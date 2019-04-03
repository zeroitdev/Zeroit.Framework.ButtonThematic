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
        private Color customDeumosBackground = Color.FromArgb(14, 14, 14);
        private Color customDeumosCornerColor = Color.FromArgb(16, 16, 16);
        private Color customDeumosOverStateColor = Color.FromArgb(5, Color.White);


        private Color[] customDeumosBorderColors = new Color[]
        {
            Color.FromArgb(62, 62, 62),
            Color.FromArgb(15, Color.White),
            Color.Black
        };


        private Color[] customDeumosDownStateColors = new Color[]
        {
            Color.FromArgb(14, 14, 14),
            Color.FromArgb(41, 41, 41)
        };

        private Color[] customDeumosNoneStateColors = new Color[]
        {
            Color.FromArgb(30, Color.White),
            Color.FromArgb(5, Color.White)
        };
        #endregion

        #region Public Properties
        public Color[] CustomDeumosBorderColors
        {
            get { return customDeumosBorderColors; }
            set
            {
                customDeumosBorderColors = value;
                Invalidate();
            }
        }

        public Color CustomDeumosBackground
        {
            get { return customDeumosBackground; }
            set
            {
                customDeumosBackground = value;
                Invalidate();
            }
        }

        public Color[] CustomDeumosDownStateColors
        {
            get { return customDeumosDownStateColors; }
            set
            {
                customDeumosDownStateColors = value;
                Invalidate();
            }
        }

        public Color CustomDeumosOverStateColor
        {
            get { return customDeumosOverStateColor; }
            set { customDeumosOverStateColor = value; Invalidate(); }
        }

        public Color[] CustomDeumosNoneStateColors
        {
            get { return customDeumosNoneStateColors; }
            set { customDeumosNoneStateColors = value; Invalidate(); }
        }

        public Color CustomDeumosCornerColor
        {
            get { return customDeumosCornerColor; }
            set { customDeumosCornerColor = value; }
        }

        #endregion

        #region Paint
        private void CustomDeumosPaintHook()
        {
            G.Clear(CustomDeumosBackground);

            if (State == MouseState.Down)
            {
                DrawGradient(CustomDeumosDownStateColors[0], CustomDeumosDownStateColors[1], 0, 0, Width, Height, 90);
            }

            if (State == MouseState.Over)
            {
                G.FillRectangle(new SolidBrush(customDeumosOverStateColor), ClientRectangle);
            }

            DrawGradient(CustomDeumosNoneStateColors[0], CustomDeumosNoneStateColors[1], 0, 0, Width, Height / 2, 90);

            G.DrawLine(new Pen(CustomDeumosBorderColors[0]), 0, 1, Width, 1);
            DrawBorders(new Pen(CustomDeumosBorderColors[1]), ClientRectangle, 1);

            DrawBorders(new Pen(CustomDeumosBorderColors[2]), ClientRectangle);

            DrawCorners(CustomDeumosCornerColor, new Rectangle(1, 1, Width - 2, Height - 2));
            DrawCorners(BackColor, ClientRectangle);

            //DrawText(new SolidBrush(deumosB2), HorizontalAlignment.Center, 0, 0);
        }

        #endregion
    }

}

