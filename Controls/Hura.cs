// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Hura.cs" company="Zeroit Dev Technologies">
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

        
        public enum HuraColorSchemes
        {
            Dark
        }

        private HuraColorSchemes huraColorScheme;

        [Browsable(false)]
        public HuraColorSchemes HuraColorScheme
        {
            get { return huraColorScheme; }
            set
            {
                huraColorScheme = value;
                Invalidate();
            }
        }
        
        private Color huraAccentColor;

        [Browsable(false)]
        public Color HuraAccentColor
        {
            get { return huraAccentColor; }
            set
            {
                huraAccentColor = value;
                OnAccentColorChanged();
            }
        }

        [Browsable(false)]
        public Color HuraBackground
        {
            get { return huraBackground; }
            set { huraBackground = value;
                Invalidate();
            }
        }

        private Color huraBackground = Color.FromArgb(50, 50, 50);

        public event AccentColorChangedEventHandler AccentColorChanged;
        public delegate void AccentColorChangedEventHandler();

        public void HuraButton()
        {
            AccentColorChanged += OnAccentColorChanged;
            Font = new Font("Segoe UI", 9.5f);
            ForeColor = Color.White;
            BackColor = Color.FromArgb(50, 50, 50);
            HuraAccentColor = Color.FromArgb(70, 70, 70);
            HuraColorScheme = HuraColorSchemes.Dark;
        }

        private void HuraPaint(PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Color BGColor = default(Color);

            G.Clear(HuraBackground);
            switch (HuraColorScheme)
            {
                case HuraColorSchemes.Dark:
                    BGColor = Color.FromArgb(50, 50, 50);
                    break;
            }

            switch (State)
            {
                case MouseState.None:
                    G.Clear(BGColor);
                    break;
                case MouseState.Over:
                    G.Clear(HuraAccentColor);
                    break;
                case MouseState.Down:
                    G.Clear(HuraAccentColor);
                    G.FillRectangle(new SolidBrush(Color.FromArgb(50, Color.Black)), new Rectangle(0, 0, Width - 1, Height - 1));
                    break;
            }


            G.DrawRectangle(new Pen(Color.FromArgb(100, 100, 100)), new Rectangle(0, 0, Width - 1, Height - 1));

            StringFormat ButtonString = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            switch (HuraColorScheme)
            {
                case HuraColorSchemes.Dark:
                    //G.DrawString(Text, Font, Brushes.White, new Rectangle(0, 0, Width - 1, Height - 1), ButtonString);
                    break;
            }

            e.Graphics.DrawImage(B, new Point(0, 0));
            
        }

        protected void OnAccentColorChanged()
        {
            Invalidate();
        }

    }

}

