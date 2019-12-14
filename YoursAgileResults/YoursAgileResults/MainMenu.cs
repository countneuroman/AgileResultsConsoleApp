using System;

namespace YoursAgileResults
{
    public static class MainMenu
    {
        public static void mainMenu()
        {
            int input;
            Console.Clear();
            Console.WriteLine("Введите номер пункта меню для выбора.");
            Console.WriteLine("1)Просмотр моих задач");
            Console.WriteLine("2)Описание Agile results");
            Console.WriteLine("3)Выход из программы");
            while (true)
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    Program.Tasks();
                    break;
                }
                else if (input == 2)
                {
                    //нужно добавить описание Agile results в отдельном классе 
                    break;
                }
                else if (input == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильный номер меню!");
                }
            }
        }
    }
}
