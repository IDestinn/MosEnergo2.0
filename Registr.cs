using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MosEnergo2._0
{
    public partial class Registr : Form
    {
        public Registr()
        {
            InitializeComponent();
            TipPatronymic.SetToolTip(StarLabel, "Необязательное поле");
            TipPatronymic.SetToolTip(PatronymicLabel, "Необязательное поле");
        }

        private void ToSignInButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInMenu LogInMenu = new LogInMenu();
            LogInMenu.Show();
        }

        private void RegistrButton_Click(object sender, EventArgs e)
        {
            // Проверка полей ввода
            if (FirstNameField.Text == "")
            {
                MessageBox.Show(this, "Введите ваше имя!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (LastNameField.Text == "")
            {
                MessageBox.Show(this, "Введите вашу фамилию!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PassportField.Text == "")
            {
                MessageBox.Show(this, "Введите ваши паспортные данные! \nНеобязательно настоящие :)", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PassportField.TextLength < 12)
            {
                MessageBox.Show(this, "Номер паспорта некоректный! \nНедостаточно символов!\nНеобязательно настоящие :)", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (LoginField.Text == "")
            {
                MessageBox.Show(this, "Введите предпочитаемый вами логин!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PasswordField.Text == "")
            {
                MessageBox.Show(this, "Введите предпочитаемый вами пароль!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsUserExist() == true)
                return;

            if (IsPassportExist() == true)
                return;


            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `semshik` (`passport`, `firstname`, `lastname`, `patronymic`) VALUES (@Passport,@FN,@LN,@Patron);", db.GetConnection());
            MySqlCommand command2 = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `semshik_passport`) VALUES (@Login,@Password,@Passport);", db.GetConnection());
            try
            {
                command.Parameters.Add("@Passport", MySqlDbType.VarChar).Value = PassportField.Text;
                command.Parameters.Add("@FN", MySqlDbType.VarChar).Value = FirstNameField.Text;
                command.Parameters.Add("@LN", MySqlDbType.VarChar).Value = LastNameField.Text;
                command.Parameters.Add("@Patron", MySqlDbType.VarChar).Value = PatronymicFielde.Text;
                command2.Parameters.Add("@Login", MySqlDbType.VarChar).Value = LoginField.Text;
                command2.Parameters.Add("@Password", MySqlDbType.VarChar).Value = HasherMD5.HashPassword(PasswordField.Text);
                command2.Parameters.Add("@Passport", MySqlDbType.VarChar).Value = PassportField.Text;

                db.OpenConnection();

                if (command.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(this, "Вы успешно зарегистрированы!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    LogInMenu LogInMenu = new LogInMenu();
                    LogInMenu.Show();
                }
                else
                    MessageBox.Show(this, "Аккаунт не был создан! ;c", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                db.CloseConnection();
            }
            catch (MySqlException)
            {
                MessageBox.Show(this, "Не удалось подключиться к базе данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Проверка на совпадения логина
        public Boolean IsUserExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @UL", db.GetConnection());
            command.Parameters.Add("@UL", MySqlDbType.VarChar).Value = LoginField.Text;
            try
            {
                adapter.SelectCommand = command;
                adapter.Fill(table);
            }
            catch (AggregateException)
            {
                MessageBox.Show(this, "Не удалось подключиться к базе данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (table.Rows.Count > 0)
            {
                MessageBox.Show(this, "Такой логин уже занят, попробуйте другой!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        // Проверка на дублирование паспорта
        public Boolean IsPassportExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT passport FROM `semshik` WHERE `passport` = @Passport", db.GetConnection());
            command.Parameters.Add("@Passport", MySqlDbType.VarChar).Value = PassportField.Text;
            try
            {
                adapter.SelectCommand = command;
                adapter.Fill(table);
            }
            catch (AggregateException)
            {
                MessageBox.Show(this, "Не удалось подключиться к базе данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (table.Rows.Count > 0)
            {
                MessageBox.Show(this, "Такой паспорт уже есть в системе, попробуйте другой!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        // Проверки ввода
        private void PassportField_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) ^ e.KeyChar == 8)
            {
                e.Handled = true;
            }

            if (PassportField.TextLength == 2 ^ PassportField.TextLength == 5)
            {
                if (e.KeyChar != 8)
                {
                    PassportField.Text += " ";
                    PassportField.SelectionStart = PassportField.Text.Length;
                }
            }
            if (PassportField.TextLength == 12)
            {
                LoginField.Focus();
            }
        }

        // Перенос на следующие поля на клавишу "Enter"
        private void FirstNameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                LastNameField.Focus();
            }
        }

        private void LastNameField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PatronymicFielde.Focus();
            }
        }

        private void LoginField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PasswordField.Focus();
            }
        }

        private void PasswordField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                RegistrButton.PerformClick();
            }
        }

        private void Registr_Load(object sender, EventArgs e)
        {
            FirstNameField.Focus();
        }

        private void PatronymicFielde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                PassportField.Focus();
            }
        }
    }
}
