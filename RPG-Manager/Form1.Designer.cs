namespace RPG_Manager
{
    partial class Form1
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
            this.GameFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nPCsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enemiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.managementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            this.addToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            // 
            // dungeonToolStripMenuItem
            // 
            this.dungeonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentRoomToolStripMenuItem,
            this.wholeThingToolStripMenuItem});
            this.dungeonToolStripMenuItem.Name = "dungeonToolStripMenuItem";
            this.dungeonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dungeonToolStripMenuItem.Text = "Dungeon";
            // 
            // currentRoomToolStripMenuItem
            // 
            this.currentRoomToolStripMenuItem.Name = "currentRoomToolStripMenuItem";
            this.currentRoomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.currentRoomToolStripMenuItem.Text = "Current Room";
            // 
            // wholeThingToolStripMenuItem
            // 
            this.wholeThingToolStripMenuItem.Name = "wholeThingToolStripMenuItem";
            this.wholeThingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wholeThingToolStripMenuItem.Text = "Whole thing...";
            // 
            // dungeonToolStripMenuItem1
            // 
            this.dungeonToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.layoutToolStripMenuItem});
            this.dungeonToolStripMenuItem1.Name = "dungeonToolStripMenuItem1";
            this.dungeonToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.dungeonToolStripMenuItem1.Text = "Dungeon";
            // 
            // layoutToolStripMenuItem
            // 
            this.layoutToolStripMenuItem.Name = "layoutToolStripMenuItem";
            this.layoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.layoutToolStripMenuItem.Text = "Layout";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.playersToolStripMenuItem.Name = "playersToolStripMenuItem";
            this.playersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.playersToolStripMenuItem.Text = "Players";
            // 
            // nPCsToolStripMenuItem
            // 
            this.nPCsToolStripMenuItem.Name = "nPCsToolStripMenuItem";
            this.nPCsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nPCsToolStripMenuItem.Text = "NPCs";
            // 
            // enemiesToolStripMenuItem
            // 
            this.enemiesToolStripMenuItem.Name = "enemiesToolStripMenuItem";
            this.enemiesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enemiesToolStripMenuItem.Text = "Enemies";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

