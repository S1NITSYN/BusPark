namespace BusPark
{
    partial class appeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appeal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AppelationTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ThemeComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PoorDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FileAttachmentButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RichDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SNameTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PatronymicTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.FeedbackTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.FileLoadedlabel = new System.Windows.Forms.Label();
            this.AddedFiles = new System.Windows.Forms.Label();
            this.AcceptmentCheckBox = new System.Windows.Forms.CheckBox();
            this.SymbNumsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(164, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "ПОЖАЛУЙСТА, ЗАПОЛНИТЕ ФОРМУ\r\n\r\nПараметры обращения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип обращения:";
            // 
            // AppelationTypeComboBox
            // 
            this.AppelationTypeComboBox.FormattingEnabled = true;
            this.AppelationTypeComboBox.Items.AddRange(new object[] {
            "Заявление",
            "Предложение",
            "Жалоба",
            "Благодарность"});
            this.AppelationTypeComboBox.Location = new System.Drawing.Point(190, 156);
            this.AppelationTypeComboBox.Name = "AppelationTypeComboBox";
            this.AppelationTypeComboBox.Size = new System.Drawing.Size(430, 24);
            this.AppelationTypeComboBox.TabIndex = 2;
            this.AppelationTypeComboBox.Text = "Заявление";
            this.AppelationTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.AppelationTypeComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тематика:";
            // 
            // ThemeComboBox
            // 
            this.ThemeComboBox.FormattingEnabled = true;
            this.ThemeComboBox.Items.AddRange(new object[] {
            "Организация дорожного движения и улично-дорожная сеть",
            "Наземный пассажирский общественный транспорт",
            "Транспортная безопасность",
            "Информационно-рекламное обслуживание"});
            this.ThemeComboBox.Location = new System.Drawing.Point(190, 225);
            this.ThemeComboBox.Name = "ThemeComboBox";
            this.ThemeComboBox.Size = new System.Drawing.Size(430, 24);
            this.ThemeComboBox.TabIndex = 4;
            this.ThemeComboBox.Text = "Организация дорожного движения и улично-дорожная сеть";
            this.ThemeComboBox.SelectedIndexChanged += new System.EventHandler(this.ThemeComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(166, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(434, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Информация об объекте обращения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Краткое описание:";
            // 
            // PoorDescriptionTextBox
            // 
            this.PoorDescriptionTextBox.Location = new System.Drawing.Point(196, 334);
            this.PoorDescriptionTextBox.Name = "PoorDescriptionTextBox";
            this.PoorDescriptionTextBox.Size = new System.Drawing.Size(424, 22);
            this.PoorDescriptionTextBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Вложения:";
            // 
            // FileAttachmentButton
            // 
            this.FileAttachmentButton.Location = new System.Drawing.Point(196, 396);
            this.FileAttachmentButton.Name = "FileAttachmentButton";
            this.FileAttachmentButton.Size = new System.Drawing.Size(129, 23);
            this.FileAttachmentButton.TabIndex = 9;
            this.FileAttachmentButton.Text = "выберите файл";
            this.FileAttachmentButton.UseVisualStyleBackColor = true;
            this.FileAttachmentButton.Click += new System.EventHandler(this.FileAttachmentButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(166, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(367, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Описание ситуации / контекста";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(441, 607);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Осталось символов:";
            // 
            // RichDescriptionTextBox
            // 
            this.RichDescriptionTextBox.Location = new System.Drawing.Point(190, 484);
            this.RichDescriptionTextBox.MaxLength = 500;
            this.RichDescriptionTextBox.Name = "RichDescriptionTextBox";
            this.RichDescriptionTextBox.Size = new System.Drawing.Size(430, 120);
            this.RichDescriptionTextBox.TabIndex = 12;
            this.RichDescriptionTextBox.Text = "";
            this.RichDescriptionTextBox.TextChanged += new System.EventHandler(this.RichDescriptionTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(166, 640);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(300, 29);
            this.label9.TabIndex = 13;
            this.label9.Text = "Контактная информация";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(187, 689);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Фамилия:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(187, 756);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "Имя:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(188, 823);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "Отчество:";
            // 
            // SNameTextBox
            // 
            this.SNameTextBox.Location = new System.Drawing.Point(190, 719);
            this.SNameTextBox.Name = "SNameTextBox";
            this.SNameTextBox.Size = new System.Drawing.Size(430, 22);
            this.SNameTextBox.TabIndex = 17;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(190, 785);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(430, 22);
            this.NameTextBox.TabIndex = 18;
            // 
            // PatronymicTextBox
            // 
            this.PatronymicTextBox.Location = new System.Drawing.Point(190, 851);
            this.PatronymicTextBox.Name = "PatronymicTextBox";
            this.PatronymicTextBox.Size = new System.Drawing.Size(430, 22);
            this.PatronymicTextBox.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(188, 891);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(418, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Электронная почта, или номер телефона для обратной связи: ";
            // 
            // FeedbackTextBox
            // 
            this.FeedbackTextBox.Location = new System.Drawing.Point(190, 926);
            this.FeedbackTextBox.Name = "FeedbackTextBox";
            this.FeedbackTextBox.Size = new System.Drawing.Size(430, 22);
            this.FeedbackTextBox.TabIndex = 21;
            // 
            // SendButton
            // 
            this.SendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SendButton.Location = new System.Drawing.Point(477, 1007);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(143, 36);
            this.SendButton.TabIndex = 23;
            this.SendButton.Text = "Отправить";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // FileLoadedlabel
            // 
            this.FileLoadedlabel.AutoSize = true;
            this.FileLoadedlabel.Location = new System.Drawing.Point(331, 399);
            this.FileLoadedlabel.Name = "FileLoadedlabel";
            this.FileLoadedlabel.Size = new System.Drawing.Size(0, 16);
            this.FileLoadedlabel.TabIndex = 24;
            // 
            // AddedFiles
            // 
            this.AddedFiles.AutoSize = true;
            this.AddedFiles.Location = new System.Drawing.Point(332, 419);
            this.AddedFiles.Name = "AddedFiles";
            this.AddedFiles.Size = new System.Drawing.Size(0, 16);
            this.AddedFiles.TabIndex = 25;
            // 
            // AcceptmentCheckBox
            // 
            this.AcceptmentCheckBox.AutoSize = true;
            this.AcceptmentCheckBox.Location = new System.Drawing.Point(196, 955);
            this.AcceptmentCheckBox.Name = "AcceptmentCheckBox";
            this.AcceptmentCheckBox.Size = new System.Drawing.Size(425, 36);
            this.AcceptmentCheckBox.TabIndex = 26;
            this.AcceptmentCheckBox.Text = "Я ознакомлен и принимаю правила приема\r\nи обработки обращений граждан в департаме" +
    "нт транспорта";
            this.AcceptmentCheckBox.UseVisualStyleBackColor = true;
            // 
            // SymbNumsLabel
            // 
            this.SymbNumsLabel.AutoSize = true;
            this.SymbNumsLabel.Location = new System.Drawing.Point(586, 607);
            this.SymbNumsLabel.Name = "SymbNumsLabel";
            this.SymbNumsLabel.Size = new System.Drawing.Size(28, 16);
            this.SymbNumsLabel.TabIndex = 27;
            this.SymbNumsLabel.Text = "500";
            // 
            // appeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(847, 765);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AcceptmentCheckBox);
            this.Controls.Add(this.AddedFiles);
            this.Controls.Add(this.FileLoadedlabel);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.FeedbackTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.PatronymicTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SNameTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RichDescriptionTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FileAttachmentButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PoorDescriptionTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ThemeComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AppelationTypeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SymbNumsLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "appeal";
            this.Text = "appeal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AppelationTypeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ThemeComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PoorDescriptionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button FileAttachmentButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox RichDescriptionTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox SNameTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PatronymicTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox FeedbackTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label FileLoadedlabel;
        private System.Windows.Forms.Label AddedFiles;
        private System.Windows.Forms.CheckBox AcceptmentCheckBox;
        private System.Windows.Forms.Label SymbNumsLabel;
    }
}