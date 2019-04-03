// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Metal.cs" company="Zeroit Dev Technologies">
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
        private Pen P1;
        private Pen P2;
        private void MetalPaintHook()
        {
            P1 = new Pen(Color.FromArgb(55, 55, 55));
            P2 = new Pen(Color.FromArgb(75, 80, 75));
            Color gradient1 = Color.FromArgb(50, 50, 50);
            Color gradient2 = Color.FromArgb(55, 55, 55);
            Color gradient11 = Color.FromArgb(45, 45, 45);
            Color gradient12 = Color.FromArgb(60, 60, 60);
            
            switch (State)
            {

                case MouseState.None:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(45, 45, 45)), ClientRectangle);
                    DrawGradient(gradient1, gradient2, 0, 0, Width, 18, 90);
                    break;

                case MouseState.Over:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(35,35,35)), ClientRectangle);
                    DrawGradient(gradient11, gradient12, 0, 0, Width, 18, 90);
                    break;

                case MouseState.Down:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(50, 50, 50)), ClientRectangle);
                    DrawGradient(gradient11, gradient12, 0, 0, Width, 18, 90);
                    break;
            }


            DrawBorders(P2, P1, ClientRectangle);
            DrawCorners(Color.FromArgb(63, 63, 63), ClientRectangle);
            //DrawText(HorizontalAlignment.Center, Color.White, 0);
        }

    }

}

