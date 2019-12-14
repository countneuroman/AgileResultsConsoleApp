using System;

namespace YoursAgileResults
{
    public static class EditTasks   //класс для изменения задач
    {
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
                    MonthTasks.EditTasks();
                    break;
                }
                else if (input == 2)
                {
                    WeekTasks.EditTasks();
                    break;
                }
                else if (input == 3)
                {
                    DayTasks.EditTasks();
                    break;
                }
                else if (input==4)
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
