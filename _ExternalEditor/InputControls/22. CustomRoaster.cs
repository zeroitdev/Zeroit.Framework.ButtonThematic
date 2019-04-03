// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="22. CustomRoaster.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
