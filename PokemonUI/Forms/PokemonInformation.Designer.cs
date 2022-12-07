namespace PokemonUI.Forms
{
    partial class PokemonInformation
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
            this.pokemonIdLabel = new System.Windows.Forms.Label();
            this.pokemonNameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pokemonImage = new System.Windows.Forms.PictureBox();
            this.type1 = new System.Windows.Forms.Label();
            this.type2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pokemonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pokemonIdLabel
            // 
            this.pokemonIdLabel.AutoSize = true;
            this.pokemonIdLabel.Location = new System.Drawing.Point(318, 12);
            this.pokemonIdLabel.Name = "pokemonIdLabel";
            this.pokemonIdLabel.Size = new System.Drawing.Size(29, 25);
            this.pokemonIdLabel.TabIndex = 1;
            this.pokemonIdLabel.Text = "id";
            this.pokemonIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pokemonNameLabel
            // 
            this.pokemonNameLabel.AutoSize = true;
            this.pokemonNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokemonNameLabel.Location = new System.Drawing.Point(318, 47);
            this.pokemonNameLabel.Name = "pokemonNameLabel";
            this.pokemonNameLabel.Size = new System.Drawing.Size(130, 51);
            this.pokemonNameLabel.TabIndex = 2;
            this.pokemonNameLabel.Text = "name";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(327, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 46);
            this.button1.TabIndex = 5;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pokemonImage
            // 
            this.pokemonImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pokemonImage.Location = new System.Drawing.Point(12, 12);
            this.pokemonImage.Name = "pokemonImage";
            this.pokemonImage.Size = new System.Drawing.Size(300, 300);
            this.pokemonImage.TabIndex = 0;
            this.pokemonImage.TabStop = false;
            // 
            // type1
            // 
            this.type1.AutoSize = true;
            this.type1.Location = new System.Drawing.Point(322, 143);
            this.type1.Name = "type1";
            this.type1.Size = new System.Drawing.Size(0, 25);
            this.type1.TabIndex = 6;
            // 
            // type2
            // 
            this.type2.AutoSize = true;
            this.type2.Location = new System.Drawing.Point(421, 143);
            this.type2.Name = "type2";
            this.type2.Size = new System.Drawing.Size(0, 25);
            this.type2.TabIndex = 7;
            // 
            // PokemonInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.type2);
            this.Controls.Add(this.type1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pokemonNameLabel);
            this.Controls.Add(this.pokemonIdLabel);
            this.Controls.Add(this.pokemonImage);
            this.Name = "PokemonInformation";
            this.Text = "PokemonInformation";
            this.Load += new System.EventHandler(this.PokemonInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pokemonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pokemonImage;
        private System.Windows.Forms.Label pokemonIdLabel;
        private System.Windows.Forms.Label pokemonNameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label type1;
        private System.Windows.Forms.Label type2;
    }
}