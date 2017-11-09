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

namespace PresentationLogic
{
    public partial class HomeForm : Form
    {
        private LogInForm Login;
        private IBusinessLogic _BL;
        public HomeForm(IBusinessLogic BL)
        {
            _BL = BL;
            InitializeComponent();
        }

        private void Save_button_HomeForm_Click(object sender, EventArgs e)
        {
            Login.Show();
            
        }
    }
}
