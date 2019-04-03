// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="01. CustomAdobe.cs" company="Zeroit Dev Technologies">
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
using System;
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

        //private Color customizableAdobeBackground = Color.FromArgb(102, 102, 102);

        //int customizableAdobeCoefficient = 15;

        //private int customizableAdobeBorderOffset = 2;

        //private Color[] customizableAdobeColors = new Color[]
        //{
        //    Color.FromArgb(105, 105, 105),
        //    Color.FromArgb(56, 56, 56),
        //    Color.FromArgb(73, 73, 73),
        //    Color.FromArgb(48, 48, 48),
        //    Color.White,
        //    Color.Black
        //};

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the customizable adobe colors.
        /// </summary>
        /// <value>The customizable adobe colors.</value>
        [Browsable(false)]
        public Color[] CustomizableAdobeColors
        {
            get { return buttonInput.CustomizableAdobeColors; }
            set
            {
                buttonInput.CustomizableAdobeColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the customizable adobe background.
        /// </summary>
        /// <value>The customizable adobe background.</value>
        [Browsable(false)]
        public Color CustomizableAdobeBackground
        {
            get { return buttonInput.CustomizableAdobeBackground; }
            set { buttonInput.CustomizableAdobeBackground = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the customizable adobe coefficient.
        /// </summary>
        /// <value>The customizable adobe coefficient.</value>
        [Browsable(false)]
        public int CustomizableAdobeCoefficient
        {
            get { return buttonInput.CustomizableAdobeCoefficient; }
            set
            {
                buttonInput.CustomizableAdobeCoefficient = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the customizable adobe border offset.
        /// </summary>
        /// <value>The customizable adobe border offset.</value>
        [Browsable(false)]
        public int CustomizableAdobeBorderOffset
        {
            get { return buttonInput.CustomizableAdobeBorderOffset; }
            set
            {
                buttonInput.CustomizableAdobeBorderOffset = value;
                Invalidate();
            }
        }

        #endregion

        #region Paint

        /// <summary>
        /// Customizables the adobe paint hook.
        /// </summary>
        private void CustomizableAdobePaintHook()
        {
            G.Clear(CustomizableAdobeBackground);

            DrawGradient(CustomizableAdobeColors[0], CustomizableAdobeColors[1], 0, 0, Width, Height, 90);
            DrawGradient(CustomizableAdobeColors[2], CustomizableAdobeColors[3], 1, 1, Width - 2, Height - 2, 90);

            switch (State)
            {
                case MouseState.None:
                    break;
                //NULL
                case MouseState.Over:

                    CustomizableAdobeCoefficient = 5;
                    break;
                case MouseState.Down:

                    CustomizableAdobeCoefficient = 10;
                    break;
            }

            for (int i = 1; i <= 5; i++)
            {
                G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(Convert.ToInt32(255 / (i * CustomizableAdobeCoefficient)), CustomizableAdobeColors[4]))), new Rectangle(i, i, Width - 2 - (i * 2), Height - 2 - (i * 2)));
            }

            DrawBorders(new Pen(CustomizableAdobeColors[5]), CustomizableAdobeBorderOffset);


        }

        #endregion

    }
}
