using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace sandboxapp
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime firstDay = new DateTime(2019, 1, 1);
            DateTime today = DateTime.Today;
            int totalDays = (today - firstDay).Days;
            List<Week> weeks = new List<Week>();
            int weekID = 1;
            for (int i = 0; i < totalDays + 7; i++)
            {
                {
                    DateTime date = firstDay.AddDays(i);
                    if (date.DayOfWeek == DayOfWeek.Sunday)
                    {
                        weeks.Add(new Week(weekID, date.AddDays(-6)));
                        weekID++;
                    }
                }
            }

            foreach(Week week in weeks)
            {
                Console.WriteLine(String.Format("{0} : {1}", week.WeekID, week.FirstDayOfWeek));

            }

        }


        public class Week
        {
            public Week(int weekId, DateTime firstDayOfWeek)
            {
                this.WeekID = weekId;
                this.FirstDayOfWeek = firstDayOfWeek;
            }
            public int WeekID { get; set; }
            public DateTime FirstDayOfWeek { get; set; }
        }
    }
}
