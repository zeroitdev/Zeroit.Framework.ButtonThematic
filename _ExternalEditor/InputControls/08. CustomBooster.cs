// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="08. CustomBooster.cs" company="Zeroit Dev Technologies">
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
        /// The custom booster colors
        /// </summary>
        private Color[] customBoosterColors = new Color[]
        {
            Color.FromArgb(22,22,22),
            Color.FromArgb(95,0,0)

        };

        /// <summary>
        /// The custom booster hatch colors
        /// </summary>
        private Color[] customBoosterHatchColors = new Color[]
        {
            Color.FromArgb(0,0,0),
            Color.FromArgb(50, 95,0,0)

        };

        /// <summary>
        /// The custom booster outer border
        /// </summary>
        private Color customBoosterOuterBorder = Color.Black;
        /// <summary>
        /// The custom booster inner border
        /// </summary>
        private Color customBoosterInnerBorder = Color.Black;

        /// <summary>
        /// The upper left curve
        /// </summary>
        private int upperLeftCurve = 10;
        /// <summary>
        /// The upper right curve
        /// </summary>
        private int upperRightCurve = 10;
        /// <summary>
        /// Down left curve
        /// </summary>
        private int downLeftCurve = 10;
        /// <summary>
        /// Down right curve
        /// </summary>
        private int downRightCurve = 10;
        /// <summary>
        /// The custom booster offset
        /// </summary>
        private int customBoosterOffset = 6;
        /// <summary>
        /// The custom gradient angle
        /// </summary>
        private float customGradientAngle = 270f;
        /// <summary>
        /// The custom booster hover transparency
        /// </summary>
        private float customBoosterHoverTransparency = 50f;
        /// <summary>
        /// The custom booster influence outer
        /// </summary>
        private bool customBoosterInfluenceOuter = false;


        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the upper left curve.
        /// </summary>
        /// <value>The upper left curve.</value>
        public int UpperLeftCurve
        {
            get { return upperLeftCurve; }
            set
            {
                upperLeftCurve = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the upper right curve.
        /// </summary>
        /// <value>The upper right curve.</value>
        public int UpperRightCurve
        {
            get { return upperRightCurve; }
            set
            {
                upperRightCurve = value;
                
            }
        }

        /// <summary>
        /// Gets or sets down left curve.
        /// </summary>
        /// <value>Down left curve.</value>
        public int DownLeftCurve
        {
            get { return downLeftCurve; }
            set
            {
                downLeftCurve = value;
                
            }
        }

        /// <summary>
        /// Gets or sets down right curve.
        /// </summary>
        /// <value>Down right curve.</value>
        public int DownRightCurve
        {
            get { return downRightCurve; }
            set
            {
                downRightCurve = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom booster colors.
        /// </summary>
        /// <value>The custom booster colors.</value>
        public Color[] CustomBoosterColors
        {
            get { return customBoosterColors; }
            set { customBoosterColors = value;  }
        }

        /// <summary>
        /// Gets or sets the custom booster gradient angle.
        /// </summary>
        /// <value>The custom booster gradient angle.</value>
        public float CustomBoosterGradientAngle
        {
            get { return customGradientAngle; }
            set
            {
                customGradientAngle = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom booster outer border.
        /// </summary>
        /// <value>The custom booster outer border.</value>
        public Color CustomBoosterOuterBorder
        {
            get { return customBoosterOuterBorder; }
            set { customBoosterOuterBorder = value;  }
        }

        /// <summary>
        /// Gets or sets the custom booster inner border.
        /// </summary>
        /// <value>The custom booster inner border.</value>
        public Color CustomBoosterInnerBorder
        {
            get { return customBoosterInnerBorder; }
            set { customBoosterInnerBorder = value;  }
        }

        /// <summary>
        /// Gets or sets the custom booster offset.
        /// </summary>
        /// <value>The custom booster offset.</value>
        public int CustomBoosterOffset
        {
            get { return customBoosterOffset; }
            set
            {
                customBoosterOffset = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom booster hover transparency.
        /// </summary>
        /// <value>The custom booster hover transparency.</value>
        public float CustomBoosterHoverTransparency
        {
            get { return customBoosterHoverTransparency; }
            set
            {
                customBoosterHoverTransparency = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom booster hatch colors.
        /// </summary>
        /// <value>The custom booster hatch colors.</value>
        public Color[] CustomBoosterHatchColors
        {
            get { return customBoosterHatchColors; }
            set
            {
                customBoosterHatchColors = value;
                
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [custom booster influence outer].
        /// </summary>
        /// <value><c>true</c> if [custom booster influence outer]; otherwise, <c>false</c>.</value>
        public bool CustomBoosterInfluenceOuter
        {
            get { return customBoosterInfluenceOuter; }
            set
            {
                customBoosterInfluenceOuter = value;
                
            }
        }
        #endregion

        
    }

}
