using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreProgram
{
    public partial class MainStoreForm : Form
    {
        TabPage StoreTP;
        bool flag = false;
        Panel panOpeningAcount;
        Panel panCoding;
        Panel panGate, panImport, panReturn, panExport, panLost, panTransfer, panGart, panEquipment, panReport;
        System.Threading.Timer loadBacGround;
        public MainStoreForm()
        {
            try
            {
                InitializeComponent();
                loadBacGround = new System.Threading.Timer(SetBackground);
                intializeStorePanel();
                intializeStoreCodingPanel();
                intializeStoreGatePanel();
                initializeStorepanImportPanel();
                initializeStorepanReturnPanel();
                initializeStorepanExportPanel();
                initializeStorepanLostPanel();
                initializeStorepanTransferPanel();
                initializeStorepanGartPanel();
                initializeStorepanEquipmentPanel();
                initializeStorepanReportPanel();

                StoreTP = tabPageStore;
                tabControlMainContainer.TabPages.Remove(tabPageStore);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
   
        }

        private void SetBackground(object state)
        {
            tabPageMain.BackgroundImage = Properties.Resources.index1;
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            try
            {
                if (flag == false)
                {
                    tabControlMainContainer.TabPages.Insert(1, StoreTP);
                    flag = true;
                }
                tabControlMainContainer.TabPages[0].Hide();
                tabControlMainContainer.TabPages[1].Show();
                tabControlMainContainer.TabPages[1].Select();
                tabControlMainContainer.SelectedTab = tabControlMainContainer.TabPages[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnOpeningAcount_Click(object sender, EventArgs e)
        {
            try
            {
                resetButtonsStorePanelStyle();
                Button btn = (Button)sender;
                if (panStoreDetailTabs.Visible == true && panStoreDetailTabs.Controls.Contains(panOpeningAcount))
                {
                    panStoreDetailTabs.Controls.Clear();
                    panStoreDetailTabs.Visible = false;
                    btn.ForeColor = Color.FromArgb(242,182,92);
                    btn.BackColor = Color.FromArgb(34, 34, 34);
                }
                else
                {
                    panStoreDetailTabs.Visible = true;
                    panStoreDetailTabs.Controls.Clear();
                    panStoreDetailTabs.Controls.Add(panOpeningAcount);
                    btn.BackColor = Color.FromArgb(242,182,92);
                    btn.ForeColor = Color.FromArgb(34,34,34);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCoding_Click(object sender, EventArgs e)
        {
            try
            {
                resetButtonsStorePanelStyle();
                Button btn = (Button)sender;
                if (panStoreDetailTabs.Visible == true && panStoreDetailTabs.Controls.Contains(panCoding))
                {
                    panStoreDetailTabs.Controls.Clear();
                    panStoreDetailTabs.Visible = false;
                    btn.ForeColor = Color.FromArgb(242,182,92);
                    btn.BackColor = Color.FromArgb(34, 34, 34);
                }
                else
                {
                    panStoreDetailTabs.Visible = true;
                    panStoreDetailTabs.Controls.Clear();
                    panStoreDetailTabs.Controls.Add(panCoding);
                    btn.BackColor = Color.FromArgb(242,182,92);
                    btn.ForeColor = Color.FromArgb(34, 34, 34);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnGate_Click(object sender, EventArgs e)
        {
            try
            {
                resetButtonsStorePanelStyle();
                Button btn = (Button)sender;
                if (panStoreDetailTabs.Visible == true && panStoreDetailTabs.Controls.Contains(panGate))
                {
                    panStoreDetailTabs.Controls.Clear();
                    panStoreDetailTabs.Visible = false;
                    btn.ForeColor = Color.FromArgb(242,182,92);
                    btn.BackColor = Color.FromArgb(34, 34, 34);
                }
                else
                {
                    panStoreDetailTabs.Visible = true;
                    panStoreDetailTabs.Controls.Clear();
                    panStoreDetailTabs.Controls.Add(panGate);
                    btn.BackColor = Color.FromArgb(242,182,92);
                    btn.ForeColor = Color.FromArgb(34, 34, 34);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                resetButtonsStorePanelStyle();
                Button btn = (Button)sender;
                if (panStoreDetailTabs.Visible == true && panStoreDetailTabs.Controls.Contains(panImport))
                {
                    panStoreDetailTabs.Controls.Clear();
                    panStoreDetailTabs.Visible = false;
                    btn.ForeColor = Color.FromArgb(242,182,92);
                    btn.BackColor = Color.FromArgb(34, 34, 34);
                }
                else
                {
                    panStoreDetailTabs.Visible = true;
                    panStoreDetailTabs.Controls.Clear();
                    panStoreDetailTabs.Controls.Add(panImport);
                    btn.BackColor = Color.FromArgb(242,182,92);
                    btn.ForeColor = Color.FromArgb(34, 34, 34);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                resetButtonsStorePanelStyle();
                Button btn = (Button)sender;
                if (panStoreDetailTabs.Visible == true && panStoreDetailTabs.Controls.Contains(panReturn))
                {
                    panStoreDetailTabs.Controls.Clear();
                    panStoreDetailTabs.Visible = false;
                    btn.ForeColor = Color.FromArgb(242,182,92);
                    btn.BackColor = Color.FromArgb(34, 34, 34);
                }
                else
                {
                    panStoreDetailTabs.Visible = true;
                    panStoreDetailTabs.Controls.Clear();
                    panStoreDetailTabs.Controls.Add(panReturn);
                    btn.BackColor = Color.FromArgb(242,182,92);
                    btn.ForeColor = Color.FromArgb(34, 34, 34);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                resetButtonsStorePanelStyle();
                Button btn = (Button)sender;
                if (panStoreDetailTabs.Visible == true && panStoreDetailTabs.Controls.Contains(panExport))
                {
                    panStoreDetailTabs.Controls.Clear();
                    panStoreDetailTabs.Visible = false;
                    btn.ForeColor = Color.FromArgb(242,182,92);
                    btn.BackColor = Color.FromArgb(34, 34, 34);
                }
                else
                {
                    panStoreDetailTabs.Visible = true;
                    panStoreDetailTabs.Controls.Clear();
                    panStoreDetailTabs.Controls.Add(panExport);
                    btn.BackColor = Color.FromArgb(242,182,92);
                    btn.ForeColor = Color.FromArgb(34, 34, 34);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnLost_Click(object sender, EventArgs e)
        {
            try
            {
                resetButtonsStorePanelStyle();
                Button btn = (Button)sender;
                if (panStoreDetailTabs.Visible == true && panStoreDetailTabs.Controls.Contains(panLost))
                {
                    panStoreDetailTabs.Controls.Clear();
                    panStoreDetailTabs.Visible = false;
                    btn.ForeColor = Color.FromArgb(242,182,92);
                    btn.BackColor = Color.FromArgb(34, 34, 34);
                }
                else
                {
                    panStoreDetailTabs.Visible = true;
                    panStoreDetailTabs.Controls.Clear();
                    panStoreDetailTabs.Controls.Add(panLost);
                    btn.BackColor = Color.FromArgb(242,182,92);
                    btn.ForeColor = Color.FromArgb(34, 34, 34);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                resetButtonsStorePanelStyle();
                Button btn = (Button)sender;
                if (panStoreDetailTabs.Visible == true && panStoreDetailTabs.Controls.Contains(panTransfer))
                {
                    panStoreDetailTabs.Controls.Clear();
                    panStoreDetailTabs.Visible = false;
                    btn.ForeColor = Color.FromArgb(242,182,92);
                    btn.BackColor = Color.FromArgb(34, 34, 34);
                }
                else
                {
                    panStoreDetailTabs.Visible = true;
                    panStoreDetailTabs.Controls.Clear();
                    panStoreDetailTabs.Controls.Add(panTransfer);
                    btn.BackColor = Color.FromArgb(242,182,92);
                    btn.ForeColor = Color.FromArgb(34, 34, 34);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGart_Click(object sender, EventArgs e)
        {
            try
            {
                resetButtonsStorePanelStyle();
                Button btn = (Button)sender;
                if (panStoreDetailTabs.Visible == true && panStoreDetailTabs.Controls.Contains(panGart))
                {
                    panStoreDetailTabs.Controls.Clear();
                    panStoreDetailTabs.Visible = false;
                    btn.ForeColor = Color.FromArgb(242,182,92);
                    btn.BackColor = Color.FromArgb(34, 34, 34);
                }
                else
                {
                    panStoreDetailTabs.Visible = true;
                    panStoreDetailTabs.Controls.Clear();
                    panStoreDetailTabs.Controls.Add(panGart);
                    btn.BackColor = Color.FromArgb(242,182,92);
                    btn.ForeColor = Color.FromArgb(34, 34, 34);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEquipment_Click(object sender, EventArgs e)
        {
            try
            {
                resetButtonsStorePanelStyle();
                Button btn = (Button)sender;
                if (panStoreDetailTabs.Visible == true && panStoreDetailTabs.Controls.Contains(panEquipment))
                {
                    panStoreDetailTabs.Controls.Clear();
                    panStoreDetailTabs.Visible = false;
                    btn.ForeColor = Color.FromArgb(242,182,92);
                    btn.BackColor = Color.FromArgb(34, 34, 34);
                }
                else
                {
                    panStoreDetailTabs.Visible = true;
                    panStoreDetailTabs.Controls.Clear();
                    panStoreDetailTabs.Controls.Add(panEquipment);
                    btn.BackColor = Color.FromArgb(242,182,92);
                    btn.ForeColor = Color.FromArgb(34, 34, 34);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //تسوية مخزون
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                resetButtonsStorePanelStyle();
                Button btn = (Button)sender;
                if (panStoreDetailTabs.Visible == true && panStoreDetailTabs.Controls.Contains(panReport))
                {
                    panStoreDetailTabs.Controls.Clear();
                    panStoreDetailTabs.Visible = false;
                    btn.ForeColor = Color.FromArgb(242,182,92);
                    btn.BackColor = Color.FromArgb(34, 34, 34);
                }
                else
                {
                    panStoreDetailTabs.Visible = true;
                    panStoreDetailTabs.Controls.Clear();
                    panStoreDetailTabs.Controls.Add(panReport);
                    btn.BackColor = Color.FromArgb(242,182,92);
                    btn.ForeColor = Color.FromArgb(34, 34, 34);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //initialize store panels
        public void intializeStorePanel()
        {
            panOpeningAcount = new Panel();
            panOpeningAcount = panStyle(panOpeningAcount);
            Button btn = new Button();
            btn = btnStyle(btn);
            btn.Text = "تسجيل الكميات";
            panOpeningAcount.Controls.Add(btn);
        }
        public void intializeStoreCodingPanel()
        {
            panCoding = new Panel();
            panCoding = panStyle(panCoding);
            Button btn3 = new Button();
            btn3 = btnStyle(btn3);
            btn3.Text = "تكويد المخازن";
            btn3.Click += BtnRecordStore_Click;
            
            Button btn = new Button();
            btn = btnStyle(btn);
            btn.Text = "تسجيل عناصر البند";
            
            btn.Click += BtnProductItemsRecord_Click;
            Button btn1 = new Button();
            btn1 = btnStyle(btn1);
            btn1.Text = "تسجيل البنود";
            btn1.Click += BtnProductsRecord_Click;
           
            Button btn2 = new Button();
            btn2 = btnStyle(btn2);
            btn2.Text = "تسجيل اطقم";
           
            btn2.Click += BtnSets_Click;

            panCoding.Controls.Add(btn2);
            panCoding.Controls.Add(btn1);
            panCoding.Controls.Add(btn);
            panCoding.Controls.Add(btn3);
        }

        private void BtnSets_Click(object sender, EventArgs e)
        {
            try
            {
                tableLayoutPanelContent.Controls.Clear();
                resetButtonsStoreDetailsPanelStyle();
                Button btn = (Button)sender;
                btn.ForeColor = Color.Black;
                btn.BackColor = Color.White;
                Ataqm objForm = new Ataqm();
                objForm.TopLevel = false;
                tableLayoutPanelContent.Controls.Add(objForm);
                objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objForm.Dock = DockStyle.Fill;
                objForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnProductsRecord_Click(object sender, EventArgs e)
        {
            try
            {
                tableLayoutPanelContent.Controls.Clear();
                resetButtonsStoreDetailsPanelStyle();
                Button btn = (Button)sender;
                btn.ForeColor = Color.Black;
                btn.BackColor = Color.White;
                Products objForm = new Products();
                objForm.TopLevel = false;
                tableLayoutPanelContent.Controls.Add(objForm);
                objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objForm.Dock = DockStyle.Fill;
                objForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnProductItemsRecord_Click(object sender, EventArgs e)
        {
            try
            {
                tableLayoutPanelContent.Controls.Clear();
                resetButtonsStoreDetailsPanelStyle();
                Button btn = (Button)sender;
                btn.ForeColor = Color.Black;
                btn.BackColor = Color.White;
                ProductItems objForm = new ProductItems();
                objForm.TopLevel = false;
                tableLayoutPanelContent.Controls.Add(objForm);
                objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objForm.Dock = DockStyle.Fill;
                objForm.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRecordStore_Click(object sender, EventArgs e)
        {
            try
            {
                tableLayoutPanelContent.Controls.Clear();
                resetButtonsStoreDetailsPanelStyle();
                Button btn = (Button)sender;
                btn.ForeColor = Color.Black;
                btn.BackColor = Color.White;
                Stores objForm = new Stores();
                objForm.TopLevel = false;
                tableLayoutPanelContent.Controls.Add(objForm);
                objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                objForm.Dock = DockStyle.Fill;
                objForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void intializeStoreGatePanel()
        {
            panGate = new Panel();
            panGate = panStyle(panGate);
            Button btn = new Button();
            btn = btnStyle(btn);
            btn.Text = "تسجيل الدخول";
          
            Button btn1 = new Button();
            btn1 = btnStyle(btn1);
            btn1.Text = "تسجيل الخروج";

            panGate.Controls.Add(btn1);
            panGate.Controls.Add(btn);

        }

        public void initializeStorepanImportPanel()
        {
            panImport = new Panel();
            panImport = panStyle(panImport);
            Button btn = new Button();
            btn = btnStyle(btn);
            btn.Text = "تقرير الطلبات المتوقع استلامها";
           
            Button btn1 = new Button();
            btn1 = btnStyle(btn1);
            btn1.Text = "وارد باذن";
            
            Button btn2 = new Button();
            btn2 = btnStyle(btn2);
            btn2.Text = "وارد بدون اذن";

            panImport.Controls.Add(btn2);
            panImport.Controls.Add(btn1);
            panImport.Controls.Add(btn);
        }
        public void initializeStorepanReturnPanel()
        {
            panReturn = new Panel();
            panReturn = panStyle(panReturn);
            Button btn = new Button();
            btn = btnStyle(btn);
            btn.Text = "مرتجع عميل";
            
            Button btn1 = new Button();
            btn1 = btnStyle(btn1);
            btn1.Text = "مرتجع وارد";

            panReturn.Controls.Add(btn1);
            panReturn.Controls.Add(btn);
        }
        public void initializeStorepanExportPanel()
        {
            panExport = new Panel();
            panExport = panStyle(panExport);
            Button btn = new Button();
            btn = btnStyle(btn);
            btn.Text = "تسليم طلب";
            
            Button btn1 = new Button();
            btn1 = btnStyle(btn1);
            btn1.Text = "تسليم طلب خاص";

            panExport.Controls.Add(btn1);
            panExport.Controls.Add(btn);
        }
        public void initializeStorepanLostPanel()
        {
            panLost = new Panel();
            panLost = panStyle(panLost);
            Button btn = new Button();
            btn = btnStyle(btn);
            btn.Text = "تسجيل الهالك";
            panLost.Controls.Add(btn);
        }

       

        public void initializeStorepanTransferPanel()
        {
            panTransfer = new Panel();
            panTransfer = panStyle(panTransfer);
            Button btn = new Button();
            btn = btnStyle(btn);
            btn.Text = "تحويل من مخزن الي مخزن";
            
            Button btn1 = new Button();
            btn1 = btnStyle(btn1);
            btn1.Text = "تنقلات داخل المخزن";

            panTransfer.Controls.Add(btn1);
            panTransfer.Controls.Add(btn);
        }

        private void MainStoreForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void initializeStorepanGartPanel()
        {
            panGart = new Panel();
            panGart = panStyle(panGart);
            Button btn = new Button();
            btn = btnStyle(btn);
            btn.Text = "ادخال الكميات الحالية في المخزن";
            
            Button btn1 = new Button();
            btn1 = btnStyle(btn1);
            btn1.Text = "حساب الفاقد";
            
            Button btn2 = new Button();
            btn2 = btnStyle(btn2);
            btn2.Text = "جرد الهالك";

            panGart.Controls.Add(btn2);
            panGart.Controls.Add(btn1);
            panGart.Controls.Add(btn);
        }
        public void initializeStorepanEquipmentPanel()
        {
            panEquipment = new Panel();
            panEquipment = panStyle(panEquipment);
            Button btn = new Button();
            btn = btnStyle(btn);
            btn.Text = "تسجيل المعدة";
            
            Button btn1 = new Button();
            btn1 = btnStyle(btn1);
            btn1.Text = "المصروفات";

            panEquipment.Controls.Add(btn1);
            panEquipment.Controls.Add(btn);

        }
        public void initializeStorepanReportPanel()
        {
            panReport = new Panel();
            panReport = panStyle(panReport);
            Button btn = new Button();
            btn = btnStyle(btn);
            btn.Text = "الكميات";
            panReport.Controls.Add(btn);
        }
        //Design Function

       
        public Panel panStyle(Panel pan)
        {
            pan.Dock = DockStyle.Fill;
            pan.BackColor = Color.FromArgb(242,182,92);
            return pan;
        }
        
        public Button btnStyle(Button btn)
        {
            btn.Dock = DockStyle.Top;
            btn.BackColor = Color.FromArgb(242,182,92);
            btn.Height= 47;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            return btn;
        }
        
        public void resetButtonsStorePanelStyle()
        {
            foreach (Control btn in panStoreMainTabs.Controls)
            {
                if (btn is Button)
                {
                    btn.ForeColor = Color.FromArgb(242,182,92);
                    btn.BackColor = Color.FromArgb(34, 34, 34);
                }
            }
        }

        public void resetButtonsStoreDetailsPanelStyle()
        {
            foreach (Control pan in panStoreDetailTabs.Controls)
            {
                foreach (Control btn in pan.Controls)
                {
                    if (btn is Button)
                    {
                        btn.BackColor = Color.FromArgb(242,182,92);
                        btn.ForeColor = Color.FromArgb(34, 34, 34);
                    }
                }
            }
        }


    }
    public static class connection
    {
      // public static string connectionString = "SERVER=192.168.1.200;DATABASE=cccserver;user=Devccc;PASSWORD=rootroot;CHARSET=utf8";
       public static string connectionString = "SERVER=localhost;DATABASE=cccLocal;user=root;PASSWORD=root;CHARSET=utf8";

    }
}
