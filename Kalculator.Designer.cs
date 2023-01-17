namespace MosEnergo2._0
{
    partial class Kalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kalculator));
            this.CloseButton = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ResultNumber = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.CalculatorLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ElectronicGB = new System.Windows.Forms.GroupBox();
            this.SeloCheck = new System.Windows.Forms.CheckBox();
            this.EHeaterCheck = new System.Windows.Forms.CheckBox();
            this.EStoveCheck = new System.Windows.Forms.CheckBox();
            this.PeopleBox = new System.Windows.Forms.TextBox();
            this.PeapleLabel = new System.Windows.Forms.Label();
            this.PokazaniyaPanel = new System.Windows.Forms.Panel();
            this.PokazaniyaLabel = new System.Windows.Forms.Label();
            this.T3Label = new System.Windows.Forms.Label();
            this.Tarif1 = new System.Windows.Forms.TextBox();
            this.T2Label = new System.Windows.Forms.Label();
            this.Tarif2 = new System.Windows.Forms.TextBox();
            this.T1Label = new System.Windows.Forms.Label();
            this.Tarif3 = new System.Windows.Forms.TextBox();
            this.TypyGB = new System.Windows.Forms.GroupBox();
            this.NoneRB = new System.Windows.Forms.RadioButton();
            this.ThreeTRB = new System.Windows.Forms.RadioButton();
            this.TwoTRB = new System.Windows.Forms.RadioButton();
            this.OneTRB = new System.Windows.Forms.RadioButton();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.SchetckikLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.ElectronicGB.SuspendLayout();
            this.PokazaniyaPanel.SuspendLayout();
            this.TypyGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.Silver;
            this.CloseButton.Location = new System.Drawing.Point(619, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(19, 18);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(FormMethods.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(FormMethods.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(FormMethods.CloseButton_MouseLeave);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.MainPanel.Controls.Add(this.ResultNumber);
            this.MainPanel.Controls.Add(this.ResultLabel);
            this.MainPanel.Controls.Add(this.CalculatorLabel);
            this.MainPanel.Controls.Add(this.CalculateButton);
            this.MainPanel.Controls.Add(this.ElectronicGB);
            this.MainPanel.Controls.Add(this.PeopleBox);
            this.MainPanel.Controls.Add(this.PeapleLabel);
            this.MainPanel.Controls.Add(this.PokazaniyaPanel);
            this.MainPanel.Controls.Add(this.TypyGB);
            this.MainPanel.Controls.Add(this.LogOutButton);
            this.MainPanel.Controls.Add(this.SchetckikLabel);
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(650, 350);
            this.MainPanel.TabIndex = 11;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(FormMethods.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(FormMethods.MainPanel_MouseMove);
            // 
            // ResultNumber
            // 
            this.ResultNumber.AutoSize = true;
            this.ResultNumber.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultNumber.ForeColor = System.Drawing.Color.White;
            this.ResultNumber.Location = new System.Drawing.Point(449, 221);
            this.ResultNumber.Name = "ResultNumber";
            this.ResultNumber.Size = new System.Drawing.Size(59, 23);
            this.ResultNumber.TabIndex = 64;
            this.ResultNumber.Text = "0,00";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.ForeColor = System.Drawing.Color.White;
            this.ResultLabel.Location = new System.Drawing.Point(367, 221);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(80, 23);
            this.ResultLabel.TabIndex = 63;
            this.ResultLabel.Text = "Итого:";
            // 
            // CalculatorLabel
            // 
            this.CalculatorLabel.AutoSize = true;
            this.CalculatorLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculatorLabel.ForeColor = System.Drawing.Color.White;
            this.CalculatorLabel.Location = new System.Drawing.Point(11, 9);
            this.CalculatorLabel.Name = "CalculatorLabel";
            this.CalculatorLabel.Size = new System.Drawing.Size(192, 29);
            this.CalculatorLabel.TabIndex = 29;
            this.CalculatorLabel.Text = "Калькулятор";
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.DarkGreen;
            this.CalculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalculateButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateButton.ForeColor = System.Drawing.Color.White;
            this.CalculateButton.Location = new System.Drawing.Point(348, 260);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(187, 41);
            this.CalculateButton.TabIndex = 28;
            this.CalculateButton.Text = "Посчитать";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ElectronicGB
            // 
            this.ElectronicGB.Controls.Add(this.SeloCheck);
            this.ElectronicGB.Controls.Add(this.EHeaterCheck);
            this.ElectronicGB.Controls.Add(this.EStoveCheck);
            this.ElectronicGB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ElectronicGB.ForeColor = System.Drawing.Color.White;
            this.ElectronicGB.Location = new System.Drawing.Point(16, 204);
            this.ElectronicGB.Name = "ElectronicGB";
            this.ElectronicGB.Size = new System.Drawing.Size(258, 97);
            this.ElectronicGB.TabIndex = 27;
            this.ElectronicGB.TabStop = false;
            this.ElectronicGB.Text = "Доп. Информация:";
            // 
            // SeloCheck
            // 
            this.SeloCheck.AutoSize = true;
            this.SeloCheck.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SeloCheck.ForeColor = System.Drawing.Color.White;
            this.SeloCheck.Location = new System.Drawing.Point(10, 67);
            this.SeloCheck.Name = "SeloCheck";
            this.SeloCheck.Size = new System.Drawing.Size(246, 20);
            this.SeloCheck.TabIndex = 0;
            this.SeloCheck.TabStop = false;
            this.SeloCheck.Text = "Квартира в сельской местности";
            this.SeloCheck.UseVisualStyleBackColor = true;
            // 
            // EHeaterCheck
            // 
            this.EHeaterCheck.AutoSize = true;
            this.EHeaterCheck.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EHeaterCheck.ForeColor = System.Drawing.Color.White;
            this.EHeaterCheck.Location = new System.Drawing.Point(10, 44);
            this.EHeaterCheck.Name = "EHeaterCheck";
            this.EHeaterCheck.Size = new System.Drawing.Size(166, 20);
            this.EHeaterCheck.TabIndex = 0;
            this.EHeaterCheck.TabStop = false;
            this.EHeaterCheck.Text = "Электробогреватель";
            this.EHeaterCheck.UseVisualStyleBackColor = true;
            // 
            // EStoveCheck
            // 
            this.EStoveCheck.AutoSize = true;
            this.EStoveCheck.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EStoveCheck.ForeColor = System.Drawing.Color.White;
            this.EStoveCheck.Location = new System.Drawing.Point(10, 22);
            this.EStoveCheck.Name = "EStoveCheck";
            this.EStoveCheck.Size = new System.Drawing.Size(121, 20);
            this.EStoveCheck.TabIndex = 0;
            this.EStoveCheck.TabStop = false;
            this.EStoveCheck.Text = "Электроплита";
            this.EStoveCheck.UseVisualStyleBackColor = true;
            // 
            // PeopleBox
            // 
            this.PeopleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.PeopleBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PeopleBox.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeopleBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PeopleBox.Location = new System.Drawing.Point(305, 160);
            this.PeopleBox.MaxLength = 2;
            this.PeopleBox.Name = "PeopleBox";
            this.PeopleBox.Size = new System.Drawing.Size(79, 31);
            this.PeopleBox.TabIndex = 4;
            this.PeopleBox.Visible = false;
            this.PeopleBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PeopleBox_KeyPress);
            // 
            // PeapleLabel
            // 
            this.PeapleLabel.AutoSize = true;
            this.PeapleLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeapleLabel.ForeColor = System.Drawing.Color.White;
            this.PeapleLabel.Location = new System.Drawing.Point(167, 139);
            this.PeapleLabel.Name = "PeapleLabel";
            this.PeapleLabel.Size = new System.Drawing.Size(341, 18);
            this.PeapleLabel.TabIndex = 25;
            this.PeapleLabel.Text = "Сколько людей проживает в квартире?";
            this.PeapleLabel.Visible = false;
            // 
            // PokazaniyaPanel
            // 
            this.PokazaniyaPanel.Controls.Add(this.PokazaniyaLabel);
            this.PokazaniyaPanel.Controls.Add(this.T3Label);
            this.PokazaniyaPanel.Controls.Add(this.Tarif1);
            this.PokazaniyaPanel.Controls.Add(this.T2Label);
            this.PokazaniyaPanel.Controls.Add(this.Tarif2);
            this.PokazaniyaPanel.Controls.Add(this.T1Label);
            this.PokazaniyaPanel.Controls.Add(this.Tarif3);
            this.PokazaniyaPanel.Location = new System.Drawing.Point(305, 45);
            this.PokazaniyaPanel.Name = "PokazaniyaPanel";
            this.PokazaniyaPanel.Size = new System.Drawing.Size(275, 153);
            this.PokazaniyaPanel.TabIndex = 22;
            this.PokazaniyaPanel.Visible = false;
            // 
            // PokazaniyaLabel
            // 
            this.PokazaniyaLabel.AutoSize = true;
            this.PokazaniyaLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PokazaniyaLabel.ForeColor = System.Drawing.Color.White;
            this.PokazaniyaLabel.Location = new System.Drawing.Point(8, 6);
            this.PokazaniyaLabel.Name = "PokazaniyaLabel";
            this.PokazaniyaLabel.Size = new System.Drawing.Size(266, 18);
            this.PokazaniyaLabel.TabIndex = 18;
            this.PokazaniyaLabel.Text = "Кол-во потребляемой энергии:";
            // 
            // T3Label
            // 
            this.T3Label.AutoSize = true;
            this.T3Label.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T3Label.ForeColor = System.Drawing.Color.White;
            this.T3Label.Location = new System.Drawing.Point(8, 116);
            this.T3Label.Name = "T3Label";
            this.T3Label.Size = new System.Drawing.Size(29, 18);
            this.T3Label.TabIndex = 21;
            this.T3Label.Text = "Т3";
            // 
            // Tarif1
            // 
            this.Tarif1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.Tarif1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tarif1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tarif1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Tarif1.Location = new System.Drawing.Point(43, 27);
            this.Tarif1.MaxLength = 30;
            this.Tarif1.Name = "Tarif1";
            this.Tarif1.Size = new System.Drawing.Size(207, 31);
            this.Tarif1.TabIndex = 1;
            this.Tarif1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tarif_KeyPress);
            // 
            // T2Label
            // 
            this.T2Label.AutoSize = true;
            this.T2Label.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T2Label.ForeColor = System.Drawing.Color.White;
            this.T2Label.Location = new System.Drawing.Point(8, 75);
            this.T2Label.Name = "T2Label";
            this.T2Label.Size = new System.Drawing.Size(29, 18);
            this.T2Label.TabIndex = 20;
            this.T2Label.Text = "Т2";
            // 
            // Tarif2
            // 
            this.Tarif2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.Tarif2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tarif2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tarif2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Tarif2.Location = new System.Drawing.Point(43, 69);
            this.Tarif2.MaxLength = 30;
            this.Tarif2.Name = "Tarif2";
            this.Tarif2.Size = new System.Drawing.Size(207, 31);
            this.Tarif2.TabIndex = 2;
            this.Tarif2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tarif_KeyPress);
            // 
            // T1Label
            // 
            this.T1Label.AutoSize = true;
            this.T1Label.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T1Label.ForeColor = System.Drawing.Color.White;
            this.T1Label.Location = new System.Drawing.Point(8, 33);
            this.T1Label.Name = "T1Label";
            this.T1Label.Size = new System.Drawing.Size(29, 18);
            this.T1Label.TabIndex = 19;
            this.T1Label.Text = "Т1";
            // 
            // Tarif3
            // 
            this.Tarif3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.Tarif3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Tarif3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tarif3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Tarif3.Location = new System.Drawing.Point(43, 110);
            this.Tarif3.MaxLength = 30;
            this.Tarif3.Name = "Tarif3";
            this.Tarif3.Size = new System.Drawing.Size(207, 31);
            this.Tarif3.TabIndex = 3;
            this.Tarif3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tarif_KeyPress);
            // 
            // TypyGB
            // 
            this.TypyGB.Controls.Add(this.NoneRB);
            this.TypyGB.Controls.Add(this.ThreeTRB);
            this.TypyGB.Controls.Add(this.TwoTRB);
            this.TypyGB.Controls.Add(this.OneTRB);
            this.TypyGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypyGB.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypyGB.ForeColor = System.Drawing.Color.White;
            this.TypyGB.Location = new System.Drawing.Point(16, 63);
            this.TypyGB.Name = "TypyGB";
            this.TypyGB.Size = new System.Drawing.Size(142, 135);
            this.TypyGB.TabIndex = 13;
            this.TypyGB.TabStop = false;
            this.TypyGB.Text = "Тип:";
            // 
            // NoneRB
            // 
            this.NoneRB.AutoSize = true;
            this.NoneRB.Location = new System.Drawing.Point(6, 100);
            this.NoneRB.Name = "NoneRB";
            this.NoneRB.Size = new System.Drawing.Size(116, 20);
            this.NoneRB.TabIndex = 0;
            this.NoneRB.Text = "Без счетчика";
            this.NoneRB.UseVisualStyleBackColor = true;
            this.NoneRB.CheckedChanged += new System.EventHandler(this.NoneRB_CheckedChanged);
            // 
            // ThreeTRB
            // 
            this.ThreeTRB.AutoSize = true;
            this.ThreeTRB.Location = new System.Drawing.Point(6, 74);
            this.ThreeTRB.Name = "ThreeTRB";
            this.ThreeTRB.Size = new System.Drawing.Size(126, 20);
            this.ThreeTRB.TabIndex = 0;
            this.ThreeTRB.Text = "ТрехТарифный";
            this.ThreeTRB.UseVisualStyleBackColor = true;
            this.ThreeTRB.CheckedChanged += new System.EventHandler(this.ThreeTRB_CheckedChanged);
            // 
            // TwoTRB
            // 
            this.TwoTRB.AutoSize = true;
            this.TwoTRB.Location = new System.Drawing.Point(6, 48);
            this.TwoTRB.Name = "TwoTRB";
            this.TwoTRB.Size = new System.Drawing.Size(127, 20);
            this.TwoTRB.TabIndex = 0;
            this.TwoTRB.Text = "ДвухТарифный";
            this.TwoTRB.UseVisualStyleBackColor = true;
            this.TwoTRB.CheckedChanged += new System.EventHandler(this.TwoTRB_CheckedChanged);
            // 
            // OneTRB
            // 
            this.OneTRB.AutoSize = true;
            this.OneTRB.Location = new System.Drawing.Point(6, 22);
            this.OneTRB.Name = "OneTRB";
            this.OneTRB.Size = new System.Drawing.Size(128, 20);
            this.OneTRB.TabIndex = 0;
            this.OneTRB.Text = "ОдноТарифный";
            this.OneTRB.UseVisualStyleBackColor = true;
            this.OneTRB.CheckedChanged += new System.EventHandler(this.OneTRB_CheckedChanged);
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogOutButton.ForeColor = System.Drawing.Color.White;
            this.LogOutButton.Location = new System.Drawing.Point(558, 313);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(80, 25);
            this.LogOutButton.TabIndex = 12;
            this.LogOutButton.Text = "Назад";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // SchetckikLabel
            // 
            this.SchetckikLabel.AutoSize = true;
            this.SchetckikLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SchetckikLabel.ForeColor = System.Drawing.Color.White;
            this.SchetckikLabel.Location = new System.Drawing.Point(13, 42);
            this.SchetckikLabel.Name = "SchetckikLabel";
            this.SchetckikLabel.Size = new System.Drawing.Size(187, 18);
            this.SchetckikLabel.TabIndex = 11;
            this.SchetckikLabel.Text = "Какой у вас счетчик?";
            // 
            // Kalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(650, 350);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ElectronicGB.ResumeLayout(false);
            this.ElectronicGB.PerformLayout();
            this.PokazaniyaPanel.ResumeLayout(false);
            this.PokazaniyaPanel.PerformLayout();
            this.TypyGB.ResumeLayout(false);
            this.TypyGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.GroupBox TypyGB;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Label SchetckikLabel;
        private System.Windows.Forms.RadioButton NoneRB;
        private System.Windows.Forms.RadioButton ThreeTRB;
        private System.Windows.Forms.RadioButton TwoTRB;
        private System.Windows.Forms.RadioButton OneTRB;
        private System.Windows.Forms.TextBox Tarif3;
        private System.Windows.Forms.TextBox Tarif2;
        private System.Windows.Forms.TextBox Tarif1;
        private System.Windows.Forms.Label T3Label;
        private System.Windows.Forms.Label T2Label;
        private System.Windows.Forms.Label T1Label;
        private System.Windows.Forms.Label PokazaniyaLabel;
        private System.Windows.Forms.Panel PokazaniyaPanel;
        private System.Windows.Forms.TextBox PeopleBox;
        private System.Windows.Forms.Label PeapleLabel;
        private System.Windows.Forms.CheckBox EHeaterCheck;
        private System.Windows.Forms.CheckBox EStoveCheck;
        private System.Windows.Forms.GroupBox ElectronicGB;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label CalculatorLabel;
        private System.Windows.Forms.CheckBox SeloCheck;
        private System.Windows.Forms.Label ResultNumber;
        private System.Windows.Forms.Label ResultLabel;
    }
}