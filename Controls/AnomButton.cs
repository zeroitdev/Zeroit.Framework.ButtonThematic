// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="AnomButton.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{
    public partial class ButtonThematic 
    {

        #region Private Fields
        Color anombuttonTop = Color.Beige;
        Color anombuttonBottom = Color.Gainsboro;

        Color anomborder = Color.Black;

        private Color[] anomNone = new Color[]
        {
            Color.FromArgb(255, 222, 222, 222),
            Color.FromArgb(255, 200, 200, 200)
        };

        private Color[] anomDown = new Color[]
        {
            Color.FromArgb(255, 200, 200, 200),
            Color.FromArgb(255, 222, 222, 222)
        };

        private Color[] anomHatchColors = new Color[]
        {
            Color.FromArgb(80, Color.Gray),
            Color.Transparent
        };

        private HatchStyle hatch = HatchStyle.LightDownwardDiagonal; 
        #endregion

        #region Public Properties

        [Browsable(false)]
        public Color AnombuttonTop
        {
            get { return anombuttonTop; }
            set
            {
                anombuttonTop = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color AnombuttonBottom
        {
            get { return anombuttonBottom; }
            set
            {
                anombuttonBottom = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color Anomborder
        {
            get { return anomborder; }
            set
            {
                anomborder = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] AnomNone
        {
            get { return anomNone; }
            set
            {
                anomNone = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] AnomDown
        {
            get { return anomDown; }
            set
            {
                anomDown = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] AnomHatchColors
        {
            get { return anomHatchColors; }
            set { anomHatchColors = value; Invalidate(); }
        }

        //[Browsable(false)]
        //public HatchStyle HatchStyle
        //{
        //    get { return hatch; }
        //    set { hatch = value; Invalidate(); }
        //} 
        #endregion


        private void AnomPaintHook(PaintEventArgs e)
        {
            G.Clear(anombuttonTop);
            LinearGradientBrush LGBNone = new LinearGradientBrush(new Rectangle(1, 1, Width - 2, Height - 2), AnomNone[0], AnomNone[1], 90f);
            LinearGradientBrush LGBDown = new LinearGradientBrush(new Rectangle(1, 1, Width - 2, Height - 2), AnomDown[0], AnomDown[1], 90f);
            G.DrawRectangle(new Pen(anomborder), new Rectangle(0, 0, Width - 1, Height - 1));
            switch (State)
            {
                case MouseState.Over:
                    G.FillRectangle(LGBNone, new Rectangle(1, 1, Width - 2, Height - 2));
                    break;
                case MouseState.None:
                    G.FillRectangle(LGBNone, new Rectangle(1, 1, Width - 2, Height - 2));
                    break;
                case MouseState.Down:
                    G.FillRectangle(LGBDown, new Rectangle(1, 1, Width - 2, Height - 2));
                    break;
            }
            HatchBrush HB = new HatchBrush(HatchStyle, AnomHatchColors[0], AnomHatchColors[1]);
            G.FillRectangle(HB, new Rectangle(1, 1, Width - 2, Height - 2));
            //DrawText(textColor, HorizontalAlignment.Center, 0, 0);
        }

    }

}
