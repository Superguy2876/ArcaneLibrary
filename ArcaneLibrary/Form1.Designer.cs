namespace ArcaneLibrary
{
    partial class frmMain
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
            this.tcLibrary = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblSearchSpell = new System.Windows.Forms.Label();
            this.tbSearchSpell = new System.Windows.Forms.TextBox();
            this.tbSpell = new System.Windows.Forms.TextBox();
            this.btnEditSpell = new System.Windows.Forms.Button();
            this.btnDeleteSpell = new System.Windows.Forms.Button();
            this.btnAddSpell = new System.Windows.Forms.Button();
            this.lbSpells = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblSearchItem = new System.Windows.Forms.Label();
            this.tbSearchItem = new System.Windows.Forms.TextBox();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.tbItem = new System.Windows.Forms.TextBox();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tcLibrary.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcLibrary
            // 
            this.tcLibrary.Controls.Add(this.tabPage1);
            this.tcLibrary.Controls.Add(this.tabPage2);
            this.tcLibrary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcLibrary.Location = new System.Drawing.Point(0, 0);
            this.tcLibrary.Name = "tcLibrary";
            this.tcLibrary.SelectedIndex = 0;
            this.tcLibrary.Size = new System.Drawing.Size(649, 492);
            this.tcLibrary.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lblSearchSpell);
            this.tabPage1.Controls.Add(this.tbSearchSpell);
            this.tabPage1.Controls.Add(this.tbSpell);
            this.tabPage1.Controls.Add(this.btnEditSpell);
            this.tabPage1.Controls.Add(this.btnDeleteSpell);
            this.tabPage1.Controls.Add(this.btnAddSpell);
            this.tabPage1.Controls.Add(this.lbSpells);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(641, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Spells";
            // 
            // lblSearchSpell
            // 
            this.lblSearchSpell.AutoSize = true;
            this.lblSearchSpell.Location = new System.Drawing.Point(7, 33);
            this.lblSearchSpell.Name = "lblSearchSpell";
            this.lblSearchSpell.Size = new System.Drawing.Size(41, 13);
            this.lblSearchSpell.TabIndex = 7;
            this.lblSearchSpell.Text = "Search";
            // 
            // tbSearchSpell
            // 
            this.tbSearchSpell.Location = new System.Drawing.Point(54, 30);
            this.tbSearchSpell.Name = "tbSearchSpell";
            this.tbSearchSpell.Size = new System.Drawing.Size(269, 20);
            this.tbSearchSpell.TabIndex = 6;
            this.tbSearchSpell.TextChanged += new System.EventHandler(this.tbSearchSpell_TextChanged);
            // 
            // tbSpell
            // 
            this.tbSpell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSpell.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbSpell.Location = new System.Drawing.Point(160, 56);
            this.tbSpell.Multiline = true;
            this.tbSpell.Name = "tbSpell";
            this.tbSpell.ReadOnly = true;
            this.tbSpell.Size = new System.Drawing.Size(473, 368);
            this.tbSpell.TabIndex = 5;
            // 
            // btnEditSpell
            // 
            this.btnEditSpell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditSpell.Location = new System.Drawing.Point(81, 430);
            this.btnEditSpell.Name = "btnEditSpell";
            this.btnEditSpell.Size = new System.Drawing.Size(73, 23);
            this.btnEditSpell.TabIndex = 4;
            this.btnEditSpell.Text = "Edit";
            this.btnEditSpell.UseVisualStyleBackColor = true;
            this.btnEditSpell.Click += new System.EventHandler(this.btnEditSpell_Click);
            // 
            // btnDeleteSpell
            // 
            this.btnDeleteSpell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteSpell.Location = new System.Drawing.Point(160, 430);
            this.btnDeleteSpell.Name = "btnDeleteSpell";
            this.btnDeleteSpell.Size = new System.Drawing.Size(73, 23);
            this.btnDeleteSpell.TabIndex = 3;
            this.btnDeleteSpell.Text = "Delete";
            this.btnDeleteSpell.UseVisualStyleBackColor = true;
            this.btnDeleteSpell.Click += new System.EventHandler(this.btnDeleteSpell_Click);
            // 
            // btnAddSpell
            // 
            this.btnAddSpell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddSpell.Location = new System.Drawing.Point(8, 430);
            this.btnAddSpell.Name = "btnAddSpell";
            this.btnAddSpell.Size = new System.Drawing.Size(73, 23);
            this.btnAddSpell.TabIndex = 2;
            this.btnAddSpell.Text = "Add";
            this.btnAddSpell.UseVisualStyleBackColor = true;
            this.btnAddSpell.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbSpells
            // 
            this.lbSpells.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbSpells.FormattingEnabled = true;
            this.lbSpells.Location = new System.Drawing.Point(8, 56);
            this.lbSpells.Name = "lbSpells";
            this.lbSpells.Size = new System.Drawing.Size(146, 368);
            this.lbSpells.TabIndex = 0;
            this.lbSpells.SelectedIndexChanged += new System.EventHandler(this.lbSpells_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblSearchItem);
            this.tabPage2.Controls.Add(this.tbSearchItem);
            this.tabPage2.Controls.Add(this.btnEditItem);
            this.tabPage2.Controls.Add(this.btnDeleteItem);
            this.tabPage2.Controls.Add(this.btnAddItem);
            this.tabPage2.Controls.Add(this.tbItem);
            this.tabPage2.Controls.Add(this.lbItems);
            this.tabPage2.Controls.Add(this.menuStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(641, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Items";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblSearchItem
            // 
            this.lblSearchItem.AutoSize = true;
            this.lblSearchItem.Location = new System.Drawing.Point(7, 33);
            this.lblSearchItem.Name = "lblSearchItem";
            this.lblSearchItem.Size = new System.Drawing.Size(41, 13);
            this.lblSearchItem.TabIndex = 12;
            this.lblSearchItem.Text = "Search";
            // 
            // tbSearchItem
            // 
            this.tbSearchItem.Location = new System.Drawing.Point(54, 30);
            this.tbSearchItem.Name = "tbSearchItem";
            this.tbSearchItem.Size = new System.Drawing.Size(269, 20);
            this.tbSearchItem.TabIndex = 11;
            this.tbSearchItem.TextChanged += new System.EventHandler(this.tbSearchItem_TextChanged);
            // 
            // btnEditItem
            // 
            this.btnEditItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEditItem.Location = new System.Drawing.Point(81, 430);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(73, 23);
            this.btnEditItem.TabIndex = 9;
            this.btnEditItem.Text = "Edit";
            this.btnEditItem.UseVisualStyleBackColor = true;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteItem.Location = new System.Drawing.Point(160, 430);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(73, 23);
            this.btnDeleteItem.TabIndex = 8;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddItem.Location = new System.Drawing.Point(8, 430);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(73, 23);
            this.btnAddItem.TabIndex = 7;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // tbItem
            // 
            this.tbItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbItem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tbItem.Location = new System.Drawing.Point(160, 56);
            this.tbItem.Multiline = true;
            this.tbItem.Name = "tbItem";
            this.tbItem.ReadOnly = true;
            this.tbItem.Size = new System.Drawing.Size(473, 368);
            this.tbItem.TabIndex = 6;
            // 
            // lbItems
            // 
            this.lbItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(8, 56);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(146, 368);
            this.lbItems.TabIndex = 1;
            this.lbItems.SelectedIndexChanged += new System.EventHandler(this.lbItems_SelectedIndexChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(635, 24);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.loadToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem1.Text = "Load";
            this.loadToolStripMenuItem1.Click += new System.EventHandler(this.loadToolStripMenuItem1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 492);
            this.Controls.Add(this.tcLibrary);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "frmMain";
            this.Text = "Name";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tcLibrary.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcLibrary;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbSpells;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Button btnEditSpell;
        private System.Windows.Forms.Button btnDeleteSpell;
        private System.Windows.Forms.Button btnAddSpell;
        private System.Windows.Forms.TextBox tbSpell;
        private System.Windows.Forms.ListBox lbItems;
        private System.Windows.Forms.TextBox tbItem;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblSearchSpell;
        private System.Windows.Forms.TextBox tbSearchSpell;
        private System.Windows.Forms.Label lblSearchItem;
        private System.Windows.Forms.TextBox tbSearchItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
    }
}

