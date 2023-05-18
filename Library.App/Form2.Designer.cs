namespace Library.App
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
            emailLogin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            passwordLogin = new TextBox();
            label5 = new Label();
            label6 = new Label();
            passwordReg = new TextBox();
            label7 = new Label();
            emailReg = new TextBox();
            label8 = new Label();
            nameReg = new TextBox();
            label9 = new Label();
            passwordRegRetry = new TextBox();
            agreement = new CheckBox();
            login = new Button();
            registration = new Button();
            checkPasswordReg = new CheckBox();
            checkPassword = new CheckBox();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // emailLogin
            // 
            emailLogin.BackColor = Color.Ivory;
            emailLogin.Location = new Point(63, 100);
            emailLogin.Name = "emailLogin";
            emailLogin.Size = new Size(165, 27);
            emailLogin.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.NavajoWhite;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(63, 9);
            label1.Name = "label1";
            label1.Size = new Size(406, 27);
            label1.TabIndex = 20;
            label1.Text = "Добро пожаловать в библиотеку!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(62, 47);
            label2.Name = "label2";
            label2.Size = new Size(165, 23);
            label2.TabIndex = 21;
            label2.Text = "Вход в аккаунт";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(63, 77);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 22;
            label3.Text = "Логин:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(63, 132);
            label4.Name = "label4";
            label4.Size = new Size(81, 21);
            label4.TabIndex = 24;
            label4.Text = "Пароль:";
            // 
            // passwordLogin
            // 
            passwordLogin.BackColor = Color.Ivory;
            passwordLogin.Location = new Point(63, 155);
            passwordLogin.Name = "passwordLogin";
            passwordLogin.Size = new Size(165, 27);
            passwordLogin.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(468, 47);
            label5.Name = "label5";
            label5.Size = new Size(139, 23);
            label5.TabIndex = 25;
            label5.Text = "Регистрация";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(552, 77);
            label6.Name = "label6";
            label6.Size = new Size(81, 21);
            label6.TabIndex = 29;
            label6.Text = "Пароль:";
            // 
            // passwordReg
            // 
            passwordReg.BackColor = Color.Ivory;
            passwordReg.Location = new Point(552, 100);
            passwordReg.Name = "passwordReg";
            passwordReg.Size = new Size(165, 27);
            passwordReg.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(357, 132);
            label7.Name = "label7";
            label7.Size = new Size(189, 21);
            label7.TabIndex = 27;
            label7.Text = "Электронная почта:";
            // 
            // emailReg
            // 
            emailReg.BackColor = Color.Ivory;
            emailReg.Location = new Point(358, 155);
            emailReg.Name = "emailReg";
            emailReg.Size = new Size(165, 27);
            emailReg.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(358, 77);
            label8.Name = "label8";
            label8.Size = new Size(146, 21);
            label8.TabIndex = 31;
            label8.Text = "Фамилия, Имя:";
            // 
            // nameReg
            // 
            nameReg.BackColor = Color.Ivory;
            nameReg.Location = new Point(358, 101);
            nameReg.Name = "nameReg";
            nameReg.Size = new Size(165, 27);
            nameReg.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(552, 132);
            label9.Name = "label9";
            label9.Size = new Size(178, 21);
            label9.TabIndex = 33;
            label9.Text = "Повторите пароль:";
            // 
            // passwordRegRetry
            // 
            passwordRegRetry.BackColor = Color.Ivory;
            passwordRegRetry.Location = new Point(552, 155);
            passwordRegRetry.Name = "passwordRegRetry";
            passwordRegRetry.Size = new Size(165, 27);
            passwordRegRetry.TabIndex = 32;
            // 
            // agreement
            // 
            agreement.AutoSize = true;
            agreement.Font = new Font("Century Gothic", 9.8F, FontStyle.Regular, GraphicsUnit.Point);
            agreement.Location = new Point(318, 241);
            agreement.Name = "agreement";
            agreement.Size = new Size(436, 25);
            agreement.TabIndex = 34;
            agreement.Text = "Согласие на обработку Персональных данных";
            agreement.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            login.BackColor = Color.Tan;
            login.Font = new Font("Century Gothic", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            login.Location = new Point(63, 272);
            login.Name = "login";
            login.Size = new Size(165, 48);
            login.TabIndex = 35;
            login.Text = "Войти";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // registration
            // 
            registration.BackColor = Color.Tan;
            registration.Font = new Font("Century Gothic", 9.8F, FontStyle.Bold, GraphicsUnit.Point);
            registration.Location = new Point(358, 272);
            registration.Name = "registration";
            registration.Size = new Size(357, 48);
            registration.TabIndex = 36;
            registration.Text = "Зарегистрироваться";
            registration.UseVisualStyleBackColor = false;
            registration.Click += registration_Click;
            // 
            // checkPasswordReg
            // 
            checkPasswordReg.AutoSize = true;
            checkPasswordReg.Font = new Font("Century Gothic", 9.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkPasswordReg.Location = new Point(552, 198);
            checkPasswordReg.Name = "checkPasswordReg";
            checkPasswordReg.Size = new Size(191, 25);
            checkPasswordReg.TabIndex = 37;
            checkPasswordReg.Text = "Видимость пароля";
            checkPasswordReg.UseVisualStyleBackColor = true;
            checkPasswordReg.CheckedChanged += checkPasswordReg_CheckedChanged;
            // 
            // checkPassword
            // 
            checkPassword.AutoSize = true;
            checkPassword.Font = new Font("Century Gothic", 9.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkPassword.Location = new Point(62, 198);
            checkPassword.Name = "checkPassword";
            checkPassword.Size = new Size(191, 25);
            checkPassword.TabIndex = 38;
            checkPassword.Text = "Видимость пароля";
            checkPassword.UseVisualStyleBackColor = true;
            checkPassword.CheckedChanged += checkPassword_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.SaddleBrown;
            label10.Location = new Point(62, 335);
            label10.Name = "label10";
            label10.Size = new Size(0, 16);
            label10.TabIndex = 39;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imgonline_com_ua_Resize_zsuVGihDvVx;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(245, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 98);
            pictureBox1.TabIndex = 40;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(757, 420);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(checkPassword);
            Controls.Add(checkPasswordReg);
            Controls.Add(registration);
            Controls.Add(login);
            Controls.Add(agreement);
            Controls.Add(label9);
            Controls.Add(passwordRegRetry);
            Controls.Add(label8);
            Controls.Add(nameReg);
            Controls.Add(label6);
            Controls.Add(passwordReg);
            Controls.Add(label7);
            Controls.Add(emailReg);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(passwordLogin);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(emailLogin);
            Name = "Form2";
            Text = "Вход в учетную запись";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox emailLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox passwordLogin;
        private Label label5;
        private Label label6;
        private TextBox passwordReg;
        private Label label7;
        private TextBox emailReg;
        private Label label8;
        private TextBox nameReg;
        private Label label9;
        private TextBox passwordRegRetry;
        private CheckBox agreement;
        private Button login;
        private Button registration;
        private CheckBox checkPasswordReg;
        private CheckBox checkPassword;
        private Label label10;
        private PictureBox pictureBox1;
    }
}