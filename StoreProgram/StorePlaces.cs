using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreProgram
{
    public partial class StorePlaces : Form
    {

        MySqlConnection dbconnection;
        DataGridViewRow StoreRow=null,StorePlace=null;

        public StorePlaces(DataGridViewRow StoreRow)
        {
            InitializeComponent();
            dbconnection = new MySqlConnection(connection.connectionString);
            this.StoreRow = StoreRow;
            labStoreName.Text = StoreRow.Cells[1].Value.ToString();
        }

        private void StorePlaces_Load(object sender, EventArgs e)
        {
            try
            {
                dbconnection.Open();
                displayStorePlaces();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dbconnection.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                dbconnection.Open();
                string query = "select Store_Place_Code from store_places where Store_Place_Code='" + txtName.Text + "'";
                MySqlCommand com = new MySqlCommand(query, dbconnection);

                if (com.ExecuteScalar() == null)
                {
                    if (txtName.Text != "")
                    {
                        string qeury = "insert into store_places (Store_Place_Code,Store_ID)values(@StorePlaceCode,@StoreID)";
                        com = new MySqlCommand(qeury, dbconnection);
                        com.Parameters.Add("@StorePlaceCode", MySqlDbType.VarChar, 255);
                        com.Parameters["@StorePlaceCode"].Value = txtName.Text;
                        com.Parameters.Add("@StoreID", MySqlDbType.VarChar, 255);
                        com.Parameters["@StoreID"].Value = StoreRow.Cells[0].Value;
                        

                        com.ExecuteNonQuery();
                        MessageBox.Show("add success");
                        displayStorePlaces();

                    }
                    else
                    {
                        MessageBox.Show("enter Name");
                    }
                }
                else
                {
                    MessageBox.Show("This Store already exist");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            dbconnection.Close();
        }
        private void btnDeleteStorePlace_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnection.Open();
                if (StorePlace != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the item?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        
                        string query = "delete from store_places where Store_Place_Code='" + StorePlace.Cells[0].Value.ToString()+"'";
                        MySqlCommand com = new MySqlCommand(query, dbconnection);
                        com.ExecuteNonQuery();
                        displayStorePlaces();
                    }
                    else if (dialogResult == DialogResult.No)
                    { }
                }
                else
                {
                    MessageBox.Show("select row");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dbconnection.Close();
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String query = "select Store_Place_Code as 'أماكن التخزين'  from store_places where Store_Place_Code like'" + txtName.Text + "%'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbconnection);
                DataTable dtaple = new DataTable();
                adapter.Fill(dtaple);
                dataGridViewStorePlace.DataSource = dtaple;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridViewStorePlace_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                StorePlace = dataGridViewStorePlace.Rows[dataGridViewStorePlace.SelectedCells[0].RowIndex];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        //functions
        //display store places
        public void displayStorePlaces()
        {
            String query = "select Store_Place_Code as 'أماكن التخزين' from store_places where Store_ID=" + StoreRow.Cells[0].Value;
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, dbconnection);
            DataTable dtaple = new DataTable();
            adapter.Fill(dtaple);
            dataGridViewStorePlace.DataSource = dtaple;
        }
        
    }
}
