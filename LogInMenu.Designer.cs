namespace MosEnergo2._0
{
    partial class LogInMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInMenu));
            this.Sign_in_label = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.TextBox();
            this.Sign_in_button = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.Registr_button = new System.Windows.Forms.Button();
            this.Login_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.User_button = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sign_in_label
            // 
            this.Sign_in_label.AutoSize = true;
            this.Sign_in_label.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sign_in_label.ForeColor = System.Drawing.Color.White;
            this.Sign_in_label.Location = new System.Drawing.Point(44, 47);
            this.Sign_in_label.Name = "Sign_in_label";
            this.Sign_in_label.Size = new System.Drawing.Size(63, 23);
            this.Sign_in_label.TabIndex = 0;
            this.Sign_in_label.Text = "Вход";
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Login.Location = new System.Drawing.Point(48, 100);
            this.Login.MaxLength = 30;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(285, 31);
            this.Login.TabIndex = 1;
            this.Login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            // 
            // Sign_in_button
            // 
            this.Sign_in_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(179)))), ((int)(((byte)(51)))));
            this.Sign_in_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sign_in_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sign_in_button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sign_in_button.ForeColor = System.Drawing.Color.White;
            this.Sign_in_button.Location = new System.Drawing.Point(48, 208);
            this.Sign_in_button.Name = "Sign_in_button";
            this.Sign_in_button.Size = new System.Drawing.Size(285, 36);
            this.Sign_in_button.TabIndex = 3;
            this.Sign_in_button.Text = "Вход";
            this.Sign_in_button.UseVisualStyleBackColor = false;
            this.Sign_in_button.Click += new System.EventHandler(this.Sign_in_button_Click);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Password.Location = new System.Drawing.Point(48, 159);
            this.Password.MaxLength = 30;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '⚡';
            this.Password.Size = new System.Drawing.Size(285, 31);
            this.Password.TabIndex = 2;
            this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
            // 
            // Registr_button
            // 
            this.Registr_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.Registr_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registr_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Registr_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registr_button.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registr_button.ForeColor = System.Drawing.Color.White;
            this.Registr_button.Location = new System.Drawing.Point(224, 49);
            this.Registr_button.Name = "Registr_button";
            this.Registr_button.Size = new System.Drawing.Size(109, 25);
            this.Registr_button.TabIndex = 4;
            this.Registr_button.Text = "Регистрация";
            this.Registr_button.UseVisualStyleBackColor = false;
            this.Registr_button.Click += new System.EventHandler(this.Registr_button_Click);
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_label.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Login_label.Location = new System.Drawing.Point(45, 81);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(47, 16);
            this.Login_label.TabIndex = 5;
            this.Login_label.Text = "Логин";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_label.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Password_label.Location = new System.Drawing.Point(45, 140);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(55, 16);
            this.Password_label.TabIndex = 6;
            this.Password_label.Text = "Пароль";
            // 
            // User_button
            // 
            this.User_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(179)))), ((int)(((byte)(51)))));
            this.User_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.User_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.User_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.User_button.ForeColor = System.Drawing.Color.White;
            this.User_button.Location = new System.Drawing.Point(124, 276);
            this.User_button.Name = "User_button";
            this.User_button.Size = new System.Drawing.Size(130, 32);
            this.User_button.TabIndex = 5;
            this.User_button.Text = "Калькулятор";
            this.User_button.UseVisualStyleBackColor = false;
            this.User_button.Click += new System.EventHandler(this.User_button_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.Silver;
            this.CloseButton.Location = new System.Drawing.Point(349, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(19, 18);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Controls.Add(this.User_button);
            this.MainPanel.Controls.Add(this.Password_label);
            this.MainPanel.Controls.Add(this.Login_label);
            this.MainPanel.Controls.Add(this.Registr_button);
            this.MainPanel.Controls.Add(this.Password);
            this.MainPanel.Controls.Add(this.Sign_in_button);
            this.MainPanel.Controls.Add(this.Login);
            this.MainPanel.Controls.Add(this.Sign_in_label);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(380, 320);
            this.MainPanel.TabIndex = 10;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // LogInMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(380, 320);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogInMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Sign_in_label;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Button Sign_in_button;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Registr_button;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Button User_button;
        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Panel MainPanel;
    }
}

