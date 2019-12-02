using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ClassesBot.Resources;

namespace ClassesBot
{
    class Data
    {
        WebClient webClient = new WebClient();

        public string MembersIDs()
        {
            string result = "";

            string[] separator = { "[", "]" };
            string[] Members = (webClient.DownloadString($"https://api.vk.com/method/groups.getMembers?group_id={Variables.vkgroupID}&access_token={Variables.accessToken}&v=5.102")).Split(separator, StringSplitOptions.RemoveEmptyEntries)[1].Split(',');

            foreach (string item in Members)
            {
                result += item + "\n";
            }

            return result;
        }

        public string Classes()
        {
            string FinalMessage = "";
            string HtmlPage = webClient.DownloadString(String.Format(@"http://www.mstu.edu.ru/study/timetable/schedule.php?key={0}&perstart={1}&perend={1}&perkind=%F7", Key(), Variables.Date));

            string pattern = String.Format(@"<td>({0})</td>{0}<td>({0})<b>({0})</b>{0}<small>({0})</small>{0}</td>{0}<td>({0})</td>{0}<td>({0})</td>", "[^<]*?");
            foreach (Match match in Regex.Matches(HtmlPage, pattern))
                /*
                 * 0 - Номер пары
                 * 1 - Группа
                 * 2 - Предмет
                 * 3 - Тип занятия
                 * 4 - Преподаватель
                 * 5 - Кабинет
                 */
                FinalMessage += String.Format(Variables.patternOutput,
                                              match.Groups[1].Value,
                                              match.Groups[2].Value.ToLower(),
                                              match.Groups[3].Value.ToUpper(),
                                              match.Groups[4].Value,
                                              match.Groups[5].Value,
                                              match.Groups[6].Value);

            // Обозначение отсутствия пар
            if (FinalMessage.Trim() == "")
            {
                FinalMessage = @"¯\_(ツ)_/¯";
            }

            return FinalMessage;
        }

        public string Key()
        {
            string key = "";

            string pattern = string.Format(@"<{0}key=({0})&perstart={0}>{1}</a>", "[^<]*?", Variables.group.ToLower());

            key = Regex.Match(SceduleTable(), pattern).Groups[1].Value;

            // для просмотра найденой строки по паттерну
            //string key = Regex.Match(tableResponse, pattern).Value;

            //File.WriteAllText(@"C:\Users\Admin\Desktop\outputFinal.eye", key);

            return key;
        }

        public string SceduleTable()
        {
            string url = "http://www.mstu.edu.ru/study/timetable/";
            string tableResponse = "";
            string numInstitute = "";

            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";

            switch (Variables.faculty.ToLower())
            {
                case "иат":
                    numInstitute = "1";
                    break;
                case "ети":
                    numInstitute = "2";
                    break;
                case "има":
                    numInstitute = "3";
                    break;
                default:
                    break;
            }

            string data = $"mode=1&facs={numInstitute}&courses={Variables.course}";
            byte[] byteArray = Encoding.GetEncoding("windows-1251").GetBytes(data);

            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;

            using (Stream dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }

            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.GetEncoding("windows-1251")))
                {
                    tableResponse = reader.ReadToEnd().ToLower();
                    //File.WriteAllText(@"C:\Users\Admin\Desktop\out.eye", tableResponse);
                }
            }
            response.Close();

            return tableResponse;
        }
    }
}
