using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace RPG_Manager.Shared.Dungeon_Related
{
    public class Room
    {
        private List<Tuple<Tuple<int, int>, Item>> treasure;
        private List<Tuple<int, int>> wallLayout;
        private List<Tuple<List<Tuple<int, int>>,Color>> obstacles;
        private List<Item> validTreasure;
        private List<Tuple<int, int, int>> entrances;          // Determines where doors are <x, y, type = [0:wall, 1:ceiling, 2:trapdoor]>
        private long id;
        private static long roomCount = 0;

        // Should be removed eventually, just here because I'm lazy in layout generation.
        private int numObstacles;
        private int numTreasures;
        private int numEntrances;
        private int height;
        private int width;

        public List<Tuple<Tuple<int, int>, Item>> Treasure { get => treasure; set => treasure = value; }
        public List<Tuple<int, int>> WallLayout { get => wallLayout; set => wallLayout = value; }
        public List<Tuple<List<Tuple<int, int>>, Color>> Obstacles { get => obstacles; set => obstacles = value; }
        public List<Item> ValidTreasure { get => validTreasure; set => validTreasure = value; }
        public long Id { get => id; set => id = value; }
        public static long RoomCount { get => roomCount; }

        // Creates a square room with length and width, and n number of treasures and obstacles and entrances
        public Room(int height, int width, List<Item> validTreasure = null, int numObstacles = 0, int numTreasures = 0, int numEntrances = 2)
        {
            Setup(validTreasure);

            this.height = height;
            this.width = width;
            this.numObstacles = numObstacles;
            this.numTreasures = numTreasures;
            this.numEntrances = numEntrances;

            wallLayout.AddRange(new List<Tuple<int,int>>(){
                new Tuple<int, int>(0, 0),
                new Tuple<int, int>(width, 0),
                new Tuple<int, int>(width, height),
                new Tuple<int, int>(0, height) });

            Regenerate();
        }

        // Creates an empty room with now dimensions, can be used for handcrafted rooms.
        public Room(List<Item> validTreasure = null)
        {
            Setup(validTreasure);
        }

        // allows the creation of a room from a file.
        public Room(XElement element)
        {
            LoadFromXml(element);
        }

        //Initializes the valid treasure list and all of the other lists.
        protected virtual void Setup(List<Item> validTreasure = null)
        {
            this.validTreasure = validTreasure ?? new List<Item> { new Item("Gold Piece") };
            treasure = new List<Tuple<Tuple<int, int>, Item>>();
            wallLayout = new List<Tuple<int, int>>();
            obstacles = new List<Tuple<List<Tuple<int, int>>, Color>>();
            entrances = new List<Tuple<int, int, int>>();
            id = roomCount++;
        }

        // Generates an obstacle based on the id and the number of points, it's centered at (x,y) with radii between the max and min
        protected virtual Tuple<List<Tuple<int, int>>, Color> GenObstacle(int x, int y, long id, int minRadius = 1, int maxRadius = 5, int numPoints = 10)
        {
            Random rng = new Random();
            List<Tuple<int, int>> layout = new List<Tuple<int, int>>(numPoints);

            for(int i = 0; i < numPoints; i++)
            {
                layout.Add(new Tuple<int, int>(x + rng.Next(minRadius, maxRadius), y + rng.Next(minRadius, maxRadius)));
            }

            return new Tuple<List<Tuple<int,int>>,Color>(layout, Color.DarkGray);
        }

        // Generates a treasure based on the id at the location (x,y)
        protected virtual Tuple<Tuple<int, int>, Item> GenTreasure(int x, int y, long id)
        {
            Predicate<Item> findId = (Item i) => { return i.Id == id; };
            if (validTreasure.Find(findId) != null)
                return new Tuple<Tuple<int, int>, Item>(new Tuple<int, int>(x, y), validTreasure.Find(findId));
            else
                throw new Exception("The treasure with id " + id + " does not exist!");
        }

        // Re-creates this room based off of the original specs supplied.
        public virtual void Regenerate()
        {
            Random rng = new Random();

            // Generates the obstacles
            if (numObstacles > 0)
                for (int i = 0; i < numObstacles; i++)
                    GenObstacle(rng.Next(0, width), rng.Next(0, height), 0);

            // Generates the loot
            if (numTreasures > 0)
                for (int i = 0; i < numTreasures; i++)
                    GenTreasure(rng.Next(0, width), rng.Next(0, height), rng.Next(0, validTreasure.Count));

            // Generates entrances into the room
            if (numEntrances > 0)
            {
                List<bool> usedLocations = new List<bool>(wallLayout.Count + 2);
                for (int i = 0; i < wallLayout.Count; i++)
                    usedLocations.Add(false);

                for (int i = 0; i < numEntrances; i++)
                {
                    // Randomly selects a wall until it finds a wall that hasn't been selected before.
                    int wall;
                    do
                    {
                        wall = rng.Next(0, wallLayout.Count + 1);
                    }
                    while (usedLocations[wall]);

                    usedLocations[wall] = true;

                    // Generates a door on the wall between the current wall index, and the next one (These are really the room coordinate nodes, not walls)
                    if (wall < wallLayout.Count)
                        entrances.Add(new Tuple<int, int, int>(
                            rng.Next(wallLayout[wall].Item1, wallLayout[((wall == wallLayout.Count - 1) ? 0 : wall + 1)].Item1),
                            rng.Next(wallLayout[wall].Item2, wallLayout[((wall == wallLayout.Count - 1) ? 0 : wall + 1)].Item2), 0));
                    else
                        // Creates trap doors or ladders.
                        entrances.Add(new Tuple<int, int, int>(
                            rng.Next(0, width), rng.Next(0, height),
                            wall - (wallLayout.Count - 1)));
                }
            }
            else
                throw new Exception("You need at least one entrance into a room!");
        }

        // generates an xml schema that stores the information for this room.
        public virtual XElement GenXml()
        {
            XElement temp = new XElement("Room", new XAttribute("ID", id));

            // converts the wall list
            XElement wallTemp = new XElement("WallLayout");
            foreach (Tuple<int, int> point in wallLayout)
                wallTemp.Add(new XElement("Point",
                    new XAttribute("X", point.Item1),
                    new XAttribute("Y", point.Item2)));
            temp.Add(wallTemp);

            // converts the obstacle list
            XElement obstacleTemp = new XElement("Obstacles");
            foreach (Tuple<List<Tuple<int, int>>,Color> obstacle in obstacles)
            {
                XElement obTempTemp = new XElement("Obstacle", new XAttribute("Color", obstacle.Item2.ToArgb()));

                wallTemp = new XElement("Layout");
                foreach (Tuple<int, int> point in obstacle.Item1)
                    wallTemp.Add(new XElement("Point",
                        new XAttribute("X", point.Item1),
                        new XAttribute("Y", point.Item2)));
                obTempTemp.Add(wallTemp);

                obstacleTemp.Add(obTempTemp);
            }
            temp.Add(obstacleTemp);

            // converts the treasure list
            XElement treasureTemp = new XElement("Treasures");
            foreach(Tuple<Tuple<int,int>,Item> item in treasure)
            {
                XElement treasureTempTemp = new XElement("Treasure",
                    new XAttribute("X", item.Item1.Item1),
                    new XAttribute("Y", item.Item1.Item2),
                    new XAttribute("ID", item.Item2.Id));

                treasureTemp.Add(treasureTempTemp);
            }
            temp.Add(treasureTemp);

            // converts the valid spawnable treasures
            XElement validTreasureTemp = new XElement("ValidTreasures");
            foreach (Item i in validTreasure)
                validTreasureTemp.Add(i.GenXml());
            temp.Add(validTreasureTemp);

            // converts the entrance list
            XElement entranceTemp = new XElement("Entrances");
            foreach (Tuple<int, int, int> entrance in entrances)
                entranceTemp.Add(new XElement("Entrance",
                    new XAttribute("X", entrance.Item1),
                    new XAttribute("Y", entrance.Item2),
                    new XAttribute("ID", entrance.Item3)));
            temp.Add(entranceTemp);

            return temp;
        }

        // Loads the room from an xml element
        public virtual void LoadFromXml(XElement element)
        {
            Setup();

            id = Convert.ToUInt32(element.XPathSelectElement("@ID").Value);

            // Reads in the wall layout
            foreach (XElement e in element.XPathSelectElements("Room/WallLayout/Point"))
                wallLayout.Add(new Tuple<int, int>(
                    Convert.ToInt32(e.XPathSelectElement("@X").Value),
                    Convert.ToInt32(e.XPathSelectElement("@Y").Value)));

            // Reads in the obstacles
            foreach(XElement e in element.XPathSelectElements("Room/Obstacles/Obstacle"))
            {
                // Loads the layout
                List<Tuple<int, int>> layout = new List<Tuple<int, int>>();
                foreach (XElement point in e.XPathSelectElements("Layout/Point"))
                    layout.Add(new Tuple<int, int>(
                        Convert.ToInt32(point.XPathSelectElement("@X").Value),
                        Convert.ToInt32(point.XPathSelectElement("@Y").Value)));

                // Loads the color
                obstacles.Add(new Tuple<List<Tuple<int, int>>, Color>(layout,
                    Color.FromArgb(Convert.ToInt32(e.XPathSelectElement("@Color").Value))));
            }

            // Reads in the valid treasures
            foreach (XElement e in element.XPathSelectElements("Room/ValidTreasures/Item"))
            {
                validTreasure.Add(new Item(e));
            }

            // Reads in all of the spawned treasure
            foreach(XElement e in element.XPathSelectElements("Room/Treasures/Treasure"))
            {
                Predicate<Item> findItem = (Item i) => { return i.Id == Convert.ToInt32(e.XPathSelectElement("@ID")); };
                if (validTreasure.Find(findItem) != null)
                    treasure.Add(new Tuple<Tuple<int, int>, Item>(new Tuple<int, int>(
                        Convert.ToInt32(e.XPathSelectElement("@X").Value),
                        Convert.ToInt32(e.XPathSelectElement("@Y").Value)),
                        validTreasure.Find(findItem)));

            }

            // Reads in all of the entrances
            foreach (XElement e in element.XPathSelectElements("Room/Entrances/Entrance"))
                entrances.Add(new Tuple<int, int, int>(
                    Convert.ToInt32(e.XPathSelectElement("@X").Value),
                    Convert.ToInt32(e.XPathSelectElement("@Y").Value),
                    Convert.ToInt32(e.XPathSelectElement("@ID").Value)));
        }
    }
}
