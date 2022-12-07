using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonUI.Forms
{
    public partial class Items : Form
    {
        public Items()
        {
            InitializeComponent();
            loadItemsListBox();
        }

        public void loadItemsListBox()
        {
            itemsListBox.Items.Add("Ability Urge");
            itemsListBox.Items.Add("Academy Bottle");
            itemsListBox.Items.Add("Rare Candy Small");
            itemsListBox.Items.Add("Rare Candy Medium");
            itemsListBox.Items.Add("Rare Candy Large");
            itemsListBox.Items.Add("Training Weight");
            itemsListBox.Items.Add("Ability Urge");
            itemsListBox.Items.Add("Academy Bottle");
            itemsListBox.Items.Add("Training Weight");
            itemsListBox.Items.Add("Ability Urge");
            itemsListBox.Items.Add("Academy Bottle");
            itemsListBox.Items.Add("Training Weight");
        }

        private void itemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = itemsListBox.GetItemText(itemsListBox.SelectedItem);
            MessageBox.Show("This item is very strong", item, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
