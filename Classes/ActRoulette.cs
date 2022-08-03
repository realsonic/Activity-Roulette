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
        private static string filePath = AppFolder + @"\activitylist.txt";
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
            if (File.Exists(filePath))
            {
                return;
            }
            else
            {
                FileStream fileCreator = File.Create(filePath);
                // fileCreator.Close();
            }
        }
        public static void AddNewActivity()
        {
            while (true)
            {
                string userInput = Console.ReadLine();
                if (userInput.ToLower() != "exit")
                {
                    using (StreamWriter activityWriter = File.AppendText(filePath))
                    {
                        activityWriter.WriteLine(userInput);
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}