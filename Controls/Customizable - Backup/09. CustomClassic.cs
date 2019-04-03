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
        private Color customClassicBorder = Color.Black;
        private Color customClassicHighlight = Color.FromArgb(35, 35, 35);
        private Color customClassicBackground = Color.FromArgb(24, 24, 24);
        private Color customClassicShadow = Color.FromArgb(100, Color.Black);

        private Color[] customClassicColors = new Color[]
        {
            Color.FromArgb(0, 156, 255),
            Color.Transparent
        };
        #endregion

        #region Public Properties
        public Color CustomClassicBorder
        {
            get { return customClassicBorder; }
            set
            {
                customClassicBorder = value;
                Invalidate();
            }
        }

        public Color CustomClassicHighlight
        {
            get { return customClassicHighlight; }
            set { customClassicHighlight = value; Invalidate(); }
        }

        public Color CustomClassicBackground
        {
            get { return customClassicBackground; }
            set { customClassicBackground = value; Invalidate(); }
        }

        public Color CustomClassicShadow
        {
            get { return customClassicShadow; }
            set { customClassicShadow = value; Invalidate(); }
        }

        public Color[] CustomClassicColors
        {
            get { return customClassicColors; }
            set
            {
                customClassicColors = value;
                Invalidate();
            }
        }
        #endregion

        #region Paint
        private void CustomClassicPaintHook()
        {
            LinearGradientBrush L1;
            HatchBrush hatchBrush;
            SolidBrush soliBrush;
            Rectangle R1 = new Rectangle(2, 2, Width - 4, Height - 4);


            //G.FillRectangle(new SolidBrush(customClassicBackground), ClientRectangle);
            DrawBorders(new Pen(customClassicBorder), ClientRectangle);
            DrawBorders(new Pen(customClassicHighlight), 1, 1, Width - 2, Height - 2);

            switch (State)
            {
                case MouseState.Over:
                    L1 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(100, customClassicColors[0]), customClassicColors[1], 270);
                    soliBrush = new SolidBrush(Color.FromArgb(100, customClassicColors[0]));

                    switch (DrawMode)
                    {
                        case RenderMode.Solid:
                            G.FillRectangle(soliBrush, R1);
                            G.FillRectangle(new SolidBrush(customClassicShadow), 1, 7, Width - 2, Height - 7);
                            break;
                        case RenderMode.Gradient:
                            G.FillRectangle(L1, R1);
                            G.FillRectangle(new SolidBrush(customClassicShadow), 1, 7, Width - 2, Height - 7);
                            break;
                        case RenderMode.Hatch:
                            hatchBrush = new HatchBrush(HatchStyles, Color.FromArgb(100, customClassicColors[0]),
                                customClassicColors[1]);
                            G.FillRectangle(hatchBrush, R1);
                            G.FillRectangle(new SolidBrush(customClassicShadow), 1, 7, Width - 2, Height - 7);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    break;
                case MouseState.Down:
                    L1 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(50, customClassicColors[0]), customClassicColors[1], 90);
                    soliBrush = new SolidBrush(Color.FromArgb(50, customClassicColors[0]));

                    switch (DrawMode)
                    {
                        case RenderMode.Solid:
                            G.FillRectangle(soliBrush, R1);
                            G.FillRectangle(new SolidBrush(customClassicShadow), 1, 7, Width - 2, Height - 7);

                            break;
                        case RenderMode.Gradient:
                            G.FillRectangle(L1, R1);
                            G.FillRectangle(new SolidBrush(customClassicShadow), 1, 7, Width - 2, Height - 7);

                            break;
                        case RenderMode.Hatch:
                            hatchBrush = new HatchBrush(HatchStyles, Color.FromArgb(50, customClassicColors[0]),
                                customClassicColors[1]);
                            G.FillRectangle(hatchBrush, R1);
                            G.FillRectangle(new SolidBrush(customClassicShadow), 1, 7, Width - 2, Height - 7);

                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    break;
                case MouseState.None:

                    switch (DrawMode)
                    {
                        case RenderMode.Solid:
                            G.FillRectangle(new SolidBrush(customClassicBackground), ClientRectangle);
                            G.FillRectangle(new SolidBrush(customClassicShadow), 1, 8, Width - 2, Height - 8);
                            break;
                        case RenderMode.Gradient:
                            L1 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(255, customClassicBackground), customClassicBackground, 90);

                            G.FillRectangle(L1, ClientRectangle);
                            G.FillRectangle(new SolidBrush(customClassicShadow), 1, 8, Width - 2, Height - 8);
                            break;
                        case RenderMode.Hatch:
                            hatchBrush = new HatchBrush(HatchStyles, customClassicBackground, Color.FromArgb(25, customClassicBackground));
                            G.FillRectangle(hatchBrush, ClientRectangle);
                            G.FillRectangle(new SolidBrush(customClassicShadow), 1, 8, Width - 2, Height - 8);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    break;
            }

            //DrawText(ClassicBloom[4].Brush, HorizontalAlignment.Center, 0, 0);

        }

        #endregion

    }

}

