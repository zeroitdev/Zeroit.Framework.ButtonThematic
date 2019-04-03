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
        Color customAdvantiumBack = Color.FromArgb(40, 40, 40);

        private Color[] customAdvantiumNoneColors = new Color[]
        {
            Color.FromArgb(50, 50, 50),
            Color.FromArgb(42, 42, 42)
        };

        private Color[] customAdvantiumDownColors = new Color[]
        {
            Color.FromArgb(50, 50, 50),
            Color.FromArgb(42, 42, 42)
        };

        private Color[] customAdvantiumOverColors = new Color[]
        {
            Color.FromArgb(42, 42, 42),
            Color.FromArgb(50, 50, 50)

        };

        private Color[] customAdvantiumBorderColors = new Color[]
        {
            Color.FromArgb(59, 59, 59),
            Color.FromArgb(25, 25, 25),
            Color.FromArgb(35, 35, 35)

        };

        private int[] customAdvantiumOffsets = new int[]
        {
            1,
            0,
            0
        };
        #endregion

        #region Public Properties
        public int[] CustomAdvantiumOffsets
        {
            get { return customAdvantiumOffsets; }
            set { customAdvantiumOffsets = value; Invalidate(); }
        }

        public Color CustomAdvantiumBackground
        {
            get { return customAdvantiumBack; }
            set { customAdvantiumBack = value; Invalidate(); }
        }

        public Color[] CustomAdvantiumNoneColors
        {
            get { return customAdvantiumNoneColors; }
            set { customAdvantiumNoneColors = value; Invalidate(); }
        }

        public Color[] CustomAdvantiumDownColors
        {
            get { return customAdvantiumDownColors; }
            set { customAdvantiumDownColors = value; Invalidate(); }
        }

        public Color[] CustomAdvantiumOverColors
        {
            get { return customAdvantiumOverColors; }
            set { customAdvantiumOverColors = value; Invalidate(); }
        }

        public Color[] CustomAdvantiumBorderColors
        {
            get { return customAdvantiumBorderColors; }
            set { customAdvantiumBorderColors = value; Invalidate(); }
        }
        #endregion

        #region Paint
        private void CustomAdvantiumPaintHook()
        {
            G.Clear(Color.Red);
            switch (State)
            {
                case MouseState.None:
                    //None
                    DrawGradient(CustomAdvantiumNoneColors[0], CustomAdvantiumNoneColors[1], ClientRectangle, 90);
                    break;
                case MouseState.Down:
                    //Down
                    DrawGradient(CustomAdvantiumDownColors[0], CustomAdvantiumDownColors[1], ClientRectangle, 90);
                    break;
                case MouseState.Over:
                    //Over
                    DrawGradient(CustomAdvantiumOverColors[0], CustomAdvantiumOverColors[1], ClientRectangle, 90);
                    break;
            }
            DrawBorders(new Pen(new SolidBrush(CustomAdvantiumBorderColors[0])), CustomAdvantiumOffsets[0]);
            DrawBorders(new Pen(new SolidBrush(CustomAdvantiumBorderColors[1])), CustomAdvantiumOffsets[1]);
            DrawCorners(CustomAdvantiumBorderColors[2], CustomAdvantiumOffsets[2]);
            //DrawText(new SolidBrush(CustomadvantiumT1), HorizontalAlignment.Center, 0, 0);
        } 
        #endregion

    }
}
