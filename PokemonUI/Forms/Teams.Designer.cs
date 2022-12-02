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
            this.panel1 = new System.Windows.Forms.Panel();
            this.newTeamButton = new System.Windows.Forms.Button();
            this.teamsImages = new System.Windows.Forms.ImageList(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.teamsListPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamsListPanel
            // 
            this.teamsListPanel.BackColor = System.Drawing.Color.Transparent;
            this.teamsListPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamsListPanel.Controls.Add(this.panel1);
            this.teamsListPanel.Controls.Add(this.newTeamButton);
            this.teamsListPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.teamsListPanel.Location = new System.Drawing.Point(0, 0);
            this.teamsListPanel.Name = "teamsListPanel";
            this.teamsListPanel.Size = new System.Drawing.Size(120, 843);
            this.teamsListPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(10, 0);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 763);
            this.panel1.TabIndex = 2;
            // 
            // newTeamButton
            // 
            this.newTeamButton.BackColor = System.Drawing.Color.Transparent;
            this.newTeamButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.newTeamButton.FlatAppearance.BorderSize = 0;
            this.newTeamButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.newTeamButton.ImageKey = "icons8-add-new-100.png";
            this.newTeamButton.ImageList = this.teamsImages;
            this.newTeamButton.Location = new System.Drawing.Point(0, 763);
            this.newTeamButton.Name = "newTeamButton";
            this.newTeamButton.Size = new System.Drawing.Size(118, 78);
            this.newTeamButton.TabIndex = 1;
            this.newTeamButton.UseVisualStyleBackColor = false;
            this.newTeamButton.Click += new System.EventHandler(this.newTeamButton_Click);
            // 
            // teamsImages
            // 
            this.teamsImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("teamsImages.ImageStream")));
            this.teamsImages.TransparentColor = System.Drawing.Color.Transparent;
            this.teamsImages.Images.SetKeyName(0, "icons8-add-new-100.png");
            this.teamsImages.Images.SetKeyName(1, "closed_pokeball.png");
            this.teamsImages.Images.SetKeyName(2, "open_pokeball.png");
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.ImageKey = "closed_pokeball.png";
            this.button7.ImageList = this.teamsImages;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.MinimumSize = new System.Drawing.Size(100, 100);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 100);
            this.button7.TabIndex = 11;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // Teams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 843);
            this.Controls.Add(this.teamsListPanel);
            this.Name = "Teams";
            this.Text = "Teams";
            this.Load += new System.EventHandler(this.Teams_Load);
            this.teamsListPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel teamsListPanel;
        private System.Windows.Forms.Button newTeamButton;
        private System.Windows.Forms.ImageList teamsImages;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
    }
}