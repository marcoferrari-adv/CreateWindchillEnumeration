using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateWindchillEnumeration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<Dictionary<string, object>> tableRows = new List<Dictionary<string, object>>();
            errorProvider1.Clear();
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            Boolean validationError = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var currentRowInternalValue = row.Cells["InternalValue"].Value as string;
                if (string.IsNullOrEmpty(currentRowInternalValue))
                {
                    continue;
                }

                Dictionary<string, object> tableRow = new Dictionary<string, object>();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (string.Equals(cell.OwningColumn.Name, "InternalValue"))
                    {
                        if (!ValidationHelper.isInternalValueValid(cell.Value as string))
                        {
                            cell.ErrorText = "Invalid format only letters, digit, '-' and '_' are allowed";
                            validationError = true;
                        }
                    }
                    else if (string.Equals(cell.OwningColumn.Name, "MasterText"))
                    {
                        if (string.IsNullOrEmpty(cell.Value as string))
                        {
                            cell.ErrorText = "A master text needs to be specified";
                            validationError = true;
                        }
                    }
                    tableRow.Add(cell.OwningColumn.Name, cell.Value);
                }
                tableRows.Add(tableRow);
            }

            if (!ValidationHelper.isInternalValueValid(internalNameEnum.Text))
            {
                errorProvider1.SetError(internalNameEnum, "Invalid format only letters, digit, '-' and '_' are allowed");
                validationError = true;
            }

            if (string.IsNullOrEmpty(containerDomain.Text))
            {
                errorProvider1.SetError(containerDomain, "Value is required");
                validationError = true;
            }

            if (string.IsNullOrEmpty(organizerName.Text))
            {
                errorProvider1.SetError(organizerName, "Value is required");
                validationError = true;
            }

            if (string.IsNullOrEmpty(valueDisplayName.Text))
            {
                errorProvider1.SetError(valueDisplayName, "Value is required");
                validationError = true;
            }

            if (validationError)
                return;

            DialogResult result = saveFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                
                if (tableRows.Count > 0)
                {
                    WindchillEnumerationRequest request = new WindchillEnumerationRequest()
                    {
                        InternalNameEnum = internalNameEnum.Text,
                        ContainerDomain = containerDomain.Text,
                        OrganizerName = organizerName.Text,
                        ValueDisplayName = valueDisplayName.Text,
                        ValueSort = valueSort.Checked,
                        TableRows = tableRows,
                    };
                    WindchillEnumerationLoaderBuilder builder = new WindchillEnumerationLoaderBuilder(request);
                    builder.Save(saveFileDialog.FileName);
                    MessageBox.Show("Save Completed", "Save completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void AddLocaleBtn_Click(object sender, EventArgs e)
        {
            var selectedLocale = LocaleCombo.SelectedItem is not null ? LocaleCombo.SelectedItem.ToString() : null;
            if(!string.IsNullOrEmpty(selectedLocale))
            {
                string columnName = $"Display_{selectedLocale}";
                if(!dataGridView1.Columns.Contains(columnName))
                {
                    DataGridViewColumn newColumn = new DataGridViewColumn
                    {
                        Name = columnName,
                        HeaderText = $"Display {selectedLocale}",
                        Visible = true,
                        SortMode = DataGridViewColumnSortMode.NotSortable
                    };
                    newColumn.CellTemplate = new DataGridViewTextBoxCell();

                    dataGridView1.Columns.Add(newColumn);
                }
                    
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {
                DataObject o = (DataObject) Clipboard.GetDataObject();
                if (o.GetDataPresent(DataFormats.Text))
                {
                    
                    var rowStartIndex = dataGridView1.CurrentRow.Index;
                    var cellStartIndex = dataGridView1.CurrentCell.ColumnIndex;
                    var clipboardText = o.GetData(DataFormats.Text).ToString();
                    string[] pastedRows = Regex.Split(clipboardText.TrimEnd("\r\n".ToCharArray()), "\r\n");

                    if((rowStartIndex + pastedRows.Length) > dataGridView1.Rows.Count)
                    {
                       
                        dataGridView1.AllowUserToAddRows = false;
                        dataGridView1.Rows.Insert(rowStartIndex , (rowStartIndex + pastedRows.Length) - dataGridView1.Rows.Count);
                        dataGridView1.AllowUserToAddRows = true;
                    }                 
                   
                    for(int i = rowStartIndex; i < (rowStartIndex + pastedRows.Length); i++)
                    {
                        string[] pastedRowCells = pastedRows[i - rowStartIndex].Split(new char[] { '\t' });
                        using (DataGridViewRow myDataGridViewRow = dataGridView1.Rows[i])
                        {
                            for (int j = 0; j < pastedRowCells.Length; j++)
                            {
                                if (myDataGridViewRow.Cells.Count > j + cellStartIndex)
                                {
                                    myDataGridViewRow.Cells[j + cellStartIndex].Value = pastedRowCells[j];
                                }
                            }
                        }
                    }

                    dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
                }
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List< DataGridViewColumn> columnsToRemove = new List<DataGridViewColumn>();
            foreach(DataGridViewColumn column in dataGridView1.Columns)
            {
                if(column.Name.StartsWith("Display_"))
                    columnsToRemove.Add(column);
                  
            }

            foreach (var column in columnsToRemove)
            {
                dataGridView1.Columns.Remove(column);
            }

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RemoveLocaleBtn_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewColumn column in dataGridView1.SelectedColumns)
            {
                if(column.Name.StartsWith("Display_"))
                {
                    dataGridView1.Columns.RemoveAt(column.Index);
                    dataGridView1.Refresh();
                }
            }
        }

        private void textbox_MouseHover(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if(control is not null)
            {
                switch(control.Name)
                {
                    case "containerDomain":
                        toolTip1.SetToolTip(control, "Nome del dominio dell'applicazione rovesciato. E.s. com.ptc");
                        break;
                    case "internalNameEnum":
                        toolTip1.SetToolTip(control, "Nome interno dell'enumerativo");
                        break;
                    case "organizerName":
                        toolTip1.SetToolTip(control, "Nome interno della folder in cui creare l'enumerativo");
                        break;
                    case "valueDisplayName":
                        toolTip1.SetToolTip(control, "Display dell'enumerativo");
                        break;
                }
                
            }
            
        }
    }
}
