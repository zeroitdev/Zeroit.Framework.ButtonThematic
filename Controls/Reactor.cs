﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Reactor.cs" company="Zeroit Dev Technologies">
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
        
        private void ReactorPaint(System.Windows.Forms.PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(36, 34, 30));

            switch (State)
            {
                case MouseState.None:
                    //Mouse None
                    G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(36, 34, 30))), 2, Height - 1, Width - 4, Height - 1);
                    LinearGradientBrush backGrad = new LinearGradientBrush(new Rectangle(1, 1, Width - 1, Height - 2), Color.FromArgb(10, 9, 8), Color.FromArgb(31, 29, 26), 90);
                    G.FillRectangle(backGrad, new Rectangle(1, 1, Width - 1, Height - 2));
                    G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(46, 45, 44))), new Rectangle(1, 1, Width - 3, Height - 4));
                    break;
                case MouseState.Over:
                    //Mouse Hover
                    G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(46, 44, 38))), 2, Height - 1, Width - 4, Height - 1);
                    LinearGradientBrush backGrad1 = new LinearGradientBrush(new Rectangle(1, 1, Width - 1, Height - 2), Color.FromArgb(219, 78, 0), Color.FromArgb(230, 95, 0), 90);
                    G.FillRectangle(backGrad1, new Rectangle(1, 1, Width - 1, Height - 2));
                    G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(245, 120, 10))), new Rectangle(1, 1, Width - 3, Height - 4));
                    break;
                case MouseState.Down:
                    //Mouse Down
                    G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(36, 34, 30))), 2, Height - 1, Width - 4, Height - 1);
                    LinearGradientBrush backGrad2 = new LinearGradientBrush(new Rectangle(1, 1, Width - 1, Height - 2), Color.FromArgb(209, 68, 0), Color.FromArgb(210, 75, 0), 270);
                    G.FillRectangle(backGrad2, new Rectangle(1, 1, Width - 1, Height - 2));
                    G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(225, 110, 30))), new Rectangle(1, 1, Width - 3, Height - 4));
                    break;
            }

            LinearGradientBrush glossGradient = new LinearGradientBrush(new Rectangle(1, 1, Width - 2, Height / 2 - 2), Color.FromArgb(80, Color.White), Color.FromArgb(50, Color.White), 90);
            G.FillRectangle(glossGradient, new Rectangle(1, 1, Width - 2, Height / 2 - 2));
            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(21, 20, 18))), new Rectangle(0, 0, Width - 1, Height - 2));

            //G.DrawString(Text, Font, Brushes.Black, new Rectangle(0, -2, Width - 1, Height - 1), new StringFormat
            //{
            //    LineAlignment = StringAlignment.Center,
            //    Alignment = StringAlignment.Center
            //});
            //G.DrawString(Text, Font, Brushes.White, new Rectangle(0, -1, Width - 1, Height - 1), new StringFormat
            //{
            //    LineAlignment = StringAlignment.Center,
            //    Alignment = StringAlignment.Center
            //});
        }

    }

}

