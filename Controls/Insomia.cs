﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Insomia.cs" company="Zeroit Dev Technologies">
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

        private Color insomiaC1 = Color.White;
        private Color insomiaP1 = Color.FromArgb(50, 50, 50);
        

        private void InsomiaPaintHook()
        {
            G.Clear(Parent.BackColor);
            if ((State == MouseState.Over))
            {
                DrawGradient(Color.FromArgb(30, 30, 30), Color.FromArgb(50, 50, 50), 0, 0, Width, Height);
            }
            else if ((State == MouseState.Down))
            {
                DrawGradient(Color.FromArgb(118, 118, 118), Color.FromArgb(110, 110, 110), 0, 0, Width, Height);
            }
            else
            {
                DrawGradient(Color.FromArgb(50, 50, 50), Color.FromArgb(30, 30, 30), 0, 0, Width, Height);
            }
            DrawBorders(new Pen(insomiaP1), ClientRectangle);
            //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);

        }

    }

}

