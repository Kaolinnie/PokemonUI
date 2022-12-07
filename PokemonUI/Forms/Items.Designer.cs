namespace PokemonUI.Forms
{
    partial class Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Items));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.itemsList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "closed_pokeball.png");
            this.imageList1.Images.SetKeyName(1, "open_pokeball.png");
            this.imageList1.Images.SetKeyName(2, "icons8-add-new-100.png");
            this.imageList1.Images.SetKeyName(3, "icons8-pokebag-96.png");
            this.imageList1.Images.SetKeyName(4, "icons8-pokedex-96.png");
            // 
            // itemsList
            // 
            this.itemsList.Dock = System.Windows.Forms.DockStyle.Left;
            this.itemsList.FormattingEnabled = true;
            this.itemsList.ItemHeight = 25;
            this.itemsList.Location = new System.Drawing.Point(0, 0);
            this.itemsList.Name = "itemsList";
            this.itemsList.Size = new System.Drawing.Size(249, 887);
            this.itemsList.TabIndex = 0;
            this.itemsList.SelectedIndexChanged += new System.EventHandler(this.itemsList_SelectedIndexChanged);
            // 
            // Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 887);
            this.Controls.Add(this.itemsList);
            this.Name = "Items";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.Items_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox itemsList;
    }
}