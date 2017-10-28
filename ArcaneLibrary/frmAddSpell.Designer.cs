namespace ArcaneLibrary
{
    partial class frmAddSpell
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.nudLevel = new System.Windows.Forms.NumericUpDown();
            this.tbSchool = new System.Windows.Forms.TextBox();
            this.tbCastTime = new System.Windows.Forms.TextBox();
            this.tbRange = new System.Windows.Forms.TextBox();
            this.cbVerbal = new System.Windows.Forms.CheckBox();
            this.cbSomantic = new System.Windows.Forms.CheckBox();
            this.cbMaterial = new System.Windows.Forms.CheckBox();
            this.cbRitual = new System.Windows.Forms.CheckBox();
            this.tbMaterialComponent = new System.Windows.Forms.TextBox();
            this.cbConcentration = new System.Windows.Forms.CheckBox();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblCastTime = new System.Windows.Forms.Label();
            this.lblRange = new System.Windows.Forms.Label();
            this.lblMaterialComponent = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.clbClasses = new System.Windows.Forms.CheckedListBox();
            this.lblClasses = new System.Windows.Forms.Label();
            this.clbTags = new System.Windows.Forms.CheckedListBox();
            this.lblTags = new System.Windows.Forms.Label();
            this.tbAddClass = new System.Windows.Forms.TextBox();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.tbAddTag = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(137, 33);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(156, 20);
            this.tbName.TabIndex = 0;
            // 
            // nudLevel
            // 
            this.nudLevel.Location = new System.Drawing.Point(137, 59);
            this.nudLevel.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(156, 20);
            this.nudLevel.TabIndex = 1;
            // 
            // tbSchool
            // 
            this.tbSchool.Location = new System.Drawing.Point(137, 85);
            this.tbSchool.Name = "tbSchool";
            this.tbSchool.Size = new System.Drawing.Size(156, 20);
            this.tbSchool.TabIndex = 2;
            // 
            // tbCastTime
            // 
            this.tbCastTime.Location = new System.Drawing.Point(137, 111);
            this.tbCastTime.Name = "tbCastTime";
            this.tbCastTime.Size = new System.Drawing.Size(156, 20);
            this.tbCastTime.TabIndex = 3;
            // 
            // tbRange
            // 
            this.tbRange.Location = new System.Drawing.Point(137, 137);
            this.tbRange.Name = "tbRange";
            this.tbRange.Size = new System.Drawing.Size(156, 20);
            this.tbRange.TabIndex = 4;
            // 
            // cbVerbal
            // 
            this.cbVerbal.AutoSize = true;
            this.cbVerbal.Location = new System.Drawing.Point(12, 436);
            this.cbVerbal.Name = "cbVerbal";
            this.cbVerbal.Size = new System.Drawing.Size(113, 17);
            this.cbVerbal.TabIndex = 11;
            this.cbVerbal.Text = "Verbal Component";
            this.cbVerbal.UseVisualStyleBackColor = true;
            // 
            // cbSomantic
            // 
            this.cbSomantic.AutoSize = true;
            this.cbSomantic.Location = new System.Drawing.Point(12, 460);
            this.cbSomantic.Name = "cbSomantic";
            this.cbSomantic.Size = new System.Drawing.Size(127, 17);
            this.cbSomantic.TabIndex = 12;
            this.cbSomantic.Text = "Somantic Component";
            this.cbSomantic.UseVisualStyleBackColor = true;
            // 
            // cbMaterial
            // 
            this.cbMaterial.AutoSize = true;
            this.cbMaterial.Location = new System.Drawing.Point(12, 484);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(120, 17);
            this.cbMaterial.TabIndex = 13;
            this.cbMaterial.Text = "Material Component";
            this.cbMaterial.UseVisualStyleBackColor = true;
            // 
            // cbRitual
            // 
            this.cbRitual.AutoSize = true;
            this.cbRitual.Location = new System.Drawing.Point(12, 508);
            this.cbRitual.Name = "cbRitual";
            this.cbRitual.Size = new System.Drawing.Size(53, 17);
            this.cbRitual.TabIndex = 14;
            this.cbRitual.Text = "Ritual";
            this.cbRitual.UseVisualStyleBackColor = true;
            // 
            // tbMaterialComponent
            // 
            this.tbMaterialComponent.Location = new System.Drawing.Point(137, 163);
            this.tbMaterialComponent.Name = "tbMaterialComponent";
            this.tbMaterialComponent.Size = new System.Drawing.Size(156, 20);
            this.tbMaterialComponent.TabIndex = 5;
            // 
            // cbConcentration
            // 
            this.cbConcentration.AutoSize = true;
            this.cbConcentration.Location = new System.Drawing.Point(12, 532);
            this.cbConcentration.Name = "cbConcentration";
            this.cbConcentration.Size = new System.Drawing.Size(92, 17);
            this.cbConcentration.TabIndex = 15;
            this.cbConcentration.Text = "Concentration";
            this.cbConcentration.UseVisualStyleBackColor = true;
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(137, 189);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(156, 20);
            this.tbDuration.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 36);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Name";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(12, 61);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(33, 13);
            this.lblLevel.TabIndex = 13;
            this.lblLevel.Text = "Level";
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Location = new System.Drawing.Point(12, 88);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(40, 13);
            this.lblSchool.TabIndex = 14;
            this.lblSchool.Text = "School";
            // 
            // lblCastTime
            // 
            this.lblCastTime.AutoSize = true;
            this.lblCastTime.Location = new System.Drawing.Point(12, 114);
            this.lblCastTime.Name = "lblCastTime";
            this.lblCastTime.Size = new System.Drawing.Size(54, 13);
            this.lblCastTime.TabIndex = 15;
            this.lblCastTime.Text = "Cast Time";
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(12, 140);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(39, 13);
            this.lblRange.TabIndex = 16;
            this.lblRange.Text = "Range";
            // 
            // lblMaterialComponent
            // 
            this.lblMaterialComponent.AutoSize = true;
            this.lblMaterialComponent.Location = new System.Drawing.Point(12, 166);
            this.lblMaterialComponent.Name = "lblMaterialComponent";
            this.lblMaterialComponent.Size = new System.Drawing.Size(101, 13);
            this.lblMaterialComponent.TabIndex = 17;
            this.lblMaterialComponent.Text = "Material Component";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(12, 192);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(47, 13);
            this.lblDuration.TabIndex = 18;
            this.lblDuration.Text = "Duration";
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Location = new System.Drawing.Point(316, 33);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(311, 527);
            this.tbDescription.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(471, 566);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(552, 566);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(316, 14);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 22;
            this.lblDescription.Text = "Description";
            // 
            // clbClasses
            // 
            this.clbClasses.FormattingEnabled = true;
            this.clbClasses.Items.AddRange(new object[] {
            "Barbarian",
            "Bard",
            "Cleric",
            "Druid",
            "Figher",
            "Monk",
            "Paladin",
            "Ranger",
            "Rogue",
            "Sorcerer",
            "Warlock",
            "Wizard"});
            this.clbClasses.Location = new System.Drawing.Point(137, 216);
            this.clbClasses.Name = "clbClasses";
            this.clbClasses.Size = new System.Drawing.Size(156, 124);
            this.clbClasses.Sorted = true;
            this.clbClasses.TabIndex = 7;
            // 
            // lblClasses
            // 
            this.lblClasses.AutoSize = true;
            this.lblClasses.Location = new System.Drawing.Point(13, 216);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(43, 13);
            this.lblClasses.TabIndex = 24;
            this.lblClasses.Text = "Classes";
            // 
            // clbTags
            // 
            this.clbTags.FormattingEnabled = true;
            this.clbTags.Location = new System.Drawing.Point(138, 372);
            this.clbTags.Name = "clbTags";
            this.clbTags.Size = new System.Drawing.Size(156, 139);
            this.clbTags.TabIndex = 9;
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Location = new System.Drawing.Point(16, 383);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(31, 13);
            this.lblTags.TabIndex = 26;
            this.lblTags.Text = "Tags";
            // 
            // tbAddClass
            // 
            this.tbAddClass.Location = new System.Drawing.Point(137, 346);
            this.tbAddClass.Name = "tbAddClass";
            this.tbAddClass.Size = new System.Drawing.Size(127, 20);
            this.tbAddClass.TabIndex = 8;
            this.tbAddClass.Enter += new System.EventHandler(this.tbAddClass_Enter);
            this.tbAddClass.Leave += new System.EventHandler(this.tbAddClass_Leave);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(270, 346);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(20, 20);
            this.btnAddClass.TabIndex = 28;
            this.btnAddClass.Text = "+";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnAddTag
            // 
            this.btnAddTag.Location = new System.Drawing.Point(274, 517);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(20, 20);
            this.btnAddTag.TabIndex = 29;
            this.btnAddTag.Text = "+";
            this.btnAddTag.UseVisualStyleBackColor = true;
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
            // 
            // tbAddTag
            // 
            this.tbAddTag.Location = new System.Drawing.Point(138, 517);
            this.tbAddTag.Name = "tbAddTag";
            this.tbAddTag.Size = new System.Drawing.Size(130, 20);
            this.tbAddTag.TabIndex = 10;
            this.tbAddTag.Enter += new System.EventHandler(this.tbAddTag_Enter);
            this.tbAddTag.Leave += new System.EventHandler(this.tbAddTag_Leave);
            // 
            // frmAddSpell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 601);
            this.Controls.Add(this.tbAddTag);
            this.Controls.Add(this.btnAddTag);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.tbAddClass);
            this.Controls.Add(this.lblTags);
            this.Controls.Add(this.clbTags);
            this.Controls.Add(this.lblClasses);
            this.Controls.Add(this.clbClasses);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblMaterialComponent);
            this.Controls.Add(this.lblRange);
            this.Controls.Add(this.lblCastTime);
            this.Controls.Add(this.lblSchool);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbDuration);
            this.Controls.Add(this.cbConcentration);
            this.Controls.Add(this.tbMaterialComponent);
            this.Controls.Add(this.cbRitual);
            this.Controls.Add(this.cbMaterial);
            this.Controls.Add(this.cbSomantic);
            this.Controls.Add(this.cbVerbal);
            this.Controls.Add(this.tbRange);
            this.Controls.Add(this.tbCastTime);
            this.Controls.Add(this.tbSchool);
            this.Controls.Add(this.nudLevel);
            this.Controls.Add(this.tbName);
            this.Name = "frmAddSpell";
            this.Text = "frmAddSpell";
            this.Load += new System.EventHandler(this.frmAddSpell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.NumericUpDown nudLevel;
        private System.Windows.Forms.TextBox tbSchool;
        private System.Windows.Forms.TextBox tbCastTime;
        private System.Windows.Forms.TextBox tbRange;
        private System.Windows.Forms.CheckBox cbVerbal;
        private System.Windows.Forms.CheckBox cbSomantic;
        private System.Windows.Forms.CheckBox cbMaterial;
        private System.Windows.Forms.CheckBox cbRitual;
        private System.Windows.Forms.TextBox tbMaterialComponent;
        private System.Windows.Forms.CheckBox cbConcentration;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.Label lblCastTime;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.Label lblMaterialComponent;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.CheckedListBox clbClasses;
        private System.Windows.Forms.Label lblClasses;
        private System.Windows.Forms.CheckedListBox clbTags;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.TextBox tbAddClass;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.TextBox tbAddTag;
    }
}