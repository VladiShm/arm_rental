namespace arm_rental
{
    partial class mainF
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
            menuStrip1 = new MenuStrip();
            клиентыToolStripMenuItem = new ToolStripMenuItem();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            инвентарьToolStripMenuItem = new ToolStripMenuItem();
            добавитьToolStripMenuItem1 = new ToolStripMenuItem();
            редактироватьToolStripMenuItem1 = new ToolStripMenuItem();
            удалитьToolStripMenuItem1 = new ToolStripMenuItem();
            категорияИнвентаряToolStripMenuItem = new ToolStripMenuItem();
            добавитьToolStripMenuItem2 = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            редактироватьToolStripMenuItem = new ToolStripMenuItem();
            данныеToolStripMenuItem = new ToolStripMenuItem();
            отчетToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            buttonAdd = new Button();
            button1 = new Button();
            listBoxInventories = new ListBox();
            listBoxFree = new ListBox();
            buttonAddArenda = new Button();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { клиентыToolStripMenuItem, инвентарьToolStripMenuItem, категорияИнвентаряToolStripMenuItem, данныеToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // клиентыToolStripMenuItem
            // 
            клиентыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem });
            клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            клиентыToolStripMenuItem.Size = new Size(83, 24);
            клиентыToolStripMenuItem.Text = "Клиенты";
            клиентыToolStripMenuItem.Click += клиентыToolStripMenuItem_Click;
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(159, 26);
            добавитьToolStripMenuItem.Text = "Добавить";
            добавитьToolStripMenuItem.Click += добавитьToolStripMenuItem_Click;
            // 
            // инвентарьToolStripMenuItem
            // 
            инвентарьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem1, редактироватьToolStripMenuItem1, удалитьToolStripMenuItem1 });
            инвентарьToolStripMenuItem.Name = "инвентарьToolStripMenuItem";
            инвентарьToolStripMenuItem.Size = new Size(99, 24);
            инвентарьToolStripMenuItem.Text = "Инвентарь";
            // 
            // добавитьToolStripMenuItem1
            // 
            добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            добавитьToolStripMenuItem1.Size = new Size(194, 26);
            добавитьToolStripMenuItem1.Text = "Добавить";
            добавитьToolStripMenuItem1.Click += добавитьToolStripMenuItem1_Click;
            // 
            // редактироватьToolStripMenuItem1
            // 
            редактироватьToolStripMenuItem1.Name = "редактироватьToolStripMenuItem1";
            редактироватьToolStripMenuItem1.Size = new Size(194, 26);
            редактироватьToolStripMenuItem1.Text = "Редактировать";
            // 
            // удалитьToolStripMenuItem1
            // 
            удалитьToolStripMenuItem1.Name = "удалитьToolStripMenuItem1";
            удалитьToolStripMenuItem1.Size = new Size(194, 26);
            удалитьToolStripMenuItem1.Text = "Удалить";
            удалитьToolStripMenuItem1.Click += удалитьToolStripMenuItem1_Click;
            // 
            // категорияИнвентаряToolStripMenuItem
            // 
            категорияИнвентаряToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьToolStripMenuItem2, удалитьToolStripMenuItem, редактироватьToolStripMenuItem });
            категорияИнвентаряToolStripMenuItem.Name = "категорияИнвентаряToolStripMenuItem";
            категорияИнвентаряToolStripMenuItem.Size = new Size(173, 24);
            категорияИнвентаряToolStripMenuItem.Text = "Категория инвентаря";
            // 
            // добавитьToolStripMenuItem2
            // 
            добавитьToolStripMenuItem2.Name = "добавитьToolStripMenuItem2";
            добавитьToolStripMenuItem2.Size = new Size(194, 26);
            добавитьToolStripMenuItem2.Text = "Добавить";
            добавитьToolStripMenuItem2.Click += добавитьToolStripMenuItem2_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(194, 26);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // редактироватьToolStripMenuItem
            // 
            редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            редактироватьToolStripMenuItem.Size = new Size(194, 26);
            редактироватьToolStripMenuItem.Text = "Редактировать";
            редактироватьToolStripMenuItem.Click += редактироватьToolStripMenuItem_Click;
            // 
            // данныеToolStripMenuItem
            // 
            данныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { отчетToolStripMenuItem });
            данныеToolStripMenuItem.Name = "данныеToolStripMenuItem";
            данныеToolStripMenuItem.Size = new Size(78, 24);
            данныеToolStripMenuItem.Text = "Данные";
            // 
            // отчетToolStripMenuItem
            // 
            отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            отчетToolStripMenuItem.Size = new Size(131, 26);
            отчетToolStripMenuItem.Text = "Отчет";
            отчетToolStripMenuItem.Click += отчетToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 60);
            label1.Name = "label1";
            label1.Size = new Size(195, 31);
            label1.TabIndex = 2;
            label1.Text = "Сейчас в аренде";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(25, 530);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(179, 46);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Добавить аренду";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.free_icon_loading_arrows_81948;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(223, 530);
            button1.Name = "button1";
            button1.Size = new Size(45, 46);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBoxInventories
            // 
            listBoxInventories.FormattingEnabled = true;
            listBoxInventories.ItemHeight = 20;
            listBoxInventories.Location = new Point(25, 105);
            listBoxInventories.Name = "listBoxInventories";
            listBoxInventories.Size = new Size(427, 384);
            listBoxInventories.TabIndex = 5;
            // 
            // listBoxFree
            // 
            listBoxFree.FormattingEnabled = true;
            listBoxFree.ItemHeight = 20;
            listBoxFree.Location = new Point(25, 85);
            listBoxFree.Name = "listBoxFree";
            listBoxFree.Size = new Size(572, 424);
            listBoxFree.TabIndex = 6;
            // 
            // buttonAddArenda
            // 
            buttonAddArenda.Location = new Point(29, 527);
            buttonAddArenda.Name = "buttonAddArenda";
            buttonAddArenda.Size = new Size(175, 52);
            buttonAddArenda.TabIndex = 7;
            buttonAddArenda.Text = "Взять в аренду";
            buttonAddArenda.UseVisualStyleBackColor = true;
            buttonAddArenda.Click += buttonAddArenda_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 29);
            label2.Name = "label2";
            label2.Size = new Size(260, 31);
            label2.TabIndex = 8;
            label2.Text = "Доступно для аренды";
            // 
            // mainF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 588);
            Controls.Add(label2);
            Controls.Add(buttonAddArenda);
            Controls.Add(listBoxFree);
            Controls.Add(listBoxInventories);
            Controls.Add(button1);
            Controls.Add(buttonAdd);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "mainF";
            Text = "mainF";
            Load += mainF_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        public ToolStripMenuItem клиентыToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem1;
        private ToolStripMenuItem добавитьToolStripMenuItem2;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem редактироватьToolStripMenuItem;
        private ToolStripMenuItem редактироватьToolStripMenuItem1;
        private ToolStripMenuItem удалитьToolStripMenuItem1;
        public ToolStripMenuItem данныеToolStripMenuItem;
        private ToolStripMenuItem отчетToolStripMenuItem;
        public Label label1;
        public ToolStripMenuItem инвентарьToolStripMenuItem;
        public ToolStripMenuItem категорияИнвентаряToolStripMenuItem;
        public ListBox listBoxInventories;
        public Button buttonAdd;
        public ListBox listBoxFree;
        public Label label2;
        public Button button1;
        public Button buttonAddArenda;
    }
}