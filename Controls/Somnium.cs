// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Somnium.cs" company="Zeroit Dev Technologies">
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

        //G.Clear
        private Color somniumC1 = Color.White;
        private Color somniumC2 = Color.FromArgb(50, 50, 50);
        //Lime Gradient
        private Color somniumC3 = Color.FromArgb(0, 0, 0);
        //Gloss
        private Color somniumB1 = Color.FromArgb(60, Color.White);
        //Grey Text
        private Color somniumB2 = Color.White;
        //DrawRectangle
        private Color somniumP1 = Color.White;
        
        
        private void SomniumPaintHook()
        {
            G.Clear(somniumC1);
            DrawGradient(somniumC2, somniumC3, 0, 0, Width, Height, 90);
            //Gloss'
            if ((State == MouseState.Over))
            {
                G.FillRectangle(new SolidBrush(somniumB1), 0, Convert.ToInt32(Height / 2), Width, Convert.ToInt32(Height / 2));
            }
            else if ((State == MouseState.Down))
            {
                G.FillRectangle(new SolidBrush(somniumB1), 0, 0, Width, Convert.ToInt32(Height / 2));
            }
            else
            {
                G.FillRectangle(new SolidBrush(somniumB1), 0, 0, Width, Convert.ToInt32(Height / 2));
            }
            DrawBorders(new Pen(somniumP1), 0, 0, Width, Height);
            //DrawText(new SolidBrush(somniumB2), HorizontalAlignment.Center, 0, 0);
        }

    }

}

