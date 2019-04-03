// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="17. CustomNetSeal.cs" company="Zeroit Dev Technologies">
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
        //private Color[] customNetSealPathBorders = new Color[]
        //{
        //    Color.FromArgb(24, 24, 24),
        //    Color.FromArgb(65, 65, 65)
        //};

        //private Color customNetSealCenterColor = Color.FromArgb(60, 60, 60);

        //private Color customNetSealSurroundColor = Color.FromArgb(55, 55, 55);

        //private PointF customFocusScales = new PointF(0.8f, 0.5f);
        #endregion

        #region Public Properties
        [Browsable(false)]
        public Color[] CustomNetSealPathBorders
        {
            get { return buttonInput.CustomNetSealPathBorders; }
            set
            {
                buttonInput.CustomNetSealPathBorders = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color CustomNetSealCenterColor
        {
            get { return buttonInput.CustomNetSealCenterColor; }
            set
            {
                buttonInput.CustomNetSealCenterColor = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color CustomNetSealSurroundColor
        {
            get { return buttonInput.CustomNetSealSurroundColor; }
            set { buttonInput.CustomNetSealSurroundColor = value; Invalidate(); }
        }

        [Browsable(false)]
        public PointF CustomFocusScales
        {
            get { return buttonInput.CustomFocusScales; }
            set { buttonInput.CustomFocusScales = value; Invalidate(); }
        }
        #endregion

        #region Paint
        private void CustomNetSealPaint(System.Windows.Forms.PaintEventArgs e)
        {

            G.Clear(Parent.BackColor);
            GraphicsPath GP1 = Draw.CreateRound(0, 0, Width - 1, Height - 1, Curve);
            GraphicsPath GP2 = Draw.CreateRound(1, 1, Width - 3, Height - 3, Curve);

            if (State == MouseState.Down)
            {
                PathGradientBrush PB1 = new PathGradientBrush(GP1);
                PB1.CenterColor = CustomNetSealCenterColor;
                PB1.SurroundColors = new Color[] { CustomNetSealSurroundColor };
                PB1.FocusScales = CustomFocusScales;

                G.FillPath(PB1, GP1);
            }
            else
            {
                LinearGradientBrush GB1 = new LinearGradientBrush(ClientRectangle, CustomNetSealCenterColor, CustomNetSealSurroundColor, GradientAngle);
                G.FillPath(GB1, GP1);
            }

            G.DrawPath(new Pen(CustomNetSealPathBorders[0]), GP1);
            G.DrawPath(new Pen(CustomNetSealPathBorders[1]), GP2);

            SizeF SZ1 = G.MeasureString(Text, Font);
            PointF PT1 = new PointF(5, Height / 2 - SZ1.Height / 2);

            if (State == MouseState.Down)
            {
                PT1.X += 1f;
                PT1.Y += 1f;
            }

            //G.DrawString(Text, Font, Brushes.Black, PT1.X + 1, PT1.Y + 1);
            //G.DrawString(Text, Font, Brushes.WhiteSmoke, PT1);
        }

        #endregion

    }

}

