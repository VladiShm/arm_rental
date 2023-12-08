using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arm_rental
{
    public partial class mainF : Form
    {
        public mainF()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAccounts addAccounts = new AddAccounts();
            addAccounts.Show();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
