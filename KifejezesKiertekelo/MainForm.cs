using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KifejezesKiertekelo
{
    public partial class MainForm : Form
    {
        Analyzer a1;
        private Expression expression;

        private const int COLUMNSIZE = 75;
        private const float EXPRESSION_SIZE = 17.0f;
        private const string EXPRESSION_STYLE = "Times new Roman";
        private Font ExpressionFont = new Font(EXPRESSION_STYLE, EXPRESSION_SIZE);
        private string DataFileName;
        private string separator = ";";

        public MainForm()
        {
            InitializeComponent();
            a1 = new Analyzer(this);
            textBox_basicExpression.Font = ExpressionFont;
        }

        private void InitializeDatagridview()
        {
            dataGridView.DataSource = null;
            dataGridView.Refresh();

            FillDatagridView(DataFileName, separator);

            dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            MakeColumnsUnsortable();
            InsertDividers();
            ResizeRows();
            dataGridView.Refresh();
            
        }

        private void FillDatagridView(string filename, string separator)
        {
            DataTable dt = CsvImport.NewDataTable(filename, separator, false);
            dataGridView.DataSource = dt;
        }

        private void InsertDividers()
        {
            dataGridView.ColumnHeadersVisible = false;
            dataGridView.Rows[0].DividerHeight = 3;
        }

        private void MakeColumnsUnsortable()
        {
            foreach (DataGridViewColumn dgvc in dataGridView.Columns)
            {
                dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void FillStack(string value)
        {
            this.a1.fillStack(value);
        }

        private void dataGridView_SizeChanged(object sender, EventArgs e)
        {
            ResizeRows();
        }

        private void ResizeRows()
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Height = (dataGridView.ClientRectangle.Height - dataGridView.ColumnHeadersHeight) / dataGridView.Rows.Count;
                // row.Height = (dataGridView.ClientRectangle.Height - dataGridView.ColumnHeadersHeight) / 13;
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            richTextBox_steps.Text = "";
            ReformatInput(textBox_basicExpression.Text);
            expression = new Expression(textBox_basicExpression.Text);
            FillStack(expression.FirstPart);

            richTextBox_steps.Text = expression.ToString() + "\n";

            if (a1.Analyze(dataGridView, expression)) textBox_result.Text = "Sikeres kiértékelés";
            else textBox_result.Text = "Sikertelen kiértékelés";

        }

        public void UpdateStepTextBox(string text)
        {
            richTextBox_steps.AppendText(text + "\n");
        }

        private void button_restart_Click(object sender, EventArgs e)
        {
            restart();
        }
        private void restart()
        {

            System.Diagnostics.Process.Start(Application.ExecutablePath);
            this.Close();
        }

        private void ReformatInput(string input)
        {
            string newInput = Regex.Replace(input, "[^0-9a-zA-Z+*]+", "");
            newInput = Regex.Replace(newInput, @"\d{2,}", "i");
            newInput = Regex.Replace(newInput, @"\d", "i");
            textBox_basicExpression.Text = newInput;
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            SaveDataGridViewToCSV();
        }

        private void button_openFile_Click(object sender, EventArgs e)
        {
            Stream fileStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK && (fileStream = openFileDialog.OpenFile()) != null)
            {
                this.DataFileName = openFileDialog.FileName;
                using (fileStream)
                {
                    //FillDatagridView(this.DataFileName, separator);
                    InitializeDatagridview();
                }
            }
        }

        private void SaveDataGridViewToCSV()
        {
            var sb = new StringBuilder();

            var headers = dataGridView.Columns.Cast<DataGridViewColumn>();
            sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                var cells = row.Cells.Cast<DataGridViewCell>();
                sb.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName, false))
                {
                    sw.WriteLine(sb.ToString());
                }
            }

            MessageBox.Show("Sikeres exportálás.");
        }
    }

}

