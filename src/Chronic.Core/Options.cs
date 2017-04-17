using System;
using Chronic.Core.Tags;

namespace Chronic.Core
{
    public class Options
    {
        public static readonly int DefaultAmbiguousTimeRange = 6;

        public Func<DateTime> Clock { get; set; }

        public Pointer.Type Context { get; set; }

        public int AmbiguousTimeRange { get; set; }

        public EndianPrecedence EndianPrecedence { get; set; }

        public string OriginalPhrase { get; set; }
        public DayOfWeek FirstDayOfWeek { get; set; }

        public Options()
        {
            AmbiguousTimeRange = DefaultAmbiguousTimeRange;
            EndianPrecedence = EndianPrecedence.Middle;
            Clock = () => DateTime.Now;
            FirstDayOfWeek = DayOfWeek.Sunday;
        }
    }
}