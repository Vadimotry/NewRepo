using System;
using System.Windows.Forms;
using CalendarApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            string phone = textBox3.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка регистрации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password.Length < 5)
            {
                MessageBox.Show("Пароль должен содержать минимум 5 символов", "Ошибка регистрации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Регистрация прошла успешно!", "Успех",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
            this.Close();
        }

        private void backToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}