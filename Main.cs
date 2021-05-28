using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_collection_of_books_on_programming
{
    public partial class Main : Form
    {
        public static Main main;
        public Main()
        {
            InitializeComponent();
            main = this;
        }

        private void книгиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Book().Show();
            this.Hide();
        }

        private void авторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Autor().Show();
            this.Hide();
        }

        private void издателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Publisher().Show();
            this.Hide();
        }

        private void языкиПрограммированияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Language().Show();
            this.Hide();
        }
    }
}
