using HabiticaClone.Enums;
using Realms;
using System;
using System.Collections.Generic;
using System.Text;

namespace HabiticaClone.Models.Habits
{
    public class Habit : RealmObject
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string TaskTitle { get; set; }
        public string Notes { get; set; }
        public bool PositiveSelected { get; set; }
        public bool NegativeSelected { get; set; }
        public Difficulty Difficulty { get; set; }
        public ResetStreak ResetStreak { get; set; }
        public int PositiveStreak { get; set; }
        public int NegativeStreak { get; set; }

    }
}
