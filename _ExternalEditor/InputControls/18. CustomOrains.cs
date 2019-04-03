// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="18. CustomOrains.cs" company="Zeroit Dev Technologies">
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

