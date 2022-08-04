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
                Console.WriteLine("Please use following structure: Activity Name, Number" + "\n" +
                    "Where: Activity Name should not include a \",\" as is used to divide the activity name from a number" + "\n" +
                    "       Number is from 1 to 99 which will represent Your desire to do a particular task" + "\n" +
                    "For Example: Play Might and Magic 10, 65");
                Roulette.AddNewActivityItem();
            }
            else
            {
                return;
            }
            Console.ReadLine();
        }
    }
}