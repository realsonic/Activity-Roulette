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
            Roulette.AddNewActivity();
            /* Запрос на добавление новых активностей
            if (userAnswer)
            {
                Roulette.AddNewActivity()
            }
            else
            {
                return;
            }*/
            Console.ReadLine();
        }
    }
}