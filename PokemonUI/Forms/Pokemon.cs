using PokeApiNet;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace PokemonUI.Forms
{
    public partial class Pokemon : Form
    {
        public Pokemon()
        {
            InitializeComponent();
        }

        private void Pokemon_Load(object sender, EventArgs e)
        {
            var pokemonList = PokemonHandler.GetPokemon();
            WebClient wc = new WebClient();

            for (int i = 0; i < pokemonList.Result.Count; i++)
            {
                var item = new ListViewItem();
                item.Text = pokemonList.Result.Results[i].Name;

                byte[] bytes = wc.DownloadData($"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/{i + 1}.png");
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
                ms.Dispose();

                if(img != null)
                {
                    pokemonImageList.Images.Add(img);
                    item.ImageIndex = i;
                }

                pokemonListView.Items.Add(item);
            }
        }
    }
}
