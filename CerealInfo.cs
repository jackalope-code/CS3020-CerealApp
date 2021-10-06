using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CerealApp
{
    // Tracks all the fields
    enum FieldName
    {
        NAME,
        MFR,
        TYPE,
        CALORIES,
        PROTEIN,
        FAT,
        SODIUM,
        FIBER,
        CARB,
        SUGARS,
        POTASS,
        VITAMINS,
        SHELF,
        WEIGHT,
        CUPS,
        RATING
    }

    /// <summary>
    /// CerealInfo
    /// 
    /// Data object for displaying to the grid from fields and accessing fields for queries
    /// </summary>
    class CerealInfo
    {
        private static List<FieldName> allFields = Enum.GetValues(typeof(FieldName)).Cast<FieldName>().ToList();
        private Dictionary<FieldName, string> values;

        public String Name { get { return this.values[FieldName.NAME]; } }
        public String MFR { get { return this.values[FieldName.MFR]; } }
        public String Type { get { return this.values[FieldName.TYPE]; } }
        public String Calories { get { return this.values[FieldName.CALORIES]; } }
        public String Protein { get { return this.values[FieldName.PROTEIN]; } }
        public String Fat { get { return this.values[FieldName.FAT]; } }
        public String Sodium { get { return this.values[FieldName.SODIUM]; } }
        public String Fiber { get { return this.values[FieldName.FIBER]; } }
        public String Carb { get { return this.values[FieldName.CARB]; } }
        public String Sugars { get { return this.values[FieldName.SUGARS]; } }
        public String Potassium { get { return this.values[FieldName.POTASS]; } }
        public String Vitamins { get { return this.values[FieldName.VITAMINS]; } }
        public String Shelf { get { return this.values[FieldName.SHELF]; } }
        public String Weight { get { return this.values[FieldName.WEIGHT]; } }
        public String Cups { get { return this.values[FieldName.CUPS]; } }
        public String Rating { get { return this.values[FieldName.RATING]; } }

        /// <summary>
        /// The data object is constructed from one row of data that is already split into an array
        /// </summary>
        /// <param name="tokenizedFields"></param>
        public CerealInfo(string[] tokenizedFields) {
            Dictionary<FieldName, string> values = new Dictionary<FieldName, string>();
            int i = 0;
            foreach (FieldName field in allFields)
            {
                values.Add(field, tokenizedFields[i]);
                i++;
            }
            this.values = values;
        }

        /// <summary>
        /// Returns a string representation of a field without error checking
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        public string GetStringField(FieldName field)
        {
            return this.values[field];
        }

        /// <summary>
        /// Tries to access a field as a double. This will fail silently if the field is not a double.
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        public double GetDoubleField(FieldName field)
        {
            double result = 0;
            double.TryParse(this.values[field], out result);
            return result;
        }

        /// <summary>
        /// Tries to access a field as an int. This will fail silently if the field is not an int.
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        public int GetIntField(FieldName field)
        {
            int result;
            int.TryParse(this.values[field], out result);
            return result;
        }
    }
}
