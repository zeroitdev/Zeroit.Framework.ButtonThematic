﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="SimpleGray.cs" company="Zeroit Dev Technologies">
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
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        Color simpleGr = Color.Gray;
        Color simpleLG = Color.LightGray;
        Color simpleO = Color.FromArgb(244, 244, 244);
        Color simpleD = Color.FromArgb(183, 183, 183);
        Color simpleP = Color.DarkGray;

        Color simplePG = Color.Gray;
        

        private void SimpleGrayPaintHook()
        {
            G.Clear(Color.DarkGray);

            if (State == MouseState.None)
            {
                DrawGradient(simpleLG, simpleGr, 0, 0, Width, Height, 90);
            }
            else if (State == MouseState.Over)
            {
                DrawGradient(simpleO, simpleGr, 0, 0, Width, Height, 90);
            }
            else if (State == MouseState.Down)
            {
                DrawGradient(simpleD, simpleGr, 0, 0, Width, Height, 90);
            }

            //DrawText(HorizontalAlignment.Center, ForeColor, 0);

            DrawBorders(new Pen(simpleP), new Pen(simplePG), ClientRectangle);
            DrawCorners(BackColor, ClientRectangle);
        }

    }

}

