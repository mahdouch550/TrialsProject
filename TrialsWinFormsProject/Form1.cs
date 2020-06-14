using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrialsWinFormsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CloseButtonClicked(object sender, EventArgs e)
        {
            /*The program doesn't actually stop, it only closes the active window
            //Close();
            Hide();*/
            //This Code line closes the whole application
            Application.Exit();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(FNameTextBox.Text) && !String.IsNullOrEmpty(LNameTextBox.Text) && !String.IsNullOrEmpty(AgeTextBox.Text) && !String.IsNullOrEmpty(IDTextBox.Text))
            {
                //All inputs are filled
                var cn = new SqlConnection(@"Data Source=MAHDI-KHARDANI\SQLEXPRESS;Initial Catalog=DataServices;Integrated Security=True");
                cn.Open();
                
                
                var cmd = new SqlCommand();
                cmd.Connection = cn;

                var sqlQuery = "insert into personne values ('"+ FNameTextBox.Text + "','"+ LNameTextBox.Text + "',"+ AgeTextBox.Text+","+ IDTextBox.Text+")";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sqlQuery;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ligne ajoutée avec succés", "Succés!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                //At least one of the inputs is empty
                MessageBox.Show("Veuillez vérifier tous les champs!", "Erreur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}