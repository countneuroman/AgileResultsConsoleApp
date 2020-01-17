using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoursAgileResults
{
    class TaskEditor
    {
        public void EditTasks(string message, List<string> tasks)
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
                Console.WriteLine(message);
                string task = Console.ReadLine();
                task = task.Trim();
                if (task == string.Empty)
                {
                    Console.WriteLine("Вы не ввели задачу!");
                }
                else
                {
                    tasks.RemoveAt(index); //удаляем старое значение 
                    tasks.Insert(index, task); //добавляем новое значение на место старого
                    break;
                }
            }
            Program.Tasks();
        }
    }
}
