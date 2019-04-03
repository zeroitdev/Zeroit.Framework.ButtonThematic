// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="04. CustomAresio.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Button control.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
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
