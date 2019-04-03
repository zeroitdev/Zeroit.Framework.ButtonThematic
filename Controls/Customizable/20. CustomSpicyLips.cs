// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="20. CustomSpicyLips.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using System.Drawing;
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
        //private Color customSpicyBackground = Color.FromArgb(1, 1, 1);

        //private Color[] customSpicyNoneStateColors = new Color[]
        //{
        //    Color.FromArgb(40, 40, 40),
        //    Color.FromArgb(28, 28, 28)
        //};

        //private Color[] customSpicyOverStateColors = new Color[]
        //{
        //    Color.FromArgb(40, 40, 40),
        //    Color.FromArgb(28, 28, 28)
        //};

        //private Color[] customSpicyDownStateColors = new Color[]
        //{
        //    Color.FromArgb(4, 4, 4),
        //    Color.FromArgb(20, 20, 20)
        //};

        //private Color customSpicyHighlight = Color.White;

        //private Color[] customSpicyBorderColors = new Color[]
        //{
        //    Color.Black,
        //    Color.Black
        //};

        //private Color customSpicyCornerColor = Color.FromArgb(20, 20, 20);
        #endregion

        #region Public Properties
        [Browsable(false)]
        public Color CustomSpicyBackground
        {
            get { return buttonInput.CustomSpicyBackground; }
            set
            {
                buttonInput.CustomSpicyBackground = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] CustomSpicyNoneStateColors
        {
            get { return buttonInput.CustomSpicyNoneStateColors; }
            set { buttonInput.CustomSpicyNoneStateColors = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color[] CustomSpicyOverStateColors
        {
            get { return buttonInput.CustomSpicyOverStateColors; }
            set { buttonInput.CustomSpicyOverStateColors = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color[] CustomSpicyDownStateColors
        {
            get { return buttonInput.CustomSpicyDownStateColors; }
            set { buttonInput.CustomSpicyDownStateColors = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomSpicyHighlight
        {
            get { return buttonInput.CustomSpicyHighlight; }
            set { buttonInput.CustomSpicyHighlight = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color[] CustomSpicyBorderColors
        {
            get { return buttonInput.CustomSpicyBorderColors; }
            set { buttonInput.CustomSpicyBorderColors = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomSpicyCornerColor
        {
            get { return buttonInput.CustomSpicyCornerColor; }
            set
            {
                buttonInput.CustomSpicyCornerColor = value;
                Invalidate();
            }
        }


        #endregion

        #region Paint
        private void CustomSpicyLipsPaintHook()
        {
            G.Clear(CustomSpicyBackground);
            switch (State)
            {
                case MouseState.None:
                    DrawGradient(CustomSpicyNoneStateColors[0], CustomSpicyNoneStateColors[1], 0, 0, Width, Height, 90);
                    break;
                case MouseState.Over:
                    DrawGradient(CustomSpicyOverStateColors[0], CustomSpicyOverStateColors[1], 0, 0, Width, Height, 90);
                    break;
                case MouseState.Down:
                    DrawGradient(CustomSpicyDownStateColors[0], CustomSpicyDownStateColors[1], 0, 0, Width, Height, 90);
                    break;
            }

            G.FillRectangle(new SolidBrush(Color.FromArgb(6, CustomSpicyHighlight)), 0, 0, Width, 12);

            DrawBorders(new Pen(CustomSpicyBorderColors[0]));
            DrawBorders(new Pen(CustomSpicyBorderColors[1]), 2);
            DrawCorners(CustomSpicyCornerColor, ClientRectangle);
            //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);

        }

        #endregion

    }

}

