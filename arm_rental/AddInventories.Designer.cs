namespace arm_rental
{
    partial class AddInventories
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
            textBoxPrice = new TextBox();
            comboBoxCategory = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(65, 93);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(250, 27);
            textBoxName.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(65, 286);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(250, 27);
            textBoxPrice.TabIndex = 1;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(65, 184);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(250, 28);
            comboBoxCategory.TabIndex = 2;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(65, 56);
            label1.Name = "label1";
            label1.Size = new Size(90, 24);
            label1.TabIndex = 3;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(65, 149);
            label2.Name = "label2";
            label2.Size = new Size(97, 24);
            label2.TabIndex = 4;
            label2.Text = "Категория";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(65, 251);
            label3.Name = "label3";
            label3.Size = new Size(53, 24);
            label3.TabIndex = 5;
            label3.Text = "Цена";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(109, 370);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(152, 41);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // AddInventories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 458);
            Controls.Add(buttonAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxCategory);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Name = "AddInventories";
            Text = "AddInventories";
            Load += AddInventories_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private ComboBox comboBoxCategory;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonAdd;
    }
}