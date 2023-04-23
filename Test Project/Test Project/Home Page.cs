using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
namespace Test_Project
{
    public partial class Home_Page : Form
    {
        public static string connectionstring = "Data Source = DESKTOP-APAG323; Initial Catalog = Test Project; Integrated Security =true";
        public Home_Page()
        {
            InitializeComponent();
        }
        private void Home_Page_Load(object sender, EventArgs e)
        {
        }
        public static Category_Master Category_Masterobject = new Category_Master();
        public static Product_Master Product_Masterobject = new Product_Master();
        public static int ctrCategoryMaster;
        public static int ctrProductMaster;
        private void CategoryMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int click = 0;
            if (ctrCategoryMaster == 0)
            {
                Category_Masterobject.MdiParent = this;
                Category_Masterobject.Show();
                ctrCategoryMaster = 1;
                click = 1;
            }
            if (ctrCategoryMaster == 1 && click == 0)
            {
                this.ActivateMdiChild(Category_Masterobject);
                Category_Masterobject.BringToFront();
                if (Category_Masterobject.WindowState == FormWindowState.Minimized)
                { Category_Masterobject.WindowState = FormWindowState.Maximized; }
            }
            Category_Masterobject.CategoryMasterButton_Click(sender, e);
        }
        private void ProductMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int click = 0;
            if (ctrProductMaster == 0)
            {
                Product_Masterobject.MdiParent = this;
                Product_Masterobject.Show();
                ctrProductMaster = 1;
                click = 1;
            }
            if (ctrProductMaster == 1 && click == 0)
            {
                this.ActivateMdiChild(Product_Masterobject);
                Product_Masterobject.BringToFront();
                if (Product_Masterobject.WindowState == FormWindowState.Minimized)
                { Product_Masterobject.WindowState = FormWindowState.Maximized; }
            }
            Product_Masterobject.ProductMasterButton_Click(sender, e);
        }

    }
}