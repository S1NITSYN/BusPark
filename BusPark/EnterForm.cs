using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BusPark
{
    public partial class EnterForm : Form
    {
        public EnterForm()
        {
            InitializeComponent();
            KeyPreview = true;
        }


        private void RegButton_Click(object sender, EventArgs e) //переводит нас на форму регистрации, а текущую форму прячет
        {
            this.Hide();
            RegForm form2 = new RegForm();
            form2.ShowDialog();
            this.Show();
        }

        private void EnterButton_Click(object sender, EventArgs e) //сверяет введенные данные с данными из бд для входа
        {
            IPStatus status = IPStatus.TimedOut;
            try
            {
                Ping p = new Ping();
                PingReply pr = p.Send("www.google.com");
                status = pr.Status;
            }
            catch { }
            if (status != IPStatus.Success)
            {
                MessageBox.Show("Необходимо наличие интернет-подключение");
                return;
            }
            DataTable table = DataBase.SelectFromUsersDB(EmailTextBox.Text, PasswordTextBox.Text);
            if (table.Rows.Count != 1)
            {
                MessageBox.Show("вход не был выполнен, проверьте введенные данные на корректность.");
                return;
            }
            MessageBox.Show("Вы успешно вошли в систему.");
            PasswordTextBox.Text = "";
            this.Hide();
            ForumForm form3 = new ForumForm();
            form3.ShowDialog();
            this.Show();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e) //чтобы программа не висела в процессах, приложение закрывается
            => Application.Exit();
       
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            EventArgs ef = new EventArgs();
            if (keyData == Keys.Enter)
                EnterButton_Click(msg, ef);
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void PasswordShower_CheckedChanged(object sender, EventArgs e)
            => PasswordTextBox.UseSystemPasswordChar = !PasswordTextBox.UseSystemPasswordChar;

        private void EnterForm_Load(object sender, EventArgs e)
            =>  PasswordTextBox.UseSystemPasswordChar = true;
        
    }
}
