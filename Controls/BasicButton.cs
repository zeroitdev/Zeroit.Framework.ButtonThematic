// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="BasicButton.cs" company="Zeroit Dev Technologies">
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
using Zeroit.Framework.ButtonThematic.BaseContainer;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        private Color[] basicColors = new Color[]
        {
            Color.FromArgb(255, 55, 55, 55),
            Color.FromArgb(255, 22, 22, 22),
            Color.FromArgb(255, 100, 0, 0),
            Color.FromArgb(255, 60, 0, 0)
        };

        private Color[] basicStateColors = new Color[]
        {
            Color.FromArgb(255, 60, 0, 0),
            Color.FromArgb(255, 100, 0, 0)
        };

        private Color[] basicHighlights = new Color[]
        {
            Color.FromArgb(25, 255, 255, 255),
            Color.FromArgb(25, 255, 255, 255),
            Color.FromArgb(25, 255, 255, 255)
        };
        
        private Color[] basicBorderColors = new Color[]
        {
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black
        };

        private Color[] basicDisabled = new Color[]
        {
            Color.FromArgb(255, 40, 40, 40),
            Color.FromArgb(255, 20, 20, 20),
            Color.FromArgb(13, 255, 255, 255)
        };

        [Browsable(false)]
        public Color[] BasicBorderColors
        {
            get { return basicBorderColors; }
            set
            {
                basicBorderColors = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] BasicStateColors
        {
            get { return basicStateColors; }
            set
            {
                basicStateColors = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] BasicColors
        {
            get { return basicColors; }
            set
            {
                basicColors = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] BasicHighlights
        {
            get { return basicHighlights; }
            set { basicHighlights = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] BasicDisabled
        {
            get { return basicDisabled; }
            set { basicDisabled = value;
                Invalidate();
            }
        }

        public void BCEvoButton()
        {
            switch (Theme)
            {
                case Themes.BasicCode:
                    Transparent = true;
                    BackColor = Color.Transparent;
                    Size = new Size(97, 23);
                    Location = new Point(40, 30);
                    break;
            }
            
        }

        private GraphicsPath BPath;
        private GraphicsPath TPath;
        private Point[] BITPoints;
        private Rectangle BRect;
        private Rectangle TRect;
        private Rectangle BIRect;
        private LinearGradientBrush BBrush;
        private LinearGradientBrush BIBrush;

        private void BasicPaint()
        {
            G.SmoothingMode = Smoothing;
            BRect = new Rectangle(0, 0, ClientRectangle.Width - 1, ClientRectangle.Height - 1);
            TRect = new Rectangle(0, 0, ClientRectangle.Width - 2, Convert.ToInt32(ClientRectangle.Height / 2));
            BITPoints = new Point[] {
            new Point(4, 4),
            new Point(ClientRectangle.Width - 4, 4),
            new Point(ClientRectangle.Width - 4, ClientRectangle.Height - 4),
            new Point(4, ClientRectangle.Height - 4),
            new Point(4, 4)
        };
            BIRect = new Rectangle(3, 3, ClientRectangle.Width - 4, ClientRectangle.Height - 4);
            BBrush = new LinearGradientBrush(ClientRectangle, BasicColors[0], BasicColors[1], LinearGradientMode.Vertical);
            BIBrush = new LinearGradientBrush(BIRect, BasicColors[2], BasicColors[3], LinearGradientMode.Vertical);

            switch (State)
            {
                case MouseState.Over:
                    BIBrush = new LinearGradientBrush(BIRect, BasicStateColors[0], BasicStateColors[1], LinearGradientMode.Vertical);
                    G.FillRectangle(BBrush, BRect);
                    G.DrawRectangle(new Pen(BasicBorderColors[0]), BRect);
                    G.FillPolygon(BIBrush, BITPoints);
                    DrawBorders(new Pen(BasicBorderColors[1]), 3);
                    G.FillRectangle(new SolidBrush(BasicHighlights[0]), TRect);
                    break;
                case MouseState.Down:
                    G.FillRectangle(BBrush, BRect);
                    G.DrawRectangle(new Pen(BasicBorderColors[2]), BRect);
                    G.FillPolygon(BIBrush, BITPoints);
                    DrawBorders(new Pen(BasicBorderColors[3]), 3);
                    G.FillRectangle(new SolidBrush(BasicHighlights[1]), TRect);
                    break;
                case MouseState.None:
                    G.FillRectangle(BBrush, BRect);
                    G.DrawRectangle(new Pen(BasicBorderColors[4]), BRect);
                    G.FillPolygon(BIBrush, BITPoints);
                    DrawBorders(new Pen(BasicBorderColors[5]), 3);
                    G.FillRectangle(new SolidBrush(BasicHighlights[2]), TRect);
                    break;
            }

            //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

            if (Enabled == false)
            {
                BIBrush = new LinearGradientBrush(BIRect, BasicDisabled[0], BasicDisabled[1], LinearGradientMode.Vertical);
                G.FillRectangle(BBrush, BRect);
                G.DrawRectangle(new Pen(BasicBorderColors[6]), BRect);
                G.FillPolygon(BIBrush, BITPoints);
                DrawBorders(new Pen(BasicBorderColors[7]), 3);
                G.FillRectangle(new SolidBrush(BasicDisabled[2]), TRect);
                //DrawText(Brushes.Gray, HorizontalAlignment.Center, 0, 0);
            }
            else
            {
            }
        }
    }

}
