// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="20. CustomSpicyLips.cs" company="Zeroit Dev Technologies">
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
        /// The custom spicy none state colors
        /// </summary>
        private Color[] customSpicyNoneStateColors = new Color[]
        {
            Color.FromArgb(40, 40, 40),
            Color.FromArgb(28, 28, 28)
        };

        /// <summary>
        /// The custom spicy over state colors
        /// </summary>
        private Color[] customSpicyOverStateColors = new Color[]
        {
            Color.FromArgb(40, 40, 40),
            Color.FromArgb(28, 28, 28)
        };

        /// <summary>
        /// The custom spicy down state colors
        /// </summary>
        private Color[] customSpicyDownStateColors = new Color[]
        {
            Color.FromArgb(4, 4, 4),
            Color.FromArgb(20, 20, 20)
        };

        /// <summary>
        /// The custom spicy border colors
        /// </summary>
        private Color[] customSpicyBorderColors = new Color[]
        {
            Color.Black,
            Color.Black
        };

        /// <summary>
        /// The custom spicy corner color
        /// </summary>
        private Color customSpicyCornerColor = Color.FromArgb(20, 20, 20);

        /// <summary>
        /// The custom spicy highlight
        /// </summary>
        private Color customSpicyHighlight = Color.White;

        /// <summary>
        /// The custom spicy background
        /// </summary>
        private Color customSpicyBackground = Color.FromArgb(1, 1, 1);

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the custom spicy background.
        /// </summary>
        /// <value>The custom spicy background.</value>
        public Color CustomSpicyBackground
        {
            get { return customSpicyBackground; }
            set
            {
                customSpicyBackground = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom spicy none state colors.
        /// </summary>
        /// <value>The custom spicy none state colors.</value>
        public Color[] CustomSpicyNoneStateColors
        {
            get { return customSpicyNoneStateColors; }
            set { customSpicyNoneStateColors = value;  }
        }

        /// <summary>
        /// Gets or sets the custom spicy over state colors.
        /// </summary>
        /// <value>The custom spicy over state colors.</value>
        public Color[] CustomSpicyOverStateColors
        {
            get { return customSpicyOverStateColors; }
            set { customSpicyOverStateColors = value;  }
        }

        /// <summary>
        /// Gets or sets the custom spicy down state colors.
        /// </summary>
        /// <value>The custom spicy down state colors.</value>
        public Color[] CustomSpicyDownStateColors
        {
            get { return customSpicyDownStateColors; }
            set { customSpicyDownStateColors = value;  }
        }

        /// <summary>
        /// Gets or sets the custom spicy highlight.
        /// </summary>
        /// <value>The custom spicy highlight.</value>
        public Color CustomSpicyHighlight
        {
            get { return customSpicyHighlight; }
            set { customSpicyHighlight = value;  }
        }

        /// <summary>
        /// Gets or sets the custom spicy border colors.
        /// </summary>
        /// <value>The custom spicy border colors.</value>
        public Color[] CustomSpicyBorderColors
        {
            get { return customSpicyBorderColors; }
            set { customSpicyBorderColors = value;  }
        }

        /// <summary>
        /// Gets or sets the color of the custom spicy corner.
        /// </summary>
        /// <value>The color of the custom spicy corner.</value>
        public Color CustomSpicyCornerColor
        {
            get { return customSpicyCornerColor; }
            set
            {
                customSpicyCornerColor = value;
                
            }
        }


        #endregion
        
    }

}

