// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="13. CustomGameBooster.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using System.Drawing;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        #region Private Fields
        //private Color customGameBoosterTopGradient = Color.FromArgb(55, 55, 55);
        //private Color customGameBoosterBotGradient = Color.FromArgb(32, 32, 32);
        //private Color customGameBoosterTopGradientClick = Color.FromArgb(60, 60, 60);
        //private Color customGameBoosterBotGradientClick = Color.FromArgb(37, 37, 37);
        //private Color customGameBoosterTopGradientHover = Color.FromArgb(66, 66, 66);
        //private Color customGameBoosterBotGradientHover = Color.FromArgb(41, 41, 41);
        //private Color customGameBoosterCornerColor = Color.FromArgb(51, 51, 51);
        //private Color customGameBoosterInnerBorder = Color.FromArgb(76, 76, 76);
        //private Color customGameBoosterOuterBorder = Color.Black;
        //private Color customGameBoosterInnerBorderHover = Color.FromArgb(87, 87, 87);
        //private Color customGameBoosterOuterBorderHover = Color.Black;
        //private Color customGameBoosterInnerBorderClick = Color.FromArgb(71, 71, 71);
        //private Color customGameBoosterOuterBorderClick = Color.Black;

        #endregion

        #region Public Properties
        [Browsable(false)]
        public Color CustomGameBoosterTopGradient
        {
            get { return buttonInput.CustomGameBoosterTopGradient; }
            set
            {
                buttonInput.CustomGameBoosterTopGradient = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color CustomGameBoosterBotGradient
        {
            get { return buttonInput.CustomGameBoosterBotGradient; }
            set { buttonInput.CustomGameBoosterBotGradient = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomGameBoosterTopGradientClick
        {
            get { return buttonInput.CustomGameBoosterTopGradientClick; }
            set { buttonInput.CustomGameBoosterTopGradientClick = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomGameBoosterBotGradientClick
        {
            get { return buttonInput.CustomGameBoosterBotGradientClick; }
            set { buttonInput.CustomGameBoosterBotGradientClick = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomGameBoosterTopGradientHover
        {
            get { return buttonInput.CustomGameBoosterTopGradientHover; }
            set { buttonInput.CustomGameBoosterTopGradientHover = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomGameBoosterBotGradientHover
        {
            get { return buttonInput.CustomGameBoosterBotGradientHover; }
            set { buttonInput.CustomGameBoosterBotGradientHover = value; Invalidate(); }
        }

        public Color CustomGameBoosterCornerColor
        {
            get { return buttonInput.CustomGameBoosterCornerColor; }
            set { buttonInput.CustomGameBoosterCornerColor = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomGameBoosterInnerBorder
        {
            get { return buttonInput.CustomGameBoosterInnerBorder; }
            set { buttonInput.CustomGameBoosterInnerBorder = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomGameBoosterOuterBorder
        {
            get { return buttonInput.CustomGameBoosterOuterBorder; }
            set { buttonInput.CustomGameBoosterOuterBorder = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomGameBoosterInnerBorderHover
        {
            get { return buttonInput.CustomGameBoosterInnerBorderHover; }
            set { buttonInput.CustomGameBoosterInnerBorderHover = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomGameBoosterOuterBorderHover
        {
            get { return buttonInput.CustomGameBoosterOuterBorderHover; }
            set { buttonInput.CustomGameBoosterOuterBorderHover = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomGameBoosterInnerBorderClick
        {
            get { return buttonInput.CustomGameBoosterInnerBorderClick; }
            set { buttonInput.CustomGameBoosterInnerBorderClick = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomGameBoosterOuterBorderClick
        {
            get { return buttonInput.CustomGameBoosterOuterBorderClick; }
            set { buttonInput.CustomGameBoosterOuterBorderClick = value; Invalidate(); }
        }
        #endregion
        
        #region Paint
        private void CustomGameBoosterPaintHook()
        {
            if (State == MouseState.Down)
            {
                DrawGradient(CustomGameBoosterTopGradientClick, CustomGameBoosterBotGradientClick, new Rectangle(2, 1, Width - 4, Height - 3), 90f);
                G.DrawRectangle(new Pen(CustomGameBoosterInnerBorderClick), 1, 1, ClientRectangle.Width - 3, ClientRectangle.Height - 3);
                //TOPLEFT
                DrawPixel(CustomGameBoosterOuterBorderClick, 1, 1);
                DrawPixel(CustomGameBoosterInnerBorderClick, 2, 2);
                //TOPRIGHT
                DrawPixel(CustomGameBoosterOuterBorderClick, Width - 2, 1);
                DrawPixel(CustomGameBoosterInnerBorderClick, Width - 3, 2);
                //BOTTOMLEFT
                DrawPixel(CustomGameBoosterOuterBorderClick, 1, Height - 2);
                DrawPixel(CustomGameBoosterInnerBorderClick, 1, Height - 3);
                //BOTTOMRIGHT
                DrawPixel(CustomGameBoosterOuterBorderClick, Width - 2, Height - 2);
                DrawPixel(CustomGameBoosterInnerBorderClick, Width - 3, Height - 3);
                DrawBorders(new Pen(CustomGameBoosterOuterBorderClick));
            }
            else
            {
                DrawGradient(CustomGameBoosterTopGradient, CustomGameBoosterBotGradient, new Rectangle(2, 1, Width - 4, Height - 3), 90f);
                G.DrawRectangle(new Pen(CustomGameBoosterInnerBorder), 1, 1, ClientRectangle.Width - 3, ClientRectangle.Height - 3);
                //TOPLEFT
                DrawPixel(CustomGameBoosterOuterBorder, 1, 1);
                DrawPixel(CustomGameBoosterInnerBorder, 2, 2);
                //TOPRIGHT
                DrawPixel(CustomGameBoosterOuterBorder, Width - 2, 1);
                DrawPixel(CustomGameBoosterInnerBorder, Width - 3, 2);
                //BOTTOMLEFT
                DrawPixel(CustomGameBoosterOuterBorder, 1, Height - 2);
                DrawPixel(CustomGameBoosterInnerBorder, 1, Height - 3);
                //BOTTOMRIGHT
                DrawPixel(CustomGameBoosterOuterBorder, Width - 2, Height - 2);
                DrawPixel(CustomGameBoosterInnerBorder, Width - 3, Height - 3);
                DrawBorders(new Pen(CustomGameBoosterOuterBorder));
            }

            if (State == MouseState.Over)
            {
                DrawGradient(CustomGameBoosterTopGradientHover, CustomGameBoosterBotGradientHover, new Rectangle(2, 1, Width - 4, Height - 3), 90f);
                G.DrawRectangle(new Pen(CustomGameBoosterInnerBorderHover), 1, 1, ClientRectangle.Width - 3, ClientRectangle.Height - 3);
                //TOPLEFT
                DrawPixel(CustomGameBoosterOuterBorderHover, 1, 1);
                DrawPixel(CustomGameBoosterInnerBorderHover, 2, 2);
                //TOPRIGHT
                DrawPixel(CustomGameBoosterOuterBorderHover, Width - 2, 1);
                DrawPixel(CustomGameBoosterInnerBorderHover, Width - 3, 2);
                //BOTTOMLEFT
                DrawPixel(CustomGameBoosterOuterBorderHover, 1, Height - 2);
                DrawPixel(CustomGameBoosterInnerBorderHover, 1, Height - 3);
                //BOTTOMRIGHT
                DrawPixel(CustomGameBoosterOuterBorderHover, Width - 2, Height - 2);
                DrawPixel(CustomGameBoosterInnerBorderHover, Width - 3, Height - 3);
                DrawBorders(new Pen(CustomGameBoosterOuterBorderHover));
            }

            //DrawText(CustomGameBoosterTextCol, HorizontalAlignment.Center, 0, 0);

            DrawCorners(CustomGameBoosterCornerColor);
        } 
        #endregion


    }

}

