// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Crystal.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {
        Color crystalG1 = Color.FromArgb(230, 230, 230);
        Color crystalG2 = Color.FromArgb(210, 210, 210);
        Color crystalGlow = Color.FromArgb(230, 230, 230);
        Color crystalEdge = Color.FromArgb(170, 170, 170);
        private Color crystalTextColor = Color.Black;
        Color crystalHover = Color.White;

        int crystalA = 0;
        

        public void CrystalClearButton()
        {
            IsAnimated = true;
            
        }

        

        private void CrystalPaintHook()
        {
            G.Clear(Parent.BackColor);
            LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(new Point(1, 1), new Size(Width - 2, Height - 2)), crystalG1, crystalG2, 90f);
            HatchBrush HB = new HatchBrush(HatchStyle.LightDownwardDiagonal, Color.FromArgb(7, Color.Black), Color.Transparent);
            G.FillRectangle(LGB, new Rectangle(new Point(1, 1), new Size(Width - 2, Height - 2)));
            G.FillRectangle(new SolidBrush(crystalGlow), new Rectangle(new Point(1, 1), new Size(Width - 2, (Height / 2) - 3)));
            G.FillRectangle(HB, new Rectangle(new Point(1, 1), new Size(Width - 2, Height - 2)));

            if (State == MouseState.Over | State == MouseState.None)
            {
                SolidBrush SB = new SolidBrush(Color.FromArgb(crystalA * 2, Color.White));
                G.FillRectangle(SB, new Rectangle(new Point(1, 1), new Size(Width - 2, Height - 2)));
            }
            else if (State == MouseState.Down)
            {
                SolidBrush SB = new SolidBrush(Color.FromArgb(2, Color.Black));
                G.FillRectangle(SB, new Rectangle(new Point(1, 1), new Size(Width - 2, Height - 2)));
            }

            G.DrawRectangle(new Pen(crystalEdge), new Rectangle(new Point(1, 1), new Size(Width - 2, Height - 2)));

            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;

            //G.DrawString(Text, Font, GetBrush("Text"), new RectangleF(2, 2, this.Width - 5, this.Height - 4), sf);
        }

        

    }

}

