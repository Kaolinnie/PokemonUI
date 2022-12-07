using CsvHelper;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PokemonUI
{
    public partial class PokemonUIForm : Form
    {

        //reference: https://www.youtube.com/watch?v=BtOEztT1Qzk

        //fields
        private Button currentButton;
        private Color[] menuColors = {
            Color.FromArgb(97, 89, 90),
            Color.FromArgb(148, 10, 17),
            Color.FromArgb(182, 182, 182),
            Color.FromArgb(227, 173, 86),
            Color.FromArgb(255, 64, 105)
        };
        private Form activeForm;
               

        //constructor
        public PokemonUIForm()
        {
            InitializeComponent();
            OpenChildForm(new Forms.Teams(), teamsButton);
        }


        //methods
        private void OpenChildForm(Form childForm,object sender)
        {
            if (activeForm!= null)
            {
                activeForm.Close();
            }
            ActivateButton(sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle= FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.desktopPanel.Controls.Add(childForm);
            this.desktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void ActivateButton(object sender) {
            if (sender!=null)
            {
                if(currentButton!=(Button)sender)
                {
                    DisableButton();
                    int index = buttonsPanel.Controls.IndexOf((Button)sender);
                    if(index>=5)
                    {
                        MessageBox.Show("Index out of bounds: " + index+"\nNumber of controls: "+menuPanel.Controls.Count, "Out of bounds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else
                    {
                    Color color = menuColors[index];
                    currentButton = (Button)sender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    menuTitlePanel.BackColor = color;
                    menuTitleLabel.Text = ((Button)sender).Text;
                    logoPanel.BackColor = ChangeColorBrightness(color, -0.3);
                    }
                }
            }
        }
        private void DisableButton()
        {
            foreach(Control previousBtn in buttonsPanel.Controls)
            {
                if(previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void teamsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Teams(), sender);
        }

        private void movesButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Moves(), sender);
        }

        private void itemsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Items(), sender);


        }

        private void pokemonButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Pokemon(), sender);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Settings(), sender);

        }



        //
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            } else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
