using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Test_Project
{
    public partial class Product_Master : Form
    {
        static string operationname = "";
        static string MainTable = "";
        static string TableName = "";
        public static int No = 0;
        static int rc = 0;
        static DataTable dt = new DataTable();
        public Product_Master()
        {
            InitializeComponent();

        }


        public void ProductMasterAddButton_Click(object sender, EventArgs e)
        {
            ProductMasterAddButton.Enabled = false;
            ProductMasterEditButton.Enabled = false;
            ProductMasterViewButton.Enabled = false;
            ProductMasterDeleteButton.Enabled = false;
            ProductMasterCancelButton.Enabled = true;
            ProductMasterSaveButton.Enabled = true;

            operationname = "Add";
            ProductMasterEnable();
            ProductMasterclear();
            ProductNameTextBoxProductMaster.Focus();

        }
        public void ProductMasterSaveButton_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand();
            SqlConnection con = new SqlConnection(Home_Page.connectionstring);
            if (operationname == "Add")
            {
                if (ProductIDTextBoxProductMaster.Text == "") { ProductIDTextBoxProductMaster.Text = "0"; }
                com = new SqlCommand("SELECT  MAX([ProductID]) FROM [Product Master]", con);
                con.Open();
                try
                {
                    ProductIDTextBoxProductMaster.Text = Convert.ToString(Convert.ToInt32(com.ExecuteScalar()) + 1);
                }
                catch (Exception ex)
                { ProductIDTextBoxProductMaster.Text = "1"; }
                con.Close();
                com = new SqlCommand(" INSERT INTO [Product Master] ([ProductID],[ProductName],[CategoryID],[CategoryName]) VALUES (@ProductID,@ProductName,@CategoryID,@CategoryName)", con);

                com.Parameters.AddWithValue("@ProductID", Convert.ToInt32(ProductIDTextBoxProductMaster.Text));
                com.Parameters.AddWithValue("@ProductName", ProductNameTextBoxProductMaster.Text);
                com.Parameters.AddWithValue("@CategoryID", CategoryIDComboBoxProductMaster.Text);
                com.Parameters.AddWithValue("@CategoryName", CategoryNameComboBoxProductMaster.Text);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                ProductMasterDisable();

                operationname = "";
                MessageBox.Show("Done");
                ProductMasterAddButton.Enabled = true;
                ProductMasterEditButton.Enabled = true;
                ProductMasterViewButton.Enabled = false;
                ProductMasterDeleteButton.Enabled = false;
                ProductMasterCancelButton.Enabled = false;
                ProductMasterSaveButton.Enabled = false;
                ProductMaster.Focus();
            }

            if (operationname == "Edit")
            {
                if (ProductIDTextBoxProductMaster.Text == "") { ProductIDTextBoxProductMaster.Text = "0"; }
                com = new SqlCommand(" UPDATE [Product Master] SET [ProductID]=@ProductID,[ProductName]=@ProductName,[CategoryID]=@CategoryID,[CategoryName]=@CategoryName WHERE [ProductID]=@ProductID", con);

                com.Parameters.AddWithValue("@ProductID", Convert.ToInt32(ProductIDTextBoxProductMaster.Text));
                com.Parameters.AddWithValue("@ProductName", ProductNameTextBoxProductMaster.Text);
                com.Parameters.AddWithValue("@CategoryID", CategoryIDComboBoxProductMaster.Text);
                com.Parameters.AddWithValue("@CategoryName", CategoryNameComboBoxProductMaster.Text);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                ProductMasterDisable();

                operationname = "";
                MessageBox.Show("Done");
                ProductMasterAddButton.Enabled = true;
                ProductMasterEditButton.Enabled = true;
                ProductMasterViewButton.Enabled = false;
                ProductMasterDeleteButton.Enabled = false;
                ProductMasterCancelButton.Enabled = false;
                ProductMasterSaveButton.Enabled = false;
                ProductMaster.Focus();

            }
            ms();
            

        }
        public void ProductMasterDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("You are going to delete this record permanently ,\npress OK to continue or Cancel to abort", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                if (ProductIDTextBoxProductMaster.Text == "") { ProductIDTextBoxProductMaster.Text = "0"; }
                SqlConnection con = new SqlConnection(Home_Page.connectionstring);
                SqlCommand com = new SqlCommand(" DELETE FROM [Product Master] WHERE [ProductID]=@ProductID", con);

                com.Parameters.AddWithValue("@ProductID", Convert.ToInt32(ProductIDTextBoxProductMaster.Text));
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Done");
                ms();
                ProductMasterCancelButton_Click(sender, e);
            }
           

        }
        public void ProductMasterSearchButton_Click(object sender, EventArgs e)
        {

        }
        public void ProductMasterEditButton_Click(object sender, EventArgs e)
        {
            ProductMasterAddButton.Enabled = false;
            ProductMasterEditButton.Enabled = false;
            ProductMasterViewButton.Enabled = true;
            ProductMasterCancelButton.Enabled = true;
            ProductMasterSaveButton.Enabled = false;

            ProductMasterEnable();
            ProductMasterclear();
            operationname = "Edit";
            ProductIDTextBoxProductMaster.Focus();

        }
        public void ProductMasterViewButton_Click(object sender, EventArgs e)
        {
            ProductMasterEnterView(Convert.ToInt32(ProductIDTextBoxProductMaster.Text));
        }
        void ProductMasterEnterView(int param)
        {
            if (ProductIDTextBoxProductMaster.Text == "")
            {
                MessageBox.Show("Please Enter ProductID");
                return;
            }
            SqlConnection con = new SqlConnection(Home_Page.connectionstring);
            SqlCommand com = new SqlCommand(" SELECT * FROM [Product Master] WHERE [ProductID]=@ProductID", con);
            com.Parameters.AddWithValue("@ProductID", param);

            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();

            
            if (dt.Rows.Count > 0)
            {
                ProductIDTextBoxProductMaster.Enabled = false;

                ProductIDTextBoxProductMaster.Text = Convert.ToString(dt.Rows[0]["ProductID"]);
                ProductNameTextBoxProductMaster.Text = Convert.ToString(dt.Rows[0]["ProductName"]);
                CategoryIDComboBoxProductMaster.Text = Convert.ToString(dt.Rows[0]["CategoryID"]);
                CategoryNameComboBoxProductMaster.Text = Convert.ToString(dt.Rows[0]["CategoryName"]);
                MessageBox.Show("Done");
                ProductMasterAddButton.Enabled = false;
                ProductMasterEditButton.Enabled = false;
                ProductMasterViewButton.Enabled = false;
                ProductMasterDeleteButton.Enabled = true;
                ProductMasterCancelButton.Enabled = true;
                ProductMasterSaveButton.Enabled = true;
            }
            else { MessageBox.Show("No records found"); }

        }
        public void ProductMasterCancelButton_Click(object sender, EventArgs e)
        {
            ProductMasterAddButton.Enabled = true;
            ProductMasterEditButton.Enabled = true;
            ProductMasterViewButton.Enabled = false;
            ProductMasterDeleteButton.Enabled = false;
            ProductMasterCancelButton.Enabled = false;
            ProductMasterSaveButton.Enabled = false;
            ProductMasterclear();

            operationname = "";
            ProductMasterDisable();
            ProductMaster.Focus();

        }
        public void ms()
        {
            dt.Rows.Clear();
            SqlCommand com = new SqlCommand();
            SqlConnection con = new SqlConnection(Home_Page.connectionstring);
            com = new SqlCommand("select * from [product master] order by productid", con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            dt.Load(dr);
            con.Close();
            rc = 0;
            int counter = 0;
            int ctr=0;
            GridView1.Rows.Clear();

            if (dt.Rows.Count > 10)
            {
                button1.Enabled = true;
                counter = 10;
            }
            else
            {
                button1.Enabled = false;
                counter = dt.Rows.Count;
            }
            for (int i = rc; i < counter; i++)
            {
                GridView1.Rows.Add();
                GridView1.Rows[ctr].Cells[0].Value = Convert.ToString(dt.Rows[i][0]);
                GridView1.Rows[ctr].Cells[1].Value = Convert.ToString(dt.Rows[i][1]);
                GridView1.Rows[ctr].Cells[2].Value = Convert.ToString(dt.Rows[i][2]);
                GridView1.Rows[ctr].Cells[3].Value = Convert.ToString(dt.Rows[i][3]);
                ctr++;
                
            }
            rc = rc + counter;


        }
        private void Product_Master_Load(object sender, EventArgs e)
        {
            this.Text = "Product Master";
            ms();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (DateParameterCheck.CheckState == CheckState.Checked)
            {
                DateParameterCheck.BackColor = Color.Red;
                FromDateSearch.Enabled = true;
                ToDateSearch.Enabled = true;
                DateFieldName.Enabled = true;
                ShowRecordsButton.Enabled = true;
                try
                {
                    DateFieldName.SelectedIndex = 0;
                }
                catch (Exception ex) { }
            }
            if (DateParameterCheck.CheckState == CheckState.Unchecked)
            {
                DateParameterCheck.BackColor = Color.Transparent;
                FromDateSearch.Enabled = false;
                ToDateSearch.Enabled = false;
                DateFieldName.Enabled = false;
                if (SearchByParameterCheck.CheckState == CheckState.Unchecked)
                { ShowRecordsButton.Enabled = false; }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (SearchByParameterCheck.CheckState == CheckState.Checked)
            {
                SearchByParameterCheck.BackColor = Color.Red;
                SearchByComboBox.Enabled = true;
                SelectValueComboBox.Enabled = true;
                CompareTypeComboBox.Enabled = true;
                ShowRecordsButton.Enabled = true;
                CompareTypeComboBox.SelectedIndex = 0;
            }
            if (SearchByParameterCheck.CheckState == CheckState.Unchecked)
            {
                SearchByParameterCheck.BackColor = Color.Transparent;
                SearchByComboBox.Enabled = false;
                SelectValueComboBox.Enabled = false;
                CompareTypeComboBox.Enabled = false;
                if (DateParameterCheck.CheckState == CheckState.Unchecked)
                { ShowRecordsButton.Enabled = false; }
            }
        }
        private void SearchByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand();
            string selecttable = "Product Master";
            if (MainTable == "Main")
            {
                selecttable = TableName;
            }
            com.CommandText = "Select * From [" + selecttable + "]";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Home_Page.connectionstring;
            com.Connection = con;
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();
            SelectValueComboBox.DataSource = dt;
            SelectValueComboBox.ValueMember = SearchByComboBox.Text;
            SelectValueComboBox.DisplayMember = SearchByComboBox.Text;
        }
        private void ShowRecordsButton_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand();
            string selecttable = "Product Master";
            if (MainTable == "Main")
            {
                selecttable = TableName;
            }
            string query = "";
            query = "Select * From [" + selecttable + "] Where";
            if (SearchByParameterCheck.CheckState == CheckState.Checked)
            {
                query = query + "[" + SearchByComboBox.Text + "]" + CompareTypeComboBox.Text + "@PARAM1 AND";
                com.Parameters.AddWithValue("@PARAM1", SelectValueComboBox.Text);
            }
            if (DateParameterCheck.CheckState == CheckState.Checked)
            {
                query = query + "[" + DateFieldName.Text + "]>= @DATE1 AND";
                com.Parameters.AddWithValue("@DATE1", Convert.ToDateTime(FromDateSearch.Value.ToShortDateString()));
            }
            if (DateParameterCheck.CheckState == CheckState.Checked)
            {
                query = query + "[" + DateFieldName.Text + "]<= @DATE2 AND";
                com.Parameters.AddWithValue("@DATE2", Convert.ToDateTime(ToDateSearch.Value.AddDays(1).ToShortDateString()).AddSeconds(-1));
            }
            query = query.Substring(0, Convert.ToInt32(query.Length) - 3);
            com.CommandText = query;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Home_Page.connectionstring;
            com.Connection = con;
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();
            GridView1.DataSource = dt;
            if (MainTable == "Main")
            {
            }
            else
            {
            }
            if (dt.Rows.Count > 0)
            {
            }
            else
            { MessageBox.Show("No records found"); }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home_Page.ctrProductMaster = 0;
        }
        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            int click = 0;
            if (this.Dock == DockStyle.Fill && click == 0)
            {
                this.Dock = DockStyle.None;
                click = 1;
            }
            if (this.Dock == DockStyle.None && click == 0)
            {
                this.Dock = DockStyle.Fill;
                click = 1;
            }
        }
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void ProductMasterBackButton_Click(object sender, EventArgs e)
        {
            ProductMaster.Visible = false;
            MainTable = "";
            OperationButtonsPanel.Visible = false;
            BindingSource clearbs = new BindingSource();
            GridView1.DataSource = clearbs;
            SelectValueComboBox.DataSource = clearbs;
            DateFieldName.Items.Clear();
            DateFieldName.Items.Add("Select Operation");
            SearchByComboBox.Items.Clear();
            SearchByComboBox.Items.Add("Select Operation");
            SearchByComboBox.Text = "";
            SearchByParameterCheck.CheckState = CheckState.Unchecked;
            DateParameterCheck.CheckState = CheckState.Unchecked;
        }
        public void ProductMasterButton_Click(object sender, EventArgs e)
        {
            TableName = ProductMasterButton.Text;
            ProductMaster.Visible = true;
            ProductMaster.BringToFront();
            MainTable = "Main";
            SqlCommand com = new SqlCommand();
            string selecttable = "Product Master";
            if (MainTable == "Main")
            {
                selecttable = TableName;
            }
            com.CommandText = "Select * From [" + selecttable + "]";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Home_Page.connectionstring;
            com.Connection = con;
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();
            int count = dt.Columns.Count;
            DateFieldName.Items.Clear();
            SearchByComboBox.Items.Clear();
            for (int ctr = 0; ctr < count; ctr++)
            {
                if (dt.Columns[ctr].DataType.ToString() == "System.DateTime")
                {
                    DateFieldName.Items.Add(dt.Columns[ctr].ColumnName.ToString());
                }
                else
                {
                    SearchByComboBox.Items.Add(dt.Columns[ctr].ColumnName.ToString());
                }
            }
            IndicatorLabelProductMaster.Text = ProductMasterButton.Text;
            OperationButtonsPanel.Visible = true;
            ms();
        }
        private void ProductMaster_VisibleChanged(object sender, EventArgs e)
        {
            if (ProductMaster.Visible == true)
            { ProductMaster.Focus(); }
        }
        void ProductMasterclear()
        {
            ProductIDTextBoxProductMaster.Text = "";
            ProductNameTextBoxProductMaster.Text = "";
            CategoryIDComboBoxProductMaster.Text = "";
            CategoryNameComboBoxProductMaster.Text = "";
        }

        void ProductMasterEnable()
        {
            ProductIDTextBoxProductMaster.Enabled = true;
            ProductNameTextBoxProductMaster.Enabled = true;
            CategoryIDComboBoxProductMaster.Enabled = true;
            CategoryNameComboBoxProductMaster.Enabled = true;
            SqlCommand com = new SqlCommand();
            SqlConnection con = new SqlConnection(Home_Page.connectionstring);
            com = new SqlCommand("Select * from [Category Master] order By [CategoryID]", con);
            con.Open();
            SqlDataReader dr=com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();
            CategoryIDComboBoxProductMaster.DataSource = dt;
            CategoryIDComboBoxProductMaster.DisplayMember = "CategoryID";
            CategoryIDComboBoxProductMaster.ValueMember = "CategoryID";
            CategoryNameComboBoxProductMaster.DataSource = dt;
            CategoryNameComboBoxProductMaster.DisplayMember = "CategoryName";
            CategoryNameComboBoxProductMaster.ValueMember = "CategoryName";

        }

        void ProductMasterDisable()
        {
            ProductIDTextBoxProductMaster.Enabled = false;
            ProductNameTextBoxProductMaster.Enabled = false;
            CategoryIDComboBoxProductMaster.Enabled = false;
            CategoryNameComboBoxProductMaster.Enabled = false;

        }
        private void ProductIDTextBoxProductMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                ProductMasterEnterView(Convert.ToInt32(ProductIDTextBoxProductMaster.Text));
            }
        }

        private void ShowPrintReports_Click(object sender, EventArgs e)
        {
        }

        private void ProductMaster_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int counter = 0;
            int ctr = 0;
            GridView1.Rows.Clear();
            if (rc > 10)
            {
                int lastdata = dt.Rows.Count % 10;
                counter = rc-lastdata;
                rc = rc - 10-lastdata;
                button1.Enabled = true;
            }
            else
            {
                counter = rc;
                rc = 0;
                button2.Enabled = false;
            }

            /*if (dt.Rows.Count > 10)
            {
                button1.Enabled = true;
                counter = 10;
            }
            else
            {
                button1.Enabled = false;
                counter = dt.Rows.Count;
            }*/
            for (int i = rc; i < counter; i++)
            {
                GridView1.Rows.Add();
                GridView1.Rows[ctr].Cells[0].Value = Convert.ToString(dt.Rows[i][0]);
                GridView1.Rows[ctr].Cells[1].Value = Convert.ToString(dt.Rows[i][1]);
                GridView1.Rows[ctr].Cells[2].Value = Convert.ToString(dt.Rows[i][2]);
                GridView1.Rows[ctr].Cells[3].Value = Convert.ToString(dt.Rows[i][3]);
                ctr++;

            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int counter = 0;
            int ctr = 0;
            GridView1.Rows.Clear();
            /*if (rc > 10)
            {
                rc = rc - 10;
                counter = 10;
            }
            else
            {
                counter = rc;
                button2.Enabled = false;
            }*/

            if (rc==0)
            {
                rc = 10;
            }
            if (dt.Rows.Count > 10+rc)
            {
                
                button2.Enabled = true;
                counter = 10+rc;
            }
            else
            {
                button1.Enabled = false;
                counter = dt.Rows.Count;

            }
            for (int i = rc; i < counter; i++)
            {
                GridView1.Rows.Add();
                GridView1.Rows[ctr].Cells[0].Value = Convert.ToString(dt.Rows[i][0]);
                GridView1.Rows[ctr].Cells[1].Value = Convert.ToString(dt.Rows[i][1]);
                GridView1.Rows[ctr].Cells[2].Value = Convert.ToString(dt.Rows[i][2]);
                GridView1.Rows[ctr].Cells[3].Value = Convert.ToString(dt.Rows[i][3]);
                ctr++;

            }
            rc = rc + ctr;


        }

        private void GridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }

}