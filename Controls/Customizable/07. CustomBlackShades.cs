// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="07. CustomBlackShades.cs" company="Zeroit Dev Technologies">
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
        //int Curve = 3;

        //private Color[] customBlackShadesNoneColors = new Color[]
        //{
        //    Color.FromArgb(32, 36, 38),
        //    Color.FromArgb(70, Color.White),
        //    Color.Transparent,
        //    Color.FromArgb(36, 31, 43),
        //    Color.FromArgb(61, 65, 68),
        //    Color.FromArgb(99, 103, 105),
        //    Color.FromArgb(27, 31, 33)
        //};

        //private Color[] customBlackShadesOverColors = new Color[]
        //{
        //    Color.FromArgb(32, 36, 38),
        //    Color.FromArgb(70, Color.White),
        //    Color.Transparent,
        //    Color.FromArgb(36, 31, 43),
        //    Color.FromArgb(61, 65, 68),
        //    Color.FromArgb(99, 103, 105),
        //    Color.FromArgb(100, 99, 103, 105),
        //    Color.FromArgb(27, 31, 33),
        //    Color.FromArgb(0, 186, 255)
        //};

        //private Color[] customBlackShadesDownColors = new Color[]
        //{
        //    Color.FromArgb(32, 36, 38),
        //    Color.FromArgb(32, 36, 38),
        //    Color.FromArgb(57, 57, 57),
        //    Color.FromArgb(57, 57, 57),
        //    Color.FromArgb(32, 36, 38),
        //    Color.FromArgb(57, 57, 57),
        //    Color.FromArgb(36, 31, 43),
        //    Color.FromArgb(61, 65, 68),
        //    Color.FromArgb(27, 31, 33)

        //};
        #endregion

        #region Public Properties
        [Browsable(false)]
        public Color[] CustomBlackShadesNoneColors
        {
            get { return buttonInput.CustomBlackShadesNoneColors; }
            set
            {
                buttonInput.CustomBlackShadesNoneColors = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] CustomBlackShadesOverColors
        {
            get { return buttonInput.CustomBlackShadesOverColors; }
            set { buttonInput.CustomBlackShadesOverColors = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color[] CustomBlackShadesDownColors
        {
            get { return buttonInput.CustomBlackShadesDownColors; }
            set { buttonInput.CustomBlackShadesDownColors = value; Invalidate(); }
        }

        //public int CustomBlackShadesCurve
        //{
        //    get { return Curve; }
        //    set
        //    {
        //        Curve = value;
        //        Invalidate();
        //    }
        //}
        #endregion

        #region Paint
        private void CustomBlackShadesPaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);

            dynamic ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);

            G.Clear(Parent.BackColor);
            //Dim bg As Color = Parent.FindForm.BackColor

            //G.Clear(Color.FromArgb(42, 47, 49));

            switch (State)
            {
                case MouseState.None:
                    //Mouse None
                    G.FillPath(new SolidBrush(CustomBlackShadesNoneColors[0]), Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 2), Curve));
                    LinearGradientBrush gloss = new LinearGradientBrush(new Rectangle(1, 1, Width - 5, Height / 2 - 3), CustomBlackShadesNoneColors[1], CustomBlackShadesNoneColors[2], 90);
                    G.FillPath(gloss, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height / 2 - 3), Curve));
                    LinearGradientBrush borderRect = new LinearGradientBrush(ClientRectangle, CustomBlackShadesNoneColors[3], CustomBlackShadesNoneColors[4], 90);
                    G.DrawPath(new Pen(CustomBlackShadesNoneColors[5]), Draw.RoundRect(new Rectangle(0, 1, Width - 1, Height - 3), Curve));
                    G.DrawPath(new Pen(borderRect), Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 2), Curve));
                    G.DrawPath(new Pen(CustomBlackShadesNoneColors[6]), Draw.RoundRect(new Rectangle(1, 0, Width - 3, Height - 3), Curve));
                    break;
                case MouseState.Over:
                    //Mouse Hover
                    G.FillPath(new SolidBrush(CustomBlackShadesOverColors[0]), Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 2), Curve));
                    LinearGradientBrush gloss1 = new LinearGradientBrush(new Rectangle(1, 1, Width - 5, Height / 2 - 3), CustomBlackShadesOverColors[1], CustomBlackShadesOverColors[2], 90);
                    G.FillPath(gloss1, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height / 2 - 3), Curve));
                    LinearGradientBrush borderRect1 = new LinearGradientBrush(ClientRectangle, CustomBlackShadesOverColors[3], CustomBlackShadesOverColors[4], 90);
                    G.DrawPath(new Pen(CustomBlackShadesOverColors[5]), Draw.RoundRect(new Rectangle(0, 1, Width - 1, Height - 3), Curve));
                    G.DrawPath(new Pen(CustomBlackShadesOverColors[6]), Draw.RoundRect(new Rectangle(2, 2, Width - 5, Height - 6), Curve));
                    G.DrawPath(new Pen(borderRect1), Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 2), Curve));
                    G.DrawPath(new Pen(CustomBlackShadesOverColors[7]), Draw.RoundRect(new Rectangle(1, 0, Width - 3, Height - 3), Curve));
                    G.DrawPath(new Pen(CustomBlackShadesOverColors[8]), Draw.RoundRect(new Rectangle(1, 1, Width - 3, Height - 4), Curve));
                    break;
                case MouseState.Down:
                    //Mouse Down
                    G.FillPath(new SolidBrush(CustomBlackShadesDownColors[0]), Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 2), Curve));
                    LinearGradientBrush topGrad = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height / 2 - 1), CustomBlackShadesDownColors[1], CustomBlackShadesDownColors[2], 90);
                    G.FillPath(topGrad, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height / 2 + 1), Curve));
                    LinearGradientBrush botGrad = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height / 2 - 1), CustomBlackShadesDownColors[3], CustomBlackShadesDownColors[4], 90);
                    G.FillPath(botGrad, Draw.RoundRect(new Rectangle(0, Height / 2 - 1, Width - 1, Height / 2 + 2), Curve));
                    G.DrawLine(new Pen(CustomBlackShadesDownColors[5]), 0, Convert.ToInt32(Height / 2 - 1), Width - 1, Convert.ToInt32(Height / 2 - 1));

                    LinearGradientBrush borderRect2 = new LinearGradientBrush(ClientRectangle, CustomBlackShadesDownColors[6], CustomBlackShadesDownColors[7], 90);
                    G.DrawPath(new Pen(borderRect2), Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 2), Curve));
                    G.DrawPath(new Pen(CustomBlackShadesDownColors[8]), Draw.RoundRect(new Rectangle(1, 0, Width - 3, Height - 3), Curve));

                    break;
            }

            //G.DrawRectangle(Pens.Black, ClientRectangle)

            //G.DrawString(Text, Font, Brushes.Black, New Rectangle(-1, -2, Width - 1, Height - 1), New StringFormat With {.LineAlignment = StringAlignment.Center, .Alignment = StringAlignment.Center})
            //G.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(-1, -1, Width - 1, Height - 1), new StringFormat
            //{
            //    LineAlignment = StringAlignment.Center,
            //    Alignment = StringAlignment.Center
            //});

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);

        }

        #endregion

    }


}
