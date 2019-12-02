using ClassesBot.Resources;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBot
{
    class PresetsSystem
    {
        string MainPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\ClassesBot.cfg";

        public void ReadConfig()
        {
            if (!(File.Exists(MainPath)))
                File.WriteAllText(MainPath,
                                 $"%group={Variables.group}" +
                                 $"%groupID={Variables.vkgroupID}" +
                                 $"%accessToken={Variables.accessToken}" +
                                 $"%patternOutput={Variables.patternOutput}");
            else
            {
                string[] InputVariables = File.ReadAllText(MainPath).Split('%');

                foreach (string item in InputVariables)
                {
                    switch (item.Split('=')[0])
                    {
                        case "group":
                            Variables.group = item.Split('=')[1];
                            break;
                        case "faculty":
                            Variables.faculty = item.Split('=')[1];
                            break;
                        case "course":
                            Variables.course = item.Split('=')[1];
                            break;
                        case "groupID":
                            Variables.vkgroupID = item.Split('=')[1];
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
            }
        }

        public void SaveConfig()
        {
            File.WriteAllText(MainPath,
                              $"faculty={Variables.faculty}" +
                              $"%course={Variables.course}" +
                              $"%group={Variables.group}" +
                              $"%groupID={Variables.vkgroupID}" +
                              $"%accessToken={Variables.accessToken}" +
                              $"%patternOutput={Variables.patternOutput}");
        }

    }
}
