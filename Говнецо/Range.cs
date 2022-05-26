using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Говнецо
{
    sealed class Range
    {
        public Range(int minValue, int maxValue)
        {
            MinValue = minValue;
            MaxValue = maxValue;
        }

        public int MinValue
        {
            get; private set;
        }

        public int MaxValue
        {
            get; private set;
        }
    }
}
