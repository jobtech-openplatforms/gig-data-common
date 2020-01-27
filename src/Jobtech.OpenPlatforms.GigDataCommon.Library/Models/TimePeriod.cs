using System;

namespace Jobtech.OpenPlatforms.GigDataCommon.Library.Models
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