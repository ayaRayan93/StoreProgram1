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
    public partial class Ataqm : Form
    {
        MySqlConnection dbconnection;
        bool loaded = false;
        bool flag = false;
        DataGridViewRow row1;
        public static SetRecord setRecord = null;
        public static SetUpdate setUpdate = null;
        public Ataqm()
        {
            InitializeComponent();
            dbconnection = new MySqlConnection(connection.connectionString);
        }

        private void Ataqm_Load(object sender, EventArgs e)
        {
            try
            {
                loadDataToBox();

                loaded = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (loaded)
                {
                    ComboBox comBox = (ComboBox)sender;

                    switch (comBox.Name)
                    {
                        case "comFactory":
                            txtFactory.Text = comFactory.SelectedValue.ToString();
                            Search();
                            break;
                        case "comType":
                            txtType.Text = comType.SelectedValue.ToString();
                            Search();
                            break;
                        case "comGroup":
                            txtGroup.Text = comGroup.SelectedValue.ToString();
                            Search();
                            break;
                        case "comSets":
                            if (flag)
                            {
                              txtSetsID.Text = comSets.SelectedValue.ToString();
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            string query;
            MySqlCommand com;
            string Name;
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txtBox.Text != "")
                    {
                        dbconnection.Open();
                        switch (txtBox.Name)
                        {
                            case "txtFactory":
                                query = "select Factory_Name from sets where Factory_ID='" + txtFactory.Text + "'";
                                com = new MySqlCommand(query, dbconnection);
                                if (com.ExecuteScalar() != null)
                                {
                                    Name = (string)com.ExecuteScalar();
                                    comFactory.Text = Name;
                                    Search();
                                    txtGroup.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("there is no item with this id");
                                    dbconnection.Close();
                                    return;
                                }
                                break;
                            case "txtType":
                                query = "select Type_Name from sets where Type_ID='" + txtType.Text + "'";
                                com = new MySqlCommand(query, dbconnection);
                                if (com.ExecuteScalar() != null)
                                {
                                    Name = (string)com.ExecuteScalar();
                                    comType.Text = Name;
                                    Search();
                                    txtFactory.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("there is no item with this id");
                                    dbconnection.Close();
                                    return;
                                }
                                break;
                            case "txtGroup":
                                query = "select Group_Name from sets where Group_ID='" + txtGroup.Text + "'";
                                com = new MySqlCommand(query, dbconnection);
                                if (com.ExecuteScalar() != null)
                                {
                                    Name = (string)com.ExecuteScalar();
                                    comGroup.Text = Name;
                                    Search();
                                    txtSetsID.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("there is no item with this id");
                                    dbconnection.Close();
                                    return;
                                }
                                break;
                            case "txtSetsID":
                                if (flag)
                                {
                                    query = "select Set_Name from sets where Set_ID='" + txtSetsID.Text + "'";
                                    com = new MySqlCommand(query, dbconnection);
                                    if (com.ExecuteScalar() != null)
                                    {
                                        Name = (string)com.ExecuteScalar();
                                        comSets.Text = Name;
                                       
                                    }
                                    else
                                    {
                                        MessageBox.Show("there is no item with this id");
                                        dbconnection.Close();
                                        return;
                                    }
                                }
                                break;
                        }

                    }

                }
                catch (Exception ex)
                {
                  //  MessageBox.Show(ex.ToString());
                }
                dbconnection.Close();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Search();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (setRecord == null)
                {
                    setRecord = new SetRecord();
                    setRecord.Show();
                    setRecord.Focus();
                }
                else
                {
                    setRecord.Show();
                    setRecord.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnection.Open();
                if (row1 != null)
                {
                    if (setUpdate==null)
                    {
                        setUpdate = new SetUpdate(row1);
                        setUpdate.Show();
                    }
                    else
                    {
                        setUpdate.Show();
                        setUpdate.Focus();
                    }
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dbconnection.Open();
                if (row1 != null)
                {
                    deleteSet((int)row1.Cells[0].Value);
                    Search();
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
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // row1 = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dbconnection.Open();
                row1 = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex];
                string query = "SELECT data.Data_ID,data.Code,product.Product_Name,type.Type_Name,factory.Factory_Name,groupo.Group_Name,color.Color_Name,size.Size_Value,sort.Sort_Value,data.Classification,data.Description,data.Carton from data INNER JOIN type ON type.Type_ID = data.Type_ID INNER JOIN product ON product.Product_ID = data.Product_ID INNER JOIN factory ON data.Factory_ID = factory.Factory_ID INNER JOIN groupo ON data.Group_ID = groupo.Group_ID LEFT outer JOIN color ON data.Color_ID = color.Color_ID LEFT outer  JOIN size ON data.Size_ID = size.Size_ID LEFT outer  JOIN sort ON data.Sort_ID = sort.Sort_ID where  data.Code in(select set_details.Code from set_details where set_details.Set_ID=" + row1.Cells[0].Value + ") group by data.Code";

                MySqlCommand comand = new MySqlCommand(query, dbconnection);
                dataGridView2.Rows.Clear();
                MySqlDataReader dr = comand.ExecuteReader();
                while (dr.Read())
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells["Data_ID"].Value = dr[0];
                    dataGridView2.Rows[n].Cells["Code2"].Value = dr[1];
                    dataGridView2.Rows[n].Cells["Product_Name"].Value = dr[2];
                    dataGridView2.Rows[n].Cells["Type"].Value = dr[3];
                    dataGridView2.Rows[n].Cells["Factory"].Value = dr[4];
                    dataGridView2.Rows[n].Cells["Group_Name"].Value = dr[5];
                    dataGridView2.Rows[n].Cells["Colour"].Value = dr[6];
                    dataGridView2.Rows[n].Cells["Size"].Value = dr[7];
                    dataGridView2.Rows[n].Cells["Sort"].Value = dr[8];
                    dataGridView2.Rows[n].Cells["Classification"].Value = dr[9];
                    dataGridView2.Rows[n].Cells["Description"].Value = dr[10];
                    dataGridView2.Rows[n].Cells["Carton"].Value = dr[11];
                }
                dr.Close();
                dataGridView2.Columns[1].Width = 180;
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
            dbconnection.Close();
        }

        //function
        //
        private void Search()
        {
            try
            {
                dbconnection.Open();
                loaded = false;
                string q1, q2, q3, q4;
                if (txtType.Text == "")
                {
                    q1 = "select Type_ID from sets";
                }
                else
                {
                    q1 = txtType.Text;
                }
                if (txtFactory.Text == "")
                {
                    q2 = "select Factory_ID from sets";
                }
                else
                {
                    q2 = txtFactory.Text;
                }
                if (txtSetsID.Text == "")
                {
                    q3 = "select Set_ID from sets";
                }
                else
                {
                    q3 = txtSetsID.Text;
                }
                if (txtGroup.Text == "")
                {
                    q4 = "select Group_ID from sets";
                }
                else
                {
                    q4 = txtGroup.Text;
                }
                
                string query = "SELECT Set_ID,Set_Name,Type_Name,Factory_Name,Group_Name from sets INNER JOIN type ON type.Type_ID = sets.Type_ID  INNER JOIN factory ON sets.Factory_ID = factory.Factory_ID INNER JOIN groupo ON sets.Group_ID = groupo.Group_ID  where  sets.Type_ID IN(" + q1 + ") and  sets.Factory_ID  IN(" + q2 + ") and sets.Group_ID IN (" + q4 + ") ";

                MySqlCommand comand = new MySqlCommand(query, dbconnection);
                dataGridView1.Rows.Clear();
                MySqlDataReader dr = comand.ExecuteReader();
                while (dr.Read())
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = dr[0];
                    dataGridView1.Rows[n].Cells[1].Value = dr[1];
                    dataGridView1.Rows[n].Cells[2].Value = dr[2];
                    dataGridView1.Rows[n].Cells[3].Value = dr[3];
                    dataGridView1.Rows[n].Cells[4].Value = dr[4];
                }
                dr.Close();
                dataGridView1.Columns[1].Width = 180;
                loaded = true;

                dataGridView2.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dbconnection.Close();
        
    } 
        public void deleteSet(int id)
        {
            String query = "delete from sets where Set_ID="+id;
            MySqlCommand com = new MySqlCommand(query,dbconnection);
            com.ExecuteNonQuery();
            query = "delete from set_details where Set_ID=" + id;
            com = new MySqlCommand(query, dbconnection);
            com.ExecuteNonQuery();

        }

        public void loadDataToBox()
        {
            string query = "select distinct Factory_Name,sets.Factory_ID from sets inner join Factory on sets.Factory_ID=Factory.Factory_ID";
            MySqlDataAdapter da = new MySqlDataAdapter(query, dbconnection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comFactory.DataSource = dt;
            comFactory.DisplayMember = dt.Columns["Factory_Name"].ToString();
            comFactory.ValueMember = dt.Columns["Factory_ID"].ToString();
            comFactory.Text = "";
            txtFactory.Text = "";

            query = "select Set_Name,Set_ID from sets ";
            da = new MySqlDataAdapter(query, dbconnection);
            dt = new DataTable();
            da.Fill(dt);
            comSets.DataSource = dt;
            comSets.DisplayMember = dt.Columns["Set_Name"].ToString();
            comSets.ValueMember = dt.Columns["Set_ID"].ToString();
            comSets.Text = "";
            txtSetsID.Text = "";

            query = "select distinct Type_Name,type.Type_ID from sets inner join type on sets.Type_ID=type.Type_ID";
            da = new MySqlDataAdapter(query, dbconnection);
            dt = new DataTable();
            da.Fill(dt);
            comType.DataSource = dt;
            comType.DisplayMember = dt.Columns["Type_Name"].ToString();
            comType.ValueMember = dt.Columns["Type_ID"].ToString();
            comType.Text = "";
            txtType.Text = "";

            query = "select distinct Group_Name,sets.Group_ID from sets inner join groupo on sets.Group_ID=groupo.Group_ID";
            da = new MySqlDataAdapter(query, dbconnection);
            dt = new DataTable();
            da.Fill(dt);
            comGroup.DataSource = dt;
            comGroup.DisplayMember = dt.Columns["Group_Name"].ToString();
            comGroup.ValueMember = dt.Columns["Group_ID"].ToString();
            comGroup.Text = "";
            txtGroup.Text = "";
        }

      
    }
}
