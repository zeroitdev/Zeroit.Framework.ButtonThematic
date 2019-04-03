using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.BaseContainer;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {
        
        #region Private Fields
        private Color customGameBoosterTopGradient = Color.FromArgb(55, 55, 55);
        private Color customGameBoosterBotGradient = Color.FromArgb(32, 32, 32);
        private Color customGameBoosterTopGradientClick = Color.FromArgb(60, 60, 60);
        private Color customGameBoosterBotGradientClick = Color.FromArgb(37, 37, 37);
        private Color customGameBoosterTopGradientHover = Color.FromArgb(66, 66, 66);
        private Color customGameBoosterBotGradientHover = Color.FromArgb(41, 41, 41);
        private Color customGameBoosterCornerColor = Color.FromArgb(51, 51, 51);
        private Color customGameBoosterInnerBorder = Color.FromArgb(76, 76, 76);
        private Color customGameBoosterOuterBorder = Color.Black;
        private Color customGameBoosterInnerBorderHover = Color.FromArgb(87, 87, 87);
        private Color customGameBoosterOuterBorderHover = Color.Black;
        private Color customGameBoosterInnerBorderClick = Color.FromArgb(71, 71, 71);
        private Color customGameBoosterOuterBorderClick = Color.Black;

        #endregion

        #region Public Properties
        public Color CustomGameBoosterTopGradient
        {
            get { return customGameBoosterTopGradient; }
            set
            {
                customGameBoosterTopGradient = value;
                Invalidate();
            }
        }

        public Color CustomGameBoosterBotGradient
        {
            get { return customGameBoosterBotGradient; }
            set { customGameBoosterBotGradient = value; Invalidate(); }
        }

        public Color CustomGameBoosterTopGradientClick
        {
            get { return customGameBoosterTopGradientClick; }
            set { customGameBoosterTopGradientClick = value; Invalidate(); }
        }

        public Color CustomGameBoosterBotGradientClick
        {
            get { return customGameBoosterBotGradientClick; }
            set { customGameBoosterBotGradientClick = value; Invalidate(); }
        }

        public Color CustomGameBoosterTopGradientHover
        {
            get { return customGameBoosterTopGradientHover; }
            set { customGameBoosterTopGradientHover = value; Invalidate(); }
        }

        public Color CustomGameBoosterBotGradientHover
        {
            get { return customGameBoosterBotGradientHover; }
            set { customGameBoosterBotGradientHover = value; Invalidate(); }
        }

        public Color CustomGameBoosterCornerColor
        {
            get { return customGameBoosterCornerColor; }
            set { customGameBoosterCornerColor = value; Invalidate(); }
        }

        public Color CustomGameBoosterInnerBorder
        {
            get { return customGameBoosterInnerBorder; }
            set { customGameBoosterInnerBorder = value; Invalidate(); }
        }

        public Color CustomGameBoosterOuterBorder
        {
            get { return customGameBoosterOuterBorder; }
            set { customGameBoosterOuterBorder = value; Invalidate(); }
        }

        public Color CustomGameBoosterInnerBorderHover
        {
            get { return customGameBoosterInnerBorderHover; }
            set { customGameBoosterInnerBorderHover = value; Invalidate(); }
        }

        public Color CustomGameBoosterOuterBorderHover
        {
            get { return customGameBoosterOuterBorderHover; }
            set { customGameBoosterOuterBorderHover = value; Invalidate(); }
        }

        public Color CustomGameBoosterInnerBorderClick
        {
            get { return customGameBoosterInnerBorderClick; }
            set { customGameBoosterInnerBorderClick = value; Invalidate(); }
        }

        public Color CustomGameBoosterOuterBorderClick
        {
            get { return customGameBoosterOuterBorderClick; }
            set { customGameBoosterOuterBorderClick = value; Invalidate(); }
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

