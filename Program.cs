using System;
using System.IO;
using Activity_Roulette.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User, Hi!");
            Roulette.CreateAppFolder();
            Roulette.CreateActivityList();
            Roulette.CreateHistoryLog();
            ActivityItemsList list = new ActivityItemsList();
            Dictionary<string, ActivityItem> items = list.GetActivityItemsContainer();
            foreach (KeyValuePair<string, ActivityItem> item in items)
                Console.WriteLine($"Activity name is {item.Key}, activity value is {item.Value.activityListItemWeight}");
            list.SetOverallActivityListWeight(items);
            float listsum = list.GetOverallActivityListWeight();
            Console.WriteLine(listsum); 
            // switch как меню для реализации разных действий на основе цифр и слов???
            // Запрос на добавление новых активностей
            while (true)
            {
                string userInput = Console.ReadLine();
                switch (userInput.ToLower())
                {
                    case "add new item":
                        Roulette.RequestNewActivityItem();
                        break;
                    /*case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    */
                    default:
                        Console.WriteLine("Do You to close the app? Yes/no");
                        if (Console.ReadLine().ToLower() == "yes")
                        {
                            Console.WriteLine("Byyyyyye!");
                            Console.ReadLine();
                            return;
                        }
                        else
                        {
                            continue;
                        }
                }
            }
        }
    }
}