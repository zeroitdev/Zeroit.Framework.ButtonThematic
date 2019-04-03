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
        #region Enum
        public enum RenderMode
        {
            Solid,
            Gradient,
            Hatch
        } 

        #endregion

        #region Private Fields
        private int upperLeftCurve = 10;
        private int upperRightCurve = 10;
        private int downLeftCurve = 10;
        private int downRightCurve = 10;

        private float customGradientAngle = 270f;

        private int customBoosterOffset = 6;

        private float customBoosterHoverTransparency = 50f;

        private Color[] customBoosterColors = new Color[]
        {
            Color.FromArgb(22,22,22),
            Color.FromArgb(95,0,0)

        };

        private Color[] customBoosterHatchColors = new Color[]
        {
            Color.FromArgb(0,0,0),
            Color.FromArgb(50, 95,0,0)

        };

        private Color customBoosterOuterBorder = Color.Black;
        private Color customBoosterInnerBorder = Color.Black;

        private bool customBoosterInfluenceOuter = false;

        private Thread customBoosterOpenT;

        #endregion


        #region Public Properties

        public int UpperLeftCurve
        {
            get { return upperLeftCurve; }
            set
            {
                upperLeftCurve = value;
                Invalidate();
            }
        }

        public int UpperRightCurve
        {
            get { return upperRightCurve; }
            set
            {
                upperRightCurve = value;
                Invalidate();
            }
        }

        public int DownLeftCurve
        {
            get { return downLeftCurve; }
            set
            {
                downLeftCurve = value;
                Invalidate();
            }
        }

        public int DownRightCurve
        {
            get { return downRightCurve; }
            set
            {
                downRightCurve = value;
                Invalidate();
            }
        }

        public Color[] CustomBoosterColors
        {
            get { return customBoosterColors; }
            set { customBoosterColors = value; Invalidate(); }
        }

        public float CustomBoosterGradientAngle
        {
            get { return customGradientAngle; }
            set
            {
                customGradientAngle = value;
                Invalidate();
            }
        }

        public Color CustomBoosterOuterBorder
        {
            get { return customBoosterOuterBorder; }
            set { customBoosterOuterBorder = value; Invalidate(); }
        }

        public Color CustomBoosterInnerBorder
        {
            get { return customBoosterInnerBorder; }
            set { customBoosterInnerBorder = value; Invalidate(); }
        }

        public int CustomBoosterOffset
        {
            get { return customBoosterOffset; }
            set
            {
                customBoosterOffset = value;
                Invalidate();
            }
        }

        public float CustomBoosterHoverTransparency
        {
            get { return customBoosterHoverTransparency; }
            set
            {
                customBoosterHoverTransparency = value;
                Invalidate();
            }
        }

        public Color[] CustomBoosterHatchColors
        {
            get { return customBoosterHatchColors; }
            set
            {
                customBoosterHatchColors = value;
                Invalidate();
            }
        }

        public bool CustomBoosterInfluenceOuter
        {
            get { return customBoosterInfluenceOuter; }
            set
            {
                customBoosterInfluenceOuter = value;
                Invalidate();
            }
        }
        #endregion

        #region Paint
        
        private void CustomBoosterPaintHook()
        {
            G.Clear(Parent.BackColor);
            GraphicsPath roundedRect = Helper.RoundRect(new Rectangle(0, 0, Width - 2, Height - 2), UpperLeftCurve, UpperRightCurve, DownLeftCurve, DownRightCurve);
            //HatchBrush hatchbrush = new HatchBrush(hatchStyle, CustomBoosterHatchColors[0], CustomBoosterHatchColors[1]);
            HatchBrush hatchbrush;

            #region Outer Drawings Original Code
            //switch (DrawMode)
            //{
            //    case RenderMode.Solid:
            //        G.FillPath(new SolidBrush(Color.FromArgb((int)CustomBoosterHoverTransparency,CustomBoosterColors[1])), roundedRect);
            //        G.DrawPath(new Pen(CustomBoosterOuterBorder), roundedRect);
            //        break;
            //    case RenderMode.Gradient:
            //        G.FillPath(new LinearGradientBrush(new Rectangle(0, 0, Width - 2, Height - 2), CustomBoosterColors[0], CustomBoosterColors[0], CustomBoosterGradientAngle), roundedRect);
            //        G.DrawPath(new Pen(CustomBoosterOuterBorder), roundedRect);
            //        break;
            //    case RenderMode.Hatch:
            //        G.FillPath(hatchbrush, roundedRect);
            //        G.DrawPath(new Pen(CustomBoosterOuterBorder), roundedRect);
            //        break;
            //    default:
            //        throw new ArgumentOutOfRangeException();
            //} 
            #endregion

            if (State == MouseState.None)
            {
                #region Outer Drawings

                switch (DrawMode)
                {
                    case RenderMode.Solid:
                        G.FillPath(new SolidBrush(Color.FromArgb((int)CustomBoosterHoverTransparency, CustomBoosterColors[1])), roundedRect);
                        G.DrawPath(new Pen(CustomBoosterOuterBorder), roundedRect);
                        break;
                    case RenderMode.Gradient:
                        G.FillPath(new LinearGradientBrush(new Rectangle(0, 0, Width - 2, Height - 2), CustomBoosterColors[0], CustomBoosterColors[0], CustomBoosterGradientAngle), roundedRect);
                        G.DrawPath(new Pen(CustomBoosterOuterBorder), roundedRect);
                        break;
                    case RenderMode.Hatch:
                        hatchbrush = new HatchBrush(hatchStyle, CustomBoosterHatchColors[0], CustomBoosterHatchColors[1]);
                        G.FillPath(hatchbrush, roundedRect);
                        G.DrawPath(new Pen(CustomBoosterOuterBorder), roundedRect);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                #endregion

                //1st Quadrant
                G.FillPath(new LinearGradientBrush(new Rectangle(CustomBoosterOffset, CustomBoosterOffset, Width / 2, Height / 2), CustomBoosterColors[0],
                    CustomBoosterColors[1], CustomBoosterGradientAngle), Helper.RoundRect(new Rectangle(CustomBoosterOffset, CustomBoosterOffset, Width / 2, Height / 2), UpperLeftCurve, 1, 1, 1));

                //G.DrawPath(new Pen(new LinearGradientBrush(new Rectangle(4, 4, Width / 2, Height / 2), Color.Red,
                //    Color.Red, CustomBoosterGradientAngle)), Helper.RoundRect(new Rectangle(4, 4, Width / 2, Height / 2), UpperLeftCurve, 1, 1, 1));

                //2nd Quadrant
                G.FillPath(new LinearGradientBrush(new Rectangle((Width / 2), CustomBoosterOffset, (Width / 2) - CustomBoosterOffset, Height / 2), CustomBoosterColors[1],
                    CustomBoosterColors[0], -CustomBoosterGradientAngle), Helper.RoundRect(new Rectangle((Width / 2), CustomBoosterOffset, (Width / 2) - CustomBoosterOffset, Height / 2), 1, UpperRightCurve, 1, 1));

                //G.DrawPath(new Pen(Color.Yellow), Helper.RoundRect(new Rectangle((Width / 2), 4, (Width / 2) - 4, Height / 2), 1, UpperRightCurve, 1, 1));

                //3rd Quadrant
                G.FillPath(new LinearGradientBrush(new Rectangle(CustomBoosterOffset, (Height / 2) + CustomBoosterOffset, (Width / 2), (Height / 2) - (CustomBoosterOffset * 2 /*8*/)), CustomBoosterColors[1],
                    CustomBoosterColors[0], CustomBoosterGradientAngle), Helper.RoundRect(new Rectangle(CustomBoosterOffset, (Height / 2) + CustomBoosterOffset, (Width / 2), (Height / 2) - (CustomBoosterOffset * 2 /*8*/)), 1, 1, DownLeftCurve, 1));

                //G.DrawPath(new Pen(Color.Lime), Helper.RoundRect(new Rectangle(4, (Height / 2) + 4, (Width / 2), (Height / 2) - 8), 1, 1, 10, 1));

                //4th Quadrant
                G.FillPath(new LinearGradientBrush(new Rectangle((Width / 2), (Height / 2) + CustomBoosterOffset, (Width / 2) - CustomBoosterOffset, (Height / 2) - (CustomBoosterOffset * 2 /*8*/)), CustomBoosterColors[0],
                    CustomBoosterColors[1], -CustomBoosterGradientAngle), Helper.RoundRect(new Rectangle((Width / 2), (Height / 2) + CustomBoosterOffset, (Width / 2) - CustomBoosterOffset, (Height / 2) - (CustomBoosterOffset * 2 /*8*/)), 1, 1, 1, DownRightCurve));

                //G.DrawPath(new Pen(Color.White), Helper.RoundRect(new Rectangle((Width / 2), (Height / 2) + 4, (Width / 2) - 4, (Height / 2) - 8), 1, 1, 1, 10));

                //Border
                G.DrawPath(new Pen(CustomBoosterInnerBorder), Helper.RoundRect(new Rectangle(CustomBoosterOffset, CustomBoosterOffset, Width - (CustomBoosterOffset * 2), Height - (CustomBoosterOffset * 2)), UpperLeftCurve, UpperRightCurve, DownLeftCurve, DownRightCurve));

            }

            else if (State == MouseState.Over)
            {
                #region Outer Drawings

                switch (DrawMode)
                {
                    case RenderMode.Solid:
                        G.FillPath(new SolidBrush(Color.FromArgb((int)CustomBoosterHoverTransparency, CustomBoosterColors[1])), roundedRect);
                        G.DrawPath(new Pen(CustomBoosterOuterBorder), roundedRect);
                        break;
                    case RenderMode.Gradient:
                        G.FillPath(new LinearGradientBrush(new Rectangle(0, 0, Width - 2, Height - 2), CustomBoosterColors[0], CustomBoosterColors[0], CustomBoosterGradientAngle), roundedRect);
                        G.DrawPath(new Pen(CustomBoosterOuterBorder), roundedRect);
                        break;
                    case RenderMode.Hatch:
                        if (CustomBoosterInfluenceOuter)
                        {
                            hatchbrush = new HatchBrush(hatchStyle, Color.FromArgb(150, CustomBoosterHatchColors[0]), Color.FromArgb(80, CustomBoosterHatchColors[1]));
                            G.FillPath(hatchbrush, roundedRect);
                            G.DrawPath(new Pen(CustomBoosterOuterBorder), roundedRect);
                        }
                        else
                        {
                            hatchbrush = new HatchBrush(hatchStyle, CustomBoosterHatchColors[0], CustomBoosterHatchColors[1]);
                            G.FillPath(hatchbrush, roundedRect);
                            G.DrawPath(new Pen(CustomBoosterOuterBorder), roundedRect);
                        }

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                #endregion

                #region Should be deleted

                //1st Quadrant
                G.FillPath(new LinearGradientBrush(new Rectangle(CustomBoosterOffset, CustomBoosterOffset, Width / 2, Height / 2), Parent.BackColor,
                    Parent.BackColor, CustomBoosterGradientAngle), Helper.RoundRect(new Rectangle(CustomBoosterOffset, CustomBoosterOffset, Width / 2, Height / 2), UpperLeftCurve, 1, 1, 1));

                //G.DrawPath(new Pen(new LinearGradientBrush(new Rectangle(4, 4, Width / 2, Height / 2), Color.Red,
                //    Color.Red, CustomBoosterGradientAngle)), Helper.RoundRect(new Rectangle(4, 4, Width / 2, Height / 2), UpperLeftCurve, 1, 1, 1));

                //2nd Quadrant
                G.FillPath(new LinearGradientBrush(new Rectangle((Width / 2), CustomBoosterOffset, (Width / 2) - CustomBoosterOffset, Height / 2), Parent.BackColor,
                    Parent.BackColor, -CustomBoosterGradientAngle), Helper.RoundRect(new Rectangle((Width / 2), CustomBoosterOffset, (Width / 2) - CustomBoosterOffset, Height / 2), 1, UpperRightCurve, 1, 1));

                //G.DrawPath(new Pen(Color.Yellow), Helper.RoundRect(new Rectangle((Width / 2), 4, (Width / 2) - 4, Height / 2), 1, UpperRightCurve, 1, 1));

                //3rd Quadrant
                G.FillPath(new LinearGradientBrush(new Rectangle(CustomBoosterOffset, (Height / 2) + CustomBoosterOffset, (Width / 2), (Height / 2) - (CustomBoosterOffset * 2 /*8*/)), Parent.BackColor,
                    Parent.BackColor, CustomBoosterGradientAngle), Helper.RoundRect(new Rectangle(CustomBoosterOffset, (Height / 2) + CustomBoosterOffset, (Width / 2), (Height / 2) - (CustomBoosterOffset * 2 /*8*/)), 1, 1, DownLeftCurve, 1));

                //G.DrawPath(new Pen(Color.Lime), Helper.RoundRect(new Rectangle(4, (Height / 2) + 4, (Width / 2), (Height / 2) - 8), 1, 1, 10, 1));

                //4th Quadrant
                G.FillPath(new LinearGradientBrush(new Rectangle((Width / 2), (Height / 2) + CustomBoosterOffset, (Width / 2) - CustomBoosterOffset, (Height / 2) - (CustomBoosterOffset * 2 /*8*/)), Parent.BackColor,
                    Parent.BackColor, -CustomBoosterGradientAngle), Helper.RoundRect(new Rectangle((Width / 2), (Height / 2) + CustomBoosterOffset, (Width / 2) - CustomBoosterOffset, (Height / 2) - (CustomBoosterOffset * 2 /*8*/)), 1, 1, 1, DownRightCurve));

                //G.DrawPath(new Pen(Color.White), Helper.RoundRect(new Rectangle((Width / 2), (Height / 2) + 4, (Width / 2) - 4, (Height / 2) - 8), 1, 1, 1, 10));

                //Border
                G.DrawPath(new Pen(CustomBoosterInnerBorder), Helper.RoundRect(new Rectangle(CustomBoosterOffset, CustomBoosterOffset, Width - (CustomBoosterOffset * 2), Height - (CustomBoosterOffset * 2)), UpperLeftCurve, UpperRightCurve, DownLeftCurve, DownRightCurve));


                #endregion

                //1st Quadrant
                G.FillPath(new LinearGradientBrush(new Rectangle(CustomBoosterOffset, CustomBoosterOffset, Width / 2, Height / 2), Color.FromArgb((int)CustomBoosterHoverTransparency, CustomBoosterColors[0]),
                    Color.FromArgb((int)CustomBoosterHoverTransparency, CustomBoosterColors[1]), CustomBoosterGradientAngle), Helper.RoundRect(new Rectangle(CustomBoosterOffset, CustomBoosterOffset, Width / 2, Height / 2), UpperLeftCurve, 1, 1, 1));

                //G.DrawPath(new Pen(new LinearGradientBrush(new Rectangle(4, 4, Width / 2, Height / 2), Color.Red,
                //    Color.Red, CustomBoosterGradientAngle)), Helper.RoundRect(new Rectangle(4, 4, Width / 2, Height / 2), UpperLeftCurve, 1, 1, 1));

                //2nd Quadrant
                G.FillPath(new LinearGradientBrush(new Rectangle((Width / 2), CustomBoosterOffset, (Width / 2) - CustomBoosterOffset, Height / 2), Color.FromArgb((int)CustomBoosterHoverTransparency, CustomBoosterColors[1]),
                    Color.FromArgb((int)CustomBoosterHoverTransparency, CustomBoosterColors[0]), -CustomBoosterGradientAngle), Helper.RoundRect(new Rectangle((Width / 2), CustomBoosterOffset, (Width / 2) - CustomBoosterOffset, Height / 2), 1, UpperRightCurve, 1, 1));

                //G.DrawPath(new Pen(Color.Yellow), Helper.RoundRect(new Rectangle((Width / 2), 4, (Width / 2) - 4, Height / 2), 1, UpperRightCurve, 1, 1));

                //3rd Quadrant
                G.FillPath(new LinearGradientBrush(new Rectangle(CustomBoosterOffset, (Height / 2) + CustomBoosterOffset, (Width / 2), (Height / 2) - (CustomBoosterOffset * 2 /*8*/)), Color.FromArgb((int)CustomBoosterHoverTransparency, CustomBoosterColors[1]),
                    Color.FromArgb((int)CustomBoosterHoverTransparency, CustomBoosterColors[0]), CustomBoosterGradientAngle), Helper.RoundRect(new Rectangle(CustomBoosterOffset, (Height / 2) + CustomBoosterOffset, (Width / 2), (Height / 2) - (CustomBoosterOffset * 2 /*8*/)), 1, 1, DownLeftCurve, 1));

                //G.DrawPath(new Pen(Color.Lime), Helper.RoundRect(new Rectangle(4, (Height / 2) + 4, (Width / 2), (Height / 2) - 8), 1, 1, 10, 1));

                //4th Quadrant
                G.FillPath(new LinearGradientBrush(new Rectangle((Width / 2), (Height / 2) + CustomBoosterOffset, (Width / 2) - CustomBoosterOffset, (Height / 2) - (CustomBoosterOffset * 2 /*8*/)), Color.FromArgb((int)CustomBoosterHoverTransparency, CustomBoosterColors[0]),
                    Color.FromArgb((int)CustomBoosterHoverTransparency, CustomBoosterColors[1]), -CustomBoosterGradientAngle), Helper.RoundRect(new Rectangle((Width / 2), (Height / 2) + CustomBoosterOffset, (Width / 2) - CustomBoosterOffset, (Height / 2) - (CustomBoosterOffset * 2 /*8*/)), 1, 1, 1, DownRightCurve));

                //G.DrawPath(new Pen(Color.White), Helper.RoundRect(new Rectangle((Width / 2), (Height / 2) + 4, (Width / 2) - 4, (Height / 2) - 8), 1, 1, 1, 10));

                //Border
                G.DrawPath(new Pen(CustomBoosterInnerBorder), Helper.RoundRect(new Rectangle(CustomBoosterOffset, CustomBoosterOffset, Width - (CustomBoosterOffset * 2), Height - (CustomBoosterOffset * 2)), UpperLeftCurve, UpperRightCurve, DownLeftCurve, DownRightCurve));

            }

            else if (State == MouseState.Down)
            {
                #region Outer Drawings

                switch (DrawMode)
                {
                    case RenderMode.Solid:
                        G.FillPath(new SolidBrush(Color.FromArgb((int)CustomBoosterHoverTransparency, CustomBoosterColors[1])), roundedRect);
                        G.DrawPath(new Pen(CustomBoosterOuterBorder), roundedRect);
                        break;
                    case RenderMode.Gradient:
                        G.FillPath(new LinearGradientBrush(new Rectangle(0, 0, Width - 2, Height - 2), CustomBoosterColors[0], CustomBoosterColors[0], CustomBoosterGradientAngle), roundedRect);
                        G.DrawPath(new Pen(CustomBoosterOuterBorder), roundedRect);
                        break;
                    case RenderMode.Hatch:
                        hatchbrush = new HatchBrush(hatchStyle, CustomBoosterHatchColors[0], CustomBoosterHatchColors[1]);
                        G.FillPath(hatchbrush, roundedRect);
                        G.DrawPath(new Pen(CustomBoosterOuterBorder), roundedRect);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                #endregion

                //1st Quadrant
                G.FillPath(new LinearGradientBrush(new Rectangle(CustomBoosterOffset, CustomBoosterOffset, Width / 2, Height / 2), CustomBoosterColors[1],
                    CustomBoosterColors[0], CustomBoosterGradientAngle), Helper.RoundRect(new Rectangle(CustomBoosterOffset, CustomBoosterOffset, Width / 2, Height / 2), UpperLeftCurve, 1, 1, 1));

                //G.DrawPath(new Pen(new LinearGradientBrush(new Rectangle(4, 4, Width / 2, Height / 2), Color.Red,
                //    Color.Red, CustomBoosterGradientAngle)), Helper.RoundRect(new Rectangle(4, 4, Width / 2, Height / 2), UpperLeftCurve, 1, 1, 1));

                //2nd Quadrant
                G.FillPath(new LinearGradientBrush(new Rectangle((Width / 2), CustomBoosterOffset, (Width / 2) - CustomBoosterOffset, Height / 2), CustomBoosterColors[0],
                    CustomBoosterColors[1], -CustomBoosterGradientAngle), Helper.RoundRect(new Rectangle((Width / 2), CustomBoosterOffset, (Width / 2) - CustomBoosterOffset, Height / 2), 1, UpperRightCurve, 1, 1));

                //G.DrawPath(new Pen(Color.Yellow), Helper.RoundRect(new Rectangle((Width / 2), 4, (Width / 2) - 4, Height / 2), 1, UpperRightCurve, 1, 1));

                //3rd Quadrant
                G.FillPath(new LinearGradientBrush(new Rectangle(CustomBoosterOffset, (Height / 2) + CustomBoosterOffset, (Width / 2), (Height / 2) - (CustomBoosterOffset * 2 /*8*/)), CustomBoosterColors[0],
                    CustomBoosterColors[1], CustomBoosterGradientAngle), Helper.RoundRect(new Rectangle(CustomBoosterOffset, (Height / 2) + CustomBoosterOffset, (Width / 2), (Height / 2) - (CustomBoosterOffset * 2 /*8*/)), 1, 1, DownLeftCurve, 1));

                //G.DrawPath(new Pen(Color.Lime), Helper.RoundRect(new Rectangle(4, (Height / 2) + 4, (Width / 2), (Height / 2) - 8), 1, 1, 10, 1));

                //4th Quadrant
                G.FillPath(new LinearGradientBrush(new Rectangle((Width / 2), (Height / 2) + CustomBoosterOffset, (Width / 2) - CustomBoosterOffset, (Height / 2) - (CustomBoosterOffset * 2 /*8*/)), CustomBoosterColors[1],
                    CustomBoosterColors[0], -CustomBoosterGradientAngle), Helper.RoundRect(new Rectangle((Width / 2), (Height / 2) + CustomBoosterOffset, (Width / 2) - CustomBoosterOffset, (Height / 2) - (CustomBoosterOffset * 2 /*8*/)), 1, 1, 1, DownRightCurve));

                //G.DrawPath(new Pen(Color.White), Helper.RoundRect(new Rectangle((Width / 2), (Height / 2) + 4, (Width / 2) - 4, (Height / 2) - 8), 1, 1, 1, 10));

                //Border
                G.DrawPath(new Pen(CustomBoosterInnerBorder), Helper.RoundRect(new Rectangle(CustomBoosterOffset, CustomBoosterOffset, Width - (CustomBoosterOffset * 2), Height - (CustomBoosterOffset * 2)), UpperLeftCurve, UpperRightCurve, DownLeftCurve, DownRightCurve));

            }
            else
            {

            }

            DrawCorners(BackColor);
            //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);

        }

        #endregion

        #region Methods and Events

        private void CustomBoosterOnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            customBoosterOpenT = new Thread(CustomBoosterEnterAnimation);
            if (!customBoosterOpenT.IsAlive)
            {
                customBoosterOpenT.IsBackground = true;
                customBoosterOpenT.Start();
            }
        }

        private void CustomBoosterEnterAnimation()
        {

            for (int fade = 0; fade <= 50; fade += 10)
            {
                Thread.Sleep(10);
                CustomBoosterHoverTransparency = fade;
            }
        }

        #endregion

    }

}
