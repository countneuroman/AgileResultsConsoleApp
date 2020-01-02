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

            MainMenu.Menu();    //выходим в главное меню
        }
        static public void Tasks()  //меню работы с задачами
        {
            int input;
            Console.Clear();
            ViewTasks();

            while (true)
            {
                Console.WriteLine("Введите 1 что бы изменить задачи, введите 2 что бы удалить задачи, введите 3 что бы выйти в главное меню");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    EditTasks();
                    break;
                }
                else if (input == 2)
                {
                    DeleteTasks();
                    break;
                }
                else if (input == 3)
                {
                    MainMenu.Menu();
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильные данные!");
                }
            }
        }
        public static void EditTasks()
        {
            ViewTasks();
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
                    MainMenu.Menu();
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели неправильные данные!");
                }
            }
        }


        public static void ViewTasks()
        {
            monthtasks.GetTasks();
            weektasks.GetTasks();
            daytasks.GetTasks();
        }

        public static void DeleteTasks()
        {
            ViewTasks();
            int input;
            while (true)
            {
                Console.WriteLine("Введите 1 что бы удалить задачи на месяц, введите 2 что удалить задачи на неделю введите 3 что бы удалить задачи на день. Введите 4 что бы выйти в главное меню");
                input = Convert.ToInt32(Console.ReadLine());
                if (input == 1)
                {
                    monthtasks.DeleteTasks();
                    break;
                }
                else if (input == 2)
                {
                    weektasks.DeleteTasks();
                    break;
                }
                else if (input == 3)
                {
                    daytasks.DeleteTasks();
                    break;
                }
                else if (input == 4)
                {
                    MainMenu.Menu();
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
