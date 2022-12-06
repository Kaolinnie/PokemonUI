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
            this.components = new System.ComponentModel.Container();
            this.pokemonListView = new System.Windows.Forms.ListView();
            this.pokemonImageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // pokemonListView
            // 
            this.pokemonListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pokemonListView.HideSelection = false;
            this.pokemonListView.LargeImageList = this.pokemonImageList;
            this.pokemonListView.Location = new System.Drawing.Point(0, 0);
            this.pokemonListView.Name = "pokemonListView";
            this.pokemonListView.Size = new System.Drawing.Size(1067, 554);
            this.pokemonListView.TabIndex = 0;
            this.pokemonListView.UseCompatibleStateImageBehavior = false;
            // 
            // pokemonImageList
            // 
            this.pokemonImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.pokemonImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.pokemonImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Pokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pokemonListView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pokemon";
            this.Text = "Pokemon";
            this.Load += new System.EventHandler(this.Pokemon_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView pokemonListView;
        private System.Windows.Forms.ImageList pokemonImageList;
    }
}