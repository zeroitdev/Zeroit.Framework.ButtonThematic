// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Vs.cs" company="Zeroit Dev Technologies">
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
using System;
using System.Drawing;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        Color vsC1 = Color.FromArgb(249, 245, 226);
        Color vsC2 = Color.FromArgb(255, 232, 165);
        Color vsC3 = Color.FromArgb(111, 88, 38);
        
        private void VsPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Bitmap B = new Bitmap(Width, Height);
            Graphics G = Graphics.FromImage(B);

            if (State == (MouseState)2)
            {
                Draw.Gradient(G, vsC2, vsC1, 0, 0, Width, Height);
            }
            else
            {
                Draw.Gradient(G, vsC1, vsC2, 0, 0, Width, Height);
            }

            if (State < (MouseState)2)
                G.FillRectangle(new SolidBrush(Color.FromArgb(100, 255, 255, 255)), 0, 0, Width, Convert.ToInt32(Height / 2));

            dynamic S = G.MeasureString(Text, Font);
            G.DrawRectangle(new Pen(vsC1), 0, 0, Width - 1, Height - 1);

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);



        }

    }

}

