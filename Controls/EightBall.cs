// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="EightBall.cs" company="Zeroit Dev Technologies">
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

    public partial class ButtonThematic
    {
        
        private System.Windows.Forms.Timer eightBallwithEventsField_animTimer = new System.Windows.Forms.Timer { Interval = 25 };
        private System.Windows.Forms.Timer eightBallAnimationTimer
        {
            get { return eightBallwithEventsField_animTimer; }
            set
            {
                if (eightBallwithEventsField_animTimer != null)
                {
                    eightBallwithEventsField_animTimer.Tick -= EightBallAnimationTimerTick;
                }
                eightBallwithEventsField_animTimer = value;
                if (eightBallwithEventsField_animTimer != null)
                {
                    eightBallwithEventsField_animTimer.Tick += EightBallAnimationTimerTick;
                }
            }
        }
        private bool eightBallGlowIncreasing = true;

        private int eightBallGlow = 2;
        private bool _animated = true;

        [Browsable(false)]
        public bool EightBallAnimation
        {
            get { return _animated; }
            set
            {
                _animated = value;
                Invalidate();
            }
        }


        private void EightBallButton()
        {
            
            EightBallAnimation = true;
            
        }

        private void EightBallOnPaint(System.Windows.Forms.PaintEventArgs e)
        {

            G.Clear(Parent.BackColor);
            G.SmoothingMode = Smoothing;

            Rectangle mainRect = new Rectangle(0, 0, Width - 1, Height - 1);
            GraphicsPath mainPath = Draw.RoundRect(mainRect, 6);

            LinearGradientBrush bgBrush = new LinearGradientBrush(mainRect, BackColor, Color.FromArgb(40, 40, 40), 90f);
            G.FillPath(bgBrush, mainPath);
            if (State == MouseState.Down)
            {
                G.FillPath(new SolidBrush(Color.FromArgb(25, Color.White)), mainPath);

            }
            else if (State == MouseState.Over)
            {
                if (_animated)
                {
                    G.FillPath(new SolidBrush(Color.FromArgb(eightBallGlow, Color.White)), mainPath);
                }
                else
                {
                    G.FillPath(new SolidBrush(Color.FromArgb(12, Color.White)), mainPath);

                }
            }
            else
            {
                if (_animated)
                {

                    G.FillPath(new SolidBrush(Color.FromArgb(eightBallGlow, Color.White)), mainPath);

                }

            }

            int textX = 0;
            int textY = 0;
            textX = ((Width - 1) / 2) - Convert.ToInt32((G.MeasureString(Text, Font).Width / 2));
            textY = ((Height - 1) / 2) - Convert.ToInt32((G.MeasureString(Text, Font).Height / 2));

            //Draw.ShadowedString(G, Text, Font, new SolidBrush(ForeColor), new Point(textX, textY));

            G.DrawPath(new Pen(Color.FromArgb(60, 60, 60)), mainPath);

        }

        private void EightBallAnimationTimerTick(object sender, System.EventArgs e)
        {
            if (eightBallGlowIncreasing)
            {
                if (eightBallGlow < 16)
                {
                    eightBallGlow += 2;
                }
                else
                {
                    eightBallAnimationTimer.Enabled = false;
                }
            }
            else
            {
                if (eightBallGlow > 0)
                {
                    eightBallGlow -= 2;
                }
                else
                {
                    eightBallAnimationTimer.Enabled = false;
                }
            }
            Invalidate();
        }

        private void EightBallOnMouseEnter(System.EventArgs e)
        {
            State = MouseState.Over;
            if (_animated)
            {
                eightBallGlowIncreasing = true;
                eightBallAnimationTimer.Enabled = true;
            }
            Invalidate();
        }

        private void EightBallOnMouseLeave(System.EventArgs e)
        {
            State = MouseState.None;
            if (_animated)
            {
                eightBallGlowIncreasing = false;
                eightBallAnimationTimer.Enabled = true;
            }
            Invalidate();
        }

        private void EightBallOnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            State = MouseState.Down;
            Invalidate();
        }

        private void EightBallOnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            State = MouseState.Over;
            Invalidate();
        }

    }


}

