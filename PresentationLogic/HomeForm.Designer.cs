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
            this.Systolic_textBox_HomeForm = new System.Windows.Forms.TextBox();
            this.Average_textBox_HomeForm = new System.Windows.Forms.TextBox();
            this.Puls_textBox_HomeForm = new System.Windows.Forms.TextBox();
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
            this.Bloodpressure_chart_Homeform = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Bloodpressure_chart_Homeform)).BeginInit();
            this.SuspendLayout();
            // 
            // Systolic_textBox_HomeForm
            // 
            this.Systolic_textBox_HomeForm.BackColor = System.Drawing.Color.Black;
            this.Systolic_textBox_HomeForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Systolic_textBox_HomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Systolic_textBox_HomeForm.ForeColor = System.Drawing.Color.Yellow;
            this.Systolic_textBox_HomeForm.Location = new System.Drawing.Point(1100, 280);
            this.Systolic_textBox_HomeForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Systolic_textBox_HomeForm.Name = "Systolic_textBox_HomeForm";
            this.Systolic_textBox_HomeForm.Size = new System.Drawing.Size(176, 37);
            this.Systolic_textBox_HomeForm.TabIndex = 25;
            this.Systolic_textBox_HomeForm.Text = "--/--";
            // 
            // Average_textBox_HomeForm
            // 
            this.Average_textBox_HomeForm.BackColor = System.Drawing.Color.Black;
            this.Average_textBox_HomeForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Average_textBox_HomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Average_textBox_HomeForm.ForeColor = System.Drawing.Color.Red;
            this.Average_textBox_HomeForm.Location = new System.Drawing.Point(1100, 231);
            this.Average_textBox_HomeForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Average_textBox_HomeForm.Name = "Average_textBox_HomeForm";
            this.Average_textBox_HomeForm.Size = new System.Drawing.Size(195, 37);
            this.Average_textBox_HomeForm.TabIndex = 24;
            this.Average_textBox_HomeForm.Text = "--";
            // 
            // Puls_textBox_HomeForm
            // 
            this.Puls_textBox_HomeForm.BackColor = System.Drawing.Color.Black;
            this.Puls_textBox_HomeForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Puls_textBox_HomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puls_textBox_HomeForm.ForeColor = System.Drawing.Color.Lime;
            this.Puls_textBox_HomeForm.Location = new System.Drawing.Point(1100, 181);
            this.Puls_textBox_HomeForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Puls_textBox_HomeForm.Name = "Puls_textBox_HomeForm";
            this.Puls_textBox_HomeForm.Size = new System.Drawing.Size(203, 37);
            this.Puls_textBox_HomeForm.TabIndex = 23;
            this.Puls_textBox_HomeForm.Text = "--";
            // 
            // Systolic_Label_HomeForm
            // 
            this.Systolic_Label_HomeForm.AutoSize = true;
            this.Systolic_Label_HomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Systolic_Label_HomeForm.ForeColor = System.Drawing.Color.Yellow;
            this.Systolic_Label_HomeForm.Location = new System.Drawing.Point(969, 290);
            this.Systolic_Label_HomeForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Systolic_Label_HomeForm.Name = "Systolic_Label_HomeForm";
            this.Systolic_Label_HomeForm.Size = new System.Drawing.Size(94, 26);
            this.Systolic_Label_HomeForm.TabIndex = 21;
            this.Systolic_Label_HomeForm.Text = "Sys/Dia:";
            // 
            // Average_Label_HomeForm
            // 
            this.Average_Label_HomeForm.AutoSize = true;
            this.Average_Label_HomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Average_Label_HomeForm.ForeColor = System.Drawing.Color.Red;
            this.Average_Label_HomeForm.Location = new System.Drawing.Point(969, 241);
            this.Average_Label_HomeForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Average_Label_HomeForm.Name = "Average_Label_HomeForm";
            this.Average_Label_HomeForm.Size = new System.Drawing.Size(99, 26);
            this.Average_Label_HomeForm.TabIndex = 20;
            this.Average_Label_HomeForm.Text = "Average:";
            // 
            // Puls_Label_HomeForm
            // 
            this.Puls_Label_HomeForm.AutoSize = true;
            this.Puls_Label_HomeForm.BackColor = System.Drawing.Color.Black;
            this.Puls_Label_HomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puls_Label_HomeForm.ForeColor = System.Drawing.Color.Lime;
            this.Puls_Label_HomeForm.Location = new System.Drawing.Point(969, 191);
            this.Puls_Label_HomeForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Puls_Label_HomeForm.Name = "Puls_Label_HomeForm";
            this.Puls_Label_HomeForm.Size = new System.Drawing.Size(61, 26);
            this.Puls_Label_HomeForm.TabIndex = 19;
            this.Puls_Label_HomeForm.Text = "Puls:";
            // 
            // ZeroPointAdjusment_button_HomeForm
            // 
            this.ZeroPointAdjusment_button_HomeForm.BackColor = System.Drawing.Color.Black;
            this.ZeroPointAdjusment_button_HomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZeroPointAdjusment_button_HomeForm.ForeColor = System.Drawing.Color.White;
            this.ZeroPointAdjusment_button_HomeForm.Location = new System.Drawing.Point(271, 23);
            this.ZeroPointAdjusment_button_HomeForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ZeroPointAdjusment_button_HomeForm.Name = "ZeroPointAdjusment_button_HomeForm";
            this.ZeroPointAdjusment_button_HomeForm.Size = new System.Drawing.Size(160, 36);
            this.ZeroPointAdjusment_button_HomeForm.TabIndex = 18;
            this.ZeroPointAdjusment_button_HomeForm.Text = "Nulpunkts justering";
            this.ZeroPointAdjusment_button_HomeForm.UseVisualStyleBackColor = false;
            this.ZeroPointAdjusment_button_HomeForm.Click += new System.EventHandler(this.ZeroPointAdjusment_button_HomeForm_Click);
            // 
            // Start_button_HomeForm
            // 
            this.Start_button_HomeForm.BackColor = System.Drawing.Color.Black;
            this.Start_button_HomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_button_HomeForm.ForeColor = System.Drawing.Color.White;
            this.Start_button_HomeForm.Location = new System.Drawing.Point(974, 375);
            this.Start_button_HomeForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Start_button_HomeForm.Name = "Start_button_HomeForm";
            this.Start_button_HomeForm.Size = new System.Drawing.Size(193, 39);
            this.Start_button_HomeForm.TabIndex = 17;
            this.Start_button_HomeForm.Text = "Start";
            this.Start_button_HomeForm.UseVisualStyleBackColor = false;
            this.Start_button_HomeForm.Click += new System.EventHandler(this.Start_button_HomeForm_Click);
            // 
            // Save_button_HomeForm
            // 
            this.Save_button_HomeForm.BackColor = System.Drawing.Color.Black;
            this.Save_button_HomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_button_HomeForm.ForeColor = System.Drawing.Color.White;
            this.Save_button_HomeForm.Location = new System.Drawing.Point(485, 23);
            this.Save_button_HomeForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Save_button_HomeForm.Name = "Save_button_HomeForm";
            this.Save_button_HomeForm.Size = new System.Drawing.Size(160, 36);
            this.Save_button_HomeForm.TabIndex = 16;
            this.Save_button_HomeForm.Text = "Gem";
            this.Save_button_HomeForm.UseVisualStyleBackColor = false;
            this.Save_button_HomeForm.Click += new System.EventHandler(this.Save_button_HomeForm_Click);
            // 
            // Digital_Button_HomeForm
            // 
            this.Digital_Button_HomeForm.BackColor = System.Drawing.Color.Black;
            this.Digital_Button_HomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Digital_Button_HomeForm.ForeColor = System.Drawing.Color.White;
            this.Digital_Button_HomeForm.Location = new System.Drawing.Point(705, 23);
            this.Digital_Button_HomeForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Digital_Button_HomeForm.Name = "Digital_Button_HomeForm";
            this.Digital_Button_HomeForm.Size = new System.Drawing.Size(160, 36);
            this.Digital_Button_HomeForm.TabIndex = 15;
            this.Digital_Button_HomeForm.Text = "Filter";
            this.Digital_Button_HomeForm.UseVisualStyleBackColor = false;
            this.Digital_Button_HomeForm.Click += new System.EventHandler(this.Digital_Button_HomeForm_Click);
            // 
            // Calibration_button_HomeForm
            // 
            this.Calibration_button_HomeForm.BackColor = System.Drawing.Color.Black;
            this.Calibration_button_HomeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calibration_button_HomeForm.ForeColor = System.Drawing.Color.White;
            this.Calibration_button_HomeForm.Location = new System.Drawing.Point(271, 78);
            this.Calibration_button_HomeForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Calibration_button_HomeForm.Name = "Calibration_button_HomeForm";
            this.Calibration_button_HomeForm.Size = new System.Drawing.Size(160, 36);
            this.Calibration_button_HomeForm.TabIndex = 14;
            this.Calibration_button_HomeForm.Text = "Kalibrer";
            this.Calibration_button_HomeForm.UseVisualStyleBackColor = false;
            this.Calibration_button_HomeForm.Click += new System.EventHandler(this.Calibration_button_HomeForm_Click);
            // 
            // stop_button
            // 
            this.stop_button.BackColor = System.Drawing.Color.Black;
            this.stop_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_button.ForeColor = System.Drawing.Color.White;
            this.stop_button.Location = new System.Drawing.Point(974, 452);
            this.stop_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(193, 39);
            this.stop_button.TabIndex = 27;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = false;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // label_FilterType
            // 
            this.label_FilterType.AutoSize = true;
            this.label_FilterType.BackColor = System.Drawing.Color.Black;
            this.label_FilterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FilterType.ForeColor = System.Drawing.Color.White;
            this.label_FilterType.Location = new System.Drawing.Point(701, 78);
            this.label_FilterType.Name = "label_FilterType";
            this.label_FilterType.Size = new System.Drawing.Size(91, 18);
            this.label_FilterType.TabIndex = 28;
            this.label_FilterType.Text = "Digitalt filter: ";
            // 
            // button_alarmtone
            // 
            this.button_alarmtone.BackColor = System.Drawing.Color.Black;
            this.button_alarmtone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_alarmtone.ForeColor = System.Drawing.Color.White;
            this.button_alarmtone.Location = new System.Drawing.Point(61, 23);
            this.button_alarmtone.Name = "button_alarmtone";
            this.button_alarmtone.Size = new System.Drawing.Size(160, 36);
            this.button_alarmtone.TabIndex = 29;
            this.button_alarmtone.Text = "Stop alarmtone";
            this.button_alarmtone.UseVisualStyleBackColor = false;
            this.button_alarmtone.Click += new System.EventHandler(this.button_alarmtone_Click);
            // 
            // button_alarm
            // 
            this.button_alarm.BackColor = System.Drawing.Color.Black;
            this.button_alarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_alarm.ForeColor = System.Drawing.Color.White;
            this.button_alarm.Location = new System.Drawing.Point(61, 78);
            this.button_alarm.Name = "button_alarm";
            this.button_alarm.Size = new System.Drawing.Size(160, 36);
            this.button_alarm.TabIndex = 30;
            this.button_alarm.Text = "Stop alarm";
            this.button_alarm.UseVisualStyleBackColor = false;
            this.button_alarm.Click += new System.EventHandler(this.button_alarm_Click);
            // 
            // button_setLimitValues
            // 
            this.button_setLimitValues.BackColor = System.Drawing.Color.Black;
            this.button_setLimitValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_setLimitValues.ForeColor = System.Drawing.Color.White;
            this.button_setLimitValues.Location = new System.Drawing.Point(485, 78);
            this.button_setLimitValues.Name = "button_setLimitValues";
            this.button_setLimitValues.Size = new System.Drawing.Size(160, 36);
            this.button_setLimitValues.TabIndex = 31;
            this.button_setLimitValues.Text = "Sæt grænseværdier";
            this.button_setLimitValues.UseVisualStyleBackColor = false;
            this.button_setLimitValues.Click += new System.EventHandler(this.button_setLimitValues_Click);
            // 
            // Bloodpressure_chart_Homeform
            // 
            this.Bloodpressure_chart_Homeform.BackColor = System.Drawing.Color.Black;
            this.Bloodpressure_chart_Homeform.BorderlineColor = System.Drawing.Color.Black;
            this.Bloodpressure_chart_Homeform.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
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
            this.Bloodpressure_chart_Homeform.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.BorderColor = System.Drawing.Color.Black;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            legend1.ForeColor = System.Drawing.Color.Red;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.Position.Auto = false;
            legend1.Position.Height = 8.423913F;
            legend1.Position.Width = 13.56185F;
            legend1.Position.X = 3F;
            legend1.Position.Y = 88.57609F;
            this.Bloodpressure_chart_Homeform.Legends.Add(legend1);
            this.Bloodpressure_chart_Homeform.Location = new System.Drawing.Point(12, 118);
            this.Bloodpressure_chart_Homeform.Name = "Bloodpressure_chart_Homeform";
            series1.BorderColor = System.Drawing.Color.Navy;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.LabelBackColor = System.Drawing.Color.Black;
            series1.LabelForeColor = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.Name = "Blodtryk";
            this.Bloodpressure_chart_Homeform.Series.Add(series1);
            this.Bloodpressure_chart_Homeform.Size = new System.Drawing.Size(953, 508);
            this.Bloodpressure_chart_Homeform.TabIndex = 32;
            this.Bloodpressure_chart_Homeform.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(971, 265);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "mmHg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(971, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "bpm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(971, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "mmHg";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1354, 602);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bloodpressure_chart_Homeform);
            this.Controls.Add(this.button_setLimitValues);
            this.Controls.Add(this.button_alarm);
            this.Controls.Add(this.button_alarmtone);
            this.Controls.Add(this.label_FilterType);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.Systolic_textBox_HomeForm);
            this.Controls.Add(this.Average_textBox_HomeForm);
            this.Controls.Add(this.Puls_textBox_HomeForm);
            this.Controls.Add(this.Systolic_Label_HomeForm);
            this.Controls.Add(this.Average_Label_HomeForm);
            this.Controls.Add(this.Puls_Label_HomeForm);
            this.Controls.Add(this.ZeroPointAdjusment_button_HomeForm);
            this.Controls.Add(this.Start_button_HomeForm);
            this.Controls.Add(this.Save_button_HomeForm);
            this.Controls.Add(this.Digital_Button_HomeForm);
            this.Controls.Add(this.Calibration_button_HomeForm);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HomeForm";
            this.RightToLeftLayout = true;
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.Bloodpressure_chart_Homeform)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Systolic_textBox_HomeForm;
        private System.Windows.Forms.TextBox Average_textBox_HomeForm;
        private System.Windows.Forms.TextBox Puls_textBox_HomeForm;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart Bloodpressure_chart_Homeform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}