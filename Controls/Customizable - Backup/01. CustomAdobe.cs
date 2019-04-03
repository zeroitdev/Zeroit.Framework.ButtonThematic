using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{
    public partial class ButtonThematic
    {
        
        #region Private Fields

        private Color customizableAdobeBackground = Color.FromArgb(102, 102, 102);

        int customizableAdobeCoefficient = 15;

        private int customizableAdobeBorderOffset = 2;

        private Color[] customizableAdobeColors = new Color[]
        {
            Color.FromArgb(105, 105, 105),
            Color.FromArgb(56, 56, 56),
            Color.FromArgb(73, 73, 73),
            Color.FromArgb(48, 48, 48),
            Color.White,
            Color.Black
        };

        #endregion

        #region Properties

        public Color[] CustomizableAdobeColors
        {
            get { return customizableAdobeColors; }
            set
            {
                customizableAdobeColors = value;
                Invalidate();
            }
        }

        public Color CustomizableAdobeBackground
        {
            get { return customizableAdobeBackground; }
            set { customizableAdobeBackground = value; Invalidate(); }
        }

        public int CustomizableAdobeCoefficient
        {
            get { return customizableAdobeCoefficient; }
            set
            {
                customizableAdobeCoefficient = value;
                Invalidate();
            }
        }

        public int CustomizableAdobeBorderOffset
        {
            get { return customizableAdobeBorderOffset; }
            set
            {
                customizableAdobeBorderOffset = value;
                Invalidate();
            }
        }

        #endregion

        #region Paint

        private void CustomizableAdobePaintHook()
        {
            G.Clear(CustomizableAdobeBackground);

            DrawGradient(CustomizableAdobeColors[0], CustomizableAdobeColors[1], 0, 0, Width, Height, 90);
            DrawGradient(CustomizableAdobeColors[2], CustomizableAdobeColors[3], 1, 1, Width - 2, Height - 2, 90);

            switch (State)
            {
                case MouseState.None:
                    break;
                //NULL
                case MouseState.Over:

                    CustomizableAdobeCoefficient = 5;
                    break;
                case MouseState.Down:

                    CustomizableAdobeCoefficient = 10;
                    break;
            }

            for (int i = 1; i <= 5; i++)
            {
                G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(Convert.ToInt32(255 / (i * CustomizableAdobeCoefficient)), CustomizableAdobeColors[4]))), new Rectangle(i, i, Width - 2 - (i * 2), Height - 2 - (i * 2)));
            }

            DrawBorders(new Pen(CustomizableAdobeColors[5]), CustomizableAdobeBorderOffset);


        }

        #endregion

    }
}
