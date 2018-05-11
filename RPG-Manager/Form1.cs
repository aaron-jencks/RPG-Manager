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
using System.Xml.Linq;

namespace RPG_Manager
{
    public partial class Form1 : Form
    {
        private bool isStarted;
        private Game game;

        public Form1()
        {
            InitializeComponent();
            isStarted = false;
        }

        // Creates a new game.
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game = new Game();
            isStarted = true;
        }

        // Opens the dialog to load the game from an xml file
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameFolderBrowserDialog.Disposed += LoadGameFolderBrowserDialog_Disposed;
            GameFolderBrowserDialog.ShowDialog();
        }

        // Loads the game from an xml file
        private void LoadGameFolderBrowserDialog_Disposed(object sender, EventArgs e)
        {
            game.LoadFromXml(XElement.Load(GameFolderBrowserDialog.SelectedPath));
            isStarted = true;
        }

        // Opens the dialog to save the game to an xml file
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameFolderBrowserDialog.Disposed += SaveGameFolderBrowserDialog_Disposed;
            GameFolderBrowserDialog.ShowDialog();
        }

        // saves the game to an xml file
        private void SaveGameFolderBrowserDialog_Disposed(object sender, EventArgs e)
        {
            game.GenXml().Save(GameFolderBrowserDialog.SelectedPath);
        }

        // Opens the dialog for adding a new player to the game
        private void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(isStarted)
            {
                PlayerCreator form = new PlayerCreator();
                form.CompletionEvent += PlayerCreatorAddition_CompletionEvent;
                form.Show();
            }
        }

        // Adds a new player to the game
        private void PlayerCreatorAddition_CompletionEvent(object sender, CompletionEventArgs e)
        {
            game.Players.Add((Player)e.CompletedData);
        }

        // Exits the program
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        // Opens the dialog for adding a new npc to the game
        private void nPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isStarted)
            {
                CharacterCreator form = new CharacterCreator();
                form.CompletionEvent += NPCCharacterCreatorAddition_CompletionEvent;
                form.Show();
            }
        }

        // Adds a new npc to the game
        private void NPCCharacterCreatorAddition_CompletionEvent(object sender, CompletionEventArgs e)
        {
            game.Npcs.Add((Character)e.CompletedData);
        }

        // Opens the dialog for adding a new enemy to the game
        private void enemyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isStarted)
            {
                CharacterCreator form = new CharacterCreator();
                form.CompletionEvent += EnemyCharacterCreatorAddition_CompletionEvent;
                form.Show();
            }
        }

        // Adds a new enemy to the game
        private void EnemyCharacterCreatorAddition_CompletionEvent(object sender, CompletionEventArgs e)
        {
            game.Enemies.Add((Character)e.CompletedData);
        }
    }
}
