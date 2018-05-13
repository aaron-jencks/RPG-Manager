using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace RPG_Manager.Shared
{
    public class Game
    {
        private string name;
        private List<Player> players;
        private List<Character> npcs;
        private List<Character> enemies;
        private Dungeon dungeon;

        public List<Player> Players { get => players; set => players = value; }
        public List<Character> Npcs { get => npcs; set => npcs = value; }
        public List<Character> Enemies { get => enemies; set => enemies = value; }
        public Dungeon Dungeon { get => dungeon; set => dungeon = value; }
        public string Name { get => name; set => name = value; }

        public Game(string name = "")
        {
            this.name = name;
            players = new List<Player>();
            npcs = new List<Character>();
            enemies = new List<Character>();
            dungeon = new Dungeon();
        }

        public virtual void LoadFromXml(XElement element)
        {
            players = new List<Player>();
            npcs = new List<Character>();
            enemies = new List<Character>();

            name = element.XPathSelectElement("@Name").Value;

            // Loads player list
            foreach (XElement e in element.XPathSelectElements("Players/Character"))
                players.Add(new Player(e));

            // Loads npc list
            foreach (XElement e in element.XPathSelectElements("NPCs/Character"))
                npcs.Add(new Character(e));

            // Loads the enemy list
            foreach (XElement e in element.XPathSelectElements("Enemies/Character"))
                enemies.Add(new Character(e));

            // Loads the dungeon
            dungeon = new Dungeon(element.XPathSelectElement("Dungeon"));
        }

        public virtual XElement GenXml()
        {
            XElement temp = new XElement("Game", new XAttribute("Name", name));

            // converts player list
            XElement pTemp = new XElement("Players");
            foreach (Player p in players)
                pTemp.Add(p.GenXml());
            temp.Add(pTemp);

            // converts npc list
            XElement nTemp = new XElement("NPCs");
            foreach (Character n in npcs)
                nTemp.Add(n.GenXml());
            temp.Add(nTemp);

            // converts the enemy list
            XElement eTemp = new XElement("Enemies");
            foreach (Character e in enemies)
                eTemp.Add(e.GenXml());
            temp.Add(eTemp);

            // converts dungeon
            temp.Add(dungeon.GenXml());

            return temp;
        }
    }
}
