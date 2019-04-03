// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Festus.cs" company="Zeroit Dev Technologies">
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
using System.Drawing.Drawing2D;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        private Pen FestusP1 = new Pen(Color.FromArgb(225, 225, 225));
        private Pen FestusP2 = new Pen(Color.FromArgb(205, 205, 205));
        private Pen FestusP11 = new Pen(Color.FromArgb(225, 225, 225));
        private Pen FestusP12 = new Pen(Color.FromArgb(200, 200, 200));

        private void FestusPaintHook()
        {
            
            G.Clear(Color.FromArgb(240, 240, 240));
            DrawGradient(Color.FromArgb(250, 250, 250), Color.FromArgb(247, 248, 248), 0, 0, Width, 3, 90);
            DrawGradient(Color.FromArgb(248, 248, 248), Color.FromArgb(0, 0, 0), 0, 0, Width, 275, 90);
            DrawBorders(FestusP11, FestusP12, ClientRectangle);

            switch (State)
            {

                case MouseState.Over:
                    DrawGradient(Color.FromArgb(250, 250, 250), Color.FromArgb(247, 248, 248), 0, 0, Width, 20, 90);
                    DrawGradient(Color.FromArgb(248, 248, 248), Color.FromArgb(0, 0, 0), 0, 0, Width, 250, 90);
                    DrawBorders(FestusP2, FestusP11, ClientRectangle);
                    //DrawText(HorizontalAlignment.Center, Color.Red, 0);

                    break;
                case MouseState.Down:
                    Rectangle _Rectangle = new Rectangle(0, -3, Width, Height / 2);
                    LinearGradientBrush _Gradient = new LinearGradientBrush(_Rectangle, Color.FromArgb(238, 238, 238), Color.FromArgb(240, 240, 240), 90);
                    G.FillRectangle(_Gradient, _Rectangle);
                    DrawBorders(new Pen(Color.FromArgb(240, 240, 240)), new Pen(Color.FromArgb(190, 190, 190)), ClientRectangle);
                    //DrawText(HorizontalAlignment.Center, Color.Gray, 0);
                    break;
            }
            
            DrawCorners(Color.FromArgb(240, 240, 240), ClientRectangle);
            //DrawText(HorizontalAlignment.Center, Color.Gray, 0);
        }
    }

}

