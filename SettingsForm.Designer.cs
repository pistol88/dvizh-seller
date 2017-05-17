namespace DvizhSeller
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.settingsSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tokenBox = new System.Windows.Forms.TextBox();
            this.clientBox = new System.Windows.Forms.TextBox();
            this.hostBox = new System.Windows.Forms.TextBox();
            this.protocolBox = new System.Windows.Forms.TextBox();
            this.online = new System.Windows.Forms.CheckBox();
            this.fiscal = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.testMode = new System.Windows.Forms.CheckBox();
            this.checkNoteBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.barcodescaner = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cashboxId = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dbFileBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.roundingTypeBox = new System.Windows.Forms.ComboBox();
            this.roundingBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.languageBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.currencyBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsSave
            // 
            this.settingsSave.Location = new System.Drawing.Point(208, 365);
            this.settingsSave.Name = "settingsSave";
            this.settingsSave.Size = new System.Drawing.Size(75, 23);
            this.settingsSave.TabIndex = 20;
            this.settingsSave.Text = "Сохранить";
            this.settingsSave.UseVisualStyleBackColor = true;
            this.settingsSave.Click += new System.EventHandler(this.settingsSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Токен:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Клиент:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Хост:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Протокол:";
            // 
            // tokenBox
            // 
            this.tokenBox.Location = new System.Drawing.Point(70, 120);
            this.tokenBox.Name = "tokenBox";
            this.tokenBox.Size = new System.Drawing.Size(141, 20);
            this.tokenBox.TabIndex = 15;
            // 
            // clientBox
            // 
            this.clientBox.Location = new System.Drawing.Point(70, 68);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(141, 20);
            this.clientBox.TabIndex = 14;
            // 
            // hostBox
            // 
            this.hostBox.Location = new System.Drawing.Point(70, 94);
            this.hostBox.Name = "hostBox";
            this.hostBox.Size = new System.Drawing.Size(141, 20);
            this.hostBox.TabIndex = 13;
            // 
            // protocolBox
            // 
            this.protocolBox.Location = new System.Drawing.Point(70, 42);
            this.protocolBox.Name = "protocolBox";
            this.protocolBox.Size = new System.Drawing.Size(141, 20);
            this.protocolBox.TabIndex = 12;
            // 
            // online
            // 
            this.online.AutoSize = true;
            this.online.Location = new System.Drawing.Point(70, 19);
            this.online.Name = "online";
            this.online.Size = new System.Drawing.Size(101, 17);
            this.online.TabIndex = 11;
            this.online.Text = "Онлайн режим";
            this.online.UseVisualStyleBackColor = true;
            // 
            // fiscal
            // 
            this.fiscal.AutoSize = true;
            this.fiscal.Location = new System.Drawing.Point(6, 19);
            this.fiscal.Name = "fiscal";
            this.fiscal.Size = new System.Drawing.Size(159, 17);
            this.fiscal.TabIndex = 21;
            this.fiscal.Text = "Фискальный регистратор";
            this.fiscal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.testMode);
            this.groupBox1.Controls.Add(this.checkNoteBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.barcodescaner);
            this.groupBox1.Controls.Add(this.fiscal);
            this.groupBox1.Location = new System.Drawing.Point(9, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 123);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оборудование";
            // 
            // testMode
            // 
            this.testMode.AutoSize = true;
            this.testMode.Location = new System.Drawing.Point(6, 42);
            this.testMode.Name = "testMode";
            this.testMode.Size = new System.Drawing.Size(113, 17);
            this.testMode.TabIndex = 23;
            this.testMode.Text = "Тестовый режим";
            this.testMode.UseVisualStyleBackColor = true;
            // 
            // checkNoteBox
            // 
            this.checkNoteBox.Location = new System.Drawing.Point(107, 97);
            this.checkNoteBox.Name = "checkNoteBox";
            this.checkNoteBox.Size = new System.Drawing.Size(107, 20);
            this.checkNoteBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Пометка на чеке:";
            // 
            // barcodescaner
            // 
            this.barcodescaner.AutoSize = true;
            this.barcodescaner.Enabled = false;
            this.barcodescaner.Location = new System.Drawing.Point(6, 65);
            this.barcodescaner.Name = "barcodescaner";
            this.barcodescaner.Size = new System.Drawing.Size(120, 17);
            this.barcodescaner.TabIndex = 22;
            this.barcodescaner.Text = "Сканер штрихкода";
            this.barcodescaner.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cashboxId);
            this.groupBox2.Controls.Add(this.hostBox);
            this.groupBox2.Controls.Add(this.online);
            this.groupBox2.Controls.Add(this.protocolBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.clientBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tokenBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 199);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "dvizh.net";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Касса:";
            // 
            // cashboxId
            // 
            this.cashboxId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cashboxId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cashboxId.FormattingEnabled = true;
            this.cashboxId.Location = new System.Drawing.Point(70, 147);
            this.cashboxId.Name = "cashboxId";
            this.cashboxId.Size = new System.Drawing.Size(141, 21);
            this.cashboxId.TabIndex = 20;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dbFileBox);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.roundingTypeBox);
            this.groupBox3.Controls.Add(this.roundingBox);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.languageBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.currencyBox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(249, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 328);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Общие";
            // 
            // dbFileBox
            // 
            this.dbFileBox.AutoCompleteCustomSource.AddRange(new string[] {
            "р.",
            "грн.",
            "$",
            "euro"});
            this.dbFileBox.Location = new System.Drawing.Point(73, 179);
            this.dbFileBox.Name = "dbFileBox";
            this.dbFileBox.Size = new System.Drawing.Size(141, 20);
            this.dbFileBox.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 182);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "База:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Округление:";
            // 
            // roundingTypeBox
            // 
            this.roundingTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roundingTypeBox.FormattingEnabled = true;
            this.roundingTypeBox.Items.AddRange(new object[] {
            "не округлять копейки",
            "до 1",
            "до 5",
            "до 10"});
            this.roundingTypeBox.Location = new System.Drawing.Point(15, 120);
            this.roundingTypeBox.Name = "roundingTypeBox";
            this.roundingTypeBox.Size = new System.Drawing.Size(199, 21);
            this.roundingTypeBox.TabIndex = 25;
            // 
            // roundingBox
            // 
            this.roundingBox.Location = new System.Drawing.Point(169, 147);
            this.roundingBox.Name = "roundingBox";
            this.roundingBox.Size = new System.Drawing.Size(45, 20);
            this.roundingBox.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "После запятой оставлять:";
            // 
            // languageBox
            // 
            this.languageBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageBox.Enabled = false;
            this.languageBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.languageBox.FormattingEnabled = true;
            this.languageBox.Items.AddRange(new object[] {
            "Русский"});
            this.languageBox.Location = new System.Drawing.Point(73, 53);
            this.languageBox.Name = "languageBox";
            this.languageBox.Size = new System.Drawing.Size(141, 21);
            this.languageBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Язык:";
            // 
            // currencyBox
            // 
            this.currencyBox.AutoCompleteCustomSource.AddRange(new string[] {
            "р.",
            "грн.",
            "$",
            "euro"});
            this.currencyBox.Location = new System.Drawing.Point(73, 27);
            this.currencyBox.Name = "currencyBox";
            this.currencyBox.Size = new System.Drawing.Size(141, 20);
            this.currencyBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Валюта:";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 400);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.settingsSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settingsSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tokenBox;
        private System.Windows.Forms.TextBox clientBox;
        private System.Windows.Forms.TextBox hostBox;
        private System.Windows.Forms.TextBox protocolBox;
        private System.Windows.Forms.CheckBox online;
        private System.Windows.Forms.CheckBox fiscal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox checkNoteBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox barcodescaner;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox languageBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox currencyBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cashboxId;
        private System.Windows.Forms.ComboBox roundingTypeBox;
        private System.Windows.Forms.TextBox roundingBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox dbFileBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox testMode;
    }
}