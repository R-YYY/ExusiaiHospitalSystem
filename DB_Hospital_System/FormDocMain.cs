using System;
using System.Windows.Forms;
using Sunny.UI;
using OracleHospital;

namespace HospitalManagementSystem {
    public partial class FormDocMain : UIHeaderAsideMainFrame {
        Functions functions = new Functions();
        private string Doctor_ID, token;

        public FormDocMain(string doc_ID, string tokentmp) {
            Doctor_ID = doc_ID;
            token = tokentmp;
            InitializeComponent();

            uiLabel2.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();

            int pageIndex = 1000;
            UIPage page = AddPage(new FormDocInfo(Doctor_ID, token), pageIndex);
            TreeNode treeNode = Aside.CreateNode(page, pageIndex + 10000, pageIndex);
            treeNode.Text = "个人信息";
            Aside.SetNodeItem(treeNode, new NavMenuItem(page));

            pageIndex = 2000;
            // Aside创建Controls节点，并给对应的page标号为pageIndex
            // FMain1需要继承UIPage或者 UITitlePage
            // 将Aside和指定的Main对应关联
            //TreeNode treeNode = new TreeNode();
            page = AddPage(new FormDocOnduty(Doctor_ID, token), pageIndex);
            treeNode = Aside.CreateNode(page, pageIndex + 10000, pageIndex);
            treeNode.Text = "值班信息";
            // 需要将修改后的TreeNode重新装入
            Aside.SetNodeItem(treeNode, new NavMenuItem(page));

            pageIndex = 3000;
            // Aside创建Controls节点，并给对应的page标号为pageIndex
            page = AddPage(new FormDocMedicine(), pageIndex);
            treeNode = Aside.CreateNode(page, pageIndex + 10000, pageIndex);
            treeNode.Text = "药品查询";
            Aside.SetNodeItem(treeNode, new NavMenuItem(page));

            pageIndex = 4000;
            page = AddPage(new FormDocRegister(Doctor_ID, token), pageIndex);
            treeNode = Aside.CreateNode(page, pageIndex + 10000, pageIndex);
            treeNode.Text = "挂号列表";
            Aside.SetNodeItem(treeNode, new NavMenuItem(page));

            pageIndex = 5000;
            page = AddPage(new FormDocSearchBed(), pageIndex);
            treeNode = Aside.CreateNode(page, pageIndex + 10000, pageIndex);
            treeNode.Text = "床位查询";
            Aside.SetNodeItem(treeNode, new NavMenuItem(page));

            pageIndex = 6000;
            page = AddPage(new FormDocAttendanceMain(Doctor_ID, token), pageIndex);
            treeNode = Aside.CreateNode(page, pageIndex + 10000, pageIndex);
            treeNode.Text = "考勤管理";
            Aside.SetNodeItem(treeNode, new NavMenuItem(page));
        }

        private void timer1_Tick(object sender, EventArgs e) {
            uiLabel2.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void button_click_doctor_logout(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}