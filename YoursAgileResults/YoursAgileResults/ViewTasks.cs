using System;

namespace YoursAgileResults
{
    public static class ViewTasks   //класс для просмотра задач
    {
        public static void viewTasks()
        {
            MonthTasks.GetTasks();
            WeekTasks.GetTasks();
            DayTasks.GetTasks();
        }
    }
}
