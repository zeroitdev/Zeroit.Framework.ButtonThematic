// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="03. CustomAdvantium.cs" company="Zeroit Dev Technologies">
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
        /// The custom advantium offsets
        /// </summary>
        private int[] customAdvantiumOffsets = new int[]
        {
            1,
            0,
            0
        };

        /// <summary>
        /// The custom advantium border colors
        /// </summary>
        private Color[] customAdvantiumBorderColors = new Color[]
        {
            Color.FromArgb(59, 59, 59),
            Color.FromArgb(25, 25, 25),
            Color.FromArgb(35, 35, 35)

        };

        /// <summary>
        /// The custom advantium none colors
        /// </summary>
        private Color[] customAdvantiumNoneColors = new Color[]
        {
            Color.FromArgb(50, 50, 50),
            Color.FromArgb(42, 42, 42)
        };

        /// <summary>
        /// The custom advantium down colors
        /// </summary>
        private Color[] customAdvantiumDownColors = new Color[]
        {
            Color.FromArgb(50, 50, 50),
            Color.FromArgb(42, 42, 42)
        };

        /// <summary>
        /// The custom advantium over colors
        /// </summary>
        private Color[] customAdvantiumOverColors = new Color[]
        {
            Color.FromArgb(42, 42, 42),
            Color.FromArgb(50, 50, 50)

        };

        /// <summary>
        /// The custom advantium back
        /// </summary>
        Color customAdvantiumBack = Color.FromArgb(40, 40, 40);

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the custom advantium offsets.
        /// </summary>
        /// <value>The custom advantium offsets.</value>
        public int[] CustomAdvantiumOffsets
        {
            get { return customAdvantiumOffsets; }
            set { customAdvantiumOffsets = value;  }
        }

        /// <summary>
        /// Gets or sets the custom advantium background.
        /// </summary>
        /// <value>The custom advantium background.</value>
        public Color CustomAdvantiumBackground
        {
            get { return customAdvantiumBack; }
            set { customAdvantiumBack = value;  }
        }

        /// <summary>
        /// Gets or sets the custom advantium none colors.
        /// </summary>
        /// <value>The custom advantium none colors.</value>
        public Color[] CustomAdvantiumNoneColors
        {
            get { return customAdvantiumNoneColors; }
            set { customAdvantiumNoneColors = value;  }
        }

        /// <summary>
        /// Gets or sets the custom advantium down colors.
        /// </summary>
        /// <value>The custom advantium down colors.</value>
        public Color[] CustomAdvantiumDownColors
        {
            get { return customAdvantiumDownColors; }
            set { customAdvantiumDownColors = value;  }
        }

        /// <summary>
        /// Gets or sets the custom advantium over colors.
        /// </summary>
        /// <value>The custom advantium over colors.</value>
        public Color[] CustomAdvantiumOverColors
        {
            get { return customAdvantiumOverColors; }
            set { customAdvantiumOverColors = value;  }
        }

        /// <summary>
        /// Gets or sets the custom advantium border colors.
        /// </summary>
        /// <value>The custom advantium border colors.</value>
        public Color[] CustomAdvantiumBorderColors
        {
            get { return customAdvantiumBorderColors; }
            set { customAdvantiumBorderColors = value;  }
        }
        #endregion
        

    }
}
