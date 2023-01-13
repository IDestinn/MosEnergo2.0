using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MosEnergo2._0
{
    public partial class KvartiraMenu : Form
    {
        public String UserPassport;
        public KvartiraMenu()
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

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        Point LastPoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogInMenu LogInMenu = new LogInMenu();
            LogInMenu.Show();
        }

        private void AddFlatButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFlatMenu addFlatMenu = new AddFlatMenu
            {
                UserPassport = UserPassport
            };
            addFlatMenu.Show();
        }

        // Включает кнопки в зависимости от существующих квартир
        private void KvartiraMenu_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT id_kvartira FROM `kvartira` WHERE `semshik_passport` = @Passport", db.GetConnection());
            command.Parameters.Add("@Passport", MySqlDbType.VarChar).Value = UserPassport;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                FlatButton1.Visible = true;
            if (table.Rows.Count > 1)
                FlatButton2.Visible = true;
            if (table.Rows.Count > 2)
                FlatButton3.Visible = true;
            if (table.Rows.Count > 3)
                FlatButton4.Visible = true;
            if (table.Rows.Count > 4)
            {
                FlatButton5.Visible = true;
                AddFlatButton.Visible = false;
                LimitLabel.Visible = true;
            }   
        }
        
        // Выбор квартиры
        public UInt32 IDKvartiri;
        private void FlatButton_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt16(this.Tag);

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT id_kvartira FROM `kvartira` WHERE `semshik_passport` = @Passport", db.GetConnection());
            command.Parameters.Add("@Passport", MySqlDbType.VarChar).Value = UserPassport;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            IDKvartiri = Convert.ToUInt32(table.Rows[index][0]);
            this.Hide();
            Flat flat = new Flat
            {
                UserPassport = UserPassport,
                IDKvartiri = IDKvartiri
            };
            flat.Show();
        }

        // Удаление аккаунта
        private void DeliteAkkButton_Click(object sender, EventArgs e)
        {
            if(FlatButton1.Visible == true)
            {
                MessageBox.Show(this, "Для подтверждения удаления аккаунта сперва удалите все квартиры!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DELETE FROM `users` WHERE `semshik_passport` = @Passport", db.GetConnection());
            MySqlCommand command2 = new MySqlCommand("DELETE FROM `semshik` WHERE `passport` = @Passport", db.GetConnection());

            command.Parameters.Add("@Passport", MySqlDbType.VarChar).Value = UserPassport;
            command2.Parameters.Add("@Passport", MySqlDbType.VarChar).Value = UserPassport;

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(this, "Аккаунт удален!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                LogInMenu logInMenu = new LogInMenu();
                logInMenu.Show();
            }
            else
                MessageBox.Show(this, "Аккаунт не был удален! ;c", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            db.CloseConnection();
        }
    }
}
