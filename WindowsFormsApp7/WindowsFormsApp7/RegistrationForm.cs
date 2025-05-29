using System;
using System.IO;
using System.Windows.Forms;
using CalendarApp;

namespace WinFormsApp1
{
    public partial class RegistrationForm : Form
    {
        private const string UsersFilePath = "users.txt";

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

            try
            {
               
                string userData = $"{login}:{password}:{phone}";

                
                File.AppendAllText(UsersFilePath, userData + Environment.NewLine);

                MessageBox.Show("Регистрация прошла успешно!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1 form = new Form1();
                form.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backToLogin_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
