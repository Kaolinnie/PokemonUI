using PokeApiNet;
using PokemonUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace PokemonUI.Forms
{
    public partial class Teams : Form
    {

        public Teams()
        {
            InitializeComponent();
          
        }

        private static async Task<Team> Randomise(int size)
        {
            if (size <= 0) size = 1;
            if (size > 6) size = 6;
            Team tmp = new Team();
            Random ran = new Random();

            for (int i = 0; i < size; i++)
            {
                PokeApiNet.Pokemon p = await PokemonHandler.RandomPokemon();
                //NamedApiResource<Item> item = await PokemonHandler.RandomItem();
                tmp.PkmnTeam[i] = new Team.Pokemon
                {
                    Pkmn = p,
                    Moves = PokemonHandler.RandomMoves(p),
                    Ability = p.Abilities.ElementAt(ran.Next(0, p.Abilities.Count)).Ability
                };
            }
            return tmp;
        }

        private void Teams_Load(object sender, EventArgs e)
        {
            //Show();
            LoadTeam();
        }

        private async void Show()
        {
            var pkmn = await PokemonHandler.RandomPokemon();
            MessageBox.Show(pkmn.Name, "Pokemon", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private async void LoadTeam()
        {
            var team = await Randomise(6);

            var teamMembers = team.PkmnTeam;
            foreach(var member in teamMembers)
            {
                tmpBox.Items.Add(member.Pkmn.Name);
            }
        }


        public void newTeamButton_Click(object sender, EventArgs e) 
        {

        }
    }
}
