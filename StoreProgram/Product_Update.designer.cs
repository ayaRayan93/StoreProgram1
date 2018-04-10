namespace StoreProgram
{
    partial class Product_Update
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Update));
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCarton = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtClassification = new System.Windows.Forms.TextBox();
            this.comSort = new System.Windows.Forms.ComboBox();
            this.comSize = new System.Windows.Forms.ComboBox();
            this.comColour = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comFactory = new System.Windows.Forms.ComboBox();
            this.comProduct = new System.Windows.Forms.ComboBox();
            this.comGroup = new System.Windows.Forms.ComboBox();
            this.comType = new System.Windows.Forms.ComboBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFactory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panClose = new System.Windows.Forms.Panel();
            this.ImageProduct = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddProduct.Location = new System.Drawing.Point(87, 475);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(156, 42);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "تعديل";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCarton);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.txtClassification);
            this.groupBox2.Controls.Add(this.comSort);
            this.groupBox2.Controls.Add(this.comSize);
            this.groupBox2.Controls.Add(this.comColour);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Neo Sans Arabic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(182)))), ((int)(((byte)(92)))));
            this.groupBox2.Location = new System.Drawing.Point(87, 278);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(804, 179);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تكويد تفاصيل";
            // 
            // txtCarton
            // 
            this.txtCarton.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCarton.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtCarton.Location = new System.Drawing.Point(108, 105);
            this.txtCarton.Name = "txtCarton";
            this.txtCarton.Size = new System.Drawing.Size(198, 23);
            this.txtCarton.TabIndex = 16;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtDescription.Location = new System.Drawing.Point(108, 45);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(198, 23);
            this.txtDescription.TabIndex = 14;
            this.txtDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescription_KeyDown);
            // 
            // txtClassification
            // 
            this.txtClassification.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtClassification.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtClassification.Location = new System.Drawing.Point(442, 109);
            this.txtClassification.Name = "txtClassification";
            this.txtClassification.Size = new System.Drawing.Size(198, 23);
            this.txtClassification.TabIndex = 13;
            this.txtClassification.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClassification_KeyDown);
            // 
            // comSort
            // 
            this.comSort.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comSort.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comSort.FormattingEnabled = true;
            this.comSort.Location = new System.Drawing.Point(108, 75);
            this.comSort.Name = "comSort";
            this.comSort.Size = new System.Drawing.Size(198, 24);
            this.comSort.Sorted = true;
            this.comSort.TabIndex = 15;
            this.comSort.SelectedValueChanged += new System.EventHandler(this.comBox_SelectedValueChanged);
            // 
            // comSize
            // 
            this.comSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comSize.FormattingEnabled = true;
            this.comSize.Location = new System.Drawing.Point(442, 79);
            this.comSize.Name = "comSize";
            this.comSize.Size = new System.Drawing.Size(198, 24);
            this.comSize.Sorted = true;
            this.comSize.TabIndex = 11;
            this.comSize.SelectedValueChanged += new System.EventHandler(this.comBox_SelectedValueChanged);
            // 
            // comColour
            // 
            this.comColour.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comColour.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comColour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comColour.FormattingEnabled = true;
            this.comColour.Location = new System.Drawing.Point(442, 49);
            this.comColour.Name = "comColour";
            this.comColour.Size = new System.Drawing.Size(198, 24);
            this.comColour.Sorted = true;
            this.comColour.TabIndex = 9;
            this.comColour.SelectedValueChanged += new System.EventHandler(this.comBox_SelectedValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Neo Sans Arabic", 10F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.label10.Location = new System.Drawing.Point(312, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "الكرتنة";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Neo Sans Arabic", 10F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.label9.Location = new System.Drawing.Point(312, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "الوصف";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Neo Sans Arabic", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.label5.Location = new System.Drawing.Point(646, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "التصنيف";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Neo Sans Arabic", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.label6.Location = new System.Drawing.Point(312, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "الفرز";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Neo Sans Arabic", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.label7.Location = new System.Drawing.Point(646, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "المقاس";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Neo Sans Arabic", 10F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.label8.Location = new System.Drawing.Point(646, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "اللون";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comFactory);
            this.groupBox1.Controls.Add(this.comProduct);
            this.groupBox1.Controls.Add(this.comGroup);
            this.groupBox1.Controls.Add(this.comType);
            this.groupBox1.Controls.Add(this.txtProduct);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtGroup);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFactory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Neo Sans Arabic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(182)))), ((int)(((byte)(92)))));
            this.groupBox1.Location = new System.Drawing.Point(436, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(443, 195);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تكويد مراحل";
            // 
            // comFactory
            // 
            this.comFactory.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comFactory.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comFactory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comFactory.FormattingEnabled = true;
            this.comFactory.Location = new System.Drawing.Point(126, 79);
            this.comFactory.Name = "comFactory";
            this.comFactory.Size = new System.Drawing.Size(198, 24);
            this.comFactory.Sorted = true;
            this.comFactory.TabIndex = 10;
            this.comFactory.SelectedValueChanged += new System.EventHandler(this.comBox_SelectedValueChanged);
            // 
            // comProduct
            // 
            this.comProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comProduct.FormattingEnabled = true;
            this.comProduct.Location = new System.Drawing.Point(126, 133);
            this.comProduct.Name = "comProduct";
            this.comProduct.Size = new System.Drawing.Size(198, 24);
            this.comProduct.Sorted = true;
            this.comProduct.TabIndex = 7;
            this.comProduct.SelectedValueChanged += new System.EventHandler(this.comBox_SelectedValueChanged);
            // 
            // comGroup
            // 
            this.comGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comGroup.FormattingEnabled = true;
            this.comGroup.Location = new System.Drawing.Point(126, 106);
            this.comGroup.Name = "comGroup";
            this.comGroup.Size = new System.Drawing.Size(198, 24);
            this.comGroup.Sorted = true;
            this.comGroup.TabIndex = 5;
            this.comGroup.SelectedValueChanged += new System.EventHandler(this.comBox_SelectedValueChanged);
            // 
            // comType
            // 
            this.comType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comType.FormattingEnabled = true;
            this.comType.Location = new System.Drawing.Point(126, 52);
            this.comType.Name = "comType";
            this.comType.Size = new System.Drawing.Size(198, 24);
            this.comType.Sorted = true;
            this.comType.TabIndex = 1;
            this.comType.SelectedValueChanged += new System.EventHandler(this.comBox_SelectedValueChanged);
            // 
            // txtProduct
            // 
            this.txtProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProduct.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtProduct.Location = new System.Drawing.Point(35, 133);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(81, 23);
            this.txtProduct.TabIndex = 8;
            this.txtProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Neo Sans Arabic", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.label4.Location = new System.Drawing.Point(330, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "اسم الصنف";
            // 
            // txtGroup
            // 
            this.txtGroup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGroup.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtGroup.Location = new System.Drawing.Point(35, 106);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(81, 23);
            this.txtGroup.TabIndex = 6;
            this.txtGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Neo Sans Arabic", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.label3.Location = new System.Drawing.Point(330, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "المجموعة";
            // 
            // txtFactory
            // 
            this.txtFactory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFactory.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtFactory.Location = new System.Drawing.Point(35, 79);
            this.txtFactory.Name = "txtFactory";
            this.txtFactory.Size = new System.Drawing.Size(81, 23);
            this.txtFactory.TabIndex = 4;
            this.txtFactory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Neo Sans Arabic", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(330, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "المصنع/المورد";
            // 
            // txtType
            // 
            this.txtType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtType.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtType.Location = new System.Drawing.Point(35, 52);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(81, 23);
            this.txtType.TabIndex = 2;
            this.txtType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Neo Sans Arabic", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(330, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "النوع";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.ImageProduct);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.btnAddProduct);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(974, 553);
            this.panel3.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(182)))), ((int)(((byte)(92)))));
            this.panel1.Controls.Add(this.panClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(972, 36);
            this.panel1.TabIndex = 21;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panClose
            // 
            this.panClose.BackgroundImage = global::StoreProgram.Properties.Resources.Delete_52px;
            this.panClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.panClose.Location = new System.Drawing.Point(926, 0);
            this.panClose.Name = "panClose";
            this.panClose.Size = new System.Drawing.Size(46, 36);
            this.panClose.TabIndex = 0;
            this.panClose.Click += new System.EventHandler(this.panClose_Click);
            // 
            // ImageProduct
            // 
            this.ImageProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(182)))), ((int)(((byte)(92)))));
            this.ImageProduct.BackgroundImage = global::StoreProgram.Properties.Resources.Camera_52px;
            this.ImageProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ImageProduct.Location = new System.Drawing.Point(87, 77);
            this.ImageProduct.Name = "ImageProduct";
            this.ImageProduct.Size = new System.Drawing.Size(325, 195);
            this.ImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImageProduct.TabIndex = 19;
            this.ImageProduct.TabStop = false;
            this.ImageProduct.Click += new System.EventHandler(this.ImageProduct_Click);
            // 
            // Product_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 553);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Product_Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل بند";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Product_Update_FormClosed);
            this.Load += new System.EventHandler(this.Product_Update_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MouseUp);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.PictureBox ImageProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCarton;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtClassification;
        private System.Windows.Forms.ComboBox comSort;
        private System.Windows.Forms.ComboBox comSize;
        private System.Windows.Forms.ComboBox comColour;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comFactory;
        private System.Windows.Forms.ComboBox comProduct;
        private System.Windows.Forms.ComboBox comGroup;
        private System.Windows.Forms.ComboBox comType;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFactory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panClose;
    }
}

