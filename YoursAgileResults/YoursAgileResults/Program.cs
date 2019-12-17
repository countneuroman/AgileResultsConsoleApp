using System;

namespace YoursAgileResults
{
    class Program
    {
        public static MonthTasks monthtasks = new MonthTasks();
        public static WeekTasks weektasks = new WeekTasks();
        public static DayTasks daytasks = new DayTasks();
        static void Main()
        {
            Console.Title = "YorAgileResults";
            //добавляем задачи при первом запуске программы
            //нужно добавить проверку на первый запуск программы
            monthtasks.AddTasks();
            weektasks.AddTasks();
            daytasks.AddTasks();

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
                    editTasks();
                    break;
                }
                else if (input == 2)
                {
                    deleteTasks();//удаление задач еще не реализовано
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
        public static void editTasks()
        {
            ViewTasks.viewTasks();
            int input;
            while (true)
            {
                Console.WriteLine("Введите 1 что бы изменить задачи на месяц, введите 2 что изменить задачи на неделю введите 3 что бы изменить задачи на день. Введите 4 что бы выйти в главное меню");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    monthtasks.EditTasks();
                    break;
                }
                else if (input == 2)
                {
                    weektasks.EditTasks();
                    break;
                }
                else if (input == 3)
                {
                    daytasks.EditTasks();
                    break;
                }
                else if (input == 4)
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

        public static class ViewTasks   //класс для просмотра задач
        {
            public static void viewTasks()
            {
                monthtasks.GetTasks();
                weektasks.GetTasks();
                daytasks.GetTasks();
            }
        }

        public static void deleteTasks()
        {
                //нужо реализовать удаление задач
        }

    }
}
