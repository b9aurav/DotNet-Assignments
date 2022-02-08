using System;
using Indexers;

namespace MainProgram {
    class Program {
        public static void Main(string[] args) {
            //example-1 
            var tempRecord = new TempRecord();
            tempRecord[3] = 58.3F;
            tempRecord[5] = 60.1F;

            for (int i = 0; i < 10; i++) {
                Console.WriteLine($"Element #{i} = {tempRecord[i]}");
            }

            //example-2
            var week = new DayCollection();
            Console.WriteLine(week["Fri"]);
            try {
                Console.WriteLine(week["Made-up day"]);
            } catch (ArgumentOutOfRangeException e) {
                Console.WriteLine($"Not supported input: {e.Message}");
            }

            //example-3
            var week2 = new DayOfWeekCollection();
            Console.WriteLine(week2[DayOfWeek.Friday]);
            try {
                Console.WriteLine(week2[(DayOfWeek)43]);
            } catch (ArgumentOutOfRangeException e) {
                Console.WriteLine($"Not supported input: {e.Message}");
            }
        }
    }
}