// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="19. CustomRecon.cs" company="Zeroit Dev Technologies">
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
        /// The custom recon none state colors
        /// </summary>
        private Color[] customReconNoneStateColors = new Color[]
        {
            Color.FromArgb(22, 22, 22),
            Color.FromArgb(34, 34, 34)
        };

        /// <summary>
        /// The custom recon down state colors
        /// </summary>
        private Color[] customReconDownStateColors = new Color[]
        {
            Color.FromArgb(28, 28, 28),
            Color.FromArgb(38, 38, 38),
            Color.FromArgb(100, 0, 0, 0),
            Color.Transparent
        };

        /// <summary>
        /// The custom recon over state colors
        /// </summary>
        private Color[] customReconOverStateColors = new Color[]
        {
            Color.FromArgb(28, 28, 28),
            Color.FromArgb(38, 38, 38),
            Color.FromArgb(100, 50, 50, 50),
            Color.Transparent
        };

        /// <summary>
        /// The custom recon border
        /// </summary>
        private Color[] customReconBorder = new Color[]
        {
            Color.Black,
            Color.FromArgb(52, 52, 52)
        };

        /// <summary>
        /// The custom recon background
        /// </summary>
        private Color customReconBackground = Color.FromArgb(49, 49, 49);

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the custom recon background.
        /// </summary>
        /// <value>The custom recon background.</value>
        public Color CustomReconBackground
        {
            get { return customReconBackground; }
            set
            {
                customReconBackground = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom recon none state colors.
        /// </summary>
        /// <value>The custom recon none state colors.</value>
        public Color[] CustomReconNoneStateColors
        {
            get { return customReconNoneStateColors; }
            set { customReconNoneStateColors = value;  }
        }

        /// <summary>
        /// Gets or sets the custom recon down state colors.
        /// </summary>
        /// <value>The custom recon down state colors.</value>
        public Color[] CustomReconDownStateColors
        {
            get { return customReconDownStateColors; }
            set { customReconDownStateColors = value;  }
        }

        /// <summary>
        /// Gets or sets the custom recon over state colors.
        /// </summary>
        /// <value>The custom recon over state colors.</value>
        public Color[] CustomReconOverStateColors
        {
            get { return customReconOverStateColors; }
            set { customReconOverStateColors = value;  }
        }

        /// <summary>
        /// Gets or sets the custom recon border.
        /// </summary>
        /// <value>The custom recon border.</value>
        public Color[] CustomReconBorder
        {
            get { return customReconBorder; }
            set
            {
                customReconBorder = value;
                
            }
        } 
        #endregion

        
    }

}

