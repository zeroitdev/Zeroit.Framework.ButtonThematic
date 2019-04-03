// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Redemption.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {
        public enum RedemptionStyles
        {
            Rectangle,
            Circle
        }

        private RedemptionStyles redemptionStyle = RedemptionStyles.Rectangle;

        [Browsable(false)]
        public RedemptionStyles RedemptionStyle
        {
            get { return redemptionStyle; }
            set { redemptionStyle = value;
                Invalidate();
            }
        }


        private void RedemptionRectPaint(PaintEventArgs e)
        {
            int curve = 5;
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            G.Clear(Parent.BackColor);
            if (Enabled)
            {
                switch (State)
                {
                    case MouseState.None:
                        LinearGradientBrush MainBody = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(55, 62, 70), Color.FromArgb(43, 44, 48), 90);
                        G.FillPath(MainBody, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), curve));
                        LinearGradientBrush GlossPen = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(93, 98, 104), Color.Transparent, 90);
                        G.DrawPath(new Pen(GlossPen), Draw.RoundRect(new Rectangle(0, 1, Width - 1, Height - 1), curve + 1));
                        break;
                    case MouseState.Over:
                        LinearGradientBrush MainBody1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(72, 79, 87), Color.FromArgb(48, 51, 56), 90);
                        G.FillPath(MainBody1, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), curve));
                        LinearGradientBrush GlossPen1 = new LinearGradientBrush(new Rectangle(1, 1, Width - 3, Height - 3), Color.FromArgb(119, 124, 130), Color.FromArgb(64, 67, 72), 90);
                        G.DrawPath(new Pen(GlossPen1), Draw.RoundRect(new Rectangle(1, 1, Width - 3, Height - 3), curve));
                        break;
                    case MouseState.Down:
                        LinearGradientBrush MainBody2 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(43, 44, 48), Color.FromArgb(51, 54, 59), 90);
                        G.FillPath(MainBody2, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), curve));
                        LinearGradientBrush GlossPen2 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(55, 56, 60), Color.Transparent, 90);
                        G.DrawPath(new Pen(GlossPen2), Draw.RoundRect(new Rectangle(0, 1, Width - 1, Height - 1), curve + 1));
                        break;
                }

                G.DrawPath(new Pen(Color.FromArgb(31, 36, 42)), Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), curve));

            }
            else
            {
            }


            StringFormat sf = new StringFormat();
            //switch (TextAlign)
            //{
            //    case HorizontalAlignment.Center:
            //        sf.Alignment = StringAlignment.Center;
            //        sf.LineAlignment = StringAlignment.Center;
            //        G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(16, 20, 21)), new Rectangle(1, 2, Width - 1, Height - 1), sf);
            //        G.DrawString(Text, Font, Brushes.White, new Rectangle(0, 1, Width - 1, Height - 1), sf);
            //        break;
            //    case HorizontalAlignment.Left:
            //        sf.Alignment = StringAlignment.Near;
            //        sf.LineAlignment = StringAlignment.Center;
            //        G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(16, 20, 21)), new Rectangle(6, 2, Width - 1, Height - 1), sf);
            //        G.DrawString(Text, Font, Brushes.White, new Rectangle(5, 1, Width - 1, Height - 1), sf);
            //        break;
            //    case HorizontalAlignment.Right:
            //        sf.Alignment = StringAlignment.Far;
            //        sf.LineAlignment = StringAlignment.Center;
            //        G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(16, 20, 21)), new Rectangle(-3, 2, Width - 1, Height - 1), sf);
            //        G.DrawString(Text, Font, Brushes.White, new Rectangle(-4, 1, Width - 1, Height - 1), sf);
            //        break;
            //}


            e.Graphics.DrawImage(B, new Point(0, 0));
            //G.Dispose();
            //B.Dispose();
        }
        
        private void RedemptionCirclePaint(PaintEventArgs e)
        {
            int curve = 13;
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            if (Enabled)
            {
                G.Clear(BackColor);
                switch (State)
                {
                    case MouseState.None:
                        LinearGradientBrush MainBody = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(131, 198, 240), Color.FromArgb(24, 121, 218), 90);
                        G.FillPath(MainBody, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), curve));
                        LinearGradientBrush GlossPen = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(145, 212, 254), Color.Transparent, 90);
                        G.DrawPath(new Pen(GlossPen), Draw.RoundRect(new Rectangle(0, 1, Width - 1, Height - 2), curve + 1));
                        break;
                    case MouseState.Over:
                        LinearGradientBrush MainBody1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(150, 203, 235), Color.FromArgb(35, 135, 220), 90);
                        G.FillPath(MainBody1, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), curve));
                        LinearGradientBrush GlossPen1 = new LinearGradientBrush(new Rectangle(1, 1, Width - 3, Height - 3), Color.FromArgb(173, 226, 255), Color.FromArgb(54, 155, 235), 90);
                        G.DrawPath(new Pen(GlossPen1), Draw.RoundRect(new Rectangle(1, 1, Width - 3, Height - 3), curve));
                        break;
                    case MouseState.Down:
                        LinearGradientBrush MainBody2 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(30, 121, 210), Color.FromArgb(84, 172, 236), 90);
                        G.FillPath(MainBody2, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), curve));
                        LinearGradientBrush GlossPen2 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(54, 145, 234), Color.Transparent, 90);
                        G.DrawPath(new Pen(GlossPen2), Draw.RoundRect(new Rectangle(0, 1, Width - 1, Height - 1), curve + 1));
                        break;
                }
                G.DrawPath(new Pen(Color.FromArgb(21, 38, 56)), Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), curve));
                G.FillRectangle(new SolidBrush(Parent.BackColor), new Rectangle(-1, -1, 2, 10));
                G.FillRectangle(new SolidBrush(Parent.BackColor), new Rectangle(-2, -1, 4, 9));

            }
            else
            {
            }


            StringFormat sf = new StringFormat();
            //switch (TextAlign)
            //{
            //    case HorizontalAlignment.Center:
            //        sf.Alignment = StringAlignment.Center;
            //        sf.LineAlignment = StringAlignment.Center;
            //        G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(16, 20, 21)), new Rectangle(1, 2, Width - 1, Height - 1), sf);
            //        G.DrawString(Text, Font, Brushes.White, new Rectangle(0, 1, Width - 1, Height - 1), sf);
            //        break;
            //    case HorizontalAlignment.Left:
            //        sf.Alignment = StringAlignment.Near;
            //        sf.LineAlignment = StringAlignment.Center;
            //        G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(16, 20, 21)), new Rectangle(6, 2, Width - 1, Height - 1), sf);
            //        G.DrawString(Text, Font, Brushes.White, new Rectangle(5, 1, Width - 1, Height - 1), sf);
            //        break;
            //    case HorizontalAlignment.Right:
            //        sf.Alignment = StringAlignment.Far;
            //        sf.LineAlignment = StringAlignment.Center;
            //        G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(16, 20, 21)), new Rectangle(-3, 2, Width - 1, Height - 1), sf);
            //        G.DrawString(Text, Font, Brushes.White, new Rectangle(-4, 1, Width - 1, Height - 1), sf);
            //        break;
            //}


            e.Graphics.DrawImage(B, new Point(0, 0));
            //G.Dispose();
            //B.Dispose();
        }

        private void RedemptionPaint(PaintEventArgs e)
        {
            switch (RedemptionStyle)
            {
                case RedemptionStyles.Rectangle:
                    RedemptionRectPaint(e);
                    break;
                case RedemptionStyles.Circle:
                    RedemptionCirclePaint(e);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        
    }


}

