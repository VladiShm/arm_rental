namespace arm_rental
{
    partial class AddCategories
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
            textBoxName = new TextBox();
            label1 = new Label();
            btnAdd = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(47, 74);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(247, 27);
            textBoxName.TabIndex = 0;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 34);
            label1.Name = "label1";
            label1.Size = new Size(182, 24);
            label1.TabIndex = 1;
            label1.Text = "Название категории";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(92, 279);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(137, 43);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Летний", "Зимний" });
            comboBox1.Location = new Point(47, 171);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(247, 28);
            comboBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 134);
            label2.Name = "label2";
            label2.Size = new Size(60, 24);
            label2.TabIndex = 4;
            label2.Text = "Сезон";
            // 
            // AddCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 363);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(btnAdd);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Name = "AddCategories";
            Text = "AddCategories";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private Label label1;
        private Button btnAdd;
        private ComboBox comboBox1;
        private Label label2;
    }
}