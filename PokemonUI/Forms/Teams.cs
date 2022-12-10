using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamDexLibrary;
using System.Linq;


namespace PokemonUI.Forms
{
    public partial class Teams : Form
    {
        private List<Team> teamList;
        public Teams()
        {
            InitializeComponent();
            SetTeamList();
        }

        private void SetTeamList()
        {
            teamList = DataRetriever.teamdex(@"./Json/team.json");
        }
        private void Teams_Load(object sender, EventArgs e)
        {
            foreach(var team in teamList)
            {
                Button btn = TeamButton();
                btn.Name=team.Name;
                teamSelectButton.Controls.Add(btn);
            }
        }


        public void newTeamButton_Click(object sender, EventArgs e) 
        {
            NewTeam();
        }

        private Button NewTeam()
        {
            string value = "";
            
            if(InputBox("Create your team","Team Name: ",ref value)==DialogResult.OK)
            {
                Button btn = TeamButton();

                btn.Name = value;
                teamSelectButton.Controls.Add(btn);

                Team team = new Team()
                {
                    Name = value
                };
                teamList.Add(team);

                return btn;
            }
            return null;
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
            Button btn = (Button)sender;
            var team =
                (from tmp in teamList
                where tmp.Name == btn.Name
                select tmp).First();

            teamName.Text = team.Name;
            teamDescription.Text = team.Description;
            var boxes = membersTable.Controls;

            for (int i=0;i<team.Members.Length;i++)
            {
                ((PictureBox)boxes[i]).Image = pokemonImages.Images[$"{team.Members[i]}"];
            }
            member1.Image = pokemonImages.Images["762"];

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

        private void pokemon1_Click(object sender, EventArgs e)
        {

        }

        private void heldItemImage_Click(object sender, EventArgs e)
        {

        }
    }
}
