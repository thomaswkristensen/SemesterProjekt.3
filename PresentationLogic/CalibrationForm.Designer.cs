namespace PresentationLogic
{
    partial class CalibrationForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.P1_radioButton = new System.Windows.Forms.RadioButton();
            this.P2_radioButton = new System.Windows.Forms.RadioButton();
            this.P3_radioButton = new System.Windows.Forms.RadioButton();
            this.calibration_button = new System.Windows.Forms.Button();
            this.done_button = new System.Windows.Forms.Button();
            this.calibration_label = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SlopeTextbox = new System.Windows.Forms.TextBox();
            this.ChangeSlope_Button = new System.Windows.Forms.Button();
            this.ViewCalibration_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // P1_radioButton
            // 
            this.P1_radioButton.AutoSize = true;
            this.P1_radioButton.Location = new System.Drawing.Point(47, 79);
            this.P1_radioButton.Margin = new System.Windows.Forms.Padding(2);
            this.P1_radioButton.Name = "P1_radioButton";
            this.P1_radioButton.Size = new System.Drawing.Size(70, 17);
            this.P1_radioButton.TabIndex = 0;
            this.P1_radioButton.TabStop = true;
            this.P1_radioButton.Text = "10 mmHg";
            this.P1_radioButton.UseVisualStyleBackColor = true;
            // 
            // P2_radioButton
            // 
            this.P2_radioButton.AutoSize = true;
            this.P2_radioButton.Location = new System.Drawing.Point(47, 114);
            this.P2_radioButton.Margin = new System.Windows.Forms.Padding(2);
            this.P2_radioButton.Name = "P2_radioButton";
            this.P2_radioButton.Size = new System.Drawing.Size(70, 17);
            this.P2_radioButton.TabIndex = 1;
            this.P2_radioButton.TabStop = true;
            this.P2_radioButton.Text = "50 mmHg";
            this.P2_radioButton.UseVisualStyleBackColor = true;
            // 
            // P3_radioButton
            // 
            this.P3_radioButton.AutoSize = true;
            this.P3_radioButton.Location = new System.Drawing.Point(47, 151);
            this.P3_radioButton.Margin = new System.Windows.Forms.Padding(2);
            this.P3_radioButton.Name = "P3_radioButton";
            this.P3_radioButton.Size = new System.Drawing.Size(76, 17);
            this.P3_radioButton.TabIndex = 2;
            this.P3_radioButton.TabStop = true;
            this.P3_radioButton.Text = "100 mmHg";
            this.P3_radioButton.UseVisualStyleBackColor = true;
            // 
            // calibration_button
            // 
            this.calibration_button.Location = new System.Drawing.Point(47, 192);
            this.calibration_button.Margin = new System.Windows.Forms.Padding(2);
            this.calibration_button.Name = "calibration_button";
            this.calibration_button.Size = new System.Drawing.Size(72, 23);
            this.calibration_button.TabIndex = 3;
            this.calibration_button.Text = "Kalibrer";
            this.calibration_button.UseVisualStyleBackColor = true;
            this.calibration_button.Click += new System.EventHandler(this.calibration_button_Click);
            // 
            // done_button
            // 
            this.done_button.Location = new System.Drawing.Point(199, 192);
            this.done_button.Margin = new System.Windows.Forms.Padding(2);
            this.done_button.Name = "done_button";
            this.done_button.Size = new System.Drawing.Size(73, 23);
            this.done_button.TabIndex = 4;
            this.done_button.Text = "Færdig";
            this.done_button.UseVisualStyleBackColor = true;
            this.done_button.Click += new System.EventHandler(this.done_button_Click);
            // 
            // calibration_label
            // 
            this.calibration_label.AutoSize = true;
            this.calibration_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calibration_label.Location = new System.Drawing.Point(42, 39);
            this.calibration_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.calibration_label.Name = "calibration_label";
            this.calibration_label.Size = new System.Drawing.Size(116, 26);
            this.calibration_label.TabIndex = 5;
            this.calibration_label.Text = "Kalibrering";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(281, 25);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(321, 220);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // SlopeTextbox
            // 
            this.SlopeTextbox.Location = new System.Drawing.Point(502, 111);
            this.SlopeTextbox.Name = "SlopeTextbox";
            this.SlopeTextbox.Size = new System.Drawing.Size(100, 20);
            this.SlopeTextbox.TabIndex = 7;
            // 
            // ChangeSlope_Button
            // 
            this.ChangeSlope_Button.Location = new System.Drawing.Point(502, 137);
            this.ChangeSlope_Button.Name = "ChangeSlope_Button";
            this.ChangeSlope_Button.Size = new System.Drawing.Size(100, 23);
            this.ChangeSlope_Button.TabIndex = 8;
            this.ChangeSlope_Button.Text = "Ændre hældning";
            this.ChangeSlope_Button.UseVisualStyleBackColor = true;
            this.ChangeSlope_Button.Click += new System.EventHandler(this.ChangeSlope_Button_Click);
            // 
            // ViewCalibration_Button
            // 
            this.ViewCalibration_Button.Location = new System.Drawing.Point(123, 192);
            this.ViewCalibration_Button.Margin = new System.Windows.Forms.Padding(2);
            this.ViewCalibration_Button.Name = "ViewCalibration_Button";
            this.ViewCalibration_Button.Size = new System.Drawing.Size(72, 23);
            this.ViewCalibration_Button.TabIndex = 9;
            this.ViewCalibration_Button.Text = "Se graf";
            this.ViewCalibration_Button.UseVisualStyleBackColor = true;
            this.ViewCalibration_Button.Click += new System.EventHandler(this.ViewCalibration_Button_Click);
            // 
            // CalibrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(615, 257);
            this.Controls.Add(this.ViewCalibration_Button);
            this.Controls.Add(this.ChangeSlope_Button);
            this.Controls.Add(this.SlopeTextbox);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.calibration_label);
            this.Controls.Add(this.done_button);
            this.Controls.Add(this.calibration_button);
            this.Controls.Add(this.P3_radioButton);
            this.Controls.Add(this.P2_radioButton);
            this.Controls.Add(this.P1_radioButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CalibrationForm";
            this.Text = "CalibrationForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton P1_radioButton;
        private System.Windows.Forms.RadioButton P2_radioButton;
        private System.Windows.Forms.RadioButton P3_radioButton;
        private System.Windows.Forms.Button calibration_button;
        private System.Windows.Forms.Button done_button;
        private System.Windows.Forms.Label calibration_label;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox SlopeTextbox;
        private System.Windows.Forms.Button ChangeSlope_Button;
        private System.Windows.Forms.Button ViewCalibration_Button;
    }
}