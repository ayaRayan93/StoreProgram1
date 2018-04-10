using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreProgram
{
    public partial class Product_Update : Form
    {
        byte[] selectedImage;
        bool loaded = false;
        MySqlConnection conn, conn1;
        string code = "";
        int color_id = 0;
        int size_id = 0;
        int sort_id = 0;
        Products products = null;
        public Product_Update(Products products,DataGridViewRow row1)
        {
            try
            {
                InitializeComponent();
                this.products = products;
                conn = new MySqlConnection(connection.connectionString);
                conn1 = new MySqlConnection(connection.connectionString);
                code = row1.Cells["Code"].Value.ToString();
                conn.Open();
                loadData();
                displayData(row1);
                TypeColor();
                FactorySize();
                string query = "delete from data where Code='" + code + "'";
                MySqlCommand comand = new MySqlCommand(query, conn);
              
                comand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void Product_Update_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void comBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                ComboBox comBox = (ComboBox)sender;

                switch (comBox.Name)
                {
                    case "comType":
                        txtType.Text = comType.SelectedValue.ToString();
                        TypeColor();
                        break;
                    case "comFactory":
                        txtFactory.Text = comFactory.SelectedValue.ToString();
                        FactorySize();
                        break;
                    case "comGroup":
                        txtGroup.Text = comGroup.SelectedValue.ToString();
                        comProduct.Focus();
                        break;
                    case "comProduct":
                        txtProduct.Text = comProduct.SelectedValue.ToString();
                        comColour.Focus();
                        break;
                    case "comColour":
                        comSize.Focus();
                        break;
                    case "comSize":
                        txtClassification.Focus();
                        break;
                    case "comSort":
                        txtCarton.Focus();
                        break;
                }
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
                        conn.Open();
                        switch (txtBox.Name)
                        {
                            case "txtType":
                                query = "select Type_Name from type where Type_ID='" + txtType.Text + "'";
                                com = new MySqlCommand(query, conn);
                                if (com.ExecuteScalar() != null)
                                {
                                    Name = (string)com.ExecuteScalar();
                                    comType.Text = Name;
                                    txtFactory.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("there is no item with this id");
                                    conn.Close();
                                    return;
                                }
                                break;
                            case "txtFactory":
                                query = "select Factory_Name from factory where Factory_ID='" + txtFactory.Text + "'";
                                com = new MySqlCommand(query, conn);
                                if (com.ExecuteScalar() != null)
                                {
                                    Name = (string)com.ExecuteScalar();
                                    comFactory.Text = Name;
                                    txtGroup.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("there is no item with this id");
                                    conn.Close();
                                    return;
                                }
                                break;
                            case "txtGroup":
                                query = "select Group_Name from groupo where Group_ID='" + txtGroup.Text + "'";
                                com = new MySqlCommand(query, conn);
                                if (com.ExecuteScalar() != null)
                                {
                                    Name = (string)com.ExecuteScalar();
                                    comGroup.Text = Name;
                                    txtProduct.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("there is no item with this id");
                                    conn.Close();
                                    return;
                                }
                                break;
                            case "txtProduct":
                                query = "select Product_Name from product where Product_ID='" + txtProduct.Text + "'";
                                com = new MySqlCommand(query, conn);
                                if (com.ExecuteScalar() != null)
                                {
                                    Name = (string)com.ExecuteScalar();
                                    comProduct.Text = Name;
                                    comColour.Focus();
                                }
                                else
                                {
                                    MessageBox.Show("there is no item with this id");
                                    conn.Close();
                                    return;
                                }
                                break;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFactory.Text != "" && txtGroup.Text != "" && txtProduct.Text != "" && txtType.Text != "" )
                {
                  
                    double carton = 0;
                    string classification, description = "";
                    if (comColour.Text != "")
                    {
                        try
                        {
                            color_id = Convert.ToInt16(comColour.SelectedValue.ToString());
                        }
                        catch
                        {
                            
                        }
                        
                    }
                    if (comSize.Text != "")
                    {
                        try
                        {
                            size_id = Convert.ToInt16(comSize.SelectedValue.ToString());
                        }
                        catch
                        {

                        }
                        
                    }
                    if (comSort.Text != "")
                    {
                        try
                        {
                            sort_id = Convert.ToInt16(comSort.SelectedValue.ToString());
                        }
                        catch
                        {

                        }
                        
                    }
                    if (txtCarton.Text != "")
                    {
                        if (double.TryParse(txtCarton.Text, out carton))
                        {
                        }
                        else
                        {
                            MessageBox.Show("carton must be numeric");
                            conn.Close();
                            return;
                        }
                    }
                    classification = txtClassification.Text;
                    description = txtDescription.Text;

                    string q = "SELECT Data_ID from data where Color_ID=" + color_id + " and Size_ID=" + size_id + " and Sort_ID=" + sort_id + " and Description='" + description + "' and Carton=" + carton + " and Type_ID=" + txtType.Text + " and Factory_ID=" + txtFactory.Text + " and Group_ID=" + txtGroup.Text + " and Product_ID=" + txtProduct.Text + " and Classification='" + classification + "'";
                    MySqlCommand comand = new MySqlCommand(q, conn);
                    conn.Open();
                    var resultValue = comand.ExecuteReader();
                    if (!resultValue.HasRows)
                    {
                        conn.Close();

                        MySqlCommand command = conn.CreateCommand();

                        string code = txtType.Text;

                        int typecount = txtType.Text.Length;

                        int factorycount = txtFactory.Text.Length;

                        int groupcount = txtGroup.Text.Length;

                        int productcount = txtProduct.Text.Length;

                        while (typecount < 4)
                        {
                            code = "0" + code;
                            typecount++;
                        }

                        string code2 = txtFactory.Text;

                        while (factorycount < 4)
                        {
                            code2 = "0" + code2;
                            factorycount++;
                        }

                        code = code + code2;

                        string code3 = txtGroup.Text;

                        while (groupcount < 4)
                        {
                            code3 = "0" + code3;
                            groupcount++;
                        }

                        code = code + code3;

                        string code4 = txtProduct.Text;

                        while (productcount < 4)
                        {
                            code4 = "0" + code4;
                            productcount++;
                        }

                        code = code + code4;

                        string query2 = "SELECT count(Code) FROM data where Type_ID=" + txtType.Text + " and Factory_ID=" + txtFactory.Text + " and Group_ID=" + txtGroup.Text + " and Product_ID=" + txtProduct.Text;
                        conn.Open();
                        MySqlCommand adpt = new MySqlCommand(query2, conn);
                        int result = Convert.ToInt16(adpt.ExecuteScalar().ToString());
                        result = result + 1;
                        conn.Close();

                        int resultcount = result.ToString().Length;

                        string code5 = result.ToString();

                        while (resultcount < 4)
                        {
                            code5 = "0" + code5;
                            resultcount++;
                        }

                        code = code + code5;

                        command.CommandText = "INSERT INTO data (Color_ID,Size_ID,Sort_ID,Description,Carton,Code,Type_ID,Factory_ID,Group_ID,Product_ID,Classification) VALUES (?Color_ID,?Size_ID,?Sort_ID,?Description,?Carton,?Code,?Type_ID,?Factory_ID,?Group_ID,?Product_ID,?Classification)";

                        command.Parameters.AddWithValue("?Color_ID", color_id);
                        command.Parameters.AddWithValue("?Size_ID", size_id);
                        command.Parameters.AddWithValue("?Sort_ID", sort_id);
                        command.Parameters.AddWithValue("?Description", description);
                        command.Parameters.AddWithValue("?Carton", carton);
                        command.Parameters.AddWithValue("?Code", code);
                        command.Parameters.AddWithValue("?Type_ID", int.Parse(txtType.Text));
                        command.Parameters.AddWithValue("?Factory_ID", int.Parse(txtFactory.Text));
                        command.Parameters.AddWithValue("?Group_ID", int.Parse(txtGroup.Text));
                        command.Parameters.AddWithValue("?Product_ID", int.Parse(txtProduct.Text));
                        command.Parameters.AddWithValue("?Classification", classification);
                        conn.Open();
                        command.ExecuteNonQuery();
                        conn.Close();


                        //save image as bytes
                        command = conn.CreateCommand();
                        command.CommandText = "INSERT INTO data_details (Code,Photo,Type) VALUES (?Code,?Photo,?Type)";
                        command.Parameters.AddWithValue("?Code", code);
                        command.Parameters.AddWithValue("?Photo", selectedImage);
                        command.Parameters.AddWithValue("?Type", "بند");
                        conn.Open();
                        command.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("updated");
                        products.displayProducts();
                        comType.Focus();
                    }
                    else
                    {
                        MessageBox.Show("This item already exist");
                    }
                }
                else
                {
                    MessageBox.Show("you should fill all fields");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void txtClassification_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescription.Focus();
            }
        }

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                comSort.Focus();
            }
        }

      

        private void btnUploadPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog1.FileName;
              
                ImageProduct.Image = Image.FromFile(openFileDialog1.FileName);                
                selectedImage= File.ReadAllBytes(selectedFile);
            }
        }

        private void Product_Update_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                //Reports f = new Reports();
                //f.Show();
                //this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //function
        public void displayData(DataGridViewRow row1)
        {
           // ImageProduct.Image = Properties.Resources.animated_gif_loading;
            Thread t1 = new Thread(displayImage);
            t1.Start();

            comType.Text = row1.Cells["Type_Name"].Value.ToString();
            comFactory.Text = row1.Cells["Factory_Name"].Value.ToString();
            comGroup.Text = row1.Cells["Group_Name"].Value.ToString();
            comProduct.Text = row1.Cells["Product_Name"].Value.ToString();

            comColour.Text = row1.Cells["Colour"].Value.ToString();

            txtCarton.Text = row1.Cells["Carton"].Value.ToString();
            comSize.Text = row1.Cells["Size"].Value.ToString();
            comSort.Text = row1.Cells["Sort"].Value.ToString();
            txtDescription.Text = row1.Cells["Classification"].Value.ToString();
            txtClassification.Text = row1.Cells["Description"].Value.ToString();
            try
            {
                color_id = Convert.ToInt16(row1.Cells["Color_ID"].Value);
                size_id = Convert.ToInt16(row1.Cells["Size_ID"].Value);
                sort_id = Convert.ToInt16(row1.Cells["Sort_ID"].Value);
            }
            catch 
            {
                
            }
          
            displayCode();
        
        }
        public void displayImage()
        {
            try
            {
                conn1.Open();
                string query = "select Photo from data_details where Code='" + code + "'";
                MySqlCommand com = new MySqlCommand(query, conn1);
                byte[] photo = (byte[])com.ExecuteScalar();
               
                if (photo != null)
                {
                    MemoryStream ms = new MemoryStream(photo);
                    ImageProduct.Image = Image.FromStream(ms);
                }
                else
                {
                   // ImageProduct.Image = Properties.Resources.image_not_found;
                }
            }
            catch
            {
                //  MessageBox.Show(ex.Message);
               // ImageProduct.Image = Properties.Resources.image_not_found;
            }
            conn1.Close();
        }
        public void displayCode()
        {
            char[] arrCode = code.ToCharArray();
            txtType.Text = arrCode[0].ToString() + arrCode[1].ToString() + arrCode[2].ToString() + arrCode[3].ToString() + "";
            txtFactory.Text = arrCode[4].ToString() + arrCode[5].ToString() + arrCode[6].ToString() + arrCode[7].ToString() + "";
            txtGroup.Text = arrCode[8].ToString() + arrCode[9].ToString() + arrCode[10].ToString() + arrCode[11].ToString() + "";
            txtProduct.Text = arrCode[12].ToString() + arrCode[13].ToString() + arrCode[14].ToString() + arrCode[15].ToString() + "";
        
          
        }
        private void TypeColor()
        {
            string query = "select * from color where Type_ID=" + Convert.ToInt16(txtType.Text);
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comColour.DataSource = dt;
            comColour.DisplayMember = dt.Columns["Color_Name"].ToString();
            comColour.ValueMember = dt.Columns["Color_ID"].ToString();
            comColour.Text = "";
            comFactory.Focus();
        }
        private void FactorySize()
        {
            string query2 = "select * from size where Factory_ID=" + Convert.ToInt16(txtFactory.Text);
            MySqlDataAdapter da2 = new MySqlDataAdapter(query2, conn);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comSize.DataSource = dt2;
            comSize.DisplayMember = dt2.Columns["Size_Value"].ToString();
            comSize.ValueMember = dt2.Columns["Size_ID"].ToString();
            comSize.Text = "";
            comGroup.Focus();
        }

        private void ImageProduct_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = openFileDialog1.FileName;

                    ImageProduct.Image = Image.FromFile(openFileDialog1.FileName);
                    selectedImage = File.ReadAllBytes(selectedFile);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void loadData()
        {
            string query = "select * from type";
            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comType.DataSource = dt;
            comType.DisplayMember = dt.Columns["Type_Name"].ToString();
            comType.ValueMember = dt.Columns["Type_ID"].ToString();


            query = "select * from factory";
            da = new MySqlDataAdapter(query, conn);
            dt = new DataTable();
            da.Fill(dt);
            comFactory.DataSource = dt;
            comFactory.DisplayMember = dt.Columns["Factory_Name"].ToString();
            comFactory.ValueMember = dt.Columns["Factory_ID"].ToString();


            query = "select * from groupo";
            da = new MySqlDataAdapter(query, conn);
            dt = new DataTable();
            da.Fill(dt);
            comGroup.DataSource = dt;
            comGroup.DisplayMember = dt.Columns["Group_Name"].ToString();
            comGroup.ValueMember = dt.Columns["Group_ID"].ToString();


            query = "select * from product";
            da = new MySqlDataAdapter(query, conn);
            dt = new DataTable();
            da.Fill(dt);
            comProduct.DataSource = dt;
            comProduct.DisplayMember = dt.Columns["Product_Name"].ToString();
            comProduct.ValueMember = dt.Columns["Product_ID"].ToString();


            query = "select * from sort";
            da = new MySqlDataAdapter(query, conn);
            dt = new DataTable();
            da.Fill(dt);
            comSort.DataSource = dt;
            comSort.DisplayMember = dt.Columns["Sort_Value"].ToString();
            comSort.ValueMember = dt.Columns["Sort_ID"].ToString();


            loaded = true;
        }
        //to move form
        Point mousedownpoint = Point.Empty;

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            mousedownpoint = new Point(e.X, e.Y);
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {

            if (mousedownpoint.IsEmpty)
                return;
            Form f = sender as Form;
            f.Location = new Point(f.Location.X + (e.X - mousedownpoint.X), f.Location.Y + (e.Y - mousedownpoint.Y));

        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            mousedownpoint = Point.Empty;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Form_MouseDown(this, e);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Form_MouseUp(this, e);
        }

        private void panClose_Click(object sender, EventArgs e)
        {
            try
            {
                products.product_Update = null;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Form_MouseMove(this, e);
        }
    }
    
}
