using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MosEnergo2._0
{
    public partial class Flat : Form
    {
        public UInt32 IDKvartiri;
        public string UserPassport;
        public Flat()
        {
            InitializeComponent();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            KvartiraMenu kvartiraMenu = new KvartiraMenu();
            kvartiraMenu.UserPassport = UserPassport;
            kvartiraMenu.Show();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            string TType;
            double MTarif1 = 0;
            double MTarif2 = 0;
            double MTarif3 = 0;
            double Total = 0;

            if (ErrorLabel.Visible == true)
            {
                MessageBox.Show(this, "Вы уже передавали сегодня показания!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Подключение и формирования запроса к БД
            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            DataTable table2 = new DataTable();
            DataTable table3 = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `kvartira` WHERE `id_kvartira` = @IDKvartira", db.GetConnection());
            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `tariffi` WHERE `type` = @Type AND now() - datetariff > 0 ORDER BY `datetariff` LIMIT 1;", db.GetConnection());
            MySqlCommand command3 = new MySqlCommand("SELECT * FROM `shetckik` WHERE `kvartira_id_kvartira` = @IDKvartira", db.GetConnection());
            MySqlCommand command4 = new MySqlCommand("INSERT INTO `checki` (`pokaz1`, `pokaz2`, `pokaz3`, `total`, `data`, `kvartira_id_kvartira`, `tariffi_datetariff`, `tariffi_type`) VALUES (@P1,@P2,@P3,@Total,@Data,@KID,@TDate,@TType);", db.GetConnection());

            command.Parameters.Add("@IDKvartira", MySqlDbType.UInt32).Value = IDKvartiri;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (Convert.ToUInt16(table.Rows[0][2]) == 1)
                TType = "Selo";
            else if (Convert.ToUInt16(table.Rows[0][4]) == 1 && Convert.ToUInt16(table.Rows[0][5]) == 1)
                TType = "EStoveEHeater";
            else if (Convert.ToUInt16(table.Rows[0][4]) == 1 && Convert.ToUInt16(table.Rows[0][5]) == 0)
                TType = "EStoveNone";
            else if (Convert.ToUInt16(table.Rows[0][4]) == 0 && Convert.ToUInt16(table.Rows[0][5]) == 1)
                TType = "NoneEHeater";
            else
                TType = "GasNone";

            command2.Parameters.Add("@Type", MySqlDbType.VarChar).Value = TType;

            adapter.SelectCommand = command2;
            adapter.Fill(table2);

            command3.Parameters.Add("@IDKvartira", MySqlDbType.UInt32).Value = IDKvartiri;

            adapter.SelectCommand = command3;
            adapter.Fill(table3);

            if (table3.Rows.Count > 0)
            {
                if (Convert.ToInt16(table3.Rows[0][2]) == 1)
                {
                    MTarif1 = (double)(table2.Rows[0][5]);
                    Tarif2.Text = null;
                    Tarif3.Text = null;
                    Total = Math.Round(((Convert.ToDouble(Tarif1.Text) - MinT1) * MTarif1), 2);
                }
                if (Convert.ToInt16(table3.Rows[0][2]) == 2)
                {
                    MTarif1 = (double)(table2.Rows[0][3]);
                    MTarif2 = (double)(table2.Rows[0][4]);
                    Tarif3.Text = null;
                    Total = Math.Round(((Convert.ToDouble(Tarif1.Text) - MinT1) * MTarif1) + ((Convert.ToDouble(Tarif2.Text) - MinT2) * MTarif2), 2);
                }
                if (Convert.ToInt16(table3.Rows[0][2]) == 3)
                {
                    MTarif1 = (double)(table2.Rows[0][6]);
                    MTarif2 = (double)(table2.Rows[0][4]);
                    MTarif3 = (double)(table2.Rows[0][5]);
                    Total = Math.Round(((Convert.ToDouble(Tarif1.Text) - MinT1) * MTarif1) +
                        ((Convert.ToDouble(Tarif2.Text) - MinT2) * MTarif2) +
                        ((Convert.ToDouble(Tarif3.Text) - MinT3) * MTarif3), 2);
                }

                ResultNumber.Text = Convert.ToString(Math.Round(Total, 2));
            }
            else
            {
                MTarif1 = (double)(table2.Rows[0][2]);
                Total = Math.Round(MTarif1 * Convert.ToUInt16(table.Rows[0][3]), 2);
                ResultNumber.Text = Convert.ToString(Math.Round(Total, 2));
                Tarif1.Text = null;
                Tarif2.Text = null;
                Tarif3.Text = null;
            }

            if ((Convert.ToDouble(Tarif1.Text == "" ? null : Tarif1.Text) < MinT1) && Convert.ToInt16(table3.Rows[0][2]) >= 1)
            {
                MessageBox.Show(this, "Нынешние показания не могут быть меньше прошлых!\n Ошибка в Т1", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((Convert.ToDouble(Tarif2.Text == "" ? null : Tarif2.Text) < MinT2) && Convert.ToInt16(table3.Rows[0][2]) >= 2)
            {
                MessageBox.Show(this, "Нынешние показания не могут быть меньше прошлых!\n Ошибка в Т2", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((Convert.ToDouble(Tarif3.Text == "" ? null : Tarif3.Text) < MinT3) && Convert.ToInt16(table3.Rows[0][2]) == 3)
            {
                MessageBox.Show(this, "Нынешние показания не могут быть меньше прошлых!\n Ошибка в Т3", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            command4.Parameters.Add("@P1", MySqlDbType.Double).Value = (Tarif1.Text == "" ? null : Tarif1.Text);
            command4.Parameters.Add("@P2", MySqlDbType.Double).Value = (Tarif2.Text == "" ? null : Tarif2.Text);
            command4.Parameters.Add("@P3", MySqlDbType.Double).Value = (Tarif3.Text == "" ? null : Tarif3.Text);
            command4.Parameters.Add("@Total", MySqlDbType.VarChar).Value = Total;
            command4.Parameters.Add("@Data", MySqlDbType.Date).Value = DateTime.Today;
            command4.Parameters.Add("@KID", MySqlDbType.UInt32).Value = IDKvartiri;
            command4.Parameters.Add("@TDate", MySqlDbType.Date).Value = table2.Rows[0][0];
            command4.Parameters.Add("@TType", MySqlDbType.VarChar).Value = TType;


            db.OpenConnection();

            if (command4.ExecuteNonQuery() == 1)
                MessageBox.Show(this, "Ваш чек успешно зарегистрирован!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(this, "Ваш чек не прошел сертификацияю! ;c\nПроверьте коректность записи ваших данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            db.CloseConnection();
        }

        public double MinT1;
        public double MinT2;
        public double MinT3;

        // Метод заполняющий информацию о выбранной квартире 
        private void Flat_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            DataTable table2 = new DataTable();
            DataTable table3 = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `kvartira` WHERE `id_kvartira` = @IDKvartira", db.GetConnection());
            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `shetckik` WHERE `kvartira_id_kvartira` = @IDKvartira", db.GetConnection());
            MySqlCommand command3 = new MySqlCommand("SELECT * FROM `checki` WHERE `kvartira_id_kvartira` = @IDKvartira ORDER BY `checki`.`data` DESC LIMIT 1", db.GetConnection());
            command.Parameters.Add("@IDKvartira", MySqlDbType.UInt32).Value = IDKvartiri;
            command2.Parameters.Add("@IDKvartira", MySqlDbType.UInt32).Value = IDKvartiri;
            command3.Parameters.Add("@IDKvartira", MySqlDbType.UInt32).Value = IDKvartiri;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            adapter.SelectCommand = command2;
            adapter.Fill(table2);
            adapter.SelectCommand = command3;
            adapter.Fill(table3);

            if (table3.Rows.Count > 0)
            {
                if (!DBNull.Value.Equals(table3.Rows[0][1]))
                    MinT1 = Convert.ToDouble(table3.Rows[0][1]);
                if (!DBNull.Value.Equals(table3.Rows[0][2]))
                    MinT2 = Convert.ToDouble(table3.Rows[0][2]);
                if (!DBNull.Value.Equals(table3.Rows[0][3]))
                    MinT3 = Convert.ToDouble(table3.Rows[0][3]);

                if (Convert.ToDateTime(table3.Rows[0][5]) == DateTime.Today)
                    ErrorLabel.Visible = true;
            }

            HouseLabel.Text =
                "Адрес: " + table.Rows[0][7] +
                "\nКвартира: " + table.Rows[0][1] +
                "\nКол-во проживающих: " + table.Rows[0][3];
            if (table2.Rows.Count == 1)
            {
                switch (Convert.ToInt32(table2.Rows[0][2]))
                {
                    case 3:
                        HouseLabel.Text += "\nСчетчик: Трехтарифный";
                        if (table3.Rows.Count > 0)
                        {
                            HistoryLabel.Text =
                            "Т1: " + table3.Rows[0][1] +
                            "\nТ2: " + table3.Rows[0][2] +
                            "\nТ3: " + table3.Rows[0][3];
                        }
                        else
                            HistoryLabel.Text =
                            "Т1: 0\nТ2: 0\nТ3: 0";

                        break;
                    case 2:
                        HouseLabel.Text += "\nСчетчик: Двухтарифный";
                        Tarif3.Visible = false;
                        T3Label.Visible = false;
                        if (table3.Rows.Count > 0)
                        {
                            HistoryLabel.Text =
                            "Т1: " + table3.Rows[0][1] +
                            "\nТ2: " + table3.Rows[0][2];
                        }
                        else
                            HistoryLabel.Text =
                            "Т1: 0\nТ2: 0";
                        break;
                    case 1:
                        HouseLabel.Text += "\nСчетчик: Однотарифный";
                        Tarif2.Visible = false;
                        T2Label.Visible = false;
                        Tarif3.Visible = false;
                        T3Label.Visible = false;
                        if (table3.Rows.Count > 0)
                        {
                            HistoryLabel.Text =
                                 "Т1: " + table3.Rows[0][1];
                        }
                        else
                            HistoryLabel.Text =
                            "Т1: 0";
                        break;
                }
            }
            else
            {
                HouseLabel.Text += "\nСчетчик: Нет счетчика";
                PokazaniyaPanel.Visible = false;
                PastPokazPanel.Visible = false;
            }
            if (Convert.ToBoolean(table.Rows[0][4]) == false)
                HouseLabel.Text += "\nЭлектро плита ❌";
            else
                HouseLabel.Text += "\nЭлектро плита ✔";

            if (Convert.ToBoolean(table.Rows[0][5]) == false)
                HouseLabel.Text += "\nЭлектро обогреватель ❌";
            else
                HouseLabel.Text += "\nЭлектро обогреватель ✔";

            if (Convert.ToBoolean(table.Rows[0][2]) == false)
                HouseLabel.Text += "\nСельская местность ❌";
            else
                HouseLabel.Text += "\nСельская местность ✔";
        }

        // Метод для удаления информации о квартире 
        private void DeleteFlatButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            DataTable table2 = new DataTable();
            MySqlCommand command = new MySqlCommand("DELETE FROM `shetckik` WHERE `kvartira_id_kvartira` = @Flat_id", db.GetConnection());
            MySqlCommand command2 = new MySqlCommand("DELETE FROM `kvartira` WHERE `id_kvartira` = @Flat_id", db.GetConnection());
            MySqlCommand command3 = new MySqlCommand("DELETE FROM `checki` WHERE `kvartira_id_kvartira` = @Flat_id", db.GetConnection());
            MySqlCommand command4 = new MySqlCommand("SELECT * FROM `checki` WHERE `kvartira_id_kvartira` = @Flat_id", db.GetConnection());
            MySqlCommand command5 = new MySqlCommand("SELECT * FROM `shetckik` WHERE `kvartira_id_kvartira` = @Flat_id", db.GetConnection());

            command.Parameters.Add("@Flat_id", MySqlDbType.UInt32).Value = IDKvartiri;
            command2.Parameters.Add("@Flat_id", MySqlDbType.UInt32).Value = IDKvartiri;
            command3.Parameters.Add("@Flat_id", MySqlDbType.UInt32).Value = IDKvartiri;
            command4.Parameters.Add("@Flat_id", MySqlDbType.UInt32).Value = IDKvartiri;
            command5.Parameters.Add("@Flat_id", MySqlDbType.UInt32).Value = IDKvartiri;

            adapter.SelectCommand = command4;
            adapter.Fill(table);

            adapter.SelectCommand = command5;
            adapter.Fill(table2);

            db.OpenConnection();
            if (table2.Rows.Count > 0)
            {
                if (table.Rows.Count > 0)
                {
                    if (command.ExecuteNonQuery() == 1 && command3.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show(this, "Квартира была удалена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        KvartiraMenu kvartiraMenu = new KvartiraMenu();
                        kvartiraMenu.UserPassport = UserPassport;
                        kvartiraMenu.Show();
                    }
                    else
                        MessageBox.Show(this, "Квартира не была удалена! ;c", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (command.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show(this, "Квартира была удалена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        KvartiraMenu kvartiraMenu = new KvartiraMenu();
                        kvartiraMenu.UserPassport = UserPassport;
                        kvartiraMenu.Show();
                    }
                    else
                        MessageBox.Show(this, "Квартира не была удалена! ;c", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (table.Rows.Count > 0)
                {
                    if (command3.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show(this, "Квартира была удалена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        KvartiraMenu kvartiraMenu = new KvartiraMenu();
                        kvartiraMenu.UserPassport = UserPassport;
                        kvartiraMenu.Show();
                    }
                    else
                        MessageBox.Show(this, "Квартира не была удалена! ;c", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (command2.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show(this, "Квартира была удалена!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        KvartiraMenu kvartiraMenu = new KvartiraMenu();
                        kvartiraMenu.UserPassport = UserPassport;
                        kvartiraMenu.Show();
                    }
                    else
                        MessageBox.Show(this, "Квартира не была удалена! ;c", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            db.CloseConnection();
        }

        // Методы для проверки ввода
        private void Tarif1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
            if (e.KeyChar == 44 && Tarif1.TextLength == 0)
            {
                e.KeyChar = (char)8;
                Tarif1.Text = "0,0";
                Tarif1.SelectionStart = 3;
            }
            if (e.KeyChar == 8 && Tarif1.Text == "0,")
                Tarif1.Text = "";
        }

        private void Tarif2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
            if (e.KeyChar == 44 && Tarif2.TextLength == 0)
            {
                e.KeyChar = (char)8;
                Tarif2.Text = "0,0";
                Tarif2.SelectionStart = 3;
            }
            if (e.KeyChar == 8 && Tarif2.Text == "0,")
                Tarif2.Text = "";
        }

        private void Tarif3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
            if (e.KeyChar == 44 && Tarif3.TextLength == 0)
            {
                e.KeyChar = (char)8;
                Tarif3.Text = "0,0";
                Tarif3.SelectionStart = 3;
            }
            if (e.KeyChar == 8 && Tarif3.Text == "0,")
                Tarif3.Text = "";
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HistoryForm historyForm = new HistoryForm();
            historyForm.UserPassport = UserPassport;
            historyForm.IDKvartiri = IDKvartiri;
            historyForm.Show();

        }
    }
}
