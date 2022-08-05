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
        private static readonly string AppFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Activity Roulette";
        // Файл активностей
        public static readonly string activityListPath = AppFolder + @"\activitylist.txt";
        // Файл истории
        private static readonly string historyLogPath = AppFolder + @"\historylog.txt";
        // Контейнер текущих активностей
        private static Dictionary<string, ActivityItem> activityItemsContainer;
        // Общий вес файла активностей
        private static int overallActivityListWeight;
        // Общий размер файла истории
        private static int historyLogSize;

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
            string number = userInput.Substring(userInput.IndexOf(',') + 1).Trim();
            bool isConvertable = Int32.TryParse(number, out int result);
            if (isConvertable == true && result <= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void SetActivityItemsContainer()
        {
            Dictionary<string, ActivityItem> Container = new Dictionary<string, ActivityItem>();
            foreach (string line in File.ReadLines(activityListPath))
            {
                ActivityItem activity = new ActivityItem(line);
                Container.Add(activity.name, activity);
            }
            activityItemsContainer = Container;
        }
        public static Dictionary<string, ActivityItem> GetActivityItemsContainer()
        {

            return activityItemsContainer;
        }
        public static void WriteHistoryLogLine()
        {

        }
        public static void SetHistoryLogSize()
        {
            historyLogSize = File.ReadLines(historyLogPath).Count();
        }
        public static int GetHistoryLogSize()
        {
            return historyLogSize;
        } 
        public static void SetOverallActivityListWeight(Dictionary<string, ActivityItem> Container)
        {
            int sum = 0;
            foreach (KeyValuePair<string, ActivityItem> activity in Container)
            {
                sum += activity.Value.activityListItemWeight;
            }
            overallActivityListWeight = sum;
        }
        public static int GetOverallActivityListWeight()
        {
            return overallActivityListWeight;
        }
        /* Что-то на будущее :D
           Метод для определения повторов
         public static bool ValidateNewActivityItemNumber(string userInput)
        { 
        
        }

           Метод для изменения активности
         public static string ChangeActivityItem()
        {

        }
        
           Метод для удаления активности
         public static string DeleteActivityItem()
        {

        }*/
    }
}