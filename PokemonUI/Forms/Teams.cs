using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PokemonUI.Forms
{
    public partial class Teams : Form
    {
        private ImageList allImages;
        public Teams(ImageList allImages)
        {
            InitializeComponent();
            this.allImages = allImages;
        }


        private void Teams_Load(object sender, EventArgs e)
        {
        }


        public void newTeamButton_Click(object sender, EventArgs e) 
        {

        }
    }
}
