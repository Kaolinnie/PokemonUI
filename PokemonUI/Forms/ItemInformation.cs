using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamDexLibrary;

namespace PokemonUI.Forms
{
    public partial class ItemInformation : Form
    {
        private Image img;
        private Item item;
        public ItemInformation(Item item,Image img)
        {
            InitializeComponent();
            this.item = item;
            this.img = img;
        }

        private void ItemInformation_Load(object sender, EventArgs e)
        {
            itemImage.Image = img;
            itemLabel.Text = item.Name;
            itemIdLabel.Text = item.Id.ToString();
        }
    }
}
