﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Frog.cs" company="Zeroit Dev Technologies">
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

        //protected override void ColorHook()
        //{
        //    SetColor("Border", Color.FromArgb(255, 200, 200, 200));
        //}

        private void FrogPaintHook()
        {
            Color Border = default(Color);
            Border = Color.FromArgb(160, Color.FromArgb(255, 200, 200, 200));

            G.SmoothingMode = SmoothingMode.AntiAlias;
            G.Clear(Color.FromArgb(255, 60, 60, 60));
            LinearGradientBrush LGBNone = new LinearGradientBrush(new Point(0, 0), new Point(0, Height - 1), Color.FromArgb(255, 65, 65, 65), Color.FromArgb(255, 50, 50, 50));
            LinearGradientBrush LGBOver = new LinearGradientBrush(new Point(0, 0), new Point(0, Height - 1), Color.FromArgb(255, 65, 65, 65), Color.FromArgb(255, 40, 40, 40));
            LinearGradientBrush LGBDown = new LinearGradientBrush(new Point(0, 0), new Point(0, Height - 1), Color.FromArgb(255, 65, 65, 65), Color.FromArgb(255, 30, 30, 30));
            Point[] Polygon = null;
            Point[] Polygon2 = null;
            Polygon = new Point[] {
            new Point(0, 0),
            new Point(Width - 1, 0),
            new Point(Width - 1, Height - 7),
            new Point(Width - 2, Height - 6),
            new Point(Width - 3, Height - 5),
            new Point(Width - 4, Height - 4),
            new Point(Width - 5, Height - 3),
            new Point(Width - 6, Height - 2),
            new Point(Width - 7, Height - 1),
            new Point(0, Height - 1)
        };
            Polygon2 = new Point[] {
            new Point(1, 1),
            new Point(Width - 2, 1),
            new Point(Width - 2, Height - 7),
            new Point(Width - 8, Height - 2),
            new Point(1, Height - 2)
        };
            switch (State)
            {
                case MouseState.Down:
                    G.FillPolygon(LGBDown, Polygon);
                    break;
                case MouseState.None:
                    G.FillPolygon(LGBNone, Polygon);
                    break;
                case MouseState.Over:
                    G.FillPolygon(LGBOver, Polygon);
                    break;
            }
            G.DrawPolygon(Pens.Black, Polygon);
            G.DrawPolygon(new Pen(Border), Polygon2);
            //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, -2, 0);
        }

    }

}
