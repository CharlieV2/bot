using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ClassesBot
{
    public partial class StartForm : UserControl
    {
        string MainPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ClassesBot");
        int presetsCount = 0;

        public StartForm()
        {
            InitializeComponent();

            if (!(Directory.Exists(MainPath)))
                Directory.CreateDirectory(MainPath);

            presetsCount = Directory.GetFiles(MainPath).Length;

            if (presetsCount == 0)
            {
                // заглушка при отсутствии пресетов
                Panel infoZeroPanel = new Panel();
                infoZeroPanel.Width = 280;
                infoZeroPanel.Height = 40;
                infoZeroPanel.BackColor = Color.FromArgb(106, 138, 232);
                infoZeroPanel.BorderStyle = BorderStyle.FixedSingle;
                PresetsList.Controls.Add(infoZeroPanel);

                Label infoZeroLabel = new Label();
                infoZeroLabel.Width = 280;
                infoZeroLabel.Height = 40;
                infoZeroLabel.ForeColor = Color.White;
                infoZeroLabel.Cursor = Cursors.Hand;
                infoZeroLabel.Text = "No presets. Create now!";
                infoZeroLabel.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                infoZeroLabel.TextAlign = ContentAlignment.MiddleCenter;
                infoZeroLabel.Location = new Point(0, 0);
                infoZeroPanel.Controls.Add(infoZeroLabel);
                infoZeroLabel.Click += new EventHandler(NewPreset_Click);
            }
            else CreatePresetsList();


        }


        void CreatePresetsList()
        {
            string[] presetsList = Directory.GetFiles(MainPath);

            foreach (string item in presetsList)
            {
                CreatePresetPanel(item);
            }
        }

        void CreatePresetPanel(string item)
        {
            Panel presetPanel = new Panel();
            presetPanel.Width = 280;
            presetPanel.Height = 40;
            presetPanel.BackColor = Color.FromArgb(106, 138, 232);
            presetPanel.BorderStyle = BorderStyle.FixedSingle;



            Label presetName = new Label();
            presetName.Width = 200;
            presetName.Height = 40;
            presetName.Text = Path.GetFileNameWithoutExtension(item);
            presetName.ForeColor = Color.White;
            presetName.Cursor = Cursors.Hand;
            presetName.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            presetName.Location = new Point(0, 0);

            presetName.MouseEnter += new EventHandler(Colorized);
            presetName.MouseLeave += new EventHandler(Uncolorized);




            PictureBox presetCheckBox = new PictureBox();
            presetCheckBox.Width = 16;
            presetCheckBox.Height = 16;
            presetCheckBox.SizeMode = PictureBoxSizeMode.Zoom;
            presetCheckBox.Image = Properties.Resources.check_on;
            presetCheckBox.Cursor = Cursors.Hand;
            presetCheckBox.Location = new Point(202, 12);

            presetCheckBox.Click += new EventHandler(CheckBoxSwitch);



            PictureBox presetEdit = new PictureBox();
            presetEdit.Width = 21;
            presetEdit.Height = 21;
            presetEdit.SizeMode = PictureBoxSizeMode.Zoom;
            presetEdit.Image = Properties.Resources.edit_30;
            presetEdit.Location = new Point(226, 10);
            presetEdit.Cursor = Cursors.Hand;

            presetEdit.MouseEnter += new EventHandler(Edit_Enter);
            presetEdit.MouseLeave += new EventHandler(Edit_Leave);



            PictureBox presetDelete = new PictureBox();
            presetDelete.Width = 24;
            presetDelete.Height = 24;
            presetDelete.SizeMode = PictureBoxSizeMode.Zoom;
            presetDelete.Image = Properties.Resources.del_default;
            presetDelete.Location = new Point(250, 8);
            presetDelete.Cursor = Cursors.Hand;

            presetDelete.MouseEnter += new EventHandler(Delete_Enter);
            presetDelete.MouseLeave += new EventHandler(Delete_Leave);



            void Colorized(object sender, EventArgs e) => presetPanel.BackColor = Color.FromArgb(58, 94, 202);
            void Uncolorized(object sender, EventArgs e) => presetPanel.BackColor = Color.FromArgb(106, 138, 232);

            void Edit_Enter(object sender, EventArgs e) => presetEdit.Image = Properties.Resources.edit_30_active;
            void Edit_Leave(object sender, EventArgs e) => presetEdit.Image = Properties.Resources.edit_30;

            void Delete_Enter(object sender, EventArgs e) => presetDelete.Image = Properties.Resources.del_active;
            void Delete_Leave(object sender, EventArgs e) => presetDelete.Image = Properties.Resources.del_default;

            void CheckBoxSwitch (object sender, EventArgs e)
            {
                if ((sender as PictureBox).Image == new Bitmap(Properties.Resources.check_on))
                    label1.Text = "yes";


                //label1.Text = (sender as PictureBox).Image.ToString();
                //label2.Text = Properties.Resources.check_on.ToString();
            }




            PresetsList.Controls.Add(presetPanel);
            presetPanel.Controls.Add(presetDelete);
            presetPanel.Controls.Add(presetCheckBox);
            presetPanel.Controls.Add(presetEdit);
            presetPanel.Controls.Add(presetName);

        }

        private void Link_Click(object sender, EventArgs e)
        {
            if ((sender as Label).Text == "www.mstu.edu.ru")
                Process.Start((sender as Label).Text);
            else
                Process.Start("https://" + (sender as Label).Text);
        }

        private void NewPreset_Click(object sender, EventArgs e)
        {
            // todo 
        }
    }
}
