using System;

namespace FuncsTimerIssueMRE
{
    public class TimerInfo
    {
        public bool IsPastDue { get; set; }

        public ScheduleStatus ScheduleStatus { get; set; }
    }

    public class ScheduleStatus
    {
        public DateTime Last { get; set; }

        public DateTime LastUpdated { get; set; }

        public DateTime Next { get; set; }
    }
}
