// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Hero.cs" company="Zeroit Dev Technologies">
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


        
        private MouseState _State;
        
        private void HexPaint()
        {
            
            
            G.Clear(Color.FromArgb(30, 33, 40));
            G.DrawPath(new Pen(Color.FromArgb(236, 95, 75)), Draw.RoundRec(new Rectangle(0, 0, Width - 1, Height - 1), 4));
            G.FillPath(new SolidBrush(Color.FromArgb(236, 95, 75)), Draw.RoundRec(new Rectangle(0, 0, Width - 1, Height - 1), 4));

            switch (_State)
            {
                case MouseState.Over:
                    G.DrawPath(new Pen(Color.FromArgb(20, Color.White)), Draw.RoundRec(new Rectangle(0, 0, Width - 1, Height - 1), 4));
                    G.FillPath(new SolidBrush(Color.FromArgb(20, Color.White)), Draw.RoundRec(new Rectangle(0, 0, Width - 1, Height - 1), 4));
                    break;
                case MouseState.Down:
                    G.DrawPath(new Pen(Color.FromArgb(25, Color.Black)), Draw.RoundRec(new Rectangle(0, 0, Width - 1, Height - 1), 4));
                    G.FillPath(new SolidBrush(Color.FromArgb(25, Color.Black)), Draw.RoundRec(new Rectangle(0, 0, Width - 1, Height - 1), 4));
                    break;
            }

            StringFormat _StringF = new StringFormat();
            _StringF.Alignment = StringAlignment.Center;
            _StringF.LineAlignment = StringAlignment.Center;
            //G.DrawString(Text, new Font("Segoe UI", 9), Brushes.White, new RectangleF(0, 0, Width - 1, Height - 1), _StringF);
        }


    }

}

