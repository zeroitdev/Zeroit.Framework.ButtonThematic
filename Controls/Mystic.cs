// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Mystic.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        
        private Color mysticBackground = Color.FromArgb(66, 219, 183);
        private void MysticPaint(PaintEventArgs e)
        {
            G = e.Graphics;
            G.Clear(mysticBackground);
            G.FillRectangle(new LinearGradientBrush(new Point(0, 0), new Point(0, Height), Color.FromArgb(66, 219, 183), Color.FromArgb(3, 122, 95)), new Rectangle(0, 0, Width, Height));

            switch (State)
            {
                case MouseState.Over:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.White)), new Rectangle(0, 0, Width, Height));
                    break;
                case MouseState.Down:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.Black)), new Rectangle(0, 0, Width, Height));
                    break;
            }

            G.FillRectangle(new SolidBrush(Color.FromArgb(44, 51, 62)), new Rectangle(0, 0, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(44, 51, 62)), new Rectangle(1, 0, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(44, 51, 62)), new Rectangle(0, 1, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(44, 51, 62)), new Rectangle(Width - 1, 0, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(44, 51, 62)), new Rectangle(Width - 1, 1, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(44, 51, 62)), new Rectangle(Width - 2, 0, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(44, 51, 62)), new Rectangle(0, Height - 1, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(44, 51, 62)), new Rectangle(1, Height - 1, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(44, 51, 62)), new Rectangle(0, Height - 2, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(44, 51, 62)), new Rectangle(Width - 1, Height - 1, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(44, 51, 62)), new Rectangle(Width - 1, Height - 2, 1, 1));
            G.FillRectangle(new SolidBrush(Color.FromArgb(44, 51, 62)), new Rectangle(Width - 2, Height - 1, 1, 1));

            StringFormat _StringF = new StringFormat();
            _StringF.Alignment = StringAlignment.Center;
            _StringF.LineAlignment = StringAlignment.Center;
            //G.DrawString(Text, new Font("Segoe UI", 9, FontStyle.Bold), Brushes.White, new RectangleF(0, 0, Width - 1, Height - 1), _StringF);

        }

    }

}

