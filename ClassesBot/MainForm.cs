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
        SettingsControl settingsControl = new SettingsControl();
        LoadingControl loadingControl = new LoadingControl();


        string MainPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ClassesBot.cfg";
        string VkRequestPattern = "https://api.vk.com/method/";


        public MainForm()
        {
            InitializeComponent();

            settingsControl.VisibleChanged += new EventHandler(UpdateForm);

            #region Create Controls

            // Создание контрола настроек
            settingsControl.Location = new Point(0, 0);
            this.Controls.Add(settingsControl);
            settingsControl.Visible = false;
            settingsControl.BringToFront();

            // Создание контрола загрузки
            loadingControl.Location = new Point(0, 0);
            this.Controls.Add(loadingControl);
            loadingControl.Visible = false;
            loadingControl.BringToFront();

            #endregion

            #region Read config

            if (!(File.Exists(MainPath)))
                File.WriteAllText(MainPath, $"%group={Variables.group}%groupID={Variables.groupID}%accessToken={Variables.accessToken}%patternOutput={Variables.patternOutput}");

            string[] InputVariables = File.ReadAllText(MainPath).Split('%');

            foreach(string item in InputVariables)
            {
                switch (item.Split('=')[0])
                {
                    case "group":
                        Variables.group = item.Split('=')[1];
                        break;
                    case "groupID":
                        Variables.groupID = item.Split('=')[1];
                        break;
                    case "accessToken":
                        Variables.accessToken = item.Split('=')[1];
                        break;
                    case "patternOutput":
                        Variables.patternOutput = item.Split('=')[1];
                        break;
                    default:
                        break;
                }
            }
            #endregion

            UpdateForm(null, null);

            Text = $"ClBot - {Variables.group}";
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


        void DownloadData()
        {
            WebClient webclient = new WebClient();
            webclient.Encoding = Encoding.GetEncoding("windows-1251");

            // Получение ID участников группы
            Members_Text.Invoke(new Action(() => Members_Text.Text = ""));
            Message_Text.Invoke(new Action(() => Message_Text.Text = ""));

            string[] separator = { "[", "]" };
            string[] Members = (webclient.DownloadString($"{VkRequestPattern}groups.getMembers?group_id={Variables.groupID}&access_token={Variables.accessToken}&v=5.102")).Split(separator, StringSplitOptions.RemoveEmptyEntries)[1].Split(',');

            foreach (string item in Members)
            {
                Members_Text.Invoke(new Action(() => Members_Text.Text += item + "\n"));
            }



            string FinalMessage = "";

            
            //TODO GET KEY






            #region Get Classes

            string Pattern = string.Format(@"<td>({0})</td>{0}<td>({0})<b>({0})</b>{0}<small>({0})</small>{0}</td>{0}<td>({0})</td>{0}<td>({0})</td>", "[^<]*?");
            foreach (Match match in Regex.Matches(HtmlPage, Pattern))
                /*
                 * 0 - Номер пары
                 * 1 - Группа
                 * 2 - Предмет
                 * 3 - Тип занятия
                 * 4 - Преподаватель
                 * 5 - Кабинет
                 */
                FinalMessage += String.Format(Variables.patternOutput, match.Groups[1].Value, match.Groups[2].Value.ToLower(), match.Groups[3].Value.ToUpper(), match.Groups[4].Value, match.Groups[5].Value, match.Groups[6].Value);

            // Обозначение отсутствия пар
            if (FinalMessage.Trim() == "")
            {
                FinalMessage = @"¯\_(ツ)_/¯";
            }

            #endregion


            Download_but.Invoke(new Action(() => Download_but.Enabled = true));
        }

        void Send(Object MyData)
        {
            WebClient webclient = new WebClient();
            Random random = new Random();

            loadingControl.Invoke(new Action(() => loadingControl.Visible = true));

            string IDs = String.Join(",", MyData.ToString().Trim().Split('=')[0].Split('\n'));
            string MyMessage = MyData.ToString().Trim().Split('=')[1];

            string response = webclient.DownloadString($"{VkRequestPattern}messages.send?user_ids={IDs}&message={MyMessage}&random_id={random.Next(10000000)}&access_token={Variables.accessToken}&v=5.102");

            Start_but.Invoke(new Action(() => Start_but.Enabled = true));

            loadingControl.Invoke(new Action(() => loadingControl.Visible = false));
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

            File.WriteAllText(MainPath, $"group={Variables.group}%groupID={Variables.groupID}%accessToken={Variables.accessToken}%patternOutput={Variables.patternOutput}");

            e.Cancel = false;
        }
    }
}
