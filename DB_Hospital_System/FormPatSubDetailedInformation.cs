using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OracleHospital;

namespace HospitalManagementSystem {
    public partial class FormPatSubDetailedInformation : Form {
        private List<string> takeMedicine;  //药品id列表
        private List<DrugInfo> DrugInfos;  //药品信息列表

        public FormPatSubDetailedInformation(List<DrugsinRecipe> L) {
            //初始化
            takeMedicine = new List<string>();
            DrugInfos = new List<DrugInfo>();
            foreach(DrugsinRecipe i in L) {
                takeMedicine.Add(i.medicine_ID);
            }

            InitializeComponent();

            //查找所有药品信息
            Functions funcs = new Functions();
            List<DrugInfo> drugInfos_tmp = funcs.GetDrugInfo();

            //记录查询药品信息
            foreach (string d_id in takeMedicine) {
                DrugInfo di = new DrugInfo();
                di = drugInfos_tmp.Find(delegate (DrugInfo drug) { return drug.ID == d_id; });
                DrugInfos.Add(di);
            }

            //下拉框添加内容
            for (int i = 0; i < DrugInfos.Count; i++)
                uiComboBox_Medicine.Items.Add(DrugInfos[i].name);
            if (uiComboBox_Medicine.Items.Count != 0) uiComboBox_Medicine.SelectedIndex = 0;
        }

        private void uiComboBox_Medicine_SelectedIndexChanged(object sender, EventArgs e) {
            //显示下拉框选中药品的信息
            uiTextBox_Life.Text = DrugInfos[uiComboBox_Medicine.SelectedIndex].shelf_life.ToString() + "月";
            uiTextBox_Usage.Text = DrugInfos[uiComboBox_Medicine.SelectedIndex].usage;
            uiRichTextBox_Intro.Text = DrugInfos[uiComboBox_Medicine.SelectedIndex].function;
            uiTextBox_Date.Text = DrugInfos[uiComboBox_Medicine.SelectedIndex].date.ToString();
        }
    }
}