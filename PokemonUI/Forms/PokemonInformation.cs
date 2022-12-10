using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TeamDexLibrary;

namespace PokemonUI.Forms
{
    public partial class PokemonInformation : Form
    {

        private Pokedex pkmn;
        private List<TeamDexLibrary.Type> typedex;
        private Image pkmnImage;
        public PokemonInformation(Pokedex pkmn, Image pkmnImage)
        {
            InitializeComponent();
            this.pkmn = pkmn;
            this.pkmnImage = pkmnImage;
            typedex = DataRetriever.typedex(@"./Json/type.json");
        }

        private void PokemonInformation_Load(object sender, EventArgs e)
        {
            pokemonImage.Image = pkmnImage;
            pokemonIdLabel.Text = pkmn.Id.ToString();
            pokemonNameLabel.Text = pkmn.Name;
            var types = pkmn.Types;
            var typeName1 = 
                (from tmp in typedex
                where tmp.Id == types[0]
                select tmp).First();
            if(types.Length==2)
            {
                var typeName2 =
                    (from tmp in typedex
                    where tmp.Id == types[1]
                    select tmp).First();
                type2.Text = typeName2.Name;
            }
            type1.Text = typeName1.Name;
        }
    }
}
