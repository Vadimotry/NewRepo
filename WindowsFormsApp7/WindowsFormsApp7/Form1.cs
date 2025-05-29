using System;
using System.IO;
using System.Windows.Forms;
using CalendarApp;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private const string UsersFilePath = "users.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, введите имя пользователя и пароль",
                    "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (username == "admin" && password == "12345")
            {
                MessageBox.Show("Вход выполнен успешно!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
                return;
            }


            if (CheckUserCredentials(username, password))
            {
                MessageBox.Show("Вход выполнен успешно!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверное имя пользователя или пароль",
                    "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckUserCredentials(string username, string password)
        {
            try
            {
                if (!File.Exists(UsersFilePath))
                {
                    return false;
                }

                string[] allUsers = File.ReadAllLines(UsersFilePath);

                foreach (string user in allUsers)
                {

                    string[] parts = user.Split(':');
                    if (parts.Length >= 2) 
                    {
                        string storedUsername = parts[0];
                        string storedPassword = parts[1];

                        if (storedUsername == username && storedPassword == password)
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении файла пользователей: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void registerUser_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }
    }
}
