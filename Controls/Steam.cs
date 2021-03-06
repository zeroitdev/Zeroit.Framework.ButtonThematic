﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Steam.cs" company="Zeroit Dev Technologies">
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

        private void SteamPaintHook()
        {
            G.Clear(Color.FromArgb(56, 54, 53));
            DrawBorders(new Pen(new SolidBrush(Color.FromArgb(77, 75, 72))));
            DrawCorners(Color.FromArgb(56, 54, 53));



            switch (State)
            {
                case MouseState.None:
                    DrawGradient(Color.FromArgb(92, 89, 86), Color.FromArgb(74, 72, 70), ClientRectangle, 90);
                    DrawBorders(new Pen(new SolidBrush(Color.FromArgb(112, 109, 105))));
                    DrawCorners(Color.FromArgb(82, 79, 77));
                    break;
                case MouseState.Over:
                    DrawGradient(Color.FromArgb(112, 109, 106), Color.FromArgb(94, 92, 90), ClientRectangle, 90);
                    DrawBorders(new Pen(new SolidBrush(Color.FromArgb(141, 148, 130))));
                    DrawCorners(Color.FromArgb(82, 79, 77));
                    break;
                case MouseState.Down:
                    DrawGradient(Color.FromArgb(56, 54, 53), Color.FromArgb(73, 71, 69), ClientRectangle, 90);
                    DrawBorders(new Pen(new SolidBrush(Color.FromArgb(112, 109, 105))));
                    DrawCorners(Color.FromArgb(82, 79, 77));
                    break;
            }
            //DrawText(new SolidBrush(Color.FromArgb(195, 193, 191)), Text.ToUpper(), HorizontalAlignment.Left, 4, 0);
        }

    }

}

