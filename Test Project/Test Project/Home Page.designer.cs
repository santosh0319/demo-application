namespace Test_Project
{
partial class Home_Page
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
    this.menuStrip1 = new System.Windows.Forms.MenuStrip();
    this.CategoryMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    this.ProductMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
    this.menuStrip1.SuspendLayout();
    this.SuspendLayout();
    // 
    // menuStrip1
    // 
    this.menuStrip1.BackColor = System.Drawing.Color.White;
    this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CategoryMasterToolStripMenuItem,
            this.ProductMasterToolStripMenuItem});
    this.menuStrip1.Location = new System.Drawing.Point(0, 0);
    this.menuStrip1.Name = "menuStrip1";
    this.menuStrip1.Size = new System.Drawing.Size(699, 24);
    this.menuStrip1.TabIndex = 0;
    this.menuStrip1.Text = "menuStrip1";
    // 
    // CategoryMasterToolStripMenuItem
    // 
    this.CategoryMasterToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.CategoryMasterToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
    this.CategoryMasterToolStripMenuItem.Name = "CategoryMasterToolStripMenuItem";
    this.CategoryMasterToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
    this.CategoryMasterToolStripMenuItem.Text = "CATEGORY MASTER";
    this.CategoryMasterToolStripMenuItem.Click += new System.EventHandler(this.CategoryMasterToolStripMenuItem_Click);
    // 
    // ProductMasterToolStripMenuItem
    // 
    this.ProductMasterToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    this.ProductMasterToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
    this.ProductMasterToolStripMenuItem.Name = "ProductMasterToolStripMenuItem";
    this.ProductMasterToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
    this.ProductMasterToolStripMenuItem.Text = "PRODUCT MASTER";
    this.ProductMasterToolStripMenuItem.Click += new System.EventHandler(this.ProductMasterToolStripMenuItem_Click);
    // 
    // Home_Page
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(699, 262);
    this.Controls.Add(this.menuStrip1);
    this.IsMdiContainer = true;
    this.MainMenuStrip = this.menuStrip1;
    this.Name = "Home_Page";
    this.Text = "Test Project Home Page ";
    this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
    this.Load += new System.EventHandler(this.Home_Page_Load);
    this.menuStrip1.ResumeLayout(false);
    this.menuStrip1.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();

}

#endregion

private System.Windows.Forms.MenuStrip menuStrip1;
public System.Windows.Forms.ToolStripMenuItem CategoryMasterToolStripMenuItem;
public System.Windows.Forms.ToolStripMenuItem ProductMasterToolStripMenuItem;
}
}