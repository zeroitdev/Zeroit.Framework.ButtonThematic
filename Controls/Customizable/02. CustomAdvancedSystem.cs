// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="02. CustomAdvancedSystem.cs" company="Zeroit Dev Technologies">
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
