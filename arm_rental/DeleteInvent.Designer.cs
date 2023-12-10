namespace arm_rental
{
    partial class DeleteInvent
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
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(76, 92);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(254, 28);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(76, 56);
            label1.Name = "label1";
            label1.Size = new Size(181, 24);
            label1.TabIndex = 1;
            label1.Text = "Название инвентаря";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(105, 196);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(164, 42);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // DeleteInvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 287);
            Controls.Add(buttonDelete);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "DeleteInvent";
            Text = "DeleteInvent";
            Load += DeleteInvent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Button buttonDelete;
    }
}