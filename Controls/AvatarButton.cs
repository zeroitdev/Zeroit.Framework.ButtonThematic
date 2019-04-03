// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="AvatarButton.cs" company="Zeroit Dev Technologies">
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
