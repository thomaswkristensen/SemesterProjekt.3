namespace PresentationLogic
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Diastolic_textBox_HomeForm = new System.Windows.Forms.TextBox();
            this.Systolic_textBox_HomeForm = new System.Windows.Forms.TextBox();
            this.Average_textBox_HomeForm = new System.Windows.Forms.TextBox();
            this.Puls_textBox_HomeForm = new System.Windows.Forms.TextBox();
            this.Diastolic_Label_HomeForm = new System.Windows.Forms.Label();
            this.Systolic_Label_HomeForm = new System.Windows.Forms.Label();
            this.Average_Label_HomeForm = new System.Windows.Forms.Label();
            this.Puls_Label_HomeForm = new System.Windows.Forms.Label();
            this.ZeroPointAdjusment_button_HomeForm = new System.Windows.Forms.Button();
            this.Start_button_HomeForm = new System.Windows.Forms.Button();
            this.Save_button_HomeForm = new System.Windows.Forms.Button();
            this.Digital_Button_HomeForm = new System.Windows.Forms.Button();
            this.Calibration_button_HomeForm = new System.Windows.Forms.Button();
            this.stop_button = new System.Windows.Forms.Button();
            this.label_FilterType = new System.Windows.Forms.Label();
            this.button_alarmtone = new System.Windows.Forms.Button();
            this.button_alarm = new System.Windows.Forms.Button();
            this.button_setLimitValues = new System.Windows.Forms.Button();
            this.Bloodpreasure_chart_Homeform = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Bloodpreasure_chart_Homeform)).BeginInit();
            this.SuspendLayout();
            // 
            // HP_Chart
            // 
            this.HP_Chart.BackColor = System.Drawing.Color.Black;
            this.HP_Chart.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea1.BorderColor = System.Drawing.Color.Blue;
            chartArea1.Name = "ChartArea1";
            this.HP_Chart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.BorderColor = System.Drawing.Color.Black;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.ForeColor = System.Drawing.Color.Lime;
            legend1.Name = "Legend1";
            this.HP_Chart.Legends.Add(legend1);
            this.HP_Chart.Location = new System.Drawing.Point(11, 129);
            this.HP_Chart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HP_Chart.Name = "HP_Chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.LabelBackColor = System.Drawing.Color.Black;
            series1.LabelForeColor = System.Drawing.Color.Lime;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.Name = "Blodtryk";
            this.HP_Chart.Series.Add(series1);
            this.HP_Chart.Size = new System.Drawing.Size(585, 299);
            this.HP_Chart.TabIndex = 0;
            this.HP_Chart.Text = "HP Chart";
            // 
            // Diastolic_textBox_HomeForm
            // 
            this.Diastolic_textBox_HomeForm.Location = new System.Drawing.Point(687, 285);
            this.Diastolic_textBox_HomeForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Diastolic_textBox_HomeForm.Name = "Diastolic_textBox_HomeForm";
            this.Diastolic_textBox_HomeForm.Size = new System.Drawing.Size(68, 20);
            this.Diastolic_textBox_HomeForm.TabIndex = 26;
            // 
            // Systolic_textBox_HomeForm
            // 
            this.Systolic_textBox_HomeForm.Location = new System.Drawing.Point(687, 248);
            this.Systolic_textBox_HomeForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Systolic_textBox_HomeForm.Name = "Systolic_textBox_HomeForm";
            this.Systolic_textBox_HomeForm.Size = new System.Drawing.Size(68, 20);
            this.Systolic_textBox_HomeForm.TabIndex = 25;
            // 
            // Average_textBox_HomeForm
            // 
            this.Average_textBox_HomeForm.Location = new System.Drawing.Point(687, 211);
            this.Average_textBox_HomeForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Average_textBox_HomeForm.Name = "Average_textBox_HomeForm";
            this.Average_textBox_HomeForm.Size = new System.Drawing.Size(68, 20);
            this.Average_textBox_HomeForm.TabIndex = 24;
            // 
            // Puls_textBox_HomeForm
            // 
            this.Puls_textBox_HomeForm.Location = new System.Drawing.Point(687, 172);
            this.Puls_textBox_HomeForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Puls_textBox_HomeForm.Name = "Puls_textBox_HomeForm";
            this.Puls_textBox_HomeForm.Size = new System.Drawing.Size(68, 20);
            this.Puls_textBox_HomeForm.TabIndex = 23;
            // 
            // Diastolic_Label_HomeForm
            // 
            this.Diastolic_Label_HomeForm.AutoSize = true;
            this.Diastolic_Label_HomeForm.Location = new System.Drawing.Point(615, 285);
            this.Diastolic_Label_HomeForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Diastolic_Label_HomeForm.Name = "Diastolic_Label_HomeForm";
            this.Diastolic_Label_HomeForm.Size = new System.Drawing.Size(47, 13);
            this.Diastolic_Label_HomeForm.TabIndex = 22;
            this.Diastolic_Label_HomeForm.Text = "Diastolic";
            // 
            // Systolic_Label_HomeForm
            // 
            this.Systolic_Label_HomeForm.AutoSize = true;
            this.Systolic_Label_HomeForm.Location = new System.Drawing.Point(615, 248);
            this.Systolic_Label_HomeForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Systolic_Label_HomeForm.Name = "Systolic_Label_HomeForm";
            this.Systolic_Label_HomeForm.Size = new System.Drawing.Size(43, 13);
            this.Systolic_Label_HomeForm.TabIndex = 21;
            this.Systolic_Label_HomeForm.Text = "Systolic";
            // 
            // Average_Label_HomeForm
            // 
            this.Average_Label_HomeForm.AutoSize = true;
            this.Average_Label_HomeForm.Location = new System.Drawing.Point(615, 211);
            this.Average_Label_HomeForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Average_Label_HomeForm.Name = "Average_Label_HomeForm";
            this.Average_Label_HomeForm.Size = new System.Drawing.Size(47, 13);
            this.Average_Label_HomeForm.TabIndex = 20;
            this.Average_Label_HomeForm.Text = "Average";
            // 
            // Puls_Label_HomeForm
            // 
            this.Puls_Label_HomeForm.AutoSize = true;
            this.Puls_Label_HomeForm.BackColor = System.Drawing.Color.White;
            this.Puls_Label_HomeForm.ForeColor = System.Drawing.Color.Black;
            this.Puls_Label_HomeForm.Location = new System.Drawing.Point(615, 172);
            this.Puls_Label_HomeForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Puls_Label_HomeForm.Name = "Puls_Label_HomeForm";
            this.Puls_Label_HomeForm.Size = new System.Drawing.Size(27, 13);
            this.Puls_Label_HomeForm.TabIndex = 19;
            this.Puls_Label_HomeForm.Text = "Puls";
            // 
            // ZeroPointAdjusment_button_HomeForm
            // 
            this.ZeroPointAdjusment_button_HomeForm.Location = new System.Drawing.Point(177, 11);
            this.ZeroPointAdjusment_button_HomeForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ZeroPointAdjusment_button_HomeForm.Name = "ZeroPointAdjusment_button_HomeForm";
            this.ZeroPointAdjusment_button_HomeForm.Size = new System.Drawing.Size(87, 36);
            this.ZeroPointAdjusment_button_HomeForm.TabIndex = 18;
            this.ZeroPointAdjusment_button_HomeForm.Text = "Nulpunkts justering";
            this.ZeroPointAdjusment_button_HomeForm.UseVisualStyleBackColor = true;
            this.ZeroPointAdjusment_button_HomeForm.Click += new System.EventHandler(this.ZeroPointAdjusment_button_HomeForm_Click);
            // 
            // Start_button_HomeForm
            // 
            this.Start_button_HomeForm.Location = new System.Drawing.Point(619, 322);
            this.Start_button_HomeForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Start_button_HomeForm.Name = "Start_button_HomeForm";
            this.Start_button_HomeForm.Size = new System.Drawing.Size(136, 30);
            this.Start_button_HomeForm.TabIndex = 17;
            this.Start_button_HomeForm.Text = "Start";
            this.Start_button_HomeForm.UseVisualStyleBackColor = true;
            this.Start_button_HomeForm.Click += new System.EventHandler(this.Start_button_HomeForm_Click);
            // 
            // Save_button_HomeForm
            // 
            this.Save_button_HomeForm.Location = new System.Drawing.Point(288, 67);
            this.Save_button_HomeForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Save_button_HomeForm.Name = "Save_button_HomeForm";
            this.Save_button_HomeForm.Size = new System.Drawing.Size(80, 36);
            this.Save_button_HomeForm.TabIndex = 16;
            this.Save_button_HomeForm.Text = "Gem";
            this.Save_button_HomeForm.UseVisualStyleBackColor = true;
            this.Save_button_HomeForm.Click += new System.EventHandler(this.Save_button_HomeForm_Click);
            // 
            // Digital_Button_HomeForm
            // 
            this.Digital_Button_HomeForm.Location = new System.Drawing.Point(66, 67);
            this.Digital_Button_HomeForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Digital_Button_HomeForm.Name = "Digital_Button_HomeForm";
            this.Digital_Button_HomeForm.Size = new System.Drawing.Size(87, 36);
            this.Digital_Button_HomeForm.TabIndex = 15;
            this.Digital_Button_HomeForm.Text = "Digital";
            this.Digital_Button_HomeForm.UseVisualStyleBackColor = true;
            this.Digital_Button_HomeForm.Click += new System.EventHandler(this.Digital_Button_HomeForm_Click);
            // 
            // Calibration_button_HomeForm
            // 
            this.Calibration_button_HomeForm.Location = new System.Drawing.Point(66, 11);
            this.Calibration_button_HomeForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Calibration_button_HomeForm.Name = "Calibration_button_HomeForm";
            this.Calibration_button_HomeForm.Size = new System.Drawing.Size(87, 36);
            this.Calibration_button_HomeForm.TabIndex = 14;
            this.Calibration_button_HomeForm.Text = "Kalibrer";
            this.Calibration_button_HomeForm.UseVisualStyleBackColor = true;
            this.Calibration_button_HomeForm.Click += new System.EventHandler(this.Calibration_button_HomeForm_Click);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(619, 365);
            this.stop_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(135, 30);
            this.stop_button.TabIndex = 27;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            // 
            // label_FilterType
            // 
            this.label_FilterType.AutoSize = true;
            this.label_FilterType.Location = new System.Drawing.Point(66, 120);
            this.label_FilterType.Name = "label_FilterType";
            this.label_FilterType.Size = new System.Drawing.Size(67, 13);
            this.label_FilterType.TabIndex = 28;
            this.label_FilterType.Text = "Digitalt filter: ";
            // 
            // button_alarmtone
            // 
            this.button_alarmtone.Location = new System.Drawing.Point(541, 12);
            this.button_alarmtone.Name = "button_alarmtone";
            this.button_alarmtone.Size = new System.Drawing.Size(91, 36);
            this.button_alarmtone.TabIndex = 29;
            this.button_alarmtone.Text = "Stop \r\nalarmtone";
            this.button_alarmtone.UseVisualStyleBackColor = true;
            this.button_alarmtone.Click += new System.EventHandler(this.button_alarmtone_Click);
            // 
            // button_alarm
            // 
            this.button_alarm.Location = new System.Drawing.Point(541, 67);
            this.button_alarm.Name = "button_alarm";
            this.button_alarm.Size = new System.Drawing.Size(91, 36);
            this.button_alarm.TabIndex = 30;
            this.button_alarm.Text = "Stop alarm";
            this.button_alarm.UseVisualStyleBackColor = true;
            this.button_alarm.Click += new System.EventHandler(this.button_alarm_Click);
            // 
            // button_setLimitValues
            // 
            this.button_setLimitValues.Location = new System.Drawing.Point(177, 67);
            this.button_setLimitValues.Name = "button_setLimitValues";
            this.button_setLimitValues.Size = new System.Drawing.Size(87, 36);
            this.button_setLimitValues.TabIndex = 31;
            this.button_setLimitValues.Text = "Sæt grænseværdier";
            this.button_setLimitValues.UseVisualStyleBackColor = true;
            this.button_setLimitValues.Click += new System.EventHandler(this.button_setLimitValues_Click);
            // 
            // Bloodpreasure_chart_Homeform
            // 
            this.Bloodpreasure_chart_Homeform.BackColor = System.Drawing.Color.Black;
            this.Bloodpreasure_chart_Homeform.BorderlineColor = System.Drawing.Color.Black;
            this.Bloodpreasure_chart_Homeform.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(98)))), ((int)(((byte)(113)))));
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BorderColor = System.Drawing.Color.Blue;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 82.57609F;
            chartArea1.Position.Width = 94F;
            chartArea1.Position.Y = 3F;
            this.Bloodpreasure_chart_Homeform.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.BorderColor = System.Drawing.Color.Black;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            legend1.ForeColor = System.Drawing.Color.Lime;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 8.423913F;
            legend1.Position.Width = 13.56185F;
            legend1.Position.X = 3F;
            legend1.Position.Y = 88.57609F;
            this.Bloodpreasure_chart_Homeform.Legends.Add(legend1);
            this.Bloodpreasure_chart_Homeform.Location = new System.Drawing.Point(12, 241);
            this.Bloodpreasure_chart_Homeform.Name = "Bloodpreasure_chart_Homeform";
            series1.BorderColor = System.Drawing.Color.Navy;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.LabelBackColor = System.Drawing.Color.Black;
            series1.LabelForeColor = System.Drawing.Color.Lime;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.Name = "Blodtryk";
            this.Bloodpreasure_chart_Homeform.Series.Add(series1);
            this.Bloodpreasure_chart_Homeform.Size = new System.Drawing.Size(881, 376);
            this.Bloodpreasure_chart_Homeform.TabIndex = 32;
            this.Bloodpreasure_chart_Homeform.Text = "chart1";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;

            this.ClientSize = new System.Drawing.Size(792, 440);
            this.ClientSize = new System.Drawing.Size(1188, 677);
            this.Controls.Add(this.Bloodpreasure_chart_Homeform);
            this.Controls.Add(this.button_setLimitValues);
            this.Controls.Add(this.button_alarm);
            this.Controls.Add(this.button_alarmtone);
            this.Controls.Add(this.label_FilterType);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.Diastolic_textBox_HomeForm);
            this.Controls.Add(this.Systolic_textBox_HomeForm);
            this.Controls.Add(this.Average_textBox_HomeForm);
            this.Controls.Add(this.Puls_textBox_HomeForm);
            this.Controls.Add(this.Diastolic_Label_HomeForm);
            this.Controls.Add(this.Systolic_Label_HomeForm);
            this.Controls.Add(this.Average_Label_HomeForm);
            this.Controls.Add(this.Puls_Label_HomeForm);
            this.Controls.Add(this.ZeroPointAdjusment_button_HomeForm);
            this.Controls.Add(this.Start_button_HomeForm);
            this.Controls.Add(this.Save_button_HomeForm);
            this.Controls.Add(this.Digital_Button_HomeForm);
            this.Controls.Add(this.Calibration_button_HomeForm);
            this.Controls.Add(this.HP_Chart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);

            this.Name = "HomeForm";
            this.RightToLeftLayout = true;
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.Bloodpreasure_chart_Homeform)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Diastolic_textBox_HomeForm;
        private System.Windows.Forms.TextBox Systolic_textBox_HomeForm;
        private System.Windows.Forms.TextBox Average_textBox_HomeForm;
        private System.Windows.Forms.TextBox Puls_textBox_HomeForm;
        private System.Windows.Forms.Label Diastolic_Label_HomeForm;
        private System.Windows.Forms.Label Systolic_Label_HomeForm;
        private System.Windows.Forms.Label Average_Label_HomeForm;
        private System.Windows.Forms.Label Puls_Label_HomeForm;
        private System.Windows.Forms.Button ZeroPointAdjusment_button_HomeForm;
        private System.Windows.Forms.Button Start_button_HomeForm;
        private System.Windows.Forms.Button Save_button_HomeForm;
        private System.Windows.Forms.Button Digital_Button_HomeForm;
        private System.Windows.Forms.Button Calibration_button_HomeForm;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Label label_FilterType;
        private System.Windows.Forms.Button button_alarmtone;
        private System.Windows.Forms.Button button_alarm;
        private System.Windows.Forms.Button button_setLimitValues;
        private System.Windows.Forms.DataVisualization.Charting.Chart Bloodpreasure_chart_Homeform;
    }
}