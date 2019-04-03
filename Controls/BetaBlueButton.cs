// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="BetaBlueButton.cs" company="Zeroit Dev Technologies">
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

        private bool _Dark;

        [Browsable(false)]
        public bool BetaBlueDark
        {
            get { return _Dark; }
            set
            {
                _Dark = value;
                Invalidate();
            }
        }

        public void BetaBluePaintHook()
        {
            Color GradA = default(Color);
            Color GradB = default(Color);
            Pen PenColor = Pens.DodgerBlue;
            GradA = Color.FromArgb(0, 105, 246);
            GradB = Color.FromArgb(0, 83, 221);

            switch (BetaBlueDark)
            {
                case false:
                    GradA = Color.FromArgb(0, 105, 246);
                    GradB = Color.FromArgb(0, 83, 221);
                    PenColor = Pens.DodgerBlue;
                    break;
                case true:
                    GradA = Color.FromArgb(62, 62, 62);
                    GradB = Color.FromArgb(38, 38, 38);
                    PenColor = Pens.DimGray;
                    break;
            }

            switch (State)
            {
                case MouseState.None:
                    G.Clear(Color.Gray);
                    DrawGradient(GradA, GradB, 0, 0, Width, Height, 90);
                    break;
                case MouseState.Over:
                    G.Clear(Color.Gray);
                    DrawGradient(GradA, GradB, 0, 0, Width, Height, 90);
                    break;
                case MouseState.Down:
                    G.Clear(Color.DarkGray);
                    DrawGradient(GradB, GradA, 0, 0, Width, Height, 90);
                    break;
            }

            DrawBorders(Pens.Black, PenColor, ClientRectangle);
            // Button Border
            DrawCorners(Color.Black, ClientRectangle);
            // Clean Corners
            //DrawText(HorizontalAlignment.Center, Color.White, 0);
        }
    }

}
