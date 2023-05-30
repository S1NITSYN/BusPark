namespace BusPark
{
    partial class RegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            this.RegLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.ConfPasswordTextBox = new System.Windows.Forms.TextBox();
            this.LogLabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.ConfPassLabel = new System.Windows.Forms.Label();
            this.RegButton = new System.Windows.Forms.Button();
            this.LoginConditionLabel = new System.Windows.Forms.Label();
            this.CompPassLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailConditionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegLabel
            // 
            this.RegLabel.AutoSize = true;
            this.RegLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegLabel.Location = new System.Drawing.Point(433, 80);
            this.RegLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RegLabel.Name = "RegLabel";
            this.RegLabel.Size = new System.Drawing.Size(185, 31);
            this.RegLabel.TabIndex = 0;
            this.RegLabel.Text = "Регистрация";
            this.RegLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(432, 226);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(201, 22);
            this.LoginTextBox.TabIndex = 1;
            this.LoginTextBox.TextChanged += new System.EventHandler(this.LoginTextBox_TextChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(432, 289);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(201, 22);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // ConfPasswordTextBox
            // 
            this.ConfPasswordTextBox.Location = new System.Drawing.Point(432, 350);
            this.ConfPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ConfPasswordTextBox.Name = "ConfPasswordTextBox";
            this.ConfPasswordTextBox.Size = new System.Drawing.Size(201, 22);
            this.ConfPasswordTextBox.TabIndex = 3;
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.Location = new System.Drawing.Point(273, 226);
            this.LogLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(131, 16);
            this.LogLabel.TabIndex = 4;
            this.LogLabel.Text = "Придумайте Логин";
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.Location = new System.Drawing.Point(273, 289);
            this.PassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(139, 16);
            this.PassLabel.TabIndex = 5;
            this.PassLabel.Text = "Придумайте пароль";
            // 
            // ConfPassLabel
            // 
            this.ConfPassLabel.AutoSize = true;
            this.ConfPassLabel.Location = new System.Drawing.Point(273, 353);
            this.ConfPassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ConfPassLabel.Name = "ConfPassLabel";
            this.ConfPassLabel.Size = new System.Drawing.Size(145, 16);
            this.ConfPassLabel.TabIndex = 6;
            this.ConfPassLabel.Text = "Подтвердите пароль";
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(441, 449);
            this.RegButton.Margin = new System.Windows.Forms.Padding(4);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(184, 28);
            this.RegButton.TabIndex = 7;
            this.RegButton.Text = "Зарегистрироваться";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // LoginConditionLabel
            // 
            this.LoginConditionLabel.AutoSize = true;
            this.LoginConditionLabel.Location = new System.Drawing.Point(667, 226);
            this.LoginConditionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginConditionLabel.Name = "LoginConditionLabel";
            this.LoginConditionLabel.Size = new System.Drawing.Size(0, 16);
            this.LoginConditionLabel.TabIndex = 8;
            // 
            // CompPassLabel
            // 
            this.CompPassLabel.AutoSize = true;
            this.CompPassLabel.Location = new System.Drawing.Point(667, 358);
            this.CompPassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompPassLabel.Name = "CompPassLabel";
            this.CompPassLabel.Size = new System.Drawing.Size(0, 16);
            this.CompPassLabel.TabIndex = 9;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(432, 172);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(201, 22);
            this.EmailTextBox.TabIndex = 10;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(50, 172);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(354, 16);
            this.EmailLabel.TabIndex = 11;
            this.EmailLabel.Text = "Введите почту, которая будет привязана к аккаунту";
            // 
            // EmailConditionLabel
            // 
            this.EmailConditionLabel.AutoSize = true;
            this.EmailConditionLabel.Location = new System.Drawing.Point(670, 177);
            this.EmailConditionLabel.Name = "EmailConditionLabel";
            this.EmailConditionLabel.Size = new System.Drawing.Size(0, 16);
            this.EmailConditionLabel.TabIndex = 12;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.EmailConditionLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.CompPassLabel);
            this.Controls.Add(this.LoginConditionLabel);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.ConfPassLabel);
            this.Controls.Add(this.PassLabel);
            this.Controls.Add(this.LogLabel);
            this.Controls.Add(this.ConfPasswordTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.RegLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox ConfPasswordTextBox;
        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label ConfPassLabel;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Label LoginConditionLabel;
        private System.Windows.Forms.Label CompPassLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label EmailConditionLabel;
    }
}