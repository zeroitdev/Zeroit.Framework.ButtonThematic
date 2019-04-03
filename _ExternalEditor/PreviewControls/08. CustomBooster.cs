// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="08. CustomBooster.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Threading;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{
    /// <summary>
    /// Class BoosterPreview.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    [ToolboxItem(false)]
    public class BoosterPreview : ThemeControl
    {
        #region Enum
        /// <summary>
        /// Enum RenderMode
        /// </summary>
        public enum RenderMode
        {
            /// <summary>
            /// The solid
            /// </summary>
            Solid,
            /// <summary>
            /// The gradient
            /// </summary>
            Gradient,
            /// <summary>
            /// The hatch
            /// </summary>
            Hatch
        }

        #endregion

        #region Private Fields
        /// <summary>
        /// The upper left curve
        /// </summary>
        private int upperLeftCurve = 10;
        /// <summary>
        /// The upper right curve
        /// </summary>
        private int upperRightCurve = 10;
        /// <summary>
        /// Down left curve
        /// </summary>
        private int downLeftCurve = 10;
        /// <summary>
        /// Down right curve
        /// </summary>
        private int downRightCurve = 10;

        /// <summary>
        /// The custom gradient angle
        /// </summary>
        private float customGradientAngle = 270f;

        /// <summary>
        /// The custom booster offset
        /// </summary>
        private int customBoosterOffset = 6;

        /// <summary>
        /// The custom booster hover transparency
        /// </summary>
        private float customBoosterHoverTransparency = 50f;

        /// <summary>
        /// The custom booster colors
        /// </summary>
        private Color[] customBoosterColors = new Color[]
        {
            Color.FromArgb(22,22,22),
            Color.FromArgb(95,0,0)

        };

        /// <summary>
        /// The custom booster hatch colors
        /// </summary>
        private Color[] customBoosterHatchColors = new Color[]
        {
            Color.FromArgb(0,0,0),
            Color.FromArgb(50, 95,0,0)

        };

        /// <summary>
        /// The custom booster outer border
        /// </summary>
        private Color customBoosterOuterBorder = Color.Black;
        /// <summary>
        /// The custom booster inner border
        /// </summary>
        private Color customBoosterInnerBorder = Color.Black;

        /// <summary>
        /// The custom booster influence outer
        /// </summary>
        private bool customBoosterInfluenceOuter = false;

        /// <summary>
        /// The custom booster open t
        /// </summary>
        private Thread customBoosterOpenT;

        /// <summary>
        /// The hatch style
        /// </summary>
        private HatchStyle hatchStyle = HatchStyle.LightDownwardDiagonal;

        /// <summary>
        /// The draw mode
        /// </summary>
        private RenderMode drawMode = RenderMode.Gradient;
        #endregion

        #region Public Properties

        #region Smoothing Mode

        /// <summary>
        /// The smoothing
        /// </summary>
        private SmoothingMode smoothing = SmoothingMode.AntiAlias;

        /// <summary>
        /// Gets or sets the smoothing.
        /// </summary>
        /// <value>The smoothing.</value>
        public SmoothingMode Smoothing
        {
            get { return smoothing; }
            set
            {
                if (value == SmoothingMode.Invalid)
                {
                    value = SmoothingMode.HighQuality;
                    Invalidate();
                }
                smoothing = value;
                Invalidate();
            }
        }

        #endregion

        #region TextRenderingHint

        #region Add it to OnPaint / Graphics Rendering component

        //e.Graphics.TextRenderingHint = textrendering;
        #endregion

        /// <summary>
        /// The textrendering
        /// </summary>
        TextRenderingHint textrendering = TextRenderingHint.SystemDefault;

        /// <summary>
        /// Gets or sets the text rendering.
        /// </summary>
        /// <value>The text rendering.</value>
        public TextRenderingHint TextRendering
        {
            get { return textrendering; }
            set
            {
                textrendering = value;
                Invalidate();
            }
        }



        #endregion

        #region Interpolation Mode

        /// <summary>
        /// The interpolation mode
        /// </summary>
        private InterpolationMode interpolationMode = InterpolationMode.HighQualityBicubic;

        /// <summary>
        /// Gets or sets the interpolation mode.
        /// </summary>
        /// <value>The interpolation mode.</value>
        public InterpolationMode InterpolationMode
        {
            get { return interpolationMode; }
            set
            {
                interpolationMode = value;
                Invalidate();
            }
        }

        #endregion

        #region Pixel Offset
        /// <summary>
        /// The pixel offset mode
        /// </summary>
        private PixelOffsetMode pixelOffsetMode = PixelOffsetMode.None;

        /// <summary>
        /// Gets or sets the pixel offset mode.
        /// </summary>
        /// <value>The pixel offset mode.</value>
        public PixelOffsetMode PixelOffsetMode
        {
            get { return pixelOffsetMode; }
            set
            {
                pixelOffsetMode = value;
                Invalidate();
            }
        }
        #endregion

        /// <summary>
        /// Gets or sets the upper left curve.
        /// </summary>
        /// <value>The upper left curve.</value>
        public int UpperLeftCurve
        {
            get { return upperLeftCurve; }
            set
            {
                upperLeftCurve = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the upper right curve.
        /// </summary>
        /// <value>The upper right curve.</value>
        public int UpperRightCurve
        {
            get { return upperRightCurve; }
            set
            {
                upperRightCurve = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets down left curve.
        /// </summary>
        /// <value>Down left curve.</value>
        public int DownLeftCurve
        {
            get { return downLeftCurve; }
            set
            {
                downLeftCurve = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets down right curve.
        /// </summary>
        /// <value>Down right curve.</value>
        public int DownRightCurve
        {
            get { return downRightCurve; }
            set
            {
                downRightCurve = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom booster colors.
        /// </summary>
        /// <value>The custom booster colors.</value>
        public Color[] CustomBoosterColors
        {
            get { return customBoosterColors; }
            set { customBoosterColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom booster gradient angle.
        /// </summary>
        /// <value>The custom booster gradient angle.</value>
        public float CustomBoosterGradientAngle
        {
            get { return customGradientAngle; }
            set
            {
                customGradientAngle = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom booster outer border.
        /// </summary>
        /// <value>The custom booster outer border.</value>
        public Color CustomBoosterOuterBorder
        {
            get { return customBoosterOuterBorder; }
            set { customBoosterOuterBorder = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom booster inner border.
        /// </summary>
        /// <value>The custom booster inner border.</value>
        public Color CustomBoosterInnerBorder
        {
            get { return customBoosterInnerBorder; }
            set { customBoosterInnerBorder = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom booster offset.
        /// </summary>
        /// <value>The custom booster offset.</value>
        public int CustomBoosterOffset
        {
            get { return customBoosterOffset; }
            set
            {
                customBoosterOffset = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom booster hover transparency.
        /// </summary>
        /// <value>The custom booster hover transparency.</value>
        public float CustomBoosterHoverTransparency
        {
            get { return customBoosterHoverTransparency; }
            set
            {
                customBoosterHoverTransparency = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom booster hatch colors.
        /// </summary>
        /// <value>The custom booster hatch colors.</value>
        public Color[] CustomBoosterHatchColors
        {
            get { return customBoosterHatchColors; }
            set
            {
                customBoosterHatchColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [custom booster influence outer].
        /// </summary>
        /// <value><c>true</c> if [custom booster influence outer]; otherwise, <c>false</c>.</value>
        public bool CustomBoosterInfluenceOuter
        {
            get { return customBoosterInfluenceOuter; }
            set
            {
                customBoosterInfluenceOuter = value;
                Invalidate();
            }
        }


        /// <summary>
        /// Gets or sets the hatch style.
        /// </summary>
        /// <value>The hatch style.</value>
        public HatchStyle HatchStyle
        {
            get { return hatchStyle; }
            set { hatchStyle = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the draw mode.
        /// </summary>
        /// <value>The draw mode.</value>
        public RenderMode DrawMode
        {
            get { return drawMode; }
            set { drawMode = value;
                Invalidate();
            }
        }

        #endregion

        #region Paint

        /// <summary>
        /// Customs the booster paint hook.
        /// </summary>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// </exception>
        private void CustomBoosterPaintHook()
        {
            G.SmoothingMode = Smoothing;
            G.TextRenderingHint = TextRendering;
            G.PixelOffsetMode = PixelOffsetMode;
            G.InterpolationMode = InterpolationMode;

            G.Clear(Parent.BackColor);
            GraphicsPath roundedRect = Helper.RoundRect(new Rectangle(0, 0, Width - 2, Height - 2), UpperLeftCurve, UpperRightCurve, DownLeftCurve, DownRightCurve);
            //HatchBrush hatchbrush = new HatchBrush(HatchStyle, CustomBoosterHatchColors[0], CustomBoosterHatchColors[1]);
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

                #region Does the trick

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

        /// <summary>
        /// Customs the booster on mouse enter.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Customs the booster enter animation.
        /// </summary>
        private void CustomBoosterEnterAnimation()
        {

            for (int fade = 0; fade <= 50; fade += 10)
            {
                Thread.Sleep(10);
                CustomBoosterHoverTransparency = fade;
            }
        }

        #endregion

        #region Addition

        /// <summary>
        /// The state
        /// </summary>
        MouseState State = MouseState.None;


        /// <summary>
        /// Colors the hook.
        /// </summary>
        protected override void ColorHook()
        {

        }

        /// <summary>
        /// Paints the hook.
        /// </summary>
        /// <param name="e">The <see cref="PaintEventArgs"/> instance containing the event data.</param>
        protected override void PaintHook(PaintEventArgs e)
        {
            CustomBoosterPaintHook();
        }


        /// <summary>
        /// Handles the <see cref="E:MouseEnter" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            State = MouseState.Over;
            CustomBoosterOnMouseEnter(e);
            Invalidate();
        }

        /// <summary>
        /// Handles the <see cref="E:MouseUp" /> event.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            State = MouseState.Over;

            Invalidate();

        }

        /// <summary>
        /// Handles the <see cref="E:MouseDown" /> event.
        /// </summary>
        /// <param name="e">The <see cref="MouseEventArgs"/> instance containing the event data.</param>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            State = MouseState.Down;

            Invalidate();

        }

        /// <summary>
        /// Handles the <see cref="E:MouseLeave" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            State = MouseState.None;

            Invalidate();
        }

        /// <summary>
        /// Handles the <see cref="E:EnabledChanged" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected override void OnEnabledChanged(EventArgs e)
        {

        }

        /// <summary>
        /// Paints the background of the control.
        /// </summary>
        /// <param name="pevent">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains information about the control to paint.</param>
        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs pevent)
        {
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.TextChanged" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnTextChanged(System.EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();

        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Resize" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnResize(EventArgs e)
        {

        }

        /// <summary>
        /// Called when [animation].
        /// </summary>
        protected override void OnAnimation()
        {
            base.OnAnimation();

            CustomBoosterEnterAnimation();
        }


        #endregion

    }

}
