using System;
using Day = System.DayOfWeek;

namespace Indexers {
    public class TempRecord {
        float[] temps = new float[10] {
            56.2F, 56.7F, 56.5F, 56.9F, 58.8F,
            61.3F, 65.9F, 62.1F, 59.2F, 57.5F
        };
        public int Length => temps.Length;
        public float this[int index] {
            get => temps[index];
            set => temps[index] = value;
        }
    }

    class DayCollection {
        string[] days = { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };
        public int this[string day] => FindDayIndex(day);
        private int FindDayIndex(string day) {
            for (int j = 0; j < days.Length; j++) {
                if (days[j] == day) {
                    return j;
                }
            }

            throw new ArgumentOutOfRangeException(
                nameof(day),
                $"Day {day} is invalid!\nDay input must be in the form \"Sun\", \"Mon\", ..."
            );
        }
    }

    class DayOfWeekCollection {
        Day[] days = {
            Day.Sunday, Day.Monday, Day.Tuesday, Day.Wednesday,
            Day.Thursday, Day.Friday, Day.Saturday
        };

        // Indexer with only a get accessor with the expression-bodied definition:
        public int this[Day day] => FindDayIndex(day);
        private int FindDayIndex(Day day) {
            for (int j = 0; j < days.Length; j++) {
                if (days[j] == day) {
                    return j;
                }
            }
        
            throw new ArgumentOutOfRangeException(
                nameof(day),
                $"Day {day} is invalid!\nDay input must be a defined System.DayOfWeek value."
            );
        }
    }
}