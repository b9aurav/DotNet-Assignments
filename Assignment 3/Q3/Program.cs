﻿using System;

namespace Assignment_3 {
    [Flags]
    public enum Days {
        None = 0b_0000_0000, // 0
        Monday = 0b_0000_0001, // 1
        Tuesday = 0b_0000_0010, // 2
        Wednesday = 0b_0000_0100, // 4
        Thursday = 0b_0000_1000, // 8
        Friday = 0b_0001_0000, // 16
        Saturday = 0b_0010_0000, // 32
        Sunday = 0b_0100_0000, // 64
        Weekend = Saturday | Sunday
    }
    class Program {
        static void Main(string[] args) {
            Days meetingDays = Days.Tuesday | Days.Thursday;
            Console.WriteLine(meetingDays);

            Days workingFromHomeDays = Days.Thursday | Days.Saturday;
            Console.WriteLine($"Join a meeting by phone on {meetingDays & workingFromHomeDays}");

            bool isMeetingOnTuesday = (meetingDays & Days.Tuesday) == Days.Tuesday;
            Console.WriteLine($"Is there a meeting on Tuesday: {isMeetingOnTuesday}");

            var a = (Days)93;
            Console.WriteLine(a);
        }
    }
}