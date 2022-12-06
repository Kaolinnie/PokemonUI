using PokemonUI.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonUI.Models
{
    public static class TypesWrapper
    {
        static TypesWrapper()
        {
            Types = new ImageList();
            LoadImages(Types);
        }

        private static void LoadImages(ImageList imageList)
        {
            Types.ImageStream = (ImageListStreamer)Resources.ResourceManager.GetObject("Types.ImageStream");
            Types.TransparentColor = System.Drawing.Color.Transparent;
            Types.Images.SetKeyName(0, "normal.gif");
            Types.Images.SetKeyName(1, "fire.gif");
            Types.Images.SetKeyName(2, "water.gif");
            Types.Images.SetKeyName(3, "electric.gif");
            Types.Images.SetKeyName(4, "grass.gif");
            Types.Images.SetKeyName(5, "ice.gif");
            Types.Images.SetKeyName(6, "psychic.gif");
            Types.Images.SetKeyName(7, "steel.gif");
        }

        public static ImageList Types { get; private set; }
    }
}
