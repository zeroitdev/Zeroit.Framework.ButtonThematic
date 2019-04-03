// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="GameBooster.cs" company="Zeroit Dev Technologies">
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
using Zeroit.Framework.ButtonThematic.ThemeManagers;


namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {


        #region Private Fields
        private Color gameBoosterTopGradient = Color.FromArgb(55, 55, 55);
        private Color gameBoosterBotGradient = Color.FromArgb(32, 32, 32);
        private Color gameBoosterTopGradientClick = Color.FromArgb(60, 60, 60);
        private Color gameBoosterBotGradientClick = Color.FromArgb(37, 37, 37);
        private Color gameBoosterTopGradientHover = Color.FromArgb(66, 66, 66);
        private Color gameBoosterBotGradientHover = Color.FromArgb(41, 41, 41);
        private Color gameBoosterCornerColor = Color.FromArgb(51, 51, 51);
        private Color gameBoosterInnerBorder = Color.FromArgb(76, 76, 76);
        private Color gameBoosterOuterBorder = Color.Black;
        private Color gameBoosterInnerBorderHover = Color.FromArgb(87, 87, 87);
        private Color gameBoosterOuterBorderHover = Color.Black;
        private Color gameBoosterInnerBorderClick = Color.FromArgb(71, 71, 71);
        private Color gameBoosterOuterBorderClick = Color.Black;
        #endregion

        #region Public Properties
        [Browsable(false)]
        public Color GameBoosterTopGradient
        {
            get { return gameBoosterTopGradient; }
            set { gameBoosterTopGradient = value;
                Invalidate();
            }
        }
        [Browsable(false)]
        public Color GameBoosterBotGradient
        {
            get { return gameBoosterBotGradient; }
            set { gameBoosterBotGradient = value; Invalidate(); }
        }
        [Browsable(false)]
        public Color GameBoosterTopGradientClick
        {
            get { return gameBoosterTopGradientClick; }
            set { gameBoosterTopGradientClick = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color GameBoosterBotGradientClick
        {
            get { return gameBoosterBotGradientClick; }
            set { gameBoosterBotGradientClick = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color GameBoosterTopGradientHover
        {
            get { return gameBoosterTopGradientHover; }
            set { gameBoosterTopGradientHover = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color GameBoosterBotGradientHover
        {
            get { return gameBoosterBotGradientHover; }
            set { gameBoosterBotGradientHover = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color GameBoosterCornerColor
        {
            get { return gameBoosterCornerColor; }
            set { gameBoosterCornerColor = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color GameBoosterInnerBorder
        {
            get { return gameBoosterInnerBorder; }
            set { gameBoosterInnerBorder = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color GameBoosterOuterBorder
        {
            get { return gameBoosterOuterBorder; }
            set { gameBoosterOuterBorder = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color GameBoosterInnerBorderHover
        {
            get { return gameBoosterInnerBorderHover; }
            set { gameBoosterInnerBorderHover = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color GameBoosterOuterBorderHover
        {
            get { return gameBoosterOuterBorderHover; }
            set { gameBoosterOuterBorderHover = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color GameBoosterInnerBorderClick
        {
            get { return gameBoosterInnerBorderClick; }
            set { gameBoosterInnerBorderClick = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color GameBoosterOuterBorderClick
        {
            get { return gameBoosterOuterBorderClick; }
            set { gameBoosterOuterBorderClick = value; Invalidate(); }
        } 
        #endregion


        private void GameBoosterPaintHook()
        {
            if (State == MouseState.Down)
            {
                DrawGradient(gameBoosterTopGradientClick, gameBoosterBotGradientClick, new Rectangle(2, 1, Width - 4, Height - 3), 90f);
                G.DrawRectangle(new Pen(gameBoosterInnerBorderClick), 1, 1, ClientRectangle.Width - 3, ClientRectangle.Height - 3);
                //TOPLEFT
                DrawPixel(gameBoosterOuterBorderClick, 1, 1);
                DrawPixel(gameBoosterInnerBorderClick, 2, 2);
                //TOPRIGHT
                DrawPixel(gameBoosterOuterBorderClick, Width - 2, 1);
                DrawPixel(gameBoosterInnerBorderClick, Width - 3, 2);
                //BOTTOMLEFT
                DrawPixel(gameBoosterOuterBorderClick, 1, Height - 2);
                DrawPixel(gameBoosterInnerBorderClick, 1, Height - 3);
                //BOTTOMRIGHT
                DrawPixel(gameBoosterOuterBorderClick, Width - 2, Height - 2);
                DrawPixel(gameBoosterInnerBorderClick, Width - 3, Height - 3);
                DrawBorders(new Pen(gameBoosterOuterBorderClick));
            }
            else
            {
                DrawGradient(gameBoosterTopGradient, gameBoosterBotGradient, new Rectangle(2, 1, Width - 4, Height - 3), 90f);
                G.DrawRectangle(new Pen(gameBoosterInnerBorder), 1, 1, ClientRectangle.Width - 3, ClientRectangle.Height - 3);
                //TOPLEFT
                DrawPixel(gameBoosterOuterBorder, 1, 1);
                DrawPixel(gameBoosterInnerBorder, 2, 2);
                //TOPRIGHT
                DrawPixel(gameBoosterOuterBorder, Width - 2, 1);
                DrawPixel(gameBoosterInnerBorder, Width - 3, 2);
                //BOTTOMLEFT
                DrawPixel(gameBoosterOuterBorder, 1, Height - 2);
                DrawPixel(gameBoosterInnerBorder, 1, Height - 3);
                //BOTTOMRIGHT
                DrawPixel(gameBoosterOuterBorder, Width - 2, Height - 2);
                DrawPixel(gameBoosterInnerBorder, Width - 3, Height - 3);
                DrawBorders(new Pen(gameBoosterOuterBorder));
            }

            if (State == MouseState.Over)
            {
                DrawGradient(gameBoosterTopGradientHover, gameBoosterBotGradientHover, new Rectangle(2, 1, Width - 4, Height - 3), 90f);
                G.DrawRectangle(new Pen(gameBoosterInnerBorderHover), 1, 1, ClientRectangle.Width - 3, ClientRectangle.Height - 3);
                //TOPLEFT
                DrawPixel(gameBoosterOuterBorderHover, 1, 1);
                DrawPixel(gameBoosterInnerBorderHover, 2, 2);
                //TOPRIGHT
                DrawPixel(gameBoosterOuterBorderHover, Width - 2, 1);
                DrawPixel(gameBoosterInnerBorderHover, Width - 3, 2);
                //BOTTOMLEFT
                DrawPixel(gameBoosterOuterBorderHover, 1, Height - 2);
                DrawPixel(gameBoosterInnerBorderHover, 1, Height - 3);
                //BOTTOMRIGHT
                DrawPixel(gameBoosterOuterBorderHover, Width - 2, Height - 2);
                DrawPixel(gameBoosterInnerBorderHover, Width - 3, Height - 3);
                DrawBorders(new Pen(gameBoosterOuterBorderHover));
            }

            //DrawText(gameBoosterTextCol, HorizontalAlignment.Center, 0, 0);

            DrawCorners(gameBoosterCornerColor);
        }

    }

}

