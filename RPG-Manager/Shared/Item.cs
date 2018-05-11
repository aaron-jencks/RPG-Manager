using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace RPG_Manager.Shared
{
    public class Item
    {
        private string name;
        private string description;
        private long id;
        private static long itemCount = 0;

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public long Id { get => id; }

        public Item(string name, string description = "")
        {
            this.name = name;
            this.description = description;
            id = itemCount++;
        }

        // Allows the creating an item from a file.
        public Item(XElement element)
        {
            LoadFromXml(element);
        }

        // generates an xml element based off of the current item
        public virtual XElement GenXml()
        {
            return new XElement("Item", new XAttribute("ID", id),
                new XAttribute("Name", name), new XAttribute("Description", description));
        }

        // Loads the item from the xml element given
        public virtual void LoadFromXml(XElement element)
        {
            name = element.XPathSelectElement("Item[@Name]").Value;
            description = element.XPathSelectElement("Item[@Description]").Value;
            id = Convert.ToUInt32(element.XPathSelectElement("Item[@ID]").Value);
        }
    }
}
