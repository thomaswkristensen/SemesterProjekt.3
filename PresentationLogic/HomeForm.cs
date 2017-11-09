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
    public partial class HomeForm : Form
    {
        private LogInForm Login;
        private IBusinessLogic _BL;
        private Measurement_DTO _data;
        public HomeForm(IBusinessLogic BL)
        {
            _BL = BL;
            InitializeComponent();
        }

        private void Save_button_HomeForm_Click(object sender, EventArgs e)
        {
            Login.Show();
            
        }

        private void ZeroPointAdjusment_button_HomeForm_Click(object sender, EventArgs e)
        {
            _data = new Measurement_DTO();
            _BL.ZeroAdjust(_data.RawData);
        }
    }
}
