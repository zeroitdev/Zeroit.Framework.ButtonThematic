// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="15. CustomizedButton.cs" company="Zeroit Dev Technologies">
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
        /// The customized BTN inactive
        /// </summary>
        private Color[] customizedBtnInactive = new Color[]
        {
            Color.FromArgb(25,25,25),
            Color.FromArgb(0,0,0)
        };

        /// <summary>
        /// The customized BTN active
        /// </summary>
        private Color[] customizedBtnActive = new Color[]
        {
            Color.FromArgb(0,0,0),
            Color.FromArgb(25,25,25)
        };

        /// <summary>
        /// The customized BTN active border
        /// </summary>
        private Color[] customizedBtnActiveBorder = new Color[]
        {
            Color.FromArgb(60,60,60),
            Color.FromArgb(100,100,100)
        };

        /// <summary>
        /// The customized BTN pressed
        /// </summary>
        private Color[] customizedBtnPressed = new Color[]
        {
            Color.FromArgb(0,0,0),
            Color.FromArgb(25,25,25)
        };

        /// <summary>
        /// The customized BTN pressed border
        /// </summary>
        private Color[] customizedBtnPressedBorder = new Color[]
        {
            Color.FromArgb(60, 60, 60),
            Color.FromArgb(100, 100, 100)
        };

        /// <summary>
        /// The customized BTN offset gradient
        /// </summary>
        private Color[] customizedBtnOffsetGradient = new Color[]
        {
            Color.FromArgb(25, 25, 25),
            Color.FromArgb(60, 60, 60)
        };

        /// <summary>
        /// The customized BTN offset border
        /// </summary>
        private Color[] customizedBtnOffsetBorder = new Color[]
        {
            Color.FromArgb(10,10,10),
            Color.FromArgb(100,100,100)
        };

        /// <summary>
        /// The customized BTN inactive border
        /// </summary>
        private Color customizedBtnInactiveBorder = Color.FromArgb(20, 20, 20);

        /// <summary>
        /// The customized BTN offset
        /// </summary>
        private int customizedBtnOffset = 3;

        //private int customizedBtnRounding = 50;


        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the customized BTN offset.
        /// </summary>
        /// <value>The customized BTN offset.</value>
        public int CustomizedBtnOffset
        {
            get { return customizedBtnOffset; }
            set { customizedBtnOffset = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the customized BTN inactive.
        /// </summary>
        /// <value>The customized BTN inactive.</value>
        public Color[] CustomizedBtnInactive
        {
            get { return customizedBtnInactive; }
            set { customizedBtnInactive = value;  }
        }

        /// <summary>
        /// Gets or sets the customized BTN active.
        /// </summary>
        /// <value>The customized BTN active.</value>
        public Color[] CustomizedBtnActive
        {
            get { return customizedBtnActive; }
            set { customizedBtnActive = value;  }
        }

        /// <summary>
        /// Gets or sets the customized BTN active border.
        /// </summary>
        /// <value>The customized BTN active border.</value>
        public Color[] CustomizedBtnActiveBorder
        {
            get { return customizedBtnActiveBorder; }
            set { customizedBtnActiveBorder = value;  }
        }

        /// <summary>
        /// Gets or sets the customized BTN pressed.
        /// </summary>
        /// <value>The customized BTN pressed.</value>
        public Color[] CustomizedBtnPressed
        {
            get { return customizedBtnPressed; }
            set { customizedBtnPressed = value;  }
        }

        /// <summary>
        /// Gets or sets the customized BTN pressed border.
        /// </summary>
        /// <value>The customized BTN pressed border.</value>
        public Color[] CustomizedBtnPressedBorder
        {
            get { return customizedBtnPressedBorder; }
            set { customizedBtnPressedBorder = value;  }
        }

        //public int CustomizedBtnRounding
        //{
        //    get { return customizedBtnRounding; }
        //    set { customizedBtnRounding = value;

        //    }
        //}

        /// <summary>
        /// Gets or sets the customized BTN offset gradient.
        /// </summary>
        /// <value>The customized BTN offset gradient.</value>
        public Color[] CustomizedBtnOffsetGradient
        {
            get { return customizedBtnOffsetGradient; }
            set { customizedBtnOffsetGradient = value; }
        }

        /// <summary>
        /// Gets or sets the customized BTN offset border.
        /// </summary>
        /// <value>The customized BTN offset border.</value>
        public Color[] CustomizedBtnOffsetBorder
        {
            get { return customizedBtnOffsetBorder; }
            set { customizedBtnOffsetBorder = value; }
        }

        /// <summary>
        /// Gets or sets the customized BTN inactive border.
        /// </summary>
        /// <value>The customized BTN inactive border.</value>
        public Color CustomizedBtnInactiveBorder
        {
            get { return customizedBtnInactiveBorder; }
            set { customizedBtnInactiveBorder = value; }
        }

        #endregion

        


    }


}
