namespace arm_rental
{
    partial class DeleteClients
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
            comboBoxClient = new ComboBox();
            buttonDel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 106);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Клиент";
            // 
            // comboBoxClient
            // 
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(66, 129);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(270, 28);
            comboBoxClient.TabIndex = 1;
            // 
            // buttonDel
            // 
            buttonDel.Location = new Point(111, 241);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(155, 51);
            buttonDel.TabIndex = 2;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            buttonDel.Click += buttonDel_Click;
            // 
            // DeleteClients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 335);
            Controls.Add(buttonDel);
            Controls.Add(comboBoxClient);
            Controls.Add(label1);
            Name = "DeleteClients";
            Text = "DeleteClients";
            Load += DeleteClients_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxClient;
        private Button buttonDel;
    }
}