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
    public partial class Autor : Form
    {
        public Autor()
        {
            InitializeComponent();
        }

        private void Autor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }

        private void Autor_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Авторы". При необходимости она может быть перемещена или удалена.
            this.авторыTableAdapter.Fill(this.databaseDataSet.Авторы);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\n" +
               "Продолжить сохранение?",
               "Подтвердите сохранение",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    авторыTableAdapter.Update(databaseDataSet.Авторы);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
