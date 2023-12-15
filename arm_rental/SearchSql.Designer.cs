namespace arm_rental
{
    partial class SearchSql
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listBoxFieldsRes = new ListBox();
            buttonManyFieldsLeft = new Button();
            buttonOneFieldLeft = new Button();
            buttonManyFieldsRight = new Button();
            buttonOneFieldRight = new Button();
            listBoxFields = new ListBox();
            tabPage2 = new TabPage();
            buttonStart = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label1 = new Label();
            comboBox4 = new ComboBox();
            buttonAdd = new Button();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            tabPage3 = new TabPage();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(807, 500);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            tabControl1.Selected += tabControl1_Selected;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listBoxFieldsRes);
            tabPage1.Controls.Add(buttonManyFieldsLeft);
            tabPage1.Controls.Add(buttonOneFieldLeft);
            tabPage1.Controls.Add(buttonManyFieldsRight);
            tabPage1.Controls.Add(buttonOneFieldRight);
            tabPage1.Controls.Add(listBoxFields);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(799, 467);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Поля";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // listBoxFieldsRes
            // 
            listBoxFieldsRes.FormattingEnabled = true;
            listBoxFieldsRes.ItemHeight = 20;
            listBoxFieldsRes.Location = new Point(483, 21);
            listBoxFieldsRes.Name = "listBoxFieldsRes";
            listBoxFieldsRes.Size = new Size(295, 424);
            listBoxFieldsRes.TabIndex = 5;
            // 
            // buttonManyFieldsLeft
            // 
            buttonManyFieldsLeft.Location = new Point(391, 315);
            buttonManyFieldsLeft.Name = "buttonManyFieldsLeft";
            buttonManyFieldsLeft.Size = new Size(61, 38);
            buttonManyFieldsLeft.TabIndex = 4;
            buttonManyFieldsLeft.Text = "<<";
            buttonManyFieldsLeft.UseVisualStyleBackColor = true;
            buttonManyFieldsLeft.Click += buttonManyFieldsLeft_Click;
            // 
            // buttonOneFieldLeft
            // 
            buttonOneFieldLeft.Location = new Point(391, 271);
            buttonOneFieldLeft.Name = "buttonOneFieldLeft";
            buttonOneFieldLeft.Size = new Size(61, 38);
            buttonOneFieldLeft.TabIndex = 3;
            buttonOneFieldLeft.Text = "<";
            buttonOneFieldLeft.UseVisualStyleBackColor = true;
            buttonOneFieldLeft.Click += buttonOneFieldLeft_Click;
            // 
            // buttonManyFieldsRight
            // 
            buttonManyFieldsRight.Location = new Point(391, 161);
            buttonManyFieldsRight.Name = "buttonManyFieldsRight";
            buttonManyFieldsRight.Size = new Size(61, 38);
            buttonManyFieldsRight.TabIndex = 2;
            buttonManyFieldsRight.Text = ">>";
            buttonManyFieldsRight.UseVisualStyleBackColor = true;
            buttonManyFieldsRight.Click += buttonManyFieldsRight_Click;
            // 
            // buttonOneFieldRight
            // 
            buttonOneFieldRight.Location = new Point(391, 117);
            buttonOneFieldRight.Name = "buttonOneFieldRight";
            buttonOneFieldRight.Size = new Size(61, 38);
            buttonOneFieldRight.TabIndex = 1;
            buttonOneFieldRight.Text = ">";
            buttonOneFieldRight.UseVisualStyleBackColor = true;
            buttonOneFieldRight.Click += buttonOneFieldRight_Click;
            // 
            // listBoxFields
            // 
            listBoxFields.FormattingEnabled = true;
            listBoxFields.ItemHeight = 20;
            listBoxFields.Location = new Point(26, 21);
            listBoxFields.Name = "listBoxFields";
            listBoxFields.Size = new Size(330, 424);
            listBoxFields.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonStart);
            tabPage2.Controls.Add(listView1);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(comboBox4);
            tabPage2.Controls.Add(buttonAdd);
            tabPage2.Controls.Add(comboBox3);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(799, 467);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Условия";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(673, 408);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(108, 32);
            buttonStart.TabIndex = 15;
            buttonStart.Text = "Выполнить";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Location = new Point(31, 105);
            listView1.Name = "listView1";
            listView1.Size = new Size(750, 284);
            listView1.TabIndex = 14;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Поле";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Условие";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Значение";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Соединение";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 18);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 13;
            label1.Text = "Имя поля";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "and", "or" });
            comboBox4.Location = new Point(552, 41);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(56, 28);
            comboBox4.TabIndex = 12;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(636, 41);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(108, 28);
            buttonAdd.TabIndex = 11;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(347, 41);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(189, 28);
            comboBox3.TabIndex = 10;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(231, 41);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(92, 28);
            comboBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(31, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 28);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView1);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(799, 467);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Результат";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(5, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(788, 430);
            dataGridView1.TabIndex = 1;
            // 
            // SearchSql
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 510);
            Controls.Add(tabControl1);
            Name = "SearchSql";
            Text = "SearchSql";
            Load += SearchSql_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox listBoxFields;
        private ListBox listBoxFieldsRes;
        private Button buttonManyFieldsLeft;
        private Button buttonOneFieldLeft;
        private Button buttonManyFieldsRight;
        private Button buttonOneFieldRight;
        private Button buttonStart;
        public ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label1;
        private ComboBox comboBox4;
        private Button buttonAdd;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TabPage tabPage3;
        public DataGridView dataGridView1;
    }
}