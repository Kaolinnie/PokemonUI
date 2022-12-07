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
        private ImageList allImages;
        private List<Pokedex> pokedex;
        public Pokemon(ImageList allImages)
        {
            InitializeComponent();
            this.allImages = allImages;
        }


        private void Pokemon_Load(object sender, EventArgs e)
        {
            pokedex = DataRetriever.pokedex(@"./Json/pokedex.json");
            foreach(var pkmn in pokedex)
            {
                pokemonList.Items.Add(pkmn.Name);
            }

        }

        private void pokemonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pokemonText = pokemonList.GetItemText(pokemonList.SelectedItem);
            var pkmn =
                (from tmp in pokedex
                 where tmp.Name == pokemonText
                 select tmp).First();
            Image img = allImages.Images["_"+pkmn.Id];

            PokemonInformation popup = new PokemonInformation(pkmn, img,allImages);
            DialogResult dialogresult = popup.ShowDialog();
            if (dialogresult == DialogResult.OK)
            {
                popup.Dispose();
            }
        }
    }
}
