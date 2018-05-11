using RPG_Manager.Shared.Dungeon_Related;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace RPG_Manager.Shared
{
    public enum MovementDirection { UP = 0, FORWARD, RIGHT, BACKWARD, LEFT, DOWNWARD }; // Used for determining where to move the focus to.

    public class Dungeon
    {
        private List<List<List<Room>>> layout;
        private List<Room> validRooms;
        private List<Item> validTreasure;
        private int x, y, z;                    // Current position in the dungeon
        private int xOffset, yOffset, zOffset;  // offsets to keep the integers positive for the indexes, but to allow negative coordinates.

        public List<List<List<Room>>> Layout { get => layout; set => layout = value; }
        public List<Room> ValidRooms { get => validRooms; set => validRooms = value; }
        public List<Item> ValidTreasure { get => validTreasure; set => validTreasure = value; }

        public Dungeon(List<Room> validRooms = null, List<Item> validTreasure = null)
        {
            layout = new List<List<List<Room>>>();
            this.validRooms = validRooms ?? new List<Room>();
            this.validTreasure = validTreasure ?? new List<Item>();
            Setup();
        }

        // Allows loading from an xml file
        public Dungeon(XElement element)
        {
            LoadFromXml(element);
        }

        private void Setup()
        {
            x = 0;
            y = 0;
            z = 0;
            xOffset = 0;
            yOffset = 0;
            zOffset = 0;
        }

        // Jumps to the desired coordinate, generating empty space all the way there if necessary.
        public void JumpTo(int x, int y, int z)
        {
            int distance;

            // handles x teleportation
            if(x + xOffset < 0)
            {
                distance = 0 - x + xOffset;
                for(int i = 0; i < distance; i++)
                {
                    BalanceLayout(true, insertPosition: 0);
                    xOffset++;
                }
            }
            if(x + xOffset > layout.Count - 1)
            {
                distance = layout.Count - 1 - (x + xOffset);
                for(int i = 0; i < distance; i++)
                {
                    BalanceLayout(true);
                }
            }
            this.x = x;

            // handles y teleportation
            if (y + yOffset < 0)
            {
                distance = 0 - y + yOffset;
                for (int i = 0; i < distance; i++)
                {
                    BalanceLayout(yDir: true, insertPosition: 0);
                    yOffset++;
                }
            }
            if (y + yOffset > layout[0].Count - 1)
            {
                distance = layout[0].Count - 1 - (y + xOffset);
                for (int i = 0; i < distance; i++)
                {
                    BalanceLayout(yDir: true);
                }
            }
            this.y = y;

            // handles z teleportation
            if (z + zOffset < 0)
            {
                distance = 0 - z + zOffset;
                for (int i = 0; i < distance; i++)
                {
                    BalanceLayout(zDir: true, insertPosition: 0);
                    zOffset++;
                }
            }
            if (z + zOffset > layout[0][0].Count - 1)
            {
                distance = layout[0][0].Count - 1 - (z + zOffset);
                for (int i = 0; i < distance; i++)
                {
                    BalanceLayout(zDir: true);
                }
            }
            this.z = z;
        }

        // Allows incrementing the current room in any cardinal direction.
        public void Navigate(MovementDirection direction)
        {
            switch(direction)
            {
                case MovementDirection.UP:
                    if (z + 1 > layout[x + xOffset][y + yOffset].Count - 1 || layout[x + xOffset][y + yOffset][z + 1 + zOffset] == null)
                    {
                        BalanceLayout(zDir: true);
                        layout[x + xOffset][y + yOffset][z + 1 + zOffset] = GenRoom();
                    }
                    z++;
                    break;

                case MovementDirection.DOWNWARD:
                    if (z - 1 + zOffset < 0)
                    {
                        BalanceLayout(zDir: true, insertPosition: 0);
                        zOffset++;
                    }
                    if (layout[x + xOffset][y + yOffset][z - 1 + zOffset] == null)
                        layout[x + xOffset][y + yOffset][z - 1 + zOffset] = GenRoom();
                    z--;
                    break;

                case MovementDirection.FORWARD:
                    if (x + 1 + xOffset > layout.Count - 1 || layout[x + 1 + xOffset][y + yOffset][z + zOffset] == null)
                    {
                        BalanceLayout(true);
                        layout[x + 1 + xOffset][y + yOffset][z + zOffset] = GenRoom();
                    }
                    x++;
                    break;

                case MovementDirection.BACKWARD:
                    if(x - 1 + xOffset < 0)
                    {
                        BalanceLayout(true, insertPosition: 0);
                        xOffset++;
                    }
                    if (layout[x - 1 + xOffset][y + yOffset][z + zOffset] == null)
                        layout[x - 1 + xOffset][y + yOffset][z + zOffset] = GenRoom();
                    x--;
                    break;

                case MovementDirection.RIGHT:
                    if(y + 1 + yOffset > layout[x + xOffset].Count - 1 || layout[x + xOffset][y + 1 + yOffset][z + zOffset] == null)
                    {
                        BalanceLayout(yDir: true);
                        layout[x + xOffset][y + 1 + yOffset][z + zOffset] = GenRoom();
                    }
                    y++;
                    break;

                case MovementDirection.LEFT:
                    if(y - 1 + yOffset < 0)
                    {
                        BalanceLayout(yDir: true, insertPosition: 0);
                        yOffset++;
                    }
                    if (layout[x + xOffset][y - 1 + yOffset][z + zOffset] == null)
                        layout[x + xOffset][y - 1 + yOffset][z + zOffset] = GenRoom();
                    y--;
                    break;

                default:
                    throw new Exception("Invalid direction!");
            }
        }

        // Ensures that every list in the layout matrix has the same count/length, filling it with emptiness to make up the differences.
        protected virtual void BalanceLayout(bool xDir = false, bool yDir = false, bool zDir = false, int insertPosition = -1)
        {
            if (xDir)
            {
                List<List<Room>> Row = new List<List<Room>>(layout[0].Count);
                for (int i = 0; i < layout[0].Count; i++)
                {
                    List<Room> Col = new List<Room>(layout[0][0].Count);
                    for (int j = 0; j < layout[0][0].Count; j++)
                        Col.Add(null);
                    Row.Add(Col);
                }

                if (insertPosition < 0)
                    layout.Add(Row);
                else
                    layout.Insert(0, Row);
            }

            if(yDir)
            {
                List<Room> Col = new List<Room>(layout[0][0].Count);
                for (int i = 0; i < layout[0][0].Count; i++)
                    Col.Add(null);

                for (int i = 0; i < layout.Count; i++)
                    if (insertPosition < 0)
                        layout[i].Add(Col);
                    else
                        layout[i].Insert(insertPosition, Col);
            }

            if(zDir)
            {
                for (int i = 0; i < layout.Count; i++)
                    for (int j = 0; j < layout[i].Count; j++)
                        if (insertPosition < 0)
                            layout[i][j].Add(null);
                        else
                            layout[i][j].Insert(insertPosition, null);
            }
        }

        // Generates a random, or specific room for the dungeon
        protected virtual Room GenRoom(int id = -1)
        {
            Random rng = new Random();
            Room temp = validRooms[(id < 0 || id > validRooms.Count - 1) ? rng.Next(0, validRooms.Count - 1) : id];
            temp.Regenerate();
            return temp;
        }

        public virtual XElement GenXml()
        {
            XElement temp = new XElement("Dungeon");

            // Generates the layout
            XElement layoutTemp = new XElement("Layout");
            int i = 0;
            foreach (List<List<Room>> row in layout)
            {
                XElement rowTemp = new XElement("Row", new XAttribute("Index", i++));
                int j = 0;
                foreach (List<Room> column in row)
                {
                    XElement colTemp = new XElement("Column", new XAttribute("Index", j++));
                    int k = 0;
                    foreach (Room room in column)
                    {
                        if (room == null)
                            colTemp.Add(new XElement("Room", new XAttribute("Index", k++), new XAttribute("ID", "Not Implemented")));
                        else
                        {
                            XElement roomTempTemp = room.GenXml();
                            roomTempTemp.Add(new XAttribute("Index", k++));
                            colTemp.Add(roomTempTemp);
                        }
                    }
                    rowTemp.Add(colTemp);
                }
                layoutTemp.Add(rowTemp);
            }
            temp.Add(layoutTemp);

            // Generates the valid room list
            XElement roomTemp = new XElement("ValidRooms");
            foreach (Room room in validRooms)
                roomTemp.Add(room.GenXml());
            temp.Add(roomTemp);

            // Generates the valid treasure list
            XElement treasureTemp = new XElement("ValidTreasure");
            foreach (Item treasure in validTreasure)
                treasureTemp.Add(treasure.GenXml());
            temp.Add(treasureTemp);


            return temp;
        }

        public virtual void LoadFromXml(XElement element)
        {
            layout = new List<List<List<Room>>>();
            validRooms = new List<Room>();
            validTreasure = new List<Item>();

            // Loads in the valid rooms list
            foreach (XElement e in element.XPathSelectElements("Dungeon/ValidRooms/Room"))
                validRooms.Add(new Room(e));

            // Loads in the valid treasure list
            foreach (XElement e in element.XPathSelectElements("Dungeon/ValidTreasure/Item"))
                validTreasure.Add(new Item(e));

            // Loads in the layout
            foreach(XElement e in element.XPathSelectElements("Dungeon/Layout/Row"))
            {
                List<List<Room>> row = new List<List<Room>>();
                foreach(XElement f in e.XPathSelectElements("Row/Column"))
                {
                    List<Room> col = new List<Room>();
                    foreach (XElement g in f.XPathSelectElements("Column/Room"))
                    {
                        if (g.XPathSelectElement("@ID").Value == "Not Implemented")
                            col.Add(null);
                        else
                            col.Add(new Room(g));
                    }
                    row.Add(col);
                }
                layout.Add(row);
            }
        }
    }
}
