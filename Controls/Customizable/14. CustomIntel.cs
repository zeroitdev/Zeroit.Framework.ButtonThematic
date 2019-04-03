// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="14. CustomIntel.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        #region Private Fields
        //private int customIntelGlow = 180;
        //private Color customIntelBackgroundColor = Color.SteelBlue;
        //private Color customIntelBorderColor = Color.DeepSkyBlue;
        //private Color customIntelShade = Color.Black;
        //private int customIntelCurve = 8;
        #endregion

        #region Public Properties
        [Browsable(false)]
        public int CustomIntelGlow
        {
            get { return buttonInput.CustomIntelGlow; }
            set
            {
                buttonInput.CustomIntelGlow = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color CustomIntelBackgroundColor
        {
            get { return buttonInput.CustomIntelBackgroundColor; }
            set { buttonInput.CustomIntelBackgroundColor = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomIntelBorderColor
        {
            get { return buttonInput.CustomIntelBorderColor; }
            set { buttonInput.CustomIntelBorderColor = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomIntelShade
        {
            get { return buttonInput.CustomIntelShade; }
            set { buttonInput.CustomIntelShade = value; Invalidate(); }
        }

        //public int CustomIntelCurve
        //{
        //    get { return CustomIntelCurve; }
        //    set
        //    {
        //        CustomIntelCurve = value;
        //        Invalidate();
        //    }
        //} 

        #endregion

        #region Paint and Private Methods
        public void CustomiButton()
        {
            IsAnimated = true;

        }

        private void CustomIntelPaintHook()
        {
            //G.Clear(Color.FromArgb(45, 45, 45));

            G.Clear(Parent.BackColor);

            GraphicsPath gp = CreateRound(new Rectangle(0, 0, Width - 1, Height - 1), Curve);
            PathGradientBrush pgb = new PathGradientBrush(gp);

            G.FillPath(new SolidBrush(CustomIntelShade), gp);

            pgb.CenterColor = Color.FromArgb(200, CustomIntelBackgroundColor);
            pgb.SurroundColors = new Color[] { Color.FromArgb(CustomIntelGlow, CustomIntelBackgroundColor) };
            pgb.CenterPoint = new Point((this.Width - 1) / 2, (this.Height - 1) / 2);

            G.FillPath(pgb, gp);
            G.DrawPath(new Pen(CustomIntelBorderColor), gp);

            int textWidth = (int)this.CreateGraphics().MeasureString(Text, Font).Width;
            int textHeight = (int)this.CreateGraphics().MeasureString(Text, Font).Height;
            SolidBrush textShadow = new SolidBrush(Color.FromArgb(30, 15, 0));
            Rectangle textRect = new Rectangle(3, 3, textWidth + 10, textHeight);
            Point textPoint = new Point((Width / 2) - (textWidth / 2), (Height / 2) - (textHeight / 2));
            Point textShadowPoint = new Point((Width / 2) - (textWidth / 2) + 1, (Height / 2) - (textHeight / 2) + 1);

            //G.DrawString(Text, Font, textShadow, textShadowPoint);
            //G.DrawString(Text, Font, Brushes.WhiteSmoke, textPoint);

        }

        private void CustomIntelOnAnimation()
        {
            if (State == MouseState.Over)
            {
                if (CustomIntelGlow < 230)
                    CustomIntelGlow += 1;
            }
            else
            {
                if (CustomIntelGlow > 182)
                {
                    CustomIntelGlow -= 2;
                }
                else if (CustomIntelGlow > 180 & CustomIntelGlow < 182)
                {
                    CustomIntelGlow = 180;
                }
            }
        }

        #endregion

    }

}

