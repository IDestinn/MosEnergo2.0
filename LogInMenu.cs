using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms; 

namespace MosEnergo2._0
{
    public partial class LogInMenu : Form
    {
        public LogInMenu()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Silver;
        }

        Point LastPoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
          if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }
        
        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void User_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kalculator MainMenu = new Kalculator();
            MainMenu.Show();
        }

        private void Sign_in_button_Click(object sender, EventArgs e)
        {

            // Проверка полей ввода
            if (Login.Text == "")
            {
                MessageBox.Show(this, "Введите Логин!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Password.Text == "")
            {
                MessageBox.Show(this, "Введите Пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String LoginUser = Login.Text;
            String PasswordUser = HasherMD5.HashPassword(Password.Text);

            // Подключения и формирования запроса к БД
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT semshik_passport FROM `users` WHERE `login` = @UL AND `password` = @UP", db.GetConnection());
            command.Parameters.Add("@UL", MySqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add("@UP", MySqlDbType.VarChar).Value = PasswordUser;

            try
            {
                adapter.SelectCommand = command;
                adapter.Fill(table);
            

            if(table.Rows.Count > 0)
            {
                this.Hide();
                KvartiraMenu kvartiraMenu = new KvartiraMenu();
                kvartiraMenu.UserPassport = table.Rows[0][0].ToString();
                kvartiraMenu.Show();
            }
            else
            {
                MessageBox.Show(this, "Неверный логин или пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }
            catch (MySqlException)
            {
                MessageBox.Show(this, "Не удалось подключиться к базе данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Registr_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registr registr = new Registr();
            registr.Show();
        }

        // Перенос строки на клавишу Enter
        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Password.Focus();
            }

        }

        private void Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Sign_in_button.PerformClick();
            }
        }
    }
}
