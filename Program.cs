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
            // switch как меню для реализации разных действий?
            // Запрос на добавление новых активностей
            Console.WriteLine("Do You want to add new activities in the File? Yes/No");
            string userAnswer = Console.ReadLine();
            if (userAnswer.ToLower() == "yes")
            {
                Console.WriteLine("Please use following structure: Activity Name, Number (1 - 99 which will represent Your desire to perform the input activity).");
                Roulette.AddNewActivity();
            }
            else
            {
                return;
            }
            Console.ReadLine();
        }
    }
}