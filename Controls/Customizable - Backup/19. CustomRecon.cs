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
        private Color customReconBackground = Color.FromArgb(49, 49, 49);

        private Color[] customReconNoneStateColors = new Color[]
        {
            Color.FromArgb(22, 22, 22),
            Color.FromArgb(34, 34, 34)
        };

        private Color[] customReconDownStateColors = new Color[]
        {
            Color.FromArgb(28, 28, 28),
            Color.FromArgb(38, 38, 38),
            Color.FromArgb(100, 0, 0, 0),
            Color.Transparent
        };

        private Color[] customReconOverStateColors = new Color[]
        {
            Color.FromArgb(28, 28, 28),
            Color.FromArgb(38, 38, 38),
            Color.FromArgb(100, 50, 50, 50),
            Color.Transparent
        };

        private Color[] customReconBorder = new Color[]
        {
            Color.Black,
            Color.FromArgb(52, 52, 52)
        };
        #endregion

        #region Public Properties
        public Color CustomReconBackground
        {
            get { return customReconBackground; }
            set
            {
                customReconBackground = value;
                Invalidate();
            }
        }

        public Color[] CustomReconNoneStateColors
        {
            get { return customReconNoneStateColors; }
            set { customReconNoneStateColors = value; Invalidate(); }
        }

        public Color[] CustomReconDownStateColors
        {
            get { return customReconDownStateColors; }
            set { customReconDownStateColors = value; Invalidate(); }
        }

        public Color[] CustomReconOverStateColors
        {
            get { return customReconOverStateColors; }
            set { customReconOverStateColors = value; Invalidate(); }
        }

        public Color[] CustomReconBorder
        {
            get { return customReconBorder; }
            set
            {
                customReconBorder = value;
                Invalidate();
            }
        }
        #endregion

        #region Paint
        private void CustomReconPaintHook()
        {
            switch (State)
            {
                case MouseState.None:
                    G.Clear(CustomReconBackground);
                    DrawGradient(CustomReconNoneStateColors[0], CustomReconNoneStateColors[1], 1, 1, ClientRectangle.Width, ClientRectangle.Height, 270);
                    DrawBorders(new Pen(CustomReconBorder[0]), new Pen(CustomReconBorder[1]), ClientRectangle);
                    //DrawText(HorizontalAlignment.Center, this.ForeColor, 0);
                    DrawCorners(this.BackColor, ClientRectangle);
                    break;
                case MouseState.Down:
                    G.Clear(CustomReconBackground);
                    DrawGradient(CustomReconDownStateColors[0], CustomReconDownStateColors[1], 1, 1, ClientRectangle.Width, ClientRectangle.Height, 270);
                    DrawGradient(CustomReconDownStateColors[2], CustomReconDownStateColors[3], 1, 1, ClientRectangle.Width, ClientRectangle.Height / 2, 90);
                    DrawBorders(new Pen(CustomReconBorder[0]), new Pen(CustomReconBorder[1]), ClientRectangle);
                    //DrawText(HorizontalAlignment.Center, this.ForeColor, 1);
                    DrawCorners(this.BackColor, ClientRectangle);
                    break;
                case MouseState.Over:
                    G.Clear(CustomReconBackground);
                    DrawGradient(CustomReconOverStateColors[0], CustomReconOverStateColors[1], 1, 1, ClientRectangle.Width, ClientRectangle.Height, 270);
                    DrawGradient(CustomReconOverStateColors[2], CustomReconOverStateColors[3], 1, 1, ClientRectangle.Width, ClientRectangle.Height / 2, 90);
                    DrawBorders(new Pen(CustomReconBorder[0]), new Pen(CustomReconBorder[1]), ClientRectangle);
                    //DrawText(HorizontalAlignment.Center, this.ForeColor, -1);
                    DrawCorners(this.BackColor, ClientRectangle);
                    break;
            }

        }

        #endregion
    }

}

