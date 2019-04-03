// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="19. CustomRecon.cs" company="Zeroit Dev Technologies">
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

