namespace RPG
{
    partial class Frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.Lbl_GameTitle = new System.Windows.Forms.Label();
            this.Btn_CreateChar = new System.Windows.Forms.Button();
            this.Btn_LoadGame = new System.Windows.Forms.Button();
            this.Btn_Credits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_GameTitle
            // 
            this.Lbl_GameTitle.AutoSize = true;
            this.Lbl_GameTitle.Location = new System.Drawing.Point(6, 9);
            this.Lbl_GameTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Lbl_GameTitle.Name = "Lbl_GameTitle";
            this.Lbl_GameTitle.Size = new System.Drawing.Size(355, 33);
            this.Lbl_GameTitle.TabIndex = 0;
            this.Lbl_GameTitle.Text = "Dungeon Fighter v1.0";
            // 
            // Btn_CreateChar
            // 
            this.Btn_CreateChar.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CreateChar.Location = new System.Drawing.Point(12, 140);
            this.Btn_CreateChar.Name = "Btn_CreateChar";
            this.Btn_CreateChar.Size = new System.Drawing.Size(201, 42);
            this.Btn_CreateChar.TabIndex = 1;
            this.Btn_CreateChar.Text = "New Game";
            this.Btn_CreateChar.UseVisualStyleBackColor = true;
            this.Btn_CreateChar.Click += new System.EventHandler(this.Btn_CreateChar_Click);
            // 
            // Btn_LoadGame
            // 
            this.Btn_LoadGame.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LoadGame.Location = new System.Drawing.Point(219, 140);
            this.Btn_LoadGame.Name = "Btn_LoadGame";
            this.Btn_LoadGame.Size = new System.Drawing.Size(201, 42);
            this.Btn_LoadGame.TabIndex = 2;
            this.Btn_LoadGame.Text = "Load Game";
            this.Btn_LoadGame.UseVisualStyleBackColor = true;
            this.Btn_LoadGame.Click += new System.EventHandler(this.Btn_LoadGame_Click);
            // 
            // Btn_Credits
            // 
            this.Btn_Credits.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Credits.Location = new System.Drawing.Point(683, 9);
            this.Btn_Credits.Name = "Btn_Credits";
            this.Btn_Credits.Size = new System.Drawing.Size(201, 42);
            this.Btn_Credits.TabIndex = 5;
            this.Btn_Credits.Text = "Credits";
            this.Btn_Credits.UseVisualStyleBackColor = true;
            this.Btn_Credits.Click += new System.EventHandler(this.Btn_Credits_Click);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(896, 543);
            this.Controls.Add(this.Btn_Credits);
            this.Controls.Add(this.Btn_LoadGame);
            this.Controls.Add(this.Btn_CreateChar);
            this.Controls.Add(this.Lbl_GameTitle);
            this.Font = new System.Drawing.Font("MS Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_Menu";
            this.Text = "RPG Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_GameTitle;
        private System.Windows.Forms.Button Btn_CreateChar;
        private System.Windows.Forms.Button Btn_LoadGame;
        private System.Windows.Forms.Button Btn_Credits;
    }
}

