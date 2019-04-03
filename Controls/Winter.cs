// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Winter.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {
        
        private void WinterPaint(PaintEventArgs e)
        {
            
            G.Clear(Color.FromArgb(61, 132, 221));
            G.FillRectangle(new SolidBrush(Color.FromArgb(78, 148, 235)), new Rectangle(0, 0, Width, Height / 2));

            switch (State)
            {
                case MouseState.Over:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.White)), new Rectangle(0, 0, Width, Height));
                    break;
                case MouseState.Down:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.Black)), new Rectangle(0, 0, Width, Height));
                    break;
            }

            StringFormat _StringF = new StringFormat();
            _StringF.Alignment = StringAlignment.Center;
            _StringF.LineAlignment = StringAlignment.Center;
            //G.DrawString(Text, new Font("Segoe UI", 10), Brushes.White, new RectangleF(0, 0, Width, Height), _StringF);

            G.FillRectangle(new SolidBrush(Color.FromArgb(211, 222, 228)), new Rectangle(0, 0, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(211, 222, 228)), new Rectangle(0, 1, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(211, 222, 228)), new Rectangle(1, 0, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(211, 222, 228)), new Rectangle(Width - 1, 0, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(211, 222, 228)), new Rectangle(Width - 1, 1, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(211, 222, 228)), new Rectangle(Width - 2, 0, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(211, 222, 228)), new Rectangle(0, Height - 1, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(211, 222, 228)), new Rectangle(0, Height - 2, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(211, 222, 228)), new Rectangle(1, Height - 1, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(211, 222, 228)), new Rectangle(Width - 1, Height - 1, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(211, 222, 228)), new Rectangle(Width - 1, Height - 2, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(211, 222, 228)), new Rectangle(Width - 2, Height - 1, 1, 1));

        }


    }

}

