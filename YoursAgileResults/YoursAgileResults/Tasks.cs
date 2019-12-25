using System;
using System.Collections.Generic;

namespace YoursAgileResults
{
    public abstract class Tasks
    {
        public readonly List<string> monthTasks = new List<string>();
        public abstract void AddTasks();   //добавление задач в лист
        public abstract void EditTasks(); //изменение задач

        public abstract void GetTasks();  //получение всех задач из листа, и вывод на экран
    }
}
