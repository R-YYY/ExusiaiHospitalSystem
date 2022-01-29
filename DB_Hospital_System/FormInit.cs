using System;
using System.Windows.Forms;

namespace HospitalManagementSystem {
    public partial class FormInit : Form {
        int select_role;
        public FormInit() {
            InitializeComponent();
        }

        private void Select_Doctor(object sender, EventArgs e) {
            select_role = 0;
            this.Hide();
        }

        private void Select_Patient(object sender, EventArgs e) {
            select_role = 1;
            this.Hide();
        }
        public int Select_Result() {
            return select_role;
        }

        private void Start_Interface_Closed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        public class DoctorValue {
            public static string ID = "0";
            public static string token = "0";
        }

        public class PatientValue {
            public static string ID = "0";
            public static string token = "0";
        }

    }
}