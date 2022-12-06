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
            this.pokemonListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // pokemonListBox
            // 
            this.pokemonListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pokemonListBox.FormattingEnabled = true;
            this.pokemonListBox.Location = new System.Drawing.Point(0, 0);
            this.pokemonListBox.Name = "pokemonListBox";
            this.pokemonListBox.Size = new System.Drawing.Size(800, 450);
            this.pokemonListBox.TabIndex = 0;
            // 
            // Pokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pokemonListBox);
            this.Name = "Pokemon";
            this.Text = "Pokemon";
            this.Load += new System.EventHandler(this.Pokemon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox pokemonListBox;
    }
}