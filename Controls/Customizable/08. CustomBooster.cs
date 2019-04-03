// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="08. CustomBooster.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Button control.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
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
        //private int upperLeftCurve = 10;
        //private int upperRightCurve = 10;
        //private int downLeftCurve = 10;
        //private int downRightCurve = 10;

        //private float customGradientAngle = 270f;

        //private int customBoosterOffset = 6;

        //private float customBoosterHoverTransparency = 50f;

        //private Color[] customBoosterColors = new Color[]
        //{
        //    Color.FromArgb(22,22,22),
        //    Color.FromArgb(95,0,0)

        //};

        //private Color[] customBoosterHatchColors = new Color[]
        //{
        //    Color.FromArgb(0,0,0),
        //    Color.FromArgb(50, 95,0,0)

        //};

        //private Color customBoosterOuterBorder = Color.Black;
        //private Color customBoosterInnerBorder = Color.Black;

        //private bool customBoosterInfluenceOuter = false;

        private Thread customBoosterOpenT;

        #endregion

        #region Public Properties

        [Browsable(false)]
        public int UpperLeftCurve
        {
            get { return buttonInput.UpperLeftCurve; }
            set
            {
                buttonInput.UpperLeftCurve = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public int UpperRightCurve
        {
            get { return buttonInput.UpperRightCurve; }
            set
            {
                buttonInput.UpperRightCurve = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public int DownLeftCurve
        {
            get { return buttonInput.DownLeftCurve; }
            set
            {
                buttonInput.DownLeftCurve = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public int DownRightCurve
        {
            get { return buttonInput.DownRightCurve; }
            set
            {
                buttonInput.DownRightCurve = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] CustomBoosterColors
        {
            get { return buttonInput.CustomBoosterColors; }
            set { buttonInput.CustomBoosterColors = value; Invalidate(); }
        }

        [Browsable(false)]
        public float CustomBoosterGradientAngle
        {
            get { return buttonInput.CustomBoosterGradientAngle; }
            set
            {
                buttonInput.CustomBoosterGradientAngle = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color CustomBoosterOuterBorder
        {
            get { return buttonInput.CustomBoosterOuterBorder; }
            set { buttonInput.CustomBoosterOuterBorder = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomBoosterInnerBorder
        {
            get { return buttonInput.CustomBoosterInnerBorder; }
            set { buttonInput.CustomBoosterInnerBorder = value; Invalidate(); }
        }

        [Browsable(false)]
        public int CustomBoosterOffset
        {
            get { return buttonInput.CustomBoosterOffset; }
            set
            {
                buttonInput.CustomBoosterOffset = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public float CustomBoosterHoverTransparency
        {
            get { return buttonInput.CustomBoosterHoverTransparency; }
            set
            {
                buttonInput.CustomBoosterHoverTransparency = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] CustomBoosterHatchColors
        {
            get { return buttonInput.CustomBoosterHatchColors; }
            set
            {
                buttonInput.CustomBoosterHatchColors = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public bool CustomBoosterInfluenceOuter
        {
            get { return buttonInput.CustomBoosterInfluenceOuter; }
            set
            {
                buttonInput.CustomBoosterInfluenceOuter = value;
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
                        hatchbrush = new HatchBrush(HatchStyle, CustomBoosterHatchColors[0], CustomBoosterHatchColors[1]);
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
                            hatchbrush = new HatchBrush(HatchStyle, Color.FromArgb(150, CustomBoosterHatchColors[0]), Color.FromArgb(80, CustomBoosterHatchColors[1]));
                            G.FillPath(hatchbrush, roundedRect);
                            G.DrawPath(new Pen(CustomBoosterOuterBorder), roundedRect);
                        }
                        else
                        {
                            hatchbrush = new HatchBrush(HatchStyle, CustomBoosterHatchColors[0], CustomBoosterHatchColors[1]);
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
                        hatchbrush = new HatchBrush(HatchStyle, CustomBoosterHatchColors[0], CustomBoosterHatchColors[1]);
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
