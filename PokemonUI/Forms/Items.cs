using Flurl.Util;
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
    public partial class Items : Form
    {
        private List<Item> items;
        public Items()
        {
            InitializeComponent();
        }

        private void Items_Load(object sender, EventArgs e)
        {
            items = TeamDexLibrary.DataRetriever.itemdex(@"./Json/item.json");
            foreach (Item item in items)
            {
                ListViewItem tmp = new ListViewItem();
                tmp.Text = item.Name;
                tmp.ImageKey = $"{item.Name}.png";
                itemsListView.Items.Add(tmp);
            }
        }

        private void itemsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var itemName = ((ListView)sender).SelectedItems[0].Text;
                var itemID =
                    (from tmp in items
                    where tmp.Name == itemName
                    select tmp.Id).First();

                MessageBox.Show($"Item Name: {itemName}", $"Item ID: {itemID}", MessageBoxButtons.OK);
            } catch (Exception)
            {
                //MessageBox.Show("Something went wrong...", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
