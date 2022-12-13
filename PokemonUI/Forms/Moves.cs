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
    public partial class Moves : Form
    {
        List<Move> moveList;
        public Moves()
        {
            InitializeComponent();
            moveList = DataRetriever.movedex(@"./Json/move.json");
        }

        private void Moves_Load(object sender, EventArgs e)
        {

            foreach (var move in moveList)
            {
                ListViewItem item = new ListViewItem();
                item.Text = move.Name;
                item.ImageIndex = move.Type-1;
                moveListView.Items.Add(item);
            }
        }
    }
}
