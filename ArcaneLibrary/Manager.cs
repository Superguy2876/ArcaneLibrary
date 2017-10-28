using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Text.RegularExpressions;

namespace ArcaneLibrary
{
    static class Manager
    {
        public static List<Spell> Spells = new List<Spell>();
        public static List<string> Tags = new List<string>();
        public static List<string> Classes = new List<string>();
        public static List<Item> Items = new List<Item>();
        public static List<Item> currentItems = new List<Item>();
        public static List<Spell> currentSpells = new List<Spell>();

        public static void addSpell(Spell spell)
        {
            Spells.Add(spell);
            Spells.Sort();

            
        }

        public static void addClass(string classString)
        {
            Classes.Add(classString);
            Classes.Sort();
        }

        public static void addTag(string tag)
        {
            Tags.Add(tag);
            Tags.Sort();
        }

        public static void addItem(Item item)
        {
            Items.Add(item);
            Items.Sort();
        }

        public static void searchItems(string searchString)
        {
            currentItems.Clear();
            Regex regex = new Regex(searchString, RegexOptions.IgnoreCase);
            foreach (Item item in Items)
            {
                if (regex.IsMatch(item.ToString()))
                {
                    currentItems.Add(item);
                }
            }
            currentItems.Sort();
        }

        public static void searchSpells(string searchString)
        {
            currentSpells.Clear();
            Regex regex = new Regex(searchString, RegexOptions.IgnoreCase);
            foreach (Spell spell in Spells)
            {
                if (regex.IsMatch(spell.ToString()))
                {
                    currentSpells.Add(spell);
                }
            }
            currentSpells.Sort();
        }

        public static void saveItems()
        {
            XmlSerializer writer =
                new XmlSerializer(typeof(List<Item>));
            SaveFileDialog saveItemFileDialog = new SaveFileDialog();

            saveItemFileDialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";

            System.IO.Stream saveStream;

            if (saveItemFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((saveStream = saveItemFileDialog.OpenFile()) != null)
                {
                    writer.Serialize(saveStream, Items);
                    saveStream.Close();
                }
            }
        }

        public static void saveSpells()
        {
            XmlSerializer writer =
                new XmlSerializer(typeof(List<Spell>));
            SaveFileDialog saveSpellFileDialog = new SaveFileDialog();

            saveSpellFileDialog.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";

            System.IO.Stream saveStream;

            //System.IO.FileStream file = System.IO.File.Create(@"spells.xml");

            if(saveSpellFileDialog.ShowDialog() == DialogResult.OK)
            {
                if((saveStream = saveSpellFileDialog.OpenFile()) != null)
                {
                    writer.Serialize(saveStream, Spells);
                    saveStream.Close();
                }
            }


        }

        public static void loadItems()
        {
            XmlSerializer reader = new XmlSerializer(typeof(List<Item>));
            System.IO.Stream loadStream;

            OpenFileDialog loadItemFileDialog = new OpenFileDialog();

            loadItemFileDialog.Filter = "XML Files(*.xml)| *.xml | All Files(*.*) | *.*";
            loadItemFileDialog.RestoreDirectory = true;

            if(loadItemFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((loadStream = loadItemFileDialog.OpenFile()) != null)
                    {

                        List<Item> tempList = reader.Deserialize(loadStream) as List<Item>;
                        Items.AddRange(tempList);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }

        }

        public static void loadSpells()
        {
            XmlSerializer reader = new XmlSerializer(typeof(List<Spell>));
            System.IO.Stream loadStream;

            OpenFileDialog loadSpellFileDialog = new OpenFileDialog();

            loadSpellFileDialog.Filter = "XML Files(*.xml)| *.xml | All Files(*.*) | *.*";
            loadSpellFileDialog.RestoreDirectory = true;

            if (loadSpellFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((loadStream = loadSpellFileDialog.OpenFile()) != null)
                    {

                        List<Spell> tempList = reader.Deserialize(loadStream) as List<Spell>;
                        Spells.AddRange(tempList);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.ToString());
                }
            }

        }

    }
}
