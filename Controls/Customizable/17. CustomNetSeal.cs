// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="17. CustomNetSeal.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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

