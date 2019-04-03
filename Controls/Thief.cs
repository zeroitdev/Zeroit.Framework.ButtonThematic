// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Thief.cs" company="Zeroit Dev Technologies">
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

        private Color thiefAColor;

        [Browsable(false)]
        public Color ThiefAccentColor
        {
            get { return thiefAColor; }
            set
            {
                thiefAColor = value;
                Invalidate();
            }
        }
        private bool thiefStyle;

        [Browsable(false)]
        public bool DarkTheme
        {
            get { return thiefStyle; }
            set
            {
                thiefStyle = value;
                Invalidate();
            }
        }
        private void Thief3Button()
        {
            switch (DarkTheme)
            {
                case true:
                    BackColor = Color.FromArgb(51, 51, 51);
                    break;
                case false:
                    BackColor = Color.FromArgb(200, 200, 200);
                    break;
            }
            ThiefAccentColor = Color.DodgerBlue;
        }

        private void ThiefPaintHook()
        {
            int GradA = 0;
            int GradB = 0;
            Pen PenColor = default(Pen);
            switch (DarkTheme)
            {
                case true:
                    GradA = 61;
                    GradB = 49;
                    PenColor = Pens.DimGray;
                    break;
                case false:
                    GradA = 200;
                    GradB = 155;
                    PenColor = Pens.White;
                    break;
            }
            G.Clear(Color.FromArgb(102, 102, 102));
            switch (State)
            {
                case MouseState.None:
                    DrawGradient(Color.FromArgb(GradA, GradA, GradA), Color.FromArgb(GradB, GradB, GradB), 0, 0, Width, Height, 90);
                    G.DrawLine(PenColor, 1, 1, Width - 1, 1);
                    break;
                case MouseState.Over:
                    DrawGradient(Color.FromArgb(GradA, GradA, GradA), Color.FromArgb(GradB, GradB, GradB), 0, 0, Width, Height, 90);
                    G.DrawLine(PenColor, 1, 1, Width - 1, 1);
                    break;
                case MouseState.Down:
                    DrawGradient(Color.FromArgb(GradB, GradB, GradB), Color.FromArgb(GradA, GradA, GradA), 0, 0, Width, Height, 90);
                    G.DrawLine(PenColor, 1, Height - 2, Width - 1, Height - 2);
                    break;
            }
            DrawBorders(Pens.Black, Pens.Transparent, ClientRectangle);
            //DrawText(HorizontalAlignment.Center, ThiefAccentColor, -1, 0);
        }

    }

}

