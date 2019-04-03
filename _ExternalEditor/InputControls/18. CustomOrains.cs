// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="18. CustomOrains.cs" company="Zeroit Dev Technologies">
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
        /// The custom orains inner border
        /// </summary>
        Color customOrainsInnerBorder = Color.FromArgb(40, 40, 40);
        /// <summary>
        /// The custom orains header
        /// </summary>
        Color customOrainsHeader = Color.FromArgb(40, 40, 40);
        /// <summary>
        /// The custom orains outer border
        /// </summary>
        Color customOrainsOuterBorder = Color.Black;

        /// <summary>
        /// The custom orains button
        /// </summary>
        private Color[] customOrainsButton = new Color[]
        {
            Color.FromArgb(35, 35, 35),
            Color.FromArgb(20, 20, 20)
        };

        /// <summary>
        /// The custom orains hatch
        /// </summary>
        private Color[] customOrainsHatch = new Color[]
        {
            Color.Black,
            Color.Transparent
        };

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the custom orains hatch.
        /// </summary>
        /// <value>The custom orains hatch.</value>
        public Color[] CustomOrainsHatch
        {
            get { return customOrainsHatch; }
            set
            {
                customOrainsHatch = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom orains button.
        /// </summary>
        /// <value>The custom orains button.</value>
        public Color[] CustomOrainsButton
        {
            get { return customOrainsButton; }
            set { customOrainsButton = value;  }
        }

        /// <summary>
        /// Gets or sets the custom orains inner border.
        /// </summary>
        /// <value>The custom orains inner border.</value>
        public Color CustomOrainsInnerBorder
        {
            get { return customOrainsInnerBorder; }
            set { customOrainsInnerBorder = value;  }
        }

        /// <summary>
        /// Gets or sets the custom orains header.
        /// </summary>
        /// <value>The custom orains header.</value>
        public Color CustomOrainsHeader
        {
            get { return customOrainsHeader; }
            set { customOrainsHeader = value;  }
        }

        /// <summary>
        /// Gets or sets the custom orains outer border.
        /// </summary>
        /// <value>The custom orains outer border.</value>
        public Color CustomOrainsOuterBorder
        {
            get { return customOrainsOuterBorder; }
            set { customOrainsOuterBorder = value;  }
        } 
        #endregion

        
    }

}

