// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Angel.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.BaseContainer;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{
    /// <summary>
    /// Class AngelButton.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ButtonThematic
    {

        #region " Back End "

        #region " Declarations "
        /// <summary>
        /// The s
        /// </summary>
        private MouseState S = MouseState.None;
        #endregion
        ///// <summary>
        ///// a
        ///// </summary>
        //private Alignment A = Alignment.Centre;

        private Color[] angelColors = new Color[]
        {
            Color.FromArgb(52, 78, 108),
            Color.FromArgb(22, 45, 67),
            Color.FromArgb(70, 103, 143),
            Color.FromArgb(25, Color.White),
            Color.Black
        };

        private Color angelBackground = Color.Black;

        #region " Mouse States "

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseEnter" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        private void AngelOnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            S = MouseState.Over;
            Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseLeave" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        private void AngelOnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            S = MouseState.None;
            Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseDown" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        private void AngelOnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            S = MouseState.Down;
            Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseUp" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        private void AngelOnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            S = MouseState.Over;
            Invalidate();
        }

        #endregion

        #region " Properties "

        #region " Appearance "


        [Browsable(false)]
        public Color[] AngelColors
        {
            get { return angelColors; }
            set { angelColors = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color AngelBackground
        {
            get { return angelBackground; }
            set { angelBackground = value;
                Invalidate();
            }
        }

        #endregion

        #region " Behaviour "

        #endregion

        #endregion

        #region " Misc "
        /// <summary>
        /// Initializes a new instance of the <see cref="AngelButton"/> class.
        /// </summary>
        public void AngelButton()
        {
            switch (Theme)
            {
                case Themes.Angel:
                    Size = new Size(90, 30);
                    Font = new Font("Segoe UI", 10);
                    break;
            }
            
        }
        #endregion

        #endregion

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.Paint" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs" /> that contains the event data.</param>
        private void AngelPaint(PaintEventArgs e)
        {
            dynamic G = e.Graphics;
            G.Clear(AngelBackground);
            G.FillRectangle(new LinearGradientBrush(new Point(1, 1), new Point(1, Height - 2), AngelColors[0], AngelColors[1]), new Rectangle(1, 1, Width - 3, Height - 3));
            G.DrawRectangle(new Pen(AngelColors[2]), new Rectangle(1, 1, Width - 3, Height - 3));
            switch (S)
            {
                case MouseState.Over:
                    G.FillRectangle(new SolidBrush(AngelColors[3]), new Rectangle(2, 2, Width - 4, Height - 4));
                    break;
                case MouseState.Down:
                    G.FillRectangle(new SolidBrush(AngelColors[4]), new Rectangle(2, 2, Width - 4, Height - 4));
                    break;
            }

            //StringFormat F = new StringFormat { LineAlignment = StringAlignment.Center };

            //switch (A)
            //{
            //    case Alignment.Left:
            //        G.DrawString(Text, Font, Brushes.White, new Rectangle(8, 0, Width - 1, Height - 1), F);
            //        break;
            //    case Alignment.Centre:
            //        F.Alignment = StringAlignment.Center;
            //        G.DrawString(Text, Font, Brushes.White, new Rectangle(0, 0, Width - 1, Height - 1), F);
            //        break;
            //    case Alignment.Right:
            //        G.DrawString(Text, Font, Brushes.White, new Rectangle(Width - TextRenderer.MeasureText(Text, Font).Width, 0, TextRenderer.MeasureText(Text, Font).Width, Height - 1), F);
            //        break;
            //}

        }
    }
}
