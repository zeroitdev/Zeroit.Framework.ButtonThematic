// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Intel.cs" company="Zeroit Dev Technologies">
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

        
        public void iButton()
        {
            IsAnimated = true;
            
        }


        private int glow = 180;
        
        private void IntelPaintHook()
        {
            G.Clear(Color.FromArgb(45, 45, 45));

            GraphicsPath gp = CreateRound(new Rectangle(0, 0, Width - 1, Height - 1), 8);
            PathGradientBrush pgb = new PathGradientBrush(gp);

            G.FillPath(Brushes.Black, gp);

            pgb.CenterColor = Color.FromArgb(200, Color.SteelBlue);
            pgb.SurroundColors = new Color[] { Color.FromArgb(glow, Color.SteelBlue) };
            pgb.CenterPoint = new Point((this.Width - 1) / 2, (this.Height - 1) / 2);

            G.FillPath(pgb, gp);
            G.DrawPath(Pens.DeepSkyBlue, gp);

            int textWidth = (int)this.CreateGraphics().MeasureString(Text, Font).Width;
            int textHeight = (int)this.CreateGraphics().MeasureString(Text, Font).Height;
            SolidBrush textShadow = new SolidBrush(Color.FromArgb(30, 15, 0));
            Rectangle textRect = new Rectangle(3, 3, textWidth + 10, textHeight);
            Point textPoint = new Point((Width / 2) - (textWidth / 2), (Height / 2) - (textHeight / 2));
            Point textShadowPoint = new Point((Width / 2) - (textWidth / 2) + 1, (Height / 2) - (textHeight / 2) + 1);
            
            //G.DrawString(Text, Font, textShadow, textShadowPoint);
            //G.DrawString(Text, Font, Brushes.WhiteSmoke, textPoint);

        }
        
        private void IntelOnAnimation()
        {
            if (State == MouseState.Over)
            {
                if (glow < 230)
                    glow += 1;
            }
            else
            {
                if (glow > 182)
                {
                    glow -= 2;
                }
                else if (glow > 180 & glow < 182)
                {
                    glow = 180;
                }
            }
        }

    }

}

