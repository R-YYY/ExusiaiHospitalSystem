using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace OracleHospital {
    public struct BillInfo {
        public string Bill_ID;
        public string Patient_ID;
        public float fee;
        public DateTime date;
        public string state;
    }
    public struct OndutyInfo {
        public string doctor_ID;
        public DateTime onduty_date;
        public string dept_name;
        public string state;
    }

    public struct SigninResult {
        public bool success;    //登录成功或失败
        public string ID;       //若失败，这一项为空
        public string result;   //若失败, -1表示不存在用户名，-2表示密码不正确(注意类型是string)
                                //若成功，这一项表示token(相当于password)
    }

    public struct PatientInfo {
        public string ID;
        public string name;
        public string sex;
        public int age;
        public string phone_num;
        public string password;
        public string ward_ID;
        public string MedicalHistory;
        public string ImageUrl;
        public float balance;
    }

    public struct WardInfo {
        public string Ward_ID;
        public string dept_name;
        public int bed_amount;
        public int free_bed_amount;
    }

    public struct DoctorInfo {
        public string ID;
        public string name;
        public string dept_name;
        public string title;
        public string sex;
        public int age;
        public string phone_num;
        public string password;
        public string introduction;
        public string ImageUrl;
    }

    public struct DrugInfo {
        public string ID;
        public string name;
        public int stock;
        public Decimal price;
        public int shelf_life;
        public DateTime date;
        public string usage;
        public string function;
    }

    public struct RegistationInfo {
        public string Window_ID;
        public string Doctor_ID;
    }

    public struct RegisterInfo {
        public DateTime time;
        public string Patient_ID;
        public string Window_ID;
    }

    public struct RecipeInfo {
        public string Recipe_ID;
        public string Doctor_ID;
        public string Patient_ID;
        public string content;
        public DateTime recipe_date;
        public string state;
    }

    public struct AttendenceInfo {
        public int day;
        public string state; //出勤、缺勤、请假
    }

    public struct DrugsinRecipe {
        public string medicine_ID;
        public int count;
    }

    /***************************************************************************
     类名称：Basic
     功  能：存放基本函数和通用函数
     说  明：
   ***************************************************************************/
    class Basic {
        private OracleConnection con;
        private OracleCommand cmd;
        private OracleDataReader reader;

        //构造函数，连接数据库
        public Basic() {
            con = new OracleConnection(GetConnectionString());
            cmd = con.CreateCommand();
            try {
                con.Open();
                Console.WriteLine("Successfully connected to Oracle Database");
                Console.WriteLine();
            }
            catch (Exception ex)    //登录失败
            {
                Console.WriteLine(ex.Message);
            }
        }

        //返回登录oracle所需的信息
        private string GetConnectionString() {
            string user = "HOSPITAL";
            string pwd = "password";
            string db = "101.133.237.83:1521/xe";
            string conStringUser = "User Id=" + user + ";" +
                "Password=" + pwd + ";Data Source=" + db + ";";
            return conStringUser;
        }

        //输入SQL语句，返回查询结果
        public OracleDataReader SendQuery(string s, List<object> para) {
            cmd.CommandText = s;
            cmd.Parameters.Clear();
            string place;
            for (int i = 0; i < para.Count; i++) {
                place = ":" + (char)('a' + i);
                cmd.Parameters.Add(new OracleParameter(place, para[i]));
            }
            reader = cmd.ExecuteReader();
            return reader;
        }

        //输入SQL语句，进行增删改
        public int SendModify(string s, List<object> para) {
            OracleTransaction Trans;
            Trans = con.BeginTransaction(IsolationLevel.ReadCommitted);
            cmd.Transaction = Trans;
            cmd.CommandText = s;
            cmd.Parameters.Clear();
            string place;
            for (int i = 0; i < para.Count; i++) {
                place = ":" + (char)('a' + i);
                cmd.Parameters.Add(new OracleParameter(place, para[i]));
            }
            int result = cmd.ExecuteNonQuery();
            Trans.Commit();
            return result;
        }

        //对password进行加密再传输给前端，防止用户以其他人的身份调用参数
        public string PasswordtoToken(string password) {
            string token = "";
            for (int i = 0; i < password.Length; i++) {
                int ch = password[i];
                if (ch < 10)
                    token += "00" + ch.ToString();
                else if (ch < 100)
                    token += "0" + ch.ToString();
                else
                    token += ch.ToString();
            }   //把密码的每一位转成ascii码对应的数字，再变成三位字符串.如bcd变成098099100
            return token;
        }

        //把token转换成password
        public string TokentoPassword(string token) {
            string password = "";
            int i = 0, len = token.Length;
            while (i < len) {
                int ch = 0;
                for (int j = 0; j < 3; j++) {
                    if (i + j < len)
                        ch = ch * 10 + token[i + j] - '0';
                }
                password += (char)ch;
                i += 3;
            }
            return password;
        }
    }

    /***************************************************************************
     类名称：Functions
     功  能：存放与前端交互的函数
     说  明：参照"数据库表.xlsx"中的"功能API"
    ***************************************************************************/

    class Functions {
        private Basic basic;
        public Functions() {
            basic = new Basic();
        }
        /***************************************************************************
            以下是private函数
        ***************************************************************************/
        //医生查看病人病史和病人自己查看病史公用这个函数
        private string History(string Patient_ID) {

            string CommandText = "Select medical_history from patient where Patient_ID = :a";
            List<object> para = new List<object>();
            para.Add(Patient_ID);
            OracleDataReader reader = basic.SendQuery(CommandText, para);
            if (reader.Read()) {
                return reader.GetString(0);
            }
            return null;
        }

        //所有需要密钥的函数都要先再次登录，确保是本人操作
        private bool Signin(string ID, string token, bool Patient) {
            string pass = basic.TokentoPassword(token);
            SigninResult signin;
            if (Patient)
                signin = PatientSignin(ID, pass);
            else
                signin = DoctorSignin(ID, pass);
            return signin.success;
        }


        /***************************************************************************
            以下是api功能
        ***************************************************************************/


        /***************************************************************************
        函数名称：1.PatientSignin
        功    能：用户登录
        说    明：返回SigninResult
        ***************************************************************************/
        public SigninResult PatientSignin(string ID, string password) {
            //ID既可以是Patient_ID,也可以是phone_num

            SigninResult result;
            string CommandText = "Select phone_num, password, Patient_ID From PATIENT";
            List<object> para = new List<object>();
            OracleDataReader reader = basic.SendQuery(CommandText, para);

            while (reader.Read()) {
                //每次读一个元组
                if (reader.GetString(0) == ID || reader.GetString(2) == ID) {
                    //  GetString表示需要读的数据类型
                    if (reader.GetString(1) == password) {
                        //登录成功
                        result.success = true;
                        result.ID = reader.GetString(2);
                        result.result = basic.PasswordtoToken(password);
                        reader.Dispose();
                        return result;
                    }
                    else {
                        //密码错误
                        result.success = false;
                        result.ID = "";
                        result.result = "-2";
                        reader.Dispose();
                        return result;
                    }
                }
            }
            //用户不存在
            result.success = false;
            result.ID = "";
            result.result = "-1";
            reader.Dispose();
            return result;
        }



        /***************************************************************************
        函数名称：2.PatientSignup
        功    能：检验是否重复注册，并在Patient表中插入一个元组
        说    明：若成功返回ID，失败返回0
        ***************************************************************************/
        public string PatientSignup(PatientInfo patient) {
            SigninResult testsign = PatientSignin(patient.phone_num, patient.password);
            if (testsign.success || testsign.result == "-2")    //存在该用户
            {
                return "-1";
            }

            Random ran = new Random();
            int Key = ran.Next(100000, 999999);
            while (true) {
                testsign = PatientSignin(Key.ToString(), patient.password);
                if (testsign.success || testsign.result == "-2")    //随机数出现重复则重新生成ID
                {
                    Key = (Key + 1);
                    if (Key == 1000000)
                        Key = 100000;
                }
                else {
                    break;
                }
            }
            if (patient.ward_ID == null)
                patient.ward_ID = "";
            if (patient.MedicalHistory == null)
                patient.MedicalHistory = "";

            string CmdText = "Insert into Patient(Patient_ID,Name,Sex,Age," +
                "Phone_num,password,Ward_ID,Medical_History,ImageUrl,balance) " +
                "values (:a,:b,:c,:d,:e,:f,'0','无',' ',0)";
            List<object> para = new List<object>();
            para.Add(Key.ToString());
            para.Add(patient.name);
            para.Add(patient.sex);
            para.Add(patient.age);
            para.Add(patient.phone_num);
            para.Add(patient.password);
            int result = basic.SendModify(CmdText, para);
            if (result == 1)
                return Key.ToString();
            else
                return "0";
        }


        /***************************************************************************
        函数名称：3.Registration
        功    能：在register表和recipe表中各插入一个元组
        说    明：患者挂号
        ***************************************************************************/
        public int Registration(string patient_ID, string token, string window_ID, string doctor_ID) {

            if (!Signin(patient_ID, token, true))
                return 0;
            //检查该病人当天是否有已经挂了该医生的号且没有去看病
            string CmdText = 
                "Select recipe_date, state from recipe where doctor_ID = :a and Patient_ID = :b";
            List<object> para = new List<object>();
            para.Add(doctor_ID);
            para.Add(patient_ID);
            OracleDataReader reader = basic.SendQuery(CmdText, para);
            var now = DateTime.Now;
            while (reader.Read()) {
                if (reader.GetString(1) == "unfinished") {
                    var time = reader.GetDateTime(0);
                    if (now.Year == time.Year && now.Month == time.Month && now.Day == time.Day)
                        return 0;
                }
            }

            DateTime dateTime = DateTime.Now;
            CmdText = "Insert into register(time,Patient_ID,window_ID) values (:a,:b,:c)";
            para.Clear();
            para.Add(dateTime);
            para.Add(patient_ID);
            para.Add(window_ID);
            int result = basic.SendModify(CmdText, para);
            if (result == 0)
                return 0;

            Random ran = new Random();
            int Key = ran.Next(10000, 99999);
            while (true) {
                CmdText = 
                    "Insert into recipe(Recipe_ID,doctor_ID,patient_ID,content,recipe_date,state) " +
                    "values (:a,:b,:c,'无',:d,'unfinished')";
                para.Clear();
                para.Add(Key.ToString());
                para.Add(doctor_ID);
                para.Add(patient_ID);
                para.Add(dateTime);
                result = basic.SendModify(CmdText, para);
                if (result == 0) {
                    Key += 1;
                    if (Key == 100000)
                        Key = 10000;
                }
                else
                    break;
            }
            return result;
        }
        /***************************************************************************
        函数名称：4.getRegisters
        功    能：获取Register信息
        说    明：返回用户ID所有的register表信息
        ***************************************************************************/
        public List<RegisterInfo> getRegisters(string patient_ID, string token) {
            if (!Signin(patient_ID, token, true))
                return null;
            var registerInfos = new List<RegisterInfo>();
            string CommandText = "Select * from register where Patient_ID = :a";
            List<object> para = new List<object>();
            para.Add(patient_ID);
            OracleDataReader reader = basic.SendQuery(CommandText, para);
            int i = 0;
            while (reader.Read())   //每次读一个元组
            {
                RegisterInfo registerInfo = new RegisterInfo();
                registerInfo.time = reader.GetDateTime(0);
                registerInfo.Patient_ID = reader.GetString(1);
                registerInfo.Window_ID = reader.GetString(2);
                registerInfos.Add(registerInfo);
                i++;
            }
            return registerInfos;
        }

        /***************************************************************************
        函数名称：5.getDoctorIntro
        功    能：获得医生信息
        说    明：返回List<DoctorInfo>
        ***************************************************************************/
        public List<DoctorInfo> getDoctorIntro() {
            var doctorInfos = new List<DoctorInfo>();
            var newlist = doctorInfos.FindAll(delegate (DoctorInfo p) { return p.dept_name == "外科"; });
            string CommandText = "Select * from Doctor";
            List<object> para = new List<object>();
            OracleDataReader reader = basic.SendQuery(CommandText, para);
            int i = 0;
            while (reader.Read())   //每次读一个元组
            {
                DoctorInfo doctorInfo = new DoctorInfo();
                doctorInfo.ID = reader.GetString(0);
                doctorInfo.name = reader.GetString(1);
                doctorInfo.dept_name = reader.GetString(2);
                doctorInfo.title = reader.GetString(3);
                doctorInfo.sex = reader.GetString(4);
                doctorInfo.age = (int)reader.GetDecimal(5);
                doctorInfo.phone_num = reader.GetString(6);
                doctorInfo.introduction = reader.GetString(8);
                doctorInfo.ImageUrl = reader.GetString(9);
                doctorInfos.Add(doctorInfo);
                i++;
            }

            return doctorInfos;
        }

        /***************************************************************************
        函数名称：6.payBill
        功    能：更新用户的付款信息
        说    明：将state改为“已付款”
        ***************************************************************************/
        public int payBill(string patient_ID, string token, string bill_ID, float balance) {
            string pass = basic.TokentoPassword(token);
            if (Signin(patient_ID, token, true)) {
                string CommandText = 
                    "Update Bill set State='已付款' where Patient_ID= :a and Bill_ID= :b";
                List<object> para = new List<object>();
                para.Add(patient_ID);
                para.Add(bill_ID);
                int result = basic.SendModify(CommandText, para);

                if (result == 1) {
                    CommandText = "Update Patient set balance = balance - :a where Patient_ID = :b";
                    para.Clear();
                    para.Add(balance);
                    para.Add(patient_ID);
                    result = basic.SendModify(CommandText, para);
                    return result;
                }
            }
            return 0;
        }

        /********************************************************************
         函数名称：7.getBill
         功能：获取账单信息
         说明：根据Patient_ID查询相应的Bill
        ********************************************************************/
        public List<BillInfo> getBill(string patient_ID, string token) {
            List<BillInfo> billInfos = new List<BillInfo>();
            if (Signin(patient_ID, token, true)) {
                string CommandText = "Select * from BILL where Patient_ID = :a";
                List<object> para = new List<object>();
                para.Add(patient_ID);
                OracleDataReader reader = basic.SendQuery(CommandText, para);
                int i = 0;
                while (reader.Read())   //每次读一个元组
                {
                    BillInfo billInfo = new BillInfo();
                    billInfo.Bill_ID = reader.GetString(0);
                    billInfo.Patient_ID = reader.GetString(1);
                    billInfo.fee = (float)reader.GetDecimal(2);
                    billInfo.date = reader.GetDateTime(3);
                    billInfo.state = reader.GetString(4);
                    billInfos.Add(billInfo);
                    i++;
                }
            }
            return billInfos;
        }
        /***************************************************************************
        函数名称：8.getHistory
        功    能：病人获取病史
        说    明：
        ***************************************************************************/
        public string getHistory(string patient_ID, string token) {
            if (Signin(patient_ID, token, true)) {
                return History(patient_ID);
            }
            else {
                return null;
            }
        }

        /***************************************************************************
        函数名称：9.getWard
        功    能：获取所有病房信息
        说    明：
        ***************************************************************************/
        public List<WardInfo> getWard() {

            string CommandText = "Select * from ward";
            List<object> para = new List<object>();
            OracleDataReader reader = basic.SendQuery(CommandText, para);
            List<WardInfo> wardInfos = new List<WardInfo>();
            while (reader.Read()) {
                WardInfo wardInfo = new WardInfo();
                wardInfo.Ward_ID = reader.GetString(0);
                wardInfo.dept_name = reader.GetString(1);
                wardInfo.bed_amount = (int)reader.GetDecimal(2);
                wardInfo.free_bed_amount = (int)reader.GetDecimal(3);
                wardInfos.Add(wardInfo);
            }
            return wardInfos;
        }

        /***************************************************************************
       函数名称：10.1 setWard
       功  能：修改指定ward的信息
       说  明：先检查医生身份，再执行update事务
       ***************************************************************************/
        public int setWard(string doctor_ID, string token, string ward_ID, int free_bed_amount) {
            /*检查医生身份*/
            if (Signin(doctor_ID, token, false)) {
                string CommandText = "select bed_amount from ward where ward_ID = :a";
                List<object> para = new List<object>();
                para.Add(ward_ID);
                OracleDataReader reader = basic.SendQuery(CommandText, para);
                if (reader.Read()) {
                    int bed_amount = (int)reader.GetDecimal(0);
                    //三个约束：1.病房id存在  2.空床位数量>=0  3.空床位数量<=bed_amount
                    if (free_bed_amount >= 0 && free_bed_amount <= bed_amount && bed_amount > 0) {
                        CommandText = 
                            "Update ward set free_bed_amount = :a where ward_ID= :b";
                        para.Clear();
                        para.Add(free_bed_amount);
                        para.Add(ward_ID);
                        int result = basic.SendModify(CommandText, para);
                        return result;
                    }
                }
            }
            return 0;
        }

        /******************************************************
         函数名称：10.2.addWard
         功能：添加病房信息
         说明：需要检验医生身份
        ******************************************************/
        public int addWard(string doctor_ID, string token, WardInfo wardInfo) {
            if (Signin(doctor_ID, token, false)) {
                string dept_name = wardInfo.dept_name;
                int bed_amount = wardInfo.bed_amount;
                int free_bed_amount = wardInfo.free_bed_amount;
                string CommandText = "Insert into Ward values (:a,:b,:c,:d)";
                List<object> para = new List<object>();
                para.Add(wardInfo.Ward_ID);
                para.Add(wardInfo.dept_name);
                para.Add(wardInfo.bed_amount);
                para.Add(wardInfo.free_bed_amount);
                int result = basic.SendModify(CommandText, para);
                return result;
            }
            else
                return 0;
        }

        /******************************************************
         函数名称：10.3.deleteWard
         功能：删除指定ID的病房信息
         说明：需要检验医生身份
        ******************************************************/
        public int deleteWard(string doctor_ID, string token, string ward_ID) {
            if (Signin(doctor_ID, token, false)) {
                string CommandText = "delete from Ward where ward_id= :a";
                List<object> para = new List<object>();
                para.Add(ward_ID);
                int result = basic.SendModify(CommandText, para);
                return result;
            }
            else {
                return 0;
            }

        }

        /***************************************************************************
        函数名称：11.clockin
        功  能：医生打卡
        说  明：先检查医生身份，更新attendance_sheet中的state
        ***************************************************************************/
        public int clockin(string doctor_ID, string token, string state) {
            DateTime dateTime = DateTime.Now;
            /*检查医生身份和token是否正确*/
            if (Signin(doctor_ID, token, false)) {
                string CmdText = 
                    "Insert Into attendence_sheet(Doctor_ID, Attend_Date, State) values (:a,:b,:c)";
                List<object> para = new List<object>();
                para.Add(doctor_ID);
                para.Add(dateTime);
                para.Add(state);
                int result = basic.SendModify(CmdText, para);
                return result;
            }
            else
                return 0;
        }

        /***************************************************************************
        函数名称：12.DoctorSignup
        功    能：医生注册
        说    明：成功返回医生ID，失败：-2表示注册码错误，-1表示存在该用户 0表示注册失败
        ***************************************************************************/
        public string DoctorSignup(DoctorInfo doctor, string key) {
            SigninResult testsign = DoctorSignin(doctor.phone_num, doctor.password);
            if (key != "1234")
                return "-2";
            if (testsign.success || testsign.result == "-2")     //存在该用户
            {
                return "-1";
            }

            Random ran = new Random();
            int Key = ran.Next(1000, 9999);
            while (true) {
                testsign = DoctorSignin(Key.ToString(), doctor.password);
                if (testsign.success || testsign.result == "-2")    //随机数出现重复则重新生成ID
                {
                    Key = (Key + 1);
                    if (Key == 10000)
                        Key = 1000;
                }
                else {
                    break;
                }
            }

            string CmdText = 
                "Insert into Doctor(" + 
                "Doctor_ID,Name,dept_name,title,Sex,Age,Phone_num,password,introduction,ImageUrl) " + 
                "values (:a,:b,:c,:d,:e,:f,:g,:h,:i,:j)";
            List<object> para = new List<object>();
            para.Add(Key.ToString());
            para.Add(doctor.name);
            para.Add(doctor.dept_name);
            para.Add(doctor.title);
            para.Add(doctor.sex);
            para.Add(doctor.age);
            para.Add(doctor.phone_num);
            para.Add(doctor.password);
            para.Add(doctor.introduction);
            para.Add(" ");

            int result = basic.SendModify(CmdText, para);
            if (result == 1)
                return Key.ToString();
            else
                return "0";
        }
        /***************************************************************************
         函数名称：13.DoctorSignin
         功    能：医生登录
         说    明：登录结果显示在SigninResult中
        ***************************************************************************/
        public SigninResult DoctorSignin(string ID, string password) {
            //ID既可以是Doctor_ID,也可以是phone_num
            SigninResult result;
            string CommandText = "Select phone_num, password, Doctor_ID from Doctor";
            List<object> para = new List<object>();
            OracleDataReader reader = basic.SendQuery(CommandText, para);

            while (reader.Read()) {
                //每次读一个元组
                if (reader.GetString(0) == ID || reader.GetString(2) == ID) {
                    if (reader.GetString(1) == password) {
                        //登录成功
                        result.success = true;
                        result.ID = reader.GetString(2);
                        result.result = basic.PasswordtoToken(password);
                        reader.Dispose();
                        return result;
                    }
                    else {
                        //密码错误
                        result.success = false;
                        result.ID = "";
                        result.result = "-2";
                        reader.Dispose();
                        return result;
                    }
                }
            }
            result.success = false;
            result.ID = "";
            result.result = "-1";
            reader.Dispose();
            return result;
        }

        /**********************************************************************
         函数名称：14.getOnduty
         功能：返回指定日期的值班表
         说明：由传过来的Doctor_ID，token和年月日确定。
        **********************************************************************/
        public List<OndutyInfo> getOnduty(string doctor_ID, string token, int year, int month, int day) {
            var ondutyInfos = new List<OndutyInfo>();
            if (Signin(doctor_ID, token, false)) {
                string CommandText = "Select * from Onduty where Doctor_ID = :a";
                List<object> para = new List<object>();
                para.Add(doctor_ID);
                OracleDataReader reader = basic.SendQuery(CommandText, para);
                int i = 0;
                while (reader.Read()) {
                    OndutyInfo Info = new OndutyInfo();
                    Info.doctor_ID = reader.GetString(0);
                    Info.onduty_date = reader.GetDateTime(1);
                    Info.dept_name = reader.GetString(2);
                    Info.state = reader.GetString(3);
                    if (Info.onduty_date.Year == year && Info.onduty_date.Month == month && Info.onduty_date.Day == day)
                        ondutyInfos.Add(Info);
                    i++;
                }
            }
            return ondutyInfos;
        }
        /***************************************************************************
         函数名称：15.setPatientHistory
         功    能：修改对应Patient_ID的medical_history
         说    明：先检查医生身份，再执行update事务
        ***************************************************************************/
        public int setPatientHistory(string doctor_ID, string token, string patient_ID, string medical_history) {
            /*先检查医生身份*/
            if (Signin(doctor_ID, token, false)) {
                string old_history = getPatientHistory(doctor_ID, token, patient_ID);
                if (old_history == null)
                    return 0;
                else {
                    string new_history = medical_history;
                    string CommandText = "Update Patient set medical_history= :a where Patient_ID= :b";
                    List<object> para = new List<object>();
                    para.Add(new_history);
                    para.Add(patient_ID);
                    int result = basic.SendModify(CommandText, para);
                    return result;
                }
            }
            else
                return 1;
        }
        /***************************************************************************
         函数名称：16.setPatientHistory
         功    能：修改对应Patient_ID的medical_history
         说    明：先检查医生身份，再执行update事务
        ***************************************************************************/
        public string getPatientHistory(string doctor_ID, string token, string patient_ID) {
            if (Signin(doctor_ID, token, false))
                return History(patient_ID);
            else
                return null;
        }

        /***************************************************************************
         函数名称：17.setRecipe
         功  能：医生修改Recipe的content
         说  明：需要验证医生身份
        ***************************************************************************/
        public int setRecipe(string doctor_ID, string token, string recipe_ID, string content) {
            if (Signin(doctor_ID, token, false)) {
                string CommandText = "Update recipe set content= :a where recipe_ID= :b and Doctor_ID= :c";
                List<object> para = new List<object>();
                para.Add(content);
                para.Add(recipe_ID);
                para.Add(doctor_ID);
                int result = basic.SendModify(CommandText, para);
                if (result == 1) {
                    CommandText = "Update recipe set state = 'finished' where recipe_ID=:a and Doctor_ID= :b";
                    para.Clear();
                    para.Add(recipe_ID);
                    para.Add(doctor_ID);
                    result = basic.SendModify(CommandText, para);
                }
                return result;
            }
            else
                return 0;
        }

        /***************************************************************************
         函数名称：18.1 addDrugInfo
         功    能：增加药品信息
         说    明：
        ***************************************************************************/
        public int addDrugInfo(string doctor_ID, string token, DrugInfo info) {
            if (Signin(doctor_ID, token, false)) {
                string CommandText = "Insert into Medicine values (:a,:b,:c,:d,:e,:f,:g,:h)";
                List<object> para = new List<object>();
                para.Add(info.ID);
                para.Add(info.name);
                para.Add(info.stock);
                para.Add(info.price);
                para.Add(info.shelf_life);
                para.Add(info.date);
                para.Add(info.usage);
                para.Add(info.function);
                int result = basic.SendModify(CommandText, para);
                return result;
            }
            else
                return 0;
        }
        /***************************************************************************
        函数名称：18.2 setDrugInfo
        功    能：修改对应medicine_ID的信息
        说    明：无
        ***************************************************************************/
        public int setDrugInfo(string medicine_ID, DrugInfo new_info) {
            /*先检查medicine是否存在*/
            string CommandText = "Select medicine_ID from medicine where medicine_ID= :a";
            List<object> para = new List<object>();
            para.Add(medicine_ID);
            OracleDataReader reader = basic.SendQuery(CommandText, para);
            if (reader.HasRows) {
                CommandText = "Update medicine set name= :a,stock= :b,price= :c,shelf_life= :d," +
                    "usage= :e,function= :f,manufacture_date=:g " +
                    "where medicine_ID= :h";
                para.Clear();
                para.Add(new_info.name);
                para.Add(new_info.stock);
                para.Add(new_info.price);
                para.Add(new_info.shelf_life);
                para.Add(new_info.usage);
                para.Add(new_info.function);
                para.Add(new_info.date);
                para.Add(medicine_ID);
                int result = basic.SendModify(CommandText, para);
                return result;
            }
            else {
                return 0;
            }
        }
        /******************************************************
         函数名称：18.3 deleteDrugInfo
         功能：删除药品信息
         说明：由medicine_id确定药品
        ******************************************************/
        public int deleteMedicine(string medicine_ID) {
            string CommandText = "Delete from Medicine where medicine_id= :a";
            List<object> para = new List<object>();
            para.Add(medicine_ID);
            int result = basic.SendModify(CommandText, para);
            return result;
        }

        /***************************************************************************
         函数名称：19.getDrugInfo
         功    能：获取对应medicine_ID的信息
         说    明：无
        ***************************************************************************/
        public List<DrugInfo> GetDrugInfo() {
            var drugInfos = new List<DrugInfo>();
            string CommandText = "Select * from Medicine";
            List<object> para = new List<object>();
            OracleDataReader reader = basic.SendQuery(CommandText, para);
            int i = 0;
            while (reader.Read())   //每次读一个元组
            {
                DrugInfo drugInfo = new DrugInfo();
                drugInfo.ID = reader.GetString(0);
                drugInfo.name = reader.GetString(1);
                drugInfo.stock = (int)reader.GetDecimal(2);
                drugInfo.price = reader.GetDecimal(3);
                drugInfo.shelf_life = (int)reader.GetDecimal(4);
                drugInfo.date = reader.GetDateTime(5);
                drugInfo.usage = reader.GetString(6);
                drugInfo.function = reader.GetString(7);
                drugInfos.Add(drugInfo);
                i++;
            }
            return drugInfos;
        }
        /***************************************************************************
         函数名称：20.getRecipe
         功  能：获取对象的Recipe
         说  明：既可以是医生的ID，也可以是患者的ID
        ***************************************************************************/
        public List<RecipeInfo> getRecipe(string ID, string token, bool is_patient) {
            List<RecipeInfo> recipeInfos = new List<RecipeInfo>();
            if (Signin(ID, token, is_patient)) {
                RecipeInfo Info = new RecipeInfo();
                string CommandText;
                if (is_patient) {
                    CommandText = "Select * from Recipe Where Patient_ID = :a";
                }
                else {
                    CommandText = "Select * from Recipe Where Doctor_ID = :a";
                }
                List<object> para = new List<object>();
                para.Add(ID);
                OracleDataReader reader = basic.SendQuery(CommandText, para);
                while (reader.Read()) {
                    Info.Recipe_ID = reader.GetString(0);
                    Info.Doctor_ID = reader.GetString(1);
                    Info.Patient_ID = reader.GetString(2);
                    Info.content = reader.GetString(3);
                    Info.recipe_date = reader.GetDateTime(4);
                    Info.state = reader.GetString(5);
                    recipeInfos.Add(Info);
                }
            }
            return recipeInfos;
        }

        /***************************************************************************
        函数名称：21.getPatientInfo
        功    能：获取病人信息
        说    明：根据PatientID获取信息
        ***************************************************************************/
        public PatientInfo GetPatientInfo(string patient_ID) {
            PatientInfo Info = new PatientInfo();

            string CommandText = "Select * from Patient Where Patient_ID = :a";
            List<object> para = new List<object>();
            para.Add(patient_ID);
            OracleDataReader reader = basic.SendQuery(CommandText, para);
            if (reader.Read()) {
                Info.ID = reader.GetString(0);
                Info.name = reader.GetString(1);
                Info.sex = reader.GetString(2);
                Info.age = reader.GetInt32(3);
                Info.phone_num = reader.GetString(4);
                Info.password = reader.GetString(5);
                Info.ward_ID = reader.GetString(6);
                Info.MedicalHistory = reader.GetString(7);
                Info.ImageUrl = reader.GetString(8);
                Info.balance = (int)reader.GetDecimal(9);
            }
            return Info;
        }


        /***************************************************************************
        函数名称：22.setWardID
        功    能：为病人安排病房
        说    明：
        ***************************************************************************/
        public int setWardID(string doctor_ID, string token, string patient_ID, string ward_ID) {
            if (Signin(doctor_ID, token, false)) {
                string CommandText = "Update Patient set ward_ID= :a where patient_ID= :b";
                List<object> para = new List<object>();
                para.Add(ward_ID);
                para.Add(patient_ID);
                int result = basic.SendModify(CommandText, para);
                if (result == 1) {
                    CommandText = "Select Free_bed_amount from ward where ward_ID = :a";
                    para.Clear();
                    para.Add(ward_ID);
                    OracleDataReader reader = basic.SendQuery(CommandText, para);
                    if (reader.Read()) {
                        int amount = (int)reader.GetDecimal(0) - 1;
                        result = setWard(doctor_ID, token, ward_ID, amount);
                        return result;
                    }
                }
            }
            return 0;
        }

        /***************************************************************************
        函数名称：23.insertBill
        功    能：增加一个Bill记录
        说    明：
        ***************************************************************************/
        public int insertBill(string ID, string patient_ID, double fee) {
            DateTime date = DateTime.Now;
            string CmdText = "Insert into Bill (Bill_ID,Patient_ID,Fee,Time,State) " +
                "values (:a,:b,:c,:d,'未付款')";
            List<object> para = new List<object>();
            para.Add(ID.ToString());
            para.Add(patient_ID);
            para.Add(fee);
            para.Add(date);
            int result = basic.SendModify(CmdText, para);
            return result;
        }

        /***************************************************************************
        函数名称：24.getWardPatient
        功    能：获取病房下的所有病人信息
        说    明：
        ***************************************************************************/
        public List<PatientInfo> getWardPatient(string ward_ID) {
            List<PatientInfo> patientInfos = new List<PatientInfo>();
            string CommandText = "Select Patient_ID, ward_ID from PATIENT Where Ward_ID is not null";
            List<object> para = new List<object>();
            OracleDataReader reader = basic.SendQuery(CommandText, para);
            while (reader.Read()) {
                if (reader.GetString(1) == ward_ID) {
                    string patient_ID = reader.GetString(0);
                    patientInfos.Add(GetPatientInfo(patient_ID));
                }
            }
            return patientInfos;
        }

        /***************************************************************************
        函数名称：25.getAttendenceSheets
        功    能：获取制定日期考勤表信息
        说    明：根据医生ID、年、月查询当月的记录
        ***************************************************************************/
        public List<AttendenceInfo> getAttendenceSheets(string doctor_ID, string token, int year, int month) {
            var attendences = new List<AttendenceInfo>();
            if (Signin(doctor_ID, token, false)) {
                string CommandText = "Select * from attendence_sheet where Doctor_ID = :a";
                List<object> para = new List<object>();
                para.Add(doctor_ID);
                OracleDataReader reader = basic.SendQuery(CommandText, para);

                int i = 0;
                while (reader.Read()) {
                    DateTime date = reader.GetDateTime(1);
                    if (date.Year == year && date.Month == month) {
                        AttendenceInfo attendence = new AttendenceInfo();
                        attendence.day = date.Day;
                        attendence.state = reader.GetString(2);
                        attendences.Add(attendence);
                    }
                    i++;
                }
            }
            return attendences;
        }

        /***************************************************************************
        函数名称：26.addDrugsinRecipe
        功    能：往Recipe中添加药品
        说    明：
        ***************************************************************************/
        public int addDrugsinRecipe(string recipe_ID, List<string> drugs, List<int> drugscount) {
            List<object> para1 = new List<object>();
            List<object> para2 = new List<object>();
            for (int i = 0; i < drugs.Count; i++) {
                para1.Clear();
                para2.Clear();
                string CmdText1 = "Insert into take (recipe_ID,medicine_ID,count) values (:a,:b,:c)";
                string CmdText2 = "Update medicine set stock = stock - :a where medicine_ID= :b";
                para1.Add(recipe_ID);
                para1.Add(drugs[i]);
                para1.Add(drugscount[i]);
                para2.Add(drugscount[i]);
                para2.Add(drugs[i]);

                int add_result = basic.SendModify(CmdText1, para1);
                int update_result = basic.SendModify(CmdText2, para2);
                if (add_result == 0 || update_result == 0)
                    return 0;
            }
            string CommandText = "Update recipe set state = 'finished' where recipe_ID=" + recipe_ID;
            List<object> para = new List<object>();
            para.Add(recipe_ID);
            int result = basic.SendModify(CommandText, para);
            return result;
        }

        /***************************************************************************
        函数名称：27.getDrugsinRecipe
        功    能：查询指定Recipe_ID的药品信息
        说    明：
        ***************************************************************************/
        public List<DrugsinRecipe> getDrugsinRecipe(string ID) {
            string CmdText = "Select Medicine_ID, count from Take where Recipe_ID = :a";
            List<DrugsinRecipe> infos = new List<DrugsinRecipe>();
            List<object> para = new List<object>();
            para.Add(ID);
            OracleDataReader reader = basic.SendQuery(CmdText, para);
            while (reader.Read()) {
                DrugsinRecipe drugsinRecipe = new DrugsinRecipe();
                drugsinRecipe.medicine_ID = reader.GetString(0);
                drugsinRecipe.count = (int)reader.GetDecimal(1);
                infos.Add(drugsinRecipe);
            }
            return infos;
        }

        /***************************************************************************
        函数名称：28.setImage
        功    能：设置头像
        说    明：医生和患者公用这个函数
        ***************************************************************************/
        public int setImage(string ID, string token, bool is_patient, string imageurl) {
            List<object> para = new List<object>();
            para.Add(imageurl);
            para.Add(ID);
            if (Signin(ID, token, is_patient)) {
                if (is_patient) {
                    string CmdText = "Update Patient set ImageUrl = :a where Patient_ID = :b";
                    return basic.SendModify(CmdText, para);
                }
                else {
                    string CmdText = "Update Doctor set ImageUrl = :a where Doctor_ID = :b";
                    return basic.SendModify(CmdText, para);
                }
            }
            return 0;
        }
        /***************************************************************************
        函数名称：29.setPatientInfo
        功    能：修改病人个人信息
        说    明：
        ***************************************************************************/

        public int setPatientInfo(string patient_ID, string token, PatientInfo info) {
            List<object> para = new List<object>();
            para.Add(info.name);
            para.Add(info.sex);
            para.Add(info.age);
            para.Add(patient_ID);

            if (Signin(patient_ID, token, true)) {
                string CmdText = "Update Patient set name = :a, sex = :b, age =:c, " +
                    "where Patient_ID =  :d";
                int result = basic.SendModify(CmdText, para);
                return result;
            }
            return 0;
        }

        /***************************************************************************
        函数名称：30.setDoctorInfo
        功    能：修改医生个人信息
        说    明：
        ***************************************************************************/
        public int setDoctorInfo(string doctor_ID, string token, DoctorInfo info) {
            List<object> para = new List<object>();
            para.Add(info.name);
            para.Add(info.sex);
            para.Add(info.age);
            para.Add(info.dept_name);
            para.Add(info.title);
            para.Add(info.introduction);
            para.Add(doctor_ID);
            if (Signin(doctor_ID, token, false)) {
                string CmdText = "Update Doctor set name = :a,sex = :b, age = :c, " +
                    "dept_name = :d,title = :e, introduction = :f where doctor_ID = :g";
                int result = basic.SendModify(CmdText, para);
                return result;
            }
            return 0;
        }

        /***************************************************************************
        函数名称：30.setDoctorInfo
        功    能：修改医生个人信息
        说    明：
        ***************************************************************************/
        public string GetPharmacyName(string medicine_ID) {
            string CmdText = "Select pharmacy_name from pharmacy natural join store where drug_ID = :a";
            List<object> para = new List<object>();
            para.Add(medicine_ID);
            OracleDataReader reader = basic.SendQuery(CmdText, para);
            string name = "";
            if (reader.Read()) {
                name = reader.GetString(0);
            }
            return name;
        }
    }
}