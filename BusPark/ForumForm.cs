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
    public partial class ForumForm : Form
    {
        public ForumForm()
        {
            InitializeComponent();
            pictureBox2.SendToBack();
            pictureBox15.Cursor= Cursors.Hand;
            ChoosingNumOfMarchroutelabel.Text = "Выберите номер автобуса, у\n которого хотите посмотреть расписание";
        }
        private void UpdateControlsVisibility(bool galleryVisible, bool ticketsVisible, bool historyVisible, bool generalsVisible, bool contactsVisible, bool scheduleVisible, bool ChoosingNumOfMarchrouteComboBoxVisible, bool ScheduleDataGridViewVisible, bool ChoosingNumOfMarchroutelabelVisible)
        {
            Gallery.Visible = galleryVisible;
            TicketstableLayoutPanel.Visible = ticketsVisible;
            HistoryRichTextBox.Visible = historyVisible;
            GeneralsTableLayoutPanel.Visible = generalsVisible;
            ContactsTableLayoutPanel.Visible = contactsVisible;
            ScheduleDataGridView.Visible = scheduleVisible;
            ChoosingNumOfMarchrouteComboBox.Visible = ChoosingNumOfMarchrouteComboBoxVisible;
            ScheduleDataGridView.Visible = ScheduleDataGridViewVisible;
            ChoosingNumOfMarchroutelabel.Visible = ChoosingNumOfMarchroutelabelVisible;
        }
        private void CompanyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PicChange.Stop();
            if (CompanyComboBox.SelectedItem.ToString() == "История")
            {
                //Controls.Cast<Control>().ToList().ForEach((ctrl) => ctrl.Visible == false);
                UpdateControlsVisibility(false, false, true, false, false, false, false, false, false);
            }
            if (CompanyComboBox.SelectedItem.ToString() == "Руководство")
            {
                //Controls.Cast<Control>().ToList().ForEach((ctrl) => ctrl.Visible = false);
                UpdateControlsVisibility(false, false, false, true, false, false, false, false, false);
            }
        }
        private void RouteScheduleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RouteScheduleComboBox.SelectedItem.ToString() == "расписание")
            {
                UpdateControlsVisibility(false, false, false, false, false, true, true, true, true);
            }
            if (RouteScheduleComboBox.SelectedItem.ToString() == "маршруты")
            {
                /*UpdateControlsVisibility(false, false, false, false, false, false, true);
                DataBase.openCon();
                DataTable table = DataBase.SelectRequestExecute("SELECT * FROM Points;");
                DataBase.closeCon();
                MarchrouteDataGridView.DataSource = table;*/
                this.Hide();
                Marchroutes card = new Marchroutes();
                card.ShowDialog();
                this.Show();
            }    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Gallery.SelectedIndex == Gallery.TabCount - 1)
                Gallery.SelectedIndex = 0;
            else
                Gallery.SelectedIndex++;
        }

        /*private void AddPictures()
        {
            PictureBox[] pictures = new PictureBox[3];
            pictures[0].Image = new Bitmap("FreeRoad.png");

        }*/
        private void ForumForm_Load(object sender, EventArgs e)
        {
            //AddPictures();
            PicChange.Start();
            UpdateControlsVisibility(true, false, false, false, false, false, false, false, false);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PicChange.Start();
            UpdateControlsVisibility(true, false, false, false, false, false, false, false, false);
        }

        private void PriceTicketButton_Click(object sender, EventArgs e)
        {
            PicChange.Stop();
            UpdateControlsVisibility(false, true, false, false, false, false, false, false, false);
        }
        private void ContactsButton_Click(object sender, EventArgs e)
        {
            PicChange.Stop();
            UpdateControlsVisibility(false, false, false, false, true, false, false, false, false);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.Hide();
            appeal form = new appeal();
            form.ShowDialog();
            this.Show();
        }

        private void ChoosingNumOfMarchrouteComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            ChoosingNumOfMarchrouteComboBox.Items.Clear();
            DataTable table = DataBase.SelectRequestExecute("SELECT RouteNumber FROM BRoute;");
            foreach (DataRow i in table.Rows)
            {
                ChoosingNumOfMarchrouteComboBox.Items.Add(i["RouteNumber"].ToString());
            }
        }

        private void ChoosingNumOfMarchrouteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = DataBase.SelectRequestExecute($"SELECT * FROM Schedule WHERE RouteNumber = {Convert.ToInt32(ChoosingNumOfMarchrouteComboBox.SelectedItem)};");
            ScheduleDataGridView.DataSource = table;
        }
    }
}
