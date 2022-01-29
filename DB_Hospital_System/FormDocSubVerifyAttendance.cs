using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Device.Location;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using Newtonsoft.Json;
using OracleHospital;

namespace HospitalManagementSystem {

    //第一步：声明一个委托
    public delegate void setLabel2Value(string label2Value);
    //设置考勤主界面“未完成”或“已完成”

    //第一步：声明一个委托
    public delegate void setButton1Value(string Button1Value);
    //设置考勤主界面“点击此处考勤”或“今日考勤已完成”

    public partial class FormDocSubVerifyAttendance : Form {
        private string Doctor_ID;
        private string token;
        Functions myFunctions = new Functions();

        //返回电脑所在位置的经度和纬度
        GeoCoordinateWatcher watcher;    

        //第二步：声明一个委托类型的事件
        public event setLabel2Value setFormLabel2Value;

        //第二步：声明一个委托类型的事件
        public event setButton1Value setFormButton1Value;

        public FormDocSubVerifyAttendance(string ID, string tok) {
            Doctor_ID = ID;
            token = tok;
            InitializeComponent();
        }

        private void VerifyAttendanceForm_Load(object sender, EventArgs e) {

            uiLabel6.Text = Doctor_ID;
            //获得所有的医生信息
            var intro = myFunctions.getDoctorIntro();      
            //找到ID为Doctor_ID的医生信息
            var result = intro.Find(delegate (DoctorInfo info) { return info.ID == Doctor_ID; });
            uiLabel7.Text = result.name;

            uiLabel8.Text = DateTime.Now.ToString("yyyy-MM-dd");//考勤日期

            if (watcher == null) {
                watcher = new GeoCoordinateWatcher();
            }
            watcher.MovementThreshold = 20;//检查位置移动的最小距离为20米
            watcher.PositionChanged += 
                new EventHandler<GeoPositionChangedEventArgs<GeoCoordinate>>(
                    watcher_PositionChanged);
            watcher.Start();
        }

        private void watcher_PositionChanged(object sender, 
            GeoPositionChangedEventArgs<GeoCoordinate> e) {
            string latitude = e.Position.Location.Latitude.ToString();
            string longitude = e.Position.Location.Longitude.ToString();
            //location=经度，纬度
            string location = longitude + "," + latitude;
            //调用函数，获得具体地址，数据格式为JSON         
            string myposition = ProgramHttpGetHelper.GaoDeAnalysis(    
                "key=d8440a22fb3fc04b72a61aa6b51902a2&location=" + location);
            //在高德地图上申请的Key
            //uiLabel9.Text = myposition;//解析结果赋给“位置”文本框
            PositionInfo user = (PositionInfo)JsonConvert.DeserializeObject(
                myposition, typeof(PositionInfo));
            //把JSON格式转化为PositionInfo
            uiLabel9.Text = user.regeocode.formatted_address;
            //结构化地址信息，包括：省份＋城市＋区县＋城镇＋乡村＋街道＋门牌号码
            uiLabel9.ForeColor = Color.Black;
        }

        private void uiButton1_Click(object sender, EventArgs e) {
            if (uiLabel9.Text == "定位中") {
                MessageBox.Show(
                    "正在定位中，请勿提交！", "提示", MessageBoxButtons.OK);
                return;
            }
            //验证打卡地点是否在考勤范围内
            //若在考勤范围内，则打卡成功

            if (uiLabel9.Text.IndexOf("上海市嘉定区") != -1) {
                //验证考勤时间，默认上班时间为8:00AM，若超过8点则认为迟到             

                if (string.Compare(DateTime.Now.ToString("T"), "08:00:00") > 0) {
                    MessageBox.Show("考勤迟到！", "提示", MessageBoxButtons.OK);
                    myFunctions.clockin(Doctor_ID, token, "迟到");
                    this.Close();
                }
                else {
                    MessageBox.Show("考勤成功！", "提示", MessageBoxButtons.OK);
                    myFunctions.clockin(Doctor_ID, token, "出勤");
                    this.Close();
                }
                //考勤主界面的今日考勤改为“已完成”
                //第三步：准备相关数据
                setFormLabel2Value("已完成");
                setFormButton1Value("今日考勤已完成");
            }

            //若不在考勤范围内，则打卡失败
            else {
                MessageBox.Show(
                    "您不在考勤范围内，无法考勤！", "提示", MessageBoxButtons.OK);
                this.Close();

                //考勤主页面的今日考勤为“未完成”
                setFormLabel2Value("未完成");
                setFormButton1Value("点击此处考勤");
            }
        }
    }

    public class PositionInfo {
        public string status;
        public string info;
        public string infocode;
        public regeocode regeocode;
    }
    public class regeocode {
        public string formatted_address;
    }

}