// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Vitality.cs" company="Zeroit Dev Technologies">
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

        Color vitalityG1 = Color.White;
        Color vitalityG2 = Color.LightGray;
        Color vitalityBG = Color.FromArgb(240, 240, 240);
        

        private void VitalityPaintHook()
        {
            G.Clear(vitalityBG);

            if (State == MouseState.Over)
            {
                G.FillRectangle(Brushes.White, new Rectangle(new Point(0, 0), new Size(Width, Height)));
            }
            else if (State == MouseState.Down)
            {
                LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(new Point(0, 0), new Size(Width, Height)), Color.FromArgb(240, 240, 240), Color.White, 90f);
                G.FillRectangle(LGB, new Rectangle(new Point(0, 0), new Size(Width, Height)));
            }
            else if (State == MouseState.None)
            {
                LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(new Point(0, 0), new Size(Width, Height)), Color.White, Color.FromArgb(240, 240, 240), 90f);
                G.FillRectangle(LGB, new Rectangle(new Point(0, 0), new Size(Width, Height)));
            }

            DrawBorders(Pens.LightGray);
            DrawCorners(Color.Transparent);

            StringFormat SF = new StringFormat();
            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;
            //G.DrawString(this.Text, new Font("Segoe UI", 9), Brushes.Gray, new RectangleF(2, 2, this.Width - 5, this.Height - 4), SF);
        }

    }

}

