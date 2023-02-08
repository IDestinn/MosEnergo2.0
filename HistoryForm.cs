using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MosEnergo2._0
{
    public partial class HistoryForm : Form
    {
        public string UserPassport;
        public UInt32 IDKvartiri;
        public HistoryForm()
        {
            InitializeComponent();
        }

        // 13.01.2023 13:28:16
        // Собирает данные о квартире, выбранной из предыдущей формы
        private List<Checki> GetChecks()
        {
            var list = new List<Checki>();
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `checki` WHERE `kvartira_id_kvartira` = @IDKvartira", db.GetConnection());

            command.Parameters.Add("@IDKvartira", MySqlDbType.UInt32).Value = IDKvartiri;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (!DBNull.Value.Equals(table.Rows[i][3]))
                {
                    list.Add(new Checki()
                    {
                        id_check = Convert.ToUInt32(table.Rows[i][0]),
                        date = Convert.ToDateTime(table.Rows[i][5]),
                        Pokaz1 = Convert.ToDouble(table.Rows[i][1]),
                        Pokaz2 = Convert.ToDouble(table.Rows[i][2]),
                        Pokaz3 = Convert.ToDouble(table.Rows[i][3])
                    });
                }
                else if (!DBNull.Value.Equals(table.Rows[i][2]))
                {
                    list.Add(new Checki()
                    {
                        id_check = Convert.ToUInt32(table.Rows[i][0]),
                        date = Convert.ToDateTime(table.Rows[i][5]),
                        Pokaz1 = Convert.ToDouble(table.Rows[i][1]),
                        Pokaz2 = Convert.ToDouble(table.Rows[i][2])
                    });
                    T3Label.Visible = false;
                    Tarif3.Visible = false;
                }
                else if (!DBNull.Value.Equals(table.Rows[i][1]))
                {
                    list.Add(new Checki()
                    {
                        id_check = Convert.ToUInt32(table.Rows[i][0]),
                        date = Convert.ToDateTime(table.Rows[i][5]),
                        Pokaz1 = Convert.ToDouble(table.Rows[i][1])
                    });
                    Tarif2.Visible = false;
                    T2Label.Visible = false;
                    Tarif3.Visible = false;
                    T3Label.Visible = false;
                }
                else
                {
                    list.Add(new Checki()
                    {
                        id_check = Convert.ToUInt32(table.Rows[i][0]),
                        date = Convert.ToDateTime(table.Rows[i][5])
                    });
                    PokazaniyaPanel.Visible = false;
                    UpdateButton.Visible = false;
                }
            }
            return list;
        }

        // 13.01.2023 13:28:16
        // Выход из меню "История чеков
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flat flat = new Flat();
            flat.UserPassport = UserPassport;
            flat.IDKvartiri = IDKvartiri;
            flat.Show();
        }

        public List<Checki> checks { get; set; }

        // 13.01.2023 13:28:16
        // Метод для формирования вида интерфейса
        private void HistoryForm_Load(object sender, EventArgs e)
        {
            var checks = this.checks;
            checks = GetChecks();

            DataGridViewChechi.DataSource = checks;
            DataGridViewChechi.Columns["Id_check"].Visible = false;
            DataGridViewChechi.Columns["Pokaz1"].Visible = false;
            DataGridViewChechi.Columns["Pokaz2"].Visible = false;
            DataGridViewChechi.Columns["Pokaz3"].Visible = false;
        }

        // 13.01.2023 13:28:16
        // Собирает информацию с чека
        private void DataGridViewChechi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var SelectedCheck = DataGridViewChechi.SelectedRows[0].DataBoundItem as Checki;
                Tarif1.Text = SelectedCheck.Pokaz1.ToString();
                Tarif2.Text = SelectedCheck.Pokaz2.ToString();
                Tarif3.Text = SelectedCheck.Pokaz3.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Найдена ошибка: " + ex.Message + " - " + ex.Source);
            }
        }

        public double MinT1 = 0;
        public double MinT2 = 0;
        public double MinT3 = 0;

        // 13.01.2023 13:28:16
        // Редактирование данных в чеке
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string TType;
            double MTarif1;
            double MTarif2;
            double MTarif3;
            double Total = 0;

            // Сохраняет выбранный пользователем чек
            var SelectedCheck = DataGridViewChechi.SelectedRows[0].DataBoundItem as Checki;

            Checki NoneSelectedCheck;
            // Если чек не выбран, выбирает самый новый
            if (DataGridViewChechi.SelectedRows[0].Index != 0)
                NoneSelectedCheck = DataGridViewChechi.Rows[Convert.ToInt16(DataGridViewChechi.SelectedRows[0].Index) - 1].DataBoundItem as Checki;
            else
                NoneSelectedCheck = SelectedCheck;

            var LastCheck = Convert.ToUInt32(SelectedCheck.id_check) - 1;

            // Поиск чека для изменения
            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table4 = new DataTable();
            MySqlCommand command5 = new MySqlCommand("SELECT * FROM `checki` WHERE `id_check` = @LIDCheck", db.GetConnection());

            if (NoneSelectedCheck != SelectedCheck)
            {
                command5.Parameters.Add("@LIDCheck", MySqlDbType.UInt32).Value = Convert.ToUInt32(NoneSelectedCheck.id_check);

                adapter.SelectCommand = command5;
                adapter.Fill(table4);

                if (table4.Rows.Count > 0)
                {
                    if (!DBNull.Value.Equals(table4.Rows[0][1]))
                        MinT1 = Convert.ToDouble(table4.Rows[0][1]);
                    if (!DBNull.Value.Equals(table4.Rows[0][2]))
                        MinT2 = Convert.ToDouble(table4.Rows[0][2]);
                    if (!DBNull.Value.Equals(table4.Rows[0][3]))
                        MinT3 = Convert.ToDouble(table4.Rows[0][3]);
                }
            }
            
            // Транзакция для изменения чека в БД
            DataTable table = new DataTable();
            DataTable table2 = new DataTable();
            DataTable table3 = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `kvartira` WHERE `id_kvartira` = @IDKvartira", db.GetConnection());
            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `tariffi` WHERE `type` = @Type AND now() - datetariff > 0 ORDER BY `datetariff` LIMIT 1;", db.GetConnection());
            MySqlCommand command3 = new MySqlCommand("SELECT * FROM `shetckik` WHERE `kvartira_id_kvartira` = @IDKvartira", db.GetConnection());
            MySqlCommand command4 = new MySqlCommand("UPDATE `checki` SET `pokaz1` = @P1, `pokaz2` = @P2, `pokaz3` = @P3, `total` = @Total WHERE `checki`.`id_check` = @IDCheck", db.GetConnection());

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

            // 13.01.2023 13:28:16
            // Расчет итоговой функции
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
            }
            else
            {
                MTarif1 = (double)(table2.Rows[0][2]);
                Total = Math.Round(MTarif1 * Convert.ToUInt16(table.Rows[0][3]), 2);
                Tarif1.Text = null;
                Tarif2.Text = null;
                Tarif3.Text = null;
            }

            command4.Parameters.Add("@P1", MySqlDbType.Double).Value = Tarif1.Text == "" ? null : Tarif1.Text;
            command4.Parameters.Add("@P2", MySqlDbType.Double).Value = Tarif2.Text == "" ? null : Tarif2.Text;
            command4.Parameters.Add("@P3", MySqlDbType.Double).Value = Tarif3.Text == "" ? null : Tarif3.Text;
            command4.Parameters.Add("@IDCheck", MySqlDbType.UInt32).Value = Convert.ToUInt32(SelectedCheck.id_check);
            command4.Parameters.Add("@Total", MySqlDbType.Double).Value = Convert.ToDouble(Total);

            db.OpenConnection();

            // 13.01.2023 13:28:16
            // Запуск транзакции
            if (command4.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(this, "Чек обновлен!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                HistoryForm historyForm = new HistoryForm
                {
                    UserPassport = UserPassport,
                    IDKvartiri = IDKvartiri
                };
                historyForm.Show();
            }
            else
                MessageBox.Show(this, "Чек не был обновлен! ;c", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            db.CloseConnection();
        }

        // 13.01.2023 13:28:16
        // Удаление данных из БД
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var SelectedCheck = DataGridViewChechi.SelectedRows[0].DataBoundItem as Checki;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DELETE FROM `checki` WHERE `id_check` = @IDCheck", db.GetConnection());

            command.Parameters.Add("@IDCheck", MySqlDbType.UInt32).Value = Convert.ToUInt32(SelectedCheck.id_check);

            db.OpenConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(this, "Чек был удален!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                HistoryForm historyForm = new HistoryForm
                {
                    UserPassport = UserPassport,
                    IDKvartiri = IDKvartiri
                };
                historyForm.Show();
            }
            else
                MessageBox.Show(this, "Чек не был удален! ;c", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            db.CloseConnection();
        }

        // 13.01.2023 13:28:16
        // Метод создания документа
        private void CrateDockButton_Click(object sender, EventArgs e)
        {
            string TType;
            var SelectedCheck = DataGridViewChechi.SelectedRows[0].DataBoundItem as Checki;
            Checki NoneSelectedCheck;
            if (DataGridViewChechi.SelectedRows[0].Index != 0)
                NoneSelectedCheck = DataGridViewChechi.Rows[Convert.ToInt16(DataGridViewChechi.SelectedRows[0].Index) - 1].DataBoundItem as Checki;
            else
                NoneSelectedCheck = SelectedCheck;

            // 08.02.2023 9:36
            // Создание транзакции в БД
            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            DataTable table2 = new DataTable();
            DataTable table3 = new DataTable();
            DataTable table4 = new DataTable();
            DataTable table5 = new DataTable();
            DataTable table6 = null;
            MySqlCommand command = new MySqlCommand("SELECT * FROM `kvartira` WHERE `id_kvartira` = @IDKvartira", db.GetConnection());
            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `tariffi` WHERE `type` = @Type AND now() - datetariff > 0 ORDER BY `datetariff` LIMIT 1;", db.GetConnection());
            MySqlCommand command3 = new MySqlCommand("SELECT * FROM `shetckik` WHERE `kvartira_id_kvartira` = @IDKvartira", db.GetConnection());
            MySqlCommand command4 = new MySqlCommand("SELECT * FROM `checki` WHERE `id_check` = @IDCheck", db.GetConnection());
            MySqlCommand command5 = new MySqlCommand("SELECT * FROM `semshik` WHERE `passport` = @Passport", db.GetConnection());
            MySqlCommand command6 = new MySqlCommand("SELECT * FROM `checki` WHERE `id_check` = @IDCheck", db.GetConnection());

            // 08.02.2023 9:36
            // Заполнение запросов в БД
            command.Parameters.Add("@IDKvartira", MySqlDbType.VarChar).Value = IDKvartiri;

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

            command3.Parameters.Add("@IDKvartira", MySqlDbType.VarChar).Value = IDKvartiri;

            adapter.SelectCommand = command3;
            adapter.Fill(table3);

            command4.Parameters.Add("@IDCheck", MySqlDbType.UInt32).Value = Convert.ToUInt32(SelectedCheck.id_check);

            adapter.SelectCommand = command4;
            adapter.Fill(table4);

            command5.Parameters.Add("@Passport", MySqlDbType.VarChar).Value = UserPassport;

            adapter.SelectCommand = command5;
            adapter.Fill(table5);

            if (NoneSelectedCheck != SelectedCheck)
            {
                command6.Parameters.Add("@IDCheck", MySqlDbType.UInt32).Value = Convert.ToUInt32(NoneSelectedCheck.id_check);

                adapter.SelectCommand = command6;
                table6 = new DataTable();
                adapter.Fill(table6);
            }

            // Выделение памяти для создания документа
            var helper = new WordHelper("ШаблонСчетаТ3.docx");
            var items = new Dictionary<string, string> { };

            // 08.02.2023 13:28:16
            // Параметры составления шаблона
            if (table3.Rows.Count == 0)
            {
                helper = new WordHelper("ШаблонСчетаNone.docx");

                items = new Dictionary<string, string>
                {
                {"<date>", table4.Rows[0][5].ToString().Replace("0:00:00","") }, //check
                {"<FIO>", table5.Rows[0][1].ToString() + " " + table5.Rows[0][2].ToString() + " " 
                + table5.Rows[0][3].ToString()}, //semshikc
                {"<Adress>", table.Rows[0][7].ToString() }, // kvartira
                {"<Flat>",  table.Rows[0][1].ToString() }, //kvartira
                {"<People>",  table.Rows[0][3].ToString()}, //kvartira
                {"<TarFf>", table2.Rows[0][2].ToString()}, //Tarifi
                {"<Total>", table4.Rows[0][4].ToString() + " Руб."}, //check
                };
            }

            else if (table3.Rows[0][2].ToString() == "3")
            {
                helper = new WordHelper("ШаблонСчетаТ3.docx");

                items = new Dictionary<string, string>
                {
                {"<date>", table4.Rows[0][5].ToString().Replace("0:00:00","") }, //check
                {"<NShetchik>", table3.Rows[0][0].ToString() }, // shetchik
                {"<FIO>", table5.Rows[0][1].ToString() + " " + table5.Rows[0][2].ToString() + " " 
                + table5.Rows[0][3].ToString()}, //semshikc
                {"<Adress>", table.Rows[0][7].ToString() }, // kvartira
                {"<Flat>",  table.Rows[0][1].ToString() }, //kvartira
                {"<People>",  table.Rows[0][3].ToString()}, //kvartira
                {"<OldP1>", table6 == null ? "0" :table6.Rows[0][1].ToString()}, //check
                {"<OldP2>", table6 == null ? "0" :table6.Rows[0][2].ToString()}, //check
                {"<OldP3>", table6 == null ? "0" :table6.Rows[0][3].ToString()},//check
                {"<OldDate>", table6 == null ? "" : table6.Rows[0][5].ToString().Replace("0:00:00","")},//check
                {"<P1>", table4.Rows[0][1].ToString() },//check
                {"<P2>", table4.Rows[0][2].ToString()},//check
                {"<P3>", table4.Rows[0][3].ToString()},//check
                {"<TarF1>", table2.Rows[0][6].ToString()}, //Tarifi
                {"<TarF2>", table2.Rows[0][4].ToString()}, //Tarifi
                {"<TarF3>", table2.Rows[0][5].ToString()}, //Tarifi
                {"<TP1>", Convert.ToString(((double)table4.Rows[0][1] - (table6 == null ? 0 :(double)table6.Rows[0][1])) 
                * (double)table2.Rows[0][6])}, // Расчитать
                {"<TP2>", Convert.ToString(((double)table4.Rows[0][2] - (table6 == null ? 0 :(double)table6.Rows[0][2]))
                * (double)table2.Rows[0][4])}, // Расчитать
                {"<TP3>", Convert.ToString(((double)table4.Rows[0][3] - (table6 == null ? 0 :(double)table6.Rows[0][3])) 
                * (double)table2.Rows[0][5])}, // Расчитать
                {"<Total>", table4.Rows[0][4].ToString() + " Руб."}, //check
                };
            }

            else if (table3.Rows[0][2].ToString() == "2")
            {
                helper = new WordHelper("ШаблонСчетаТ2.docx");

                items = new Dictionary<string, string>
                {
                {"<date>", table4.Rows[0][5].ToString().Replace("0:00:00","") }, //check
                {"<NShetchik>", table3.Rows[0][0].ToString() }, // shetchik
                {"<FIO>", table5.Rows[0][1].ToString() + " " + table5.Rows[0][2].ToString() + " " 
                + table5.Rows[0][3].ToString()}, //semshikc
                {"<Adress>", table.Rows[0][7].ToString() }, // kvartira
                {"<Flat>",  table.Rows[0][1].ToString() }, //kvartira
                {"<People>",  table.Rows[0][3].ToString()}, //kvartira
                {"<OldP1>", table6 == null ? "0" :table6.Rows[0][1].ToString()}, //check
                {"<OldP2>", table6 == null ? "0" :table6.Rows[0][2].ToString()}, //check
                {"<OldDate>", table6 == null ? "" : table6.Rows[0][5].ToString().Replace("0:00:00","")},//check
                {"<P1>", table4.Rows[0][1].ToString() },//check
                {"<P2>", table4.Rows[0][2].ToString()},//
                {"<TarF1>", table2.Rows[0][3].ToString()}, //Tarifi
                {"<TarF2>", table2.Rows[0][4].ToString()}, //
                {"<TP1>", Convert.ToString(((double)table4.Rows[0][1] - (table6 == null ? 0 :(double)table6.Rows[0][1])) 
                * (double)table2.Rows[0][3])}, // Расчитать
                {"<TP2>", Convert.ToString(((double)table4.Rows[0][2] - (table6 == null ? 0 :(double)table6.Rows[0][2]))
                * (double)table2.Rows[0][4])}, //
                {"<Total>", table4.Rows[0][4].ToString() + " Руб."}, //check
                };
            }

            else if (table3.Rows[0][2].ToString() == "1")
            {
                helper = new WordHelper("ШаблонСчетаТ1.docx");

                items = new Dictionary<string, string>
                {
                {"<date>", table4.Rows[0][5].ToString().Replace("0:00:00","") }, //check
                {"<NShetchik>", table3.Rows[0][0].ToString() }, // shetchik
                {"<FIO>", table5.Rows[0][1].ToString() + " " + table5.Rows[0][2].ToString() + " " 
                + table5.Rows[0][3].ToString()}, //semshikc
                {"<Adress>", table.Rows[0][7].ToString() }, // kvartira
                {"<Flat>",  table.Rows[0][1].ToString() }, //kvartira
                {"<People>",  table.Rows[0][3].ToString()}, //kvartira
                {"<OldP1>", table6 == null ? "0" :table6.Rows[0][1].ToString()}, //check
                {"<OldDate>", table6 == null ? "" : table6.Rows[0][5].ToString().Replace("0:00:00","")},//check
                {"<P1>", table4.Rows[0][1].ToString() },//check
                {"<TarF1>", table2.Rows[0][5].ToString()}, //Tarifi
                {"<TP1>", Convert.ToString(((double)table4.Rows[0][1] - (table6 == null ? 0 :(double)table6.Rows[0][1])) 
                * (double)table2.Rows[0][5])}, // Расчитать
                {"<Total>", table4.Rows[0][4].ToString() + " Руб."}, //check
                };
            }

            // 08.02.2023 9:33
            // Шаблон для названия файла
            helper.dateP = table4.Rows[0][5].ToString().Replace("0:00:00", "");
            helper.adress = table.Rows[0][7].ToString();
            helper.flat = table.Rows[0][1].ToString();

            // 08.02.2023 9:33
            // Проверка статуса транзакции
            if (helper.Process(items) == true)
            {
                MessageBox.Show(this, "Документ был успешно созадан!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                HistoryForm historyForm = new HistoryForm();
                historyForm.UserPassport = UserPassport;
                historyForm.IDKvartiri = IDKvartiri;
                historyForm.Show();
            }
            else
                MessageBox.Show(this, "Документ не был создан! ;c", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
