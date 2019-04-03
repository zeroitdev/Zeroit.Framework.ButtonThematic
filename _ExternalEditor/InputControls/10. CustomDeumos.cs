// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="10. CustomDeumos.cs" company="Zeroit Dev Technologies">
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
        /// The custom deumos background
        /// </summary>
        private Color customDeumosBackground = Color.FromArgb(14, 14, 14);

        /// <summary>
        /// The custom deumos corner color
        /// </summary>
        private Color customDeumosCornerColor = Color.FromArgb(16, 16, 16);

        /// <summary>
        /// The custom deumos over state color
        /// </summary>
        private Color customDeumosOverStateColor = Color.FromArgb(5, Color.White);

        /// <summary>
        /// The custom deumos border colors
        /// </summary>
        private Color[] customDeumosBorderColors = new Color[]
        {
            Color.FromArgb(62, 62, 62),
            Color.FromArgb(15, Color.White),
            Color.Black
        };

        /// <summary>
        /// The custom deumos down state colors
        /// </summary>
        private Color[] customDeumosDownStateColors = new Color[]
        {
            Color.FromArgb(14, 14, 14),
            Color.FromArgb(41, 41, 41)
        };

        /// <summary>
        /// The custom deumos none state colors
        /// </summary>
        private Color[] customDeumosNoneStateColors = new Color[]
        {
            Color.FromArgb(30, Color.White),
            Color.FromArgb(5, Color.White)
        };

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the custom deumos border colors.
        /// </summary>
        /// <value>The custom deumos border colors.</value>
        public Color[] CustomDeumosBorderColors
        {
            get { return customDeumosBorderColors; }
            set
            {
                customDeumosBorderColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom deumos background.
        /// </summary>
        /// <value>The custom deumos background.</value>
        public Color CustomDeumosBackground
        {
            get { return customDeumosBackground; }
            set
            {
                customDeumosBackground = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom deumos down state colors.
        /// </summary>
        /// <value>The custom deumos down state colors.</value>
        public Color[] CustomDeumosDownStateColors
        {
            get { return customDeumosDownStateColors; }
            set
            {
                customDeumosDownStateColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the custom deumos over state.
        /// </summary>
        /// <value>The color of the custom deumos over state.</value>
        public Color CustomDeumosOverStateColor
        {
            get { return customDeumosOverStateColor; }
            set { customDeumosOverStateColor = value;  }
        }

        /// <summary>
        /// Gets or sets the custom deumos none state colors.
        /// </summary>
        /// <value>The custom deumos none state colors.</value>
        public Color[] CustomDeumosNoneStateColors
        {
            get { return customDeumosNoneStateColors; }
            set { customDeumosNoneStateColors = value;  }
        }

        /// <summary>
        /// Gets or sets the color of the custom deumos corner.
        /// </summary>
        /// <value>The color of the custom deumos corner.</value>
        public Color CustomDeumosCornerColor
        {
            get { return customDeumosCornerColor; }
            set { customDeumosCornerColor = value; }
        }

        #endregion

        
    }

}

