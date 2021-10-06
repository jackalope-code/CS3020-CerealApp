using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CerealApp
{
    class FieldFilter
    {
        private int min;
        private int max;
        private String fieldName;

        public int MinValue { get { return this.min; } }

        public int MaxValue { get { return this.max; } }

        public FieldFilter(int min, int max, String fieldName)
        {
            this.min = min;
            this.max = max;
            this.fieldName = fieldName;
        }

        public int Min => min;

        public int Max => max;

        public String FieldName => fieldName;
    }
}
