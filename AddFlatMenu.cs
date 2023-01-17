using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MosEnergo2._0
{
    public partial class AddFlatMenu : Form
    {
        public AddFlatMenu()
        {
            // Формирование интерфейса
            InitializeComponent();

            // Закрепление подсказок
            Tip1.SetToolTip(StarLabel, "Необязательное поле");
            Tip1.SetToolTip(OwnerLabel, "Необязательное поле");
            Tip1.SetToolTip(StarLabel2, "Необязательное поле");
            Tip1.SetToolTip(FactorLabel, "Необязательное поле");

            // Запрос для составления списка зарегестрированных домов
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT address FROM `dom`", db.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            for (int i = 0; i < table.Rows.Count; i++)
                HousesBox.Items.Add(table.Rows[i][0]);
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            KvartiraMenu kvartiraMenu = new KvartiraMenu();
            kvartiraMenu.UserPassport = UserPassport;
            kvartiraMenu.Show();
        }

        // Изменение интерфейса в зависимости от статуса флажка
        private void SeloCheck_CheckedChanged(object sender, EventArgs e)
        {

            if (SeloCheck.Checked == true)
            {
                OwnerField.Visible = false;
                OwnerLabel.Visible = false;
                StarLabel.Visible = false;
                HouseExist.Visible = false;
                DoorWayLabel.Visible = false;
                DoorWayField.Visible = false;
                NFlatlabel.Visible = false;
                NFlatField.Visible = false;
            }
            else
            {
                OwnerField.Visible = true;
                OwnerLabel.Visible = true;
                StarLabel.Visible = true;
                HouseExist.Visible = true;
                DoorWayLabel.Visible = true;
                DoorWayField.Visible = true;
                NFlatlabel.Visible = true;
                NFlatField.Visible = true;
            }
        }

        private void HouseExist_CheckedChanged(object sender, EventArgs e)
        {
            if (HouseExist.Checked == true)
            {
                AdressField.Visible = false;
                AdressLabel.Visible = false;
                OwnerField.Visible = false;
                OwnerLabel.Visible = false;
                StarLabel.Visible = false;
                DoorWayLabel.Visible = false;
                DoorWayField.Visible = false;
                NFlatlabel.Visible = false;
                NFlatField.Visible = false;
                SeloCheck.Visible = false;
                HousesBox.Visible = true;
                DopPanel.Location = new Point(340, 140);
            }
            else
            {
                AdressField.Visible = true;
                AdressLabel.Visible = true;
                OwnerField.Visible = true;
                OwnerLabel.Visible = true;
                StarLabel.Visible = true;
                DoorWayLabel.Visible = true;
                DoorWayField.Visible = true;
                NFlatlabel.Visible = true;
                NFlatField.Visible = true;
                SeloCheck.Visible = true;
                HousesBox.Visible = false;
                DopPanel.Location = new Point(340, 165);
            }
        }

        private void ShetchikExistCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ShetchikExistCheck.Checked == true)
            {
                NShetchikLabel.Visible = false;
                NShetchikField.Visible = false;
                TypyGB.Visible = false;
                VidGB.Visible = false;
                FactorLabel.Visible = false;
                FactorField.Visible = false;
            }
            else
            {
                NShetchikLabel.Visible = true;
                NShetchikField.Visible = true;
                TypyGB.Visible = true;
                VidGB.Visible = true;
                FactorLabel.Visible = true;
                FactorField.Visible = true;
            }
        }

        // Проверки на ввод цифр указанные ниже поля
        private void PassportField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) ^ e.KeyChar == 8)
            {
                e.Handled = true;
            }
        }

        private void FlatField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) ^ e.KeyChar == 8)
            {
                e.Handled = true;
            }
        }

        private void DoorWayField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) ^ e.KeyChar == 8)
            {
                e.Handled = true;
            }
        }

        private void NFlatField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) ^ e.KeyChar == 8)
            {
                e.Handled = true;
            }
        }

        public string UserPassport;
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Проверки ввода 
            if (AdressField.Text == "" && HouseExist.Checked == false)
            {
                MessageBox.Show(this, "Введите адрес вашего дома!\nПроверьте, возможно ваш дом есть в уже существующих", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (HouseExist.Checked == false && SeloCheck.Checked == false)
            {
                if (DoorWayField.Text == "")
                {
                    MessageBox.Show(this, "Введите количество подъездов в доме!\nПроверьте, возможно ваш дом есть в уже существующих", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (NFlatField.Text == "")
                {
                    MessageBox.Show(this, "Введите колличество квартир в доме!\nПроверьте, возможно ваш дом есть в уже существующих", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Convert.ToInt32(NFlatField.Text) < Convert.ToInt32(DoorWayField.Text))
                {
                    MessageBox.Show(this, "Количество квартир не может быть меньше количества подъездов!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Convert.ToInt32(NFlatField.Text) < Convert.ToInt32(FlatField.Text))
                {
                    MessageBox.Show(this, "Номер квартиры не может быть больше количества квартир в доме!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (FlatField.Text == "")
            {
                MessageBox.Show(this, "Введите номер вашей квартиры!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PeopleField.Text == "")
            {
                MessageBox.Show(this, "Введите количество проживающих людей в квартиер!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (NShetchikField.Text == "" && ShetchikExistCheck.Checked == false)
            {
                MessageBox.Show(this, "Введите Заводской номре вашего счетчика!\nИли отметьте что у вас отсутствует счетчик", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (NShetchikField.Text == "" && ShetchikExistCheck.Checked == false)
            {
                MessageBox.Show(this, "Введите Заводской номре вашего счетчика!\nИли отметьте что у вас отсутствует счетчик", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (OneTRB.Checked == false && TwoTRB.Checked == false && ThreeTRB.Checked == false && ShetchikExistCheck.Checked == false)
            {
                MessageBox.Show(this, "Выбирите тип вашего счетчика!\nИли отметьте что у вас отсутствует счетчик", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (OneFRB.Checked == false && ThreeFRB.Checked == false && ShetchikExistCheck.Checked == false)
            {
                MessageBox.Show(this, "Введите Заводской номре вашего счетчика!\nИли отметьте что у вас отсутствует счетчик", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((FactorField.Text == "0," ^ FactorField.Text == "0,0" ^ FactorField.Text == "0,00" ^ FactorField.Text == "0,000" ^ FactorField.Text == "0,0000" ^ FactorField.Text == "0,00000") && ShetchikExistCheck.Checked == false)
            {
                MessageBox.Show(this, "Введите в коэфицент фазности число больше нуля или оставьте его пустым \nВы также можете отметить что у вас отсутствует счетчик", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Подключение и составления запроса к БД
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO `dom` (`address`, `owner`, `doorway`, `flats`, `picture`) VALUES (@Adress,@Owner,@Doorway,@Flats,@Picture);", db.GetConnection());
            MySqlCommand command2 = new MySqlCommand("INSERT INTO `kvartira` (`flat`, `flattype`, `people`, `estove`, `eheater`, `semshik_passport`, `dom_address`) VALUES (@Flat,@Flattype,@People,@EStove,@EHeater,@SPassport,@Adress);", db.GetConnection());
            MySqlCommand command3 = new MySqlCommand("INSERT INTO `shetckik` (`SNumber`, `kind`, `type`, `factor`, `kvartira_id_kvartira`) VALUES (@SNumber,@Kind,@Type,@Factor,@IDKvartira);", db.GetConnection());
            MySqlCommand command4 = new MySqlCommand("SELECT id_kvartira FROM `kvartira` WHERE `flat` = @Flat AND `dom_address` = @Adress", db.GetConnection());
            if (HouseExist.Checked == false)
            {
                command.Parameters.Add("@Adress", MySqlDbType.VarChar).Value = AdressField.Text;
                command.Parameters.Add("@Owner", MySqlDbType.VarChar).Value = OwnerField.Text == "" ? null : OwnerField.Text;
                command.Parameters.Add("@Doorway", MySqlDbType.UByte).Value = DoorWayField.Text == "" ? null : DoorWayField.Text;
                command.Parameters.Add("@Flats", MySqlDbType.UInt32).Value = NFlatField.Text == "" ? null : NFlatField.Text;
                command.Parameters.Add("@Picture", MySqlDbType.Blob).Value = PicFileDialog.FileName == "" ? null : PicFileDialog.FileName;
            }

            command2.Parameters.Add("@Flat", MySqlDbType.UInt32).Value = FlatField.Text;
            if (SeloCheck.Checked == false)
                command2.Parameters.Add("@Flattype", MySqlDbType.Bit).Value = 0;
            else
                command2.Parameters.Add("@Flattype", MySqlDbType.Bit).Value = 1;

            command2.Parameters.Add("@People", MySqlDbType.UByte).Value = PeopleField.Text;

            if (EStoveCheck.Checked == false)
                command2.Parameters.Add("@EStove", MySqlDbType.Bit).Value = 0;
            else
                command2.Parameters.Add("@EStove", MySqlDbType.Bit).Value = 1;

            if (EHeaterCheck.Checked == false)
                command2.Parameters.Add("@EHeater", MySqlDbType.Bit).Value = 0;
            else
                command2.Parameters.Add("@EHeater", MySqlDbType.Bit).Value = 1;

            command2.Parameters.Add("@SPassport", MySqlDbType.VarChar).Value = UserPassport;
            if (HouseExist.Checked == false)
                command2.Parameters.Add("@Adress", MySqlDbType.VarChar).Value = AdressField.Text;
            else
                command2.Parameters.Add("@Adress", MySqlDbType.VarChar).Value = HousesBox.SelectedItem.ToString();

            if (ShetchikExistCheck.Checked == false)
            {
                command3.Parameters.Add("@SNumber", MySqlDbType.VarChar).Value = NShetchikField.Text;

                if (OneFRB.Checked == true)
                    command3.Parameters.Add("@Kind", MySqlDbType.Bit).Value = 0;
                else
                    command3.Parameters.Add("@Kind", MySqlDbType.Bit).Value = 1;

                if (OneTRB.Checked == true)
                    command3.Parameters.Add("@Type", MySqlDbType.Byte).Value = 1;
                else
                {
                    if (TwoTRB.Checked == true)
                        command3.Parameters.Add("@Type", MySqlDbType.Byte).Value = 2;
                    else
                        command3.Parameters.Add("@Type", MySqlDbType.Byte).Value = 3;
                }

                command3.Parameters.Add("@Factor", MySqlDbType.Double).Value = (FactorField.Text == "" ? null : FactorField.Text);
            }

            // Ввод запроса в БД
            if (HouseExist.Checked == false)
            {
                if (ShetchikExistCheck.Checked == false)
                {
                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1)
                    {
                        db.CloseConnection();
                        command4.Parameters.Add("@Flat", MySqlDbType.Int16).Value = FlatField.Text;
                        command4.Parameters.Add("@Adress", MySqlDbType.VarChar).Value = AdressField.Text;
                        adapter.SelectCommand = command4;
                        adapter.Fill(table);
                        command3.Parameters.Add("@IDKvartira", MySqlDbType.UInt32).Value = table.Rows[0][0];
                        db.OpenConnection();
                        if (command3.ExecuteNonQuery() == 1)
                            MessageBox.Show(this, "Квартира была добавленна!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show(this, "Квартира не была добавленна!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    db.CloseConnection();
                    this.Hide();
                    KvartiraMenu kvartiraMenu = new KvartiraMenu();
                    kvartiraMenu.UserPassport = UserPassport;
                    kvartiraMenu.Show();
                }
                else
                {
                    db.OpenConnection();

                    if (command.ExecuteNonQuery() == 1 && command2.ExecuteNonQuery() == 1)
                        MessageBox.Show(this, "Квартира была добавленна!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(this, "Квартира не была добавленна!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    db.CloseConnection();
                    this.Hide();
                    KvartiraMenu kvartiraMenu = new KvartiraMenu();
                    kvartiraMenu.UserPassport = UserPassport;
                    kvartiraMenu.Show();
                }
            }
            else
            {
                if (ShetchikExistCheck.Checked == false)
                {
                    db.OpenConnection();

                    if (command2.ExecuteNonQuery() == 1)
                    {
                        db.CloseConnection();
                        command4.Parameters.Add("@Flat", MySqlDbType.Int16).Value = FlatField.Text;
                        command4.Parameters.Add("@Adress", MySqlDbType.VarChar).Value = HousesBox.Text;
                        adapter.SelectCommand = command4;
                        adapter.Fill(table);
                        command3.Parameters.Add("@IDKvartira", MySqlDbType.UInt32).Value = table.Rows[0][0];
                        db.OpenConnection();
                        if (command3.ExecuteNonQuery() == 1)
                            MessageBox.Show(this, "Квартира была добавленна!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        db.CloseConnection();
                    }
                    else
                        MessageBox.Show(this, "Квартира не была добавленна!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    db.CloseConnection();
                    this.Hide();
                    KvartiraMenu kvartiraMenu = new KvartiraMenu();
                    kvartiraMenu.UserPassport = UserPassport;
                    kvartiraMenu.Show();
                }
                else
                {
                    db.OpenConnection();

                    if (command2.ExecuteNonQuery() == 1)
                        MessageBox.Show(this, "Квартира была добавленна!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(this, "Квартира не была добавленна!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    db.CloseConnection();
                    this.Hide();
                    KvartiraMenu kvartiraMenu = new KvartiraMenu();
                    kvartiraMenu.UserPassport = UserPassport;
                    kvartiraMenu.Show();
                }
            }
        }

        // Проверка ввода фазности
        private void FactorField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 8 && e.KeyChar != 44)
                e.Handled = true;
            if (e.KeyChar == 44 && FactorField.TextLength != 0)
            {
                e.Handled = true;
            }

            if (e.KeyChar == 44 && FactorField.TextLength == 0)
            {
                e.KeyChar = (char)8;
                FactorField.Text = "0,0";
                FactorField.SelectionStart = 3;
            }

            if ((e.KeyChar >= 48 || e.KeyChar < 58) && FactorField.TextLength == 0)
            {
                FactorField.Text = "0,";
                FactorField.SelectionStart = 3;
            }

            if (e.KeyChar == 8 && FactorField.Text == "0,")
                FactorField.Text = "";
        }
    }
}
