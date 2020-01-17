using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoursAgileResults
{
    class TaskAdder
    {
        public void AddTasks(string message, List<string> tasks)
        {
            var done = 1;
            Console.WriteLine(message);
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
                    tasks.Add(input);
                    done += 1;
                }
            }
        }
    }
}
