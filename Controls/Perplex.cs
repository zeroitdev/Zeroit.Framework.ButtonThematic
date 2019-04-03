﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Perplex.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {
        private void PerplexPaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);


            G.Clear(BackColor);
            Font drawFont = new Font("Tahoma", 8, FontStyle.Bold);

            //G.CompositingQuality = CompositingQuality.HighQuality
            //G.SmoothingMode = SmoothingMode.HighQuality;

            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush lgb = new LinearGradientBrush(ClientRectangle, Color.FromArgb(66, 67, 70), Color.FromArgb(43, 44, 48), 90);
                    G.FillPath(lgb, Draw.RoundRect(ClientRectangle, 2));
                    LinearGradientBrush gloss = new LinearGradientBrush(new Rectangle(0, 0, Width - 125, 35 / 2), Color.FromArgb(75, Color.FromArgb(26, 26, 26)), Color.FromArgb(3, 255, 255, 255), 90);
                    G.FillPath(gloss, Draw.RoundRect(ClientRectangle, 2));

                    LinearGradientBrush botbar = new LinearGradientBrush(new Rectangle(5, Height - 10, Width - 11, 5), Color.FromArgb(44, 45, 49), Color.FromArgb(45, 46, 50), 90);
                    G.FillPath(botbar, Draw.RoundRect(new Rectangle(5, Height - 10, Width - 11, 5), 1));

                    LinearGradientBrush fill = new LinearGradientBrush(new Rectangle(6, Height - 9, Width - 13, 3), Color.FromArgb(174, 195, 30), Color.FromArgb(141, 153, 16), 90);
                    G.FillPath(fill, Draw.RoundRect(new Rectangle(6, Height - 9, Width - 13, 3), 1));
                    Pen o = new Pen(Color.FromArgb(50, 50, 50), 1);
                    G.DrawPath(o, Draw.RoundRect(ClientRectangle, 2));
                    G.DrawPath(Pens.Black, Draw.RoundRect(new Rectangle(1, 1, Width - 3, Height - 3), 2));
                    break;
                case MouseState.Over:
                    LinearGradientBrush lgb1 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(66, 67, 70), Color.FromArgb(43, 44, 48), 90);
                    G.FillPath(lgb1, Draw.RoundRect(ClientRectangle, 2));
                    LinearGradientBrush gloss1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 125, 35 / 2), Color.FromArgb(15, Color.FromArgb(26, 26, 26)), Color.FromArgb(1, 255, 255, 255), 90);
                    G.FillPath(gloss1, Draw.RoundRect(ClientRectangle, 2));

                    LinearGradientBrush botbar1 = new LinearGradientBrush(new Rectangle(5, Height - 10, Width - 11, 5), Color.FromArgb(44, 45, 49), Color.FromArgb(45, 46, 50), 90);
                    G.FillPath(botbar1, Draw.RoundRect(new Rectangle(5, Height - 10, Width - 11, 5), 1));

                    LinearGradientBrush fill1 = new LinearGradientBrush(new Rectangle(6, Height - 9, Width - 13, 3), Color.FromArgb(174, 195, 30), Color.FromArgb(141, 153, 16), 90);
                    G.FillPath(fill1, Draw.RoundRect(new Rectangle(6, Height - 9, Width - 13, 3), 1));
                    Pen o1 = new Pen(Color.FromArgb(50, 50, 50), 1);
                    G.DrawPath(o1, Draw.RoundRect(ClientRectangle, 2));
                    G.DrawPath(Pens.Black, Draw.RoundRect(new Rectangle(1, 1, Width - 3, Height - 3), 2));
                    break;
                case MouseState.Down:
                    LinearGradientBrush lgb2 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(66, 67, 70), Color.FromArgb(43, 44, 48), 90);
                    G.FillPath(lgb2, Draw.RoundRect(ClientRectangle, 2));
                    LinearGradientBrush gloss2 = new LinearGradientBrush(new Rectangle(0, 0, Width - 125, 35 / 2), Color.FromArgb(100, Color.FromArgb(26, 26, 26)), Color.FromArgb(1, 255, 255, 255), 90);
                    G.FillPath(gloss2, Draw.RoundRect(ClientRectangle, 2));

                    LinearGradientBrush botbar2 = new LinearGradientBrush(new Rectangle(5, Height - 10, Width - 11, 5), Color.FromArgb(44, 45, 49), Color.FromArgb(45, 46, 50), 90);
                    G.FillPath(botbar2, Draw.RoundRect(new Rectangle(5, Height - 10, Width - 11, 5), 1));

                    LinearGradientBrush fill2 = new LinearGradientBrush(new Rectangle(6, Height - 9, Width - 13, 3), Color.FromArgb(174, 195, 30), Color.FromArgb(141, 153, 16), 90);
                    G.FillPath(fill2, Draw.RoundRect(new Rectangle(6, Height - 9, Width - 13, 3), 1));
                    Pen o2 = new Pen(Color.FromArgb(50, 50, 50), 1);
                    G.DrawPath(o2, Draw.RoundRect(ClientRectangle, 2));
                    G.DrawPath(Pens.Black, Draw.RoundRect(new Rectangle(1, 1, Width - 3, Height - 3), 2));
                    break;
            }

            //G.DrawString(Text, drawFont, new SolidBrush(Color.FromArgb(5, 5, 5)), new Rectangle(1, 0, Width - 1, Height - 1), new StringFormat
            //{
            //    Alignment = StringAlignment.Center,
            //    LineAlignment = StringAlignment.Center
            //});
            //G.DrawString(Text, drawFont, new SolidBrush(Color.FromArgb(205, 205, 205)), new Rectangle(0, -1, Width - 1, Height - 1), new StringFormat
            //{
            //    Alignment = StringAlignment.Center,
            //    LineAlignment = StringAlignment.Center
            //});

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            //G.Dispose();
            //B.Dispose();
        }

    }

}
