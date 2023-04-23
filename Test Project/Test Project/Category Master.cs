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
    public partial class Category_Master : Form
    {
        static string operationname = "";
        static string MainTable = "";
        static string TableName = "";
        public static int No = 0;
        //Accounts ac = new Accounts();
        public Category_Master()
        {
            InitializeComponent();

        }


        public void CategoryMasterAddButton_Click(object sender, EventArgs e)
        {
            CategoryMasterAddButton.Enabled = false;
            CategoryMasterEditButton.Enabled = false;
            CategoryMasterViewButton.Enabled = false;
            CategoryMasterDeleteButton.Enabled = false;
            CategoryMasterCancelButton.Enabled = true;
            CategoryMasterSaveButton.Enabled = true;

            operationname = "Add";
            CategoryMasterEnable();
            CategoryMasterclear();
            CategoryNameTextBoxCategoryMaster.Focus();

        }
        public void CategoryMasterSaveButton_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand();
            SqlConnection con = new SqlConnection(Home_Page.connectionstring);
            if (operationname == "Add")
            {
                if (CategoryIDTextBoxCategoryMaster.Text == "") { CategoryIDTextBoxCategoryMaster.Text = "0"; }
                com = new SqlCommand("SELECT  MAX([CategoryID]) FROM [Category Master]", con);
                con.Open();
                try
                {
                    CategoryIDTextBoxCategoryMaster.Text = Convert.ToString(Convert.ToInt32(com.ExecuteScalar()) + 1);
                }
                catch (Exception ex)
                { CategoryIDTextBoxCategoryMaster.Text = "1"; }
                con.Close();
                com = new SqlCommand(" INSERT INTO [Category Master] ([CategoryID],[CategoryName]) VALUES (@CategoryID,@CategoryName)", con);

                com.Parameters.AddWithValue("@CategoryID", Convert.ToInt32(CategoryIDTextBoxCategoryMaster.Text));
                com.Parameters.AddWithValue("@CategoryName", CategoryNameTextBoxCategoryMaster.Text);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                CategoryMasterDisable();

                operationname = "";
                MessageBox.Show("Done");
                CategoryMasterAddButton.Enabled = true;
                CategoryMasterEditButton.Enabled = true;
                CategoryMasterViewButton.Enabled = false;
                CategoryMasterDeleteButton.Enabled = false;
                CategoryMasterCancelButton.Enabled = false;
                CategoryMasterSaveButton.Enabled = false;
                CategoryMaster.Focus();
            }

            if (operationname == "Edit")
            {
                if (CategoryIDTextBoxCategoryMaster.Text == "") { CategoryIDTextBoxCategoryMaster.Text = "0"; }
                com = new SqlCommand(" UPDATE [Category Master] SET [CategoryID]=@CategoryID,[CategoryName]=@CategoryName WHERE [CategoryID]=@CategoryID", con);

                com.Parameters.AddWithValue("@CategoryID", Convert.ToInt32(CategoryIDTextBoxCategoryMaster.Text));
                com.Parameters.AddWithValue("@CategoryName", CategoryNameTextBoxCategoryMaster.Text);
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                CategoryMasterDisable();

                operationname = "";
                MessageBox.Show("Done");
                CategoryMasterAddButton.Enabled = true;
                CategoryMasterEditButton.Enabled = true;
                CategoryMasterViewButton.Enabled = false;
                CategoryMasterDeleteButton.Enabled = false;
                CategoryMasterCancelButton.Enabled = false;
                CategoryMasterSaveButton.Enabled = false;
                CategoryMaster.Focus();

            }
            FillGrid();

        }
        public void CategoryMasterDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("You are going to delete this record permanently ,\npress OK to continue or Cancel to abort", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                if (CategoryIDTextBoxCategoryMaster.Text == "") { CategoryIDTextBoxCategoryMaster.Text = "0"; }
                SqlConnection con = new SqlConnection(Home_Page.connectionstring);
                SqlCommand com = new SqlCommand(" DELETE FROM [Category Master] WHERE [CategoryID]=@CategoryID", con);

                com.Parameters.AddWithValue("@CategoryID", Convert.ToInt32(CategoryIDTextBoxCategoryMaster.Text));
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Done");
                FillGrid();
                CategoryMasterCancelButton_Click(sender, e);
            }

        }
        public void CategoryMasterSearchButton_Click(object sender, EventArgs e)
        {

        }
        public void CategoryMasterEditButton_Click(object sender, EventArgs e)
        {
            CategoryMasterAddButton.Enabled = false;
            CategoryMasterEditButton.Enabled = false;
            CategoryMasterViewButton.Enabled = true;
            CategoryMasterCancelButton.Enabled = true;
            CategoryMasterSaveButton.Enabled = false;

            CategoryMasterEnable();
            CategoryMasterclear();
            operationname = "Edit";
            CategoryIDTextBoxCategoryMaster.Focus();

        }
        public void CategoryMasterViewButton_Click(object sender, EventArgs e)
        {
            CategoryMasterEnterView(Convert.ToInt32(CategoryIDTextBoxCategoryMaster.Text));
        }
        void CategoryMasterEnterView(int param)
        {
            if (CategoryIDTextBoxCategoryMaster.Text == "")
            {
                MessageBox.Show("Please Enter CategoryID");
                return;
            }
            SqlConnection con = new SqlConnection(Home_Page.connectionstring);
            SqlCommand com = new SqlCommand(" SELECT * FROM [Category Master] WHERE [CategoryID]=@CategoryID", con);
            com.Parameters.AddWithValue("@CategoryID", param);

            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();

            //GridView1.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                CategoryIDTextBoxCategoryMaster.Enabled = false;

                CategoryIDTextBoxCategoryMaster.Text = Convert.ToString(dt.Rows[0]["CategoryID"]);
                CategoryNameTextBoxCategoryMaster.Text = Convert.ToString(dt.Rows[0]["CategoryName"]);
                MessageBox.Show("Done");
                CategoryMasterAddButton.Enabled = false;
                CategoryMasterEditButton.Enabled = false;
                CategoryMasterViewButton.Enabled = false;
                CategoryMasterDeleteButton.Enabled = true;
                CategoryMasterCancelButton.Enabled = true;
                CategoryMasterSaveButton.Enabled = true;
            }
            else { MessageBox.Show("No records found"); }

        }
        void FillGrid()
        {
            SqlConnection con = new SqlConnection(Home_Page.connectionstring);
            SqlCommand com = new SqlCommand(" SELECT * FROM [Category Master] Order BY [CategoryID]", con);
            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            con.Close();
            GridView1.DataSource = dt;
        }
        public void CategoryMasterCancelButton_Click(object sender, EventArgs e)
        {
            CategoryMasterAddButton.Enabled = true;
            CategoryMasterEditButton.Enabled = true;
            CategoryMasterViewButton.Enabled = false;
            CategoryMasterDeleteButton.Enabled = false;
            CategoryMasterCancelButton.Enabled = false;
            CategoryMasterSaveButton.Enabled = false;
            CategoryMasterclear();

            operationname = "";
            CategoryMasterDisable();
            CategoryMaster.Focus();

        }
        private void Category_Master_Load(object sender, EventArgs e)
        {
            
            this.Text = "Category Master";
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
            string selecttable = "Category Master";
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
            string selecttable = "Category Master";
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
            Home_Page.ctrCategoryMaster = 0;
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
        private void CategoryMasterBackButton_Click(object sender, EventArgs e)
        {
            CategoryMaster.Visible = false;
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
        public void CategoryMasterButton_Click(object sender, EventArgs e)
        {
            FillGrid();
            TableName = CategoryMasterButton.Text;
            CategoryMaster.Visible = true;
            CategoryMaster.BringToFront();
            MainTable = "Main";
            SqlCommand com = new SqlCommand();
            string selecttable = "Category Master";
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
            IndicatorLabelCategoryMaster.Text = CategoryMasterButton.Text;
            OperationButtonsPanel.Visible = true;
        }
        private void CategoryMaster_VisibleChanged(object sender, EventArgs e)
        {
            if (CategoryMaster.Visible == true)
            { CategoryMaster.Focus(); }
        }
        void CategoryMasterclear()
        {
            CategoryIDTextBoxCategoryMaster.Text = "";
            CategoryNameTextBoxCategoryMaster.Text = "";
        }

        void CategoryMasterEnable()
        {
            CategoryIDTextBoxCategoryMaster.Enabled = true;
            CategoryNameTextBoxCategoryMaster.Enabled = true;

        }

        void CategoryMasterDisable()
        {
            CategoryIDTextBoxCategoryMaster.Enabled = false;
            CategoryNameTextBoxCategoryMaster.Enabled = false;

        }
        private void CategoryIDTextBoxCategoryMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                CategoryMasterEnterView(Convert.ToInt32(CategoryIDTextBoxCategoryMaster.Text));
            }
        }

        private void ShowPrintReports_Click(object sender, EventArgs e)
        {
        }

    }

}