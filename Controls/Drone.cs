// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Drone.cs" company="Zeroit Dev Technologies">
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
        

        private void DronePaintHook()
        {
            DrawBorders(new Pen(Color.FromArgb(32, 32, 32)), 1);
            G.FillRectangle(new SolidBrush(Color.FromArgb(62, 62, 62)), 0, 0, Width, 8);
            DrawBorders(Pens.Black, 2);
            DrawBorders(Pens.Black);

            if (State == MouseState.Over)
            {
                G.FillRectangle(new SolidBrush(Color.FromArgb(0, 55, 90)), 3, 3, Width - 6, Height - 6);
                DrawBorders(new Pen(Color.FromArgb(0, 66, 108)), 3);
            }
            else if (State == MouseState.Down)
            {
                G.FillRectangle(new SolidBrush(Color.FromArgb(0, 44, 72)), 3, 3, Width - 6, Height - 6);
                DrawBorders(new Pen(Color.FromArgb(0, 55, 90)), 3);
            }
            else
            {
                G.FillRectangle(new SolidBrush(Color.FromArgb(24, 24, 24)), 3, 3, Width - 6, Height - 6);
                DrawBorders(new Pen(Color.FromArgb(38, 38, 38)), 3);
            }

            G.FillRectangle(new SolidBrush(Color.FromArgb(13, Color.White)), 3, 3, Width - 6, 8);

            if (State == MouseState.Down)
            {
                //DrawText(Brushes.White, HorizontalAlignment.Center, 1, 1);
            }
            else
            {
                //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
            }

        }

    }

}

