﻿using System;

namespace YoursAgileResults
{
    public static class MainMenu
    {
        public static void Menu()
        {
            int input;
            Console.Clear();
            Console.WriteLine("Введите номер пункта меню для выбора.");
            Console.WriteLine("1)Просмотр моих задач");
            Console.WriteLine("2)Описание Agile results");
            Console.WriteLine("3)Выход из программы");
            while (true)
            {
                try
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
                        System.Environment.Exit(0); //закрытие программы
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели неправильный номер меню!");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Нажмите любую клавишу для возврата в главное меню...");
                    Console.ReadKey();
                    MainMenu.Menu();
                }
            }
        }
    }
}
