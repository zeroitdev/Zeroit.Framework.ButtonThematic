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
        private ColorBlend customFusionBlend = new ColorBlend
        {
            Colors = new Color[]
            {
                Color.FromArgb(28, 28, 28),
                Color.FromArgb(32, 32, 32),
                Color.FromArgb(24, 24, 24),
            },
            Positions = new float[] {
                0f,
                0.5f,
                1f
            }
        };

        private Color[] customFusionGradColors = new Color[]
        {
            Color.FromArgb(40, 40, 40),
            Color.FromArgb(48, 48, 48)
        };

        private Color customFusionCornerColor = Color.FromArgb(40, 40, 40);

        private Color customFusionNoneBorderColor = Color.Black;
        private Color customFusionDownBorderColor = Color.FromArgb(24, 24, 24);
        private Color customFusionOverBorderColor = Color.FromArgb(44, 44, 44);
        #endregion

        #region Public Properties
        public ColorBlend CustomFusionBlend
        {
            get { return customFusionBlend; }
            set
            {
                customFusionBlend = value;
                Invalidate();
            }
        }

        public Color[] CustomFusionGradColors
        {
            get { return customFusionGradColors; }
            set
            {
                customFusionGradColors = value;
                Invalidate();
            }
        }

        public Color CustomFusionCornerColor
        {
            get { return customFusionCornerColor; }
            set { customFusionCornerColor = value; Invalidate(); }
        }

        public Color CustomFusionNoneBorderColor
        {
            get { return customFusionNoneBorderColor; }
            set { customFusionNoneBorderColor = value; Invalidate(); }
        }

        public Color CustomFusionDownBorderColor
        {
            get { return customFusionDownBorderColor; }
            set { customFusionDownBorderColor = value; Invalidate(); }
        }

        public Color CustomFusionOverBorderColor
        {
            get { return customFusionOverBorderColor; }
            set { customFusionOverBorderColor = value; Invalidate(); }
        }
        #endregion
        
        #region Paint
        private void CustomFuturePaintHook()
        {
            DrawGradient(CustomFusionBlend, ClientRectangle, 90f);

            LinearGradientBrush GB1 = new LinearGradientBrush(ClientRectangle, CustomFusionGradColors[0], CustomFusionGradColors[1], 90f);
            Pen P1 = new Pen(GB1);

            DrawBorders(new Pen(CustomFusionNoneBorderColor), 1);
            DrawBorders(P1);

            if (State == MouseState.Down)
            {
                DrawBorders(new Pen(CustomFusionDownBorderColor), 2);

            }
            else
            {
                G.DrawLine(new Pen(CustomFusionOverBorderColor), 2, 2, Width - 3, 2);

            }

            DrawCorners(CustomFusionCornerColor, 1, 1, Width - 2, Height - 2);
            DrawCorners(Parent.BackColor);
        }

        #endregion

    }

}

