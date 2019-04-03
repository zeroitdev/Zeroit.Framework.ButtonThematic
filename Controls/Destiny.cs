// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Destiny.cs" company="Zeroit Dev Technologies">
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
        Color destinyG1 = Color.Teal;
        Color destinyG2 = Color.Black;
        Color destinyG3 = Color.Black;
        Color destinyG4 = Color.Teal;
        Color destinyBorder = Color.Black;
        Color destinyG5 = Color.Teal;

        [Browsable(false)]
        public Color DestinyG1
        {
            get { return destinyG1; }
            set { destinyG1 = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color DestinyG2
        {
            get { return destinyG2; }
            set { destinyG2 = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color DestinyG3
        {
            get { return destinyG3; }
            set { destinyG3 = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color DestinyG4
        {
            get { return destinyG4; }
            set { destinyG4 = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color DestinyBorder
        {
            get { return destinyBorder; }
            set { destinyBorder = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color DestinyG5
        {
            get { return destinyG5; }
            set { destinyG5 = value; Invalidate(); }
        }

        //Color N;
        private void DestinyPaintHook()
        {
            //N = BackColor;
            G.Clear(Parent.BackColor);

            if (State == MouseState.None)
            {
                DrawGradient(DestinyG1, DestinyG2, 0, 0, Width, Height, 90);
            }
            else if (State == MouseState.Over)
            {
                DrawGradient(DestinyG3, DestinyG5, 0, 0, Width, Height, 90);
            }
            else if (State == MouseState.Down)
            {
                DrawGradient(DestinyG4, DestinyG4, 0, 0, Width, Height, 90);
            }

            //DrawText(HorizontalAlignment.Center, ForeColor, 0);
            G.DrawRectangle(new Pen(destinyBorder), ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width - 1, ClientRectangle.Height - 1);
        }

    }

}

