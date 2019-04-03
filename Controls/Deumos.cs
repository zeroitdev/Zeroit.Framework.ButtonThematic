// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Deumos.cs" company="Zeroit Dev Technologies">
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
        private Color deumosC1 = Color.FromArgb(14, 14, 14);
        private Color deumosC2 = Color.FromArgb(14, 14, 14);
        private Color deumosC3 = Color.FromArgb(41, 41, 41);
        private Color deumosC4 = Color.FromArgb(30, Color.White);
        private Color deumosC5 = Color.FromArgb(5, Color.White);
        private Color deumosC6 = Color.FromArgb(16, 16, 16);
        private Color deumosB1 = Color.FromArgb(5, Color.White);
        private Color deumosB2 = Color.White;
        private Color deumosP1 = Color.FromArgb(62, 62, 62);
        private Color deumosP2 = Color.FromArgb(15, Color.White);
        private Color deumosP3 = Color.Black;

        
        private void DeumosPaintHook()
        {
            G.Clear(deumosC1);

            if (State == MouseState.Down)
            {
                DrawGradient(deumosC2, deumosC3, 0, 0, Width, Height, 90);
            }

            if (State == MouseState.Over)
            {
                G.FillRectangle(new SolidBrush(deumosB1), ClientRectangle);
            }

            DrawGradient(deumosC4, deumosC5, 0, 0, Width, Height / 2, 90);

            G.DrawLine(new Pen(deumosP1), 0, 1, Width, 1);
            DrawBorders(new Pen(deumosP2), ClientRectangle, 1);

            DrawBorders(new Pen(deumosP3), ClientRectangle);

            DrawCorners(deumosC6, new Rectangle(1, 1, Width - 2, Height - 2));
            DrawCorners(BackColor, ClientRectangle);

            //DrawText(new SolidBrush(deumosB2), HorizontalAlignment.Center, 0, 0);
        }

    }

}

