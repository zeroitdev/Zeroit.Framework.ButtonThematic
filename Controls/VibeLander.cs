﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="VibeLander.cs" company="Zeroit Dev Technologies">
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

        private void VibeLanderPaintHook()
        {
            G.Clear(Parent.BackColor);
            G.SmoothingMode = SmoothingMode.HighQuality;
            switch (State)
            {
                case MouseState.None:
                    Pen p = new Pen(Color.FromArgb(34, 112, 171), 1);
                    LinearGradientBrush x = new LinearGradientBrush(ClientRectangle, Color.FromArgb(51, 159, 231), Color.FromArgb(33, 128, 206), LinearGradientMode.Vertical);
                    G.FillPath(x, Draw.RoundRect(ClientRectangle, 4));
                    G.DrawPath(p, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), 3));
                    G.DrawLine(new Pen(Color.FromArgb(131, 197, 241)), 2, 1, Width - 3, 1);
                    //DrawText(HorizontalAlignment.Center, Color.FromArgb(240, 240, 240), 0);
                    break;
                case MouseState.Down:
                    Pen p1 = new Pen(Color.FromArgb(34, 112, 171), 1);
                    LinearGradientBrush x1 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(37, 124, 196), Color.FromArgb(53, 153, 219), LinearGradientMode.Vertical);
                    G.FillPath(x1, Draw.RoundRect(ClientRectangle, 4));
                    G.DrawPath(p1, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), 3));

                    //DrawText(HorizontalAlignment.Center, Color.FromArgb(250, 250, 250), 1);
                    break;
                case MouseState.Over:
                    Pen p2 = new Pen(Color.FromArgb(34, 112, 171), 1);
                    LinearGradientBrush x2 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(54, 167, 243), Color.FromArgb(35, 165, 217), LinearGradientMode.Vertical);
                    G.FillPath(x2, Draw.RoundRect(ClientRectangle, 4));
                    G.DrawPath(p2, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), 3));
                    G.DrawLine(new Pen(Color.FromArgb(131, 197, 241)), 2, 1, Width - 3, 1);
                    //DrawText(HorizontalAlignment.Center, Color.FromArgb(240, 240, 240), -1);
                    break;
            }
            //this.Cursor = Cursors.Hand;
        }

    }

}

