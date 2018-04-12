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
    public partial class Store_Record : Form
    {
        MySqlConnection conn;
        public Store_Record()
        {
            InitializeComponent();
            
            string constr= connection.connectionString;
            conn = new MySqlConnection(constr);
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                conn.Open();
                string query = "select Store_Name from store where Store_Name='" + txtName.Text + "'";
                MySqlCommand com = new MySqlCommand(query, conn);


                if (com.ExecuteScalar() == null)
                {
                    if (txtName.Text != "")
                    {
                        string qeury = "insert into store (Store_Name,Store_Address,Store_Phone)values(@Name,@Address,@Phone)";
                        com = new MySqlCommand(qeury, conn);
                        com.Parameters.Add("@Name", MySqlDbType.VarChar, 255);
                        com.Parameters["@Name"].Value = txtName.Text;
                        com.Parameters.Add("@Address", MySqlDbType.VarChar, 255);
                        com.Parameters["@Address"].Value = txtAddress.Text;
                        com.Parameters.Add("@Phone", MySqlDbType.VarChar, 255);
                        com.Parameters["@Phone"].Value = txtPhone.Text;

                        com.ExecuteNonQuery();
                        MessageBox.Show("add success");
                        clear();
                        txtName.Focus();
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //try
            //{
            //    RecordData f = new RecordData();
            //    f.Show();
            //    this.Hide();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    RecordData f = new RecordData();
            //    f.Show();
            //    this.Hide();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        //function
        public void clear()
        {
            txtName.Text = txtAddress.Text = txtPhone.Text = "";
        }
    }
   
}
