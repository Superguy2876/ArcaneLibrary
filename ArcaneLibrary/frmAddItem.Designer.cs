namespace ArcaneLibrary
{
    partial class frmAddItem
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbRarity = new System.Windows.Forms.TextBox();
            this.clbAttuneList = new System.Windows.Forms.CheckedListBox();
            this.tbAddAttunement = new System.Windows.Forms.TextBox();
            this.cbAttunement = new System.Windows.Forms.CheckBox();
            this.clbTags = new System.Windows.Forms.CheckedListBox();
            this.tbAddTag = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblRarity = new System.Windows.Forms.Label();
            this.lblAttuneList = new System.Windows.Forms.Label();
            this.lblAddAtune = new System.Windows.Forms.Label();
            this.lblTags = new System.Windows.Forms.Label();
            this.lblAddTag = new System.Windows.Forms.Label();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.btnAddAttune = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(292, 9);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 24;
            this.lblDescription.Text = "Description";
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Location = new System.Drawing.Point(295, 26);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(360, 527);
            this.tbDescription.TabIndex = 33;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(106, 26);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(182, 20);
            this.tbName.TabIndex = 25;
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(106, 52);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(182, 20);
            this.tbType.TabIndex = 26;
            // 
            // tbRarity
            // 
            this.tbRarity.Location = new System.Drawing.Point(106, 78);
            this.tbRarity.Name = "tbRarity";
            this.tbRarity.Size = new System.Drawing.Size(182, 20);
            this.tbRarity.TabIndex = 27;
            // 
            // clbAttuneList
            // 
            this.clbAttuneList.FormattingEnabled = true;
            this.clbAttuneList.Items.AddRange(new object[] {
            "Barbarian",
            "Bard",
            "Cleric",
            "Druid",
            "Fighter",
            "Martial",
            "Monk",
            "Paladin",
            "Ranger",
            "Rogue",
            "Sorcerer",
            "SpellCaster",
            "Warlock"});
            this.clbAttuneList.Location = new System.Drawing.Point(106, 127);
            this.clbAttuneList.Name = "clbAttuneList";
            this.clbAttuneList.Size = new System.Drawing.Size(182, 109);
            this.clbAttuneList.Sorted = true;
            this.clbAttuneList.TabIndex = 29;
            // 
            // tbAddAttunement
            // 
            this.tbAddAttunement.Location = new System.Drawing.Point(106, 242);
            this.tbAddAttunement.Name = "tbAddAttunement";
            this.tbAddAttunement.Size = new System.Drawing.Size(148, 20);
            this.tbAddAttunement.TabIndex = 30;
            this.tbAddAttunement.Enter += new System.EventHandler(this.tbAddAttunement_Enter);
            this.tbAddAttunement.Leave += new System.EventHandler(this.tbAddAttunement_Leave);
            // 
            // cbAttunement
            // 
            this.cbAttunement.AutoSize = true;
            this.cbAttunement.Location = new System.Drawing.Point(106, 104);
            this.cbAttunement.Name = "cbAttunement";
            this.cbAttunement.Size = new System.Drawing.Size(125, 17);
            this.cbAttunement.TabIndex = 28;
            this.cbAttunement.Text = "Requires Attunement";
            this.cbAttunement.UseVisualStyleBackColor = true;
            // 
            // clbTags
            // 
            this.clbTags.FormattingEnabled = true;
            this.clbTags.Location = new System.Drawing.Point(106, 268);
            this.clbTags.Name = "clbTags";
            this.clbTags.Size = new System.Drawing.Size(182, 109);
            this.clbTags.Sorted = true;
            this.clbTags.TabIndex = 31;
            // 
            // tbAddTag
            // 
            this.tbAddTag.Location = new System.Drawing.Point(106, 383);
            this.tbAddTag.Name = "tbAddTag";
            this.tbAddTag.Size = new System.Drawing.Size(148, 20);
            this.tbAddTag.TabIndex = 32;
            this.tbAddTag.Enter += new System.EventHandler(this.tbAddTag_Enter);
            this.tbAddTag.Leave += new System.EventHandler(this.tbAddTag_Leave);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 33;
            this.lblName.Text = "Name";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 55);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 34;
            this.lblType.Text = "Type";
            // 
            // lblRarity
            // 
            this.lblRarity.AutoSize = true;
            this.lblRarity.Location = new System.Drawing.Point(12, 81);
            this.lblRarity.Name = "lblRarity";
            this.lblRarity.Size = new System.Drawing.Size(34, 13);
            this.lblRarity.TabIndex = 35;
            this.lblRarity.Text = "Rarity";
            // 
            // lblAttuneList
            // 
            this.lblAttuneList.AutoSize = true;
            this.lblAttuneList.Location = new System.Drawing.Point(12, 136);
            this.lblAttuneList.Name = "lblAttuneList";
            this.lblAttuneList.Size = new System.Drawing.Size(85, 13);
            this.lblAttuneList.TabIndex = 36;
            this.lblAttuneList.Text = "Who can Attune";
            // 
            // lblAddAtune
            // 
            this.lblAddAtune.AutoSize = true;
            this.lblAddAtune.Location = new System.Drawing.Point(12, 245);
            this.lblAddAtune.Name = "lblAddAtune";
            this.lblAddAtune.Size = new System.Drawing.Size(71, 13);
            this.lblAddAtune.TabIndex = 37;
            this.lblAddAtune.Text = "Add Catagory";
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Location = new System.Drawing.Point(12, 278);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(31, 13);
            this.lblTags.TabIndex = 38;
            this.lblTags.Text = "Tags";
            // 
            // lblAddTag
            // 
            this.lblAddTag.AutoSize = true;
            this.lblAddTag.Location = new System.Drawing.Point(12, 386);
            this.lblAddTag.Name = "lblAddTag";
            this.lblAddTag.Size = new System.Drawing.Size(48, 13);
            this.lblAddTag.TabIndex = 39;
            this.lblAddTag.Text = "Add Tag";
            // 
            // btnAddTag
            // 
            this.btnAddTag.Location = new System.Drawing.Point(260, 383);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(28, 20);
            this.btnAddTag.TabIndex = 40;
            this.btnAddTag.Text = "+";
            this.btnAddTag.UseVisualStyleBackColor = true;
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
            // 
            // btnAddAttune
            // 
            this.btnAddAttune.Location = new System.Drawing.Point(260, 241);
            this.btnAddAttune.Name = "btnAddAttune";
            this.btnAddAttune.Size = new System.Drawing.Size(28, 20);
            this.btnAddAttune.TabIndex = 41;
            this.btnAddAttune.Text = "+";
            this.btnAddAttune.UseVisualStyleBackColor = true;
            this.btnAddAttune.Click += new System.EventHandler(this.btnAddAttune_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(581, 559);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(500, 559);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmAddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 603);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnAddAttune);
            this.Controls.Add(this.btnAddTag);
            this.Controls.Add(this.lblAddTag);
            this.Controls.Add(this.lblTags);
            this.Controls.Add(this.lblAddAtune);
            this.Controls.Add(this.lblAttuneList);
            this.Controls.Add(this.lblRarity);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbAddTag);
            this.Controls.Add(this.clbTags);
            this.Controls.Add(this.cbAttunement);
            this.Controls.Add(this.tbAddAttunement);
            this.Controls.Add(this.clbAttuneList);
            this.Controls.Add(this.tbRarity);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbDescription);
            this.Name = "frmAddItem";
            this.Text = "frmAddItem";
            this.Load += new System.EventHandler(this.frmAddItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.TextBox tbRarity;
        private System.Windows.Forms.CheckedListBox clbAttuneList;
        private System.Windows.Forms.TextBox tbAddAttunement;
        private System.Windows.Forms.CheckBox cbAttunement;
        private System.Windows.Forms.CheckedListBox clbTags;
        private System.Windows.Forms.TextBox tbAddTag;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblRarity;
        private System.Windows.Forms.Label lblAttuneList;
        private System.Windows.Forms.Label lblAddAtune;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.Label lblAddTag;
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.Button btnAddAttune;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}