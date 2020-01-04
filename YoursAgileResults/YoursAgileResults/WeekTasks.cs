using System;
using System.Collections.Generic;

namespace YoursAgileResults
{
    public  class WeekTasks:Tasks    //задачи на неделю
    {
        public override void AddTasks()    //добавление задач в лист
        {
            var done = 1;
            Console.WriteLine("Введите ваши задачи на неделю:");
            while (done < 4)    //цикл проверки ввода не более 3 задач
            {
                Console.WriteLine($"Введите вашу {done} задачу:");
                string input = Console.ReadLine();
                input = input.Trim();   //удаляем начальные и конечные пробелы для проверки на ввод пустой строки
                if (input == string.Empty)  //проверка на ввод пустой строки
                {
                    Console.WriteLine("Вы не ввели задачу!");
                }
                else
                {
                    allTasks.Add(input);
                    done += 1;
                }
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
            while (true)
            {
                Console.WriteLine("Введите новую задачу на день");
                string task = Console.ReadLine();
                task = task.Trim();
                if (task == string.Empty)
                {
                    Console.WriteLine("Вы не ввели задачу!");
                }
                else
                {
                    allTasks.RemoveAt(index); //удаляем старое значение 
                    allTasks.Insert(index, task); //добавляем новое значение на место старого
                    break;
                }
            }
            Program.Tasks();
        }

        public override void GetTasks()  //получение всех задач из листа, и вывод на экран
        {
            if (allTasks.Count == 0)
            {
                Console.WriteLine("У вас нет задач на неделю!");
            }
            else

            {
                Console.WriteLine("Ваши задачи на неделю:");
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
