using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace MosEnergo2._0
{
    public partial class Kalculator : Form
    {
        public Kalculator()
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
        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

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

        // Изменение интерфейса в зависимости от типа счетчика
        private void NoneRB_CheckedChanged(object sender, EventArgs e)
        {
            if (NoneRB.Checked == true)
            {
                PokazaniyaPanel.Visible = false;
                PeapleLabel.Visible = true;
                PeopleBox.Visible = true;
            }
        }

        private void OneTRB_CheckedChanged(object sender, EventArgs e)
        {
            if (OneTRB.Checked == true)
            {
                PokazaniyaPanel.Visible = true;
                T1Label.Visible = true;
                T2Label.Visible = false;
                T3Label.Visible = false;
                Tarif1.Visible = true;
                Tarif2.Visible = false;
                Tarif3.Visible = false;
                PeapleLabel.Visible = false;
                PeopleBox.Visible = false;
            }
        }

        private void TwoTRB_CheckedChanged(object sender, EventArgs e)
        {
            if (TwoTRB.Checked == true)
            {
                PokazaniyaPanel.Visible = true;
                T1Label.Visible = true;
                T2Label.Visible = true;
                T3Label.Visible = false;
                Tarif1.Visible = true;
                Tarif2.Visible = true;
                Tarif3.Visible = false;
                PeapleLabel.Visible = false;
                PeopleBox.Visible = false;
            }
        }

        private void ThreeTRB_CheckedChanged(object sender, EventArgs e)
        {
            if (ThreeTRB.Checked == true)
            {
                PokazaniyaPanel.Visible = true;
                T1Label.Visible = true;
                T2Label.Visible = true;
                T3Label.Visible = true;
                Tarif1.Visible = true;
                Tarif2.Visible = true;
                Tarif3.Visible = true;
                PeapleLabel.Visible = false;
                PeopleBox.Visible = false;
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            string TType;
            double MTarif1;
            double MTarif2;
            double MTarif3;
            double Total = 0;

            if (TwoTRB.Checked != true && ThreeTRB.Checked != true && TwoTRB.Checked != true && NoneRB.Checked != true)
            {
                MessageBox.Show(this, "Выберете тип счетчика!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Tarif1.Text == "" && (OneTRB.Checked == true ^ TwoTRB.Checked == true ^ ThreeTRB.Checked == true))
            {
                MessageBox.Show(this, "Введите показания в поле Т1", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Tarif2.Text == "" && (TwoTRB.Checked == true ^ ThreeTRB.Checked == true))
            {
                MessageBox.Show(this, "Введите показания в поле Т2", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Tarif3.Text == "" && ThreeTRB.Checked == true)
            {
                MessageBox.Show(this, "Введите показания в поле Т3", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PeopleBox.Text == "" && NoneRB.Checked == true)
            {
                MessageBox.Show(this, "Введите количество прописаных людей!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Выбираем тариф в зависимости от выбранного типа счетчика
            if (SeloCheck.Checked == true)
                TType = "Selo";
            else if (EStoveCheck.Checked == true && EHeaterCheck.Checked == true)
                TType = "EStoveEHeater";
            else if (EStoveCheck.Checked == true && EHeaterCheck.Checked == false)
                TType = "EStoveNone";
            else if (EStoveCheck.Checked == false && EHeaterCheck.Checked == true)
                TType = "NoneEHeater";
            else
                TType = "GasNone";

            DB db = new DB();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `tariffi` WHERE `type` = @Type AND now() - datetariff > 0 LIMIT 1;", db.GetConnection());
            command.Parameters.Add("@Type", MySqlDbType.VarChar).Value = TType;

            try
            {
                adapter.SelectCommand = command;
                adapter.Fill(table);
            
            // Фунукция расчета общей суммы выплаты 
            if (NoneRB.Checked == true)
                {
                    MTarif1 = Convert.ToDouble(table.Rows[0][2]);
                    Total = Math.Round(MTarif1 * Convert.ToUInt16(PeopleBox.Text), 2);
                }
                if (OneTRB.Checked == true)
                {
                    MTarif1 = Convert.ToDouble(table.Rows[0][5]);
                    Total = Math.Round((Convert.ToDouble(Tarif1.Text) * MTarif1), 2);
                }
                if (TwoTRB.Checked == true)
                {
                    MTarif1 = Convert.ToDouble(table.Rows[0][3]);
                    MTarif2 = Convert.ToDouble(table.Rows[0][4]);
                    Total = Math.Round((Convert.ToDouble(Tarif1.Text) * MTarif1) + (Convert.ToDouble(Tarif2.Text) * MTarif2), 2);
                }
                if (ThreeTRB.Checked == true)
                {
                    MTarif1 = Convert.ToDouble(table.Rows[0][6]);
                    MTarif2 = Convert.ToDouble(table.Rows[0][4]);
                    MTarif3 = Convert.ToDouble(table.Rows[0][5]);
                    Total = Math.Round((Convert.ToDouble(Tarif1.Text) * MTarif1) +
                       (Convert.ToDouble(Tarif2.Text) * MTarif2) +
                       (Convert.ToDouble(Tarif3.Text) * MTarif3), 2);
                }
                ResultNumber.Text = Convert.ToString(Total);
            }
            catch (MySqlException)
            {
                MessageBox.Show(this, "Не удалось подключиться к базе данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Проверка ввода
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
                Tarif2.Text = "";
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

        private void PeopleBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
