// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Mystic.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        
        private Color mysticBackground = Color.FromArgb(66, 219, 183);
        private void MysticPaint(PaintEventArgs e)
        {
            G = e.Graphics;
            G.Clear(mysticBackground);
            G.FillRectangle(new LinearGradientBrush(new Point(0, 0), new Point(0, Height), Color.FromArgb(66, 219, 183), Color.FromArgb(3, 122, 95)), new Rectangle(0, 0, Width, Height));

            switch (State)
            {
                case MouseState.Over:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.White)), new Rectangle(0, 0, Width, Height));
                    break;
                case MouseState.Down:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.Black)), new Rectangle(0, 0, Width, Height));
                    break;
            }

            G.FillRectangle(new SolidBrush(Color.FromArgb(44, 51, 62)), new Rectangle(0, 0, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(44, 51, 62)), new Rectangle(1, 0, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(44, 51, 62)), new Rectangle(0, 1, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(44, 51, 62)), new Rectangle(Width - 1, 0, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(44, 51, 62)), new Rectangle(Width - 1, 1, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(44, 51, 62)), new Rectangle(Width - 2, 0, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(44, 51, 62)), new Rectangle(0, Height - 1, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(44, 51, 62)), new Rectangle(1, Height - 1, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(44, 51, 62)), new Rectangle(0, Height - 2, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(44, 51, 62)), new Rectangle(Width - 1, Height - 1, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(44, 51, 62)), new Rectangle(Width - 1, Height - 2, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(44, 51, 62)), new Rectangle(Width - 2, Height - 1, 1, 1));

            StringFormat _StringF = new StringFormat();
            _StringF.Alignment = StringAlignment.Center;
            _StringF.LineAlignment = StringAlignment.Center;
            //G.DrawString(Text, new Font("Segoe UI", 9, FontStyle.Bold), Brushes.White, new RectangleF(0, 0, Width - 1, Height - 1), _StringF);

        }

    }

}

