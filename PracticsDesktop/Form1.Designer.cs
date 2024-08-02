namespace PracticsDesktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbLogin = new TextBox();
            tbPassword = new TextBox();
            btJoin = new Button();
            btRegister = new Button();
            SuspendLayout();
            // 
            // tbLogin
            // 
            tbLogin.HideSelection = false;
            tbLogin.Location = new Point(212, 169);
            tbLogin.Name = "tbLogin";
            tbLogin.PlaceholderText = "Ваш логин";
            tbLogin.Size = new Size(189, 23);
            tbLogin.TabIndex = 0;
            
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(212, 208);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.PlaceholderText = "Ваш пароль";
            tbPassword.Size = new Size(189, 23);
            tbPassword.TabIndex = 1;
            // 
            // btJoin
            // 
            btJoin.Location = new Point(101, 252);
            btJoin.Name = "btJoin";
            btJoin.Size = new Size(189, 23);
            btJoin.TabIndex = 2;
            btJoin.Text = "Вход";
            btJoin.UseVisualStyleBackColor = true;
            btJoin.Click += btJoin_Click;
            // 
            // btRegister
            // 
            btRegister.Location = new Point(330, 252);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(147, 23);
            btRegister.TabIndex = 4;
            btRegister.Text = "Регистрация";
            btRegister.UseVisualStyleBackColor = true;
            btRegister.Click += btRegister_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 439);
            Controls.Add(btRegister);
            Controls.Add(btJoin);
            Controls.Add(tbPassword);
            Controls.Add(tbLogin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbLogin;
        private TextBox tbPassword;
        private Button btJoin;
        private Button btRegister;
    }
}
