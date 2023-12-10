namespace arm_rental
{
    public partial class Autorization_Form : Form
    {
        static public string pass, log, whoIs;
        SqlCommands commands = new SqlCommands();
        public Autorization_Form()
        {
            InitializeComponent();
            tbPassword.PasswordChar = 'ï';
            tbPassword.UseSystemPasswordChar = checkBox1.Checked;
        }



        private void Autorization_Load(object sender, EventArgs e)
        {
            commands.Connection();
            CenterToScreen();
            checkBox1.Checked = true;
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Text;
            var p = Autorization.NewHash(Autorization.GenerateHash(password));
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {
                Autorization.AutorizationMethod(login, password);
                switch (Autorization.role)
                {
                    case null:
                        MessageBox.Show("œÓÎ¸ÁÓ‚‡ÚÂÎ¸ ÌÂ Ì‡È‰ÂÌ!");
                        break;
                    case "admin":
                        if (login == Autorization.login_a && Autorization.NewHash(Autorization.GenerateHash(password)) == Autorization.password_a)
                        {
                            whoIs = "admin";
                            pass = Autorization.password_a;
                            log = Autorization.login_a;
                            mainF mainF = new mainF();
                            mainF.Show();
                            mainF.listBoxFree.Visible = false;
                            mainF.label2.Visible = false;
                            mainF.buttonAddArenda.Visible = false;

                            //this.Hide();
                        }
                        break;
                    case "client":
                        if (login == Autorization.login_a && Autorization.NewHash(Autorization.GenerateHash(password)) == Autorization.password_a)
                        {
                            whoIs = "client";
                            pass = Autorization.password_a;
                            log = Autorization.login_a;
                            mainF mainF = new mainF();
                            mainF.Show();
                            mainF.ÍÎËÂÌÚ˚ToolStripMenuItem.Visible = false;
                            mainF.listBoxInventories.Visible = false;
                            mainF.buttonAdd.Visible = false;
                            mainF.label1.Visible = false;
                            mainF.ËÌ‚ÂÌÚ‡¸ToolStripMenuItem.Visible = false;
                            mainF.Í‡ÚÂ„ÓËˇ»Ì‚ÂÌÚ‡ˇToolStripMenuItem.Visible = false;
                            mainF.‰‡ÌÌ˚ÂToolStripMenuItem.Visible=false;
                            //this.Hide();
                        }
                        break;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = ((CheckBox)sender).Checked;
        }

        private void Autorization_Form_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Autorization_Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}