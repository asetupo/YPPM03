using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Загрузка данных
            this.notesTableAdapter.Fill(this.databaseDataSet.Notes);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Открытие формы Form2 (предположим, это создание новой записи)
            Form2 af = new Form2();
            af.Owner = this;
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Сохранение изменений в базе
            notesTableAdapter.Update(databaseDataSet);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Редактируем выбранную строку
            if (dataGridView1.CurrentRow != null)
            {
                DataRowView drv = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
                DetailForm detailForm = new DetailForm(drv.Row);

                if (detailForm.ShowDialog() == DialogResult.OK)
                {
                    // После успешного редактирования сохраняем изменения
                    this.notesTableAdapter.Update(this.databaseDataSet.Notes);
                    // Обновляем таблицу
                    this.notesTableAdapter.Fill(this.databaseDataSet.Notes);
                }
            }
            else
            {
                MessageBox.Show("Выберите строку для редактирования");
            }
        }
    }
}
