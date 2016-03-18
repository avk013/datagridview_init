 private void dginit(DataGridView datagridname, int max_column, int max_row, int begin_num=0)
 {datagridname.Rows.Clear();
 datagridname.Columns.Clear();
 int stro = 0;
 for (int i = begin_num; i <= max_column; i++) datagridname.Columns.Add("Column", i.ToString());
 for (int i = begin_num; i < max_row; i++) datagridname.Rows.Add();
 for (int i = begin_num; i <= max_row; i++) datagridname.Rows[stro++].HeaderCell.Value = i.ToString();
 datagridname.AutoResizeColumns();}
