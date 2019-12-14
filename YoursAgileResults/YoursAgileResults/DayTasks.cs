using System;
using System.Collections.Generic;

namespace YoursAgileResults
{
    public static class DayTasks    //задачи на день
    {
        private static List<string> dayTasks = new List<string>();
        public static void AddTasks()    //добавление задач в лист
        {
            var done = 0;
            Console.WriteLine("Введите ваши задачи на день.");
            while (done < 3)    //цикл проверки ввода не более 3 задач
            {
                Console.WriteLine("Введите вашу задачу или q для выхода:");
                string input = Console.ReadLine();
                if (input == "q")    //условие для выхода из программы
                {
                    break;
                }
                else
                {
                    dayTasks.Add(input);
                    done += 1;
                    continue;
                }

            }
        }

        public static void EditTasks() //изменение задач
        {
            int index;
            while (true)
            {
                Console.WriteLine("Какую задачу вы хотите изменить (введите номер задачи):");
                index = Convert.ToInt32(Console.ReadLine()) - 1; //уменьшаем значение на единицу, т.к. перечисление элементов начинается с 0 
                if (index == 0 | index == 1 | index == 2)    //проверка соответствия номеру задачи
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильный номер задачи!");
                }
            }
            Console.WriteLine("Введите новую задачу");
            string task = Console.ReadLine();
            dayTasks.RemoveAt(index); //удаляем старое значение 
            dayTasks.Insert(index, task); //добавляем новое значение на место старого
            Program.Tasks();
        }

        public static void GetTasks()  //получение всех задач из листа, и вывод на экран
        {
            if (dayTasks.Count == 0)
            {
                Console.WriteLine("У вас нет задач на день!");
            }
            else

            {
                Console.WriteLine("Ваши задачи на день:");
                foreach (string task in dayTasks)
                {
                    Console.WriteLine(task);
                }
            }
        }
    }
}
