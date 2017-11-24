namespace PresentationLogic
{
    partial class LimitValues
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
            this.label_systolic = new System.Windows.Forms.Label();
            this.label_diastolic = new System.Windows.Forms.Label();
            this.textBox_DiastolicLimit = new System.Windows.Forms.TextBox();
            this.textBox_SystolicLimit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_systolic
            // 
            this.label_systolic.AutoSize = true;
            this.label_systolic.Location = new System.Drawing.Point(50, 89);
            this.label_systolic.Name = "label_systolic";
            this.label_systolic.Size = new System.Drawing.Size(48, 13);
            this.label_systolic.TabIndex = 0;
            this.label_systolic.Text = "Systolisk";
            // 
            // label_diastolic
            // 
            this.label_diastolic.AutoSize = true;
            this.label_diastolic.Location = new System.Drawing.Point(50, 151);
            this.label_diastolic.Name = "label_diastolic";
            this.label_diastolic.Size = new System.Drawing.Size(52, 13);
            this.label_diastolic.TabIndex = 1;
            this.label_diastolic.Text = "Diastolisk";
            // 
            // textBox_DiastolicLimit
            // 
            this.textBox_DiastolicLimit.Location = new System.Drawing.Point(135, 148);
            this.textBox_DiastolicLimit.Name = "textBox_DiastolicLimit";
            this.textBox_DiastolicLimit.Size = new System.Drawing.Size(100, 20);
            this.textBox_DiastolicLimit.TabIndex = 2;
            // 
            // textBox_SystolicLimit
            // 
            this.textBox_SystolicLimit.Location = new System.Drawing.Point(135, 86);
            this.textBox_SystolicLimit.Name = "textBox_SystolicLimit";
            this.textBox_SystolicLimit.Size = new System.Drawing.Size(100, 20);
            this.textBox_SystolicLimit.TabIndex = 3;
            // 
            // LimitValues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox_SystolicLimit);
            this.Controls.Add(this.textBox_DiastolicLimit);
            this.Controls.Add(this.label_diastolic);
            this.Controls.Add(this.label_systolic);
            this.Name = "LimitValues";
            this.Text = "LimitValues";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_systolic;
        private System.Windows.Forms.Label label_diastolic;
        private System.Windows.Forms.TextBox textBox_DiastolicLimit;
        private System.Windows.Forms.TextBox textBox_SystolicLimit;
    }
}