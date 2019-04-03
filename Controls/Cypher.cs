// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Cypher.cs" company="Zeroit Dev Technologies">
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

        
        private void CypherOnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle OuterR = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle InnerR = new Rectangle(1, 1, Width - 3, Height - 3);
            Rectangle UpHalf = new Rectangle(2, 2, Width - 3, (Height - 1) / 2);
            Rectangle DownHalf = new Rectangle(2, (Height - 1) / 2, Width - 3, (Height - 1) / 2);
            
            switch (State)
            {
                case MouseState.None:
                    Draw.Gradient(G, Color.FromArgb(88, 79, 72), Color.FromArgb(76, 69, 61), UpHalf);
                    Draw.Gradient(G, Color.FromArgb(56, 46, 36), Color.FromArgb(66, 56, 46), DownHalf);
                    G.DrawRectangle(Pens.Black, OuterR);
                    G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(75, 66, 60))), InnerR);
                    //ForeColor = Color.White;
                    break;
                case MouseState.Down:
                    Draw.Gradient(G, Color.FromArgb(88, 79, 72), Color.FromArgb(76, 69, 61), UpHalf);
                    Draw.Gradient(G, Color.FromArgb(56, 46, 36), Color.FromArgb(66, 56, 46), DownHalf);
                    G.DrawRectangle(Pens.Black, OuterR);
                    G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(75, 66, 60))), InnerR);
                    //ForeColor = Color.White;
                    break;
                case MouseState.Over:
                    Draw.Gradient(G, Color.FromArgb(234, 236, 241), Color.FromArgb(215, 219, 225), UpHalf);
                    Draw.Gradient(G, Color.FromArgb(189, 193, 198), Color.FromArgb(195, 198, 201), DownHalf);
                    ForeColor = Color.FromArgb(23, 32, 37);
                    break;
            }
            SizeF S = G.MeasureString(Text, Font);
            //G.DrawString(Text, Font, new SolidBrush(ForeColor), Convert.ToInt32(Width / 2 - S.Width / 2), Convert.ToInt32(Height / 2 - S.Height / 2));

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);



        }
        
    }

}

