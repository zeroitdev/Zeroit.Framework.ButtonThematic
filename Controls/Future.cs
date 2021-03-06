﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Future.cs" company="Zeroit Dev Technologies">
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
using System.Drawing;
using System.Drawing.Drawing2D;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        
        private ColorBlend fusionBlend = new ColorBlend
        {
            Colors = new Color[]
            {
                Color.FromArgb(28, 28, 28),
                Color.FromArgb(32, 32, 32),
                Color.FromArgb(24, 24, 24),
            },
            Positions = new float[] {
                0f,
                0.5f,
                1f
            }
        };

        private Color futureC1 = Color.FromArgb(40, 40, 40);
        private Color futureC2 = Color.FromArgb(48, 48, 48);
        private Color futureC3 = Color.FromArgb(40, 40, 40);
        private Color futureP2 = Color.Black;
        private Color futureP3 = Color.FromArgb(24, 24, 24);
        private Color futureP4 = Color.FromArgb(44, 44, 44);
        private Color futureB1 = Color.Black;
        private Color futureB2 = Color.White;

        
        
        private void FuturePaintHook()
        {
            DrawGradient(fusionBlend, ClientRectangle, 90f);

            LinearGradientBrush GB1 = new LinearGradientBrush(ClientRectangle, futureC1, futureC2, 90f);
            Pen P1 = new Pen(GB1);

            DrawBorders(P1);
            DrawBorders(new Pen(futureP2), 1);

            if (State == MouseState.Down)
            {
                DrawBorders(new Pen(futureP3), 2);

                //DrawText(new SolidBrush(futureB1), HorizontalAlignment.Center, 2, 2);
                //DrawText(new SolidBrush(futureB2), HorizontalAlignment.Center, 1, 1);
            }
            else
            {
                G.DrawLine(new Pen(futureP4), 2, 2, Width - 3, 2);

                //DrawText(new SolidBrush(futureB1), HorizontalAlignment.Center, 1, 1);
                //DrawText(new SolidBrush(futureB2), HorizontalAlignment.Center, 0, 0);
            }

            DrawCorners(futureC3, 1, 1, Width - 2, Height - 2);
            DrawCorners(Parent.BackColor);
        }


    }

}

