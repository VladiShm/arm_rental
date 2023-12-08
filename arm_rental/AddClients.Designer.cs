namespace arm_rental
{
    partial class AddClients
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
            tbName = new TextBox();
            tbSurname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbPhone = new TextBox();
            label3 = new Label();
            buttonAdd = new Button();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(109, 64);
            tbName.Name = "tbName";
            tbName.Size = new Size(226, 27);
            tbName.TabIndex = 0;
            // 
            // tbSurname
            // 
            tbSurname.Location = new Point(109, 150);
            tbSurname.Name = "tbSurname";
            tbSurname.Size = new Size(226, 27);
            tbSurname.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(109, 30);
            label1.Name = "label1";
            label1.Size = new Size(45, 24);
            label1.TabIndex = 2;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(109, 119);
            label2.Name = "label2";
            label2.Size = new Size(86, 24);
            label2.TabIndex = 3;
            label2.Text = "Фамилия";
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(109, 229);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(226, 27);
            tbPhone.TabIndex = 4;
            tbPhone.TextChanged += tbPhone_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(109, 202);
            label3.Name = "label3";
            label3.Size = new Size(90, 24);
            label3.TabIndex = 5;
            label3.Text = "Телефон";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(129, 329);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(164, 38);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // AddClients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 410);
            Controls.Add(buttonAdd);
            Controls.Add(label3);
            Controls.Add(tbPhone);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbSurname);
            Controls.Add(tbName);
            Name = "AddClients";
            Text = "AddClients";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private TextBox tbSurname;
        private Label label1;
        private Label label2;
        private TextBox tbPhone;
        private Label label3;
        private Button buttonAdd;
    }
}