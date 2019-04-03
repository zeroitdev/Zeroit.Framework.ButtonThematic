// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="02. CustomAdvancedSystem.cs" company="Zeroit Dev Technologies">
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
        /// The slope
        /// </summary>
        int slope = 5;
        /// <summary>
        /// The customizableadvanced system glow
        /// </summary>
        private Color customizableadvancedSystemGlow = Color.FromArgb(40, 95, 210);
        /// <summary>
        /// The customizable adv system back color
        /// </summary>
        private Color customizableAdvSysBackColor = Color.FromArgb(25, 25, 25);
        /// <summary>
        /// The custom adv system color dilution
        /// </summary>
        private Color customAdvSysColorDilution = Color.FromArgb(25, Color.Black);
        //int customAdvSysGlow = 0;

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the customizable advanced system glow.
        /// </summary>
        /// <value>The customizable advanced system glow.</value>
        public Color CustomizableAdvancedSystemGlow
        {
            get { return customizableadvancedSystemGlow; }
            set
            {
                customizableadvancedSystemGlow = value;
                
            }
        }

        /// <summary>
        /// Gets or sets the customizable advanced system slope.
        /// </summary>
        /// <value>The customizable advanced system slope.</value>
        public int CustomizableAdvancedSystemSlope
        {
            get { return slope; }
            set { slope = value; }
        }

        /// <summary>
        /// Gets or sets the color of the customizable adv system back.
        /// </summary>
        /// <value>The color of the customizable adv system back.</value>
        public Color CustomizableAdvSysBackColor
        {
            get { return customizableAdvSysBackColor; }
            set
            {
                customizableAdvSysBackColor = value;
                
            }
        }



        /// <summary>
        /// Gets or sets the custom adv system color dilution.
        /// </summary>
        /// <value>The custom adv system color dilution.</value>
        public Color CustomAdvSysColorDilution
        {
            get { return customAdvSysColorDilution; }
            set
            {
                customAdvSysColorDilution = value;
                
            }
        }
        #endregion

        

    }
}
