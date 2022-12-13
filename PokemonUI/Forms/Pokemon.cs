using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using TeamDexLibrary;
using System.Linq;

namespace PokemonUI.Forms
{
    public partial class Pokemon : Form
    {
        private List<Pokedex> pokedex;
        public Pokemon()
        {
            InitializeComponent();
        }


        private void Pokemon_Load(object sender, EventArgs e)
        {
            pokedex = DataRetriever.pokedex(@"./Json/pokedex.json");
            foreach(var pkmn in pokedex)
            {
                ListViewItem item = new ListViewItem();
                item.Text = char.ToUpper(pkmn.Name[0]) + pkmn.Name.Substring(1);
                item.ImageKey = $"{pkmn.Id}.png";
                pokemonListView.Items.Add(item);
            }

        }
         
    }
}
