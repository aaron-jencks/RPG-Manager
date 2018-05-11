using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;
using RPG_Manager.Shared;

namespace RPG_Manager
{
    public class Character
    {
        private string name;
        private string race;
        private int hp;
        private int ac;
        private List<Tuple<Item, int>> inventory;

        public string Name { get => name; set => name = value; }
        public string Race { get => race; set => race = value; }
        public int Hp { get => hp; set => hp = value; }
        public int AC { get => ac; set => ac = value; }
        public List<Tuple<Item, int>> Inventory { get => inventory; set => inventory = value; }

        public Character(string name, string race, int hp, int ac)
        {
            this.name = name;
            this.race = race;
            this.hp = hp;
            this.ac = ac;
            inventory = new List<Tuple<Item, int>>();
        }

        // Allows for loading from an xml file
        public Character(XElement element)
        {
            LoadFromXml(element);
        }

        public virtual void LoadFromXml(XElement element)
        {
            inventory = new List<Tuple<Item, int>>();

            name = element.XPathSelectElement("@Name").Value;
            race = element.XPathSelectElement("@Race").Value;
            hp = Convert.ToInt32(element.XPathSelectElement("@HP").Value);
            ac = Convert.ToInt32(element.XPathSelectElement("@AC").Value);

            // Loads in the inventory
            foreach (XElement e in element.XPathSelectElements("Inventory/Item"))
                inventory.Add(new Tuple<Item, int>(new Item(e), Convert.ToInt32(e.XPathSelectElement("@Quantity").Value)));
        }

        public virtual XElement GenXml()
        {
            XElement temp = new XElement("Character",
                new XAttribute("Name", name),
                new XAttribute("Race", race),
                new XAttribute("HP", hp),
                new XAttribute("AC", ac));

            // converts the inventory
            XElement invTemp = new XElement("Inventory");
            foreach(Tuple<Item, int> item in inventory)
            {
                XElement itemTemp = item.Item1.GenXml();
                itemTemp.Add(new XAttribute("Quantity", item.Item2));
                invTemp.Add(itemTemp);
            }
            temp.Add(invTemp);

            return temp;
        }
    }
}
