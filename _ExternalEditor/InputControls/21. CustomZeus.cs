// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="21. CustomZeus.cs" company="Zeroit Dev Technologies">
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
        /// The custom zeus gradient colors
        /// </summary>
        private Color[] customZeusGradientColors = new Color[]
        {
            Color.AliceBlue,
            Color.FromArgb(150, 255, 255)
        };

        /// <summary>
        /// The custom zeus border colors
        /// </summary>
        private Color[] customZeusBorderColors = new Color[]
        {
            Color.Black,
            Color.AliceBlue
        };

        /// <summary>
        /// The custom zeus background
        /// </summary>
        Color customZeusBackground = Color.FromArgb(38, 38, 38);

        /// <summary>
        /// The custom zeus click reduce
        /// </summary>
        private int customZeusClickReduce = 5;

        /// <summary>
        /// The custom zeus click locate
        /// </summary>
        private int customZeusClickLocate = 2;

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the custom zeus background.
        /// </summary>
        /// <value>The custom zeus background.</value>
        public Color CustomZeusBackground
        {
            get { return customZeusBackground; }
            set
            {
                customZeusBackground = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom zeus gradient colors.
        /// </summary>
        /// <value>The custom zeus gradient colors.</value>
        public Color[] CustomZeusGradientColors
        {
            get { return customZeusGradientColors; }
            set
            {
                customZeusGradientColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom zeus border colors.
        /// </summary>
        /// <value>The custom zeus border colors.</value>
        public Color[] CustomZeusBorderColors
        {
            get { return customZeusBorderColors; }
            set
            {
                customZeusBorderColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom zeus click reduce.
        /// </summary>
        /// <value>The custom zeus click reduce.</value>
        public int CustomZeusClickReduce
        {
            get { return customZeusClickReduce; }
            set { customZeusClickReduce = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom zeus click locate.
        /// </summary>
        /// <value>The custom zeus click locate.</value>
        public int CustomZeusClickLocate
        {
            get { return customZeusClickLocate; }
            set { customZeusClickLocate = value;
                
            }
        }

        #endregion
        

        
    }

}

