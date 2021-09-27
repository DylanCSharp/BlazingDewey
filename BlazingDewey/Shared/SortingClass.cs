using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazingDewey.Shared
{
    public class Sortingclass : IComparer<GridTaskModel>
    {
        public int Compare(GridTaskModel x, GridTaskModel y)
        {
            int compareValue = x.FinalAppendedDewey.CompareTo(y.FinalAppendedDewey);
            if (compareValue == 0)
            {
                return x.FinalAppendedDewey.CompareTo(y.FinalAppendedDewey);
            }
            return compareValue;
        }
    }
}
