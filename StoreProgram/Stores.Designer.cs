namespace StoreProgram
{
    partial class Stores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tLPanProductsContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tLPanFilter = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tLPanSearch = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Store_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Store_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Store_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Store_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDeleteStore = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddStorePlaces = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tLPanProductsContainer.SuspendLayout();
            this.tLPanFilter.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPanProductsContainer
            // 
            this.tLPanProductsContainer.BackColor = System.Drawing.Color.White;
            this.tLPanProductsContainer.ColumnCount = 3;
            this.tLPanProductsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tLPanProductsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tLPanProductsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tLPanProductsContainer.Controls.Add(this.tLPanFilter, 1, 2);
            this.tLPanProductsContainer.Controls.Add(this.tLPanSearch, 0, 2);
            this.tLPanProductsContainer.Controls.Add(this.dataGridView1, 1, 3);
            this.tLPanProductsContainer.Controls.Add(this.tableLayoutPanel4, 0, 3);
            this.tLPanProductsContainer.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tLPanProductsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPanProductsContainer.Location = new System.Drawing.Point(0, 0);
            this.tLPanProductsContainer.Name = "tLPanProductsContainer";
            this.tLPanProductsContainer.RowCount = 5;
            this.tLPanProductsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tLPanProductsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tLPanProductsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tLPanProductsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tLPanProductsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tLPanProductsContainer.Size = new System.Drawing.Size(792, 502);
            this.tLPanProductsContainer.TabIndex = 2;
            // 
            // tLPanFilter
            // 
            this.tLPanFilter.ColumnCount = 1;
            this.tLPanFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPanFilter.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tLPanFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPanFilter.Location = new System.Drawing.Point(198, 50);
            this.tLPanFilter.Margin = new System.Windows.Forms.Padding(0);
            this.tLPanFilter.Name = "tLPanFilter";
            this.tLPanFilter.RowCount = 2;
            this.tLPanFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tLPanFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tLPanFilter.Size = new System.Drawing.Size(554, 50);
            this.tLPanFilter.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.904762F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.14286F));
            this.tableLayoutPanel3.Controls.Add(this.bunifuFlatButton1, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtSearch, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 5);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(554, 45);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(182)))), ((int)(((byte)(92)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(182)))), ((int)(((byte)(92)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "بحث";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Neo Sans Arabic", 12F);
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(225, 5);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(182)))), ((int)(((byte)(92)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(69, 35);
            this.bunifuFlatButton1.TabIndex = 3;
            this.bunifuFlatButton1.Text = "بحث";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Neo Sans Arabic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Neo Sans Arabic", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(101)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(457, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "بحث بالأسم";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtSearch.Location = new System.Drawing.Point(302, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(152, 23);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // tLPanSearch
            // 
            this.tLPanSearch.ColumnCount = 2;
            this.tLPanSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPanSearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPanSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPanSearch.Location = new System.Drawing.Point(3, 53);
            this.tLPanSearch.Name = "tLPanSearch";
            this.tLPanSearch.RowCount = 3;
            this.tLPanSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tLPanSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tLPanSearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tLPanSearch.Size = new System.Drawing.Size(192, 44);
            this.tLPanSearch.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(182)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Neo Sans Arabic", 12.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Store_ID,
            this.Store_Name,
            this.Store_Address,
            this.Store_Phone});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(182)))), ((int)(((byte)(92)))));
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(201, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Neo Sans Arabic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.Size = new System.Drawing.Size(548, 320);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Store_ID
            // 
            this.Store_ID.HeaderText = "الكود";
            this.Store_ID.Name = "Store_ID";
            // 
            // Store_Name
            // 
            this.Store_Name.HeaderText = "الأسم";
            this.Store_Name.Name = "Store_Name";
            // 
            // Store_Address
            // 
            this.Store_Address.HeaderText = "العنوان";
            this.Store_Address.Name = "Store_Address";
            // 
            // Store_Phone
            // 
            this.Store_Phone.HeaderText = "التلفون";
            this.Store_Phone.Name = "Store_Phone";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 103);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(192, 320);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel5.Controls.Add(this.btnDeleteStore, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.bunifuTileButton2, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.bunifuTileButton3, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(186, 90);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // btnDeleteStore
            // 
            this.btnDeleteStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnDeleteStore.color = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnDeleteStore.colorActive = System.Drawing.Color.Silver;
            this.btnDeleteStore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteStore.Font = new System.Drawing.Font("Neo Sans Arabic", 12F);
            this.btnDeleteStore.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteStore.Image = global::StoreProgram.Properties.Resources.Trash_Can_64px_1;
            this.btnDeleteStore.ImagePosition = 16;
            this.btnDeleteStore.ImageZoom = 50;
            this.btnDeleteStore.LabelPosition = 33;
            this.btnDeleteStore.LabelText = "حذف";
            this.btnDeleteStore.Location = new System.Drawing.Point(6, 6);
            this.btnDeleteStore.Margin = new System.Windows.Forms.Padding(6);
            this.btnDeleteStore.Name = "btnDeleteStore";
            this.btnDeleteStore.Size = new System.Drawing.Size(49, 78);
            this.btnDeleteStore.TabIndex = 0;
            this.btnDeleteStore.Click += new System.EventHandler(this.btnDeleteStore_Click);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.bunifuTileButton2.color = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.bunifuTileButton2.colorActive = System.Drawing.Color.Silver;
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton2.Font = new System.Drawing.Font("Neo Sans Arabic", 12F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.Black;
            this.bunifuTileButton2.Image = global::StoreProgram.Properties.Resources.Refresh_48px;
            this.bunifuTileButton2.ImagePosition = 16;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 33;
            this.bunifuTileButton2.LabelText = "تعديل";
            this.bunifuTileButton2.Location = new System.Drawing.Point(67, 6);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(51, 78);
            this.bunifuTileButton2.TabIndex = 1;
            this.bunifuTileButton2.Click += new System.EventHandler(this.btnAddStore_Click);
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.bunifuTileButton3.color = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.bunifuTileButton3.colorActive = System.Drawing.Color.Silver;
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Neo Sans Arabic", 12F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.Black;
            this.bunifuTileButton3.Image = global::StoreProgram.Properties.Resources.Add_File_52px;
            this.bunifuTileButton3.ImagePosition = 16;
            this.bunifuTileButton3.ImageZoom = 50;
            this.bunifuTileButton3.LabelPosition = 33;
            this.bunifuTileButton3.LabelText = "اضافة";
            this.bunifuTileButton3.Location = new System.Drawing.Point(130, 6);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(50, 78);
            this.bunifuTileButton3.TabIndex = 2;
            this.bunifuTileButton3.Click += new System.EventHandler(this.btnAddStore_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.bunifuFlatButton3, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.btnAddStorePlaces, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 99);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(186, 218);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "تقرير  ";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuFlatButton3.Font = new System.Drawing.Font("Neo Sans Arabic", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = global::StoreProgram.Properties.Resources.Print_50px;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 60D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(3, 111);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(180, 37);
            this.bunifuFlatButton3.TabIndex = 1;
            this.bunifuFlatButton3.Text = "تقرير  ";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Neo Sans Arabic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAddStorePlaces
            // 
            this.btnAddStorePlaces.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnAddStorePlaces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnAddStorePlaces.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddStorePlaces.BorderRadius = 0;
            this.btnAddStorePlaces.ButtonText = "اماكن التخزين";
            this.btnAddStorePlaces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStorePlaces.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddStorePlaces.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddStorePlaces.Font = new System.Drawing.Font("Neo Sans Arabic", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStorePlaces.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddStorePlaces.Iconimage = null;
            this.btnAddStorePlaces.Iconimage_right = null;
            this.btnAddStorePlaces.Iconimage_right_Selected = null;
            this.btnAddStorePlaces.Iconimage_Selected = null;
            this.btnAddStorePlaces.IconMarginLeft = 0;
            this.btnAddStorePlaces.IconMarginRight = 0;
            this.btnAddStorePlaces.IconRightVisible = true;
            this.btnAddStorePlaces.IconRightZoom = 0D;
            this.btnAddStorePlaces.IconVisible = true;
            this.btnAddStorePlaces.IconZoom = 60D;
            this.btnAddStorePlaces.IsTab = false;
            this.btnAddStorePlaces.Location = new System.Drawing.Point(3, 3);
            this.btnAddStorePlaces.Name = "btnAddStorePlaces";
            this.btnAddStorePlaces.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.btnAddStorePlaces.OnHovercolor = System.Drawing.Color.Silver;
            this.btnAddStorePlaces.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAddStorePlaces.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddStorePlaces.selected = false;
            this.btnAddStorePlaces.Size = new System.Drawing.Size(180, 36);
            this.btnAddStorePlaces.TabIndex = 2;
            this.btnAddStorePlaces.Text = "اماكن التخزين";
            this.btnAddStorePlaces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddStorePlaces.Textcolor = System.Drawing.Color.Black;
            this.btnAddStorePlaces.TextFont = new System.Drawing.Font("Neo Sans Arabic", 11.75F);
            this.btnAddStorePlaces.Click += new System.EventHandler(this.btnAddStorePlaces_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(198, 25);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(554, 25);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Neo Sans Arabic", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(182)))), ((int)(((byte)(92)))));
            this.label2.Location = new System.Drawing.Point(486, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "المخازن";
            // 
            // Stores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 502);
            this.Controls.Add(this.tLPanProductsContainer);
            this.Name = "Stores";
            this.Text = "Stores";
            this.Load += new System.EventHandler(this.Stores_Load);
            this.tLPanProductsContainer.ResumeLayout(false);
            this.tLPanFilter.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLPanProductsContainer;
        private System.Windows.Forms.TableLayoutPanel tLPanFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tLPanSearch;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Bunifu.Framework.UI.BunifuTileButton btnDeleteStore;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Store_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Store_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Store_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Store_Phone;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddStorePlaces;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
    }
}