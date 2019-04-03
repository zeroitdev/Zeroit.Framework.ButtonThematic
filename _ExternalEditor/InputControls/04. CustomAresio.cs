// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="04. CustomAresio.cs" company="Zeroit Dev Technologies">
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
        /// The custom aresio border colors
        /// </summary>
        private Color[] customAresioBorderColors = new Color[]
        {
            Color.FromArgb(50,Color.White),
            Color.FromArgb(150, 100, 70)
        };

        /// <summary>
        /// The custom aresio none colors
        /// </summary>
        private Color[] customAresioNoneColors = new Color[]
        {
            Color.FromArgb(250, 200, 70),
            Color.FromArgb(250, 160, 40)
        };

        /// <summary>
        /// The custom aresio over colors
        /// </summary>
        private Color[] customAresioOverColors = new Color[]
        {
            Color.FromArgb(50, Color.White),
            Color.Transparent
        };

        /// <summary>
        /// The custom aresio down colors
        /// </summary>
        private Color[] customAresioDownColors = new Color[]
        {
            Color.FromArgb(50, Color.Black),
            Color.Transparent
        };

        //private int customAresioCurve = 4;

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the custom aresio border colors.
        /// </summary>
        /// <value>The custom aresio border colors.</value>
        public Color[] CustomAresioBorderColors
        {
            get { return customAresioBorderColors; }
            set
            {
                customAresioBorderColors = value;
                
            }
        }

        //public int CustomAresioCurve
        //{
        //    get { return customAresioCurve; }
        //    set
        //    {
        //        customAresioCurve = value;

        //    }
        //}

        /// <summary>
        /// Gets or sets the custom aresio none colors.
        /// </summary>
        /// <value>The custom aresio none colors.</value>
        public Color[] CustomAresioNoneColors
        {
            get { return customAresioNoneColors; }
            set { customAresioNoneColors = value;  }
        }

        /// <summary>
        /// Gets or sets the custom aresio over colors.
        /// </summary>
        /// <value>The custom aresio over colors.</value>
        public Color[] CustomAresioOverColors
        {
            get { return customAresioOverColors; }
            set { customAresioOverColors = value;  }
        }

        /// <summary>
        /// Gets or sets the custom aresio down colors.
        /// </summary>
        /// <value>The custom aresio down colors.</value>
        public Color[] CustomAresioDownColors
        {
            get { return customAresioDownColors; }
            set
            {
                customAresioDownColors = value;
                
            }
        }

        #endregion

        

    }


}
