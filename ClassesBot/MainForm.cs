using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassesBot.Resources;
using System.Net;
using System.Threading;
using System.Text.RegularExpressions;

namespace ClassesBot
{
    public partial class MainForm : Form
    {
        LoadingControl loadingControl = new LoadingControl();
        SettingsControl settingsControl = new SettingsControl();
        //StartForm startForm = new StartForm();

        PresetsSystem PresetsSystem = new PresetsSystem();
        UI UI = new UI();
        

        public MainForm()
        {
            InitializeComponent();

            UI.CreateUserControls(this);
            PresetsSystem.ReadConfig();

            UpdateForm(null, null);
            settingsControl.VisibleChanged += new EventHandler(UpdateForm);

            Text = $"ClBot - {Variables.group}";
        }


        void DownloadData()
        {
            Data GetData = new Data();

            // получение данных
            string membersIDs = GetData.MembersIDs();
            string classes = GetData.Classes();

            // заполнение текстовых полей
            this.Invoke(new Action(() =>
            {
                Members_Text.Text = membersIDs;
                Message_Text.Text = classes;
                Download_but.Enabled = true;
            }));

        }

        public void Send(Object MyData)
        {
            Random random = new Random();

            loadingControl.Invoke(new Action(() => loadingControl.Visible = true));

            string IDs = String.Join(",", MyData.ToString().Trim().Split('=')[0].Split('\n'));
            string MyMessage = MyData.ToString().Trim().Split('=')[1];

            using (WebClient webClient = new WebClient())
                webClient.DownloadString($"https://api.vk.com/method/messages.send?user_ids={IDs}&message={MyMessage}&random_id={random.Next(10000000)}&access_token={Variables.accessToken}&v=5.102");


            this.Invoke(new Action(() =>
            {
                Start_but.Enabled = true;
                loadingControl.Visible = false;
            }));
        }



        void UpdateForm(object sender, EventArgs e)
        {
            if (settingsControl.Visible == false)
            {
                Text = $"ClBot - {Variables.group}";

                if (Variables.accessToken != "" && Variables.group != "set the group in settings")
                {
                    Start_but.Visible = true;
                    Download_but.Visible = true;
                }
                else
                {
                    Start_but.Visible = false;
                    Download_but.Visible = false;
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            PresetsSystem.SaveConfig();
            e.Cancel = false;
        }


        #region Buttons
        public void Setting_Enter(object sender, EventArgs e)
        {
            Settings_Button.Image = Properties.Resources.Settings_Active;
        }
        public void Setting_Leave(object sender, EventArgs e)
        {
            Settings_Button.Image = Properties.Resources.Settings_Default;
        }
        private void Settings_Button_Click(object sender, EventArgs e)
        {
            settingsControl.Visible = true;
        }

        public void Start_Enter(object sender, EventArgs e)
        {
            Start_but.Image = Properties.Resources.Start_active;
        }
        public void Start_Leave(object sender, EventArgs e)
        {
            Start_but.Image = Properties.Resources.Start_default;
        }
        private void Start_but_Click(object sender, EventArgs e)
        {
            Start_but.Enabled = false;
            Thread sending = new Thread(new ParameterizedThreadStart(Send));
            sending.Start(Members_Text.Text + "=" + Message_Text.Text);
        }

        public void Download_Enter(object sender, EventArgs e)
        {
            Download_but.Image = Properties.Resources.DownloadData_Active;
        }
        public void Download_Leave(object sender, EventArgs e)
        {
            Download_but.Image = Properties.Resources.DownloadData_Default;
        }
        private void Download_but_Click(object sender, EventArgs e)
        {
            Download_but.Enabled = false;
            Thread downloading = new Thread(DownloadData);
            downloading.Start();
        }
        #endregion
    }
}
