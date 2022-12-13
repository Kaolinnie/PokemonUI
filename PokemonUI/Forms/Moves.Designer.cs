namespace PokemonUI.Forms
{
    partial class Moves
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Moves));
            this.moveListView = new System.Windows.Forms.ListView();
            this.types = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // moveListView
            // 
            this.moveListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moveListView.HideSelection = false;
            this.moveListView.LargeImageList = this.types;
            this.moveListView.Location = new System.Drawing.Point(0, 0);
            this.moveListView.Name = "moveListView";
            this.moveListView.Size = new System.Drawing.Size(800, 450);
            this.moveListView.SmallImageList = this.types;
            this.moveListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.moveListView.TabIndex = 0;
            this.moveListView.UseCompatibleStateImageBehavior = false;
            this.moveListView.View = System.Windows.Forms.View.List;
            // 
            // types
            // 
            this.types.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("types.ImageStream")));
            this.types.TransparentColor = System.Drawing.Color.Transparent;
            this.types.Images.SetKeyName(0, "normal.gif");
            this.types.Images.SetKeyName(1, "fighting.gif");
            this.types.Images.SetKeyName(2, "flying.gif");
            this.types.Images.SetKeyName(3, "poison.gif");
            this.types.Images.SetKeyName(4, "ground.gif");
            this.types.Images.SetKeyName(5, "rock.gif");
            this.types.Images.SetKeyName(6, "bug.gif");
            this.types.Images.SetKeyName(7, "ghost.gif");
            this.types.Images.SetKeyName(8, "steel.gif");
            this.types.Images.SetKeyName(9, "fire.gif");
            this.types.Images.SetKeyName(10, "water.gif");
            this.types.Images.SetKeyName(11, "grass.gif");
            this.types.Images.SetKeyName(12, "electric.gif");
            this.types.Images.SetKeyName(13, "psychic.gif");
            this.types.Images.SetKeyName(14, "ice.gif");
            this.types.Images.SetKeyName(15, "dragon.gif");
            this.types.Images.SetKeyName(16, "dark.gif");
            this.types.Images.SetKeyName(17, "fairy.gif");
            // 
            // Moves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.moveListView);
            this.Name = "Moves";
            this.Text = "Moves";
            this.Load += new System.EventHandler(this.Moves_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView moveListView;
        private System.Windows.Forms.ImageList types;
    }
}