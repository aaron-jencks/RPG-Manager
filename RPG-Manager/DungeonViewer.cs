using RPG_Manager.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Manager
{
    public partial class DungeonViewer : Form
    {
        private Dungeon dungeon;

        public DungeonViewer()
        {
            InitializeComponent();
            initialize();
        }

        public DungeonViewer(Dungeon dungeon)
        {
            InitializeComponent();
            this.dungeon = dungeon;
            initialize();
        }

        private void initialize()
        {
            //Figure out how to make image reference.
        }

        

        // Resets the dungeon to its original state
        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
        }
    }
}
