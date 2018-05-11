namespace RPG_Manager
{
    partial class CharacterCreator
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.acNumeric = new System.Windows.Forms.NumericUpDown();
            this.hpNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.characterRaceText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.characterNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.acNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(178, 105);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 23;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(259, 105);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(75, 23);
            this.acceptBtn.TabIndex = 22;
            this.acceptBtn.Text = "Accept";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // acNumeric
            // 
            this.acNumeric.Location = new System.Drawing.Point(214, 51);
            this.acNumeric.Name = "acNumeric";
            this.acNumeric.Size = new System.Drawing.Size(120, 20);
            this.acNumeric.TabIndex = 21;
            this.acNumeric.ValueChanged += new System.EventHandler(this.acNumeric_ValueChanged);
            // 
            // hpNumeric
            // 
            this.hpNumeric.Location = new System.Drawing.Point(214, 25);
            this.hpNumeric.Name = "hpNumeric";
            this.hpNumeric.Size = new System.Drawing.Size(120, 20);
            this.hpNumeric.TabIndex = 20;
            this.hpNumeric.ValueChanged += new System.EventHandler(this.hpNumeric_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Character AC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Character HP";
            // 
            // characterRaceText
            // 
            this.characterRaceText.Location = new System.Drawing.Point(12, 66);
            this.characterRaceText.Name = "characterRaceText";
            this.characterRaceText.Size = new System.Drawing.Size(118, 20);
            this.characterRaceText.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Character Race";
            // 
            // characterNameText
            // 
            this.characterNameText.Location = new System.Drawing.Point(12, 27);
            this.characterNameText.Name = "characterNameText";
            this.characterNameText.Size = new System.Drawing.Size(118, 20);
            this.characterNameText.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Character Name";
            // 
            // CharacterCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 135);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.acNumeric);
            this.Controls.Add(this.hpNumeric);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.characterRaceText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.characterNameText);
            this.Controls.Add(this.label2);
            this.Name = "CharacterCreator";
            this.Text = "CharacterCreator";
            ((System.ComponentModel.ISupportInitialize)(this.acNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hpNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.NumericUpDown acNumeric;
        private System.Windows.Forms.NumericUpDown hpNumeric;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox characterRaceText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox characterNameText;
        private System.Windows.Forms.Label label2;
    }
}