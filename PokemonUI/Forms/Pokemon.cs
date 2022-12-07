using PokeApiNet;
using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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
            pokemonListBox.Items.Add("Pikachu");
            pokemonListBox.Items.Add("Charizard");
            pokemonListBox.Items.Add("Piplup");
            pokemonListBox.Items.Add("Pikachu");
            pokemonListBox.Items.Add("Charizard");
            pokemonListBox.Items.Add("Piplup"); 
            pokemonListBox.Items.Add("Pikachu");
            pokemonListBox.Items.Add("Charizard");
            pokemonListBox.Items.Add("Piplup");
            pokemonListBox.Items.Add("Pikachu");
            pokemonListBox.Items.Add("Charizard");
            pokemonListBox.Items.Add("Piplup");


            //PokemonHandler.GetPokemon(pokemonListBox);
        }

        private void pokemonListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pokemon = pokemonListBox.GetItemText(pokemonListBox.SelectedItem);
            MessageBox.Show("This pokemon is very strong", pokemon, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
