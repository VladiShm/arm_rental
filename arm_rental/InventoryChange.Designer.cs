namespace arm_rental
{
    partial class InventoryChange
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Название = new Label();
            Цена = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(30, 161);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(30, 269);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(214, 27);
            textBox2.TabIndex = 1;
            // 
            // Название
            // 
            Название.AutoSize = true;
            Название.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Название.Location = new Point(30, 18);
            Название.Name = "Название";
            Название.RightToLeft = RightToLeft.No;
            Название.Size = new Size(90, 24);
            Название.TabIndex = 2;
            Название.Text = "Название";
            // 
            // Цена
            // 
            Цена.AutoSize = true;
            Цена.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Цена.Location = new Point(34, 234);
            Цена.Name = "Цена";
            Цена.Size = new Size(53, 24);
            Цена.TabIndex = 3;
            Цена.Text = "Цена";
            // 
            // button1
            // 
            button1.Location = new Point(82, 332);
            button1.Name = "button1";
            button1.Size = new Size(113, 44);
            button1.TabIndex = 4;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(30, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(214, 28);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 134);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(146, 24);
            label1.TabIndex = 6;
            label1.Text = "Новое название";
            // 
            // InventoryChange
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 416);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(Цена);
            Controls.Add(Название);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "InventoryChange";
            Text = "InventoryChange";
            Load += InventoryChange_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label Название;
        private Label Цена;
        private Button button1;
        private ComboBox comboBox1;
        private Label label1;
    }
}