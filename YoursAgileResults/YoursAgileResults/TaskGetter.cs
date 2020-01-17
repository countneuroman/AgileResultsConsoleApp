using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoursAgileResults
{
    class TaskGetter
    {
        public void GetTasks(string message, List<string> tasks)
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine($"У вас нет задач на {message}!");
            }
            else

            {
                Console.WriteLine($"Ваши задачи на {message}:");
                foreach (string task in tasks)
                {
                    Console.WriteLine(task);
                }
            }
        }
    }
}
