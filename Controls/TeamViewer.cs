// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="TeamViewer.cs" company="Zeroit Dev Technologies">
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

        private void TeamViewerPaintHook()
        {
            
            G.Clear(Color.FromArgb(1, 1, 1));
            switch (State)
            {
                case MouseState.None:
                    DrawGradient(Color.FromArgb(0, 153, 255), Color.FromArgb(0, 102, 255), 0, 0, Width, Height, 90);
                    break;
                case MouseState.Over:
                    DrawGradient(Color.FromArgb(0, 102, 255), Color.FromArgb(0, 153, 255), 0, 0, Width, Height, 90);
                    break;
                case MouseState.Down:
                    DrawGradient(Color.FromArgb(0, 143, 240), Color.FromArgb(0, 200, 240), 0, 0, Width, Height, 90);
                    break;
            }
            G.FillRectangle(new SolidBrush(Color.FromArgb(6, Color.White)), 0, 0, Width, 12);
            DrawBorders(Pens.Black);
            DrawBorders(Pens.Black, 2);
            DrawCorners(Color.FromArgb(20, 20, 20), ClientRectangle);
            //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);

        }

    }

}

