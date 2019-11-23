using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesBot.Resources
{
    public static class Variables
    {
        // mstu
        public static string group = "set the group in settings";
        public static string faculty = "";
        public static string course = "";

        // vk
        public static string vkgroupID = "0";
        public static string accessToken = "";

        // program
        public static string patternOutput = "{0}\n ->{2}<-\n{1} << {5} >>\n{3} {4}\n\n";
        public static string Date = DateTime.Now.AddDays(1).ToString("yyyy-M-d");
    }
}
