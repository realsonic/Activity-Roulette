using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_Roulette.Classes
{
    class Roulette
    {
        // Папка приложения
        private static string AppFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Activity Roulette";
        // Файл активностей
        public static readonly string activityListPath = AppFolder + @"\activitylist.txt";
        // Файл истории логов
        private static string historyLogPath = AppFolder + @"\historylog.txt";
        public static void CreateAppFolder()
        {
            if (Directory.Exists(AppFolder))
            {
                return;
            }
            else
            {
                Directory.CreateDirectory(AppFolder);
            }
        }
        public static void CreateActivityList()
        {
            if (File.Exists(activityListPath))
            {
                return;
            }
            else
            {
                FileStream fileCreator = File.Create(activityListPath);
                fileCreator.Close();
            }
        }
        public static void CreateHistoryLog()
        {
            if (File.Exists(historyLogPath))
            {
                return;
            }
            else
            {
                FileStream fileCreator = File.Create(historyLogPath);
                fileCreator.Close();
            }
        }
        public static void AddNewActivityItem()
        {
            Console.WriteLine("Type \"exit\" to go back.");
            while (true)
            {
                string userInput = Console.ReadLine();
                using (StreamWriter activityWriter = File.AppendText(activityListPath))
                {
                    if (userInput.ToLower() != "exit")
                    {
                        if (ValidateNewActivityItemString(userInput) == true && ValidateNewActivityItemNumber(userInput) == true)
                        {
                            activityWriter.WriteLine(userInput);
                            continue;
                        }
                        else
                        {
                            Console.WriteLine("Please follow the template: \"Activity Name, Number\"");
                            continue;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        public static bool ValidateNewActivityItemString(string userInput)
        {
            if (userInput.Count(c => c == ',') == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ValidateNewActivityItemNumber(string userInput)
        {
            char symbol = ',';
            int startIndex = userInput.IndexOf(symbol) + 1;
            string number = userInput.Substring(startIndex).Trim();
            bool isConveratble = Int32.TryParse(number, out int result);
            if (isConveratble == true && result <= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /* Что-то на будущее :D
         * Метод для определения повторов
         * public static bool ValidateNewActivityItemNumber(string userInput)
        { 
        
        }
           Метод для изменения активности
         * public static string ChangeActivityItem()
        {

        }*/

        /* Метод для удаления активности
         * public static string DeleteActivityItem()
        {

        }*/
    }
}