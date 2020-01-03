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
            InitializeTabs();
        }


        #region CustomTabControl
        // panels
        Tabs_mstu mstu = new Tabs_mstu();
        Tabs_vk vk = new Tabs_vk();
        Tabs_format format = new Tabs_format();

        Button CurrentTab;

        public void InitializeTabs()
        {
            mstu.Location = new Point(1, 1);
            CustomTabControl.Controls.Add(mstu);

            vk.Location = new Point(1, 1);
            CustomTabControl.Controls.Add(vk);

            format.Location = new Point(1, 1);
            CustomTabControl.Controls.Add(format);

            CurrentTab = MstuTab;
            Transform(CurrentTab);
        }


        // helpful functions
        private void DisableAll()
        {
            // reset color
            (CurrentTab as Button).BackColor = Color.FromArgb(255, 201, 201, 201);

            // reset transform
            CurrentTab.Height = CurrentTab.Height - 2;
            CurrentTab.Width = CurrentTab.Width - 4;
            CurrentTab.Location = new Point(CurrentTab.Location.X + 2, CurrentTab.Location.Y + 2);
        }
        private void Transform(object sender)
        {
            CurrentTab = (sender as Button);
            CurrentTab.BringToFront();
            CurrentTab.Height = CurrentTab.Height + 2;
            CurrentTab.Width = CurrentTab.Width + 4;
            CurrentTab.Location = new Point(CurrentTab.Location.X - 2, CurrentTab.Location.Y - 2);
        }


        // tab click
        private void MstuTab_Click(object sender, EventArgs e)
        {
            DisableAll();
            MstuTab.BackColor = Color.FromArgb(255, 123, 165, 240);
            mstu.BringToFront();

            Transform(sender);
        }
        private void VkTab_Click(object sender, EventArgs e)
        {
            DisableAll();
            VkTab.BackColor = Color.FromArgb(255, 123, 165, 240);
            vk.BringToFront();

            Transform(sender);
        }
        private void FormatTab_Click(object sender, EventArgs e)
        {
            DisableAll();
            FormatTab.BackColor = Color.FromArgb(255, 123, 165, 240);
            format.BringToFront();

            Transform(sender);
        }
        #endregion


        void UpdateForm(object sender, EventArgs e)
        {
            if (Visible == true)
            {
                // Установка текущих значений в поля редактирования
                mstu.Group.Text = (Variables.group == "set the group in settings") ? "" : Variables.group;
                mstu.Faculty.Text = Variables.faculty;
                mstu.Course.Text = Variables.course;

                vk.VKGroupID.Text = Variables.vkgroupID;
                vk.Token.Text = Variables.accessToken;

                format.patternOutputText.Text = Variables.patternOutput;
                format.DateText.Text = Variables.Date;
            }
        }


        #region Buttons
        private void Back_Button_Click(object sender, EventArgs e)
        {
            // Сохранение новых значений
            Variables.group = (mstu.Group.Text == "") ? "set the group in settings" : mstu.Group.Text;
            Variables.faculty = mstu.Faculty.Text;
            Variables.course = mstu.Course.Text;

            Variables.vkgroupID = vk.VKGroupID.Text;
            Variables.accessToken = (vk.Token.Text == "") ? "" : vk.Token.Text;

            Variables.patternOutput = format.patternOutputText.Text;
            Variables.Date = format.DateText.Text;

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
