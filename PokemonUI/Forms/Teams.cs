using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TeamDexLibrary;
using System.Linq;
using System.Drawing;
using System.IO;
using Flurl.Http.Configuration;

namespace PokemonUI.Forms
{
    public partial class Teams : Form
    {
        private List<Team> teamList;
        private List<Move>  movedex;
        private List<Pokedex> pokedex;
        private List<Item> itemdex;
        private Team activeTeam;
        private int activeMon;
        public Teams()
        {
            InitializeComponent();
            SetLists();
            if(teamList.Count>0)
            {
                activeTeam = teamList[0];
                activeMon = activeTeam.Members[0];
                var btn = new Button();
                btn.Name = activeTeam.Name;
                ShowTeam(btn,new EventArgs());
            }
        }

        private void SetLists()
        {
            var path = "./Json/team.json";
            var fullPath = Path.GetFullPath(path);
            var json = File.ReadAllText(fullPath);
            Console.WriteLine(fullPath);
            teamList = JsonConvert.DeserializeObject<List<Team>>(json);
            movedex = DataRetriever.movedex(@"./Json/move.json");
            pokedex = DataRetriever.pokedex(@"./Json/pokedex.json");
            itemdex = DataRetriever.itemdex(@"./Json/item.json");
        }
        private void Teams_Load(object sender, EventArgs e)
        {
            reloadTeams();
        }

        private void reloadTeams()
        {
            teamSelectButton.Controls.Clear();
            foreach (var team in teamList)
            {
                Button btn = TeamButton();
                btn.Name = team.Name;
                teamSelectButton.Controls.Add(btn);
            }
        }
        public void newTeamButton_Click(object sender, EventArgs e) 
        {
            NewTeam();
        }

        private void NewTeam()
        {
            int[] indices = new int[6];
            Random ran = new Random();
            for (var i = 0; i < 6; i++)
            {
                indices[i] = ran.Next(0, pokedex.Count);
            }
            int[] moves = new int[24];
            for (var i = 0; i < 24; i++)
            {
                moves[i] = ran.Next(0, movedex.Count);
            }
            int[] items = new int[6];
            for (var i = 0; i < 6; i++)
            {
                items[i] = ran.Next(0, itemdex.Count);
            }

            Team newTeam = new Team();
            newTeam.Name = $"randomTeam{teamList.Count + 1}";
            newTeam.Description = "A randomised team";
            newTeam.Members = indices;
            newTeam.Moves = moves;
            newTeam.HeldItem = items;
            teamList.Add(newTeam);
            saveTeams();
            reloadTeams();
        }
        private Button TeamButton()
        {
            Button btn = new Button();
            btn.Dock = DockStyle.Top;
            btn.ImageKey = "closed_pokeball.png";
            btn.ImageList = teamsImages;
            btn.Location = new System.Drawing.Point(0, 0);
            btn.Margin = new System.Windows.Forms.Padding(2);
            btn.MinimumSize = new System.Drawing.Size(50, 52);
            btn.Size = new System.Drawing.Size(59, 56);
            btn.UseVisualStyleBackColor = true;
            btn.Click += new System.EventHandler(ShowTeam);

            return btn;
        }

        private void ShowTeam(object sender, EventArgs e)
        {
            var panel = teamSelectButton;
            foreach (var control in panel.Controls)
            {
                ((Button)control).BackColor = DefaultBackColor;
            }
            Button btn = (Button)sender;
            btn.BackColor = System.Drawing.Color.LightGray;
            var team =
                (from tmp in teamList
                where tmp.Name == btn.Name
                select tmp).First();

            activeTeam = team;
            teamName.Text = team.Name;
            var boxes = membersTable.Controls;

            for (int i=0;i<team.Members.Length;i++)
            {
                var tmpImg = pokemonImages.Images[$"{team.Members[i]}.png"];
                ((PictureBox)boxes[i]).Image = tmpImg;
            }

        }
        private DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textbox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;

            buttonOk.Text = "Create";
            buttonCancel.Text = "Cancel";

            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(36, 36, 372, 13);
            textbox.SetBounds(36, 86, 700, 20);
            buttonOk.SetBounds(228, 160, 160, 60);
            buttonCancel.SetBounds(400, 160, 160, 60);

            label.AutoSize = true;
            form.ClientSize = new System.Drawing.Size(796, 307);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox= false;
            form.MaximizeBox = false;

            form.Controls.AddRange(new Control[] { label, textbox, buttonOk, buttonCancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textbox.Text;
            return dialogResult;
        }


        private void member_Click(object sender, EventArgs e)
        {
            clearMemberDetails();
            try
            {

                var index = membersTable.Controls.IndexOf((PictureBox)sender);
                if (index >= activeTeam.Members.Length) return;

                activeMon = index;
                foreach (var control in membersTable.Controls)
                {
                    ((PictureBox)control).BackColor = DefaultBackColor;
                }
                var box = (PictureBox)sender;
                box.BackColor = Color.LightGray;
            
                var teamMember = activeTeam.Members[index];

                var pkmn = pokedex[teamMember-1];
                pokemonImage.Image = pokemonImages.Images[$"{teamMember}.png"];
                pokemonNameLabel.Text = pkmn.Name;

                var item =
                    (from tmp in itemdex
                    where tmp.Id == activeTeam.HeldItem[index]
                    select tmp.Name).First();
                heldItemImage.Image = itemImages.Images[$"{item}.png"];
                heldItemLabel.Text = item;

                for(int i = 0; i < 4; i++)
                {
                    ListViewItem move = new ListViewItem();
                    var mv =
                        (from tmp in movedex
                        where tmp.Id == activeTeam.Moves[(index * 4) + i]
                        select tmp).First();
                    move.Text = mv.Name;
                    move.ImageKey = $"{mv.Type}.gif";
                    memberMovesListView.Items.Add(move);
                }
            } catch (Exception)
            {
                //no error handling necessary
            }
        }
        private void clearMemberDetails()
        {
            memberMovesListView.Items.Clear();
            heldItemImage.Image = null;
            pokemonImage.Image = null;
            heldItemLabel.Text = "null";
            pokemonNameLabel.Text = "null";
        }
        private void saveTeams()
        {
            var json = JsonConvert.SerializeObject(teamList);
            var path = "./Json/team.json";
            var fullPath = Path.GetFullPath(path);
            File.WriteAllText(fullPath,json);
        }
    }
}
