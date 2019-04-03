// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Visceral.cs" company="Zeroit Dev Technologies">
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

        
        
        private void VisceralPaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);

            G.Clear(Parent.BackColor);
            Font drawFont = new Font("Arial", 8, FontStyle.Bold);
            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush lgb = new LinearGradientBrush(ClientRectangle, Color.FromArgb(61, 61, 63), Color.FromArgb(14, 14, 14), 90);
                    G.FillPath(lgb, Draw.RoundRect(ClientRectangle, 3));
                    LinearGradientBrush gloss = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height / 2), Color.FromArgb(100, Color.FromArgb(61, 61, 63)), Color.FromArgb(12, 255, 255, 255), 90);
                    G.FillPath(gloss, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height / 2), 3));
                    G.DrawPath(Pens.Black, Draw.RoundRect(ClientRectangle, 3));
                    //G.DrawString(Text, drawFont, new SolidBrush(ForeColor), new Rectangle(0, 0, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Over:
                    LinearGradientBrush lgb1 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(245, 61, 61, 63), Color.FromArgb(245, 14, 14, 14), 90);
                    G.FillPath(lgb1, Draw.RoundRect(ClientRectangle, 3));
                    LinearGradientBrush gloss1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height / 2), Color.FromArgb(75, Color.FromArgb(61, 61, 63)), Color.FromArgb(20, 255, 255, 255), 90);
                    G.FillPath(gloss1, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height / 2), 3));
                    G.DrawPath(Pens.Black, Draw.RoundRect(ClientRectangle, 3));
                    //G.DrawString(Text, drawFont, new SolidBrush(ForeColor), new Rectangle(0, 0, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Down:
                    LinearGradientBrush lgb2 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(51, 51, 53), Color.FromArgb(4, 4, 4), 90);
                    G.FillPath(lgb2, Draw.RoundRect(ClientRectangle, 3));
                    LinearGradientBrush gloss2 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height / 2), Color.FromArgb(75, Color.FromArgb(61, 61, 63)), Color.FromArgb(5, 255, 255, 255), 90);
                    G.FillPath(gloss2, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height / 2), 3));
                    G.DrawPath(Pens.Black, Draw.RoundRect(ClientRectangle, 3));
                    //G.DrawString(Text, drawFont, new SolidBrush(ForeColor), new Rectangle(0, 0, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
            }

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            //G.Dispose();
            //B.Dispose();
        }

    }

}

