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
        private HomeForm _homeForm;
        private IBusinessLogic _BL;
        private string _employeeID;
        private Measurement_DTO _measurementDTO;
        private int _counter;
        public SSNForm(HomeForm homeForm, IBusinessLogic BL, string employeeID, Measurement_DTO measurementDTO)
        {
            InitializeComponent();
            _homeForm = homeForm;
            _BL = BL;
            _employeeID = employeeID;
            _measurementDTO = measurementDTO;
            _counter = 0;

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            
            bool save = _BL.SaveMeasurementBusiness(_measurementDTO, SSN_textBox.Text, employeeID_textBox.Text);
            if (save)
            {
                if (DialogResult.OK == MessageBox.Show("Data gemt"))
                {
                    this.Hide();
                    _homeForm.Show();
                }
                
            }
            else if (!save)
            {
                if (_counter < 2)
                {
                    MessageBox.Show("Gem mislykkedes");
                    _counter++;
                }
                else if (_counter == 2)
                {
                    if (DialogResult.OK == MessageBox.Show("Problemer med at gemme.\r\nDu vises tilbage til hovedvinduet"))
                    {
                        this.Hide();
                        _homeForm.Show();
                    }
                }
            }
            
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
            else
            {
                name_textBox.Clear();
                age_textBox.Clear();
                employeeID_textBox.Clear();
                save_button.Enabled = false;
                MessageBox.Show("Patient ikke fundet");
            }
        }
    }
}
