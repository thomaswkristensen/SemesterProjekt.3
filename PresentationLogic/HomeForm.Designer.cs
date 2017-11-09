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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.HP_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            ((System.ComponentModel.ISupportInitialize)(this.HP_Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // HP_Chart
            // 
            chartArea2.Name = "ChartArea1";
            this.HP_Chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.HP_Chart.Legends.Add(legend2);
            this.HP_Chart.Location = new System.Drawing.Point(12, 83);
            this.HP_Chart.Name = "HP_Chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Blood Preasure";
            this.HP_Chart.Series.Add(series2);
            this.HP_Chart.Size = new System.Drawing.Size(947, 460);
            this.HP_Chart.TabIndex = 0;
            this.HP_Chart.Text = "HP Chart";
            // 
            // Diastolic_textBox_HomeForm
            // 
            this.Diastolic_textBox_HomeForm.Location = new System.Drawing.Point(831, 334);
            this.Diastolic_textBox_HomeForm.Name = "Diastolic_textBox_HomeForm";
            this.Diastolic_textBox_HomeForm.Size = new System.Drawing.Size(100, 26);
            this.Diastolic_textBox_HomeForm.TabIndex = 26;
            // 
            // Systolic_textBox_HomeForm
            // 
            this.Systolic_textBox_HomeForm.Location = new System.Drawing.Point(831, 276);
            this.Systolic_textBox_HomeForm.Name = "Systolic_textBox_HomeForm";
            this.Systolic_textBox_HomeForm.Size = new System.Drawing.Size(100, 26);
            this.Systolic_textBox_HomeForm.TabIndex = 25;
            // 
            // Average_textBox_HomeForm
            // 
            this.Average_textBox_HomeForm.Location = new System.Drawing.Point(831, 218);
            this.Average_textBox_HomeForm.Name = "Average_textBox_HomeForm";
            this.Average_textBox_HomeForm.Size = new System.Drawing.Size(100, 26);
            this.Average_textBox_HomeForm.TabIndex = 24;
            // 
            // Puls_textBox_HomeForm
            // 
            this.Puls_textBox_HomeForm.Location = new System.Drawing.Point(831, 158);
            this.Puls_textBox_HomeForm.Name = "Puls_textBox_HomeForm";
            this.Puls_textBox_HomeForm.Size = new System.Drawing.Size(100, 26);
            this.Puls_textBox_HomeForm.TabIndex = 23;
            // 
            // Diastolic_Label_HomeForm
            // 
            this.Diastolic_Label_HomeForm.AutoSize = true;
            this.Diastolic_Label_HomeForm.Location = new System.Drawing.Point(725, 334);
            this.Diastolic_Label_HomeForm.Name = "Diastolic_Label_HomeForm";
            this.Diastolic_Label_HomeForm.Size = new System.Drawing.Size(69, 20);
            this.Diastolic_Label_HomeForm.TabIndex = 22;
            this.Diastolic_Label_HomeForm.Text = "Diastolic";
            // 
            // Systolic_Label_HomeForm
            // 
            this.Systolic_Label_HomeForm.AutoSize = true;
            this.Systolic_Label_HomeForm.Location = new System.Drawing.Point(725, 276);
            this.Systolic_Label_HomeForm.Name = "Systolic_Label_HomeForm";
            this.Systolic_Label_HomeForm.Size = new System.Drawing.Size(63, 20);
            this.Systolic_Label_HomeForm.TabIndex = 21;
            this.Systolic_Label_HomeForm.Text = "Systolic";
            // 
            // Average_Label_HomeForm
            // 
            this.Average_Label_HomeForm.AutoSize = true;
            this.Average_Label_HomeForm.Location = new System.Drawing.Point(725, 218);
            this.Average_Label_HomeForm.Name = "Average_Label_HomeForm";
            this.Average_Label_HomeForm.Size = new System.Drawing.Size(68, 20);
            this.Average_Label_HomeForm.TabIndex = 20;
            this.Average_Label_HomeForm.Text = "Average";
            // 
            // Puls_Label_HomeForm
            // 
            this.Puls_Label_HomeForm.AutoSize = true;
            this.Puls_Label_HomeForm.BackColor = System.Drawing.Color.White;
            this.Puls_Label_HomeForm.ForeColor = System.Drawing.Color.Black;
            this.Puls_Label_HomeForm.Location = new System.Drawing.Point(725, 158);
            this.Puls_Label_HomeForm.Name = "Puls_Label_HomeForm";
            this.Puls_Label_HomeForm.Size = new System.Drawing.Size(39, 20);
            this.Puls_Label_HomeForm.TabIndex = 19;
            this.Puls_Label_HomeForm.Text = "Puls";
            // 
            // ZeroPointAdjusment_button_HomeForm
            // 
            this.ZeroPointAdjusment_button_HomeForm.Location = new System.Drawing.Point(244, 22);
            this.ZeroPointAdjusment_button_HomeForm.Name = "ZeroPointAdjusment_button_HomeForm";
            this.ZeroPointAdjusment_button_HomeForm.Size = new System.Drawing.Size(120, 55);
            this.ZeroPointAdjusment_button_HomeForm.TabIndex = 18;
            this.ZeroPointAdjusment_button_HomeForm.Text = "Nulpunkts justering";
            this.ZeroPointAdjusment_button_HomeForm.UseVisualStyleBackColor = true;
            // 
            // Start_button_HomeForm
            // 
            this.Start_button_HomeForm.Location = new System.Drawing.Point(729, 381);
            this.Start_button_HomeForm.Name = "Start_button_HomeForm";
            this.Start_button_HomeForm.Size = new System.Drawing.Size(202, 46);
            this.Start_button_HomeForm.TabIndex = 17;
            this.Start_button_HomeForm.Text = "Start";
            this.Start_button_HomeForm.UseVisualStyleBackColor = true;
            // 
            // Save_button_HomeForm
            // 
            this.Save_button_HomeForm.Location = new System.Drawing.Point(520, 21);
            this.Save_button_HomeForm.Name = "Save_button_HomeForm";
            this.Save_button_HomeForm.Size = new System.Drawing.Size(112, 56);
            this.Save_button_HomeForm.TabIndex = 16;
            this.Save_button_HomeForm.Text = "Gem";
            this.Save_button_HomeForm.UseVisualStyleBackColor = true;
            this.Save_button_HomeForm.Click += new System.EventHandler(this.Save_button_HomeForm_Click);
            // 
            // Digital_Button_HomeForm
            // 
            this.Digital_Button_HomeForm.Location = new System.Drawing.Point(388, 22);
            this.Digital_Button_HomeForm.Name = "Digital_Button_HomeForm";
            this.Digital_Button_HomeForm.Size = new System.Drawing.Size(110, 55);
            this.Digital_Button_HomeForm.TabIndex = 15;
            this.Digital_Button_HomeForm.Text = "Digital";
            this.Digital_Button_HomeForm.UseVisualStyleBackColor = true;
            // 
            // Calibration_button_HomeForm
            // 
            this.Calibration_button_HomeForm.Location = new System.Drawing.Point(105, 22);
            this.Calibration_button_HomeForm.Name = "Calibration_button_HomeForm";
            this.Calibration_button_HomeForm.Size = new System.Drawing.Size(119, 55);
            this.Calibration_button_HomeForm.TabIndex = 14;
            this.Calibration_button_HomeForm.Text = "Kalibrer";
            this.Calibration_button_HomeForm.UseVisualStyleBackColor = true;
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(729, 456);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(202, 46);
            this.stop_button.TabIndex = 27;
            this.stop_button.Text = "Stop";
            this.stop_button.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 555);
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
            this.Name = "HomeForm";
            this.RightToLeftLayout = true;
            this.Text = "HomeForm";
            ((System.ComponentModel.ISupportInitialize)(this.HP_Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart HP_Chart;
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
    }
}