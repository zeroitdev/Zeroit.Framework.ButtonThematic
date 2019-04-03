using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.BaseContainer;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        #region Private Fields
        private Color customSpicyBackground = Color.FromArgb(1, 1, 1);

        private Color[] customSpicyNoneStateColors = new Color[]
        {
            Color.FromArgb(40, 40, 40),
            Color.FromArgb(28, 28, 28)
        };

        private Color[] customSpicyOverStateColors = new Color[]
        {
            Color.FromArgb(40, 40, 40),
            Color.FromArgb(28, 28, 28)
        };

        private Color[] customSpicyDownStateColors = new Color[]
        {
            Color.FromArgb(4, 4, 4),
            Color.FromArgb(20, 20, 20)
        };

        private Color customSpicyHighlight = Color.White;

        private Color[] customSpicyBorderColors = new Color[]
        {
            Color.Black,
            Color.Black
        };

        private Color customSpicyCornerColor = Color.FromArgb(20, 20, 20);
        #endregion

        #region Public Properties
        public Color CustomSpicyBackground
        {
            get { return customSpicyBackground; }
            set
            {
                customSpicyBackground = value;
                Invalidate();
            }
        }

        public Color[] CustomSpicyNoneStateColors
        {
            get { return customSpicyNoneStateColors; }
            set { customSpicyNoneStateColors = value; Invalidate(); }
        }

        public Color[] CustomSpicyOverStateColors
        {
            get { return customSpicyOverStateColors; }
            set { customSpicyOverStateColors = value; Invalidate(); }
        }

        public Color[] CustomSpicyDownStateColors
        {
            get { return customSpicyDownStateColors; }
            set { customSpicyDownStateColors = value; Invalidate(); }
        }

        public Color CustomSpicyHighlight
        {
            get { return customSpicyHighlight; }
            set { customSpicyHighlight = value; Invalidate(); }
        }

        public Color[] CustomSpicyBorderColors
        {
            get { return customSpicyBorderColors; }
            set { customSpicyBorderColors = value; Invalidate(); }
        }

        public Color CustomSpicyCornerColor
        {
            get { return customSpicyCornerColor; }
            set
            {
                customSpicyCornerColor = value;
                Invalidate();
            }
        }


        #endregion

        #region Paint
        private void CustomSpicyLipsPaintHook()
        {
            G.Clear(CustomSpicyBackground);
            switch (State)
            {
                case MouseState.None:
                    DrawGradient(CustomSpicyNoneStateColors[0], CustomSpicyNoneStateColors[1], 0, 0, Width, Height, 90);
                    break;
                case MouseState.Over:
                    DrawGradient(CustomSpicyOverStateColors[0], CustomSpicyOverStateColors[1], 0, 0, Width, Height, 90);
                    break;
                case MouseState.Down:
                    DrawGradient(CustomSpicyDownStateColors[0], CustomSpicyDownStateColors[1], 0, 0, Width, Height, 90);
                    break;
            }

            G.FillRectangle(new SolidBrush(Color.FromArgb(6, CustomSpicyHighlight)), 0, 0, Width, 12);

            DrawBorders(new Pen(CustomSpicyBorderColors[0]));
            DrawBorders(new Pen(CustomSpicyBorderColors[1]), 2);
            DrawCorners(CustomSpicyCornerColor, ClientRectangle);
            //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);

        }

        #endregion
        
    }

}

