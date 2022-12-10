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
                itemsList.Items.Add(item.Name);
            }
        }
        private void itemsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemText = itemsList.GetItemText(itemsList.SelectedItem);
            var image = itemText.Replace('-','_');
            var item =
                (from tmp in items
                where tmp.Name == itemText
                select tmp).First();
            Image img = itemImages.Images[image];

            ItemInformation popup = new ItemInformation(item,img);
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                popup.Dispose();
            }
        }
    }
}
