// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Modern.cs" company="Zeroit Dev Technologies">
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

        
        Color moderC1 = Color.FromArgb(240, 240, 240);
        Color moderC2 = Color.FromArgb(230, 230, 230);
        Color moderC3 = Color.FromArgb(190, 190, 190);
        
        private void ModernPaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);

            if (State == (MouseState)2)
            {
                Draw.Gradient(G, moderC2, Color.WhiteSmoke, 1, 1, Width, Height);
            }
            else
            {
                Draw.Gradient(G, Color.WhiteSmoke, moderC2, 1, 1, Width, Height);
            }

            if (State < (MouseState)2)
                G.FillRectangle(new SolidBrush(Color.FromArgb(80, 255, 255, 255)), 0, 0, Width, Convert.ToInt32(Height * 0.3));

            dynamic S = G.MeasureString(Text, Font);
            //G.DrawString(Text, Font, new SolidBrush(ForeColor), Width / 2 - S.Width / 2, Height / 2 - S.Height / 2);
            G.DrawRectangle(new Pen(moderC3), 0, 0, Width - 1, Height - 1);

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            

        }

    }

}

