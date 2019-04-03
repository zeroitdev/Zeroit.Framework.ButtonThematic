// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="17. CustomNetSeal.cs" company="Zeroit Dev Technologies">
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
        /// The custom net seal path borders
        /// </summary>
        private Color[] customNetSealPathBorders = new Color[]
        {
            Color.FromArgb(24, 24, 24),
            Color.FromArgb(65, 65, 65)
        };

        /// <summary>
        /// The custom net seal center color
        /// </summary>
        private Color customNetSealCenterColor = Color.FromArgb(60, 60, 60);

        /// <summary>
        /// The custom net seal surround color
        /// </summary>
        private Color customNetSealSurroundColor = Color.FromArgb(55, 55, 55);

        /// <summary>
        /// The custom focus scales
        /// </summary>
        private PointF customFocusScales = new PointF(0.8f, 0.5f);

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the custom net seal path borders.
        /// </summary>
        /// <value>The custom net seal path borders.</value>
        public Color[] CustomNetSealPathBorders
        {
            get { return customNetSealPathBorders; }
            set
            {
                customNetSealPathBorders = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the custom net seal center.
        /// </summary>
        /// <value>The color of the custom net seal center.</value>
        public Color CustomNetSealCenterColor
        {
            get { return customNetSealCenterColor; }
            set
            {
                customNetSealCenterColor = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the custom net seal surround.
        /// </summary>
        /// <value>The color of the custom net seal surround.</value>
        public Color CustomNetSealSurroundColor
        {
            get { return customNetSealSurroundColor; }
            set { customNetSealSurroundColor = value;  }
        }

        /// <summary>
        /// Gets or sets the custom focus scales.
        /// </summary>
        /// <value>The custom focus scales.</value>
        public PointF CustomFocusScales
        {
            get { return customFocusScales; }
            set { customFocusScales = value;  }
        }
        #endregion

        

    }

}

