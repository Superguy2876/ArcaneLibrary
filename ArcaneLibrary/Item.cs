using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcaneLibrary 
{
    public class Item : IComparable<Item>
    {
        public string       name;
        public string       type;
        public string       rarity;
        public bool         attunement;
        public List<string> attuneList;
        public string       description;
        public List<string> tags;

        public Item()
        { }

        public Item(string name, string type, string rarity, bool attunement, List<string> attuneList, string description, List<string> tags)
        {
            this.name =               name;       
            this.type =               type;       
            this.rarity =             rarity;     
            this.attunement =         attunement;
            this.attuneList =         attuneList;
            this.description =        description;
            this.tags =               tags;
        }

        public int CompareTo(Item that)
        {
            return this.name.CompareTo(that.name);
        }

        override
        public string ToString()
        {
            return
                this.name + "\r\n"
                + this.type +
                (attunement ? ", (Requires Attunement" +
                (attuneList.Any() ? " by " + String.Join(", ", this.attuneList) : ")") : "") + "\r\n"
                + description + "\r\n"
                + "Tags: " + String.Join(", ", this.tags);
        }

    }
}
