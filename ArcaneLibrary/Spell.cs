using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcaneLibrary
{
    public class Spell : IComparable<Spell>
    {
        public string       name;
        public int          level;
        public string       school;
        public string       castTime;
        public string       range;
        public bool         verbal;
        public bool         somantic;
        public bool         material;
        public bool         ritual;
        public string       materialComponent;
        public bool         concentration;
        public string       duration;
        public string       description;
        public List<string> classes;
        public List<string> tags;

        public Spell()
        {
            
        }

        public Spell(string name, int level, string school, string castTime, string range, bool verbal, bool somantic,
            bool material, bool ritual, string materialComponent, bool concentration, string duration, string description, List<string> classes, List<string> tags)
        {
            this.name =                 name;             
            this.level =                level;            
            this.school =               school;           
            this.castTime =             castTime;      
            this.range =                range;            
            this.verbal =               verbal;           
            this.somantic =             somantic;         
            this.material =             material;         
            this.ritual =               ritual;           
            this.materialComponent =    materialComponent;
            this.concentration =        concentration;    
            this.duration =             duration;         
            this.description =          description;      
            this.classes =              classes;          
            this.tags =                 tags;             
        }

        public int CompareTo(Spell that)
        {
            return this.name.CompareTo(that.name);
        }

        override
        public string ToString()
        {
            string postfix;
            switch (level)
            {
                case 1:
                    postfix = "st";
                    break;
                case 2:
                    postfix = "nd";
                    break;
                case 3:
                    postfix = "rd";
                    break;
                default:
                    postfix = "th";
                    break;
            }

            string components = "";
            if (this.verbal)
            {
                components = components + "V";
            }
            if (this.somantic)
            {
                if (this.verbal)
                {
                    components = components + ", S";
                }
                else
                {
                    components = components + "S";
                }
            }
            if (this.material)
            {
                if (this.verbal || this.somantic)
                {
                    components = components + ", M";
                }
                else
                {
                    components = components + "M";
                }
                components = components + " (" + this.materialComponent + ")";
            }
                
            return 
                (this.name + "\r\n" +
                (
                    this.level == 0 ? 
                    (this.school + " Cantrip") :
                    (this.level + postfix + " Level " + this.school 
                    + ( ritual ? " (Ritual)": "" ))
                )
                + "\r\n" +
                "Classes: " + String.Join(", ", this.classes) + "\r\n" +
                "Casting Time: " + this.castTime + "\r\n" +
                "Range: " + this.range + "\r\n" +
                "Components: " + components + "\r\n" + 
                "Duration: " + this.duration + "\r\n" + 
                this.description + "\r\n" +
                "Tags: " + String.Join(", ", this.tags));
        }

    }
}
