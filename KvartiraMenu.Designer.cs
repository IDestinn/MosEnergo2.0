namespace MosEnergo2._0
{
    partial class KvartiraMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KvartiraMenu));
            this.CloseButton = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.DeliteAkkButton = new System.Windows.Forms.Button();
            this.LimitLabel = new System.Windows.Forms.Label();
            this.MenuFlatLabel = new System.Windows.Forms.Label();
            this.FlatButton2 = new System.Windows.Forms.Button();
            this.FlatButton3 = new System.Windows.Forms.Button();
            this.FlatButton4 = new System.Windows.Forms.Button();
            this.FlatButton5 = new System.Windows.Forms.Button();
            this.FlatButton1 = new System.Windows.Forms.Button();
            this.AddFlatButton = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
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
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.MainPanel.Controls.Add(this.DeliteAkkButton);
            this.MainPanel.Controls.Add(this.LimitLabel);
            this.MainPanel.Controls.Add(this.MenuFlatLabel);
            this.MainPanel.Controls.Add(this.FlatButton2);
            this.MainPanel.Controls.Add(this.FlatButton3);
            this.MainPanel.Controls.Add(this.FlatButton4);
            this.MainPanel.Controls.Add(this.FlatButton5);
            this.MainPanel.Controls.Add(this.FlatButton1);
            this.MainPanel.Controls.Add(this.AddFlatButton);
            this.MainPanel.Controls.Add(this.LogOutButton);
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(700, 300);
            this.MainPanel.TabIndex = 11;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(FormMethods.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(FormMethods.MainPanel_MouseMove);
            // 
            // DeliteAkkButton
            // 
            this.DeliteAkkButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(51)))), ((int)(((byte)(36)))));
            this.DeliteAkkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeliteAkkButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DeliteAkkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeliteAkkButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeliteAkkButton.ForeColor = System.Drawing.Color.White;
            this.DeliteAkkButton.Location = new System.Drawing.Point(229, 9);
            this.DeliteAkkButton.Name = "DeliteAkkButton";
            this.DeliteAkkButton.Size = new System.Drawing.Size(160, 29);
            this.DeliteAkkButton.TabIndex = 8;
            this.DeliteAkkButton.Text = "Удалить аккаунт";
            this.DeliteAkkButton.UseVisualStyleBackColor = false;
            this.DeliteAkkButton.Click += new System.EventHandler(this.DeliteAkkButton_Click);
            // 
            // LimitLabel
            // 
            this.LimitLabel.AutoSize = true;
            this.LimitLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LimitLabel.ForeColor = System.Drawing.Color.White;
            this.LimitLabel.Location = new System.Drawing.Point(156, 217);
            this.LimitLabel.Name = "LimitLabel";
            this.LimitLabel.Size = new System.Drawing.Size(394, 54);
            this.LimitLabel.TabIndex = 56;
            this.LimitLabel.Text = "Достигнут максимальное количество квартир \r\n(Системное ограничение)\r\n\r\n";
            this.LimitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LimitLabel.Visible = false;
            // 
            // MenuFlatLabel
            // 
            this.MenuFlatLabel.AutoSize = true;
            this.MenuFlatLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuFlatLabel.ForeColor = System.Drawing.Color.White;
            this.MenuFlatLabel.Location = new System.Drawing.Point(12, 9);
            this.MenuFlatLabel.Name = "MenuFlatLabel";
            this.MenuFlatLabel.Size = new System.Drawing.Size(211, 29);
            this.MenuFlatLabel.TabIndex = 55;
            this.MenuFlatLabel.Text = "Главное меню";
            // 
            // FlatButton2
            // 
            this.FlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlatButton2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FlatButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatButton2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FlatButton2.ForeColor = System.Drawing.Color.White;
            this.FlatButton2.Location = new System.Drawing.Point(249, 100);
            this.FlatButton2.Name = "FlatButton2";
            this.FlatButton2.Size = new System.Drawing.Size(195, 47);
            this.FlatButton2.TabIndex = 2;
            this.FlatButton2.Tag = "2";
            this.FlatButton2.Text = "Квартира 2";
            this.FlatButton2.UseVisualStyleBackColor = false;
            this.FlatButton2.Visible = false;
            this.FlatButton2.Click += new System.EventHandler(this.FlatButton_Click);
            // 
            // FlatButton3
            // 
            this.FlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlatButton3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FlatButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatButton3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FlatButton3.ForeColor = System.Drawing.Color.White;
            this.FlatButton3.Location = new System.Drawing.Point(464, 100);
            this.FlatButton3.Name = "FlatButton3";
            this.FlatButton3.Size = new System.Drawing.Size(195, 47);
            this.FlatButton3.TabIndex = 3;
            this.FlatButton3.Tag = "3";
            this.FlatButton3.Text = "Квартира 3";
            this.FlatButton3.UseVisualStyleBackColor = false;
            this.FlatButton3.Visible = false;
            this.FlatButton3.Click += new System.EventHandler(this.FlatButton_Click);
            // 
            // FlatButton4
            // 
            this.FlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlatButton4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FlatButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatButton4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FlatButton4.ForeColor = System.Drawing.Color.White;
            this.FlatButton4.Location = new System.Drawing.Point(141, 167);
            this.FlatButton4.Name = "FlatButton4";
            this.FlatButton4.Size = new System.Drawing.Size(195, 47);
            this.FlatButton4.TabIndex = 4;
            this.FlatButton4.Tag = "4";
            this.FlatButton4.Text = "Квартира 4";
            this.FlatButton4.UseVisualStyleBackColor = false;
            this.FlatButton4.Visible = false;
            this.FlatButton4.Click += new System.EventHandler(this.FlatButton_Click);
            // 
            // FlatButton5
            // 
            this.FlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.FlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlatButton5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FlatButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatButton5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FlatButton5.ForeColor = System.Drawing.Color.White;
            this.FlatButton5.Location = new System.Drawing.Point(371, 167);
            this.FlatButton5.Name = "FlatButton5";
            this.FlatButton5.Size = new System.Drawing.Size(195, 47);
            this.FlatButton5.TabIndex = 5;
            this.FlatButton5.Tag = "5";
            this.FlatButton5.Text = "Квартира 5";
            this.FlatButton5.UseVisualStyleBackColor = false;
            this.FlatButton5.Visible = false;
            this.FlatButton5.Click += new System.EventHandler(this.FlatButton_Click);
            // 
            // FlatButton1
            // 
            this.FlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FlatButton1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FlatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatButton1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FlatButton1.ForeColor = System.Drawing.Color.White;
            this.FlatButton1.Location = new System.Drawing.Point(34, 100);
            this.FlatButton1.Name = "FlatButton1";
            this.FlatButton1.Size = new System.Drawing.Size(195, 47);
            this.FlatButton1.TabIndex = 1;
            this.FlatButton1.Tag = "1";
            this.FlatButton1.Text = "Квартира 1";
            this.FlatButton1.UseVisualStyleBackColor = false;
            this.FlatButton1.Visible = false;
            this.FlatButton1.Click += new System.EventHandler(this.FlatButton_Click);
            // 
            // AddFlatButton
            // 
            this.AddFlatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(179)))), ((int)(((byte)(51)))));
            this.AddFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFlatButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddFlatButton.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddFlatButton.ForeColor = System.Drawing.Color.White;
            this.AddFlatButton.Location = new System.Drawing.Point(17, 244);
            this.AddFlatButton.Name = "AddFlatButton";
            this.AddFlatButton.Size = new System.Drawing.Size(238, 36);
            this.AddFlatButton.TabIndex = 6;
            this.AddFlatButton.Text = "+ Добавить квартиру ";
            this.AddFlatButton.UseVisualStyleBackColor = false;
            this.AddFlatButton.Click += new System.EventHandler(this.AddFlatButton_Click);
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(44)))), ((int)(((byte)(43)))));
            this.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogOutButton.ForeColor = System.Drawing.Color.White;
            this.LogOutButton.Location = new System.Drawing.Point(608, 255);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(80, 25);
            this.LogOutButton.TabIndex = 7;
            this.LogOutButton.Text = "Выход";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // KvartiraMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(700, 300);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KvartiraMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.KvartiraMenu_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button FlatButton2;
        private System.Windows.Forms.Button FlatButton3;
        private System.Windows.Forms.Button FlatButton4;
        private System.Windows.Forms.Button FlatButton5;
        private System.Windows.Forms.Button FlatButton1;
        private System.Windows.Forms.Button AddFlatButton;
        private System.Windows.Forms.Label MenuFlatLabel;
        private System.Windows.Forms.Label LimitLabel;
        private System.Windows.Forms.Button DeliteAkkButton;
    }
}