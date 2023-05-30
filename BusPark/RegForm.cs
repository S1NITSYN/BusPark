using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusPark
{
    public partial class RegForm : Form
    {
        bool GeneratedCode = false;
        Random RandForAcceptCode= new Random();
        public RegForm()
        {
            InitializeComponent();
        }
        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "")
                LoginConditionLabel.Text = "";
            DataTable table = DataBase.SelectFromUsersDB(LoginTextBox.Text);
            if (table.Rows.Count > 0)
            {
                LoginConditionLabel.ForeColor = Color.Red;
                LoginConditionLabel.Text = "этот логин уже существует в системе";
                return;
            }
            LoginConditionLabel.ForeColor = Color.Green;
            LoginConditionLabel.Text = "этот логин свободен";
        }
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (EmailTextBox.Text == "")
                EmailConditionLabel.Text = "";
            DataTable table = DataBase.SelectEmailFromUsersDB(EmailTextBox.Text);
            if (table.Rows.Count > 0)
            {
                EmailConditionLabel.ForeColor = Color.Red;
                EmailConditionLabel.Text = "эта почта уже используется";
                return;
            }
            EmailConditionLabel.ForeColor = Color.Green;
            EmailConditionLabel.Text = "эта почта не используется";
        }

       /* private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        => Application.Exit();*/

        private void RegButton_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(EmailTextBox.Text, "^\\S+@\\S+\\.\\S+$"))
            {
                MessageBox.Show("неверный формат почты");
                return;
            }
            if (PasswordTextBox.Text == "" || LoginTextBox.Text == "" || ConfPasswordTextBox.Text == "")
            {
                MessageBox.Show("ни одно из полей не должно остаться пустым. Пожалуйста, заполните все представленные поля");
                return;
            }
            if (PasswordTextBox.Text != ConfPasswordTextBox.Text)
            {
                MessageBox.Show("введенные пароли не совпадают");
                return;
            }

            DataTable EmailTable = DataBase.SelectEmailFromUsersDB(EmailTextBox.Text);
            DataTable LogTable = DataBase.SelectFromUsersDB(LoginTextBox.Text);
            if (EmailTable.Rows.Count == 0 && LogTable.Rows.Count == 0)
            {

                ConfirmEmail Confirmation = new ConfirmEmail();
                if(!GeneratedCode)
                    WebInteraction.SendMessage(EmailTextBox.Text, "Добрый день, вас привествует МосГорТранс", $"Код для подтверждения регистрации:{WebInteraction.AcceptCode = RandForAcceptCode.Next()}");
                Confirmation.ShowDialog();
                while (true)
                {
                    if (Confirmation.passed)
                    {
                        DataBase.InsertIntoUsersDB(LoginTextBox.Text, PasswordTextBox.Text, EmailTextBox.Text);
                        break;
                    }
                    if (!Confirmation.Visible)
                    {
                        GeneratedCode = true;
                        return;
                    }
                }
                MessageBox.Show("Вы были успешно зарегистрированы в систему.");
                this.Close();
                return;
            }
            MessageBox.Show("Вы не можете зарегистрироваться, т.к. введенный вами логин, или почта уже существует в системе.");
        }

    }
}
