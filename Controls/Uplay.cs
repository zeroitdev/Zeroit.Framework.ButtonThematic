// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Uplay.cs" company="Zeroit Dev Technologies">
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

        public void UPlaybutton()
        {
            IsAnimated = true;
            
        }
        Color uPlayG1 = Color.FromArgb(60, 60, 60);
        Color uPlayG2 = Color.FromArgb(65, 65, 65);
        Color uPlayGlow = Color.FromArgb(70, 70, 70);
        Color uPlayEdge = Color.FromArgb(60, 60, 60);
        Color uPlayHovercolor = Color.FromArgb(30, 30, 30);

        int uPlayA = 0;
       

        private void UPlayOnAnimation()
        {
            switch (State)
            {
                case MouseState.Over:
                    if (uPlayA < 40)
                    {
                        uPlayA += 8;
                        Invalidate();
                        Application.DoEvents();
                    }
                    break;
                case MouseState.None:
                    if (uPlayA > 0)
                    {
                        uPlayA -= 10;
                        if (uPlayA < 0)
                            uPlayA = 0;
                        Invalidate();
                        Application.DoEvents();
                    }
                    break;
            }
        }

        private void UPlayPaintHook()
        {
            G.Clear(uPlayG1);
            LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(new Point(1, 1), new Size(Width - 2, Height - 2)), uPlayG1, uPlayG2, 90f);

            G.FillRectangle(LGB, new Rectangle(new Point(1, 1), new Size(Width - 2, Height - 2)));
            G.FillRectangle(new SolidBrush(uPlayGlow), new Rectangle(new Point(1, 1), new Size(Width - 2, (Height / 2) - 3)));


            if (State == MouseState.Over | State == MouseState.None)
            {
                SolidBrush SB = new SolidBrush(Color.FromArgb(uPlayA * 2, Color.FromArgb(30, 30, 30)));
                G.FillRectangle(SB, new Rectangle(new Point(1, 1), new Size(Width - 2, Height - 2)));
            }
            else if (State == MouseState.Down)
            {
                SolidBrush SB = new SolidBrush(Color.FromArgb(2, Color.Black));
                G.FillRectangle(SB, new Rectangle(new Point(1, 1), new Size(Width - 2, Height - 2)));
            }

            G.DrawRectangle(new Pen(uPlayEdge), new Rectangle(new Point(1, 1), new Size(Width - 2, Height - 2)));
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            //G.DrawString(Text, Font, GetBrush("Text"), new RectangleF(2, 2, this.Width - 5, this.Height - 4), sf);
        }

        

    }

}

