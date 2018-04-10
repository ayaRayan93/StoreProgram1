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
    public partial class Stores : Form
    {
        MySqlConnection dbconnection;
        DataGridViewRow row = null;
        StorePlaces storePlaces = null;
        public Stores()
        {
            InitializeComponent();
            dbconnection = new MySqlConnection(connection.connectionString);
        }
        private void Stores_Load(object sender, EventArgs e)
        {
            try
            {
                dbconnection.Open();
                DisplayStores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            dbconnection.Close();
        }
        private void btnAddStore_Click(object sender, EventArgs e)
        {
            try
            {
                Store_Record f = new Store_Record();
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateStore_Click(object sender, EventArgs e)
        {
            try
            {
                Store_Update f = new Store_Update(1);
                f.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteStore_Click(object sender, EventArgs e)
        {
            try
            {
                if (row != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the item?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dbconnection.Open();
                        string Query = "delete from store where Store_ID=" + row.Cells[0].Value;
                        MySqlCommand MyCommand = new MySqlCommand(Query, dbconnection);
                        MyCommand.ExecuteNonQuery();
                       // MessageBox.Show("Delete Done");
                        DisplayStores();
                    }
                    else if (dialogResult == DialogResult.No)
                    { }
                }
                else
                {
                    MessageBox.Show("Select Row");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            dbconnection.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                row = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                row.Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddStorePlaces_Click(object sender, EventArgs e)
        {
            try
            {
                if (row != null)
                {
                    if (storePlaces == null)
                    {
                        storePlaces = new StorePlaces(row);
                        storePlaces.Show();
                    }
                    else
                    {
                        storePlaces.Close();
                        storePlaces = new StorePlaces(row);
                        storePlaces.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Select Row");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //functions
        //display stores
        public void DisplayStores()
        {
            dataGridView1.Rows.Clear();
            string qeury = "select * from store";
            MySqlCommand com = new MySqlCommand(qeury, dbconnection);
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["Store_ID"].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells["Store_Name"].Value = dr[1].ToString();
                dataGridView1.Rows[n].Cells["Store_Address"].Value = dr[2].ToString();
                dataGridView1.Rows[n].Cells["Store_Phone"].Value = dr[3].ToString();
            }
            dr.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dbconnection.Open();
                dataGridView1.Rows.Clear();
                String query = "select * from store where Store_Name like'" + txtSearch.Text + "%'";
                MySqlCommand com = new MySqlCommand(query, dbconnection);
                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells["Store_ID"].Value = dr[0].ToString();
                    dataGridView1.Rows[n].Cells["Store_Name"].Value = dr[1].ToString();
                    dataGridView1.Rows[n].Cells["Store_Address"].Value = dr[2].ToString();
                    dataGridView1.Rows[n].Cells["Store_Phone"].Value = dr[3].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dbconnection.Close();
        }
    }
}
