namespace arm_rental
{
    partial class Autorization_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbPassword = new TextBox();
            tbLogin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonSignUp = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.Location = new Point(77, 314);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(238, 36);
            tbPassword.TabIndex = 0;
            // 
            // tbLogin
            // 
            tbLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbLogin.Location = new Point(77, 184);
            tbLogin.Multiline = true;
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(238, 34);
            tbLogin.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(103, 64);
            label1.Name = "label1";
            label1.Size = new Size(190, 39);
            label1.TabIndex = 2;
            label1.Text = "Авторизация";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(77, 153);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 3;
            label2.Text = "Логин";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(77, 283);
            label3.Name = "label3";
            label3.Size = new Size(86, 28);
            label3.TabIndex = 4;
            label3.Text = "Пароль";
            // 
            // buttonSignUp
            // 
            buttonSignUp.Location = new Point(118, 478);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(165, 40);
            buttonSignUp.TabIndex = 5;
            buttonSignUp.Text = "Войти";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(181, 379);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(150, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Показать пароль";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Autorization_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 554);
            Controls.Add(checkBox1);
            Controls.Add(buttonSignUp);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbLogin);
            Controls.Add(tbPassword);
            Name = "Autorization_Form";
            Text = "Form1";
            FormClosing += Autorization_Form_FormClosing;
            FormClosed += Autorization_Form_FormClosed;
            Load += Autorization_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPassword;
        private TextBox tbLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonSignUp;
        private CheckBox checkBox1;
    }
}