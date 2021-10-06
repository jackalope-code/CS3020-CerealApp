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
 *  Update fields to work with sane default values
 *  Update the search to work from ONE SAVED FIELD
 *  Update the search to work with ALL SAVED FIELDS
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
            InitializeComponent();

            this.filterFieldComboBox.DataSource = Enum.GetNames(typeof(FieldName));
            this.sortFieldComboBox.DataSource = Enum.GetNames(typeof(FieldName));

            this.cereals = new List<CerealInfo>();
            this.filterData = new Dictionary<FieldName, FieldFilter>();

            // Load cereals
            StreamReader reader = new StreamReader("../../cereal.csv");
            string line;
            string header = reader.ReadLine();
            while((line = reader.ReadLine()) != null)
            //for (int i = 0; i < 5; i++)
            {
                string[] fields = line.Split(',');
                CerealInfo info = new CerealInfo(fields);
                cereals.Add(info);
            }

            SetResultOutput(cereals);
        }

        private void menuAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SaveCurrentField();

            String nameSearch = this.nameTextBox.Text;
            FieldName sortedField;
            Enum.TryParse(this.sortFieldComboBox.Text, out sortedField);
            FieldName currentFilteredField;
            Enum.TryParse(this.filterFieldComboBox.Text, out currentFilteredField);
            double fieldMin = 0;
            double fieldMax = 0;
            bool sortOrderAscending = this.sortOrderComboBox.Text.Equals("Ascending");

            bool errorParsing = !double.TryParse(this.minFieldValue.Text, out fieldMin);
            errorParsing = errorParsing || !double.TryParse(this.maxFieldValue.Text, out fieldMax);
            Console.WriteLine($"Error parsing? {errorParsing}");

            var results = (from cereal in cereals
                           where cereal.Name.ToLower().Contains(nameSearch.ToLower())
                           where (errorParsing ||
                               (cereal.GetDoubleField(currentFilteredField) >= fieldMin
                                 && cereal.GetDoubleField(currentFilteredField) <= fieldMax
                               )
                           )
                           select cereal);


            Console.WriteLine($"sort on {sortedField}");
            IOrderedEnumerable<CerealInfo> sortedResults;
            bool isTextField = sortedField == FieldName.NAME || sortedField == FieldName.MFR || sortedField == FieldName.TYPE;
            if(sortOrderAscending)
            {
                if(isTextField)
                {
                    sortedResults = results.OrderBy(result => result.GetStringField(sortedField));
                } else
                {
                    sortedResults = results.OrderBy(result => result.GetDoubleField(sortedField));
                }
            } else
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
            filterData.Clear();
        }

        private void SetResultOutput(List<CerealInfo> results)
        {
            var bindingList = new BindingList<CerealInfo>(results);
            var source = new BindingSource(bindingList, null);
            this.dataGridView1.DataSource = source;
        }

        private void filterFieldComboBox_DropDown(object sender, EventArgs e)
        {
            SaveCurrentField();

            Console.WriteLine("Fields:");
            foreach (var key in filterData.Keys)
            {
                var filter = filterData[key];
                Console.WriteLine($"{key}: {filter.MinValue} - {filter.MaxValue}");
            }
        }

        private void SaveCurrentField()
        {
            int min, max;
            int.TryParse(this.minFieldValue.Text, out min);
            int.TryParse(this.maxFieldValue.Text, out max);

            FieldName field = GetSelectedFilterFieldAsEnum();
            var filter = new FieldFilter(min, max, "");
            this.filterData[field] = filter;
        }

        private FieldName GetSelectedFilterFieldAsEnum()
        {
            FieldName field;
            Enum.TryParse(this.filterFieldComboBox.Text, out field);
            return field;
        }
    }
}
