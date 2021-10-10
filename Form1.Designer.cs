
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.nameGroupbox.SuspendLayout();
            this.fieldBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(589, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Results";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(73, 28);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(286, 26);
            this.nameTextBox.TabIndex = 15;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(6, 370);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(561, 60);
            this.searchButton.TabIndex = 16;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // nameGroupbox
            // 
            this.nameGroupbox.Controls.Add(this.label1);
            this.nameGroupbox.Controls.Add(this.filterFieldComboBox);
            this.nameGroupbox.Controls.Add(this.checkBox6);
            this.nameGroupbox.Controls.Add(this.maxFieldValue);
            this.nameGroupbox.Controls.Add(this.label15);
            this.nameGroupbox.Controls.Add(this.label16);
            this.nameGroupbox.Controls.Add(this.minFieldValue);
            this.nameGroupbox.Location = new System.Drawing.Point(6, 120);
            this.nameGroupbox.Name = "nameGroupbox";
            this.nameGroupbox.Size = new System.Drawing.Size(556, 126);
            this.nameGroupbox.TabIndex = 25;
            this.nameGroupbox.TabStop = false;
            this.nameGroupbox.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Field name";
            // 
            // filterFieldComboBox
            // 
            this.filterFieldComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterFieldComboBox.FormattingEnabled = true;
            this.filterFieldComboBox.Location = new System.Drawing.Point(120, 22);
            this.filterFieldComboBox.Name = "filterFieldComboBox";
            this.filterFieldComboBox.Size = new System.Drawing.Size(177, 28);
            this.filterFieldComboBox.TabIndex = 27;
            this.filterFieldComboBox.DropDown += new System.EventHandler(this.filterFieldComboBox_DropDown);
            this.filterFieldComboBox.SelectedIndexChanged += new System.EventHandler(this.filterFieldComboBox_SelectedIndexChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(276, 75);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(124, 24);
            this.checkBox6.TabIndex = 22;
            this.checkBox6.Text = "Exclude field";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // maxFieldValue
            // 
            this.maxFieldValue.Location = new System.Drawing.Point(188, 73);
            this.maxFieldValue.Name = "maxFieldValue";
            this.maxFieldValue.Size = new System.Drawing.Size(71, 26);
            this.maxFieldValue.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(144, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 20);
            this.label15.TabIndex = 20;
            this.label15.Text = "Max";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 20);
            this.label16.TabIndex = 19;
            this.label16.Text = "Min";
            // 
            // minFieldValue
            // 
            this.minFieldValue.Location = new System.Drawing.Point(67, 73);
            this.minFieldValue.Name = "minFieldValue";
            this.minFieldValue.Size = new System.Drawing.Size(71, 26);
            this.minFieldValue.TabIndex = 18;
            // 
            // fieldBox
            // 
            this.fieldBox.Controls.Add(this.resetFieldsButton);
            this.fieldBox.Controls.Add(this.groupBox1);
            this.fieldBox.Controls.Add(this.nameGroupbox);
            this.fieldBox.Controls.Add(this.searchButton);
            this.fieldBox.Controls.Add(this.nameTextBox);
            this.fieldBox.Controls.Add(this.label6);
            this.fieldBox.Location = new System.Drawing.Point(12, 9);
            this.fieldBox.Name = "fieldBox";
            this.fieldBox.Size = new System.Drawing.Size(571, 437);
            this.fieldBox.TabIndex = 26;
            this.fieldBox.TabStop = false;
            this.fieldBox.Text = "Search";
            // 
            // resetFieldsButton
            // 
            this.resetFieldsButton.Location = new System.Drawing.Point(462, 275);
            this.resetFieldsButton.Name = "resetFieldsButton";
            this.resetFieldsButton.Size = new System.Drawing.Size(103, 48);
            this.resetFieldsButton.TabIndex = 23;
            this.resetFieldsButton.Text = "Reset filters";
            this.resetFieldsButton.UseVisualStyleBackColor = true;
            this.resetFieldsButton.Click += new System.EventHandler(this.resetFieldsButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortOrderComboBox);
            this.groupBox1.Controls.Add(this.sortFieldComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(4, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 54);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort";
            // 
            // sortOrderComboBox
            // 
            this.sortOrderComboBox.FormattingEnabled = true;
            this.sortOrderComboBox.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.sortOrderComboBox.Location = new System.Drawing.Point(333, 21);
            this.sortOrderComboBox.Name = "sortOrderComboBox";
            this.sortOrderComboBox.Size = new System.Drawing.Size(147, 28);
            this.sortOrderComboBox.TabIndex = 28;
            // 
            // sortFieldComboBox
            // 
            this.sortFieldComboBox.FormattingEnabled = true;
            this.sortFieldComboBox.Location = new System.Drawing.Point(152, 20);
            this.sortFieldComboBox.Name = "sortFieldComboBox";
            this.sortFieldComboBox.Size = new System.Drawing.Size(175, 28);
            this.sortFieldComboBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Field name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(601, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(696, 546);
            this.dataGridView1.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 889);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fieldBox);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.nameGroupbox.ResumeLayout(false);
            this.nameGroupbox.PerformLayout();
            this.fieldBox.ResumeLayout(false);
            this.fieldBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
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
    }
}

