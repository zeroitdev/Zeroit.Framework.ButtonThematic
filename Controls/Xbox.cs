// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Xbox.cs" company="Zeroit Dev Technologies">
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

        private void XboxPaintHook()
        {
            switch (State)
            {
                case MouseState.None:
                    G.Clear(Color.LightGray);
                    DrawGradient(Color.GhostWhite, Color.LightGray, 0, 0, Width, 20, 90);
                    break;
                case MouseState.Over:
                    G.Clear(Color.Orange);
                    DrawGradient(Color.FromArgb(0, 255, 36), (Color.FromArgb(0, 140, 20)), 0, 0, Width, 25, 90);
                    break;
                case MouseState.Down:
                    G.Clear(Color.Orange);
                    DrawGradient(Color.DarkGreen, (Color.FromArgb(18, 255, 0)), 0, 0, Width, 30, 90);
                    break;
            }
            //DrawText(HorizontalAlignment.Center, Color.FromArgb(190, 190, 190), 0);
            DrawBorders(Pens.DarkGreen, Pens.LightGray, ClientRectangle);
            DrawCorners(Color.DarkGreen, ClientRectangle);
        }

    }

}

