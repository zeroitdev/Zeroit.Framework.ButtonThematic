// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Prime.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {
        
        private Color primeC1 = Color.FromArgb(215, 215, 215);
        private Color primeC2 = Color.FromArgb(235, 235, 235);
        private Color primeC3 = Color.FromArgb(235, 235, 235);
        private Color primeC4 = Color.FromArgb(215, 215, 215);
        private Color primeC5 = Color.FromArgb(252, 252, 252);
        private Color primeC6 = Color.FromArgb(242, 242, 242);
        private Color primeB1 = Color.FromArgb(50, Color.White);
        private Color primeB2 = Color.White;
        private Color primeB3 = Color.FromArgb(50, Color.White);
        private Color primeP1 = Color.White;
        private Color primeP2 = Color.FromArgb(180, 180, 180);
        

        private void PrimePaintHook()
        {
            if (State == MouseState.Down)
            {
                DrawGradient(primeC1, primeC2, ClientRectangle, 90);
            }
            else
            {
                DrawGradient(primeC3, primeC4, ClientRectangle, 90);
                DrawGradient(primeC5, primeC6, 0, 0, Width, Height / 2, 90f);
            }

            if (State == MouseState.Over)
            {
                G.FillRectangle(new SolidBrush(primeB1), ClientRectangle);
            }

            if (State == MouseState.Down)
            {
                DrawText(new SolidBrush(primeB2), HorizontalAlignment.Center, 2, 2);
                DrawText(new SolidBrush(primeB3), HorizontalAlignment.Center, 1, 1);
            }
            else
            {
                DrawText(new SolidBrush(primeB2), HorizontalAlignment.Center, 1, 1);
                DrawText(new SolidBrush(primeB3), HorizontalAlignment.Center, 0, 0);
            }

            DrawBorders(new Pen(primeP1), 1);
            DrawBorders(new Pen(primeP2));

            DrawCorners(BackColor);
        }

    }

}

