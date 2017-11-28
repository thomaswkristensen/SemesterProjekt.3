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
        private CalibrationForm Calibration;
        private LimitValuesForm Limitvalues;
        private IBusinessLogic _BL;
        private Measurement_DTO _data;
        private bool _digitalFilter;

        public HomeForm(IBusinessLogic BL)
        {
            _BL = BL;
            _digitalFilter = false;
            InitializeComponent();
        }

        private void Save_button_HomeForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login = new LogInForm(_BL, _data);
            Login.Show();
        }

        private void ZeroPointAdjusment_button_HomeForm_Click(object sender, EventArgs e)
        {
            _data = new Measurement_DTO();
            _BL.StartZPA(_data.RawData);
        }

        private void Calibration_button_HomeForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calibration = new CalibrationForm(_BL);
            Calibration.Show();
        }

        private void Digital_Button_HomeForm_Click(object sender, EventArgs e)
        {
            if (!_digitalFilter)
            {
                label_FilterType.Text = "Digitalt filter: Til";
                _BL.UseDigitalFilter();
                _digitalFilter = true;
            }
            else
            {
                label_FilterType.Text = "Digitalt filter: Fra";
                //RawFilterMethod
                _digitalFilter = false;
            }
            
        }

        private void button_alarmtone_Click(object sender, EventArgs e)
        {

        }

        private void button_alarm_Click(object sender, EventArgs e)
        {

        }

        private void button_setLimitValues_Click(object sender, EventArgs e)
        {
            this.Hide();
            Limitvalues = new LimitValuesForm(_BL);
            Limitvalues.Show();
        }

        private void Start_button_HomeForm_Click(object sender, EventArgs e)
        {
            _BL.StartMeasuring();
        }
    }
}
