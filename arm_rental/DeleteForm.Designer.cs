namespace arm_rental
{
    partial class DeleteForm
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(71, 111);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(239, 28);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(71, 76);
            label1.Name = "label1";
            label1.Size = new Size(90, 24);
            label1.TabIndex = 1;
            label1.Text = "Название";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(110, 186);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(139, 49);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Удалить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 281);
            Controls.Add(buttonAdd);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "DeleteForm";
            Text = "DeleteForm";
            Load += DeleteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Button buttonAdd;
    }
}