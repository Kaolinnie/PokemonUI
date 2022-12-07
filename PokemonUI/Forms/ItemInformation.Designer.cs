namespace PokemonUI.Forms
{
    partial class ItemInformation
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
            this.button1 = new System.Windows.Forms.Button();
            this.itemImage = new System.Windows.Forms.PictureBox();
            this.itemLabel = new System.Windows.Forms.Label();
            this.itemIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(337, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // itemImage
            // 
            this.itemImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.itemImage.Location = new System.Drawing.Point(12, 12);
            this.itemImage.Name = "itemImage";
            this.itemImage.Size = new System.Drawing.Size(300, 300);
            this.itemImage.TabIndex = 1;
            this.itemImage.TabStop = false;
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLabel.Location = new System.Drawing.Point(328, 54);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(210, 51);
            this.itemLabel.TabIndex = 2;
            this.itemLabel.Text = "itemLabel";
            // 
            // itemIdLabel
            // 
            this.itemIdLabel.AutoSize = true;
            this.itemIdLabel.Location = new System.Drawing.Point(332, 12);
            this.itemIdLabel.Name = "itemIdLabel";
            this.itemIdLabel.Size = new System.Drawing.Size(29, 25);
            this.itemIdLabel.TabIndex = 3;
            this.itemIdLabel.Text = "id";
            // 
            // ItemInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 344);
            this.Controls.Add(this.itemIdLabel);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.itemImage);
            this.Controls.Add(this.button1);
            this.Name = "ItemInformation";
            this.Text = "ItemInformation";
            this.Load += new System.EventHandler(this.ItemInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox itemImage;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Label itemIdLabel;
    }
}