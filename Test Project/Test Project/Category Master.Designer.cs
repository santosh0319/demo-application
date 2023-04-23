namespace Test_Project
{
partial class Category_Master
{
/// <summary>
/// Required designer variable.
/// </summary>
private System.ComponentModel.IContainer components = null;

/// <summary>
/// Clean up any resources being used.\n/// </summary>
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
/// the contents of this method with the code editor.\n/// </summary>
  
private void InitializeComponent()
{
    this.components = new System.ComponentModel.Container();
    this.CategoryIDTextBoxCategoryMaster = new System.Windows.Forms.TextBox();
    this.CategoryMaster = new System.Windows.Forms.Panel();
    this.CategoryMastercontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
    this.addToolStripMenuItemCategoryMaster = new System.Windows.Forms.ToolStripMenuItem();
    this.editToolStripMenuItemCategoryMaster = new System.Windows.Forms.ToolStripMenuItem();
    this.saveToolStripMenuItemCategoryMaster = new System.Windows.Forms.ToolStripMenuItem();
    this.cancelToolStripMenuItemCategoryMaster = new System.Windows.Forms.ToolStripMenuItem();
    this.backToolStripMenuItemCategoryMaster = new System.Windows.Forms.ToolStripMenuItem();
    this.CategoryMasterDeleteButton = new System.Windows.Forms.Button();
    this.CategoryMasterViewButton = new System.Windows.Forms.Button();
    this.CategoryMasterCancelButton = new System.Windows.Forms.Button();
    this.CategoryMasterSaveButton = new System.Windows.Forms.Button();
    this.CategoryMasterEditButton = new System.Windows.Forms.Button();
    this.CategoryMasterAddButton = new System.Windows.Forms.Button();
    this.IndicatorLabelCategoryMaster = new System.Windows.Forms.Label();
    this.CategoryIDCategoryMasterLabel = new System.Windows.Forms.Label();
    this.CategoryNameTextBoxCategoryMaster = new System.Windows.Forms.TextBox();
    this.CategoryNameCategoryMasterLabel = new System.Windows.Forms.Label();
    this.CategoryMasterButton = new System.Windows.Forms.Button();
    this.DownPanel = new System.Windows.Forms.Panel();
    this.GridView1 = new System.Windows.Forms.DataGridView();
    this.OperationButtonsPanel = new System.Windows.Forms.Panel();
    this.UpPanel = new System.Windows.Forms.Panel();
    this.ClosePanel = new System.Windows.Forms.Panel();
    this.ControlBoxPanel = new System.Windows.Forms.Panel();
    this.CloseButton = new System.Windows.Forms.Button();
    this.MaximizeButton = new System.Windows.Forms.Button();
    this.MinimizeButton = new System.Windows.Forms.Button();
    this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
    this.SearchPanel = new System.Windows.Forms.Panel();
    this.ViewPrintReportsGroupBox = new System.Windows.Forms.GroupBox();
    this.ShowPrintReports = new System.Windows.Forms.Button();
    this.ReportsComboBox = new System.Windows.Forms.ComboBox();
    this.SearchPanelGroupBox = new System.Windows.Forms.GroupBox();
    this.DateFieldNameLabel = new System.Windows.Forms.Label();
    this.DateFieldName = new System.Windows.Forms.ComboBox();
    this.ShowRecordsButton = new System.Windows.Forms.Button();
    this.CompareTypeComboBox = new System.Windows.Forms.ComboBox();
    this.CompareTypeLabel = new System.Windows.Forms.Label();
    this.SearchByParameterCheck = new System.Windows.Forms.CheckBox();
    this.DateParameterCheck = new System.Windows.Forms.CheckBox();
    this.SelectValueLabel = new System.Windows.Forms.Label();
    this.SelectValueComboBox = new System.Windows.Forms.ComboBox();
    this.SearchByComboBox = new System.Windows.Forms.ComboBox();
    this.SearchByLabel = new System.Windows.Forms.Label();
    this.ToDateLabel = new System.Windows.Forms.Label();
    this.FromDateLabel = new System.Windows.Forms.Label();
    this.ToDateSearch = new System.Windows.Forms.DateTimePicker();
    this.FromDateSearch = new System.Windows.Forms.DateTimePicker();
    this.CategoryMaster.SuspendLayout();
    this.CategoryMastercontextMenuStrip.SuspendLayout();
    this.DownPanel.SuspendLayout();
    ((System.ComponentModel.ISupportInitialize)(this.GridView1)).BeginInit();
    this.UpPanel.SuspendLayout();
    this.ClosePanel.SuspendLayout();
    this.ControlBoxPanel.SuspendLayout();
    this.SearchPanel.SuspendLayout();
    this.ViewPrintReportsGroupBox.SuspendLayout();
    this.SearchPanelGroupBox.SuspendLayout();
    this.SuspendLayout();
    // 
    // CategoryIDTextBoxCategoryMaster
    // 
    this.CategoryIDTextBoxCategoryMaster.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
    this.CategoryIDTextBoxCategoryMaster.Enabled = false;
    this.CategoryIDTextBoxCategoryMaster.Location = new System.Drawing.Point(165, 11);
    this.CategoryIDTextBoxCategoryMaster.Name = "CategoryIDTextBoxCategoryMaster";
    this.CategoryIDTextBoxCategoryMaster.Size = new System.Drawing.Size(97, 28);
    this.CategoryIDTextBoxCategoryMaster.TabIndex = 0;
    this.CategoryIDTextBoxCategoryMaster.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CategoryIDTextBoxCategoryMaster_KeyDown);
    // 
    // CategoryMaster
    // 
    this.CategoryMaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    this.CategoryMaster.ContextMenuStrip = this.CategoryMastercontextMenuStrip;
    this.CategoryMaster.Controls.Add(this.CategoryMasterDeleteButton);
    this.CategoryMaster.Controls.Add(this.CategoryMasterButton);
    this.CategoryMaster.Controls.Add(this.CategoryMasterViewButton);
    this.CategoryMaster.Controls.Add(this.CategoryMasterCancelButton);
    this.CategoryMaster.Controls.Add(this.CategoryMasterSaveButton);
    this.CategoryMaster.Controls.Add(this.CategoryMasterEditButton);
    this.CategoryMaster.Controls.Add(this.CategoryMasterAddButton);
    this.CategoryMaster.Controls.Add(this.CategoryIDTextBoxCategoryMaster);
    this.CategoryMaster.Controls.Add(this.IndicatorLabelCategoryMaster);
    this.CategoryMaster.Controls.Add(this.CategoryIDCategoryMasterLabel);
    this.CategoryMaster.Controls.Add(this.CategoryNameTextBoxCategoryMaster);
    this.CategoryMaster.Controls.Add(this.CategoryNameCategoryMasterLabel);
    this.CategoryMaster.Dock = System.Windows.Forms.DockStyle.Fill;
    this.CategoryMaster.Location = new System.Drawing.Point(0, 0);
    this.CategoryMaster.Name = "CategoryMaster";
    this.CategoryMaster.Size = new System.Drawing.Size(1320, 218);
    this.CategoryMaster.TabIndex = 0;
    this.CategoryMaster.Visible = false;
    this.CategoryMaster.VisibleChanged += new System.EventHandler(this.CategoryMaster_VisibleChanged);
    // 
    // CategoryMastercontextMenuStrip
    // 
    this.CategoryMastercontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItemCategoryMaster,
            this.editToolStripMenuItemCategoryMaster,
            this.saveToolStripMenuItemCategoryMaster,
            this.cancelToolStripMenuItemCategoryMaster,
            this.backToolStripMenuItemCategoryMaster});
    this.CategoryMastercontextMenuStrip.Name = "CategoryMastercontextMenuStrip";
    this.CategoryMastercontextMenuStrip.Size = new System.Drawing.Size(197, 154);
    // 
    // addToolStripMenuItemCategoryMaster
    // 
    this.addToolStripMenuItemCategoryMaster.Name = "addToolStripMenuItemCategoryMaster";
    this.addToolStripMenuItemCategoryMaster.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
    this.addToolStripMenuItemCategoryMaster.Size = new System.Drawing.Size(196, 30);
    this.addToolStripMenuItemCategoryMaster.Text = "Add";
    this.addToolStripMenuItemCategoryMaster.Click += new System.EventHandler(this.CategoryMasterAddButton_Click);
    // 
    // editToolStripMenuItemCategoryMaster
    // 
    this.editToolStripMenuItemCategoryMaster.Name = "editToolStripMenuItemCategoryMaster";
    this.editToolStripMenuItemCategoryMaster.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
    this.editToolStripMenuItemCategoryMaster.Size = new System.Drawing.Size(196, 30);
    this.editToolStripMenuItemCategoryMaster.Text = "Edit";
    this.editToolStripMenuItemCategoryMaster.Click += new System.EventHandler(this.CategoryMasterEditButton_Click);
    // 
    // saveToolStripMenuItemCategoryMaster
    // 
    this.saveToolStripMenuItemCategoryMaster.Name = "saveToolStripMenuItemCategoryMaster";
    this.saveToolStripMenuItemCategoryMaster.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
    this.saveToolStripMenuItemCategoryMaster.Size = new System.Drawing.Size(196, 30);
    this.saveToolStripMenuItemCategoryMaster.Text = "Save";
    this.saveToolStripMenuItemCategoryMaster.Click += new System.EventHandler(this.CategoryMasterSaveButton_Click);
    // 
    // cancelToolStripMenuItemCategoryMaster
    // 
    this.cancelToolStripMenuItemCategoryMaster.Name = "cancelToolStripMenuItemCategoryMaster";
    this.cancelToolStripMenuItemCategoryMaster.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
    this.cancelToolStripMenuItemCategoryMaster.Size = new System.Drawing.Size(196, 30);
    this.cancelToolStripMenuItemCategoryMaster.Text = "Cancel";
    this.cancelToolStripMenuItemCategoryMaster.Click += new System.EventHandler(this.CategoryMasterCancelButton_Click);
    // 
    // backToolStripMenuItemCategoryMaster
    // 
    this.backToolStripMenuItemCategoryMaster.Name = "backToolStripMenuItemCategoryMaster";
    this.backToolStripMenuItemCategoryMaster.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
    this.backToolStripMenuItemCategoryMaster.Size = new System.Drawing.Size(196, 30);
    this.backToolStripMenuItemCategoryMaster.Text = "Cancel";
    this.backToolStripMenuItemCategoryMaster.Click += new System.EventHandler(this.CategoryMasterBackButton_Click);
    // 
    // CategoryMasterDeleteButton
    // 
    this.CategoryMasterDeleteButton.AutoSize = true;
    this.CategoryMasterDeleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
    this.CategoryMasterDeleteButton.Enabled = false;
    this.CategoryMasterDeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
    this.CategoryMasterDeleteButton.ForeColor = System.Drawing.Color.Navy;
    this.CategoryMasterDeleteButton.Location = new System.Drawing.Point(426, 40);
    this.CategoryMasterDeleteButton.Name = "CategoryMasterDeleteButton";
    this.CategoryMasterDeleteButton.Size = new System.Drawing.Size(85, 30);
    this.CategoryMasterDeleteButton.TabIndex = 0;
    this.CategoryMasterDeleteButton.Text = "Delete";
    this.toolTip1.SetToolTip(this.CategoryMasterDeleteButton, "Delete");
    this.CategoryMasterDeleteButton.UseVisualStyleBackColor = true;
    this.CategoryMasterDeleteButton.Click += new System.EventHandler(this.CategoryMasterDeleteButton_Click);
    // 
    // CategoryMasterViewButton
    // 
    this.CategoryMasterViewButton.AutoSize = true;
    this.CategoryMasterViewButton.Cursor = System.Windows.Forms.Cursors.Hand;
    this.CategoryMasterViewButton.Enabled = false;
    this.CategoryMasterViewButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
    this.CategoryMasterViewButton.ForeColor = System.Drawing.Color.Navy;
    this.CategoryMasterViewButton.Location = new System.Drawing.Point(342, 40);
    this.CategoryMasterViewButton.Name = "CategoryMasterViewButton";
    this.CategoryMasterViewButton.Size = new System.Drawing.Size(85, 30);
    this.CategoryMasterViewButton.TabIndex = 0;
    this.CategoryMasterViewButton.Text = "View";
    this.toolTip1.SetToolTip(this.CategoryMasterViewButton, "View");
    this.CategoryMasterViewButton.UseVisualStyleBackColor = true;
    this.CategoryMasterViewButton.Click += new System.EventHandler(this.CategoryMasterViewButton_Click);
    // 
    // CategoryMasterCancelButton
    // 
    this.CategoryMasterCancelButton.AutoSize = true;
    this.CategoryMasterCancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
    this.CategoryMasterCancelButton.Enabled = false;
    this.CategoryMasterCancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
    this.CategoryMasterCancelButton.ForeColor = System.Drawing.Color.Navy;
    this.CategoryMasterCancelButton.Location = new System.Drawing.Point(258, 40);
    this.CategoryMasterCancelButton.Name = "CategoryMasterCancelButton";
    this.CategoryMasterCancelButton.Size = new System.Drawing.Size(85, 30);
    this.CategoryMasterCancelButton.TabIndex = 0;
    this.CategoryMasterCancelButton.Text = "Cancel";
    this.toolTip1.SetToolTip(this.CategoryMasterCancelButton, "Cancel");
    this.CategoryMasterCancelButton.UseVisualStyleBackColor = true;
    this.CategoryMasterCancelButton.Click += new System.EventHandler(this.CategoryMasterCancelButton_Click);
    // 
    // CategoryMasterSaveButton
    // 
    this.CategoryMasterSaveButton.AutoSize = true;
    this.CategoryMasterSaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
    this.CategoryMasterSaveButton.Enabled = false;
    this.CategoryMasterSaveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
    this.CategoryMasterSaveButton.ForeColor = System.Drawing.Color.Navy;
    this.CategoryMasterSaveButton.Location = new System.Drawing.Point(174, 40);
    this.CategoryMasterSaveButton.Name = "CategoryMasterSaveButton";
    this.CategoryMasterSaveButton.Size = new System.Drawing.Size(85, 30);
    this.CategoryMasterSaveButton.TabIndex = 0;
    this.CategoryMasterSaveButton.Text = "Save";
    this.toolTip1.SetToolTip(this.CategoryMasterSaveButton, "Save");
    this.CategoryMasterSaveButton.UseVisualStyleBackColor = true;
    this.CategoryMasterSaveButton.Click += new System.EventHandler(this.CategoryMasterSaveButton_Click);
    // 
    // CategoryMasterEditButton
    // 
    this.CategoryMasterEditButton.AutoSize = true;
    this.CategoryMasterEditButton.Cursor = System.Windows.Forms.Cursors.Hand;
    this.CategoryMasterEditButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
    this.CategoryMasterEditButton.ForeColor = System.Drawing.Color.Navy;
    this.CategoryMasterEditButton.Location = new System.Drawing.Point(90, 40);
    this.CategoryMasterEditButton.Name = "CategoryMasterEditButton";
    this.CategoryMasterEditButton.Size = new System.Drawing.Size(85, 30);
    this.CategoryMasterEditButton.TabIndex = 0;
    this.CategoryMasterEditButton.Text = "Edit";
    this.toolTip1.SetToolTip(this.CategoryMasterEditButton, "Edit");
    this.CategoryMasterEditButton.UseVisualStyleBackColor = true;
    this.CategoryMasterEditButton.Click += new System.EventHandler(this.CategoryMasterEditButton_Click);
    // 
    // CategoryMasterAddButton
    // 
    this.CategoryMasterAddButton.AutoSize = true;
    this.CategoryMasterAddButton.Cursor = System.Windows.Forms.Cursors.Hand;
    this.CategoryMasterAddButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
    this.CategoryMasterAddButton.ForeColor = System.Drawing.Color.Navy;
    this.CategoryMasterAddButton.Location = new System.Drawing.Point(6, 40);
    this.CategoryMasterAddButton.Name = "CategoryMasterAddButton";
    this.CategoryMasterAddButton.Size = new System.Drawing.Size(85, 30);
    this.CategoryMasterAddButton.TabIndex = 0;
    this.CategoryMasterAddButton.Text = "Add";
    this.toolTip1.SetToolTip(this.CategoryMasterAddButton, "Add");
    this.CategoryMasterAddButton.UseVisualStyleBackColor = true;
    this.CategoryMasterAddButton.Click += new System.EventHandler(this.CategoryMasterAddButton_Click);
    // 
    // IndicatorLabelCategoryMaster
    // 
    this.IndicatorLabelCategoryMaster.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.IndicatorLabelCategoryMaster.ForeColor = System.Drawing.Color.Navy;
    this.IndicatorLabelCategoryMaster.Location = new System.Drawing.Point(307, 2);
    this.IndicatorLabelCategoryMaster.Name = "IndicatorLabelCategoryMaster";
    this.IndicatorLabelCategoryMaster.Size = new System.Drawing.Size(333, 35);
    this.IndicatorLabelCategoryMaster.TabIndex = 1;
    this.IndicatorLabelCategoryMaster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    // 
    // CategoryIDCategoryMasterLabel
    // 
    this.CategoryIDCategoryMasterLabel.AutoSize = true;
    this.CategoryIDCategoryMasterLabel.Location = new System.Drawing.Point(65, 15);
    this.CategoryIDCategoryMasterLabel.Name = "CategoryIDCategoryMasterLabel";
    this.CategoryIDCategoryMasterLabel.Size = new System.Drawing.Size(124, 20);
    this.CategoryIDCategoryMasterLabel.TabIndex = 1;
    this.CategoryIDCategoryMasterLabel.Text = "CategoryID:";
    // 
    // CategoryNameTextBoxCategoryMaster
    // 
    this.CategoryNameTextBoxCategoryMaster.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
    this.CategoryNameTextBoxCategoryMaster.Enabled = false;
    this.CategoryNameTextBoxCategoryMaster.Location = new System.Drawing.Point(165, 96);
    this.CategoryNameTextBoxCategoryMaster.Name = "CategoryNameTextBoxCategoryMaster";
    this.CategoryNameTextBoxCategoryMaster.Size = new System.Drawing.Size(154, 28);
    this.CategoryNameTextBoxCategoryMaster.TabIndex = 0;
    // 
    // CategoryNameCategoryMasterLabel
    // 
    this.CategoryNameCategoryMasterLabel.AutoSize = true;
    this.CategoryNameCategoryMasterLabel.Location = new System.Drawing.Point(12, 99);
    this.CategoryNameCategoryMasterLabel.Name = "CategoryNameCategoryMasterLabel";
    this.CategoryNameCategoryMasterLabel.Size = new System.Drawing.Size(155, 20);
    this.CategoryNameCategoryMasterLabel.TabIndex = 1;
    this.CategoryNameCategoryMasterLabel.Text = "CategoryName:";
    // 
    // CategoryMasterButton
    // 
    this.CategoryMasterButton.AutoSize = true;
    this.CategoryMasterButton.Cursor = System.Windows.Forms.Cursors.Hand;
    this.CategoryMasterButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
    this.CategoryMasterButton.ForeColor = System.Drawing.Color.Navy;
    this.CategoryMasterButton.Location = new System.Drawing.Point(720, 38);
    this.CategoryMasterButton.Name = "CategoryMasterButton";
    this.CategoryMasterButton.Size = new System.Drawing.Size(174, 30);
    this.CategoryMasterButton.TabIndex = 0;
    this.CategoryMasterButton.Text = "Category Master";
    this.toolTip1.SetToolTip(this.CategoryMasterButton, "Category Master");
    this.CategoryMasterButton.UseVisualStyleBackColor = true;
    this.CategoryMasterButton.Visible = false;
    this.CategoryMasterButton.Click += new System.EventHandler(this.CategoryMasterButton_Click);
    // 
    // DownPanel
    // 
    this.DownPanel.Controls.Add(this.GridView1);
    this.DownPanel.Dock = System.Windows.Forms.DockStyle.Fill;
    this.DownPanel.Location = new System.Drawing.Point(0, 246);
    this.DownPanel.Name = "DownPanel";
    this.DownPanel.Size = new System.Drawing.Size(1320, 284);
    this.DownPanel.TabIndex = 36;
    // 
    // GridView1
    // 
    this.GridView1.AllowUserToAddRows = false;
    this.GridView1.AllowUserToDeleteRows = false;
    this.GridView1.BackgroundColor = System.Drawing.Color.White;
    this.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    this.GridView1.Dock = System.Windows.Forms.DockStyle.Fill;
    this.GridView1.Location = new System.Drawing.Point(0, 0);
    this.GridView1.Name = "GridView1";
    this.GridView1.ReadOnly = true;
    this.GridView1.Size = new System.Drawing.Size(1320, 284);
    this.GridView1.TabIndex = 5;
    // 
    // OperationButtonsPanel
    // 
    this.OperationButtonsPanel.BackColor = System.Drawing.Color.Red;
    this.OperationButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
    this.OperationButtonsPanel.Location = new System.Drawing.Point(0, 242);
    this.OperationButtonsPanel.Name = "OperationButtonsPanel";
    this.OperationButtonsPanel.Size = new System.Drawing.Size(1320, 4);
    this.OperationButtonsPanel.TabIndex = 0;
    // 
    // UpPanel
    // 
    this.UpPanel.Controls.Add(this.CategoryMaster);
    this.UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
    this.UpPanel.Location = new System.Drawing.Point(0, 24);
    this.UpPanel.Name = "UpPanel";
    this.UpPanel.Size = new System.Drawing.Size(1320, 218);
    this.UpPanel.TabIndex = 36;
    // 
    // ClosePanel
    // 
    this.ClosePanel.BackColor = System.Drawing.Color.SkyBlue;
    this.ClosePanel.Controls.Add(this.ControlBoxPanel);
    this.ClosePanel.Dock = System.Windows.Forms.DockStyle.Top;
    this.ClosePanel.Location = new System.Drawing.Point(0, 0);
    this.ClosePanel.Name = "ClosePanel";
    this.ClosePanel.Size = new System.Drawing.Size(1320, 24);
    this.ClosePanel.TabIndex = 17;
    // 
    // ControlBoxPanel
    // 
    this.ControlBoxPanel.BackColor = System.Drawing.Color.DimGray;
    this.ControlBoxPanel.Controls.Add(this.CloseButton);
    this.ControlBoxPanel.Controls.Add(this.MaximizeButton);
    this.ControlBoxPanel.Controls.Add(this.MinimizeButton);
    this.ControlBoxPanel.Dock = System.Windows.Forms.DockStyle.Right;
    this.ControlBoxPanel.Location = new System.Drawing.Point(1244, 0);
    this.ControlBoxPanel.Name = "ControlBoxPanel";
    this.ControlBoxPanel.Size = new System.Drawing.Size(76, 24);
    this.ControlBoxPanel.TabIndex = 47;
    // 
    // CloseButton
    // 
    this.CloseButton.BackColor = System.Drawing.Color.DimGray;
    this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
    this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.CloseButton.ForeColor = System.Drawing.Color.Red;
    this.CloseButton.Location = new System.Drawing.Point(51, 1);
    this.CloseButton.Name = "CloseButton";
    this.CloseButton.Size = new System.Drawing.Size(25, 23);
    this.CloseButton.TabIndex = 48;
    this.CloseButton.Text = "X";
    this.CloseButton.UseVisualStyleBackColor = true;
    this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
    // 
    // MaximizeButton
    // 
    this.MaximizeButton.BackColor = System.Drawing.Color.DimGray;
    this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
    this.MaximizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.MaximizeButton.ForeColor = System.Drawing.Color.Red;
    this.MaximizeButton.Location = new System.Drawing.Point(26, 1);
    this.MaximizeButton.Name = "MaximizeButton";
    this.MaximizeButton.Size = new System.Drawing.Size(25, 23);
    this.MaximizeButton.TabIndex = 47;
    this.MaximizeButton.Text = "+";
    this.MaximizeButton.UseVisualStyleBackColor = true;
    this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
    // 
    // MinimizeButton
    // 
    this.MinimizeButton.BackColor = System.Drawing.Color.DimGray;
    this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
    this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.MinimizeButton.ForeColor = System.Drawing.Color.Red;
    this.MinimizeButton.Location = new System.Drawing.Point(1, 1);
    this.MinimizeButton.Name = "MinimizeButton";
    this.MinimizeButton.Size = new System.Drawing.Size(25, 23);
    this.MinimizeButton.TabIndex = 46;
    this.MinimizeButton.Text = "_";
    this.MinimizeButton.UseVisualStyleBackColor = true;
    this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
    // 
    // SearchPanel
    // 
    this.SearchPanel.BackColor = System.Drawing.Color.Transparent;
    this.SearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    this.SearchPanel.Controls.Add(this.ViewPrintReportsGroupBox);
    this.SearchPanel.Controls.Add(this.SearchPanelGroupBox);
    this.SearchPanel.ForeColor = System.Drawing.Color.White;
    this.SearchPanel.Location = new System.Drawing.Point(743, 33);
    this.SearchPanel.Name = "SearchPanel";
    this.SearchPanel.Size = new System.Drawing.Size(0, 0);
    this.SearchPanel.TabIndex = 0;
    // 
    // ViewPrintReportsGroupBox
    // 
    this.ViewPrintReportsGroupBox.BackColor = System.Drawing.Color.Transparent;
    this.ViewPrintReportsGroupBox.Controls.Add(this.ShowPrintReports);
    this.ViewPrintReportsGroupBox.Controls.Add(this.ReportsComboBox);
    this.ViewPrintReportsGroupBox.ForeColor = System.Drawing.Color.White;
    this.ViewPrintReportsGroupBox.Location = new System.Drawing.Point(6, 302);
    this.ViewPrintReportsGroupBox.Name = "ViewPrintReportsGroupBox";
    this.ViewPrintReportsGroupBox.Size = new System.Drawing.Size(200, 70);
    this.ViewPrintReportsGroupBox.TabIndex = 12;
    this.ViewPrintReportsGroupBox.TabStop = false;
    this.ViewPrintReportsGroupBox.Text = "View Print Reports";
    // 
    // ShowPrintReports
    // 
    this.ShowPrintReports.ForeColor = System.Drawing.Color.Black;
    this.ShowPrintReports.Location = new System.Drawing.Point(113, 42);
    this.ShowPrintReports.Name = "ShowPrintReports";
    this.ShowPrintReports.Size = new System.Drawing.Size(75, 23);
    this.ShowPrintReports.TabIndex = 2;
    this.ShowPrintReports.Text = "Show";
    this.ShowPrintReports.UseVisualStyleBackColor = true;
    this.ShowPrintReports.Click += new System.EventHandler(this.ShowPrintReports_Click);
    // 
    // ReportsComboBox
    // 
    this.ReportsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
    this.ReportsComboBox.FormattingEnabled = true;
    this.ReportsComboBox.Location = new System.Drawing.Point(11, 18);
    this.ReportsComboBox.Name = "ReportsComboBox";
    this.ReportsComboBox.Size = new System.Drawing.Size(177, 28);
    this.ReportsComboBox.TabIndex = 15;
    // 
    // SearchPanelGroupBox
    // 
    this.SearchPanelGroupBox.BackColor = System.Drawing.Color.Transparent;
    this.SearchPanelGroupBox.Controls.Add(this.DateFieldNameLabel);
    this.SearchPanelGroupBox.Controls.Add(this.DateFieldName);
    this.SearchPanelGroupBox.Controls.Add(this.ShowRecordsButton);
    this.SearchPanelGroupBox.Controls.Add(this.CompareTypeComboBox);
    this.SearchPanelGroupBox.Controls.Add(this.CompareTypeLabel);
    this.SearchPanelGroupBox.Controls.Add(this.SearchByParameterCheck);
    this.SearchPanelGroupBox.Controls.Add(this.DateParameterCheck);
    this.SearchPanelGroupBox.Controls.Add(this.SelectValueLabel);
    this.SearchPanelGroupBox.Controls.Add(this.SelectValueComboBox);
    this.SearchPanelGroupBox.Controls.Add(this.SearchByComboBox);
    this.SearchPanelGroupBox.Controls.Add(this.SearchByLabel);
    this.SearchPanelGroupBox.Controls.Add(this.ToDateLabel);
    this.SearchPanelGroupBox.Controls.Add(this.FromDateLabel);
    this.SearchPanelGroupBox.Controls.Add(this.ToDateSearch);
    this.SearchPanelGroupBox.Controls.Add(this.FromDateSearch);
    this.SearchPanelGroupBox.ForeColor = System.Drawing.Color.White;
    this.SearchPanelGroupBox.Location = new System.Drawing.Point(6, 6);
    this.SearchPanelGroupBox.Name = "SearchPanelGroupBox";
    this.SearchPanelGroupBox.Size = new System.Drawing.Size(200, 289);
    this.SearchPanelGroupBox.TabIndex = 11;
    this.SearchPanelGroupBox.TabStop = false;
    this.SearchPanelGroupBox.Text = "Search Panel";
    // 
    // DateFieldNameLabel
    // 
    this.DateFieldNameLabel.AutoSize = true;
    this.DateFieldNameLabel.Location = new System.Drawing.Point(13, 75);
    this.DateFieldNameLabel.Name = "DateFieldNameLabel";
    this.DateFieldNameLabel.Size = new System.Drawing.Size(170, 20);
    this.DateFieldNameLabel.TabIndex = 14;
    this.DateFieldNameLabel.Text = "Date Field name:";
    // 
    // DateFieldName
    // 
    this.DateFieldName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
    this.DateFieldName.Enabled = false;
    this.DateFieldName.FormattingEnabled = true;
    this.DateFieldName.Items.AddRange(new object[] {
            "Select Operation"});
    this.DateFieldName.Location = new System.Drawing.Point(12, 93);
    this.DateFieldName.Name = "DateFieldName";
    this.DateFieldName.Size = new System.Drawing.Size(155, 28);
    this.DateFieldName.TabIndex = 13;
    // 
    // ShowRecordsButton
    // 
    this.ShowRecordsButton.Enabled = false;
    this.ShowRecordsButton.ForeColor = System.Drawing.Color.Black;
    this.ShowRecordsButton.Location = new System.Drawing.Point(11, 250);
    this.ShowRecordsButton.Name = "ShowRecordsButton";
    this.ShowRecordsButton.Size = new System.Drawing.Size(155, 23);
    this.ShowRecordsButton.TabIndex = 12;
    this.ShowRecordsButton.Text = "Show Records";
    this.ShowRecordsButton.UseVisualStyleBackColor = true;
    this.ShowRecordsButton.Click += new System.EventHandler(this.ShowRecordsButton_Click);
    // 
    // CompareTypeComboBox
    // 
    this.CompareTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
    this.CompareTypeComboBox.Enabled = false;
    this.CompareTypeComboBox.FormattingEnabled = true;
    this.CompareTypeComboBox.Items.AddRange(new object[] {
            "=",
            ">",
            "<",
            ">=",
            "<=",
            "<>"});
    this.CompareTypeComboBox.Location = new System.Drawing.Point(91, 174);
    this.CompareTypeComboBox.Name = "CompareTypeComboBox";
    this.CompareTypeComboBox.Size = new System.Drawing.Size(76, 28);
    this.CompareTypeComboBox.TabIndex = 11;
    // 
    // CompareTypeLabel
    // 
    this.CompareTypeLabel.AutoSize = true;
    this.CompareTypeLabel.Location = new System.Drawing.Point(13, 178);
    this.CompareTypeLabel.Name = "CompareTypeLabel";
    this.CompareTypeLabel.Size = new System.Drawing.Size(152, 20);
    this.CompareTypeLabel.TabIndex = 10;
    this.CompareTypeLabel.Text = "Compare Type:";
    // 
    // SearchByParameterCheck
    // 
    this.SearchByParameterCheck.AutoSize = true;
    this.SearchByParameterCheck.Location = new System.Drawing.Point(173, 151);
    this.SearchByParameterCheck.Name = "SearchByParameterCheck";
    this.SearchByParameterCheck.Size = new System.Drawing.Size(22, 21);
    this.SearchByParameterCheck.TabIndex = 9;
    this.SearchByParameterCheck.UseVisualStyleBackColor = true;
    this.SearchByParameterCheck.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
    // 
    // DateParameterCheck
    // 
    this.DateParameterCheck.AutoSize = true;
    this.DateParameterCheck.Location = new System.Drawing.Point(173, 56);
    this.DateParameterCheck.Name = "DateParameterCheck";
    this.DateParameterCheck.Size = new System.Drawing.Size(22, 21);
    this.DateParameterCheck.TabIndex = 8;
    this.DateParameterCheck.UseVisualStyleBackColor = true;
    this.DateParameterCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
    // 
    // SelectValueLabel
    // 
    this.SelectValueLabel.AutoSize = true;
    this.SelectValueLabel.Location = new System.Drawing.Point(12, 205);
    this.SelectValueLabel.Name = "SelectValueLabel";
    this.SelectValueLabel.Size = new System.Drawing.Size(133, 20);
    this.SelectValueLabel.TabIndex = 7;
    this.SelectValueLabel.Text = "Select Value:";
    // 
    // SelectValueComboBox
    // 
    this.SelectValueComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
    this.SelectValueComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
    this.SelectValueComboBox.Enabled = false;
    this.SelectValueComboBox.FormattingEnabled = true;
    this.SelectValueComboBox.Location = new System.Drawing.Point(12, 223);
    this.SelectValueComboBox.Name = "SelectValueComboBox";
    this.SelectValueComboBox.Size = new System.Drawing.Size(176, 28);
    this.SelectValueComboBox.TabIndex = 6;
    // 
    // SearchByComboBox
    // 
    this.SearchByComboBox.Enabled = false;
    this.SearchByComboBox.FormattingEnabled = true;
    this.SearchByComboBox.Items.AddRange(new object[] {
            "Select Operation"});
    this.SearchByComboBox.Location = new System.Drawing.Point(12, 149);
    this.SearchByComboBox.Name = "SearchByComboBox";
    this.SearchByComboBox.Size = new System.Drawing.Size(155, 28);
    this.SearchByComboBox.TabIndex = 5;
    this.SearchByComboBox.SelectedIndexChanged += new System.EventHandler(this.SearchByComboBox_SelectedIndexChanged);
    // 
    // SearchByLabel
    // 
    this.SearchByLabel.AutoSize = true;
    this.SearchByLabel.Location = new System.Drawing.Point(12, 132);
    this.SearchByLabel.Name = "SearchByLabel";
    this.SearchByLabel.Size = new System.Drawing.Size(110, 20);
    this.SearchByLabel.TabIndex = 4;
    this.SearchByLabel.Text = "Search By:";
    // 
    // ToDateLabel
    // 
    this.ToDateLabel.AutoSize = true;
    this.ToDateLabel.Location = new System.Drawing.Point(21, 54);
    this.ToDateLabel.Name = "ToDateLabel";
    this.ToDateLabel.Size = new System.Drawing.Size(88, 20);
    this.ToDateLabel.TabIndex = 3;
    this.ToDateLabel.Text = "To date:";
    // 
    // FromDateLabel
    // 
    this.FromDateLabel.AutoSize = true;
    this.FromDateLabel.Location = new System.Drawing.Point(12, 28);
    this.FromDateLabel.Name = "FromDateLabel";
    this.FromDateLabel.Size = new System.Drawing.Size(113, 20);
    this.FromDateLabel.TabIndex = 2;
    this.FromDateLabel.Text = "From date:";
    // 
    // ToDateSearch
    // 
    this.ToDateSearch.Enabled = false;
    this.ToDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
    this.ToDateSearch.Location = new System.Drawing.Point(70, 51);
    this.ToDateSearch.Name = "ToDateSearch";
    this.ToDateSearch.Size = new System.Drawing.Size(97, 28);
    this.ToDateSearch.TabIndex = 1;
    // 
    // FromDateSearch
    // 
    this.FromDateSearch.Enabled = false;
    this.FromDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
    this.FromDateSearch.Location = new System.Drawing.Point(70, 25);
    this.FromDateSearch.Name = "FromDateSearch";
    this.FromDateSearch.Size = new System.Drawing.Size(97, 28);
    this.FromDateSearch.TabIndex = 0;
    // 
    // Category_Master
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 20F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.BackColor = System.Drawing.Color.Khaki;
    this.ClientSize = new System.Drawing.Size(1320, 530);
    this.ControlBox = false;
    this.Controls.Add(this.DownPanel);
    this.Controls.Add(this.OperationButtonsPanel);
    this.Controls.Add(this.UpPanel);
    this.Controls.Add(this.ClosePanel);
    this.Controls.Add(this.SearchPanel);
    this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
    this.Name = "Category_Master";
    this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
    this.Text = "Test_Project";
    this.CategoryMaster.ResumeLayout(false);
    this.CategoryMaster.PerformLayout();
    this.CategoryMastercontextMenuStrip.ResumeLayout(false);
    this.DownPanel.ResumeLayout(false);
    ((System.ComponentModel.ISupportInitialize)(this.GridView1)).EndInit();
    this.UpPanel.ResumeLayout(false);
    this.ClosePanel.ResumeLayout(false);
    this.ControlBoxPanel.ResumeLayout(false);
    this.SearchPanel.ResumeLayout(false);
    this.ViewPrintReportsGroupBox.ResumeLayout(false);
    this.SearchPanelGroupBox.ResumeLayout(false);
    this.SearchPanelGroupBox.PerformLayout();
    this.ResumeLayout(false);

}

