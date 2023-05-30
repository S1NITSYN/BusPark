namespace BusPark
{
    partial class ConfirmEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmEmail));
            this.EmailCodeLabel = new System.Windows.Forms.Label();
            this.EnterCodeTextBox = new System.Windows.Forms.TextBox();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailCodeLabel
            // 
            this.EmailCodeLabel.AutoSize = true;
            this.EmailCodeLabel.Location = new System.Drawing.Point(73, 66);
            this.EmailCodeLabel.Name = "EmailCodeLabel";
            this.EmailCodeLabel.Size = new System.Drawing.Size(353, 16);
            this.EmailCodeLabel.TabIndex = 0;
            this.EmailCodeLabel.Text = "Введите код из сообщения, отправленного на почту:";
            // 
            // EnterCodeTextBox
            // 
            this.EnterCodeTextBox.Location = new System.Drawing.Point(432, 66);
            this.EnterCodeTextBox.Name = "EnterCodeTextBox";
            this.EnterCodeTextBox.Size = new System.Drawing.Size(100, 22);
            this.EnterCodeTextBox.TabIndex = 1;
            // 
            // ContinueButton
            // 
            this.ContinueButton.Location = new System.Drawing.Point(432, 104);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(103, 23);
            this.ContinueButton.TabIndex = 2;
            this.ContinueButton.Text = "продолжить";
            this.ContinueButton.UseVisualStyleBackColor = true;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // ConfirmEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(631, 183);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.EnterCodeTextBox);
            this.Controls.Add(this.EmailCodeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfirmEmail";
            this.Text = "Подтверждение прикрепляемого почтого ящика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmailCodeLabel;
        private System.Windows.Forms.TextBox EnterCodeTextBox;
        private System.Windows.Forms.Button ContinueButton;
    }
}