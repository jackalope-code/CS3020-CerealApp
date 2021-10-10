
namespace CerealApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.nameGroupbox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.filterFieldComboBox = new System.Windows.Forms.ComboBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.maxFieldValue = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.minFieldValue = new System.Windows.Forms.TextBox();
            this.fieldBox = new System.Windows.Forms.GroupBox();
            this.resetFieldsButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortOrderComboBox = new System.Windows.Forms.ComboBox();
            this.sortFieldComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nameGroupbox.SuspendLayout();
            this.fieldBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(10, 26);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(292, 26);
            this.nameTextBox.TabIndex = 15;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(980, 36);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(393, 115);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // nameGroupbox
            // 
            this.nameGroupbox.Controls.Add(this.resetFieldsButton);
            this.nameGroupbox.Controls.Add(this.label1);
            this.nameGroupbox.Controls.Add(this.filterFieldComboBox);
            this.nameGroupbox.Controls.Add(this.label16);
            this.nameGroupbox.Controls.Add(this.minFieldValue);
            this.nameGroupbox.Controls.Add(this.checkBox6);
            this.nameGroupbox.Controls.Add(this.label15);
            this.nameGroupbox.Controls.Add(this.maxFieldValue);
            this.nameGroupbox.Location = new System.Drawing.Point(496, 25);
            this.nameGroupbox.Name = "nameGroupbox";
            this.nameGroupbox.Size = new System.Drawing.Size(459, 126);
            this.nameGroupbox.TabIndex = 25;
            this.nameGroupbox.TabStop = false;
            this.nameGroupbox.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Field name";
            // 
            // filterFieldComboBox
            // 
            this.filterFieldComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterFieldComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterFieldComboBox.FormattingEnabled = true;
            this.filterFieldComboBox.Location = new System.Drawing.Point(99, 31);
            this.filterFieldComboBox.Name = "filterFieldComboBox";
            this.filterFieldComboBox.Size = new System.Drawing.Size(177, 28);
            this.filterFieldComboBox.TabIndex = 27;
            this.filterFieldComboBox.DropDown += new System.EventHandler(this.filterFieldComboBox_DropDown);
            this.filterFieldComboBox.SelectedIndexChanged += new System.EventHandler(this.filterFieldComboBox_SelectedIndexChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(255, 84);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(124, 24);
            this.checkBox6.TabIndex = 22;
            this.checkBox6.Text = "Exclude field";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // maxFieldValue
            // 
            this.maxFieldValue.Location = new System.Drawing.Point(167, 82);
            this.maxFieldValue.Name = "maxFieldValue";
            this.maxFieldValue.Size = new System.Drawing.Size(71, 26);
            this.maxFieldValue.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(123, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 20);
            this.label15.TabIndex = 20;
            this.label15.Text = "Max";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 20);
            this.label16.TabIndex = 19;
            this.label16.Text = "Min";
            // 
            // minFieldValue
            // 
            this.minFieldValue.Location = new System.Drawing.Point(46, 82);
            this.minFieldValue.Name = "minFieldValue";
            this.minFieldValue.Size = new System.Drawing.Size(71, 26);
            this.minFieldValue.TabIndex = 18;
            // 
            // fieldBox
            // 
            this.fieldBox.Controls.Add(this.groupBox2);
            this.fieldBox.Controls.Add(this.searchButton);
            this.fieldBox.Controls.Add(this.groupBox1);
            this.fieldBox.Controls.Add(this.nameGroupbox);
            this.fieldBox.Location = new System.Drawing.Point(6, 12);
            this.fieldBox.Name = "fieldBox";
            this.fieldBox.Size = new System.Drawing.Size(1396, 161);
            this.fieldBox.TabIndex = 26;
            this.fieldBox.TabStop = false;
            this.fieldBox.Text = "Search";
            // 
            // resetFieldsButton
            // 
            this.resetFieldsButton.Location = new System.Drawing.Point(306, 27);
            this.resetFieldsButton.Name = "resetFieldsButton";
            this.resetFieldsButton.Size = new System.Drawing.Size(141, 35);
            this.resetFieldsButton.TabIndex = 23;
            this.resetFieldsButton.Text = "Reset fields";
            this.resetFieldsButton.UseVisualStyleBackColor = true;
            this.resetFieldsButton.Click += new System.EventHandler(this.resetFieldsButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortOrderComboBox);
            this.groupBox1.Controls.Add(this.sortFieldComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 68);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort";
            // 
            // sortOrderComboBox
            // 
            this.sortOrderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortOrderComboBox.FormattingEnabled = true;
            this.sortOrderComboBox.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.sortOrderComboBox.Location = new System.Drawing.Point(287, 25);
            this.sortOrderComboBox.Name = "sortOrderComboBox";
            this.sortOrderComboBox.Size = new System.Drawing.Size(132, 28);
            this.sortOrderComboBox.TabIndex = 28;
            // 
            // sortFieldComboBox
            // 
            this.sortFieldComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortFieldComboBox.FormattingEnabled = true;
            this.sortFieldComboBox.Location = new System.Drawing.Point(136, 25);
            this.sortFieldComboBox.Name = "sortFieldComboBox";
            this.sortFieldComboBox.Size = new System.Drawing.Size(145, 28);
            this.sortFieldComboBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Field name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1385, 674);
            this.dataGridView1.TabIndex = 27;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(6, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1396, 705);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Results";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nameTextBox);
            this.groupBox2.Location = new System.Drawing.Point(6, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 58);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 889);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.fieldBox);
            this.Name = "Form1";
            this.Text = "Cereal Killer";
            this.nameGroupbox.ResumeLayout(false);
            this.nameGroupbox.PerformLayout();
            this.fieldBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.GroupBox nameGroupbox;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.TextBox maxFieldValue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox minFieldValue;
        private System.Windows.Forms.GroupBox fieldBox;
        private System.Windows.Forms.Button resetFieldsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filterFieldComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox sortFieldComboBox;
        private System.Windows.Forms.ComboBox sortOrderComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

