using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;
using DTO;

namespace PresentationLogic
{
    public partial class SSNForm : Form
    {
        private IBusinessLogic _BL;
        private string _employeeID;
        public SSNForm(IBusinessLogic BL, string employeeID)
        {
            InitializeComponent();
            _BL = BL;
            _employeeID = employeeID;
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            _BL.saveMeasurement();
        }

        private void information_button_Click(object sender, EventArgs e)
        {
            Patient_DTO patientDTO = _BL.GetPatientInformation(SSN_textBox.Text);
            if (patientDTO != null)
            {
                name_textBox.Text = patientDTO.FirstName + " " + patientDTO.LastName;
                age_textBox.Text = Convert.ToString(patientDTO.Age);
                employeeID_textBox.Text = _employeeID;
                save_button.Enabled = true;
            }
            else MessageBox.Show("Patient ikke fundet");
        }
    }
}
