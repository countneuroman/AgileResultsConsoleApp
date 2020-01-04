using System;
using System.Collections.Generic;

namespace YoursAgileResults
{
    public abstract class Tasks
    {
        public readonly List<string> allTasks = new List<string>();
        public abstract void AddTasks();   //добавление задач в лист
        public abstract void EditTasks(); //изменение задач
        public abstract void GetTasks();  //получение всех задач из листа, и вывод на экран

        public virtual void DeleteTasks()   //удаление задач
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
            allTasks.RemoveAt(index); //удаляем значение
            allTasks.Insert(index, "Задача отсутствует!");
            Program.Tasks();
        }

    }
}
