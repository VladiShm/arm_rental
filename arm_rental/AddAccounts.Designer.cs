namespace arm_rental
{
    partial class AddAccounts
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
            textBoxLogin = new TextBox();
            textBoxPass = new TextBox();
            comboBoxRole = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(104, 73);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(220, 27);
            textBoxLogin.TabIndex = 0;
            textBoxLogin.TextChanged += textBox1_TextChanged;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(104, 161);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(220, 27);
            textBoxPass.TabIndex = 1;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Клиент", "Администратор" });
            comboBoxRole.Location = new Point(104, 238);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(220, 28);
            comboBoxRole.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(104, 40);
            label1.Name = "label1";
            label1.Size = new Size(63, 24);
            label1.TabIndex = 3;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(104, 128);
            label2.Name = "label2";
            label2.Size = new Size(77, 24);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(104, 206);
            label3.Name = "label3";
            label3.Size = new Size(51, 24);
            label3.TabIndex = 5;
            label3.Text = "Роль";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(132, 323);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(141, 39);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddAccounts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 387);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxRole);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxLogin);
            Name = "AddAccounts";
            Text = "AddAccounts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxPass;
        private ComboBox comboBoxRole;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAdd;
    }
}