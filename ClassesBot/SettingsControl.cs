using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using ClassesBot.Resources;

namespace ClassesBot
{
    public partial class SettingsControl : UserControl
    {
        public SettingsControl()
        {
            InitializeComponent();
        }

        void UpdateForm(object sender, EventArgs e)
        {
            if (Visible == true)
            {hh
                // Установка текущих значений в поля редактирования
                VKGroupText.Text = Variables.groupID;
                patternOutputText.Text = Variables.patternOutput;
                GroupText.Text = (Variables.group == "set the group in settings") ? "" : Variables.group;
                TokenText.Text = Variables.accessToken;

                DateText.Text = Variables.Date;
            }
        }


        #region Buttons
        private void Back_Button_Click(object sender, EventArgs e)
        {
            // Сохранение новых значений
            Variables.groupID = VKGroupText.Text;
            Variables.patternOutput = patternOutputText.Text;
            Variables.group = (GroupText.Text == "") ? "set the group in settings" : GroupText.Text;
            Variables.accessToken = (TokenText.Text == "") ? "" : TokenText.Text;

            Variables.Date = DateText.Text;

            Visible = false;
        }
        private void Back_Button_Enter(object sender, EventArgs e)
        {
            Back_Button.Image = Properties.Resources.Back_Active;
        }
        private void Back_Button_Leave(object sender, EventArgs e)
        {
            Back_Button.Image = Properties.Resources.Back_Default;
        }

        private void MSTULink_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.mstu.edu.ru");
        }
        private void CreatorLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://vk.com/danyanet");
        }

        //private void LinkClick(object sender, EventArgs e)
        //{
        //    Process.Start((sender as Label).Text);
        //}

        #endregion
    }
}
