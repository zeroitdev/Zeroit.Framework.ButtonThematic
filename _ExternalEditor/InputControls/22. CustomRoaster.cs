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
        /// The custom roaster gradient colors
        /// </summary>
        private Color[] customRoasterGradientColors = new Color[]
        {
            Color.FromArgb(0, 0, 0),
            Color.FromArgb(95, 0, 0),
            Color.FromArgb(73, 73, 73),
            Color.FromArgb(93, 93, 93)
        };

        /// <summary>
        /// The custom roaster background state colors
        /// </summary>
        private Color[] customRoasterBackgroundStateColors = new Color[]
        {
            Color.White,
            Color.Black
        };

        /// <summary>
        /// The custom roaster border color
        /// </summary>
        private Color customRoasterBorderColor = Color.Black;

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the custom roaster gradient colors.
        /// </summary>
        /// <value>The custom roaster gradient colors.</value>
        public Color[] CustomRoasterGradientColors
        {
            get { return customRoasterGradientColors; }
            set
            {
                customRoasterGradientColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the custom roaster border.
        /// </summary>
        /// <value>The color of the custom roaster border.</value>
        public Color CustomRoasterBorderColor
        {
            get { return customRoasterBorderColor; }
            set
            {
                customRoasterBorderColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom roaster background state colors.
        /// </summary>
        /// <value>The custom roaster background state colors.</value>
        public Color[] CustomRoasterBackgroundStateColors
        {
            get { return customRoasterBackgroundStateColors; }
            set
            {
                customRoasterBackgroundStateColors = value;
                
            }
        }
        #endregion
        

    }

}
