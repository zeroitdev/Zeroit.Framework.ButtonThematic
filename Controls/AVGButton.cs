// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="AVGButton.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel;
using System.Drawing;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic 
    {
        Color avgbackground = Color.FromArgb(24, 143, 124);
        Color avgBorder = Color.Transparent;

        [Browsable(false)]
        public Color Avgbackground
        {
            get
            {
                return avgbackground;
            }
            set { avgbackground = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color AvgBorder
        {
            get { return avgBorder; }
            set { avgBorder = value; Invalidate();}
        }


        private void AVGPaint()
        {
            G.Clear(Avgbackground);
            switch (State)
            {
                case MouseState.None:
                    G.DrawRectangle(new Pen(AvgBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    break;
                case MouseState.Over:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(24, 143, 124)), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(AvgBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    break;
            }
        }
    }

    
}
