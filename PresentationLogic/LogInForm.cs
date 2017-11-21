using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Interfaces;

namespace PresentationLogic
{
    public partial class LogInForm : Form
    {
        private HomeForm _homeForm;
        private SSNForm _SSNForm;
        private LogInForm _loginForm;
        private IBusinessLogic _BL;
        private Measurement_DTO _measurementDTO;

        public LogInForm(IBusinessLogic BL, Measurement_DTO measurementDTO)
        {
            _BL = BL;
            InitializeComponent();
            _measurementDTO = measurementDTO;
        }

        private void Login_button_LogInForm_Click(object sender, EventArgs e)
        {
            _SSNForm = new SSNForm(_BL, EmployeeID_textBox_LogInForm.Text, _measurementDTO);
            if (_BL.GetLogin(EmployeeID_textBox_LogInForm.Text,
                Password_textBox_LogInForm.Text))
            {
                this.Hide();
                _SSNForm.Show();
            }
            else MessageBox.Show("Login mislykkedes, prøv igen");

        }

        private void Cancel_button_LogInForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            _homeForm.Show();
        }
    }
}
