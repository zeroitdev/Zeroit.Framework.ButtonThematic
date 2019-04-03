// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="06. CustomBitDefender.cs" company="Zeroit Dev Technologies">
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
        /// The custom bit defender c1
        /// </summary>
        private Color customBitDefenderC1 = Color.FromArgb(100, 41, 41, 41);
        /// <summary>
        /// The custom bit defender c2
        /// </summary>
        private Color customBitDefenderC2 = Color.White;
        /// <summary>
        /// The custom bit defender c3
        /// </summary>
        private Color customBitDefenderC3 = Color.FromArgb(101, 101, 101);
        /// <summary>
        /// The custom bit defender c4
        /// </summary>
        private Color customBitDefenderC4 = Color.FromArgb(60, 60, 60);
        /// <summary>
        /// The custom bit defender c5
        /// </summary>
        private Color customBitDefenderC5 = Color.FromArgb(28, 28, 28);
        /// <summary>
        /// The custom bit defender c6
        /// </summary>
        private Color customBitDefenderC6 = Color.FromArgb(45, 45, 45);
        /// <summary>
        /// The custom bit defender border
        /// </summary>
        private Color customBitDefenderBorder = Color.Black;
        /// <summary>
        /// The custom bit defender fade color
        /// </summary>
        private Color customBitDefenderFadeColor = Color.White;
        //private int customBitDefenderCurve = 11;


        #endregion

        #region Public Properties

        //public int CustomBitDefenderCurve
        //{
        //    get { return customBitDefenderCurve; }
        //    set
        //    {
        //        customBitDefenderCurve = value;

        //    }
        //}

        /// <summary>
        /// Gets or sets the custom bit defender c1.
        /// </summary>
        /// <value>The custom bit defender c1.</value>
        public Color CustomBitDefenderC1
        {
            get { return customBitDefenderC1; }
            set { customBitDefenderC1 = value;  }
        }

        /// <summary>
        /// Gets or sets the custom bit defender c2.
        /// </summary>
        /// <value>The custom bit defender c2.</value>
        public Color CustomBitDefenderC2
        {
            get { return customBitDefenderC2; }
            set { customBitDefenderC2 = value;  }
        }

        /// <summary>
        /// Gets or sets the custom bit defender c3.
        /// </summary>
        /// <value>The custom bit defender c3.</value>
        public Color CustomBitDefenderC3
        {
            get { return customBitDefenderC3; }
            set { customBitDefenderC3 = value;  }
        }

        /// <summary>
        /// Gets or sets the custom bit defender c4.
        /// </summary>
        /// <value>The custom bit defender c4.</value>
        public Color CustomBitDefenderC4
        {
            get { return customBitDefenderC4; }
            set { customBitDefenderC4 = value;  }
        }

        /// <summary>
        /// Gets or sets the custom bit defender c5.
        /// </summary>
        /// <value>The custom bit defender c5.</value>
        public Color CustomBitDefenderC5
        {
            get { return customBitDefenderC5; }
            set { customBitDefenderC5 = value;  }
        }

        /// <summary>
        /// Gets or sets the custom bit defender c6.
        /// </summary>
        /// <value>The custom bit defender c6.</value>
        public Color CustomBitDefenderC6
        {
            get { return customBitDefenderC6; }
            set { customBitDefenderC6 = value;  }
        }

        /// <summary>
        /// Gets or sets the custom bit defender border.
        /// </summary>
        /// <value>The custom bit defender border.</value>
        public Color CustomBitDefenderBorder
        {
            get { return customBitDefenderBorder; }
            set { customBitDefenderBorder = value;  }
        }

        /// <summary>
        /// Gets or sets the color of the custom bit defender fade.
        /// </summary>
        /// <value>The color of the custom bit defender fade.</value>
        public Color CustomBitDefenderFadeColor
        {
            get { return customBitDefenderFadeColor; }
            set
            {
                customBitDefenderFadeColor = value;
                
            }
        }

        #endregion

        

    }

}
