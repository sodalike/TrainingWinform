namespace prognostic_and_health_management_PHM_
{
    partial class Form_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.Txt_UserID = new System.Windows.Forms.TextBox();
            this.Login_Ok = new System.Windows.Forms.Button();
            this.Login_Cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password : ";
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(178, 133);
            this.Txt_Password.MaxLength = 20;
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.PasswordChar = '●';
            this.Txt_Password.Size = new System.Drawing.Size(100, 25);
            this.Txt_Password.TabIndex = 3;
            this.Txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Password_KeyPress);
            // 
            // Txt_UserID
            // 
            this.Txt_UserID.Location = new System.Drawing.Point(178, 86);
            this.Txt_UserID.MaxLength = 12;
            this.Txt_UserID.Name = "Txt_UserID";
            this.Txt_UserID.Size = new System.Drawing.Size(100, 25);
            this.Txt_UserID.TabIndex = 2;
            this.Txt_UserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_UserID_KeyPress);
            // 
            // Login_Ok
            // 
            this.Login_Ok.Location = new System.Drawing.Point(93, 202);
            this.Login_Ok.Name = "Login_Ok";
            this.Login_Ok.Size = new System.Drawing.Size(75, 23);
            this.Login_Ok.TabIndex = 4;
            this.Login_Ok.Text = "OK";
            this.Login_Ok.UseVisualStyleBackColor = true;
            this.Login_Ok.Click += new System.EventHandler(this.Login_Ok_Click);
            // 
            // Login_Cancel
            // 
            this.Login_Cancel.Location = new System.Drawing.Point(191, 202);
            this.Login_Cancel.Name = "Login_Cancel";
            this.Login_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Login_Cancel.TabIndex = 5;
            this.Login_Cancel.Text = "Cancel";
            this.Login_Cancel.UseVisualStyleBackColor = true;
            this.Login_Cancel.Click += new System.EventHandler(this.Login_Cancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prognostic and Health Management";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 260);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Login_Cancel);
            this.Controls.Add(this.Login_Ok);
            this.Controls.Add(this.Txt_Password);
            this.Controls.Add(this.Txt_UserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.TextBox Txt_UserID;
        private System.Windows.Forms.Button Login_Ok;
        private System.Windows.Forms.Button Login_Cancel;
        private System.Windows.Forms.Label label3;
    }
}