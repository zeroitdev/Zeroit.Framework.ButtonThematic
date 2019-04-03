// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="15. CustomizedButton.cs" company="Zeroit Dev Technologies">
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
