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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuTitleLabel = new System.Windows.Forms.Label();
            this.desktopPanel = new System.Windows.Forms.Panel();
            this.types = new System.Windows.Forms.ImageList(this.components);
            this.menuPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.menuTitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            resources.ApplyResources(this.menuPanel, "menuPanel");
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.menuPanel.Controls.Add(this.buttonsPanel);
            this.menuPanel.Controls.Add(this.label1);
            this.menuPanel.Controls.Add(this.logoPanel);
            this.menuPanel.ForeColor = System.Drawing.Color.Gainsboro;
            this.menuPanel.Name = "menuPanel";
            // 
            // buttonsPanel
            // 
            resources.ApplyResources(this.buttonsPanel, "buttonsPanel");
            this.buttonsPanel.Controls.Add(this.settingsButton);
            this.buttonsPanel.Controls.Add(this.pokemonButton);
            this.buttonsPanel.Controls.Add(this.itemsButton);
            this.buttonsPanel.Controls.Add(this.movesButton);
            this.buttonsPanel.Controls.Add(this.teamsButton);
            this.buttonsPanel.Name = "buttonsPanel";
            // 
            // settingsButton
            // 
            resources.ApplyResources(this.settingsButton, "settingsButton");
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.ImageList = this.icons;
            this.settingsButton.Name = "settingsButton";
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
            resources.ApplyResources(this.pokemonButton, "pokemonButton");
            this.pokemonButton.FlatAppearance.BorderSize = 0;
            this.pokemonButton.ImageList = this.icons;
            this.pokemonButton.Name = "pokemonButton";
            this.pokemonButton.UseVisualStyleBackColor = true;
            this.pokemonButton.Click += new System.EventHandler(this.pokemonButton_Click);
            // 
            // itemsButton
            // 
            resources.ApplyResources(this.itemsButton, "itemsButton");
            this.itemsButton.FlatAppearance.BorderSize = 0;
            this.itemsButton.ImageList = this.icons;
            this.itemsButton.Name = "itemsButton";
            this.itemsButton.UseVisualStyleBackColor = true;
            this.itemsButton.Click += new System.EventHandler(this.itemsButton_Click);
            // 
            // movesButton
            // 
            resources.ApplyResources(this.movesButton, "movesButton");
            this.movesButton.FlatAppearance.BorderSize = 0;
            this.movesButton.ImageList = this.icons;
            this.movesButton.Name = "movesButton";
            this.movesButton.UseVisualStyleBackColor = true;
            this.movesButton.Click += new System.EventHandler(this.movesButton_Click);
            // 
            // teamsButton
            // 
            resources.ApplyResources(this.teamsButton, "teamsButton");
            this.teamsButton.FlatAppearance.BorderSize = 0;
            this.teamsButton.ImageList = this.icons;
            this.teamsButton.Name = "teamsButton";
            this.teamsButton.UseVisualStyleBackColor = true;
            this.teamsButton.Click += new System.EventHandler(this.teamsButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // logoPanel
            // 
            resources.ApplyResources(this.logoPanel, "logoPanel");
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.logoPanel.Controls.Add(this.appTitleLabel);
            this.logoPanel.Name = "logoPanel";
            // 
            // appTitleLabel
            // 
            resources.ApplyResources(this.appTitleLabel, "appTitleLabel");
            this.appTitleLabel.Name = "appTitleLabel";
            // 
            // menuTitlePanel
            // 
            resources.ApplyResources(this.menuTitlePanel, "menuTitlePanel");
            this.menuTitlePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuTitlePanel.Controls.Add(this.label2);
            this.menuTitlePanel.Controls.Add(this.comboBox1);
            this.menuTitlePanel.Controls.Add(this.menuTitleLabel);
            this.menuTitlePanel.Name = "menuTitlePanel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuTitleLabel
            // 
            resources.ApplyResources(this.menuTitleLabel, "menuTitleLabel");
            this.menuTitleLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.menuTitleLabel.Name = "menuTitleLabel";
            // 
            // desktopPanel
            // 
            resources.ApplyResources(this.desktopPanel, "desktopPanel");
            this.desktopPanel.Name = "desktopPanel";
            // 
            // types
            // 
            this.types.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.types, "types");
            this.types.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PokemonUIForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.desktopPanel);
            this.Controls.Add(this.menuTitlePanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "PokemonUIForm";
            this.Load += new System.EventHandler(this.PokemonUIForm_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.buttonsPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.menuTitlePanel.ResumeLayout(false);
            this.menuTitlePanel.PerformLayout();
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
        private System.Windows.Forms.ImageList types;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}

