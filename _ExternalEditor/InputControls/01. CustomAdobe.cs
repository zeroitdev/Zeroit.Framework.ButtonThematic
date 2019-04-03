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
using System.Drawing;

namespace Zeroit.Framework.ButtonThematic.Controls
{
    /// <summary>
    /// Class ButtonInput.
    /// </summary>
    public partial class ButtonInput
    {

        #region Private Fields
        /// <summary>
        /// The customizable adobe colors
        /// </summary>
        private Color[] customizableAdobeColors = new Color[]
        {
            Color.FromArgb(105, 105, 105),
            Color.FromArgb(56, 56, 56),
            Color.FromArgb(73, 73, 73),
            Color.FromArgb(48, 48, 48),
            Color.White,
            Color.Black
        };

        /// <summary>
        /// The customizable adobe background
        /// </summary>
        Color customizableAdobeBackground = Color.FromArgb(102, 102, 102);

        /// <summary>
        /// The customizable adobe coefficient
        /// </summary>
        int customizableAdobeCoefficient = 15;

        /// <summary>
        /// The customizable adobe border offset
        /// </summary>
        private int customizableAdobeBorderOffset = 2;


        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the customizable adobe colors.
        /// </summary>
        /// <value>The customizable adobe colors.</value>
        public Color[] CustomizableAdobeColors
        {
            get { return customizableAdobeColors; }
            set
            {
                customizableAdobeColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the customizable adobe background.
        /// </summary>
        /// <value>The customizable adobe background.</value>
        public Color CustomizableAdobeBackground
        {
            get { return customizableAdobeBackground; }
            set
            {
                customizableAdobeBackground = value;
            }
        }

        /// <summary>
        /// Gets or sets the customizable adobe coefficient.
        /// </summary>
        /// <value>The customizable adobe coefficient.</value>
        public int CustomizableAdobeCoefficient
        {
            get { return customizableAdobeCoefficient; }
            set
            {
                customizableAdobeCoefficient = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the customizable adobe border offset.
        /// </summary>
        /// <value>The customizable adobe border offset.</value>
        public int CustomizableAdobeBorderOffset
        {
            get { return customizableAdobeBorderOffset; }
            set
            {
                customizableAdobeBorderOffset = value;
                
            }
        }

        #endregion

        

    }
}
