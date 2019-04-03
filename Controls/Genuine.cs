// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Genuine.cs" company="Zeroit Dev Technologies">
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
        
        private Color genuineC1 = Color.FromArgb(41, 41, 41);
        private Color genuineC2 = Color.FromArgb(51, 51, 51);
        private Color genuineC3 = Color.FromArgb(51, 51, 51);
        private Color genuineC4 = Color.FromArgb(41, 41, 41);
        private Color genuineP1 = Color.FromArgb(12, Color.White);

        private Color genuineP2 = Color.FromArgb(25, 25, 25);
        

        private void GenuinePaintHook()
        {
            if (State == MouseState.Down)
            {
                DrawGradient(genuineC1, genuineC2, ClientRectangle, 90f);
            }
            else
            {
                DrawGradient(genuineC3, genuineC4, ClientRectangle, 90f);
            }

            //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

            DrawBorders(new Pen(genuineP1), 1);
            DrawBorders(new Pen(genuineP2));

            DrawCorners(Parent.BackColor);
        }

    }

}

