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
    public partial class Book : Form
    {
        public Book()
        {
            InitializeComponent();
        }

        private void Book_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.main.Show();
        }

        private void Book_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Издательства". При необходимости она может быть перемещена или удалена.
            this.издательстваTableAdapter.Fill(this.databaseDataSet.Издательства);
            loadData();
        }

        private void loadData()
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Авторы". При необходимости она может быть перемещена или удалена.
            this.авторыTableAdapter.Fill(this.databaseDataSet.Авторы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Языки". При необходимости она может быть перемещена или удалена.
            this.языкиTableAdapter.Fill(this.databaseDataSet.Языки);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Языки_книг". При необходимости она может быть перемещена или удалена.
            this.языки_книгTableAdapter.Fill(this.databaseDataSet.Языки_книг);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Авторы_книг". При необходимости она может быть перемещена или удалена.
            this.авторы_книгTableAdapter.Fill(this.databaseDataSet.Авторы_книг);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.databaseDataSet.Книги);

            dataGridView1.RowTemplate.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void dataGridView3_DataError(object sender, DataGridViewDataErrorEventArgs e){ }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e){ }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\n" +
              "Продолжить сохранение?",
              "Подтвердите сохранение",
              MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    авторы_книгTableAdapter.Update(databaseDataSet.Авторы_книг);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\n" +
              "Продолжить сохранение?",
              "Подтвердите сохранение",
              MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    языки_книгTableAdapter.Update(databaseDataSet.Языки_книг);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void toolStripButton15_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Все изменения в системе будут сохранены в базе данных.\r\n" +
              "Продолжить сохранение?",
              "Подтвердите сохранение",
              MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    книгиTableAdapter.Update(databaseDataSet.Книги);
                    MessageBox.Show("Изменения сохранены");
                    loadData();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
