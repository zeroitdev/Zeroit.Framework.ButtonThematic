// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="AdvancedSystem.cs" company="Zeroit Dev Technologies">
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
    public partial class ButtonThematic
    {

        /// <summary>
        /// The advanced system glow
        /// </summary>
        private Color advancedSystemGlow = Color.FromArgb(40, 95, 210);

        /// <summary>
        /// Gets or sets the advanced system glow.
        /// </summary>
        /// <value>The advanced system glow.</value>
        [Browsable(false)]
        public Color AdvancedSystemGlow
        {
            get { return advancedSystemGlow; }
            set
            {
                advancedSystemGlow = value;
                Invalidate();
            }
        }
        
        
        private void AdvancedSystemPaint(System.Windows.Forms.PaintEventArgs e)
        {
            G.Clear(Parent.BackColor);
            
            int slope = 5;

            Rectangle mainRect = new Rectangle(0, 0, Width - 1, Height - 1);
            GraphicsPath mainPath = Draw.RoundRect(mainRect, slope);
            G.FillPath(new LinearGradientBrush(mainRect, BackColor, Color.FromArgb(25, Color.Black), 90f), mainPath);
            G.DrawPath(new Pen(Color.FromArgb(BackColor.R / 2, BackColor.G / 2, BackColor.B / 2)), mainPath);

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
            G.DrawPath(new Pen(Color.FromArgb(glow, advancedSystemGlow)), mainPath);

            int textX = ((Width - 1) / 2) - Convert.ToInt32((G.MeasureString(Text, Font).Width / 2));
            int textY = ((Height - 1) / 2) - Convert.ToInt32((G.MeasureString(Text, Font).Height / 2));

            //G.DrawString(Text, Font, new SolidBrush(ForeColor), new Point(textX, textY));
            
        }

    }
}
