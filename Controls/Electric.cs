// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Electric.cs" company="Zeroit Dev Technologies">
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

        

        Color electricG1 = Color.FromArgb(23, 102, 139);
        Color electricG2 = Color.FromArgb(12, 77, 103);
        Color electricG3 = Color.FromArgb(34, 133, 179);
        Color electricG4 = Color.FromArgb(17, 89, 119);
        Color electricBorder = Color.Black;
        Color electricG5 = Color.FromArgb(28, 107, 144);

        Color electricBacground = Color.Navy;

        private void ElectricPaintHook()
        {
            G.Clear(electricBacground);
            //Temporary, gradient will cover it

            //Draws a gradient depending on the mousestate
            if (State == MouseState.None)
            {
                DrawGradient(electricG1, electricG2, 0, 0, Width, Height, 90);
            }
            else if (State == MouseState.Over)
            {
                DrawGradient(electricG3, electricG5, 0, 0, Width, Height, 90);
            }
            else if (State == MouseState.Down)
            {
                DrawGradient(electricG4, electricG4, 0, 0, Width, Height, 90);
            }

            //DrawText(HorizontalAlignment.Center, ForeColor, 0);
            //Draws the text...
            G.DrawRectangle(new Pen(electricBorder), ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width - 1, ClientRectangle.Height - 1);
            //Border
        }
    }


}

