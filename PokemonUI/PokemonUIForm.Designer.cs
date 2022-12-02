namespace PokemonUI
{
    partial class PokemonUIForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokemonUIForm));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.pokemonButton = new System.Windows.Forms.Button();
            this.itemsButton = new System.Windows.Forms.Button();
            this.movesButton = new System.Windows.Forms.Button();
            this.teamsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.appTitleLabel = new System.Windows.Forms.Label();
            this.menuTitlePanel = new System.Windows.Forms.Panel();
            this.menuTitleLabel = new System.Windows.Forms.Label();
            this.desktopPanel = new System.Windows.Forms.Panel();
            this.menuPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.menuTitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.menuPanel.Controls.Add(this.buttonsPanel);
            this.menuPanel.Controls.Add(this.label1);
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPanel.ForeColor = System.Drawing.Color.Gainsboro;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(335, 779);
            this.menuPanel.TabIndex = 0;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.AutoSize = true;
            this.buttonsPanel.Controls.Add(this.settingsButton);
            this.buttonsPanel.Controls.Add(this.pokemonButton);
            this.buttonsPanel.Controls.Add(this.itemsButton);
            this.buttonsPanel.Controls.Add(this.movesButton);
            this.buttonsPanel.Controls.Add(this.teamsButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonsPanel.Location = new System.Drawing.Point(0, 125);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(335, 600);
            this.buttonsPanel.TabIndex = 7;
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.ImageKey = "icons8-gear-pok-96.png";
            this.settingsButton.ImageList = this.icons;
            this.settingsButton.Location = new System.Drawing.Point(0, 480);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.settingsButton.Size = new System.Drawing.Size(335, 120);
            this.settingsButton.TabIndex = 4;
            this.settingsButton.Text = " Settings";
            this.settingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // icons
            // 
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "icons8-sword-80.png");
            this.icons.Images.SetKeyName(1, "icons8-sword-64.png");
            this.icons.Images.SetKeyName(2, "icons8-gear-pok-96.png");
            this.icons.Images.SetKeyName(3, "icons8-fight-pokemon-96.png");
            this.icons.Images.SetKeyName(4, "1337524_game_go_moltres_play_pokemon_icon.png");
            this.icons.Images.SetKeyName(5, "icons8-pokedex-96.png");
            this.icons.Images.SetKeyName(6, "icons8-pokebag-96.png");
            // 
            // pokemonButton
            // 
            this.pokemonButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pokemonButton.FlatAppearance.BorderSize = 0;
            this.pokemonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pokemonButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokemonButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pokemonButton.ImageIndex = 5;
            this.pokemonButton.ImageList = this.icons;
            this.pokemonButton.Location = new System.Drawing.Point(0, 360);
            this.pokemonButton.Name = "pokemonButton";
            this.pokemonButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pokemonButton.Size = new System.Drawing.Size(335, 120);
            this.pokemonButton.TabIndex = 3;
            this.pokemonButton.Text = " Pokemon";
            this.pokemonButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pokemonButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pokemonButton.UseVisualStyleBackColor = true;
            this.pokemonButton.Click += new System.EventHandler(this.pokemonButton_Click);
            // 
            // itemsButton
            // 
            this.itemsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemsButton.FlatAppearance.BorderSize = 0;
            this.itemsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemsButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemsButton.ImageIndex = 6;
            this.itemsButton.ImageList = this.icons;
            this.itemsButton.Location = new System.Drawing.Point(0, 240);
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.itemsButton.Size = new System.Drawing.Size(335, 120);
            this.itemsButton.TabIndex = 2;
            this.itemsButton.Text = " Items";
            this.itemsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.itemsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.itemsButton.UseVisualStyleBackColor = true;
            this.itemsButton.Click += new System.EventHandler(this.itemsButton_Click);
            // 
            // movesButton
            // 
            this.movesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.movesButton.FlatAppearance.BorderSize = 0;
            this.movesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movesButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.movesButton.ImageIndex = 1;
            this.movesButton.ImageList = this.icons;
            this.movesButton.Location = new System.Drawing.Point(0, 120);
            this.movesButton.Name = "movesButton";
            this.movesButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.movesButton.Size = new System.Drawing.Size(335, 120);
            this.movesButton.TabIndex = 1;
            this.movesButton.Text = " Moves";
            this.movesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.movesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.movesButton.UseVisualStyleBackColor = true;
            this.movesButton.Click += new System.EventHandler(this.movesButton_Click);
            // 
            // teamsButton
            // 
            this.teamsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.teamsButton.FlatAppearance.BorderSize = 0;
            this.teamsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teamsButton.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.teamsButton.ImageIndex = 3;
            this.teamsButton.ImageList = this.icons;
            this.teamsButton.Location = new System.Drawing.Point(0, 0);
            this.teamsButton.Name = "teamsButton";
            this.teamsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.teamsButton.Size = new System.Drawing.Size(335, 120);
            this.teamsButton.TabIndex = 0;
            this.teamsButton.Text = " Teams";
            this.teamsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.teamsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.teamsButton.UseVisualStyleBackColor = true;
            this.teamsButton.Click += new System.EventHandler(this.teamsButton_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 747);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "CC BY Kaolin | Eris";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.logoPanel.Controls.Add(this.appTitleLabel);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(335, 125);
            this.logoPanel.TabIndex = 0;
            // 
            // appTitleLabel
            // 
            this.appTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.appTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.appTitleLabel.Name = "appTitleLabel";
            this.appTitleLabel.Size = new System.Drawing.Size(335, 125);
            this.appTitleLabel.TabIndex = 0;
            this.appTitleLabel.Text = "Pokemon Team Builder";
            this.appTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuTitlePanel
            // 
            this.menuTitlePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuTitlePanel.Controls.Add(this.menuTitleLabel);
            this.menuTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuTitlePanel.Location = new System.Drawing.Point(335, 0);
            this.menuTitlePanel.Name = "menuTitlePanel";
            this.menuTitlePanel.Size = new System.Drawing.Size(1374, 125);
            this.menuTitlePanel.TabIndex = 1;
            // 
            // menuTitleLabel
            // 
            this.menuTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuTitleLabel.Font = new System.Drawing.Font("Arial", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuTitleLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.menuTitleLabel.Location = new System.Drawing.Point(0, 0);
            this.menuTitleLabel.Name = "menuTitleLabel";
            this.menuTitleLabel.Size = new System.Drawing.Size(1374, 125);
            this.menuTitleLabel.TabIndex = 0;
            this.menuTitleLabel.Text = "HOME";
            this.menuTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desktopPanel
            // 
            this.desktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktopPanel.Location = new System.Drawing.Point(335, 125);
            this.desktopPanel.Name = "desktopPanel";
            this.desktopPanel.Size = new System.Drawing.Size(1374, 654);
            this.desktopPanel.TabIndex = 8;
            // 
            // PokemonUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 779);
            this.Controls.Add(this.desktopPanel);
            this.Controls.Add(this.menuTitlePanel);
            this.Controls.Add(this.menuPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 850);
            this.Name = "PokemonUIForm";
            this.Text = "Pokemon Team Builder";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.menuTitlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button pokemonButton;
        private System.Windows.Forms.Button itemsButton;
        private System.Windows.Forms.Button movesButton;
        private System.Windows.Forms.Button teamsButton;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.Label appTitleLabel;
        private System.Windows.Forms.Panel menuTitlePanel;
        private System.Windows.Forms.Label menuTitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Panel desktopPanel;
    }
}

