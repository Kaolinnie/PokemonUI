namespace PokemonUI.Forms
{
    partial class Pokemon
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
            this.pokemonList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // pokemonList
            // 
            this.pokemonList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pokemonList.FormattingEnabled = true;
            this.pokemonList.ItemHeight = 25;
            this.pokemonList.Location = new System.Drawing.Point(0, 0);
            this.pokemonList.Name = "pokemonList";
            this.pokemonList.Size = new System.Drawing.Size(765, 865);
            this.pokemonList.TabIndex = 0;
            this.pokemonList.SelectedIndexChanged += new System.EventHandler(this.pokemonList_SelectedIndexChanged);
            // 
            // Pokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.pokemonList);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Pokemon";
            this.Text = "Pokemon";
            this.Load += new System.EventHandler(this.Pokemon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox pokemonList;
    }
}