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
    public partial class CalibrationForm : Form
    {
        private IBusinessLogic _BL;
        private Measurement_DTO _data;
        private Calibration_DTO _calibration;
        private List<double> x;
        public CalibrationForm(IBusinessLogic BL)
        {
            x = new List<double>();
            _BL = BL;
            InitializeComponent();
        }

        private void calibration_button_Click(object sender, EventArgs e)
        {
            _data = new Measurement_DTO();

            if (P1_radioButton.Checked)
            {
                _BL.StartCalibration(_data.RawData, 10);
            }
            else if (P2_radioButton.Checked)
            {
                _BL.StartCalibration(_data.RawData, 50);
            }
            else if (P3_radioButton.Checked)
            {
                _BL.StartCalibration(_data.RawData, 100);
            }
        }

        private void ViewCalibration_Button_Click(object sender, EventArgs e)
        {
            _calibration =_BL.ViewCalibration();

            x.Add(_calibration.ZPA);
            x.Add(_calibration.P1);
            x.Add(_calibration.P2);
            x.Add(_calibration.P3);

            for (int i = 0; i < x.Count; i++)
            {
                chart1.Series["Series1"].Points.AddY(x[i]);
            }

            SlopeTextbox.Text = Convert.ToString(_calibration.Slope);
        }

        private void ChangeSlope_Button_Click(object sender, EventArgs e)
        {
            _calibration = _BL.ChangeSlope(Convert.ToDouble(SlopeTextbox));

            x.Add(_calibration.ZPA);
            x.Add(_calibration.P1);
            x.Add(_calibration.P2);
            x.Add(_calibration.P3);

            for (int i = 0; i < x.Count; i++)
            {
                chart1.Series["Series1"].Points.AddY(x[i]);
            }
        }

        private void done_button_Click(object sender, EventArgs e)
        {

        }
    }
}
