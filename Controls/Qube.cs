// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Qube.cs" company="Zeroit Dev Technologies">
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

        
        
        private void QubePaint(PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            Font btnfont = new Font("Verdana", 10, FontStyle.Regular);
            G.Clear(BackColor);
            LinearGradientBrush buttonrect = new LinearGradientBrush(rect, Color.FromArgb(68, 76, 99), Color.FromArgb(68, 76, 99), LinearGradientMode.Vertical);
            G.FillPath(buttonrect, Draw.RoundRect(rect, 3));
            G.DrawPath(new Pen(Brushes.Gray), Draw.RoundRect(rect, 3));
            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush buttonrectnone = new LinearGradientBrush(rect, Color.FromArgb(68, 76, 99), Color.FromArgb(68, 76, 99), LinearGradientMode.Vertical);
                    G.FillPath(buttonrectnone, Draw.RoundRect(rect, 3));
                    G.DrawPath(new Pen(Color.FromArgb(68, 76, 99)), Draw.RoundRect(rect, 3));
                    //G.DrawString(Text, btnfont, Brushes.White, new Rectangle(0, 0, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Down:
                    LinearGradientBrush buttonrectnone1 = new LinearGradientBrush(rect, Color.FromArgb(105, 120, 149), Color.FromArgb(105, 120, 149), LinearGradientMode.Vertical);
                    G.FillPath(buttonrectnone1, Draw.RoundRect(rect, 3));
                    G.DrawPath(new Pen(Color.FromArgb(105, 120, 149)), Draw.RoundRect(rect, 3));
                    //G.DrawString(Text, btnfont, Brushes.White, new Rectangle(0, 0, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Over:
                    LinearGradientBrush buttonrectnone2 = new LinearGradientBrush(rect, Color.FromArgb(68, 76, 99), Color.FromArgb(68, 76, 99), LinearGradientMode.Vertical);
                    G.FillPath(buttonrectnone2, Draw.RoundRect(rect, 3));
                    G.DrawPath(new Pen(Color.FromArgb(68, 76, 99)), Draw.RoundRect(rect, 3));
                    //G.DrawString(Text, btnfont, Brushes.White, new Rectangle(0, 0, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
            }
            e.Graphics.DrawImage(B, new Point(0, 0));
            //G.Dispose();
            //B.Dispose();
        }

    }

}

