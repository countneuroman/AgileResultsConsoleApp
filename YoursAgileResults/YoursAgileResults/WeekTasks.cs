using System;
using System.Collections.Generic;

namespace YoursAgileResults
{
    public  class WeekTasks:ITask    //задачи на неделю
    {
        List<string> Tasks = new List<string>();
        TaskAdder adder = new TaskAdder();
        TaskEditor editor = new TaskEditor();
        TaskGetter getter = new TaskGetter();
        TaskRemover remover = new TaskRemover();

        public void AddTasks()
        {
            adder.AddTasks("Введите ваши задачи на неделю:", Tasks);
        }

        public void GetTasks()
        {
            getter.GetTasks("неделю", Tasks);
        }

        public void EditTasks()
        {
            editor.EditTasks("Введите ваши задачи на неделю:", Tasks);
        }

        public void DeleteTasks()
        {
            remover.DeleteTasks(Tasks);
        }
    }
}
