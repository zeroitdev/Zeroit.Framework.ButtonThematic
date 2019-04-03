// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="12. CustomFuture.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    /// <summary>
    /// Class ButtonInput.
    /// </summary>
    public partial class ButtonInput
    {


        #region Private Fields

        /// <summary>
        /// The custom fusion grad colors
        /// </summary>
        private Color[] customFusionGradColors = new Color[]
        {
            Color.FromArgb(40, 40, 40),
            Color.FromArgb(48, 48, 48)
        };
        /// <summary>
        /// The custom fusion corner color
        /// </summary>
        private Color customFusionCornerColor = Color.FromArgb(40, 40, 40);
        /// <summary>
        /// The custom fusion none border color
        /// </summary>
        private Color customFusionNoneBorderColor = Color.Black;
        /// <summary>
        /// The custom fusion down border color
        /// </summary>
        private Color customFusionDownBorderColor = Color.FromArgb(24, 24, 24);
        /// <summary>
        /// The custom fusion over border color
        /// </summary>
        private Color customFusionOverBorderColor = Color.FromArgb(44, 44, 44);
        /// <summary>
        /// The custom fusion blend
        /// </summary>
        private ColorBlend customFusionBlend = new ColorBlend
        {
            Colors = new Color[]
            {
                Color.FromArgb(28, 28, 28),
                Color.FromArgb(32, 32, 32),
                Color.FromArgb(24, 24, 24),
            },
            Positions = new float[] {
                0f,
                0.5f,
                1f
            }
        };

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the custom fusion blend.
        /// </summary>
        /// <value>The custom fusion blend.</value>
        public ColorBlend CustomFusionBlend
        {
            get { return customFusionBlend; }
            set
            {
                customFusionBlend = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom fusion grad colors.
        /// </summary>
        /// <value>The custom fusion grad colors.</value>
        public Color[] CustomFusionGradColors
        {
            get { return customFusionGradColors; }
            set
            {
                customFusionGradColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the color of the custom fusion corner.
        /// </summary>
        /// <value>The color of the custom fusion corner.</value>
        public Color CustomFusionCornerColor
        {
            get { return customFusionCornerColor; }
            set { customFusionCornerColor = value;  }
        }

        /// <summary>
        /// Gets or sets the color of the custom fusion none border.
        /// </summary>
        /// <value>The color of the custom fusion none border.</value>
        public Color CustomFusionNoneBorderColor
        {
            get { return customFusionNoneBorderColor; }
            set { customFusionNoneBorderColor = value;  }
        }

        /// <summary>
        /// Gets or sets the color of the custom fusion down border.
        /// </summary>
        /// <value>The color of the custom fusion down border.</value>
        public Color CustomFusionDownBorderColor
        {
            get { return customFusionDownBorderColor; }
            set { customFusionDownBorderColor = value;  }
        }

        /// <summary>
        /// Gets or sets the color of the custom fusion over border.
        /// </summary>
        /// <value>The color of the custom fusion over border.</value>
        public Color CustomFusionOverBorderColor
        {
            get { return customFusionOverBorderColor; }
            set { customFusionOverBorderColor = value;  }
        } 
        #endregion
        
        
    }

}

