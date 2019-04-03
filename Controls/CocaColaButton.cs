// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="CocaColaButton.cs" company="Zeroit Dev Technologies">
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

        private void CocaColaPaintHook()
        {
            G.Clear(Color.FromArgb(192, 0, 0));
            //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
            DrawBorders(new Pen(new SolidBrush(Color.LightGray)));
            DrawBorders(new Pen(new SolidBrush(Color.RosyBrown)), 1);
            DrawCorners(Color.RosyBrown, ClientRectangle);
            if (State == MouseState.Over)
            {
                DrawBorders(new Pen(new SolidBrush(Color.Goldenrod)));
                DrawBorders(new Pen(new SolidBrush(Color.Goldenrod)), 1);
                //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
            }
            else if (State == MouseState.Down)
            {
                G.Clear(Color.FromArgb(204, 0, 5));
                DrawBorders(new Pen(new SolidBrush(Color.Gold)));
                DrawBorders(new Pen(new SolidBrush(Color.Gold)), 1);
                //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);
            }


        }
    }

}

