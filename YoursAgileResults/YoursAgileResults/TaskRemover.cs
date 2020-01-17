using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoursAgileResults
{
    class TaskRemover
    {
        public void DeleteTasks(List<string> tasks)
        {
            int index;
            while (true)
            {
                Console.WriteLine("Какую задачу вы хотите удалить (введите номер задачи):");
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
            tasks.RemoveAt(index); //удаляем значение
            tasks.Insert(index, "Задача отсутствует!");
            Program.Tasks();
        }
    }
}
