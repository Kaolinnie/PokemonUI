using PokeApiNet;
using System;
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
            PokemonHandler.GetPokemon(pokemonListBox);
        }
    }
}
