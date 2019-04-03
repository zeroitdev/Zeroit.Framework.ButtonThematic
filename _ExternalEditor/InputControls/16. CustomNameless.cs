// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="16. CustomNameless.cs" company="Zeroit Dev Technologies">
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
        /// The custom nameless border colors
        /// </summary>
        private Color[] customNamelessBorderColors = new Color[]
        {
            Color.FromArgb(50, 50, 50),
            Color.Black,
            Color.Black
        };

        /// <summary>
        /// The custom nameless none highlight
        /// </summary>
        private Color[] customNamelessNoneHighlight = new Color[]
        {
            Color.White,
            Color.FromArgb(130, 130, 130),
            Color.FromArgb(40, 40, 40)

        };

        /// <summary>
        /// The custom nameless over highlight
        /// </summary>
        private Color[] customNamelessOverHighlight = new Color[]
        {
            Color.White,
            Color.FromArgb(150, 150, 150),
            Color.FromArgb(50, 50, 50)

        };

        /// <summary>
        /// The custom nameless down highlight
        /// </summary>
        private Color[] customNamelessDownHighlight = new Color[]
        {
            Color.White,
            Color.FromArgb(60, 60, 60),
            Color.FromArgb(22, 22, 22)

        };

        /// <summary>
        /// The custom nameless corners
        /// </summary>
        private Color customNamelessCorners = Color.Black;

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the custom nameless corners.
        /// </summary>
        /// <value>The custom nameless corners.</value>
        public Color CustomNamelessCorners
        {
            get { return customNamelessCorners; }
            set
            {
                customNamelessCorners = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom nameless border colors.
        /// </summary>
        /// <value>The custom nameless border colors.</value>
        public Color[] CustomNamelessBorderColors
        {
            get { return customNamelessBorderColors; }
            set { customNamelessBorderColors = value;  }
        }

        /// <summary>
        /// Gets or sets the custom nameless none highlight.
        /// </summary>
        /// <value>The custom nameless none highlight.</value>
        public Color[] CustomNamelessNoneHighlight
        {
            get { return customNamelessNoneHighlight; }
            set { customNamelessNoneHighlight = value;  }
        }

        /// <summary>
        /// Gets or sets the custom nameless over highlight.
        /// </summary>
        /// <value>The custom nameless over highlight.</value>
        public Color[] CustomNamelessOverHighlight
        {
            get { return customNamelessOverHighlight; }
            set
            {
                customNamelessOverHighlight = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom nameless down highlight.
        /// </summary>
        /// <value>The custom nameless down highlight.</value>
        public Color[] CustomNamelessDownHighlight
        {
            get { return customNamelessDownHighlight; }
            set
            {
                customNamelessDownHighlight = value;
                
            }
        } 
        #endregion
        
    }

}

