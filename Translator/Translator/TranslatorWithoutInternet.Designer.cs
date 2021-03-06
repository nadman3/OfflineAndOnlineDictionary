﻿namespace Translator
{
    partial class TranslatorWithoutInternet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TranslatorWithoutInternet));
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReplaceLanguages = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonTranslate = new System.Windows.Forms.Button();
            this.languageTo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSentence = new System.Windows.Forms.TextBox();
            this.languageFrom = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxOfAviableWords = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статус з\'єднання";
            // 
            // buttonReplaceLanguages
            // 
            this.buttonReplaceLanguages.Location = new System.Drawing.Point(301, 8);
            this.buttonReplaceLanguages.Name = "buttonReplaceLanguages";
            this.buttonReplaceLanguages.Size = new System.Drawing.Size(56, 34);
            this.buttonReplaceLanguages.TabIndex = 24;
            this.buttonReplaceLanguages.Text = "<- | ->";
            this.buttonReplaceLanguages.UseVisualStyleBackColor = true;
            this.buttonReplaceLanguages.Click += new System.EventHandler(this.buttonReplaceLanguages_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(387, 49);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(260, 90);
            this.textBoxResult.TabIndex = 23;
            // 
            // buttonTranslate
            // 
            this.buttonTranslate.Location = new System.Drawing.Point(278, 64);
            this.buttonTranslate.Name = "buttonTranslate";
            this.buttonTranslate.Size = new System.Drawing.Size(103, 59);
            this.buttonTranslate.TabIndex = 22;
            this.buttonTranslate.Text = "ПЕРЕКЛАСТИ ->";
            this.buttonTranslate.UseVisualStyleBackColor = true;
            this.buttonTranslate.Click += new System.EventHandler(this.buttonTranslate_Click);
            // 
            // languageTo
            // 
            this.languageTo.FormattingEnabled = true;
            this.languageTo.Items.AddRange(new object[] {
            "English",
            "Українська",
            "Русский",
            "Français",
            "Deutsch",
            "日本の"});
            this.languageTo.Location = new System.Drawing.Point(497, 16);
            this.languageTo.Name = "languageTo";
            this.languageTo.Size = new System.Drawing.Size(150, 21);
            this.languageTo.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Мова перекладу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Мова оригіналу";
            // 
            // textBoxSentence
            // 
            this.textBoxSentence.Location = new System.Drawing.Point(12, 49);
            this.textBoxSentence.Multiline = true;
            this.textBoxSentence.Name = "textBoxSentence";
            this.textBoxSentence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSentence.Size = new System.Drawing.Size(260, 90);
            this.textBoxSentence.TabIndex = 18;
            // 
            // languageFrom
            // 
            this.languageFrom.FormattingEnabled = true;
            this.languageFrom.Items.AddRange(new object[] {
            "English",
            "Українська",
            "Русский",
            "Français",
            "Deutsch",
            "日本の"});
            this.languageFrom.Location = new System.Drawing.Point(108, 16);
            this.languageFrom.Name = "languageFrom";
            this.languageFrom.Size = new System.Drawing.Size(150, 21);
            this.languageFrom.TabIndex = 17;
            this.languageFrom.SelectedIndexChanged += new System.EventHandler(this.languageFrom_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Додати слово до словника";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxOfAviableWords
            // 
            this.comboBoxOfAviableWords.FormattingEnabled = true;
            this.comboBoxOfAviableWords.Location = new System.Drawing.Point(301, 162);
            this.comboBoxOfAviableWords.Name = "comboBoxOfAviableWords";
            this.comboBoxOfAviableWords.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOfAviableWords.TabIndex = 26;
            this.comboBoxOfAviableWords.SelectedIndexChanged += new System.EventHandler(this.comboBoxOfAviableWords_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Доступні слова по обраній мові : ";
            // 
            // TranslatorWithoutInternet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 192);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxOfAviableWords);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonReplaceLanguages);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonTranslate);
            this.Controls.Add(this.languageTo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSentence);
            this.Controls.Add(this.languageFrom);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TranslatorWithoutInternet";
            this.Text = "Словник";
            this.Load += new System.EventHandler(this.TranslatorWithoutInternet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
        private System.Data.OleDb.OleDbCommand oleDbCommand1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReplaceLanguages;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonTranslate;
        private System.Windows.Forms.ComboBox languageTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSentence;
        private System.Windows.Forms.ComboBox languageFrom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxOfAviableWords;
        private System.Windows.Forms.Label label4;
    }
}