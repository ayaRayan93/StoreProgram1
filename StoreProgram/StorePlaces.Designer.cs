namespace StoreProgram
{
    partial class StorePlaces
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panHeader = new System.Windows.Forms.Panel();
            this.panClose = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labStoreName = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewStorePlace = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteStorePlace = new System.Windows.Forms.Button();
            this.panHeader.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorePlace)).BeginInit();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(182)))), ((int)(((byte)(92)))));
            this.panHeader.Controls.Add(this.panClose);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(573, 36);
            this.panHeader.TabIndex = 23;
            // 
            // panClose
            // 
            this.panClose.BackgroundImage = global::StoreProgram.Properties.Resources.Delete_52px;
            this.panClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.panClose.Location = new System.Drawing.Point(527, 0);
            this.panClose.Name = "panClose";
            this.panClose.Size = new System.Drawing.Size(46, 36);
            this.panClose.TabIndex = 0;
            this.panClose.Click += new System.EventHandler(this.panClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Neo Sans Arabic", 12F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(276, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 36);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(182)))), ((int)(((byte)(92)))));
            this.label1.Location = new System.Drawing.Point(456, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = ":مكان التخزين";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(276, 132);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 20);
            this.txtName.TabIndex = 20;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(182)))), ((int)(((byte)(92)))));
            this.label2.Location = new System.Drawing.Point(456, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = ":المخزن";
            // 
            // labStoreName
            // 
            this.labStoreName.AutoSize = true;
            this.labStoreName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labStoreName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.labStoreName.Location = new System.Drawing.Point(277, 92);
            this.labStoreName.Name = "labStoreName";
            this.labStoreName.Size = new System.Drawing.Size(0, 19);
            this.labStoreName.TabIndex = 25;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panHeader;
            this.bunifuDragControl1.Vertical = true;
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.ColumnCount = 1;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel20.Controls.Add(this.btnDeleteStorePlace, 0, 1);
            this.tableLayoutPanel20.Controls.Add(this.dataGridViewStorePlace, 0, 0);
            this.tableLayoutPanel20.Location = new System.Drawing.Point(12, 42);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 2;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(234, 288);
            this.tableLayoutPanel20.TabIndex = 26;
            // 
            // dataGridViewStorePlace
            // 
            this.dataGridViewStorePlace.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewStorePlace.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStorePlace.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewStorePlace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStorePlace.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(182)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStorePlace.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStorePlace.ColumnHeadersHeight = 25;
            this.dataGridViewStorePlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStorePlace.DoubleBuffered = true;
            this.dataGridViewStorePlace.EnableHeadersVisualStyles = false;
            this.dataGridViewStorePlace.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(182)))), ((int)(((byte)(92)))));
            this.dataGridViewStorePlace.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewStorePlace.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewStorePlace.Name = "dataGridViewStorePlace";
            this.dataGridViewStorePlace.ReadOnly = true;
            this.dataGridViewStorePlace.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewStorePlace.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewStorePlace.Size = new System.Drawing.Size(228, 238);
            this.dataGridViewStorePlace.TabIndex = 4;
            this.dataGridViewStorePlace.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStorePlace_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 337);
            this.panel1.TabIndex = 27;
            // 
            // btnDeleteStorePlace
            // 
            this.btnDeleteStorePlace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(68)))), ((int)(((byte)(53)))));
            this.btnDeleteStorePlace.FlatAppearance.BorderSize = 0;
            this.btnDeleteStorePlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStorePlace.Font = new System.Drawing.Font("Neo Sans Arabic", 12F);
            this.btnDeleteStorePlace.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeleteStorePlace.Location = new System.Drawing.Point(3, 247);
            this.btnDeleteStorePlace.Name = "btnDeleteStorePlace";
            this.btnDeleteStorePlace.Size = new System.Drawing.Size(84, 36);
            this.btnDeleteStorePlace.TabIndex = 28;
            this.btnDeleteStorePlace.Text = "حذف";
            this.btnDeleteStorePlace.UseVisualStyleBackColor = false;
            // 
            // StorePlaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 337);
            this.Controls.Add(this.tableLayoutPanel20);
            this.Controls.Add(this.labStoreName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panHeader);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StorePlaces";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StorePlaces";
            this.Load += new System.EventHandler(this.StorePlaces_Load);
            this.panHeader.ResumeLayout(false);
            this.tableLayoutPanel20.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStorePlace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Panel panClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labStoreName;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewStorePlace;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteStorePlace;
    }
}