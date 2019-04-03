// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="12. CustomFuture.cs" company="Zeroit Dev Technologies">
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
        //private ColorBlend customFusionBlend = new ColorBlend
        //{
        //    Colors = new Color[]
        //    {
        //        Color.FromArgb(28, 28, 28),
        //        Color.FromArgb(32, 32, 32),
        //        Color.FromArgb(24, 24, 24),
        //    },
        //    Positions = new float[] {
        //        0f,
        //        0.5f,
        //        1f
        //    }
        //};

        //private Color[] customFusionGradColors = new Color[]
        //{
        //    Color.FromArgb(40, 40, 40),
        //    Color.FromArgb(48, 48, 48)
        //};

        //private Color customFusionCornerColor = Color.FromArgb(40, 40, 40);

        //private Color customFusionNoneBorderColor = Color.Black;
        //private Color customFusionDownBorderColor = Color.FromArgb(24, 24, 24);
        //private Color customFusionOverBorderColor = Color.FromArgb(44, 44, 44);
        #endregion

        #region Public Properties
        [Browsable(false)]
        public ColorBlend CustomFusionBlend
        {
            get { return buttonInput.CustomFusionBlend; }
            set
            {
                buttonInput.CustomFusionBlend = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] CustomFusionGradColors
        {
            get { return buttonInput.CustomFusionGradColors; }
            set
            {
                buttonInput.CustomFusionGradColors = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color CustomFusionCornerColor
        {
            get { return buttonInput.CustomFusionCornerColor; }
            set { buttonInput.CustomFusionCornerColor = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomFusionNoneBorderColor
        {
            get { return buttonInput.CustomFusionNoneBorderColor; }
            set { buttonInput.CustomFusionNoneBorderColor = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomFusionDownBorderColor
        {
            get { return buttonInput.CustomFusionDownBorderColor; }
            set { buttonInput.CustomFusionDownBorderColor = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomFusionOverBorderColor
        {
            get { return buttonInput.CustomFusionOverBorderColor; }
            set { buttonInput.CustomFusionOverBorderColor = value; Invalidate(); }
        }

        #endregion
        
        #region Paint

        private void CustomFuturePaintHook()
        {
            DrawGradient(CustomFusionBlend, ClientRectangle, 90f);

            LinearGradientBrush GB1 = new LinearGradientBrush(ClientRectangle, CustomFusionGradColors[0], CustomFusionGradColors[1], 90f);
            Pen P1 = new Pen(GB1);

            DrawBorders(new Pen(CustomFusionNoneBorderColor), 1);
            DrawBorders(P1);

            if (State == MouseState.Down)
            {
                DrawBorders(new Pen(CustomFusionDownBorderColor), 2);

            }
            else
            {
                G.DrawLine(new Pen(CustomFusionOverBorderColor), 2, 2, Width - 3, 2);

            }

            DrawCorners(CustomFusionCornerColor, 1, 1, Width - 2, Height - 2);
            DrawCorners(Parent.BackColor);
        }

        #endregion

    }

}

