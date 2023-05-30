using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusPark
{   
    public partial class appeal : Form
    {
        //private String path;
        private String SNP;
        private String body;
        private String mail;
        private String Theme;
        private String AppelType;
        List<string> attachments = new List<string>();
        public appeal()
        {
            InitializeComponent();
            AutoScroll = true;
        }

        private void FileAttachmentButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialog = new OpenFileDialog();
            Dialog.Filter = "Text Files | *.txt|Bitmap files (*.bmp)|*.bmp|Image files (*.jpg)|*.jpg|All files(*.*)|*."; // | Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif; | Office Files|*.doc;*.xls;*.ppt;*.xlsx;*.pptx;
            Dialog.Multiselect = false;
            if (Dialog.ShowDialog() == DialogResult.OK)
            {
                attachments.Add(Dialog.FileName);
                FileLoadedlabel.Text = $"{Dialog.FileName} загружен";
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "" || SNameTextBox.Text == "" || PatronymicTextBox.Text == "" || PoorDescriptionTextBox.Text == "")
            {
                    MessageBox.Show("введите значения во все строки");
                    return;
            }

            if (AcceptmentCheckBox.Checked)
            {
                SNP = AppelType + " на тему \"" + Theme + "\". ФИО отправителя: " + SNameTextBox.Text + ' ' + NameTextBox.Text + ' ' + PatronymicTextBox.Text;
                body = PoorDescriptionTextBox.Text + "\n\n" + RichDescriptionTextBox.Text + "\n\nКонтакт для связи\n" + FeedbackTextBox.Text;
                mail = "sin1tsyn@vk.com";
                WebInteraction.SendMessage(mail, SNP, body, attachments);
                MessageBox.Show("Письмо успешно отправлено");
            }
        }

        private void AppelationTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
            =>AppelType = AppelationTypeComboBox.SelectedItem.ToString();

        private void ThemeComboBox_SelectedIndexChanged(object sender, EventArgs e)
            =>Theme = ThemeComboBox.SelectedItem.ToString();

        private void RichDescriptionTextBox_TextChanged(object sender, EventArgs e)
            =>SymbNumsLabel.Text = (RichDescriptionTextBox.MaxLength - RichDescriptionTextBox.Text.Length).ToString();
    }
}
