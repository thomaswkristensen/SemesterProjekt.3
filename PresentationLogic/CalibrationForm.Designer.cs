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
            this.P1_radioButton = new System.Windows.Forms.RadioButton();
            this.P2_radioButton = new System.Windows.Forms.RadioButton();
            this.P3_radioButton = new System.Windows.Forms.RadioButton();
            this.calibration_button = new System.Windows.Forms.Button();
            this.done_button = new System.Windows.Forms.Button();
            this.calibration_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // P1_radioButton
            // 
            this.P1_radioButton.AutoSize = true;
            this.P1_radioButton.Location = new System.Drawing.Point(70, 122);
            this.P1_radioButton.Name = "P1_radioButton";
            this.P1_radioButton.Size = new System.Drawing.Size(103, 24);
            this.P1_radioButton.TabIndex = 0;
            this.P1_radioButton.TabStop = true;
            this.P1_radioButton.Text = "10 mmHg";
            this.P1_radioButton.UseVisualStyleBackColor = true;
            // 
            // P2_radioButton
            // 
            this.P2_radioButton.AutoSize = true;
            this.P2_radioButton.Location = new System.Drawing.Point(70, 176);
            this.P2_radioButton.Name = "P2_radioButton";
            this.P2_radioButton.Size = new System.Drawing.Size(103, 24);
            this.P2_radioButton.TabIndex = 1;
            this.P2_radioButton.TabStop = true;
            this.P2_radioButton.Text = "50 mmHg";
            this.P2_radioButton.UseVisualStyleBackColor = true;
            // 
            // P3_radioButton
            // 
            this.P3_radioButton.AutoSize = true;
            this.P3_radioButton.Location = new System.Drawing.Point(70, 233);
            this.P3_radioButton.Name = "P3_radioButton";
            this.P3_radioButton.Size = new System.Drawing.Size(112, 24);
            this.P3_radioButton.TabIndex = 2;
            this.P3_radioButton.TabStop = true;
            this.P3_radioButton.Text = "100 mmHg";
            this.P3_radioButton.UseVisualStyleBackColor = true;
            // 
            // calibration_button
            // 
            this.calibration_button.Location = new System.Drawing.Point(70, 296);
            this.calibration_button.Name = "calibration_button";
            this.calibration_button.Size = new System.Drawing.Size(108, 35);
            this.calibration_button.TabIndex = 3;
            this.calibration_button.Text = "Kalibrer";
            this.calibration_button.UseVisualStyleBackColor = true;
            // 
            // done_button
            // 
            this.done_button.Location = new System.Drawing.Point(211, 296);
            this.done_button.Name = "done_button";
            this.done_button.Size = new System.Drawing.Size(109, 35);
            this.done_button.TabIndex = 4;
            this.done_button.Text = "Færdig";
            this.done_button.UseVisualStyleBackColor = true;
            // 
            // calibration_label
            // 
            this.calibration_label.AutoSize = true;
            this.calibration_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calibration_label.Location = new System.Drawing.Point(63, 60);
            this.calibration_label.Name = "calibration_label";
            this.calibration_label.Size = new System.Drawing.Size(170, 37);
            this.calibration_label.TabIndex = 5;
            this.calibration_label.Text = "Kalibrering";
            // 
            // CalibrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 396);
            this.Controls.Add(this.calibration_label);
            this.Controls.Add(this.done_button);
            this.Controls.Add(this.calibration_button);
            this.Controls.Add(this.P3_radioButton);
            this.Controls.Add(this.P2_radioButton);
            this.Controls.Add(this.P1_radioButton);
            this.Name = "CalibrationForm";
            this.Text = "CalibrationForm";
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
    }
}