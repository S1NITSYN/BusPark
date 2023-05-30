namespace BusPark
{
    partial class EnterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterForm));
            this.EnterButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordShower = new System.Windows.Forms.CheckBox();
            this.EnterLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.RegButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterButton
            // 
            this.EnterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterButton.Location = new System.Drawing.Point(436, 410);
            this.EnterButton.Margin = new System.Windows.Forms.Padding(4);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(100, 28);
            this.EnterButton.TabIndex = 0;
            this.EnterButton.Text = "войти";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordTextBox.Location = new System.Drawing.Point(388, 295);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(201, 22);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailTextBox.Location = new System.Drawing.Point(388, 192);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(201, 22);
            this.EmailTextBox.TabIndex = 2;
            // 
            // PasswordShower
            // 
            this.PasswordShower.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordShower.AutoSize = true;
            this.PasswordShower.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PasswordShower.Location = new System.Drawing.Point(629, 295);
            this.PasswordShower.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordShower.Name = "PasswordShower";
            this.PasswordShower.Size = new System.Drawing.Size(140, 20);
            this.PasswordShower.TabIndex = 3;
            this.PasswordShower.Text = "показать пароль";
            this.PasswordShower.UseVisualStyleBackColor = true;
            this.PasswordShower.CheckedChanged += new System.EventHandler(this.PasswordShower_CheckedChanged);
            // 
            // EnterLabel
            // 
            this.EnterLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EnterLabel.AutoSize = true;
            this.EnterLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.EnterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterLabel.Location = new System.Drawing.Point(313, 95);
            this.EnterLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnterLabel.Name = "EnterLabel";
            this.EnterLabel.Size = new System.Drawing.Size(324, 31);
            this.EnterLabel.TabIndex = 4;
            this.EnterLabel.Text = "Вход в личный аккаунт";
            // 
            // LoginLabel
            // 
            this.LoginLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Location = new System.Drawing.Point(265, 196);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(48, 16);
            this.LoginLabel.TabIndex = 5;
            this.LoginLabel.Text = "Почта";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(265, 300);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(54, 16);
            this.PasswordLabel.TabIndex = 6;
            this.PasswordLabel.Text = "пароль";
            // 
            // RegButton
            // 
            this.RegButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegButton.Location = new System.Drawing.Point(655, 188);
            this.RegButton.Margin = new System.Windows.Forms.Padding(4);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(172, 28);
            this.RegButton.TabIndex = 7;
            this.RegButton.Text = "зарегистрироваться";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.EnterLabel);
            this.Controls.Add(this.PasswordShower);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EnterButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EnterForm";
            this.Text = "Вход";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.EnterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.CheckBox PasswordShower;
        private System.Windows.Forms.Label EnterLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button RegButton;
    }
}

