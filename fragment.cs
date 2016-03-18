private void dg(DataGridView datagridname, int max_column, int max_row)
{int min = 0;//0;
  for (int i = min; i < max_column + min; i++) datagridname.Columns.Add("Column", i.ToString());
  for (int i = min; i < max_row ; i++) datagridname.Rows.Add();
  for (int i = min; i <= max_row ; i++) datagridname.Rows[i - min].HeaderCell.Value = i.ToString();
datagridname.AutoResizeColumns();}