#endregion

 private System.Windows.Forms.TextBox CategoryIDTextBoxCategoryMaster;
private System.Windows.Forms.Panel CategoryMaster;
private System.Windows.Forms.Label IndicatorLabelCategoryMaster;
private System.Windows.Forms.ContextMenuStrip CategoryMastercontextMenuStrip;
private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItemCategoryMaster;
private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItemCategoryMaster;
private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItemCategoryMaster;
private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItemCategoryMaster;
private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItemCategoryMaster;
private System.Windows.Forms.Button CategoryMasterAddButton;
private System.Windows.Forms.Button CategoryMasterEditButton;
private System.Windows.Forms.Button CategoryMasterSaveButton;
private System.Windows.Forms.Button CategoryMasterCancelButton;
private System.Windows.Forms.Button CategoryMasterViewButton;
private System.Windows.Forms.Button CategoryMasterDeleteButton;
private System.Windows.Forms.Button CategoryMasterButton;
private System.Windows.Forms.Panel DownPanel;
private System.Windows.Forms.Panel OperationButtonsPanel;
private System.Windows.Forms.Panel UpPanel;
private System.Windows.Forms.Panel ClosePanel;
private System.Windows.Forms.Panel ControlBoxPanel;
private System.Windows.Forms.Button CloseButton;
private System.Windows.Forms.Button MaximizeButton;
private System.Windows.Forms.Button MinimizeButton;
private System.Windows.Forms.ToolTip toolTip1;
private System.Windows.Forms.Panel SearchPanel;
private System.Windows.Forms.Label SelectValueLabel;
private System.Windows.Forms.ComboBox SelectValueComboBox;
private System.Windows.Forms.ComboBox SearchByComboBox;
private System.Windows.Forms.Label SearchByLabel;
private System.Windows.Forms.Label ToDateLabel;
private System.Windows.Forms.Label FromDateLabel;
private System.Windows.Forms.DateTimePicker ToDateSearch;
private System.Windows.Forms.DateTimePicker FromDateSearch;
private System.Windows.Forms.CheckBox SearchByParameterCheck;
private System.Windows.Forms.CheckBox DateParameterCheck;
private System.Windows.Forms.GroupBox SearchPanelGroupBox;
private System.Windows.Forms.ComboBox CompareTypeComboBox;
private System.Windows.Forms.Label CompareTypeLabel;
private System.Windows.Forms.Button ShowRecordsButton;
private System.Windows.Forms.ComboBox DateFieldName;
private System.Windows.Forms.Label DateFieldNameLabel;
private System.Windows.Forms.GroupBox ViewPrintReportsGroupBox;
private System.Windows.Forms.Button ShowPrintReports;
private System.Windows.Forms.ComboBox ReportsComboBox;
private System.Windows.Forms.Label CategoryIDCategoryMasterLabel;
private System.Windows.Forms.DataGridView GridView1;
 private System.Windows.Forms.TextBox CategoryNameTextBoxCategoryMaster;
private System.Windows.Forms.Label CategoryNameCategoryMasterLabel;
private System.Windows.Forms.ErrorProvider errorProvider1;

}
}