using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ArcaneLibrary
{
    public partial class frmAddSpell : Form
    {

        public Spell returnSpell;

        public frmAddSpell()
        {
            InitializeComponent();
            btnAdd.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;

            foreach (string item in Manager.Classes)
            {
                clbClasses.Items.Add(item);
            }

            foreach (string item in Manager.Tags)
            {
                clbTags.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> classes = clbClasses.CheckedItems.OfType<string>().ToList();
            List<string> tags = clbTags.CheckedItems.OfType<string>().ToList();
            returnSpell = new Spell
                (
                    tbName.Text, 
                    (int)nudLevel.Value, 
                    tbSchool.Text, 
                    tbCastTime.Text, 
                    tbRange.Text, 
                    cbVerbal.Checked, 
                    cbSomantic.Checked, 
                    cbMaterial.Checked, 
                    cbRitual.Checked, 
                    tbMaterialComponent.Text, 
                    cbConcentration.Checked,
                    tbDuration.Text, 
                    tbDescription.Text, 
                    classes, 
                    tags
                );
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbAddClass.Text))
            {
                clbClasses.Items.Add(tbAddClass.Text);
                Manager.addClass(tbAddClass.Text);
                tbAddClass.Text = "";

            }

        }

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbAddTag.Text))
            {
                clbTags.Items.Add(tbAddTag.Text);
                Manager.addTag(tbAddTag.Text);
                tbAddTag.Text = "";

            }

        }

        private void tbAddClass_Enter(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = btnAddClass;
        }

        private void tbAddClass_Leave(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = null;
        }

        private void tbAddTag_Enter(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = btnAddTag;
        }

        private void tbAddTag_Leave(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = null;
        }

        private void frmAddSpell_Load(object sender, EventArgs e)
        {

        }
    }
}
