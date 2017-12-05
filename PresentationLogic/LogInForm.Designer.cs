namespace PresentationLogic
{
    partial class LogInForm
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
            this.Login_Label_LogInForm = new System.Windows.Forms.Label();
            this.EmployeeID_Label_LogInForm = new System.Windows.Forms.Label();
            this.Password_Label_LogInForm = new System.Windows.Forms.Label();
            this.EmployeeID_textBox_LogInForm = new System.Windows.Forms.TextBox();
            this.Password_textBox_LogInForm = new System.Windows.Forms.TextBox();
            this.Cancel_button_LogInForm = new System.Windows.Forms.Button();
            this.Login_button_LogInForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login_Label_LogInForm
            // 
            this.Login_Label_LogInForm.AutoSize = true;
            this.Login_Label_LogInForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Label_LogInForm.Location = new System.Drawing.Point(34, 37);
            this.Login_Label_LogInForm.Name = "Login_Label_LogInForm";
            this.Login_Label_LogInForm.Size = new System.Drawing.Size(96, 37);
            this.Login_Label_LogInForm.TabIndex = 0;
            this.Login_Label_LogInForm.Text = "Login";
            // 
            // EmployeeID_Label_LogInForm
            // 
            this.EmployeeID_Label_LogInForm.AutoSize = true;
            this.EmployeeID_Label_LogInForm.Location = new System.Drawing.Point(38, 104);
            this.EmployeeID_Label_LogInForm.Name = "EmployeeID_Label_LogInForm";
            this.EmployeeID_Label_LogInForm.Size = new System.Drawing.Size(119, 20);
            this.EmployeeID_Label_LogInForm.TabIndex = 1;
            this.EmployeeID_Label_LogInForm.Text = "Medarbejder ID";
            // 
            // Password_Label_LogInForm
            // 
            this.Password_Label_LogInForm.AutoSize = true;
            this.Password_Label_LogInForm.Location = new System.Drawing.Point(38, 195);
            this.Password_Label_LogInForm.Name = "Password_Label_LogInForm";
            this.Password_Label_LogInForm.Size = new System.Drawing.Size(78, 20);
            this.Password_Label_LogInForm.TabIndex = 2;
            this.Password_Label_LogInForm.Text = "Password";
            // 
            // EmployeeID_textBox_LogInForm
            // 
            this.EmployeeID_textBox_LogInForm.Location = new System.Drawing.Point(40, 127);
            this.EmployeeID_textBox_LogInForm.Name = "EmployeeID_textBox_LogInForm";
            this.EmployeeID_textBox_LogInForm.Size = new System.Drawing.Size(290, 26);
            this.EmployeeID_textBox_LogInForm.TabIndex = 3;
            // 
            // Password_textBox_LogInForm
            // 
            this.Password_textBox_LogInForm.Location = new System.Drawing.Point(40, 218);
            this.Password_textBox_LogInForm.Name = "Password_textBox_LogInForm";
            this.Password_textBox_LogInForm.PasswordChar = '*';
            this.Password_textBox_LogInForm.Size = new System.Drawing.Size(290, 26);
            this.Password_textBox_LogInForm.TabIndex = 4;
            // 
            // Cancel_button_LogInForm
            // 
            this.Cancel_button_LogInForm.BackColor = System.Drawing.Color.Transparent;
            this.Cancel_button_LogInForm.Location = new System.Drawing.Point(41, 289);
            this.Cancel_button_LogInForm.Name = "Cancel_button_LogInForm";
            this.Cancel_button_LogInForm.Size = new System.Drawing.Size(134, 35);
            this.Cancel_button_LogInForm.TabIndex = 5;
            this.Cancel_button_LogInForm.Text = "Annuller";
            this.Cancel_button_LogInForm.UseVisualStyleBackColor = false;
            this.Cancel_button_LogInForm.Click += new System.EventHandler(this.Cancel_button_LogInForm_Click);
            // 
            // Login_button_LogInForm
            // 
            this.Login_button_LogInForm.BackColor = System.Drawing.Color.Transparent;
            this.Login_button_LogInForm.Location = new System.Drawing.Point(197, 289);
            this.Login_button_LogInForm.Name = "Login_button_LogInForm";
            this.Login_button_LogInForm.Size = new System.Drawing.Size(133, 35);
            this.Login_button_LogInForm.TabIndex = 6;
            this.Login_button_LogInForm.Text = "Login";
            this.Login_button_LogInForm.UseVisualStyleBackColor = false;
            this.Login_button_LogInForm.Click += new System.EventHandler(this.Login_button_LogInForm_Click);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(381, 423);
            this.Controls.Add(this.Login_button_LogInForm);
            this.Controls.Add(this.Cancel_button_LogInForm);
            this.Controls.Add(this.Password_textBox_LogInForm);
            this.Controls.Add(this.EmployeeID_textBox_LogInForm);
            this.Controls.Add(this.Password_Label_LogInForm);
            this.Controls.Add(this.EmployeeID_Label_LogInForm);
            this.Controls.Add(this.Login_Label_LogInForm);
            this.Name = "LogInForm";
            this.Text = "LogInForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login_Label_LogInForm;
        private System.Windows.Forms.Label EmployeeID_Label_LogInForm;
        private System.Windows.Forms.Label Password_Label_LogInForm;
        private System.Windows.Forms.TextBox EmployeeID_textBox_LogInForm;
        private System.Windows.Forms.TextBox Password_textBox_LogInForm;
        private System.Windows.Forms.Button Cancel_button_LogInForm;
        private System.Windows.Forms.Button Login_button_LogInForm;
    }
}