// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="AvatarButton.cs" company="Zeroit Dev Technologies">
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
using System.Drawing.Drawing2D;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{
    public partial class ButtonThematic
    {

        Color avatarButtonColorTop = Color.FromArgb(255, 48, 48, 48);
        Color avatarButtonColorBottom = Color.FromArgb(200, 24, 24, 24);

        Color avatarBorder = Color.Black;

        Color[] avatarStateColors = new Color[]
        {
            Color.FromArgb(125, Color.Black),
            Color.FromArgb(200, Color.Black)
        };

        [Browsable(false)]
        public Color AvatarButtonColorTop
        {
            get
            {
                return avatarButtonColorTop;
                
            }
            set
            {
                avatarButtonColorTop = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color AvatarButtonColorBottom
        {
            get { return avatarButtonColorBottom; }
            set
            {
                avatarButtonColorBottom = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color AvatarBorder
        {
            get { return avatarBorder; }
            set
            {
                avatarBorder = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] AvatarStateColors
        {
            get { return avatarStateColors; }
            set { avatarStateColors = value; Invalidate(); }
        }

        public void AvatarButton()
        {
            ForeColor =  Color.DeepSkyBlue;
        }

        
        private void AvatarPaint()
        {
            G.Clear(avatarButtonColorTop);
            G.DrawRectangle(new Pen(avatarBorder), new Rectangle(0, 0, Width, Height));
            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(1, 1, Width - 2, Height - 2), avatarButtonColorTop, avatarButtonColorBottom, 90f);
                    G.FillRectangle(LGB, new Rectangle(1, 1, Width - 2, Height - 2));
                    
                    break;
                case MouseState.Over:
                    G.FillRectangle(new SolidBrush(AvatarStateColors[0]), new Rectangle(0, 0, Width, Height));
                    break;
                case MouseState.Down:
                    G.FillRectangle(new SolidBrush(AvatarStateColors[1]), new Rectangle(0, 0, Width, Height));
                    break;
            }

            //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);
        }
    }

}
