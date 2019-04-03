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
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    /// <summary>
    /// Class ButtonThematic.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    public partial class ButtonThematic
    {

        #region Private Fields
        //private Color customizableadvancedSystemGlow = Color.FromArgb(40, 95, 210);
        //int slope = 5;
        ////int customAdvSysGlow = 0;
        //private Color customizableAdvSysBackColor = Color.FromArgb(25, 25, 25);
        //private Color customAdvSysColorDilution = Color.FromArgb(25, Color.Black);

        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the customizable advanced system glow.
        /// </summary>
        /// <value>The customizable advanced system glow.</value>
        [Browsable(false)]
        public Color CustomizableAdvancedSystemGlow
        {
            get { return buttonInput.CustomizableAdvancedSystemGlow; }
            set
            {
                buttonInput.CustomizableAdvancedSystemGlow = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the customizable advanced system slope.
        /// </summary>
        /// <value>The customizable advanced system slope.</value>
        [Browsable(false)]
        public int CustomizableAdvancedSystemSlope
        {
            get { return buttonInput.CustomizableAdvancedSystemSlope; }
            set { buttonInput.CustomizableAdvancedSystemSlope = value; }
        }

        /// <summary>
        /// Gets or sets the color of the customizable adv system back.
        /// </summary>
        /// <value>The color of the customizable adv system back.</value>
        [Browsable(false)]
        public Color CustomizableAdvSysBackColor
        {
            get { return buttonInput.CustomizableAdvSysBackColor; }
            set
            {
                buttonInput.CustomizableAdvSysBackColor = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom adv system color dilution.
        /// </summary>
        /// <value>The custom adv system color dilution.</value>
        [Browsable(false)]
        public Color CustomAdvSysColorDilution
        {
            get { return buttonInput.CustomAdvSysColorDilution; }
            set
            {
                buttonInput.CustomAdvSysColorDilution = value;
                Invalidate();
            }
        }
        #endregion

        #region Paint

        private void CustomizableAdvancedSystemPaint(System.Windows.Forms.PaintEventArgs e)
        {
            G.Clear(Parent.BackColor);

            Rectangle mainRect = new Rectangle(0, 0, Width - 1, Height - 1);
            GraphicsPath mainPath = Draw.RoundRect(mainRect, Curve);
            G.FillPath(new LinearGradientBrush(mainRect, CustomizableAdvSysBackColor, CustomAdvSysColorDilution, 90f), mainPath);
            G.DrawPath(new Pen(Color.FromArgb(CustomizableAdvSysBackColor.R / 2, CustomizableAdvSysBackColor.G / 2, CustomizableAdvSysBackColor.B / 2)), mainPath);

            int glow = 0;


            if (State == MouseState.Over)
            {
                glow = 200;
            }
            else if (State == MouseState.Down)
            {
                glow = 255;
            }
            else
            {
                glow = 100;
            }
            G.DrawPath(new Pen(Color.FromArgb(glow, CustomizableAdvancedSystemGlow)), mainPath);

            int textX = ((Width - 1) / 2) - Convert.ToInt32((G.MeasureString(Text, Font).Width / 2));
            int textY = ((Height - 1) / 2) - Convert.ToInt32((G.MeasureString(Text, Font).Height / 2));

            //G.DrawString(Text, Font, new SolidBrush(ForeColor), new Point(textX, textY));

        }

        #endregion

    }
}
