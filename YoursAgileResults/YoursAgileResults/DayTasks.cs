using System;
using System.Collections.Generic;

namespace YoursAgileResults
{
    public  class DayTasks:Tasks    //задачи на день
    {
        public override void AddTasks()    //добавление задач в лист
        {
            var done = 1;
            Console.WriteLine("Введите ваши задачи на день:");
            while (done < 4)    //цикл проверки ввода не более 3 задач
            {
                Console.WriteLine($"Введите вашу {done} задачу:");
                string input = Console.ReadLine();
                monthTasks.Add(input);
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
            Console.WriteLine("Введите новую задачу на день");
            string task = Console.ReadLine();
            monthTasks.RemoveAt(index); //удаляем старое значение 
            monthTasks.Insert(index, task); //добавляем новое значение на место старого
            Program.Tasks();
        }

        public override void GetTasks()  //получение всех задач из листа, и вывод на экран
        {
            if (monthTasks.Count == 0)
            {
                Console.WriteLine("У вас нет задач на день!");
            }
            else

            {
                Console.WriteLine("Ваши задачи на день:");
                foreach (string task in monthTasks)
                {
                    Console.WriteLine(task);
                }
            }
        }
    }
}
