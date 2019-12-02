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
            {
                // Установка текущих значений в поля редактирования
                Group.Text = (Variables.group == "set the group in settings") ? "" : Variables.group;
                Faculty.Text = Variables.faculty;
                Course.Text = Variables.course;

                VKGroupID.Text = Variables.vkgroupID;
                Token.Text = Variables.accessToken;

                patternOutputText.Text = Variables.patternOutput;
                DateText.Text = Variables.Date;
            }
        }


        #region Buttons
        private void Back_Button_Click(object sender, EventArgs e)
        {
            // Сохранение новых значений
            Variables.group = (Group.Text == "") ? "set the group in settings" : Group.Text;
            Variables.faculty = Faculty.Text;
            Variables.course = Course.Text;

            Variables.vkgroupID = VKGroupID.Text;
            Variables.accessToken = (Token.Text == "") ? "" : Token.Text;

            Variables.patternOutput = patternOutputText.Text;
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

        private void Link_Click(object sender, EventArgs e)
        {
            if ((sender as Label).Text == "www.mstu.edu.ru")
                Process.Start((sender as Label).Text);
            else
                Process.Start("https://" + (sender as Label).Text);
        }

        #endregion
    }
}
