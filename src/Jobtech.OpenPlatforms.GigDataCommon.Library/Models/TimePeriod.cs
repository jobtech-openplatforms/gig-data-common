using System;

namespace AF.Gig.Common.Models
{
    public class TimePeriod
    {
        public TimePeriod(DateTimeOffset? start, DateTimeOffset? end)
        {
            Start = start;
            End = end;
        }

        public DateTimeOffset? Start { get; private set; }
        public DateTimeOffset? End { get; private set; }
    }
}