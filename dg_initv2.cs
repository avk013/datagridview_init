using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        { InitializeComponent(); }

        private void button1_Click(object sender, EventArgs e)
        {           
         for (int i = 0; i < dataGridView1.RowCount; i++)
         for (int j = 0; j < dataGridView1.ColumnCount; j++)
         dataGridView1.Rows[i].Cells[j].Value = (i * j+1).ToString();
         dataGridView1.AutoResizeColumns();
        
        }

        private void dginit(DataGridView datagridname, int max_column, int max_row, int begin_num=0)
        {
           // DataGridViewColumn[] columns = new DataGridViewColumn[50000];
        datagridname.Rows.Clear();
        datagridname.Columns.Clear();
        int stro = 0, nom=0;
        for (int i = begin_num; i <= max_column; i++) { datagridname.Columns.Add("Column", i.ToString()); 
            datagridname.Columns[nom++].FillWeight = 1; 
          };
        for (int i = begin_num; i < max_row; i++) datagridname.Rows.Add();
        for (int i = begin_num; i <= max_row; i++) datagridname.Rows[stro++].HeaderCell.Value = i.ToString();
         datagridname.AutoResizeColumns();}

        private void Form1_Load(object sender, EventArgs e)
        {dginit(dataGridView1, 1650, 8,1);}
    }
}

