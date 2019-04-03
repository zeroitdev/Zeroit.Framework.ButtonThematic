// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="AtrocitiyButton.cs" company="Zeroit Dev Technologies">
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


        
        private Color C1 = Color.FromArgb(24, 23, 26);
        private Color C2 = Color.FromArgb(72, 69, 75);
        private Color C3 = Color.FromArgb(72, 69, 75);
        private Color C4 = Color.FromArgb(24, 23, 26);

        private Color atrocityborder1 = Color.FromArgb(65, 65, 65);
        private Color atrocityborder2 = Color.FromArgb(75, 75, 75);

        
        

        private void AtrocityPaint()
        {
            switch (State)
            {
                case MouseState.None:
                    DrawGradient(C3, C4, ClientRectangle, 90f);
                    break;
                case MouseState.Over:
                    break;
                //DrawGradient(C5, C6, ClientRectangle, 90.0F)
                case MouseState.Down:
                    DrawGradient(C1, C2, ClientRectangle, 90f);
                    break;
            }

            //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

            DrawBorders(new Pen(atrocityborder1), 1);
            DrawBorders(new Pen(atrocityborder2));

            DrawCorners(BackColor);
        }
    }

}
