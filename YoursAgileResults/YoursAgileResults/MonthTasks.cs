using System;
using System.Collections.Generic;

namespace YoursAgileResults
{
    public class MonthTasks : Tasks //задачи на месяц
    {
        public override void AddTasks()    //добавление задач в лист
        {
            var done = 1;
            Console.WriteLine("Введите ваши задачи на месяц:");
            while (done < 4)    //цикл проверки ввода не более 3 задач
            {
                Console.WriteLine($"Введите вашу {done} задачу:");
                string input = Console.ReadLine();
                allTasks.Add(input);
                done += 1;
            }
        }

        public override void EditTasks() //изменение задач
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
            Console.WriteLine("Введите новую задачу на месяц");
            string task = Console.ReadLine();
            allTasks.RemoveAt(index); //удаляем старое значение 
            allTasks.Insert(index, task); //добавляем новое значение на место старого
            Program.Tasks();
        }

        public override void GetTasks()  //получение всех задач из листа, и вывод на экран
        {
            if (allTasks.Count == 0)
            {
                Console.WriteLine("У вас нет задач на месяц!");
            }
            else

            {
                Console.WriteLine("Ваши задачи на месяц:");
                foreach (string task in allTasks)
                {
                    Console.WriteLine(task);
                }
            }
        }

        public override void DeleteTasks()
        {
            base.DeleteTasks();
        }
    }
}
