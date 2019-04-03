// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Teen.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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

        public enum teenColorSchemes
        {
            Light,
            Dark
        }
        private teenColorSchemes teenColorScheme = teenColorSchemes.Dark;

        [Browsable(false)]
        public teenColorSchemes TeenColorScheme
        {
            get { return teenColorScheme; }
            set
            {
                teenColorScheme = value;
                Invalidate();
            }
        }

        
        private Color teenAccentColor = Color.DodgerBlue;

        [Browsable(false)]
        public Color TeenAccentColor
        {
            get { return teenAccentColor; }
            set
            {
                teenAccentColor = value;
                OnAccentColorChanged();
            }
        }

        
        private void TeenPaint(PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Color BGColor = default(Color);
            switch (TeenColorScheme)
            {
                case teenColorSchemes.Dark:
                    BGColor = Color.FromArgb(50, 50, 50);
                    break;
                case teenColorSchemes.Light:
                    BGColor = Color.White;
                    break;
            }

            switch (State)
            {
                case MouseState.None:
                    G.Clear(BGColor);
                    break;
                case MouseState.Over:
                    G.Clear(TeenAccentColor);
                    break;
                case MouseState.Down:
                    G.Clear(TeenAccentColor);
                    G.FillRectangle(new SolidBrush(Color.FromArgb(50, Color.Black)), new Rectangle(0, 0, Width - 1, Height - 1));
                    break;
            }


            G.DrawRectangle(new Pen(Color.FromArgb(100, 100, 100)), new Rectangle(0, 0, Width - 1, Height - 1));

            //StringFormat ButtonString = new StringFormat
            //{
            //    Alignment = StringAlignment.Center,
            //    LineAlignment = StringAlignment.Center
            //};
            //switch (TeenColorScheme)
            //{
            //    case teenColorSchemes.Dark:
            //        G.DrawString(Text, Font, Brushes.White, new Rectangle(0, 0, Width - 1, Height - 1), ButtonString);
            //        break;
            //    case teenColorSchemes.Light:
            //        G.DrawString(Text, Font, Brushes.Black, new Rectangle(0, 0, Width - 1, Height - 1), ButtonString);
            //        break;
            //}

            e.Graphics.DrawImage(B, new Point(0, 0));
            //G.Dispose();
            //B.Dispose();
        }
        
    }

}

