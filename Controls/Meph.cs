// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Meph.cs" company="Zeroit Dev Technologies">
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

        
        
        private void MephPaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);

            G.Clear(BackColor);
            Font drawFont = new Font("Verdana", 8, FontStyle.Regular);

            //G.FillPath(new SolidBrush(Color.FromArgb(40, 40, 40)), Draw.RoundRect(ClientRectangle, 3));
            //G.DrawPath(new Pen(new SolidBrush(Color.FromArgb(15, 15, 15))), Draw.RoundRect(ClientRectangle, 3));
            //G.DrawPath(new Pen(new SolidBrush(Color.FromArgb(55, 55, 55))), Draw.RoundRect(new Rectangle(1, 1, Width - 3, Height - 3), 3));

            switch (State)
            {
                case MouseState.None:

                    G.FillPath(new SolidBrush(Color.FromArgb(40, 40, 40)), Draw.RoundRect(ClientRectangle, 3));
                    G.DrawPath(new Pen(new SolidBrush(Color.FromArgb(15, 15, 15))), Draw.RoundRect(ClientRectangle, 3));
                    G.DrawPath(new Pen(new SolidBrush(Color.FromArgb(55, 55, 55))), Draw.RoundRect(new Rectangle(1, 1, Width - 3, Height - 3), 3));

                    //G.DrawString(Text, drawFont, Brushes.Silver, new Rectangle(0, 0, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Over:
                    G.FillPath(new SolidBrush(Color.FromArgb(30, 30, 30)), Draw.RoundRect(ClientRectangle, 3));
                    G.DrawPath(new Pen(new SolidBrush(Color.FromArgb(15, 15, 15))), Draw.RoundRect(ClientRectangle, 3));
                    G.DrawPath(new Pen(new SolidBrush(Color.FromArgb(55, 55, 55))), Draw.RoundRect(new Rectangle(1, 1, Width - 3, Height - 3), 3));

                    //G.DrawString(Text, drawFont, Brushes.White, new Rectangle(0, 0, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                break;
                case MouseState.Down:
                    G.FillPath(new SolidBrush(Color.FromArgb(25, 25, 25)), Draw.RoundRect(ClientRectangle, 3));
                    G.DrawPath(new Pen(new SolidBrush(Color.FromArgb(15, 15, 15))), Draw.RoundRect(ClientRectangle, 3));
                    G.DrawPath(new Pen(new SolidBrush(Color.FromArgb(55, 55, 55))), Draw.RoundRect(new Rectangle(1, 1, Width - 3, Height - 3), 3));

                    //G.DrawString(Text, drawFont, Brushes.Gray, new Rectangle(0, 0, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
            }

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            //G.Dispose();
            //B.Dispose();
        }



    }

}

