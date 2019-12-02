using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassesBot.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace ClassesBot
{
    class UI
    {        
        public void CreateUserControls(MainForm mainForm)
        {
            LoadingControl loadingControl = new LoadingControl();
            SettingsControl settingsControl = new SettingsControl();
            StartForm startForm = new StartForm();

            // Создание контрола загрузки
            loadingControl.Location = new Point(0, 0);
            mainForm.Controls.Add(loadingControl);
            loadingControl.Visible = false;
            loadingControl.BringToFront();

            // Создание контрола настроек
            settingsControl.Location = new Point(0, 0);
            mainForm.Controls.Add(settingsControl);
            settingsControl.Visible = false;
            settingsControl.BringToFront();

            // Создание контрола стартовой формы
            startForm.Location = new Point(0, 0);
            //mainForm.Controls.Add(startForm);
            startForm.BringToFront();
        }


    }
}
