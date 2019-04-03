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
        private Color[] customNamelessBorderColors = new Color[]
        {
            Color.FromArgb(50, 50, 50),
            Color.Black,
            Color.Black
        };

        private Color customNamelessCorners = Color.Black;

        private Color[] customNamelessNoneHighlight = new Color[]
        {
            Color.White,
            Color.FromArgb(130, 130, 130),
            Color.FromArgb(40, 40, 40)

        };

        private Color[] customNamelessOverHighlight = new Color[]
        {
            Color.White,
            Color.FromArgb(150, 150, 150),
            Color.FromArgb(50, 50, 50)

        };

        private Color[] customNamelessDownHighlight = new Color[]
        {
            Color.White,
            Color.FromArgb(60, 60, 60),
            Color.FromArgb(22, 22, 22)

        };
        #endregion

        #region Public Properties
        public Color CustomNamelessCorners
        {
            get { return customNamelessCorners; }
            set
            {
                customNamelessCorners = value;
                Invalidate();
            }
        }

        public Color[] CustomNamelessBorderColors
        {
            get { return customNamelessBorderColors; }
            set { customNamelessBorderColors = value; Invalidate(); }
        }

        public Color[] CustomNamelessNoneHighlight
        {
            get { return customNamelessNoneHighlight; }
            set { customNamelessNoneHighlight = value; Invalidate(); }
        }

        public Color[] CustomNamelessOverHighlight
        {
            get { return customNamelessOverHighlight; }
            set
            {
                customNamelessOverHighlight = value;
                Invalidate();
            }
        }

        public Color[] CustomNamelessDownHighlight
        {
            get { return customNamelessDownHighlight; }
            set
            {
                customNamelessDownHighlight = value;
                Invalidate();
            }
        }
        #endregion

        #region Paint
        private void CustomNameLessPaintHook()
        {
            if (State == MouseState.None)
            {
                G.Clear(Color.FromArgb(20, CustomNamelessNoneHighlight[0]));
                Rectangle GrdRect = new Rectangle(0, 0, Width, this.Height / 2);
                LinearGradientBrush HeaderLGB = new LinearGradientBrush(GrdRect, CustomNamelessNoneHighlight[1], CustomNamelessNoneHighlight[2], 90);
                G.FillRectangle(HeaderLGB, GrdRect);
                //DrawGradient(Color.FromArgb(70, 70, 70), Color.FromArgb(30, 30, 30), 0, 0, Width, Me.Height \ 2)
                DrawBorders(new Pen(CustomNamelessBorderColors[0]), 1);
                DrawBorders(new Pen(CustomNamelessBorderColors[1]), 2);
                DrawBorders(new Pen(CustomNamelessBorderColors[2]));

                DrawCorners(CustomNamelessCorners, ClientRectangle);
                //DrawText(new SolidBrush(Color.FromArgb(180, 180, 180)), HorizontalAlignment.Center, 0, 0);

            }

            else if (State == MouseState.Over)
            {
                G.Clear(Color.FromArgb(35, CustomNamelessOverHighlight[0]));
                //DrawGradient(Color.FromArgb(80, 80, 80), Color.FromArgb(40, 40, 40), 0, 0, Width, Me.Height \ 2)

                Rectangle GrdRect1 = new Rectangle(0, 0, Width, this.Height / 2);
                LinearGradientBrush HeaderLGB1 = new LinearGradientBrush(GrdRect1, CustomNamelessOverHighlight[1], CustomNamelessOverHighlight[2], 90);
                G.FillRectangle(HeaderLGB1, GrdRect1);
                DrawBorders(new Pen(CustomNamelessBorderColors[0]), 1);
                DrawBorders(new Pen(CustomNamelessBorderColors[1]), 2);
                DrawBorders(new Pen(CustomNamelessBorderColors[2]));

                DrawCorners(CustomNamelessCorners, ClientRectangle);
                //DrawText(new SolidBrush(Color.FromArgb(222, 222, 222)), HorizontalAlignment.Center, 0, 0);


            }

            else if (State == MouseState.Down)
            {
                G.Clear(Color.FromArgb(10, CustomNamelessDownHighlight[0]));
                DrawGradient(CustomNamelessDownHighlight[1], CustomNamelessDownHighlight[2], 0, 0, Width, this.Height / 2);

                DrawBorders(new Pen(CustomNamelessBorderColors[0]), 1);
                DrawBorders(new Pen(CustomNamelessBorderColors[1]), 2);
                DrawBorders(new Pen(CustomNamelessBorderColors[2]));

                DrawCorners(CustomNamelessCorners, ClientRectangle);
                //DrawText(new SolidBrush(Color.FromArgb(170, 170, 170)), HorizontalAlignment.Center, 1, 1);

            }
        }

        #endregion

    }

}

