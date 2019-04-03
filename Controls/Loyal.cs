// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Loyal.cs" company="Zeroit Dev Technologies">
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
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {


        #region " Properties "



        private Color loyalOutlineColor = Color.FromArgb(102, 51, 153);

        [Browsable(false)]
        [Category("Button Settings")]
        public Color LoyalOutlineColor
        {
            get { return loyalOutlineColor; }
            set
            {
                loyalOutlineColor = value;
                Invalidate();
            }
        }

        #endregion

        // Get more free themes at ThemesVB.NET
        private void LoyalPaint(PaintEventArgs e)
        {
            G.Clear(Color.FromArgb(40, 40, 40));
            switch (State)
            {
                case MouseState.None:
                    G.DrawRectangle(new Pen(Color.FromArgb(24, 24, 24)), new Rectangle(0, 0, Width - 1, Height - 1));
                    break;
                case MouseState.Over:
                    G.DrawRectangle(new Pen(loyalOutlineColor), new Rectangle(0, 0, Width - 1, Height - 1));

                    break;
                case MouseState.Down:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(30, 30, 30)), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(loyalOutlineColor), new Rectangle(0, 0, Width - 1, Height - 1));
                    break;
            }
            G.DrawRectangle(new Pen(Color.FromArgb(48, 48, 48)), new Rectangle(1, 1, Width - 3, Height - 3));
            G.FillRectangle(new SolidBrush(Color.FromArgb(35, 35, 35)), new Rectangle(0, 0, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(35, 35, 35)), new Rectangle(0, Height - 1, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(35, 35, 35)), new Rectangle(Width - 1, 0, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(35, 35, 35)), new Rectangle(Width - 1, Height - 1, 1, 1));
            StringFormat _StringF = new StringFormat { LineAlignment = StringAlignment.Center };

            //switch (_TextAlignment)
            //{
            //    case Alignment.Center:
            //        _StringF.Alignment = StringAlignment.Center;
            //        G.DrawString(Text, new Font("Arial", 9), Brushes.White, new RectangleF(0, 0, Width - 1, Height - 1), _StringF);
            //        break;
            //    case Alignment.Left:
            //        G.DrawString(Text, new Font("Arial", 9), Brushes.White, new RectangleF(7, 0, Width - 11, Height - 1), _StringF);
            //        break;
            //    case Alignment.Right:
            //        int _StringLength = TextRenderer.MeasureText(Text, new Font("Arial", 9)).Width + 8;
            //        G.DrawString(Text, new Font("Arial", 9), Brushes.White, new Rectangle(Width - _StringLength, 0, Width - _StringLength, Height - 1), _StringF);
            //        break;
            //}
        }


    }

}

