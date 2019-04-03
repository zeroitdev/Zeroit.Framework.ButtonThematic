// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="05. CustomBasic.cs" company="Zeroit Dev Technologies">
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

    /// <summary>
    /// Class ButtonThematic.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    public partial class ButtonThematic
    {

        #region Private Fields
        /// <summary>
        /// The custom basic colors
        /// </summary>
        private Color[] customBasicColors = new Color[]
        {
            Color.FromArgb(255, 55, 55, 55),
            Color.FromArgb(255, 22, 22, 22),
            Color.FromArgb(255, 100, 0, 0),
            Color.FromArgb(255, 60, 0, 0)
        };

        /// <summary>
        /// The custom basic state colors
        /// </summary>
        private Color[] customBasicStateColors = new Color[]
        {
            Color.FromArgb(255, 60, 0, 0),
            Color.FromArgb(255, 100, 0, 0)
        };

        /// <summary>
        /// The custom basic highlights
        /// </summary>
        private Color[] customBasicHighlights = new Color[]
        {
            Color.FromArgb(25, 255, 255, 255),
            Color.FromArgb(25, 255, 255, 255),
            Color.FromArgb(25, 255, 255, 255)
        };

        /// <summary>
        /// The custom basic border colors
        /// </summary>
        private Color[] customBasicBorderColors = new Color[]
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

        /// <summary>
        /// The custom basic disabled
        /// </summary>
        private Color[] customBasicDisabled = new Color[]
        {
            Color.FromArgb(255, 40, 40, 40),
            Color.FromArgb(255, 20, 20, 20),
            Color.FromArgb(13, 255, 255, 255)
        };


        /// <summary>
        /// The custom basic offset
        /// </summary>
        private int customBasicOffset = 3;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the custom basic border colors.
        /// </summary>
        /// <value>The custom basic border colors.</value>
        [Browsable(false)]
        public Color[] CustomBasicBorderColors
        {
            get { return buttonInput.CustomBasicBorderColors; }
            set
            {
                buttonInput.CustomBasicBorderColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom basic state colors.
        /// </summary>
        /// <value>The custom basic state colors.</value>
        [Browsable(false)]
        public Color[] CustomBasicStateColors
        {
            get { return buttonInput.CustomBasicStateColors; }
            set
            {
                buttonInput.CustomBasicStateColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom basic colors.
        /// </summary>
        /// <value>The custom basic colors.</value>
        [Browsable(false)]
        public Color[] CustomBasicColors
        {
            get { return buttonInput.CustomBasicColors; }
            set
            {
                buttonInput.CustomBasicColors = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom basic highlights.
        /// </summary>
        /// <value>The custom basic highlights.</value>
        [Browsable(false)]
        public Color[] CustomBasicHighlights
        {
            get { return buttonInput.CustomBasicHighlights; }
            set
            {
                buttonInput.CustomBasicHighlights = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom basic disabled.
        /// </summary>
        /// <value>The custom basic disabled.</value>
        [Browsable(false)]
        public Color[] CustomBasicDisabled
        {
            get { return buttonInput.CustomBasicDisabled; }
            set
            {
                buttonInput.CustomBasicDisabled = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Gets or sets the custom basic offset.
        /// </summary>
        /// <value>The custom basic offset.</value>
        [Browsable(false)]
        public int CustomBasicOffset
        {
            get { return buttonInput.CustomBasicOffset; }
            set
            {
                buttonInput.CustomBasicOffset = value;
                Invalidate();
            }
        }
        #endregion

        #region Paint

        /// <summary>
        /// Customs the basic paint.
        /// </summary>
        private void CustomBasicPaint()
        {
            GraphicsPath customBasicBPath;
            GraphicsPath customBasicTPath;
            Point[] customBasicBITPoints;
            Rectangle customBasicBRect;
            Rectangle customBasicTRect;
            Rectangle customBasicBIRect;
            LinearGradientBrush customBasicBBrush;
            LinearGradientBrush customBasicBIBrush;

            customBasicBRect = new Rectangle(0, 0, ClientRectangle.Width - 1, ClientRectangle.Height - 1);
            customBasicTRect = new Rectangle(0, 0, ClientRectangle.Width - 2, Convert.ToInt32(ClientRectangle.Height / 2));
            customBasicBITPoints = new Point[] {
                new Point(4, 4),
                new Point(ClientRectangle.Width - 4, 4),
                new Point(ClientRectangle.Width - 4, ClientRectangle.Height - 4),
                new Point(4, ClientRectangle.Height - 4),
                new Point(4, 4)
            };
            customBasicBIRect = new Rectangle(3, 3, ClientRectangle.Width - 4, ClientRectangle.Height - 4);
            customBasicBBrush = new LinearGradientBrush(ClientRectangle, CustomBasicColors[0], CustomBasicColors[1], LinearGradientMode.Vertical);
            customBasicBIBrush = new LinearGradientBrush(customBasicBIRect, CustomBasicColors[2], CustomBasicColors[3], LinearGradientMode.Vertical);

            switch (State)
            {
                case MouseState.Over:
                    customBasicBIBrush = new LinearGradientBrush(customBasicBIRect, CustomBasicStateColors[0], CustomBasicStateColors[1], LinearGradientMode.Vertical);
                    G.FillRectangle(customBasicBBrush, customBasicBRect);
                    G.DrawRectangle(new Pen(CustomBasicBorderColors[0]), customBasicBRect);
                    G.FillPolygon(customBasicBIBrush, customBasicBITPoints);
                    DrawBorders(new Pen(CustomBasicBorderColors[1]), CustomBasicOffset);
                    G.FillRectangle(new SolidBrush(CustomBasicHighlights[0]), customBasicTRect);
                    break;
                case MouseState.Down:
                    G.FillRectangle(customBasicBBrush, customBasicBRect);
                    G.DrawRectangle(new Pen(CustomBasicBorderColors[2]), customBasicBRect);
                    G.FillPolygon(customBasicBIBrush, customBasicBITPoints);
                    DrawBorders(new Pen(CustomBasicBorderColors[3]), CustomBasicOffset);
                    G.FillRectangle(new SolidBrush(CustomBasicHighlights[1]), customBasicTRect);
                    break;
                case MouseState.None:
                    G.FillRectangle(customBasicBBrush, customBasicBRect);
                    G.DrawRectangle(new Pen(CustomBasicBorderColors[4]), customBasicBRect);
                    G.FillPolygon(customBasicBIBrush, customBasicBITPoints);
                    DrawBorders(new Pen(CustomBasicBorderColors[5]), CustomBasicOffset);
                    G.FillRectangle(new SolidBrush(CustomBasicHighlights[2]), customBasicTRect);
                    break;
            }

            //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

            if (Enabled == false)
            {
                customBasicBIBrush = new LinearGradientBrush(customBasicBIRect, CustomBasicDisabled[0], CustomBasicDisabled[1], LinearGradientMode.Vertical);
                G.FillRectangle(customBasicBBrush, customBasicBRect);
                G.DrawRectangle(new Pen(CustomBasicBorderColors[6]), customBasicBRect);
                G.FillPolygon(customBasicBIBrush, customBasicBITPoints);
                DrawBorders(new Pen(CustomBasicBorderColors[7]), CustomBasicOffset);
                G.FillRectangle(new SolidBrush(CustomBasicDisabled[2]), customBasicTRect);
                //DrawText(Brushes.Gray, HorizontalAlignment.Center, 0, 0);
            }
            else
            {
            }
        }

        #endregion

    }

}
