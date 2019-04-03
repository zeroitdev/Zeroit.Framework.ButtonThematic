﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="xVisual.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        public enum xVisualInnerShade
        {
            Light,
            Dark
        }
        private xVisualInnerShade xVisualShade = xVisualInnerShade.Dark;

        [Browsable(false)]
        public xVisualInnerShade XVisualShade
        {
            get { return xVisualShade; }
            set
            {
                xVisualShade = value;
                Invalidate();
            }
        }

        
        TextureBrush xVisualInnerTexture = Draw.NoiseBrush(new Color[]{
        Color.FromArgb(52, 48, 44),
        Color.FromArgb(54, 50, 46),
        Color.FromArgb(50, 46, 42)
        });


        private void XVisualPaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle ClientRectangle = new Rectangle(3, 3, Width - 7, Height - 7);

            G.Clear(Parent.BackColor);

            switch (xVisualShade)
            {
                case xVisualInnerShade.Dark:

                    G.FillPath(xVisualInnerTexture, Draw.CreateRound(ClientRectangle, 3));

                    G.DrawPath(Draw.GetPen(Color.FromArgb(40, 38, 36)), Draw.CreateRound(new Rectangle(3, 3, Width - 6, Height - 6), 3));
                    G.DrawPath(Draw.GetPen(Color.FromArgb(45, 43, 41)), Draw.CreateRound(new Rectangle(3, 3, Width - 6, Height - 5), 3));
                    G.DrawPath(Draw.GetPen(Color.FromArgb(50, 48, 46)), Draw.CreateRound(new Rectangle(2, 2, Width - 5, Height - 3), 3));

                    LinearGradientBrush HighlightGradient = new LinearGradientBrush(new Rectangle(4, 4, Width - 8, Height - 8), Color.FromArgb(160, 158, 157), Color.FromArgb(61, 57, 54), 90);
                    Pen hp = new Pen(HighlightGradient);
                    G.DrawPath(hp, Draw.CreateRound(new Rectangle(4, 4, Width - 9, Height - 9), 3));

                    LinearGradientBrush OutlineGradient = new LinearGradientBrush(new Rectangle(3, 3, Width - 7, Height - 6), Color.FromArgb(34, 32, 30), Color.Black, 90);
                    Pen op = new Pen(OutlineGradient);
                    G.DrawPath(op, Draw.CreateRound(new Rectangle(3, 3, Width - 7, Height - 7), 3));

                    Font drawFont = new Font("Arial", 9, FontStyle.Bold);
                    //switch (State)
                    //{
                    //    case MouseState.None:
                    //        G.DrawString(Text, drawFont, Brushes.White, new Rectangle(0, 0, Width - 1, Height - 1), new StringFormat
                    //        {
                    //            Alignment = StringAlignment.Center,
                    //            LineAlignment = StringAlignment.Center
                    //        });
                    //        break;
                    //    case MouseState.Over:
                    //        G.DrawString(Text, drawFont, Brushes.White, new Rectangle(0, 0, Width - 1, Height - 1), new StringFormat
                    //        {
                    //            Alignment = StringAlignment.Center,
                    //            LineAlignment = StringAlignment.Center
                    //        });
                    //        break;
                    //    case MouseState.Down:
                    //        G.DrawString(Text, drawFont, Brushes.White, new Rectangle(0, 0, Width - 1, Height - 1), new StringFormat
                    //        {
                    //            Alignment = StringAlignment.Center,
                    //            LineAlignment = StringAlignment.Center
                    //        });
                    //        break;
                    //}

                    break;
                case xVisualInnerShade.Light:

                    LinearGradientBrush MainGradient = new LinearGradientBrush(ClientRectangle, Color.FromArgb(225, 227, 230), Color.FromArgb(199, 201, 204), 90);
                    G.FillPath(MainGradient, Draw.CreateRound(ClientRectangle, 3));

                    G.DrawPath(Draw.GetPen(Color.FromArgb(167, 168, 171)), Draw.CreateRound(new Rectangle(3, 3, Width - 6, Height - 6), 3));
                    G.DrawPath(Draw.GetPen(Color.FromArgb(203, 205, 208)), Draw.CreateRound(new Rectangle(2, 2, Width - 5, Height - 4), 3));

                    LinearGradientBrush HighlightGradient1 = new LinearGradientBrush(new Rectangle(4, 4, Width - 8, Height - 8), Color.FromArgb(255, 255, 255), Color.FromArgb(218, 219, 222), 90);
                    Pen hp1 = new Pen(HighlightGradient1);
                    G.DrawPath(hp1, Draw.CreateRound(new Rectangle(4, 4, Width - 9, Height - 9), 3));

                    LinearGradientBrush OutlineGradient1 = new LinearGradientBrush(new Rectangle(3, 3, Width - 7, Height - 6), Color.FromArgb(173, 174, 177), Color.FromArgb(110, 111, 114), 90);
                    Pen op1 = new Pen(OutlineGradient1);
                    G.DrawPath(op1, Draw.CreateRound(new Rectangle(3, 3, Width - 7, Height - 7), 3));

                    Font drawFont1 = new Font("Arial", 9, FontStyle.Bold);
                    //switch (State)
                    //{
                    //    case MouseState.None:
                    //        G.DrawString(Text, drawFont1, Draw.GetBrush(Color.FromArgb(109, 109, 110)), new Rectangle(0, 0, Width - 1, Height - 1), new StringFormat
                    //        {
                    //            Alignment = StringAlignment.Center,
                    //            LineAlignment = StringAlignment.Center
                    //        });
                    //        break;
                    //    case MouseState.Over:
                    //        G.DrawString(Text, drawFont1, Draw.GetBrush(Color.FromArgb(109, 109, 110)), new Rectangle(0, 0, Width - 1, Height - 1), new StringFormat
                    //        {
                    //            Alignment = StringAlignment.Center,
                    //            LineAlignment = StringAlignment.Center
                    //        });
                    //        break;
                    //    case MouseState.Down:
                    //        G.DrawString(Text, drawFont1, Draw.GetBrush(Color.FromArgb(109, 109, 110)), new Rectangle(0, 0, Width - 1, Height - 1), new StringFormat
                    //        {
                    //            Alignment = StringAlignment.Center,
                    //            LineAlignment = StringAlignment.Center
                    //        });
                    //        break;
                    //}

                    break;
            }


            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            //G.Dispose();
            //B.Dispose();
        }

    }

}
