using System;

namespace YoursAgileResults
{
    class Program
    {
        static void Main()
        {
            Console.Title = "YorAgileResults";
            //добавляем задачи при первом запуске программы
            //нужно добавить проверку на первый запуск программы
            MonthTasks.AddTasks();
            WeekTasks.AddTasks();
            DayTasks.AddTasks();

            MainMenu.mainMenu();    //выходим в главное меню
        }
        static public void Tasks()  //меню работы с задачами
        {
            int input;
            Console.Clear();

            ViewTasks.viewTasks();

            while (true)
            {
                Console.WriteLine("Введите 1 что бы изменить задачи, введите 2 что бы удалить задачи, введите 3 что бы выйти в главное меню");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    EditTasks.editTasks();
                    break;
                }
                else if (input == 2)
                {
                    DeleteTasks.deleteTasks();//удаление задач еще не реализовано
                    break;
                }
                else if (input == 3)
                {
                    MainMenu.mainMenu();
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильные данные!");
                }
            }
        }
    }
}
