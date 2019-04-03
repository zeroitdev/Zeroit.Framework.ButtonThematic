// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="09. CustomClassic.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        #region Private Fields
        //private Color customClassicBorder = Color.Black;
        //private Color customClassicHighlight = Color.FromArgb(35, 35, 35);
        //private Color customClassicBackground = Color.FromArgb(24, 24, 24);
        //private Color customClassicShadow = Color.FromArgb(100, Color.Black);

        //private Color[] customClassicColors = new Color[]
        //{
        //    Color.FromArgb(0, 156, 255),
        //    Color.Transparent
        //};
        #endregion

        #region Public Properties
        [Browsable(false)]
        public Color CustomClassicBorder
        {
            get { return buttonInput.CustomClassicBorder; }
            set
            {
                buttonInput.CustomClassicBorder = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color CustomClassicHighlight
        {
            get { return buttonInput.CustomClassicHighlight; }
            set { buttonInput.CustomClassicHighlight = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomClassicBackground
        {
            get { return buttonInput.CustomClassicBackground; }
            set { buttonInput.CustomClassicBackground = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomClassicShadow
        {
            get { return buttonInput.CustomClassicShadow; }
            set { buttonInput.CustomClassicShadow = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color[] CustomClassicColors
        {
            get { return buttonInput.CustomClassicColors; }
            set
            {
                buttonInput.CustomClassicColors = value;
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
            DrawBorders(new Pen(CustomClassicBorder), ClientRectangle);
            DrawBorders(new Pen(CustomClassicHighlight), 1, 1, Width - 2, Height - 2);

            switch (State)
            {
                case MouseState.Over:
                    L1 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(100, CustomClassicColors[0]), CustomClassicColors[1], 270);
                    soliBrush = new SolidBrush(Color.FromArgb(100, CustomClassicColors[0]));

                    switch (DrawMode)
                    {
                        case RenderMode.Solid:
                            G.FillRectangle(soliBrush, R1);
                            G.FillRectangle(new SolidBrush(CustomClassicShadow), 1, 7, Width - 2, Height - 7);
                            break;
                        case RenderMode.Gradient:
                            G.FillRectangle(L1, R1);
                            G.FillRectangle(new SolidBrush(CustomClassicShadow), 1, 7, Width - 2, Height - 7);
                            break;
                        case RenderMode.Hatch:
                            hatchBrush = new HatchBrush(HatchStyle, Color.FromArgb(100, CustomClassicColors[0]),
                                CustomClassicColors[1]);
                            G.FillRectangle(hatchBrush, R1);
                            G.FillRectangle(new SolidBrush(CustomClassicShadow), 1, 7, Width - 2, Height - 7);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    break;
                case MouseState.Down:
                    L1 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(50, CustomClassicColors[0]), CustomClassicColors[1], 90);
                    soliBrush = new SolidBrush(Color.FromArgb(50, CustomClassicColors[0]));

                    switch (DrawMode)
                    {
                        case RenderMode.Solid:
                            G.FillRectangle(soliBrush, R1);
                            G.FillRectangle(new SolidBrush(CustomClassicShadow), 1, 7, Width - 2, Height - 7);

                            break;
                        case RenderMode.Gradient:
                            G.FillRectangle(L1, R1);
                            G.FillRectangle(new SolidBrush(CustomClassicShadow), 1, 7, Width - 2, Height - 7);

                            break;
                        case RenderMode.Hatch:
                            hatchBrush = new HatchBrush(HatchStyle, Color.FromArgb(50, CustomClassicColors[0]),
                                CustomClassicColors[1]);
                            G.FillRectangle(hatchBrush, R1);
                            G.FillRectangle(new SolidBrush(CustomClassicShadow), 1, 7, Width - 2, Height - 7);

                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    break;
                case MouseState.None:

                    switch (DrawMode)
                    {
                        case RenderMode.Solid:
                            G.FillRectangle(new SolidBrush(CustomClassicBackground), ClientRectangle);
                            G.FillRectangle(new SolidBrush(CustomClassicShadow), 1, 8, Width - 2, Height - 8);
                            break;
                        case RenderMode.Gradient:
                            L1 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(255, CustomClassicBackground), CustomClassicBackground, 90);

                            G.FillRectangle(L1, ClientRectangle);
                            G.FillRectangle(new SolidBrush(CustomClassicShadow), 1, 8, Width - 2, Height - 8);
                            break;
                        case RenderMode.Hatch:
                            hatchBrush = new HatchBrush(HatchStyle, CustomClassicBackground, Color.FromArgb(25, CustomClassicBackground));
                            G.FillRectangle(hatchBrush, ClientRectangle);
                            G.FillRectangle(new SolidBrush(CustomClassicShadow), 1, 8, Width - 2, Height - 8);
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

