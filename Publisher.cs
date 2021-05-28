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
    public partial class Publisher : Form
    {
        public Publisher()
        {
            InitializeComponent();
        }

        private void Publisher_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }

        private void Publisher_Load(object sender, EventArgs e)
        {            
            loadData();
        }

        private void loadData()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Издательства". При необходимости она может быть перемещена или удалена.
            this.издательстваTableAdapter.Fill(this.databaseDataSet.Издательства);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\n" +
               "Продолжить сохранение?",
               "Подтвердите сохранение",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    издательстваTableAdapter.Update(databaseDataSet.Издательства);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
