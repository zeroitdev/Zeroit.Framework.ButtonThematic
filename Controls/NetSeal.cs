// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="NetSeal.cs" company="Zeroit Dev Technologies">
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
        
        private Color netSealP1 = Color.FromArgb(24, 24, 24);

        private Color netSealP2 = Color.FromArgb(65, 65, 65);
        
        private void NetSealPaint(System.Windows.Forms.PaintEventArgs e)
        {
            
            
            G.Clear(Parent.BackColor);
            GraphicsPath GP1 = Draw.CreateRound(0, 0, Width - 1, Height - 1, 7);
            GraphicsPath GP2 = Draw.CreateRound(1, 1, Width - 3, Height - 3, 7);

            if (State == MouseState.Down)
            {
                PathGradientBrush PB1 = new PathGradientBrush(GP1);
                PB1.CenterColor = Color.FromArgb(60, 60, 60);
                PB1.SurroundColors = new Color[] { Color.FromArgb(55, 55, 55) };
                PB1.FocusScales = new PointF(0.8f, 0.5f);

                G.FillPath(PB1, GP1);
            }
            else
            {
                LinearGradientBrush GB1 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(60, 60, 60), Color.FromArgb(55, 55, 55), 90f);
                G.FillPath(GB1, GP1);
            }

            G.DrawPath(new Pen(netSealP1), GP1);
            G.DrawPath(new Pen(netSealP2), GP2);

            SizeF SZ1 = G.MeasureString(Text, Font);
            PointF PT1 = new PointF(5, Height / 2 - SZ1.Height / 2);

            if (State == MouseState.Down)
            {
                PT1.X += 1f;
                PT1.Y += 1f;
            }

            //G.DrawString(Text, Font, Brushes.Black, PT1.X + 1, PT1.Y + 1);
            //G.DrawString(Text, Font, Brushes.WhiteSmoke, PT1);
        }

    }

}

