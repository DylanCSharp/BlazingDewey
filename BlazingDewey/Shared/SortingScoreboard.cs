using System.Collections.Generic;

namespace BlazingDewey.Shared
{
    public class SortingScoreboard : IComparer<ScoreboardClass>
    {
        public int Compare(ScoreboardClass x, ScoreboardClass y)
        {
            int compareValue = x.TimeTaken.CompareTo(y.TimeTaken);
            if (compareValue == 0)
            {
                return x.TimeTaken.CompareTo(y.TimeTaken);
            }
            return compareValue;
        }
    }
}
