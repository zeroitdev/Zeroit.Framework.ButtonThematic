// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="05. CustomBasic.cs" company="Zeroit Dev Technologies">
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
        /// The custom basic colors
        /// </summary>
        private Color[] customBasicColors = new Color[]
        {
            Color.FromArgb(255, 55, 55, 55),
            Color.FromArgb(255, 22, 22, 22),
            Color.FromArgb(255, 100, 0, 0),
            Color.FromArgb(255, 60, 0, 0)
        };

        /// <summary>
        /// The custom basic highlights
        /// </summary>
        private Color[] customBasicHighlights = new Color[]
        {
            Color.FromArgb(25, 255, 255, 255),
            Color.FromArgb(25, 255, 255, 255),
            Color.FromArgb(25, 255, 255, 255)
        };

        /// <summary>
        /// The custom basic state colors
        /// </summary>
        private Color[] customBasicStateColors = new Color[]
        {
            Color.FromArgb(255, 60, 0, 0),
            Color.FromArgb(255, 100, 0, 0)
        };

        /// <summary>
        /// The custom basic border colors
        /// </summary>
        private Color[] customBasicBorderColors = new Color[]
        {
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black
        };

        /// <summary>
        /// The custom basic disabled
        /// </summary>
        private Color[] customBasicDisabled = new Color[]
        {
            Color.FromArgb(255, 40, 40, 40),
            Color.FromArgb(255, 20, 20, 20),
            Color.FromArgb(13, 255, 255, 255)
        };

        /// <summary>
        /// The custom basic offset
        /// </summary>
        private int customBasicOffset = 3;

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the custom basic border colors.
        /// </summary>
        /// <value>The custom basic border colors.</value>
        public Color[] CustomBasicBorderColors
        {
            get { return customBasicBorderColors; }
            set
            {
                customBasicBorderColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom basic state colors.
        /// </summary>
        /// <value>The custom basic state colors.</value>
        public Color[] CustomBasicStateColors
        {
            get { return customBasicStateColors; }
            set
            {
                customBasicStateColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom basic colors.
        /// </summary>
        /// <value>The custom basic colors.</value>
        public Color[] CustomBasicColors
        {
            get { return customBasicColors; }
            set
            {
                customBasicColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom basic highlights.
        /// </summary>
        /// <value>The custom basic highlights.</value>
        public Color[] CustomBasicHighlights
        {
            get { return customBasicHighlights; }
            set
            {
                customBasicHighlights = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom basic disabled.
        /// </summary>
        /// <value>The custom basic disabled.</value>
        public Color[] CustomBasicDisabled
        {
            get { return customBasicDisabled; }
            set
            {
                customBasicDisabled = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom basic offset.
        /// </summary>
        /// <value>The custom basic offset.</value>
        public int CustomBasicOffset
        {
            get { return customBasicOffset; }
            set
            {
                customBasicOffset = value;
                
            }
        } 
        #endregion

        

    }

}
