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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                {
                    Form1 main = this.Owner as Form1;
                    if (main != null)
                    {

                        DataRow nRow = main.databaseDataSet.Tables[0].NewRow();
                        int rc = main.dataGridView1.RowCount + 1;
                        nRow[0] = rc;
                        nRow[1] = textBox1.Text;
                        nRow[2] = richTextBox1.Text;
                        nRow[3] = textBox3.Text;

                        main.databaseDataSet.Tables[0].Rows.Add(nRow);
                        main.notesTableAdapter.Update(main.databaseDataSet);
                        main.databaseDataSet.Tables[0].AcceptChanges();
                        main.dataGridView1.Refresh();

                        textBox1.Text = "";
                        richTextBox1.Text = "";
                        textBox3.Text = "";
                    }
                }
            }
        }
    }
}
