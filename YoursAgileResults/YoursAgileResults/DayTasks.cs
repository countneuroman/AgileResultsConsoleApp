using System;
using System.Collections.Generic;

namespace YoursAgileResults
{
    public  class DayTasks:ITask    //задачи на день
    {
        List<string> Tasks = new List<string>();
        TaskAdder adder = new TaskAdder();
        TaskEditor editor = new TaskEditor();
        TaskGetter getter = new TaskGetter();
        TaskRemover remover = new TaskRemover();

        public void AddTasks()
        {
            adder.AddTasks("Введите ваши задачи на день:", Tasks);
        }

        public void GetTasks()
        {
            getter.GetTasks("день", Tasks);
        }

        public void EditTasks()
        {
            editor.EditTasks("Введите ваши задачи на день:", Tasks);
        }

        public void DeleteTasks()
        {
            remover.DeleteTasks(Tasks);
        }
    }
}
