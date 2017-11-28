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
    public partial class LimitValuesForm : Form
    {
        private IBusinessLogic _BL;
        private Alarm_DTO _alarmDTO;
        public LimitValuesForm(IBusinessLogic BL)
        {
            InitializeComponent();

            _BL = BL;
            _alarmDTO = new Alarm_DTO();
        }

        private void button_OK_LV_Click(object sender, EventArgs e)
        {
            _alarmDTO.SysUpper = Convert.ToInt32(textBox_upperSystolicLimit.Text);
            _alarmDTO.SysLower = Convert.ToInt32(textBox_lowerSystolic.Text);
            _alarmDTO.DiaUpper = Convert.ToInt32(textBox_upperDiastolicLimit.Text);
            _alarmDTO.DiaLower = Convert.ToInt32(textBox_lowerDiastolic.Text);
            _alarmDTO.PulsUpper = Convert.ToInt32(textBox_upperPuls.Text);
            _alarmDTO.PulsLower = Convert.ToInt32(textBox_lowerPuls.Text);

            
            if (_BL.SetAlarmLimitsBusiness(_alarmDTO))
            {
                MessageBox.Show("Grænser er nu sat");
            }
            else MessageBox.Show("Fejl, prøv igen");



        }
    }
}
