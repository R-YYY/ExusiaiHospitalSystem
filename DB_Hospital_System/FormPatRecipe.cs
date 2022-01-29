using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OracleHospital;
using Sunny.UI;

namespace HospitalManagementSystem {
    public partial class FormPatRecipe : UIPage {
        readonly Functions functions;
        private readonly string patient_ID, token;
        List<RecipeInfo> recipe;

        public FormPatRecipe(string patient_tmp_ID, string tmp_token) {
            patient_ID = patient_tmp_ID;
            token = tmp_token;
            InitializeComponent();
            functions = new Functions();

            recipe = functions.getRecipe(patient_ID, token, true);
            for (int i = 0; i < recipe.Count; i++) {
                if (recipe[i].content == "无") continue;

                int j = this.dgv_recipe.Rows.Count;
                this.dgv_recipe.Rows.Add();
                this.dgv_recipe.Rows[j].Cells[1].Value = recipe[i].Recipe_ID;
                this.dgv_recipe.Rows[j].Cells[2].Value = recipe[i].Doctor_ID;
                this.dgv_recipe.Rows[j].Cells[3].Value = recipe[i].recipe_date;
                this.dgv_recipe.Rows[j].Cells[4].Value = recipe[i].content;
            }
        }
        private void dgv_recipe_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            if (e.RowIndex == -1) return;
            string action = dgv_recipe.Columns[e.ColumnIndex].Name;
            switch (action) {
                case "getDrug":
                    string recipes_ID = dgv_recipe.SelectedCells[1].Value.ToString();
                    List<DrugsinRecipe> l = functions.getDrugsinRecipe(recipes_ID);
                    FormPatSubDetailedInformation subFrom = new FormPatSubDetailedInformation(l);
                    subFrom.Show();
                    break;
                default:
                    break;
            }
        }

        private void button_Flush_Click(object sender, EventArgs e) {

            recipe.Clear();
            while (dgv_recipe.Rows.Count != 0)
                dgv_recipe.Rows.RemoveAt(0);
            recipe = functions.getRecipe(patient_ID, token, true);

            for (int i = 0; i < recipe.Count; i++) {
                if (recipe[i].state == "unfinish") continue;

                int j = this.dgv_recipe.Rows.Count;
                this.dgv_recipe.Rows.Add();
                this.dgv_recipe.Rows[j].Cells[1].Value = recipe[i].Recipe_ID;
                this.dgv_recipe.Rows[j].Cells[2].Value = recipe[i].Doctor_ID;
                this.dgv_recipe.Rows[j].Cells[3].Value = recipe[i].recipe_date;
                this.dgv_recipe.Rows[j].Cells[4].Value = recipe[i].content;
            }
        }

    }
}