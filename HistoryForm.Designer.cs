namespace MosEnergo2._0
{
    partial class HistoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.CloseButton = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.DataGridViewChechi = new System.Windows.Forms.DataGridView();
            this.HistoryLabel = new System.Windows.Forms.Label();
            this.PokazaniyaPanel = new System.Windows.Forms.Panel();
            this.T3Label = new System.Windows.Forms.Label();
            this.Tarif1 = new System.Windows.Forms.TextBox();
            this.T2Label = new System.Windows.Forms.Label();
            this.Tarif2 = new System.Windows.Forms.TextBox();
            this.T1Label = new System.Windows.Forms.Label();
            this.Tarif3 = new System.Windows.Forms.TextBox();
            this.CrateDockButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewChechi)).BeginInit();
            this.PokazaniyaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.ForeColor = System.Drawing.Color.Silver;
            this.CloseButton.Location = new System.Drawing.Point(416, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(19, 18);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "X";
            this.CloseButton.Click += new System.EventHandler(FormMethods.CloseButton_Click);
            this.CloseButton.MouseEnter += new System.EventHandler(FormMethods.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(FormMethods.CloseButton_MouseLeave);
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.LogOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogOutButton.ForeColor = System.Drawing.Color.White;
            this.LogOutButton.Location = new System.Drawing.Point(355, 341);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(80, 25);
            this.LogOutButton.TabIndex = 11;
            this.LogOutButton.Text = "Назад";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // DataGridViewChechi
            // 
            this.DataGridViewChechi.AllowUserToAddRows = false;
            this.DataGridViewChechi.AllowUserToDeleteRows = false;
            this.DataGridViewChechi.AllowUserToResizeColumns = false;
            this.DataGridViewChechi.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewChechi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewChechi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewChechi.ColumnHeadersVisible = false;
            this.DataGridViewChechi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.DataGridViewChechi.Location = new System.Drawing.Point(322, 71);
            this.DataGridViewChechi.MultiSelect = false;
            this.DataGridViewChechi.Name = "DataGridViewChechi";
            this.DataGridViewChechi.ReadOnly = true;
            this.DataGridViewChechi.RowHeadersVisible = false;
            this.DataGridViewChechi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DataGridViewChechi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewChechi.Size = new System.Drawing.Size(104, 238);
            this.DataGridViewChechi.TabIndex = 12;
            this.DataGridViewChechi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewChechi_CellContentClick);
            // 
            // HistoryLabel
            // 
            this.HistoryLabel.AutoSize = true;
            this.HistoryLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HistoryLabel.ForeColor = System.Drawing.Color.White;
            this.HistoryLabel.Location = new System.Drawing.Point(12, 9);
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.Size = new System.Drawing.Size(214, 29);
            this.HistoryLabel.TabIndex = 56;
            this.HistoryLabel.Text = "История чеков";
            // 
            // PokazaniyaPanel
            // 
            this.PokazaniyaPanel.Controls.Add(this.T3Label);
            this.PokazaniyaPanel.Controls.Add(this.Tarif1);
            this.PokazaniyaPanel.Controls.Add(this.T2Label);
            this.PokazaniyaPanel.Controls.Add(this.Tarif2);
            this.PokazaniyaPanel.Controls.Add(this.T1Label);
            this.PokazaniyaPanel.Controls.Add(this.Tarif3);
            this.PokazaniyaPanel.Location = new System.Drawing.Point(31, 95);
            this.PokazaniyaPanel.Name = "PokazaniyaPanel";
            this.PokazaniyaPanel.Size = new System.Drawing.Size(270, 138);
            this.PokazaniyaPanel.TabIndex = 59;
            // 
            // T3Label
            // 
            this.T3Label.AutoSize = true;
            this.T3Label.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T3Label.ForeColor = System.Drawing.Color.White;
            this.T3Label.Location = new System.Drawing.Point(7, 101);
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
            this.Tarif1.Location = new System.Drawing.Point(42, 12);
            this.Tarif1.MaxLength = 30;
            this.Tarif1.Name = "Tarif1";
            this.Tarif1.Size = new System.Drawing.Size(207, 31);
            this.Tarif1.TabIndex = 1;
            // 
            // T2Label
            // 
            this.T2Label.AutoSize = true;
            this.T2Label.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T2Label.ForeColor = System.Drawing.Color.White;
            this.T2Label.Location = new System.Drawing.Point(7, 60);
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
            this.Tarif2.Location = new System.Drawing.Point(42, 54);
            this.Tarif2.MaxLength = 30;
            this.Tarif2.Name = "Tarif2";
            this.Tarif2.Size = new System.Drawing.Size(207, 31);
            this.Tarif2.TabIndex = 2;
            // 
            // T1Label
            // 
            this.T1Label.AutoSize = true;
            this.T1Label.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.T1Label.ForeColor = System.Drawing.Color.White;
            this.T1Label.Location = new System.Drawing.Point(7, 18);
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
            this.Tarif3.Location = new System.Drawing.Point(42, 95);
            this.Tarif3.MaxLength = 30;
            this.Tarif3.Name = "Tarif3";
            this.Tarif3.Size = new System.Drawing.Size(207, 31);
            this.Tarif3.TabIndex = 3;
            // 
            // CrateDockButton
            // 
            this.CrateDockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(179)))), ((int)(((byte)(51)))));
            this.CrateDockButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CrateDockButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CrateDockButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CrateDockButton.ForeColor = System.Drawing.Color.White;
            this.CrateDockButton.Location = new System.Drawing.Point(17, 330);
            this.CrateDockButton.Name = "CrateDockButton";
            this.CrateDockButton.Size = new System.Drawing.Size(299, 36);
            this.CrateDockButton.TabIndex = 60;
            this.CrateDockButton.Text = "Создать выходной документ";
            this.CrateDockButton.UseVisualStyleBackColor = false;
            this.CrateDockButton.Click += new System.EventHandler(this.CrateDockButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(179)))), ((int)(((byte)(51)))));
            this.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UpdateButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.Location = new System.Drawing.Point(41, 239);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(109, 28);
            this.UpdateButton.TabIndex = 61;
            this.UpdateButton.Text = "Изменить";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(182, 239);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(109, 28);
            this.DeleteButton.TabIndex = 62;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateLabel.ForeColor = System.Drawing.Color.White;
            this.DateLabel.Location = new System.Drawing.Point(319, 50);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(116, 18);
            this.DateLabel.TabIndex = 63;
            this.DateLabel.Text = "Дата чеков:";
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Укажите путь выходного файла";
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(447, 388);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CrateDockButton);
            this.Controls.Add(this.PokazaniyaPanel);
            this.Controls.Add(this.HistoryLabel);
            this.Controls.Add(this.DataGridViewChechi);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "История чеков";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(FormMethods.MainPanel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(FormMethods.MainPanel_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewChechi)).EndInit();
            this.PokazaniyaPanel.ResumeLayout(false);
            this.PokazaniyaPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CloseButton;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.DataGridView DataGridViewChechi;
        private System.Windows.Forms.Label HistoryLabel;
        private System.Windows.Forms.Panel PokazaniyaPanel;
        private System.Windows.Forms.Label T3Label;
        private System.Windows.Forms.TextBox Tarif1;
        private System.Windows.Forms.Label T2Label;
        private System.Windows.Forms.TextBox Tarif2;
        private System.Windows.Forms.Label T1Label;
        private System.Windows.Forms.TextBox Tarif3;
        private System.Windows.Forms.Button CrateDockButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}