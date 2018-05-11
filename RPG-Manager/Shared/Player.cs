using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace RPG_Manager.Shared
{
    public class Player : Character
    {
        private string playerName;

        public string PlayerName { get => playerName; set => playerName = value; }

        public Player(string name, string race, string playerName, int hp, int ac):base(name, race, hp, ac)
        {
            this.playerName = playerName;
        }

        public Player(XElement element):base(element)
        {
        }

        public override void LoadFromXml(XElement element)
        {
            base.LoadFromXml(element);

            playerName = element.XPathSelectElement("Player").Value;
        }

        public override XElement GenXml()
        {
            XElement temp =  base.GenXml();

            temp.Add(new XElement("Player", playerName));

            return temp;
        }
    }
}
