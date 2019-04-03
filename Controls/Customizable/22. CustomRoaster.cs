// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="22. CustomRoaster.cs" company="Zeroit Dev Technologies">
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

    /// <summary>
    /// Class ButtonThematic.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    public partial class ButtonThematic
    {
        #region Private Fields
        private Color[] customRoasterGradientColors = new Color[]
        {
            Color.FromArgb(0, 0, 0),
            Color.FromArgb(95, 0, 0),
            Color.FromArgb(73, 73, 73),
            Color.FromArgb(93, 93, 93)
        };

        private Color customRoasterBorderColor = Color.Black;

        private Color[] customRoasterBackgroundStateColors = new Color[]
        {
            Color.White,
            Color.Black
        };
        #endregion

        #region Public Properties

        [Browsable(false)]
        public Color[] CustomRoasterGradientColors
        {
            get { return buttonInput.CustomRoasterGradientColors; }
            set
            {
                buttonInput.CustomRoasterGradientColors = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color CustomRoasterBorderColor
        {
            get { return buttonInput.CustomRoasterBorderColor; }
            set
            {
                buttonInput.CustomRoasterBorderColor = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] CustomRoasterBackgroundStateColors
        {
            get { return buttonInput.CustomRoasterBackgroundStateColors; }
            set
            {
                buttonInput.CustomRoasterBackgroundStateColors = value;
                Invalidate();
            }
        }
        
        #endregion

        #region Paint
        private void CustomRoasterPaintHook()
        {
            G.Clear(Parent.BackColor);
            DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[1], 0, 2, Width / 2, Height / 2, 45);
            DrawGradient(CustomRoasterGradientColors[1], CustomRoasterGradientColors[0], Width / 2, 2, Width - 15, Height / 2, -45);
            DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[1], 0, Height / 2, Width / 2, Height, 45);
            DrawGradient(CustomRoasterGradientColors[1], CustomRoasterGradientColors[0], Width / 2, Height / 2, Width, Height / 2, 315);

            DrawBorders(new Pen(CustomRoasterBorderColor), 0);
            DrawBorders(new Pen(CustomRoasterBorderColor), 1);
            DrawBorders(new Pen(CustomRoasterGradientColors[1]), 3);
            G.DrawLine(new Pen(CustomRoasterGradientColors[3]), 3, 3, Width - 5, 3);
            G.DrawLine(new Pen(CustomRoasterGradientColors[2]), 0, Height - 1, Width, Height - 1);
            DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[2], 0, 0, 1, Height);
            DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[2], Width - 1, 0, 1, Height);

            if (State == MouseState.Over)
            {
                DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[1], 0, 2, Width / 2, Height / 2, 45);
                DrawGradient(CustomRoasterGradientColors[1], CustomRoasterGradientColors[0], Width / 2, 2, Width - 15, Height / 2, -45);
                DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[1], 0, Height / 2, Width / 2, Height, 45);
                DrawGradient(CustomRoasterGradientColors[1], CustomRoasterGradientColors[0], Width / 2, Height / 2, Width, Height / 2, 315);
                G.FillRectangle(new SolidBrush(Color.FromArgb(13, CustomRoasterBackgroundStateColors[0])), 0, 0, Width, (Height / 2) - 7);
                DrawBorders(new Pen(CustomRoasterBorderColor), 0);
                DrawBorders(new Pen(CustomRoasterBorderColor), 1);
                DrawBorders(new Pen(CustomRoasterGradientColors[1]), 3);
                G.DrawLine(new Pen(CustomRoasterGradientColors[3]), 3, 3, Width - 5, 3);
                G.DrawLine(new Pen(CustomRoasterGradientColors[2]), 0, Height - 1, Width, Height - 1);
                DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[2], 0, 0, 1, Height);
                DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[2], Width - 1, 0, 1, Height);
            }
            else if (State == MouseState.Down)
            {
                DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[1], 0, 2, Width / 2, Height / 2, 45);
                DrawGradient(CustomRoasterGradientColors[1], CustomRoasterGradientColors[0], Width / 2, 2, Width - 15, Height / 2, -45);
                DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[1], 0, Height / 2, Width / 2, Height, 45);
                DrawGradient(CustomRoasterGradientColors[1], CustomRoasterGradientColors[0], Width / 2, Height / 2, Width, Height / 2, 315);
                G.FillRectangle(new SolidBrush(Color.FromArgb(20, CustomRoasterBackgroundStateColors[1])), 0, 0, Width, (Height / 2) - 7);
                DrawBorders(new Pen(CustomRoasterBorderColor), 0);
                DrawBorders(new Pen(CustomRoasterBorderColor), 1);
                DrawBorders(new Pen(CustomRoasterGradientColors[1]), 3);
                G.DrawLine(new Pen(CustomRoasterGradientColors[3]), 3, 3, Width - 5, 3);
                G.DrawLine(new Pen(CustomRoasterGradientColors[2]), 0, Height - 1, Width, Height - 1);
                DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[2], 0, 0, 1, Height);
                DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[2], Width - 1, 0, 1, Height);
            }
            else
            {
            }

            DrawCorners(BackColor);
            //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);

        } 
        #endregion

    }

}
