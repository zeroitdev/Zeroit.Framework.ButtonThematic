﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="VTheme.cs" company="Zeroit Dev Technologies">
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

        private void VThemePaintHook()
        {
            G.Clear(Parent.BackColor);
            DrawBorders(new Pen(Color.FromArgb(16, 16, 16)), 1);
            G.FillRectangle(new SolidBrush(Color.FromArgb(5, 5, 5)), 0, 0, Width, 8);
            DrawBorders(Pens.Black, 3);
            DrawBorders(new Pen(Color.FromArgb(24, 24, 24)));

            if (State == MouseState.Over)
            {
                G.FillRectangle(new SolidBrush(Color.FromArgb(25, 25, 25)), 3, 3, Width - 6, Height - 6);
                DrawBorders(new Pen(Color.FromArgb(0, 0, 0)), 2);
            }
            else if (State == MouseState.Down)
            {
                G.FillRectangle(new LinearGradientBrush(new Rectangle(3, 3, Width - 6, Height - 6), Color.FromArgb(12, 12, 12), Color.FromArgb(30, 30, 30), LinearGradientMode.BackwardDiagonal), 3, 3, Width - 6, Height - 6);
                DrawBorders(new Pen(Color.FromArgb(0, 0, 0)), 2);
            }
            else
            {
                G.FillRectangle(new LinearGradientBrush(new Rectangle(3, 3, Width - 6, Height - 6), Color.FromArgb(9, 9, 9), Color.FromArgb(18, 18, 18), LinearGradientMode.Vertical), 3, 3, Width - 6, Height - 6);
                DrawBorders(new Pen(Color.FromArgb(32, 32, 32)), 2);
            }
            if (State == MouseState.Down)
            {
                //DrawText(Brushes.White, HorizontalAlignment.Center, 2, 2);
            }
            else
            {
                //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
            }
        }
    }

}

