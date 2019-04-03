// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Fusion.cs" company="Zeroit Dev Technologies">
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
        private Color fusionC1 = Color.FromArgb(255, 127, 1);
        private Color fusionC2 = Color.FromArgb(255, 175, 12);
        private Color fusionC3 = Color.FromArgb(255, 175, 12);
        private Color fusionC4 = Color.FromArgb(255, 127, 1);
        private Color fusionB1 = Color.FromArgb(30, Color.Black);
        private Color fusionB2 = Color.White;
        private Color fusionP1 = Color.FromArgb(255, 197, 19);

        private Color fusionP2 = Color.FromArgb(254, 133, 0);

        
        private void FusionPaintHook()
        {
            if (State == MouseState.Down)
            {
                DrawGradient(fusionC1, fusionC2, ClientRectangle, 90f);
            }
            else
            {
                DrawGradient(fusionC3, fusionC4, ClientRectangle, 90f);
            }

            //DrawText(new SolidBrush(fusionB1), HorizontalAlignment.Center, 1, 1);
            //DrawText(new SolidBrush(fusionB2), HorizontalAlignment.Center, 0, 0);

            DrawBorders(new Pen(fusionP1), 1);
            DrawBorders(new Pen(fusionP2));

            DrawCorners(BackColor);
        }

    }

}

