namespace WinFormsApp1
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.writeLogin = new System.Windows.Forms.Label();
            this.registerPassword = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.backToLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            

            this.textBox1.Location = new System.Drawing.Point(120, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 0;
            

            this.textBox2.Location = new System.Drawing.Point(120, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 1;
            

            this.textBox3.Location = new System.Drawing.Point(120, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 2;
            

            this.register.Location = new System.Drawing.Point(120, 150);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(150, 30);
            this.register.TabIndex = 3;
            this.register.Text = "Зарегистрироваться";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            

            this.writeLogin.AutoSize = true;
            this.writeLogin.Location = new System.Drawing.Point(50, 53);
            this.writeLogin.Name = "writeLogin";
            this.writeLogin.Size = new System.Drawing.Size(41, 13);
            this.writeLogin.TabIndex = 4;
            this.writeLogin.Text = "Логин:";
           

            this.registerPassword.AutoSize = true;
            this.registerPassword.Location = new System.Drawing.Point(50, 83);
            this.registerPassword.Name = "registerPassword";
            this.registerPassword.Size = new System.Drawing.Size(48, 13);
            this.registerPassword.TabIndex = 5;
            this.registerPassword.Text = "Пароль:";
            

            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Location = new System.Drawing.Point(50, 113);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(55, 13);
            this.phoneNumber.TabIndex = 6;
            this.phoneNumber.Text = "Телефон:";
            

            this.backToLogin.Location = new System.Drawing.Point(120, 190);
            this.backToLogin.Name = "backToLogin";
            this.backToLogin.Size = new System.Drawing.Size(150, 30);
            this.backToLogin.TabIndex = 7;
            this.backToLogin.Text = "Назад";
            this.backToLogin.UseVisualStyleBackColor = true;
            this.backToLogin.Click += new System.EventHandler(this.backToLogin_Click);
            

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.backToLogin);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.registerPassword);
            this.Controls.Add(this.writeLogin);
            this.Controls.Add(this.register);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "RegistrationForm";
            this.Text = "Форма регистрации";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label writeLogin;
        private System.Windows.Forms.Label registerPassword;
        private System.Windows.Forms.Label phoneNumber;
        private System.Windows.Forms.Button backToLogin;
    }
}
