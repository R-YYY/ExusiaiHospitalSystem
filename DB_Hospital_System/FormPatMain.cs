using Sunny.UI;
using System;
using System.Windows.Forms;

namespace HospitalManagementSystem {
    public partial class FormPatMain : UIHeaderAsideMainFrame {
        private string patient_ID, token;
        public FormPatMain(string pat_ID, string tokentmp) {
            patient_ID = pat_ID;
            token = tokentmp;
            InitializeComponent();

            uiLabel2.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer1.Start();

            int pageIndex = 1000;
            UIPage page = AddPage(new FormPatInfo(patient_ID, token), pageIndex);
            TreeNode treeNode = Aside.CreateNode(page, pageIndex + 10000, pageIndex);
            treeNode.Text = "个人信息";
            Aside.SetNodeItem(treeNode, new NavMenuItem(page));



            pageIndex = 2000;
            // Aside创建Controls节点，并给对应的page标号为pageIndex
            // FMain1需要继承UIPage或者 UITitlePage
            // 将Aside和指定的Main对应关联
            //TreeNode treeNode = new TreeNode();
            page = AddPage(new FormPatReg(patient_ID, token), pageIndex);
            treeNode = Aside.CreateNode(page, pageIndex + 10000, pageIndex);
            treeNode.Text = "挂号";
            // 需要将修改后的TreeNode重新装入
            Aside.SetNodeItem(treeNode, new NavMenuItem(page));

            pageIndex = 3000;
            // Aside创建Controls节点，并给对应的page标号为pageIndex
            page = AddPage(new FormPatMyReg(patient_ID, token), pageIndex);
            treeNode = Aside.CreateNode(page, pageIndex + 10000, pageIndex);
            treeNode.Text = "我的挂号";
            Aside.SetNodeItem(treeNode, new NavMenuItem(page));

            pageIndex = 4000;
            page = AddPage(new FormPatMyBill(patient_ID, token), pageIndex);
            treeNode = Aside.CreateNode(page, pageIndex + 10000, pageIndex);
            treeNode.Text = "我的账单";
            Aside.SetNodeItem(treeNode, new NavMenuItem(page));

            pageIndex = 5000;
            page = AddPage(new FormPatMedicineHistory(patient_ID, token), pageIndex);
            treeNode = Aside.CreateNode(page, pageIndex + 10000, pageIndex);
            treeNode.Text = "我的病史";
            Aside.SetNodeItem(treeNode, new NavMenuItem(page));

            pageIndex = 6000;
            page = AddPage(new FormPatRecipe(patient_ID, token), pageIndex);
            treeNode = Aside.CreateNode(page, pageIndex + 10000, pageIndex);
            treeNode.Text = "我的处方";
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