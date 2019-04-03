// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="07. CustomBlackShades.cs" company="Zeroit Dev Technologies">
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
        /// The custom black shades none colors
        /// </summary>
        private Color[] customBlackShadesNoneColors = new Color[]
        {
            Color.FromArgb(32, 36, 38),
            Color.FromArgb(70, Color.White),
            Color.Transparent,
            Color.FromArgb(36, 31, 43),
            Color.FromArgb(61, 65, 68),
            Color.FromArgb(99, 103, 105),
            Color.FromArgb(27, 31, 33)
        };

        /// <summary>
        /// The custom black shades over colors
        /// </summary>
        private Color[] customBlackShadesOverColors = new Color[]
        {
            Color.FromArgb(32, 36, 38),
            Color.FromArgb(70, Color.White),
            Color.Transparent,
            Color.FromArgb(36, 31, 43),
            Color.FromArgb(61, 65, 68),
            Color.FromArgb(99, 103, 105),
            Color.FromArgb(100, 99, 103, 105),
            Color.FromArgb(27, 31, 33),
            Color.FromArgb(0, 186, 255)
        };

        /// <summary>
        /// The custom black shades down colors
        /// </summary>
        private Color[] customBlackShadesDownColors = new Color[]
        {
            Color.FromArgb(32, 36, 38),
            Color.FromArgb(32, 36, 38),
            Color.FromArgb(57, 57, 57),
            Color.FromArgb(57, 57, 57),
            Color.FromArgb(32, 36, 38),
            Color.FromArgb(57, 57, 57),
            Color.FromArgb(36, 31, 43),
            Color.FromArgb(61, 65, 68),
            Color.FromArgb(27, 31, 33)

        };

        //int customBlackShadesCurve = 3;

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the custom black shades none colors.
        /// </summary>
        /// <value>The custom black shades none colors.</value>
        public Color[] CustomBlackShadesNoneColors
        {
            get { return customBlackShadesNoneColors; }
            set
            {
                customBlackShadesNoneColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom black shades over colors.
        /// </summary>
        /// <value>The custom black shades over colors.</value>
        public Color[] CustomBlackShadesOverColors
        {
            get { return customBlackShadesOverColors; }
            set { customBlackShadesOverColors = value;  }
        }

        /// <summary>
        /// Gets or sets the custom black shades down colors.
        /// </summary>
        /// <value>The custom black shades down colors.</value>
        public Color[] CustomBlackShadesDownColors
        {
            get { return customBlackShadesDownColors; }
            set { customBlackShadesDownColors = value;  }
        }

        //public int CustomBlackShadesCurve
        //{
        //    get { return customBlackShadesCurve; }
        //    set
        //    {
        //        customBlackShadesCurve = value;
                
        //    }
        //}
        #endregion

        

    }


}
