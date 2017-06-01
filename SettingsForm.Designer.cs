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
            this.testMode = new System.Windows.Forms.CheckBox();
            this.checkNoteBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.barcodescaner = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cashboxId = new System.Windows.Forms.ComboBox();
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
            this.fiscalDriverTypeBox = new System.Windows.Forms.ComboBox();
            this.fiscalComPortBox = new System.Windows.Forms.TextBox();
            this.atolSettingsButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.fiscalSettings = new System.Windows.Forms.GroupBox();
            this.savingInfo = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.fiscalSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsSave
            // 
            this.settingsSave.Location = new System.Drawing.Point(169, 271);
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
            this.label4.Location = new System.Drawing.Point(29, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Токен:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Клиент:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Хост:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Протокол:";
            // 
            // tokenBox
            // 
            this.tokenBox.Location = new System.Drawing.Point(72, 112);
            this.tokenBox.Name = "tokenBox";
            this.tokenBox.Size = new System.Drawing.Size(141, 20);
            this.tokenBox.TabIndex = 15;
            // 
            // clientBox
            // 
            this.clientBox.Location = new System.Drawing.Point(72, 60);
            this.clientBox.Name = "clientBox";
            this.clientBox.Size = new System.Drawing.Size(141, 20);
            this.clientBox.TabIndex = 14;
            // 
            // hostBox
            // 
            this.hostBox.Location = new System.Drawing.Point(72, 86);
            this.hostBox.Name = "hostBox";
            this.hostBox.Size = new System.Drawing.Size(141, 20);
            this.hostBox.TabIndex = 13;
            // 
            // protocolBox
            // 
            this.protocolBox.Location = new System.Drawing.Point(72, 34);
            this.protocolBox.Name = "protocolBox";
            this.protocolBox.Size = new System.Drawing.Size(141, 20);
            this.protocolBox.TabIndex = 12;
            // 
            // online
            // 
            this.online.AutoSize = true;
            this.online.Location = new System.Drawing.Point(72, 11);
            this.online.Name = "online";
            this.online.Size = new System.Drawing.Size(101, 17);
            this.online.TabIndex = 11;
            this.online.Text = "Онлайн режим";
            this.online.UseVisualStyleBackColor = true;
            // 
            // fiscal
            // 
            this.fiscal.AutoSize = true;
            this.fiscal.Location = new System.Drawing.Point(16, 16);
            this.fiscal.Name = "fiscal";
            this.fiscal.Size = new System.Drawing.Size(159, 17);
            this.fiscal.TabIndex = 21;
            this.fiscal.Text = "Фискальный регистратор";
            this.fiscal.UseVisualStyleBackColor = true;
            this.fiscal.CheckedChanged += new System.EventHandler(this.fiscal_CheckedChanged);
            // 
            // testMode
            // 
            this.testMode.AutoSize = true;
            this.testMode.Location = new System.Drawing.Point(15, 83);
            this.testMode.Name = "testMode";
            this.testMode.Size = new System.Drawing.Size(113, 17);
            this.testMode.TabIndex = 23;
            this.testMode.Text = "Тестовый режим";
            this.testMode.UseVisualStyleBackColor = true;
            // 
            // checkNoteBox
            // 
            this.checkNoteBox.Location = new System.Drawing.Point(118, 55);
            this.checkNoteBox.Name = "checkNoteBox";
            this.checkNoteBox.Size = new System.Drawing.Size(131, 20);
            this.checkNoteBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Пометка на чеке:";
            // 
            // barcodescaner
            // 
            this.barcodescaner.AutoSize = true;
            this.barcodescaner.Enabled = false;
            this.barcodescaner.Location = new System.Drawing.Point(16, 173);
            this.barcodescaner.Name = "barcodescaner";
            this.barcodescaner.Size = new System.Drawing.Size(120, 17);
            this.barcodescaner.TabIndex = 22;
            this.barcodescaner.Text = "Сканер штрихкода";
            this.barcodescaner.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 142);
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
            this.cashboxId.Location = new System.Drawing.Point(72, 139);
            this.cashboxId.Name = "cashboxId";
            this.cashboxId.Size = new System.Drawing.Size(141, 21);
            this.cashboxId.TabIndex = 20;
            // 
            // dbFileBox
            // 
            this.dbFileBox.AutoCompleteCustomSource.AddRange(new string[] {
            "р.",
            "грн.",
            "$",
            "euro"});
            this.dbFileBox.Location = new System.Drawing.Point(57, 109);
            this.dbFileBox.Name = "dbFileBox";
            this.dbFileBox.Size = new System.Drawing.Size(315, 20);
            this.dbFileBox.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "База:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(202, 19);
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
            this.roundingTypeBox.Location = new System.Drawing.Point(205, 42);
            this.roundingTypeBox.Name = "roundingTypeBox";
            this.roundingTypeBox.Size = new System.Drawing.Size(167, 21);
            this.roundingTypeBox.TabIndex = 25;
            // 
            // roundingBox
            // 
            this.roundingBox.Location = new System.Drawing.Point(327, 69);
            this.roundingBox.Name = "roundingBox";
            this.roundingBox.Size = new System.Drawing.Size(45, 20);
            this.roundingBox.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(202, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "После запятой:";
            // 
            // languageBox
            // 
            this.languageBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.languageBox.Enabled = false;
            this.languageBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.languageBox.FormattingEnabled = true;
            this.languageBox.Items.AddRange(new object[] {
            "Русский"});
            this.languageBox.Location = new System.Drawing.Point(74, 43);
            this.languageBox.Name = "languageBox";
            this.languageBox.Size = new System.Drawing.Size(109, 21);
            this.languageBox.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 51);
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
            this.currencyBox.Location = new System.Drawing.Point(74, 17);
            this.currencyBox.Name = "currencyBox";
            this.currencyBox.Size = new System.Drawing.Size(109, 20);
            this.currencyBox.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Валюта:";
            // 
            // fiscalDriverTypeBox
            // 
            this.fiscalDriverTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fiscalDriverTypeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fiscalDriverTypeBox.FormattingEnabled = true;
            this.fiscalDriverTypeBox.Location = new System.Drawing.Point(15, 23);
            this.fiscalDriverTypeBox.Name = "fiscalDriverTypeBox";
            this.fiscalDriverTypeBox.Size = new System.Drawing.Size(97, 21);
            this.fiscalDriverTypeBox.TabIndex = 29;
            this.fiscalDriverTypeBox.SelectedValueChanged += new System.EventHandler(this.fiscalDriverTypeBox_SelectedValueChanged);
            // 
            // fiscalComPortBox
            // 
            this.fiscalComPortBox.AutoCompleteCustomSource.AddRange(new string[] {
            "р.",
            "грн.",
            "$",
            "euro"});
            this.fiscalComPortBox.Enabled = false;
            this.fiscalComPortBox.Location = new System.Drawing.Point(118, 22);
            this.fiscalComPortBox.Name = "fiscalComPortBox";
            this.fiscalComPortBox.Size = new System.Drawing.Size(56, 20);
            this.fiscalComPortBox.TabIndex = 29;
            // 
            // atolSettingsButton
            // 
            this.atolSettingsButton.Enabled = false;
            this.atolSettingsButton.Location = new System.Drawing.Point(180, 20);
            this.atolSettingsButton.Name = "atolSettingsButton";
            this.atolSettingsButton.Size = new System.Drawing.Size(69, 23);
            this.atolSettingsButton.TabIndex = 30;
            this.atolSettingsButton.Text = "Настроить";
            this.atolSettingsButton.UseVisualStyleBackColor = true;
            this.atolSettingsButton.Click += new System.EventHandler(this.atolSettingsButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(402, 252);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dbFileBox);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.currencyBox);
            this.tabPage1.Controls.Add(this.roundingTypeBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.roundingBox);
            this.tabPage1.Controls.Add(this.languageBox);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(394, 226);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Общие";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cashboxId);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.hostBox);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.online);
            this.tabPage2.Controls.Add(this.tokenBox);
            this.tabPage2.Controls.Add(this.protocolBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.clientBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(394, 251);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dvizh.net";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.fiscalSettings);
            this.tabPage3.Controls.Add(this.fiscal);
            this.tabPage3.Controls.Add(this.barcodescaner);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(394, 251);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Оборудование";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // fiscalSettings
            // 
            this.fiscalSettings.Controls.Add(this.fiscalDriverTypeBox);
            this.fiscalSettings.Controls.Add(this.atolSettingsButton);
            this.fiscalSettings.Controls.Add(this.fiscalComPortBox);
            this.fiscalSettings.Controls.Add(this.testMode);
            this.fiscalSettings.Controls.Add(this.label6);
            this.fiscalSettings.Controls.Add(this.checkNoteBox);
            this.fiscalSettings.Enabled = false;
            this.fiscalSettings.Location = new System.Drawing.Point(16, 39);
            this.fiscalSettings.Name = "fiscalSettings";
            this.fiscalSettings.Size = new System.Drawing.Size(268, 115);
            this.fiscalSettings.TabIndex = 31;
            this.fiscalSettings.TabStop = false;
            this.fiscalSettings.Text = "Настройки";
            // 
            // savingInfo
            // 
            this.savingInfo.AutoSize = true;
            this.savingInfo.Location = new System.Drawing.Point(71, 301);
            this.savingInfo.Name = "savingInfo";
            this.savingInfo.Size = new System.Drawing.Size(41, 13);
            this.savingInfo.TabIndex = 26;
            this.savingInfo.Text = "label12";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 337);
            this.Controls.Add(this.savingInfo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.settingsSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.fiscalSettings.ResumeLayout(false);
            this.fiscalSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox checkNoteBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox barcodescaner;
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
        private System.Windows.Forms.TextBox fiscalComPortBox;
        private System.Windows.Forms.ComboBox fiscalDriverTypeBox;
        private System.Windows.Forms.Button atolSettingsButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox fiscalSettings;
        private System.Windows.Forms.Label savingInfo;
    }
}