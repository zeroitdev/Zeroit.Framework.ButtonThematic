// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="13. CustomGameBooster.cs" company="Zeroit Dev Technologies">
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
        /// The custom game booster top gradient
        /// </summary>
        private Color customGameBoosterTopGradient = Color.FromArgb(55, 55, 55);
        /// <summary>
        /// The custom game booster bot gradient
        /// </summary>
        private Color customGameBoosterBotGradient = Color.FromArgb(32, 32, 32);
        /// <summary>
        /// The custom game booster top gradient click
        /// </summary>
        private Color customGameBoosterTopGradientClick = Color.FromArgb(60, 60, 60);
        /// <summary>
        /// The custom game booster bot gradient click
        /// </summary>
        private Color customGameBoosterBotGradientClick = Color.FromArgb(37, 37, 37);
        /// <summary>
        /// The custom game booster top gradient hover
        /// </summary>
        private Color customGameBoosterTopGradientHover = Color.FromArgb(66, 66, 66);
        /// <summary>
        /// The custom game booster bot gradient hover
        /// </summary>
        private Color customGameBoosterBotGradientHover = Color.FromArgb(41, 41, 41);
        /// <summary>
        /// The custom game booster corner color
        /// </summary>
        private Color customGameBoosterCornerColor = Color.FromArgb(51, 51, 51);
        /// <summary>
        /// The custom game booster inner border
        /// </summary>
        private Color customGameBoosterInnerBorder = Color.FromArgb(76, 76, 76);
        /// <summary>
        /// The custom game booster outer border
        /// </summary>
        private Color customGameBoosterOuterBorder = Color.Black;
        /// <summary>
        /// The custom game booster inner border hover
        /// </summary>
        private Color customGameBoosterInnerBorderHover = Color.FromArgb(87, 87, 87);
        /// <summary>
        /// The custom game booster outer border hover
        /// </summary>
        private Color customGameBoosterOuterBorderHover = Color.Black;
        /// <summary>
        /// The custom game booster inner border click
        /// </summary>
        private Color customGameBoosterInnerBorderClick = Color.FromArgb(71, 71, 71);
        /// <summary>
        /// The custom game booster outer border click
        /// </summary>
        private Color customGameBoosterOuterBorderClick = Color.Black;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the custom game booster top gradient.
        /// </summary>
        /// <value>The custom game booster top gradient.</value>
        public Color CustomGameBoosterTopGradient
        {
            get { return customGameBoosterTopGradient; }
            set
            {
                customGameBoosterTopGradient = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the custom game booster bot gradient.
        /// </summary>
        /// <value>The custom game booster bot gradient.</value>
        public Color CustomGameBoosterBotGradient
        {
            get { return customGameBoosterBotGradient; }
            set { customGameBoosterBotGradient = value;  }
        }

        /// <summary>
        /// Gets or sets the custom game booster top gradient click.
        /// </summary>
        /// <value>The custom game booster top gradient click.</value>
        public Color CustomGameBoosterTopGradientClick
        {
            get { return customGameBoosterTopGradientClick; }
            set { customGameBoosterTopGradientClick = value;  }
        }

        /// <summary>
        /// Gets or sets the custom game booster bot gradient click.
        /// </summary>
        /// <value>The custom game booster bot gradient click.</value>
        public Color CustomGameBoosterBotGradientClick
        {
            get { return customGameBoosterBotGradientClick; }
            set { customGameBoosterBotGradientClick = value;  }
        }

        /// <summary>
        /// Gets or sets the custom game booster top gradient hover.
        /// </summary>
        /// <value>The custom game booster top gradient hover.</value>
        public Color CustomGameBoosterTopGradientHover
        {
            get { return customGameBoosterTopGradientHover; }
            set { customGameBoosterTopGradientHover = value;  }
        }

        /// <summary>
        /// Gets or sets the custom game booster bot gradient hover.
        /// </summary>
        /// <value>The custom game booster bot gradient hover.</value>
        public Color CustomGameBoosterBotGradientHover
        {
            get { return customGameBoosterBotGradientHover; }
            set { customGameBoosterBotGradientHover = value;  }
        }

        /// <summary>
        /// Gets or sets the color of the custom game booster corner.
        /// </summary>
        /// <value>The color of the custom game booster corner.</value>
        public Color CustomGameBoosterCornerColor
        {
            get { return customGameBoosterCornerColor; }
            set { customGameBoosterCornerColor = value;  }
        }

        /// <summary>
        /// Gets or sets the custom game booster inner border.
        /// </summary>
        /// <value>The custom game booster inner border.</value>
        public Color CustomGameBoosterInnerBorder
        {
            get { return customGameBoosterInnerBorder; }
            set { customGameBoosterInnerBorder = value;  }
        }

        /// <summary>
        /// Gets or sets the custom game booster outer border.
        /// </summary>
        /// <value>The custom game booster outer border.</value>
        public Color CustomGameBoosterOuterBorder
        {
            get { return customGameBoosterOuterBorder; }
            set { customGameBoosterOuterBorder = value;  }
        }

        /// <summary>
        /// Gets or sets the custom game booster inner border hover.
        /// </summary>
        /// <value>The custom game booster inner border hover.</value>
        public Color CustomGameBoosterInnerBorderHover
        {
            get { return customGameBoosterInnerBorderHover; }
            set { customGameBoosterInnerBorderHover = value;  }
        }

        /// <summary>
        /// Gets or sets the custom game booster outer border hover.
        /// </summary>
        /// <value>The custom game booster outer border hover.</value>
        public Color CustomGameBoosterOuterBorderHover
        {
            get { return customGameBoosterOuterBorderHover; }
            set { customGameBoosterOuterBorderHover = value;  }
        }

        /// <summary>
        /// Gets or sets the custom game booster inner border click.
        /// </summary>
        /// <value>The custom game booster inner border click.</value>
        public Color CustomGameBoosterInnerBorderClick
        {
            get { return customGameBoosterInnerBorderClick; }
            set { customGameBoosterInnerBorderClick = value;  }
        }

        /// <summary>
        /// Gets or sets the custom game booster outer border click.
        /// </summary>
        /// <value>The custom game booster outer border click.</value>
        public Color CustomGameBoosterOuterBorderClick
        {
            get { return customGameBoosterOuterBorderClick; }
            set { customGameBoosterOuterBorderClick = value;  }
        }
        #endregion



    }

}

