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
            this.teamsImages = new System.Windows.Forms.ImageList(this.components);
            this.newTeamButton = new System.Windows.Forms.Button();
            this.teamMembersPanel = new System.Windows.Forms.Panel();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.itemLabel = new System.Windows.Forms.Label();
            this.abilityLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pokemonPicture = new System.Windows.Forms.PictureBox();
            this.movesListView = new System.Windows.Forms.ListView();
            this.teamName = new System.Windows.Forms.TextBox();
            this.teamDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.membersBox = new System.Windows.Forms.GroupBox();
            this.pokemonDetails = new System.Windows.Forms.Panel();
            this.pokemon1 = new System.Windows.Forms.PictureBox();
            this.pokemon2 = new System.Windows.Forms.PictureBox();
            this.pokemon3 = new System.Windows.Forms.PictureBox();
            this.pokemon6 = new System.Windows.Forms.PictureBox();
            this.pokemon5 = new System.Windows.Forms.PictureBox();
            this.pokemon4 = new System.Windows.Forms.PictureBox();
            this.pokemonNameLabel = new System.Windows.Forms.Label();
            this.type1 = new System.Windows.Forms.Label();
            this.type2 = new System.Windows.Forms.Label();
            this.pokemonImage = new System.Windows.Forms.PictureBox();
            this.move1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.heldItemImage = new System.Windows.Forms.PictureBox();
            this.heldItemLabel = new System.Windows.Forms.Label();
            this.teamsListPanel.SuspendLayout();
            this.teamMembersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonPicture)).BeginInit();
            this.membersBox.SuspendLayout();
            this.pokemonDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heldItemImage)).BeginInit();
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
            this.teamsListPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teamsListPanel.Name = "teamsListPanel";
            this.teamsListPanel.Size = new System.Drawing.Size(120, 829);
            this.teamsListPanel.TabIndex = 0;
            // 
            // teamSelectButton
            // 
            this.teamSelectButton.AutoScroll = true;
            this.teamSelectButton.AutoScrollMinSize = new System.Drawing.Size(10, 0);
            this.teamSelectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamSelectButton.Location = new System.Drawing.Point(0, 0);
            this.teamSelectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teamSelectButton.Name = "teamSelectButton";
            this.teamSelectButton.Size = new System.Drawing.Size(118, 748);
            this.teamSelectButton.TabIndex = 2;
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
            this.newTeamButton.Location = new System.Drawing.Point(0, 748);
            this.newTeamButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newTeamButton.Name = "newTeamButton";
            this.newTeamButton.Size = new System.Drawing.Size(118, 79);
            this.newTeamButton.TabIndex = 1;
            this.newTeamButton.UseVisualStyleBackColor = false;
            this.newTeamButton.Click += new System.EventHandler(this.newTeamButton_Click);
            // 
            // teamMembersPanel
            // 
            this.teamMembersPanel.Controls.Add(this.pokemonDetails);
            this.teamMembersPanel.Controls.Add(this.membersBox);
            this.teamMembersPanel.Controls.Add(this.label2);
            this.teamMembersPanel.Controls.Add(this.label1);
            this.teamMembersPanel.Controls.Add(this.teamDescription);
            this.teamMembersPanel.Controls.Add(this.teamName);
            this.teamMembersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamMembersPanel.Location = new System.Drawing.Point(120, 0);
            this.teamMembersPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.teamMembersPanel.Name = "teamMembersPanel";
            this.teamMembersPanel.Size = new System.Drawing.Size(1333, 829);
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
            // teamName
            // 
            this.teamName.Location = new System.Drawing.Point(143, 23);
            this.teamName.Name = "teamName";
            this.teamName.Size = new System.Drawing.Size(642, 31);
            this.teamName.TabIndex = 0;
            // 
            // teamDescription
            // 
            this.teamDescription.Location = new System.Drawing.Point(143, 60);
            this.teamDescription.Name = "teamDescription";
            this.teamDescription.Size = new System.Drawing.Size(642, 329);
            this.teamDescription.TabIndex = 1;
            this.teamDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // membersBox
            // 
            this.membersBox.Controls.Add(this.pokemon6);
            this.membersBox.Controls.Add(this.pokemon5);
            this.membersBox.Controls.Add(this.pokemon4);
            this.membersBox.Controls.Add(this.pokemon3);
            this.membersBox.Controls.Add(this.pokemon2);
            this.membersBox.Controls.Add(this.pokemon1);
            this.membersBox.Location = new System.Drawing.Point(22, 421);
            this.membersBox.Name = "membersBox";
            this.membersBox.Size = new System.Drawing.Size(763, 396);
            this.membersBox.TabIndex = 4;
            this.membersBox.TabStop = false;
            this.membersBox.Text = "Members";
            // 
            // pokemonDetails
            // 
            this.pokemonDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pokemonDetails.Controls.Add(this.heldItemLabel);
            this.pokemonDetails.Controls.Add(this.heldItemImage);
            this.pokemonDetails.Controls.Add(this.textBox3);
            this.pokemonDetails.Controls.Add(this.textBox2);
            this.pokemonDetails.Controls.Add(this.textBox1);
            this.pokemonDetails.Controls.Add(this.move1);
            this.pokemonDetails.Controls.Add(this.pokemonImage);
            this.pokemonDetails.Controls.Add(this.type2);
            this.pokemonDetails.Controls.Add(this.type1);
            this.pokemonDetails.Controls.Add(this.pokemonNameLabel);
            this.pokemonDetails.Location = new System.Drawing.Point(791, 23);
            this.pokemonDetails.Name = "pokemonDetails";
            this.pokemonDetails.Size = new System.Drawing.Size(519, 794);
            this.pokemonDetails.TabIndex = 2;
            // 
            // pokemon1
            // 
            this.pokemon1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pokemon1.Location = new System.Drawing.Point(15, 39);
            this.pokemon1.Name = "pokemon1";
            this.pokemon1.Size = new System.Drawing.Size(150, 150);
            this.pokemon1.TabIndex = 0;
            this.pokemon1.TabStop = false;
            this.pokemon1.Click += new System.EventHandler(this.pokemon1_Click);
            // 
            // pokemon2
            // 
            this.pokemon2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pokemon2.Location = new System.Drawing.Point(308, 39);
            this.pokemon2.Name = "pokemon2";
            this.pokemon2.Size = new System.Drawing.Size(150, 150);
            this.pokemon2.TabIndex = 1;
            this.pokemon2.TabStop = false;
            this.pokemon2.Click += new System.EventHandler(this.pokemon1_Click);
            // 
            // pokemon3
            // 
            this.pokemon3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pokemon3.Location = new System.Drawing.Point(597, 39);
            this.pokemon3.Name = "pokemon3";
            this.pokemon3.Size = new System.Drawing.Size(150, 150);
            this.pokemon3.TabIndex = 2;
            this.pokemon3.TabStop = false;
            this.pokemon3.Click += new System.EventHandler(this.pokemon1_Click);
            // 
            // pokemon6
            // 
            this.pokemon6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pokemon6.Location = new System.Drawing.Point(597, 223);
            this.pokemon6.Name = "pokemon6";
            this.pokemon6.Size = new System.Drawing.Size(150, 150);
            this.pokemon6.TabIndex = 5;
            this.pokemon6.TabStop = false;
            this.pokemon6.Click += new System.EventHandler(this.pokemon1_Click);
            // 
            // pokemon5
            // 
            this.pokemon5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pokemon5.Location = new System.Drawing.Point(308, 223);
            this.pokemon5.Name = "pokemon5";
            this.pokemon5.Size = new System.Drawing.Size(150, 150);
            this.pokemon5.TabIndex = 4;
            this.pokemon5.TabStop = false;
            this.pokemon5.Click += new System.EventHandler(this.pokemon1_Click);
            // 
            // pokemon4
            // 
            this.pokemon4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pokemon4.Location = new System.Drawing.Point(15, 223);
            this.pokemon4.Name = "pokemon4";
            this.pokemon4.Size = new System.Drawing.Size(150, 150);
            this.pokemon4.TabIndex = 3;
            this.pokemon4.TabStop = false;
            this.pokemon4.Click += new System.EventHandler(this.pokemon1_Click);
            // 
            // pokemonNameLabel
            // 
            this.pokemonNameLabel.AutoSize = true;
            this.pokemonNameLabel.Location = new System.Drawing.Point(12, 5);
            this.pokemonNameLabel.Name = "pokemonNameLabel";
            this.pokemonNameLabel.Size = new System.Drawing.Size(70, 25);
            this.pokemonNameLabel.TabIndex = 0;
            this.pokemonNameLabel.Text = "label3";
            // 
            // type1
            // 
            this.type1.AutoSize = true;
            this.type1.Location = new System.Drawing.Point(12, 49);
            this.type1.Name = "type1";
            this.type1.Size = new System.Drawing.Size(0, 25);
            this.type1.TabIndex = 1;
            // 
            // type2
            // 
            this.type2.AutoSize = true;
            this.type2.Location = new System.Drawing.Point(116, 49);
            this.type2.Name = "type2";
            this.type2.Size = new System.Drawing.Size(0, 25);
            this.type2.TabIndex = 2;
            // 
            // pokemonImage
            // 
            this.pokemonImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pokemonImage.Location = new System.Drawing.Point(364, 5);
            this.pokemonImage.Name = "pokemonImage";
            this.pokemonImage.Size = new System.Drawing.Size(150, 150);
            this.pokemonImage.TabIndex = 6;
            this.pokemonImage.TabStop = false;
            // 
            // move1
            // 
            this.move1.Location = new System.Drawing.Point(36, 555);
            this.move1.Name = "move1";
            this.move1.Size = new System.Drawing.Size(460, 31);
            this.move1.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 611);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(460, 31);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(36, 671);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(460, 31);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(36, 728);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(460, 31);
            this.textBox3.TabIndex = 10;
            // 
            // heldItemImage
            // 
            this.heldItemImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.heldItemImage.Location = new System.Drawing.Point(464, 174);
            this.heldItemImage.Name = "heldItemImage";
            this.heldItemImage.Size = new System.Drawing.Size(50, 50);
            this.heldItemImage.TabIndex = 11;
            this.heldItemImage.TabStop = false;
            // 
            // heldItemLabel
            // 
            this.heldItemLabel.AutoSize = true;
            this.heldItemLabel.Location = new System.Drawing.Point(359, 174);
            this.heldItemLabel.Name = "heldItemLabel";
            this.heldItemLabel.Size = new System.Drawing.Size(70, 25);
            this.heldItemLabel.TabIndex = 12;
            this.heldItemLabel.Text = "label3";
            // 
            // Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 829);
            this.Controls.Add(this.teamMembersPanel);
            this.Controls.Add(this.teamsListPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Teams";
            this.Text = "Teams";
            this.Load += new System.EventHandler(this.Teams_Load);
            this.teamsListPanel.ResumeLayout(false);
            this.teamMembersPanel.ResumeLayout(false);
            this.teamMembersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonPicture)).EndInit();
            this.membersBox.ResumeLayout(false);
            this.pokemonDetails.ResumeLayout(false);
            this.pokemonDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heldItemImage)).EndInit();
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
        private System.Windows.Forms.Panel teamMembersPanel;
        private System.Windows.Forms.ListView movesListView;
        private System.Windows.Forms.RichTextBox teamDescription;
        private System.Windows.Forms.TextBox teamName;
        private System.Windows.Forms.Panel pokemonDetails;
        private System.Windows.Forms.GroupBox membersBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pokemon1;
        private System.Windows.Forms.PictureBox pokemon6;
        private System.Windows.Forms.PictureBox pokemon5;
        private System.Windows.Forms.PictureBox pokemon4;
        private System.Windows.Forms.PictureBox pokemon3;
        private System.Windows.Forms.PictureBox pokemon2;
        private System.Windows.Forms.Label heldItemLabel;
        private System.Windows.Forms.PictureBox heldItemImage;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox move1;
        private System.Windows.Forms.PictureBox pokemonImage;
        private System.Windows.Forms.Label type2;
        private System.Windows.Forms.Label type1;
        private System.Windows.Forms.Label pokemonNameLabel;
    }
}