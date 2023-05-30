using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusPark
{
    public partial class ConfirmEmail : Form
    {
        public bool passed = false;
        public ConfirmEmail()
        {
            InitializeComponent();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            if (EnterCodeTextBox.Text != WebInteraction.AcceptCode.ToString())
            {
                MessageBox.Show("неверное число");
                return;
            }
            passed = true;
            this.Close();
        }
    }
}
