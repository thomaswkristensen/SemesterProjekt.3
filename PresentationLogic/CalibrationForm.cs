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
using ObserverPattern;

namespace PresentationLogic
{
    public partial class CalibrationForm : Form
    {
        private IBusinessLogic _BL;
        private Calibration_DTO _calibration;
        private List<double> x;
        private HomeForm _homeForm;
        public CalibrationForm(IBusinessLogic BL, FilterContainer filterContainer, AnalysisContainer analysisContainer)
        {
            x = new List<double>();
            _BL = BL;
            _homeForm = new HomeForm(_BL,filterContainer,analysisContainer);
            InitializeComponent();
        }

        private void calibration_button_Click(object sender, EventArgs e)
        {

            if (P1_radioButton.Checked)
            {
                if (_BL.StartCalibration(10))
                {
                    MessageBox.Show("Kalibrering foretaget");
                }
                else MessageBox.Show("For stor afvigelse, tjek vandsøjle");
            }
            else if (P2_radioButton.Checked)
            {
                if (_BL.StartCalibration(50))
                {
                    MessageBox.Show("Kalibrering foretaget");
                }
                else MessageBox.Show("For stor afvigelse, tjek vandsøjle");
            }
            else if (P3_radioButton.Checked)
            {
                if (_BL.StartCalibration(100))
                {
                    MessageBox.Show("Kalibrering foretaget");
                }
                else MessageBox.Show("For stor afvigelse, tjek vandsøjle");
            }
        }

        private void ViewCalibration_Button_Click(object sender, EventArgs e)
        {
            
            _calibration =_BL.ViewCalibration();

            x.Add(_calibration.ZPA);
            x.Add(_calibration.P1);
            x.Add(_calibration.P2);
            x.Add(_calibration.P3);

            chart1.Series["Series1"].Points.AddXY(0, x[0]);
            chart1.Series["Series1"].Points.AddXY(10, x[1]);
            chart1.Series["Series1"].Points.AddXY(50, x[2]);
            chart1.Series["Series1"].Points.AddXY(100, x[3]);

            SlopeTextbox.Text = Convert.ToString(_calibration.Slope);
        }

        private void ChangeSlope_Button_Click(object sender, EventArgs e)
        {
            _calibration = _BL.ChangeSlope(Convert.ToDouble(SlopeTextbox.Text));
            x.Clear();
            x.Add(_calibration.ZPA);
            x.Add(_calibration.P1);
            x.Add(_calibration.P2);
            x.Add(_calibration.P3);

            chart1.Series["Series1"].Points.Clear();
            chart1.Series["Series1"].Points.AddXY(0, x[0]);
            chart1.Series["Series1"].Points.AddXY(10, x[1]);
            chart1.Series["Series1"].Points.AddXY(50, x[2]);
            chart1.Series["Series1"].Points.AddXY(100, x[3]);

        }

        private void done_button_Click(object sender, EventArgs e)
        {
            if (_BL.SaveCalibrationLogic(_calibration))
            {
                MessageBox.Show("Kalibrering gemt");
                this.Hide();
                _homeForm.Show();

            }
            else MessageBox.Show("Kalibrering ikke gemt, prøv igen");
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            _homeForm.Show();
        }
    }
}
