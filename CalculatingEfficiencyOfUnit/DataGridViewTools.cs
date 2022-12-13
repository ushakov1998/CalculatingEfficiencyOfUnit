using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatingEfficiencyOfUnit
{
    /// <summary>
    /// Класс для манипуляций с таблицами 
    /// </summary>
    class DataGridViewTools
    {
        public static void CreateTableForProtocol(DataGridView dataGridView)
        {
            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "type";
            dataGridView.Columns.Add(imgColumn);
            dataGridView.Columns.Add("message", "Сообщение");
            dataGridView.Columns["type"].Width = 25;
            dataGridView.Columns["message"].Width = 800;
            dataGridView.Columns["message"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView.Columns["type"].CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns["type"].Frozen = false;
            dataGridView.Columns["message"].Frozen = false;
            dataGridView.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;

            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.ColumnHeadersVisible = false;
            dataGridView.ScrollBars = ScrollBars.Both;
        }
    }
}
