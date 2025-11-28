using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class DetailForm : Form
    {
        private DataRow row;

        public DetailForm(DataRow dataRow)
        {
            InitializeComponent();
            this.row = dataRow;

            textBox1.Text = row["titles"].ToString();
            richTextBox1.Text = row["content"].ToString();
            textBox2.Text = row["data"].ToString();
            // добавьте для всех нужных полей
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Обновляем DataRow значениями из текстовых полей
            row["titles"] = textBox1.Text;
            row["content"] = richTextBox1.Text;
            row["data"] = textBox2.Text;
            // добавьте для всех нужных полей

            this.DialogResult = DialogResult.OK;
            this.Close();


        }
    }
}
