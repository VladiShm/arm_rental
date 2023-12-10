namespace arm_rental
{
    partial class UpdateCategories
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
            label1 = new Label();
            buttonAdd = new Button();
            comboBoxName = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 28);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(77, 247);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(147, 48);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Сохранить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // comboBoxName
            // 
            comboBoxName.FormattingEnabled = true;
            comboBoxName.Location = new Point(35, 68);
            comboBoxName.Name = "comboBoxName";
            comboBoxName.Size = new Size(253, 28);
            comboBoxName.TabIndex = 3;
            comboBoxName.SelectedIndexChanged += comboBoxName_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 163);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 27);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 123);
            label2.Name = "label2";
            label2.Size = new Size(163, 28);
            label2.TabIndex = 5;
            label2.Text = "Новое название";
            // 
            // UpdateCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 327);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(comboBoxName);
            Controls.Add(buttonAdd);
            Controls.Add(label1);
            Name = "UpdateCategories";
            Text = "UpdateCategories";
            Load += UpdateCategories_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonAdd;
        private ComboBox comboBoxName;
        private TextBox textBox1;
        private Label label2;
    }
}