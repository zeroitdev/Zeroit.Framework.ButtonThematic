// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="14. CustomIntel.cs" company="Zeroit Dev Technologies">
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
        /// The custom intel background color
        /// </summary>
        private Color customIntelBackgroundColor = Color.SteelBlue;
        /// <summary>
        /// The custom intel border color
        /// </summary>
        private Color customIntelBorderColor = Color.DeepSkyBlue;
        /// <summary>
        /// The custom intel shade
        /// </summary>
        private Color customIntelShade = Color.Black;
        /// <summary>
        /// The custom intel glow
        /// </summary>
        private int customIntelGlow = 180;

        //private int customIntelCurve = 8;

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the custom intel glow.
        /// </summary>
        /// <value>The custom intel glow.</value>
        public int CustomIntelGlow
        {
            get { return customIntelGlow; }
            set
            {
                customIntelGlow = value;

            }
        }

        /// <summary>
        /// Gets or sets the color of the custom intel background.
        /// </summary>
        /// <value>The color of the custom intel background.</value>
        public Color CustomIntelBackgroundColor
        {
            get { return customIntelBackgroundColor; }
            set { customIntelBackgroundColor = value; }
        }

        /// <summary>
        /// Gets or sets the color of the custom intel border.
        /// </summary>
        /// <value>The color of the custom intel border.</value>
        public Color CustomIntelBorderColor
        {
            get { return customIntelBorderColor; }
            set { customIntelBorderColor = value; }
        }

        /// <summary>
        /// Gets or sets the custom intel shade.
        /// </summary>
        /// <value>The custom intel shade.</value>
        public Color CustomIntelShade
        {
            get { return customIntelShade; }
            set { customIntelShade = value; }
        }

        //public int CustomIntelCurve
        //{
        //    get { return customIntelCurve; }
        //    set
        //    {
        //        customIntelCurve = value;

        //    }
        //} 
        #endregion
        

    }

}

