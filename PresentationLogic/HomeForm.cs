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
        private bool _alarm;
        private FilterContainer _filterContainer;
        private AnalysisContainer _analysisContainer;
        private Timer _alarmTimer;
       

        public HomeForm(IBusinessLogic BL, FilterContainer filterContainer, AnalysisContainer analysisContainer)
        {
            _BL = BL;
            
            _digitalFilter = false;
            _alarm = false;
            _alarmTimer = new Timer();
            _alarmTimer.Interval = (10 * 1000);
            _alarmTimer.Tick += new EventHandler(timer1_Tick);
            _filterContainer = filterContainer;
            _filterContainer.Attach(this);
            _analysisContainer = analysisContainer;
            _analysisContainer.Attach(this);
            _data = new Measurement_DTO();
            InitializeComponent();

            Bloodpressure_chart_Homeform.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            Bloodpressure_chart_Homeform.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }


        private void Save_button_HomeForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            _data.ConvertedData = _filterContainer.GetSlidingWindow();
            _data.Fsample = 1000;
            _data.TimeOfMeasurement = DateTime.Now;
            Login = new LogInForm(_BL, _data,_filterContainer,_analysisContainer);
            Login.Show();
        }

        private void ZeroPointAdjusment_button_HomeForm_Click(object sender, EventArgs e)
        {
            _BL.StartZPA();
            MessageBox.Show("Nulpunktsjustering foretaget");
        }

        private void Calibration_button_HomeForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calibration = new CalibrationForm(_BL,_filterContainer,_analysisContainer);
            Calibration.Show();
        }

        private void Digital_Button_HomeForm_Click(object sender, EventArgs e)
        {
            _BL.UseDigitalFilterBL();

            if (!_digitalFilter)
            {
                label_FilterType.Text = "Digitalt filter: Til";
                _digitalFilter = true;
            }
            else
            {
                label_FilterType.Text = "Digitalt filter: Fra";
             
                _digitalFilter = false;
            }
            
        }

        private void button_alarmtone_Click(object sender, EventArgs e)
        {
            _BL.StopAlarmTone();
            Alarmtone_label.Text = "Alarmtone: Fra";
        }

        private void button_alarm_Click(object sender, EventArgs e)
        {
            if (!_alarm)
            {
                _BL.StopAlarm();
                _alarmTimer.Start();
                Alarm_label.Text = "Alarm: Fra";
                _alarm = true;
            }
            else
            {
                _BL.StartAlarm();
                _alarmTimer.Stop();
                Alarm_label.Text = "Alarm: Til";
                _alarm = false;
                Alarmtone_label.Text = "Alarmtone:";
            }
            



        }

        private void button_setLimitValues_Click(object sender, EventArgs e)
        {
            this.Hide();
            Limitvalues = new LimitValuesForm(_BL, _filterContainer, _analysisContainer);
            Limitvalues.Show();
        }

        private void Start_button_HomeForm_Click(object sender, EventArgs e)
        {
            Save_button_HomeForm.Enabled = false;
            stop_button.Enabled = true;
            Digital_Button_HomeForm.Enabled = true;
            button_alarm.Enabled = true;
            button_alarmtone.Enabled = true;
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
                BeginInvoke(new Action(() => AnalysisUpdate()));
            }
            else
            {
                HealthValues_DTO hvDTO = _analysisContainer.GetHealthValues();
                Systolic_textBox_HomeForm.Text = Math.Round(hvDTO.SysBP,2) + "/" +Math.Round(hvDTO.DiaBP,2);
                Average_textBox_HomeForm.Text = hvDTO.AverageBP.ToString();
                Puls_textBox_HomeForm.Text = hvDTO.HeartRate.ToString();
                if (hvDTO.Alarm)
                {
                    Alarm_button.BackColor = Color.Red;
                    
                }
                else Alarm_button.BackColor = Color.Black;
            }

        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            _BL.StopMeasuringBL();
            Save_button_HomeForm.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _alarmTimer.Stop();
            _BL.StartAlarm();
            Alarm_label.Text = "Alarm: Til";
            _alarm = false;
        }
    }
}
