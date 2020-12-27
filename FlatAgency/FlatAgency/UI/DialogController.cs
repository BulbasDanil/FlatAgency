using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatAgency.UI
{
    class DialogController
    {

        public bool allowContinue()
        {
            Console.WriteLine("\n> Продолжаем? (Да/Нет)");
            string ans = Console.ReadLine();
            if (ans == "Да" || ans == "да")
                return true;
            else
                return false;
        }

        public void displayClient()
        {
            Console.WriteLine(" 1. Просмотреть книгу");
            Console.WriteLine(" 2. Просмотреть журнал");
            Console.WriteLine(" 3. Просмотреть брошюру");

            Console.WriteLine(" 4. Добавить книгу");
            Console.WriteLine(" 5. Добавить брошюру");
            Console.WriteLine(" 6. Добавить журнал");

            Console.WriteLine(" 0. Выход");
        }
    }
}
