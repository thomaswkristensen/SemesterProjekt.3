﻿namespace PresentationLogic
{
    partial class SSNForm
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
            this.Patientdata_Label = new System.Windows.Forms.Label();
            this.SSN_Label = new System.Windows.Forms.Label();
            this.name_Label = new System.Windows.Forms.Label();
            this.age_Label = new System.Windows.Forms.Label();
            this.EmployeeID_Label = new System.Windows.Forms.Label();
            this.SSN_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.age_textBox = new System.Windows.Forms.TextBox();
            this.employeeID_textBox = new System.Windows.Forms.TextBox();
            this.save_button = new System.Windows.Forms.Button();
            this.information_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Patientdata_Label
            // 
            this.Patientdata_Label.AutoSize = true;
            this.Patientdata_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patientdata_Label.Location = new System.Drawing.Point(34, 52);
            this.Patientdata_Label.Name = "Patientdata_Label";
            this.Patientdata_Label.Size = new System.Drawing.Size(161, 32);
            this.Patientdata_Label.TabIndex = 0;
            this.Patientdata_Label.Text = "Patientdata";
            // 
            // SSN_Label
            // 
            this.SSN_Label.AutoSize = true;
            this.SSN_Label.Location = new System.Drawing.Point(38, 109);
            this.SSN_Label.Name = "SSN_Label";
            this.SSN_Label.Size = new System.Drawing.Size(42, 20);
            this.SSN_Label.TabIndex = 1;
            this.SSN_Label.Text = "CPR";
            // 
            // name_Label
            // 
            this.name_Label.AutoSize = true;
            this.name_Label.Location = new System.Drawing.Point(38, 177);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(45, 20);
            this.name_Label.TabIndex = 2;
            this.name_Label.Text = "Navn";
            // 
            // age_Label
            // 
            this.age_Label.AutoSize = true;
            this.age_Label.Location = new System.Drawing.Point(36, 249);
            this.age_Label.Name = "age_Label";
            this.age_Label.Size = new System.Drawing.Size(46, 20);
            this.age_Label.TabIndex = 3;
            this.age_Label.Text = "Alder";
            // 
            // EmployeeID_Label
            // 
            this.EmployeeID_Label.AutoSize = true;
            this.EmployeeID_Label.Location = new System.Drawing.Point(38, 325);
            this.EmployeeID_Label.Name = "EmployeeID_Label";
            this.EmployeeID_Label.Size = new System.Drawing.Size(73, 20);
            this.EmployeeID_Label.TabIndex = 4;
            this.EmployeeID_Label.Text = "Ansvarlig";
            // 
            // SSN_textBox
            // 
            this.SSN_textBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SSN_textBox.Location = new System.Drawing.Point(40, 132);
            this.SSN_textBox.Name = "SSN_textBox";
            this.SSN_textBox.Size = new System.Drawing.Size(302, 26);
            this.SSN_textBox.TabIndex = 5;
            // 
            // name_textBox
            // 
            this.name_textBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.name_textBox.Enabled = false;
            this.name_textBox.Location = new System.Drawing.Point(40, 200);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(302, 26);
            this.name_textBox.TabIndex = 6;
            // 
            // age_textBox
            // 
            this.age_textBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.age_textBox.Enabled = false;
            this.age_textBox.Location = new System.Drawing.Point(40, 272);
            this.age_textBox.Name = "age_textBox";
            this.age_textBox.Size = new System.Drawing.Size(302, 26);
            this.age_textBox.TabIndex = 7;
            // 
            // employeeID_textBox
            // 
            this.employeeID_textBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.employeeID_textBox.Enabled = false;
            this.employeeID_textBox.Location = new System.Drawing.Point(40, 348);
            this.employeeID_textBox.Name = "employeeID_textBox";
            this.employeeID_textBox.Size = new System.Drawing.Size(302, 26);
            this.employeeID_textBox.TabIndex = 8;
            // 
            // save_button
            // 
            this.save_button.BackColor = System.Drawing.Color.Transparent;
            this.save_button.Enabled = false;
            this.save_button.Location = new System.Drawing.Point(201, 412);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(141, 35);
            this.save_button.TabIndex = 9;
            this.save_button.Text = "Gem";
            this.save_button.UseVisualStyleBackColor = false;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // information_button
            // 
            this.information_button.BackColor = System.Drawing.Color.Transparent;
            this.information_button.Location = new System.Drawing.Point(40, 412);
            this.information_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.information_button.Name = "information_button";
            this.information_button.Size = new System.Drawing.Size(141, 35);
            this.information_button.TabIndex = 10;
            this.information_button.Text = "Hent information";
            this.information_button.UseVisualStyleBackColor = false;
            this.information_button.Click += new System.EventHandler(this.information_button_Click);
            // 
            // SSNForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(418, 508);
            this.Controls.Add(this.information_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.employeeID_textBox);
            this.Controls.Add(this.age_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.SSN_textBox);
            this.Controls.Add(this.EmployeeID_Label);
            this.Controls.Add(this.age_Label);
            this.Controls.Add(this.name_Label);
            this.Controls.Add(this.SSN_Label);
            this.Controls.Add(this.Patientdata_Label);
            this.Name = "SSNForm";
            this.Text = "SSNForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Patientdata_Label;
        private System.Windows.Forms.Label SSN_Label;
        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.Label age_Label;
        private System.Windows.Forms.Label EmployeeID_Label;
        private System.Windows.Forms.TextBox SSN_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox age_textBox;
        private System.Windows.Forms.TextBox employeeID_textBox;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button information_button;
    }
}