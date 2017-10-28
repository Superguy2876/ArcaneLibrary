using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcaneLibrary
{
    public partial class frmAddItem : Form
    {

        public Item returnItem;

        public frmAddItem()
        {
            InitializeComponent();

            btnAdd.DialogResult = DialogResult.OK;
            btnCancel.DialogResult = DialogResult.Cancel;

           foreach(string item in Manager.Tags)
            {
                clbTags.Items.Add(item);
            }
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> attuneList = clbAttuneList.CheckedItems.OfType<string>().ToList();
            List<string> tags = clbTags.CheckedItems.OfType<string>().ToList();

            returnItem = new Item
                (
                    tbName.Text,
                    tbType.Text,
                    tbRarity.Text,
                    cbAttunement.Checked,
                    attuneList,
                    tbDescription.Text,
                    tags
                );
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

        private void btnAddAttune_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbAddAttunement.Text))
            {
                clbAttuneList.Items.Add(tbAddAttunement.Text);
                tbAddAttunement.Text = "";
            }
        }

        private void tbAddAttunement_Enter(object sender, EventArgs e)
        {
            ActiveForm.AcceptButton = btnAddAttune;

        }

        private void tbAddAttunement_Leave(object sender, EventArgs e)
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
    }
}
