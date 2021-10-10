using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*  TODO:
 *  
 *  Change field value storage so that just a max or just a min works
 *  Change filter field so it can also filter on single text values
 *  
 *  Review code structure... look for inconsistencies and errors
 *  Add more comments/documentation
 *  Do the writeup and design doc for this program
 * 
 * 
 */

namespace CerealApp
{

    public partial class Form1 : Form
    {
        private List<CerealInfo> cereals;

        private Dictionary<FieldName, FieldFilter> filterData;

        public Form1()
        {
            this.cereals = new List<CerealInfo>();
            this.filterData = new Dictionary<FieldName, FieldFilter>();
            InitializeComponent();
            this.sortFieldComboBox.SelectedItem = FieldName.NAME;
            this.sortOrderComboBox.SelectedIndex = 0;

            this.filterFieldComboBox.DataSource = Enum.GetNames(typeof(FieldName));
            this.sortFieldComboBox.DataSource = Enum.GetNames(typeof(FieldName));


            // Load cereals
            StreamReader reader = new StreamReader("../../cereal.csv");
            string line;
            string header = reader.ReadLine();
            while((line = reader.ReadLine()) != null)
            {
                string[] fields = line.Split(',');
                CerealInfo info = new CerealInfo(fields);
                cereals.Add(info);
            }

            SetResultOutput(cereals);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SaveCurrentField();

            RunSearch();
        }

        /// <summary>
        ///  Contains all the logic for searching, filtering, ordering, and displaying results.
        /// </summary>
        private void RunSearch()
        {
            String nameSearch = this.nameTextBox.Text;
            FieldName sortedField;
            Enum.TryParse(this.sortFieldComboBox.Text, out sortedField);
            FieldName currentFilteredField;
            Enum.TryParse(this.filterFieldComboBox.Text, out currentFilteredField);
            double fieldMin = 0;
            double fieldMax = 0;
            bool sortOrderAscending = this.sortOrderComboBox.SelectedItem.Equals("Ascending");

            bool errorParsing = !double.TryParse(this.minFieldValue.Text, out fieldMin);
            errorParsing = errorParsing || !double.TryParse(this.maxFieldValue.Text, out fieldMax);
            // TODO: Cleanup
            Console.WriteLine($"Error parsing? {errorParsing}");

            // Initialize results with all of the data, then apply repeating filters.
            IEnumerable<CerealInfo> results = cereals;
            foreach (FieldName filterName in filterData.Keys) {
                FieldFilter filterObject = filterData[filterName];
                if(filterObject.ExcludeField)
                {
                    continue;
                }
                results = (from cereal in results
                               where cereal.Name.ToLower().Contains(nameSearch.ToLower())
                               where (errorParsing ||
                                   (cereal.GetDoubleField(filterName) >= filterObject.MinValue
                                     && cereal.GetDoubleField(filterName) <= filterObject.MaxValue
                                   )
                               )
                               select cereal);

            }


            IOrderedEnumerable<CerealInfo> sortedResults;
            bool isTextField = sortedField == FieldName.NAME || sortedField == FieldName.MFR || sortedField == FieldName.TYPE;
            if (sortOrderAscending)
            {
                if (isTextField)
                {
                    sortedResults = results.OrderBy(result => result.GetStringField(sortedField));
                }
                else
                {
                    sortedResults = results.OrderBy(result => result.GetDoubleField(sortedField));
                }
            }
            else
            {
                if (isTextField)
                {
                    sortedResults = results.OrderByDescending(result => result.GetStringField(sortedField));
                }
                else
                {
                    sortedResults = results.OrderByDescending(result => result.GetDoubleField(sortedField));
                }
            }

            SetResultOutput(sortedResults.ToList());
        }

        private void resetFieldsButton_Click(object sender, EventArgs e)
        {
            DialogResult result = 
                MessageBox.Show("Warning! This will reset all fields! Are you sure that you want to continue?",
                "Confirm reset", MessageBoxButtons.OKCancel);
            if(result == DialogResult.OK)
            {
                filterData.Clear();
                this.minFieldValue.Text = "";
                this.maxFieldValue.Text = "";
                this.checkBox6.Checked = false;

                this.sortFieldComboBox.SelectedItem = FieldName.NAME;
                this.sortOrderComboBox.SelectedIndex = 0;
                RunSearch();
            }
        }

        private void SetResultOutput(List<CerealInfo> results)
        {
            var bindingList = new BindingList<CerealInfo>(results);
            var source = new BindingSource(bindingList, null);
            this.dataGridView1.DataSource = source;
        }

        // Store whatever is in the currently selected field in case the user changes the selection.
        private void filterFieldComboBox_DropDown(object sender, EventArgs e)
        {
            SaveCurrentField();
        }

        /// <summary>
        /// Save the field state if both the min and max fields are populated.
        /// Returns a bool that indicates success or failure.
        /// </summary>
        /// <returns></returns>
        private bool SaveCurrentField()
        {
            int min, max;
            if (
                int.TryParse(this.minFieldValue.Text, out min) &&
                int.TryParse(this.maxFieldValue.Text, out max)
            )
            {
                FieldName field = GetSelectedFilterFieldAsEnum();
                bool excludeField = this.checkBox6.Checked;
                var filter = new FieldFilter(min, max, excludeField);
                this.filterData[field] = filter;
                return true;

            }
            return false;
        }

        // Helper method to determine what field is selected in the UI at any given time
        private FieldName GetSelectedFilterFieldAsEnum()
        {
            FieldName field;
            Enum.TryParse(this.filterFieldComboBox.Text, out field);
            return field;
        }

        // Load whatever might be saved for the newly selected field
        private void filterFieldComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadField(GetSelectedFilterFieldAsEnum());
        }

        /// <summary>
        /// Set fields if there is data stored in the running program. Otherwise, this
        /// will set fields to default (empty) values.
        /// </summary>
        /// <param name="field"></param>
        private void LoadField(FieldName field)
        {
            if (filterData.ContainsKey(field))
            {
                // Load filter data object from a field to allow cycling through fields
                var filter = filterData[field];
                this.minFieldValue.Text = filter.MinValue.ToString();
                this.maxFieldValue.Text = filter.MaxValue.ToString();
                this.checkBox6.Checked = filter.ExcludeField;

            } else
            {
                // Set default field UI state
                this.minFieldValue.Text = "";
                this.maxFieldValue.Text = "";
                this.checkBox6.Checked = false;
            }
        }
    }
}
