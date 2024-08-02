namespace PracticsDesktop
{
    partial class Form2
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
            tbName = new TextBox();
            tbSurName = new TextBox();
            tbllogin = new TextBox();
            tbEmail = new TextBox();
            tbPhone = new TextBox();
            tbPassword = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            lbDate = new Label();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(12, 35);
            tbName.Name = "tbName";
            tbName.PlaceholderText = "Ваше имя: ";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 0;
            // 
            // tbSurName
            // 
            tbSurName.Location = new Point(12, 75);
            tbSurName.Name = "tbSurName";
            tbSurName.PlaceholderText = "Фамилия: ";
            tbSurName.Size = new Size(100, 23);
            tbSurName.TabIndex = 1;
            // 
            // tbllogin
            // 
            tbllogin.Location = new Point(12, 119);
            tbllogin.Name = "tbllogin";
            tbllogin.PlaceholderText = "Ваш логин: ";
            tbllogin.Size = new Size(100, 23);
            tbllogin.TabIndex = 2;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(12, 158);
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "Ваш Email";
            tbEmail.Size = new Size(100, 23);
            tbEmail.TabIndex = 3;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(12, 201);
            tbPhone.Name = "tbPhone";
            tbPhone.PlaceholderText = "Ваш телефон";
            tbPhone.Size = new Size(100, 23);
            tbPhone.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(12, 244);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.PlaceholderText = "Ваш пароль";
            tbPassword.Size = new Size(100, 23);
            tbPassword.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 295);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Location = new Point(13, 274);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(90, 15);
            lbDate.TabIndex = 9;
            lbDate.Text = "Дата рождения";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbDate);
            Controls.Add(dateTimePicker1);
            Controls.Add(tbPassword);
            Controls.Add(tbPhone);
            Controls.Add(tbEmail);
            Controls.Add(tbllogin);
            Controls.Add(tbSurName);
            Controls.Add(tbName);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private TextBox tbSurName;
        private TextBox tbllogin;
        private TextBox tbEmail;
        private TextBox tbPhone;
        private TextBox tbPassword;
        private DateTimePicker dateTimePicker1;
        private Label lbDate;
    }
}