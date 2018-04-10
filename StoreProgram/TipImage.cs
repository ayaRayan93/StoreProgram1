﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreProgram
{
    public partial class TipImage : Form
    {
        string code = "";
        MySqlConnection dbconnection;
        byte[] bin;
        int bufferSize = 1024;
        MemoryStream ms = null;
        Image image = null;
        public TipImage(String code)
        {
            InitializeComponent();
            dbconnection = new MySqlConnection(connection.connectionString);
            bin = new byte[bufferSize];
            image = null;
            this.code = code;
        }

        private void TipImage_Load(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox1.Image = Properties.Resources.animated_gif_loading;
                Thread t1 = new Thread(displayImage);
                t1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void displayImage()
        {
            try
            {
                dbconnection.Open();
               
                string query = "select Photo from data_details where Code='"+code+"'";
                MySqlCommand com = new MySqlCommand(query, dbconnection);

               
                if (com.ExecuteScalar() != null)
                {
                    bin = (byte[])com.ExecuteScalar();

                    ms = new MemoryStream(bin);
                    image = Image.FromStream(ms);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = image;
                }
                else
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = Properties.Resources.Delete_52px;
                }
            
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Properties.Resources.Delete_52px;
               
            }
            dbconnection.Close();
        }
    }
}
