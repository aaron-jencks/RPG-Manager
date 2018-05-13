namespace RPG_Manager
{
    partial class MainHost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enemyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dungeonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wholeThingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dungeonToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nPCsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.enemiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dungeonToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.GameFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gameNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.npcListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.enemyListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dungeonSizeText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dungeonPositionText = new System.Windows.Forms.Label();
            this.newGameWarningTextLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(417, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.dungeonToolStripMenuItem1,
            this.optionsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerToolStripMenuItem,
            this.nPCToolStripMenuItem,
            this.enemyToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.playerToolStripMenuItem.Text = "Player";
            this.playerToolStripMenuItem.Click += new System.EventHandler(this.playerToolStripMenuItem_Click);
            // 
            // nPCToolStripMenuItem
            // 
            this.nPCToolStripMenuItem.Name = "nPCToolStripMenuItem";
            this.nPCToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.nPCToolStripMenuItem.Text = "NPC";
            this.nPCToolStripMenuItem.Click += new System.EventHandler(this.nPCToolStripMenuItem_Click);
            // 
            // enemyToolStripMenuItem
            // 
            this.enemyToolStripMenuItem.Name = "enemyToolStripMenuItem";
            this.enemyToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.enemyToolStripMenuItem.Text = "Enemy";
            this.enemyToolStripMenuItem.Click += new System.EventHandler(this.enemyToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dungeonToolStripMenuItem});
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // dungeonToolStripMenuItem
            // 
            this.dungeonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentRoomToolStripMenuItem,
            this.wholeThingToolStripMenuItem});
            this.dungeonToolStripMenuItem.Name = "dungeonToolStripMenuItem";
            this.dungeonToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.dungeonToolStripMenuItem.Text = "Dungeon";
            // 
            // currentRoomToolStripMenuItem
            // 
            this.currentRoomToolStripMenuItem.Name = "currentRoomToolStripMenuItem";
            this.currentRoomToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.currentRoomToolStripMenuItem.Text = "Current Room";
            // 
            // wholeThingToolStripMenuItem
            // 
            this.wholeThingToolStripMenuItem.Name = "wholeThingToolStripMenuItem";
            this.wholeThingToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.wholeThingToolStripMenuItem.Text = "Whole thing...";
            // 
            // dungeonToolStripMenuItem1
            // 
            this.dungeonToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layoutToolStripMenuItem});
            this.dungeonToolStripMenuItem1.Name = "dungeonToolStripMenuItem1";
            this.dungeonToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.dungeonToolStripMenuItem1.Text = "Dungeon";
            // 
            // layoutToolStripMenuItem
            // 
            this.layoutToolStripMenuItem.Name = "layoutToolStripMenuItem";
            this.layoutToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.layoutToolStripMenuItem.Text = "Layout";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playersToolStripMenuItem,
            this.nPCsToolStripMenuItem,
            this.enemiesToolStripMenuItem});
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // playersToolStripMenuItem
            // 
            this.playersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem3,
            this.removeToolStripMenuItem,
            this.editToolStripMenuItem1});
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.playersToolStripMenuItem.Text = "Players";
            // 
            // addToolStripMenuItem3
            // 
            this.addToolStripMenuItem3.Name = "addToolStripMenuItem3";
            this.addToolStripMenuItem3.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem3.Text = "Add";
            this.addToolStripMenuItem3.Click += new System.EventHandler(this.addToolStripMenuItem3_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem1.Text = "Edit";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // nPCsToolStripMenuItem
            // 
            this.nPCsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem2,
            this.removeToolStripMenuItem1,
            this.editToolStripMenuItem2});
            this.nPCsToolStripMenuItem.Name = "nPCsToolStripMenuItem";
            this.nPCsToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.nPCsToolStripMenuItem.Text = "NPCs";
            // 
            // addToolStripMenuItem2
            // 
            this.addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            this.addToolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem2.Text = "Add";
            this.addToolStripMenuItem2.Click += new System.EventHandler(this.addToolStripMenuItem2_Click);
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem1.Text = "Remove";
            this.removeToolStripMenuItem1.Click += new System.EventHandler(this.removeToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem2
            // 
            this.editToolStripMenuItem2.Name = "editToolStripMenuItem2";
            this.editToolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem2.Text = "Edit";
            this.editToolStripMenuItem2.Click += new System.EventHandler(this.editToolStripMenuItem2_Click);
            // 
            // enemiesToolStripMenuItem
            // 
            this.enemiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.removeToolStripMenuItem2,
            this.editToolStripMenuItem3});
            this.enemiesToolStripMenuItem.Name = "enemiesToolStripMenuItem";
            this.enemiesToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.enemiesToolStripMenuItem.Text = "Enemies";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // removeToolStripMenuItem2
            // 
            this.removeToolStripMenuItem2.Name = "removeToolStripMenuItem2";
            this.removeToolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem2.Text = "Remove";
            this.removeToolStripMenuItem2.Click += new System.EventHandler(this.removeToolStripMenuItem2_Click);
            // 
            // editToolStripMenuItem3
            // 
            this.editToolStripMenuItem3.Name = "editToolStripMenuItem3";
            this.editToolStripMenuItem3.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem3.Text = "Edit";
            this.editToolStripMenuItem3.Click += new System.EventHandler(this.editToolStripMenuItem3_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dungeonToolStripMenuItem2});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // dungeonToolStripMenuItem2
            // 
            this.dungeonToolStripMenuItem2.Name = "dungeonToolStripMenuItem2";
            this.dungeonToolStripMenuItem2.Size = new System.Drawing.Size(123, 22);
            this.dungeonToolStripMenuItem2.Text = "Dungeon";
            // 
            // playerListBox
            // 
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.Location = new System.Drawing.Point(15, 79);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(120, 186);
            this.playerListBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Players";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Game Name";
            // 
            // gameNameText
            // 
            this.gameNameText.Location = new System.Drawing.Point(15, 40);
            this.gameNameText.Name = "gameNameText";
            this.gameNameText.Size = new System.Drawing.Size(120, 20);
            this.gameNameText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "NPCs";
            // 
            // npcListBox
            // 
            this.npcListBox.FormattingEnabled = true;
            this.npcListBox.Location = new System.Drawing.Point(144, 79);
            this.npcListBox.Name = "npcListBox";
            this.npcListBox.Size = new System.Drawing.Size(120, 186);
            this.npcListBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enemies";
            // 
            // enemyListBox
            // 
            this.enemyListBox.FormattingEnabled = true;
            this.enemyListBox.Location = new System.Drawing.Point(273, 79);
            this.enemyListBox.Name = "enemyListBox";
            this.enemyListBox.Size = new System.Drawing.Size(120, 186);
            this.enemyListBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dungeon Size";
            // 
            // dungeonSizeText
            // 
            this.dungeonSizeText.AutoSize = true;
            this.dungeonSizeText.Location = new System.Drawing.Point(96, 272);
            this.dungeonSizeText.Name = "dungeonSizeText";
            this.dungeonSizeText.Size = new System.Drawing.Size(47, 13);
            this.dungeonSizeText.TabIndex = 10;
            this.dungeonSizeText.Text = "0 x 0 x 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Dungeon Position";
            // 
            // dungeonPositionText
            // 
            this.dungeonPositionText.AutoSize = true;
            this.dungeonPositionText.Location = new System.Drawing.Point(112, 289);
            this.dungeonPositionText.Name = "dungeonPositionText";
            this.dungeonPositionText.Size = new System.Drawing.Size(31, 13);
            this.dungeonPositionText.TabIndex = 12;
            this.dungeonPositionText.Text = "(0, 0)";
            // 
            // newGameWarningTextLabel
            // 
            this.newGameWarningTextLabel.AutoSize = true;
            this.newGameWarningTextLabel.Location = new System.Drawing.Point(141, 24);
            this.newGameWarningTextLabel.Name = "newGameWarningTextLabel";
            this.newGameWarningTextLabel.Size = new System.Drawing.Size(183, 13);
            this.newGameWarningTextLabel.TabIndex = 13;
            this.newGameWarningTextLabel.Text = "Select File>New to start a new game!";
            // 
            // MainHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 321);
            this.Controls.Add(this.newGameWarningTextLabel);
            this.Controls.Add(this.dungeonPositionText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dungeonSizeText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.enemyListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.npcListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gameNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainHost";
            this.Text = "Overview";
            this.Load += new System.EventHandler(this.CheckEnablebility);
            this.Shown += new System.EventHandler(this.CheckEnablebility);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainHost_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nPCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enemyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dungeonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wholeThingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dungeonToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem layoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog GameFolderBrowserDialog;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nPCsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enemiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dungeonToolStripMenuItem2;
        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gameNameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox npcListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox enemyListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dungeonSizeText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label dungeonPositionText;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem3;
        private System.Windows.Forms.Label newGameWarningTextLabel;
    }
}

