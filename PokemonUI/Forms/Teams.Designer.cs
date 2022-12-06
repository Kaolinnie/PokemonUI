namespace PokemonUI.Forms
{
    partial class Teams
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teams));
            this.teamsListPanel = new System.Windows.Forms.Panel();
            this.teamSelectButton = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.teamsImages = new System.Windows.Forms.ImageList(this.components);
            this.newTeamButton = new System.Windows.Forms.Button();
            this.teamMembersPanel = new System.Windows.Forms.Panel();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.itemLabel = new System.Windows.Forms.Label();
            this.abilityLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pokemonPicture = new System.Windows.Forms.PictureBox();
            this.movesListView = new System.Windows.Forms.ListView();
            this.tmpBox = new System.Windows.Forms.ListBox();
            this.teamsListPanel.SuspendLayout();
            this.teamSelectButton.SuspendLayout();
            this.teamMembersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // teamsListPanel
            // 
            this.teamsListPanel.BackColor = System.Drawing.Color.Transparent;
            this.teamsListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamsListPanel.Controls.Add(this.teamSelectButton);
            this.teamsListPanel.Controls.Add(this.newTeamButton);
            this.teamsListPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.teamsListPanel.Location = new System.Drawing.Point(0, 0);
            this.teamsListPanel.Margin = new System.Windows.Forms.Padding(2);
            this.teamsListPanel.Name = "teamsListPanel";
            this.teamsListPanel.Size = new System.Drawing.Size(61, 438);
            this.teamsListPanel.TabIndex = 0;
            // 
            // teamSelectButton
            // 
            this.teamSelectButton.AutoScroll = true;
            this.teamSelectButton.AutoScrollMinSize = new System.Drawing.Size(10, 0);
            this.teamSelectButton.Controls.Add(this.button7);
            this.teamSelectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamSelectButton.Location = new System.Drawing.Point(0, 0);
            this.teamSelectButton.Margin = new System.Windows.Forms.Padding(2);
            this.teamSelectButton.Name = "teamSelectButton";
            this.teamSelectButton.Size = new System.Drawing.Size(59, 395);
            this.teamSelectButton.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.ImageKey = "closed_pokeball.png";
            this.button7.ImageList = this.teamsImages;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.MinimumSize = new System.Drawing.Size(50, 52);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(59, 56);
            this.button7.TabIndex = 11;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // teamsImages
            // 
            this.teamsImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("teamsImages.ImageStream")));
            this.teamsImages.TransparentColor = System.Drawing.Color.Transparent;
            this.teamsImages.Images.SetKeyName(0, "icons8-add-new-100.png");
            this.teamsImages.Images.SetKeyName(1, "closed_pokeball.png");
            this.teamsImages.Images.SetKeyName(2, "open_pokeball.png");
            // 
            // newTeamButton
            // 
            this.newTeamButton.BackColor = System.Drawing.Color.Transparent;
            this.newTeamButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.newTeamButton.FlatAppearance.BorderSize = 0;
            this.newTeamButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newTeamButton.ImageKey = "icons8-add-new-100.png";
            this.newTeamButton.ImageList = this.teamsImages;
            this.newTeamButton.Location = new System.Drawing.Point(0, 395);
            this.newTeamButton.Margin = new System.Windows.Forms.Padding(2);
            this.newTeamButton.Name = "newTeamButton";
            this.newTeamButton.Size = new System.Drawing.Size(59, 41);
            this.newTeamButton.TabIndex = 1;
            this.newTeamButton.UseVisualStyleBackColor = false;
            this.newTeamButton.Click += new System.EventHandler(this.newTeamButton_Click);
            // 
            // teamMembersPanel
            // 
            this.teamMembersPanel.Controls.Add(this.tmpBox);
            this.teamMembersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamMembersPanel.Location = new System.Drawing.Point(61, 0);
            this.teamMembersPanel.Name = "teamMembersPanel";
            this.teamMembersPanel.Size = new System.Drawing.Size(639, 438);
            this.teamMembersPanel.TabIndex = 1;
            // 
            // detailsPanel
            // 
            this.detailsPanel.Location = new System.Drawing.Point(0, 0);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(200, 100);
            this.detailsPanel.TabIndex = 0;
            // 
            // itemLabel
            // 
            this.itemLabel.Location = new System.Drawing.Point(0, 0);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(100, 23);
            this.itemLabel.TabIndex = 0;
            // 
            // abilityLabel
            // 
            this.abilityLabel.Location = new System.Drawing.Point(0, 0);
            this.abilityLabel.Name = "abilityLabel";
            this.abilityLabel.Size = new System.Drawing.Size(100, 23);
            this.abilityLabel.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(100, 23);
            this.nameLabel.TabIndex = 0;
            // 
            // pokemonPicture
            // 
            this.pokemonPicture.Location = new System.Drawing.Point(0, 0);
            this.pokemonPicture.Name = "pokemonPicture";
            this.pokemonPicture.Size = new System.Drawing.Size(100, 50);
            this.pokemonPicture.TabIndex = 0;
            this.pokemonPicture.TabStop = false;
            // 
            // movesListView
            // 
            this.movesListView.HideSelection = false;
            this.movesListView.Location = new System.Drawing.Point(0, 0);
            this.movesListView.Name = "movesListView";
            this.movesListView.Size = new System.Drawing.Size(121, 97);
            this.movesListView.TabIndex = 0;
            this.movesListView.UseCompatibleStateImageBehavior = false;
            // 
            // tmpBox
            // 
            this.tmpBox.FormattingEnabled = true;
            this.tmpBox.Location = new System.Drawing.Point(0, 0);
            this.tmpBox.Name = "tmpBox";
            this.tmpBox.Size = new System.Drawing.Size(322, 212);
            this.tmpBox.TabIndex = 0;
            // 
            // Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 438);
            this.Controls.Add(this.teamMembersPanel);
            this.Controls.Add(this.teamsListPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Teams";
            this.Text = "Teams";
            this.Load += new System.EventHandler(this.Teams_Load);
            this.teamsListPanel.ResumeLayout(false);
            this.teamSelectButton.ResumeLayout(false);
            this.teamSelectButton.PerformLayout();
            this.teamMembersPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pokemonPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pokemonPicture;
        private System.Windows.Forms.Panel detailsPanel;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Label abilityLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel teamsListPanel;
        private System.Windows.Forms.Button newTeamButton;
        private System.Windows.Forms.ImageList teamsImages;
        private System.Windows.Forms.Panel teamSelectButton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel teamMembersPanel;
        private System.Windows.Forms.ListView movesListView;
        private System.Windows.Forms.ListBox tmpBox;
    }
}