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
    public partial class MainHost : Form
    {
        private bool isStarted;
        private Game game;

        public MainHost()
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
            Player temp = (Player)e.CompletedData;
            game.Players.Add(temp);
            playerListBox.Items.Add(temp.PlayerName);
            playerListBox.Invalidate();
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
            Character temp = (Character)e.CompletedData;
            game.Npcs.Add(temp);
            npcListBox.Items.Add(temp.Name);
            npcListBox.Invalidate();
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
            Character temp = (Character)e.CompletedData;
            game.Enemies.Add(temp);
            enemyListBox.Items.Add(temp.Name);
            enemyListBox.Invalidate();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (isStarted)
            {
                PlayerCreator form = new PlayerCreator();
                form.CompletionEvent += PlayerCreatorAddition_CompletionEvent;
                form.Show();
            }
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (isStarted)
            {
                CharacterCreator form = new CharacterCreator();
                form.CompletionEvent += NPCCharacterCreatorAddition_CompletionEvent;
                form.Show();
            }
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (isStarted)
            {
                CharacterCreator form = new CharacterCreator();
                form.CompletionEvent += EnemyCharacterCreatorAddition_CompletionEvent;
                form.Show();
            }
        }

        // Removes a player from the game
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.Players.RemoveAt(playerListBox.SelectedIndex);
            playerListBox.Items.RemoveAt(playerListBox.SelectedIndex);
        }

        // Removes a npc from the game
        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            game.Npcs.RemoveAt(npcListBox.SelectedIndex);
            playerListBox.Items.RemoveAt(npcListBox.SelectedIndex);
        }

        // Removes an enemy from the game
        private void removeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            game.Enemies.RemoveAt(enemyListBox.SelectedIndex);
            playerListBox.Items.RemoveAt(enemyListBox.SelectedIndex);
        }

        // Allows editing of a selected player
        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (isStarted)
            {
                PlayerCreator form = new PlayerCreator(game.Players[playerListBox.SelectedIndex]);  // Passes in the selected player object.

                // Removes that player object from the lists
                game.Players.RemoveAt(playerListBox.SelectedIndex);
                playerListBox.Items.RemoveAt(playerListBox.SelectedIndex);

                form.CompletionEvent += PlayerCreatorAddition_CompletionEvent;
                form.Show();
            }
        }

        // Allows editing of a selected npc
        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (isStarted)
            {
                CharacterCreator form = new CharacterCreator(game.Npcs[npcListBox.SelectedIndex]);  // Passes in the selected npc object.

                // Removes that npc object from the lists
                game.Npcs.RemoveAt(npcListBox.SelectedIndex);
                npcListBox.Items.RemoveAt(npcListBox.SelectedIndex);

                form.CompletionEvent += NPCCharacterCreatorAddition_CompletionEvent;
                form.Show();
            }
        }

        // Allows editing of a selected enemy
        private void editToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (isStarted)
            {
                CharacterCreator form = new CharacterCreator(game.Enemies[enemyListBox.SelectedIndex]); // Passes in the selected enemy object.

                // Removes that enemy object from the lists
                game.Enemies.RemoveAt(enemyListBox.SelectedIndex);
                enemyListBox.Items.RemoveAt(enemyListBox.SelectedIndex);

                form.CompletionEvent += EnemyCharacterCreatorAddition_CompletionEvent;
                form.Show();
            }
        }
    }
}
