﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;

namespace PresentationLogic
{
    public partial class LogInForm : Form
    {
        private HomeForm _homeForm;
        private SSNForm _SSNForm;
        private LogInForm _loginForm;
        private IBusinessLogic _BL;

        public LogInForm(IBusinessLogic BL)
        {
            _BL = BL;
            InitializeComponent();
        }

        private void Login_button_LogInForm_Click(object sender, EventArgs e)
        {

            this.Hide();
            _SSNForm.Show();
        }

        private void Cancel_button_LogInForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            _homeForm.Show();
        }
    }
}
