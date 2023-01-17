namespace MosEnergo2._0
{
    partial class Flat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flat));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.PastPokazPanel = new System.Windows.Forms.Panel();
            this.PredPokazLabel = new System.Windows.Forms.Label();
            this.HistoryLabel = new System.Windows.Forms.Label();
            this.ResultNumber = new System.Windows.Forms.Label();
            this.DeleteFlatButton = new System.Windows.Forms.Button();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.PokazaniyaPanel = new System.Windows.Forms.Panel();
            this.PokazaniyaLabel = new System.Windows.Forms.Label();
            this.T3Label = new System.Windows.Forms.Label();
            this.Tarif1 = new System.Windows.Forms.TextBox();
            this.T2Label = new System.Windows.Forms.Label();
            this.Tarif2 = new System.Windows.Forms.TextBox();
            this.T1Label = new System.Windows.Forms.Label();
            this.Tarif3 = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.HouseLabel = new System.Windows.Forms.Label();
            this.OplataMenuLabel = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.PastPokazPanel.SuspendLayout();
            this.PokazaniyaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.MainPanel.Controls.Add(this.ErrorLabel);
            this.MainPanel.Controls.Add(this.PastPokazPanel);
            this.MainPanel.Controls.Add(this.ResultNumber);
            this.MainPanel.Controls.Add(this.DeleteFlatButton);
            this.MainPanel.Controls.Add(this.HistoryButton);
            this.MainPanel.Controls.Add(this.ResultLabel);
            this.MainPanel.Controls.Add(this.PokazaniyaPanel);
            this.MainPanel.Controls.Add(this.CalculateButton);
            this.MainPanel.Controls.Add(this.HouseLabel);
            this.MainPanel.Controls.Add(this.OplataMenuLabel);
            this.MainPanel.Controls.Add(this.LogOutButton);
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(700, 350);
            this.MainPanel.TabIndex = 12;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(FormMethods.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(FormMethods.MainPanel_MouseMove);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(220, 18);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(375, 18);
            this.ErrorLabel.TabIndex = 64;
            this.ErrorLabel.Text = "Вы уже сегодня передавали показания!";
            this.ErrorLabel.Visible = false;
            // 
            // PastPokazPanel
            // 
            this.PastPokazPanel.Controls.Add(this.PredPokazLabel);
            this.PastPokazPanel.Controls.Add(this.HistoryLabel);
            this.PastPokazPanel.Location = new System.Drawing.Point(12, 175);
            this.PastPokazPanel.Name = "PastPokazPanel";
            this.PastPokazPanel.Size = new System.Drawing.Size(205, 81);
            this.PastPokazPanel.TabIndex = 63;
            // 
            // PredPokazLabel
            // 
            this.PredPokazLabel.AutoSize = true;
            this.PredPokazLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PredPokazLabel.ForeColor = System.Drawing.Color.White;
            this.PredPokazLabel.Location = new System.Drawing.Point(3, 2);
            this.PredPokazLabel.Name = "PredPokazLabel";
            this.PredPokazLabel.Size = new System.Drawing.Size(192, 16);
            this.PredPokazLabel.TabIndex = 61;
            this.PredPokazLabel.Text = "Предыдущие показания:";
            // 
            // HistoryLabel
            // 
            this.HistoryLabel.AutoSize = true;
            this.HistoryLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HistoryLabel.ForeColor = System.Drawing.Color.White;
            this.HistoryLabel.Location = new System.Drawing.Point(5, 24);
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.Size = new System.Drawing.Size(42, 48);
            this.HistoryLabel.TabIndex = 60;
            this.HistoryLabel.Text = "Т1: 0\r\nТ2: 0\r\nТ3: 0";
            // 
            // ResultNumber
            // 
            this.ResultNumber.AutoSize = true;
            this.ResultNumber.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultNumber.ForeColor = System.Drawing.Color.White;
            this.ResultNumber.Location = new System.Drawing.Point(390, 247);
            this.ResultNumber.Name = "ResultNumber";
            this.ResultNumber.Size = new System.Drawing.Size(59, 23);
            this.ResultNumber.TabIndex = 62;
            this.ResultNumber.Text = "0,00";
            // 
            // DeleteFlatButton
            // 
            this.DeleteFlatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(51)))), ((int)(((byte)(36)))));
            this.DeleteFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteFlatButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DeleteFlatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteFlatButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteFlatButton.ForeColor = System.Drawing.Color.White;
            this.DeleteFlatButton.Location = new System.Drawing.Point(17, 297);
            this.DeleteFlatButton.Name = "DeleteFlatButton";
            this.DeleteFlatButton.Size = new System.Drawing.Size(171, 29);
            this.DeleteFlatButton.TabIndex = 7;
            this.DeleteFlatButton.Text = "Удалить квартиру";
            this.DeleteFlatButton.UseVisualStyleBackColor = false;
            this.DeleteFlatButton.Click += new System.EventHandler(this.DeleteFlatButton_Click);
            // 
            // HistoryButton
            // 
            this.HistoryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.HistoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HistoryButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistoryButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HistoryButton.ForeColor = System.Drawing.Color.White;
            this.HistoryButton.Location = new System.Drawing.Point(455, 301);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(121, 25);
            this.HistoryButton.TabIndex = 5;
            this.HistoryButton.Text = "История чеков";
            this.HistoryButton.UseVisualStyleBackColor = false;
            this.HistoryButton.Click += new System.EventHandler(this.HistoryButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultLabel.ForeColor = System.Drawing.Color.White;
            this.ResultLabel.Location = new System.Drawing.Point(308, 247);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(80, 23);
            this.ResultLabel.TabIndex = 59;
            this.ResultLabel.Text = "Итого:";
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
            this.PokazaniyaPanel.Location = new System.Drawing.Point(351, 59);
            this.PokazaniyaPanel.Name = "PokazaniyaPanel";
            this.PokazaniyaPanel.Size = new System.Drawing.Size(270, 161);
            this.PokazaniyaPanel.TabIndex = 58;
            // 
            // PokazaniyaLabel
            // 
            this.PokazaniyaLabel.AutoSize = true;
            this.PokazaniyaLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PokazaniyaLabel.ForeColor = System.Drawing.Color.White;
            this.PokazaniyaLabel.Location = new System.Drawing.Point(88, 6);
            this.PokazaniyaLabel.Name = "PokazaniyaLabel";
            this.PokazaniyaLabel.Size = new System.Drawing.Size(104, 18);
            this.PokazaniyaLabel.TabIndex = 18;
            this.PokazaniyaLabel.Text = "Показания:";
            this.PokazaniyaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Tarif1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tarif1_KeyPress);
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
            this.Tarif2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tarif2_KeyPress);
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
            this.Tarif3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tarif3_KeyPress);
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.Color.DarkGreen;
            this.CalculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CalculateButton.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateButton.ForeColor = System.Drawing.Color.White;
            this.CalculateButton.Location = new System.Drawing.Point(234, 285);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(197, 41);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Посчитать";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // HouseLabel
            // 
            this.HouseLabel.AutoSize = true;
            this.HouseLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HouseLabel.ForeColor = System.Drawing.Color.White;
            this.HouseLabel.Location = new System.Drawing.Point(14, 59);
            this.HouseLabel.Name = "HouseLabel";
            this.HouseLabel.Size = new System.Drawing.Size(192, 112);
            this.HouseLabel.TabIndex = 56;
            this.HouseLabel.Text = "Адрес: \r\nКвартира:\r\nКол-во проживающих:\r\nСчетчик:\r\nЭлектро плита ❌\r\nЭлектро обогр" +
    "еватель ❌\r\nСельская местность ❌";
            // 
            // OplataMenuLabel
            // 
            this.OplataMenuLabel.AutoSize = true;
            this.OplataMenuLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OplataMenuLabel.ForeColor = System.Drawing.Color.White;
            this.OplataMenuLabel.Location = new System.Drawing.Point(12, 9);
            this.OplataMenuLabel.Name = "OplataMenuLabel";
            this.OplataMenuLabel.Size = new System.Drawing.Size(202, 29);
            this.OplataMenuLabel.TabIndex = 55;
            this.OplataMenuLabel.Text = "Меню оплаты";
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogOutButton.ForeColor = System.Drawing.Color.White;
            this.LogOutButton.Location = new System.Drawing.Point(608, 301);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(80, 25);
            this.LogOutButton.TabIndex = 6;
            this.LogOutButton.Text = "Назад";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.Silver;
            this.CloseButton.Location = new System.Drawing.Point(669, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(19, 18);
            this.CloseButton.TabIndex = 9;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(FormMethods.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(FormMethods.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(FormMethods.CloseButton_MouseLeave);
            // 
            // Flat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(700, 350);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Flat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню оплаты";
            this.Load += new System.EventHandler(this.Flat_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.PastPokazPanel.ResumeLayout(false);
            this.PastPokazPanel.PerformLayout();
            this.PokazaniyaPanel.ResumeLayout(false);
            this.PokazaniyaPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label OplataMenuLabel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Label HouseLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Panel PokazaniyaPanel;
        private System.Windows.Forms.Label PokazaniyaLabel;
        private System.Windows.Forms.Label T3Label;
        private System.Windows.Forms.TextBox Tarif1;
        private System.Windows.Forms.Label T2Label;
        private System.Windows.Forms.TextBox Tarif2;
        private System.Windows.Forms.Label T1Label;
        private System.Windows.Forms.TextBox Tarif3;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button HistoryButton;
        private System.Windows.Forms.Label PredPokazLabel;
        private System.Windows.Forms.Label HistoryLabel;
        private System.Windows.Forms.Button DeleteFlatButton;
        private System.Windows.Forms.Label ResultNumber;
        private System.Windows.Forms.Panel PastPokazPanel;
        private System.Windows.Forms.Label ErrorLabel;
    }
}