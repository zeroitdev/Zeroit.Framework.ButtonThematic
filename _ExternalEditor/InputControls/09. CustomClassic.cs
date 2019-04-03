// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="09. CustomClassic.cs" company="Zeroit Dev Technologies">
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
        /// The custom classic colors
        /// </summary>
        private Color[] customClassicColors = new Color[]
        {
            Color.FromArgb(0, 156, 255),
            Color.Transparent
        };
        /// <summary>
        /// The custom classic border
        /// </summary>
        private Color customClassicBorder = Color.Black;
        /// <summary>
        /// The custom classic highlight
        /// </summary>
        private Color customClassicHighlight = Color.FromArgb(35, 35, 35);
        /// <summary>
        /// The custom classic background
        /// </summary>
        private Color customClassicBackground = Color.FromArgb(24, 24, 24);
        /// <summary>
        /// The custom classic shadow
        /// </summary>
        private Color customClassicShadow = Color.FromArgb(100, Color.Black);

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the custom classic border.
        /// </summary>
        /// <value>The custom classic border.</value>
        public Color CustomClassicBorder
        {
            get { return customClassicBorder; }
            set
            {
                customClassicBorder = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom classic highlight.
        /// </summary>
        /// <value>The custom classic highlight.</value>
        public Color CustomClassicHighlight
        {
            get { return customClassicHighlight; }
            set { customClassicHighlight = value;  }
        }

        /// <summary>
        /// Gets or sets the custom classic background.
        /// </summary>
        /// <value>The custom classic background.</value>
        public Color CustomClassicBackground
        {
            get { return customClassicBackground; }
            set { customClassicBackground = value;  }
        }

        /// <summary>
        /// Gets or sets the custom classic shadow.
        /// </summary>
        /// <value>The custom classic shadow.</value>
        public Color CustomClassicShadow
        {
            get { return customClassicShadow; }
            set { customClassicShadow = value;  }
        }

        /// <summary>
        /// Gets or sets the custom classic colors.
        /// </summary>
        /// <value>The custom classic colors.</value>
        public Color[] CustomClassicColors
        {
            get { return customClassicColors; }
            set
            {
                customClassicColors = value;
                
            }
        }
        #endregion
        
    }

}

