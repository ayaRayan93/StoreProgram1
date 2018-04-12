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
    public partial class Store_Update : Form
    {
        MySqlConnection conn;
        int ID;
        public Store_Update(int id)
        {
            InitializeComponent();
            ID = id;
            string query = "select * from store where Store_ID='" + ID + "'";
            conn = new MySqlConnection(connection.connectionString);
            try
            {
                conn.Open();
                MySqlCommand com = new MySqlCommand(query, conn);
                MySqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                   
                    txtName.Text = dr["Name"].ToString();
                    txtAddress.Text = dr["Address"].ToString();
                    txtPhone.Text = dr["Phone"].ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != "")
                {
                    conn.Open();
                    String query = "update store set Name=@Name,Address=@Address,Phone=@Phone where ID='" + ID + "'";
                    MySqlCommand com = new MySqlCommand(query, conn);
                    
                    com.Parameters.Add("@Name", MySqlDbType.VarChar, 255).Value = txtName.Text;
                    com.Parameters.Add("@Address", MySqlDbType.VarChar, 255).Value = txtAddress.Text;
                    com.Parameters.Add("@Phone", MySqlDbType.VarChar, 255).Value = txtPhone.Text;

                    com.ExecuteNonQuery();
                    MessageBox.Show("udpate success :)");
                    txtName.Focus();
                }
                else
                {
                    MessageBox.Show("enter name");
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
                conn.Close();
            }
            conn.Close();
        }
        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    TextBox t = (TextBox)sender;
                    switch (t.Name)
                    {
                        case "txtName":
                            txtAddress.Focus();
                            break;
                        case "txtAddress":
                            txtPhone.Focus();
                            break;
                        case "txtPhone":
                            txtName.Focus();
                            break;


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Reports f = new Reports();
            //    f.Show();
            //    this.Hide();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void Store_Update_FormClosed(object sender, FormClosedEventArgs e)
        {
            //try
            //{
            //    Reports f = new Reports();
            //    f.Show();
            //    this.Hide();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}
