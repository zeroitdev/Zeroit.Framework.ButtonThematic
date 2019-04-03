// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="05. CustomBasic.cs" company="Zeroit Dev Technologies">
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
        /// The custom basic colors
        /// </summary>
        private Color[] customBasicColors = new Color[]
        {
            Color.FromArgb(255, 55, 55, 55),
            Color.FromArgb(255, 22, 22, 22),
            Color.FromArgb(255, 100, 0, 0),
            Color.FromArgb(255, 60, 0, 0)
        };

        /// <summary>
        /// The custom basic highlights
        /// </summary>
        private Color[] customBasicHighlights = new Color[]
        {
            Color.FromArgb(25, 255, 255, 255),
            Color.FromArgb(25, 255, 255, 255),
            Color.FromArgb(25, 255, 255, 255)
        };

        /// <summary>
        /// The custom basic state colors
        /// </summary>
        private Color[] customBasicStateColors = new Color[]
        {
            Color.FromArgb(255, 60, 0, 0),
            Color.FromArgb(255, 100, 0, 0)
        };

        /// <summary>
        /// The custom basic border colors
        /// </summary>
        private Color[] customBasicBorderColors = new Color[]
        {
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black
        };

        /// <summary>
        /// The custom basic disabled
        /// </summary>
        private Color[] customBasicDisabled = new Color[]
        {
            Color.FromArgb(255, 40, 40, 40),
            Color.FromArgb(255, 20, 20, 20),
            Color.FromArgb(13, 255, 255, 255)
        };

        /// <summary>
        /// The custom basic offset
        /// </summary>
        private int customBasicOffset = 3;

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the custom basic border colors.
        /// </summary>
        /// <value>The custom basic border colors.</value>
        public Color[] CustomBasicBorderColors
        {
            get { return customBasicBorderColors; }
            set
            {
                customBasicBorderColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom basic state colors.
        /// </summary>
        /// <value>The custom basic state colors.</value>
        public Color[] CustomBasicStateColors
        {
            get { return customBasicStateColors; }
            set
            {
                customBasicStateColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom basic colors.
        /// </summary>
        /// <value>The custom basic colors.</value>
        public Color[] CustomBasicColors
        {
            get { return customBasicColors; }
            set
            {
                customBasicColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom basic highlights.
        /// </summary>
        /// <value>The custom basic highlights.</value>
        public Color[] CustomBasicHighlights
        {
            get { return customBasicHighlights; }
            set
            {
                customBasicHighlights = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom basic disabled.
        /// </summary>
        /// <value>The custom basic disabled.</value>
        public Color[] CustomBasicDisabled
        {
            get { return customBasicDisabled; }
            set
            {
                customBasicDisabled = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom basic offset.
        /// </summary>
        /// <value>The custom basic offset.</value>
        public int CustomBasicOffset
        {
            get { return customBasicOffset; }
            set
            {
                customBasicOffset = value;
                
            }
        } 
        #endregion

        

    }

}
