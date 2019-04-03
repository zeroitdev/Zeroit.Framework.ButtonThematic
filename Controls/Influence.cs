// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Influence.cs" company="Zeroit Dev Technologies">
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

        
        private void InfluencePaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);

            dynamic ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);

            
            //G.SmoothingMode = SmoothingMode.HighQuality;
            //G.Clear(Color.FromArgb(20, 20, 20))
            G.Clear(Parent.BackColor);

            switch (State)
            {
                case MouseState.None:
                    //Mouse None
                    G.FillPath(new SolidBrush(Color.FromArgb(20, 20, 20)), Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 2), 2));
                    LinearGradientBrush g1 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(125, 78, 75, 73), Color.FromArgb(125, 61, 59, 55), 90);
                    G.FillPath(g1, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 2), 2));
                    HatchBrush h1 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(100, 31, 31, 31), Color.FromArgb(100, 36, 36, 36));
                    G.FillPath(h1, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 2), 2));
                    LinearGradientBrush s1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height / 2), Color.FromArgb(35, Color.White), Color.FromArgb(0, Color.White), 90);
                    G.FillPath(s1, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height / 2 - 1), 2));
                    G.DrawPath(new Pen(Color.FromArgb(150, 97, 94, 90)), Draw.RoundRect(new Rectangle(0, 1, Width - 1, Height - 3), 2));
                    G.DrawPath(new Pen(Color.FromArgb(0, 0, 0)), Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), 2));
                    break;
                case MouseState.Over:
                    //Mouse Hover
                    LinearGradientBrush g11 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(125, 78, 75, 73), Color.FromArgb(125, 61, 59, 55), 90);
                    G.FillPath(g11, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 2), 2));
                    //G.FillRectangle(g1, ClientRectangle)
                    HatchBrush h11 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(100, 31, 31, 31), Color.FromArgb(100, 36, 36, 36));
                    G.FillPath(h11, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 2), 2));
                    //G.FillRectangle(h1, New Rectangle(0, 0, Width - 1, Height - 2))
                    LinearGradientBrush s11 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height / 2), Color.FromArgb(35, Color.White), Color.FromArgb(0, Color.White), 90);
                    G.FillPath(s11, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height / 2 - 1), 2));
                    G.FillPath(new SolidBrush(Color.FromArgb(15, Color.White)), Draw.RoundRect(ClientRectangle, 2));
                    G.DrawPath(new Pen(Color.FromArgb(150, 97, 94, 90)), Draw.RoundRect(new Rectangle(0, 1, Width - 1, Height - 3), 2));
                    G.DrawPath(new Pen(Color.FromArgb(0, 0, 0)), Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), 2));
                    break;
                case MouseState.Down:
                    //Mouse Down
                    LinearGradientBrush g12 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(125, 78, 75, 73), Color.FromArgb(125, 61, 59, 55), 90);
                    G.FillPath(g12, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 2), 2));
                    //G.FillRectangle(g1, ClientRectangle)
                    HatchBrush h12 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(100, 31, 31, 31), Color.FromArgb(100, 36, 36, 36));
                    G.FillPath(h12, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 2), 2));
                    //G.FillRectangle(h1, New Rectangle(0, 0, Width - 1, Height - 2))
                    LinearGradientBrush s12 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height / 2), Color.FromArgb(35, Color.White), Color.FromArgb(0, Color.White), 90);
                    G.FillPath(s12, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height / 2 - 1), 2));
                    G.FillPath(new SolidBrush(Color.FromArgb(15, Color.Black)), Draw.RoundRect(ClientRectangle, 2));
                    G.DrawPath(new Pen(Color.FromArgb(150, 97, 94, 90)), Draw.RoundRect(new Rectangle(0, 1, Width - 1, Height - 3), 2));
                    G.DrawPath(new Pen(Color.FromArgb(0, 0, 0)), Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), 2));
                    break;
            }

            //G.DrawRectangle(Pens.Black, ClientRectangle)

            //G.DrawString(Text, Font, Brushes.Black, new Rectangle(5, 0, Width - 1, Height - 1), new StringFormat
            //{
            //    LineAlignment = StringAlignment.Center,
            //    Alignment = _align
            //});
            //G.DrawString(Text, Font, Brushes.White, new Rectangle(5, 1, Width - 1, Height - 1), new StringFormat
            //{
            //    LineAlignment = StringAlignment.Center,
            //    Alignment = _align
            //});

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            //G.Dispose();
            //B.Dispose();
        }

    }

}

