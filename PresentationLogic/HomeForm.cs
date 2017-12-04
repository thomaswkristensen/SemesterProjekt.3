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
using ObserverPattern;

namespace PresentationLogic
{
    public partial class HomeForm : Form, IFilterObserver, IAnalysisObserver
    {
        private LogInForm Login;
        private CalibrationForm Calibration;
        private LimitValuesForm Limitvalues;
        private IBusinessLogic _BL;
        private Measurement_DTO _data;
        private bool _digitalFilter;
        private FilterContainer _filterContainer;
        private AnalysisContainer _analysisContainer;
       

        public HomeForm(IBusinessLogic BL, FilterContainer filterContainer, AnalysisContainer analysisContainer)
        {
            _BL = BL;
            
            _digitalFilter = false;
            _filterContainer = filterContainer;
            _filterContainer.Attach(this);
            _analysisContainer = analysisContainer;
            _analysisContainer.Attach(this);
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
            _BL.StartZPA();
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
            
           _BL.StartMeasuringBL();
        }

        public void FilterUpdate()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => FilterUpdate()));
            }
            else
            {
                List<double> list = _filterContainer.GetSlidingWindow();
                int x = 0;
                Bloodpressure_chart_Homeform.Series["Blodtryk"].Points.Clear();
                for (int i = 0; i < list.Count; i++)
                {
                    Bloodpressure_chart_Homeform.Series["Blodtryk"].Points.AddXY(x, list[i]);
                    x++;
                }
            }

        }

        public void AnalysisUpdate()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => Update()));
            }
            else
            {
                HealthValues_DTO hvDTO = _analysisContainer.GetHealthValues();
                Systolic_textBox_HomeForm.Text = hvDTO.SysBP.ToString();
                Diastolic_textBox_HomeForm.Text = hvDTO.DiaBP.ToString();
                Average_textBox_HomeForm.Text = hvDTO.AverageBP.ToString();
                Puls_textBox_HomeForm.Text = hvDTO.HeartRate.ToString();
            }

        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            _BL.StopMeasuringBL();
        }
    }
}
