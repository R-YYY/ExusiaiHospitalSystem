using OracleHospital;
using Sunny.UI;

namespace HospitalManagementSystem {
    public partial class FormPatMedicineHistory : UIPage {
        private string token, patient_ID;
        Functions functions;
        public FormPatMedicineHistory(string patient_tmp_ID, string tmp_token) {
            functions = new Functions();
            InitializeComponent();
            token = tmp_token;
            patient_ID = patient_tmp_ID;
            InitMedicineHistory(patient_ID, token);
        }
        private void InitMedicineHistory(string patient_ID, string token) {
            string medicineHistory = functions.getHistory(patient_ID, token);
            if (medicineHistory != "无")
                this.uiTextBox1.Text = medicineHistory;
        }
    }
}