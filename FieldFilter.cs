using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CerealApp
{
    class FieldFilter
    {
        private int? min;
        private int? max;

        public int? MinValue { get { return this.min; } }

        public int? MaxValue { get { return this.max; } }

        public bool MinValueSet { get; set; }

        public bool MaxValueSet { get; set; }

        public bool ExcludeField { get; set; }

        public FieldFilter(int? min, int? max, bool exclude)
        {
            this.min = min;
            this.max = max;
            this.ExcludeField = exclude;
        }
    }
}
