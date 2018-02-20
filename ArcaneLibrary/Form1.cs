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
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
            updateSpellList(Manager.Spells);
        }

        private void updateSpellList(List<Spell>spellList)
        {
            lbSpells.Items.Clear();
            foreach (Spell spell in spellList)
            {
                lbSpells.Items.Add(spell.name);
            }
        }

        private void updateItemList(List<Item>itemList)
        {
            lbItems.Items.Clear();
            foreach (Item item in itemList)
            {
                lbItems.Items.Add(item.name);
            }
        }
    

        private void lbSpells_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(tbSearchSpell.Text))
            {
                try
                {
                    tbSpell.Text = Manager.currentSpells[lbSpells.SelectedIndex].ToString();
                }
                catch (IndexOutOfRangeException indexException)
                {
                    tbSpell.Text = "";
                }
            }
            else
            {
                try
                {
                    tbSpell.Text = Manager.Spells[lbSpells.SelectedIndex].ToString();

                }
                catch (IndexOutOfRangeException indexException)
                {
                    tbSpell.Text = "";
                }
            }
            
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmAddItem addItem = new frmAddItem();
            DialogResult result = addItem.ShowDialog();
            if (result == DialogResult.OK)
            {
                Manager.addItem(addItem.returnItem);
                updateItemList(Manager.Items);
                lblSearchItem.Text = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddSpell addSpell = new frmAddSpell();
            DialogResult result = addSpell.ShowDialog();
            if (result == DialogResult.OK)
            {
                Manager.addSpell(addSpell.returnSpell);
                updateSpellList(Manager.Spells);
                lblSearchSpell.Text = "";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager.saveSpells();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbSearchItem.Text))
            {
                try
                {
                    tbItem.Text = Manager.currentItems[lbItems.SelectedIndex].ToString();
                }
                catch (Exception indexException)
                {
                    tbItem.Text = "";
                }
            }
            else
            {
                try
                {
                    tbItem.Text = Manager.Items[lbItems.SelectedIndex].ToString();

                }
                catch (Exception indexException)
                {
                    tbItem.Text = "";
                }
            }
        }

        private void tbSearchSpell_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSearchSpell.Text))
            {
                updateSpellList(Manager.Spells);
            }
            else
            {
                Manager.searchSpells(tbSearchSpell.Text);
                updateSpellList(Manager.currentSpells);
            }
            
        }

        private void tbSearchItem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSearchItem.Text))
            {
                updateItemList(Manager.Items);
            }
            else
            {
                Manager.searchItems(tbSearchItem.Text);
                updateItemList(Manager.currentItems);
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Manager.saveItems();
        }

        private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Manager.loadItems();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager.loadSpells();
        }

        private void btnEditSpell_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteSpell_Click(object sender, EventArgs e)
        {

        }
    }
}