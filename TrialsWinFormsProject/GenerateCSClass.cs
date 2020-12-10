using ClassLibraryProject.Models.CSGeneration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrialsWinFormsProject
{
    public partial class GenerateCSClass : Form
    {
        private List<String> Types = new List<string>
        {
            "int",
            "double",
            "long",
            "String",
            "float",
            "Guid",
            "DateTime"
        };

        private CSClass CSClass;

        public GenerateCSClass()
        {
            InitializeComponent();
            CSClass = new CSClass();
        }

        private void CloseButotn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GenerateCSClass_Load(object sender, EventArgs e)
        {
            DataGridViewComboBoxCell cbCell = (DataGridViewComboBoxCell)PropertiesDataGridView.Rows[0].Cells[0];
            Types.ForEach(type => cbCell.Items.Add(type));
        }

        private void PropertiesDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridViewComboBoxCell cbCell = (DataGridViewComboBoxCell)PropertiesDataGridView.Rows[e.RowIndex].Cells[0];
            Types.ForEach(type => cbCell.Items.Add(type));
        }

        private void PropertiesDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                var text = PropertiesDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                Types.Add(text);
                DataGridViewComboBoxCell cbCell = (DataGridViewComboBoxCell)PropertiesDataGridView.Rows[e.RowIndex + 1].Cells[0];
                cbCell.Items.Clear();
                Types.Distinct().ToList().ForEach(type => cbCell.Items.Add(type));
            }

            if (e.ColumnIndex == 2)
            {
                if (ValidateRow(e.RowIndex))
                {
                    var csClass = new CSClassProperty
                    {
                        Type = PropertiesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(),
                        Name = PropertiesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString(),
                        Namespace = PropertiesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString()
                    };
                    CSClass.Properties.Add(csClass);
                }
            }

        }

        private bool ValidateRow(int RowIndex)
        {
            return !String.IsNullOrEmpty(PropertiesDataGridView.Rows[RowIndex].Cells[0].Value.ToString()) && String.IsNullOrEmpty(PropertiesDataGridView.Rows[RowIndex].Cells[1].Value.ToString()) && String.IsNullOrEmpty(PropertiesDataGridView.Rows[RowIndex].Cells[2].Value.ToString());
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                CSClass.Path = ClassPathTextBox.Text;
                CSClass.Header.ClassName = Path.GetFileNameWithoutExtension(CSClass.Path);
                CSClass.Header.NameSpace = NameSpaceTextBox.Text;
                CSClass.Header.Usings = CSClass.Properties.Select(prop => prop.Namespace).ToList();
                PreviewTextBox.Text = CSClass.ToString();
            }
            else
                MessageBox.Show("Verify your inputs!");
        }

        private new bool Validate()
        {
            return !String.IsNullOrEmpty(ClassPathTextBox.Text) && !String.IsNullOrEmpty(NameSpaceTextBox.Text) && ClassPathTextBox.Text.ToLower().EndsWith(".cs");
        }
    }
}