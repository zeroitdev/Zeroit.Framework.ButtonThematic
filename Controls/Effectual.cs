// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Effectual.cs" company="Zeroit Dev Technologies">
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

        public enum EffectualStyles
        {
            Blue,
            Gray,
            Orange,
        }

        private EffectualStyles effectualStyle = EffectualStyles.Blue;

        [Browsable(false)]
        public EffectualStyles EffectualStyle
        {
            get { return effectualStyle; }
            set { effectualStyle = value;
                Invalidate();
            }
        }

        
        private void EffectualButtonBlueOnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle InnerRect = new Rectangle(1, 1, Width - 3, Height - 3);
            
            G.Clear(Parent.BackColor);

            Font drawFont = new Font("Tahoma", 8, FontStyle.Bold);

            //G.CompositingQuality = CompositingQuality.HighQuality
            //G.SmoothingMode = Smoothing;

            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush lgb = new LinearGradientBrush(ClientRectangle, Color.FromArgb(123, 190, 216), Color.FromArgb(108, 175, 201), 90);
                    G.FillPath(lgb, Draw.RoundRect(ClientRectangle, 2));
                    Pen p = new Pen(new SolidBrush(Color.FromArgb(60, 113, 132)));
                    G.DrawPath(p, Draw.RoundRect(ClientRectangle, 2));
                    Pen Ip = new Pen(Color.FromArgb(75, Color.White));
                    G.DrawPath(Ip, Draw.RoundRect(InnerRect, 2));
                    break;
                case MouseState.Over:
                    LinearGradientBrush lgb1 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(113, 180, 206), Color.FromArgb(114, 181, 207), 90);
                    G.FillPath(lgb1, Draw.RoundRect(ClientRectangle, 2));
                    Pen p1 = new Pen(new SolidBrush(Color.FromArgb(60, 113, 132)));
                    G.DrawPath(p1, Draw.RoundRect(ClientRectangle, 2));
                    Pen Ip1 = new Pen(Color.FromArgb(75, Color.White));
                    G.DrawPath(Ip1, Draw.RoundRect(InnerRect, 2));
                    break;
                case MouseState.Down:
                    LinearGradientBrush lgb2 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(123, 190, 216), Color.FromArgb(108, 175, 201), 90);
                    G.FillPath(lgb2, Draw.RoundRect(ClientRectangle, 2));
                    Pen p2 = new Pen(new SolidBrush(Color.FromArgb(60, 113, 132)));
                    G.DrawPath(p2, Draw.RoundRect(ClientRectangle, 2));
                    Pen Ip3 = new Pen(Color.FromArgb(75, Color.White));
                    G.DrawPath(Ip3, Draw.RoundRect(InnerRect, 2));
                    break;
            }

            //G.DrawString(Text, drawFont, new SolidBrush(Color.White), new Rectangle(0, 1, Width - 1, Height - 1), new StringFormat
            //{
            //    Alignment = StringAlignment.Center,
            //    LineAlignment = StringAlignment.Center
            //});

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            //G.Dispose();
            //B.Dispose();
        }
    
        private void EffectualButtonOrangeOnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle InnerRect = new Rectangle(1, 1, Width - 3, Height - 3);


            G.Clear(Parent.BackColor);
            Font drawFont = new Font("Tahoma", 8, FontStyle.Bold);

            //G.CompositingQuality = CompositingQuality.HighQuality
            G.SmoothingMode = Smoothing;

            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush lgb = new LinearGradientBrush(ClientRectangle, Color.FromArgb(214, 162, 68), Color.FromArgb(199, 147, 53), 90);
                    G.FillPath(lgb, Draw.RoundRect(ClientRectangle, 2));

                    Pen p = new Pen(new SolidBrush(Color.FromArgb(142, 107, 46)));
                    G.DrawPath(p, Draw.RoundRect(ClientRectangle, 2));
                    Pen Ip = new Pen(Color.FromArgb(75, Color.White));
                    G.DrawPath(Ip, Draw.RoundRect(InnerRect, 2));
                    break;
                case MouseState.Over:
                    LinearGradientBrush lgb1 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(204, 152, 58), Color.FromArgb(205, 153, 59), 90);
                    G.FillPath(lgb1, Draw.RoundRect(ClientRectangle, 2));
                    Pen p1 = new Pen(new SolidBrush(Color.FromArgb(142, 107, 46)));
                    G.DrawPath(p1, Draw.RoundRect(ClientRectangle, 2));
                    Pen Ip1 = new Pen(Color.FromArgb(75, Color.White));
                    G.DrawPath(Ip1, Draw.RoundRect(InnerRect, 2));
                    break;
                case MouseState.Down:
                    LinearGradientBrush lgb2 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(214, 162, 68), Color.FromArgb(199, 147, 53), 90);
                    G.FillPath(lgb2, Draw.RoundRect(ClientRectangle, 2));
                    Pen p2 = new Pen(new SolidBrush(Color.FromArgb(142, 107, 46)));
                    G.DrawPath(p2, Draw.RoundRect(ClientRectangle, 2));
                    Pen Ip2 = new Pen(Color.FromArgb(75, Color.White));
                    G.DrawPath(Ip2, Draw.RoundRect(InnerRect, 2));
                    break;
            }

            //G.DrawString(Text, drawFont, new SolidBrush(Color.White), new Rectangle(0, 1, Width - 1, Height - 1), new StringFormat
            //{
            //    Alignment = StringAlignment.Center,
            //    LineAlignment = StringAlignment.Center
            //});

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            //G.Dispose();
            //B.Dispose();
        }
    
        private void EffectualButtonGrayOnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle InnerRect = new Rectangle(1, 1, Width - 3, Height - 3);

            G.Clear(Parent.BackColor);
            Font drawFont = new Font("Tahoma", 8, FontStyle.Bold);

            //G.CompositingQuality = CompositingQuality.HighQuality
            G.SmoothingMode = Smoothing;

            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush lgb = new LinearGradientBrush(ClientRectangle, Color.FromArgb(203, 201, 205), Color.FromArgb(188, 186, 190), 90);
                    G.FillPath(lgb, Draw.RoundRect(ClientRectangle, 2));
                    Pen p = new Pen(new SolidBrush(Color.FromArgb(117, 120, 117)));
                    G.DrawPath(p, Draw.RoundRect(ClientRectangle, 2));
                    Pen Ip = new Pen(Color.FromArgb(75, Color.White));
                    G.DrawPath(Ip, Draw.RoundRect(InnerRect, 2));
                    break;
                case MouseState.Over:
                    LinearGradientBrush lgb1 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(193, 191, 195), Color.FromArgb(194, 192, 196), 90);
                    G.FillPath(lgb1, Draw.RoundRect(ClientRectangle, 2));
                    Pen p1 = new Pen(new SolidBrush(Color.FromArgb(117, 120, 117)));
                    G.DrawPath(p1, Draw.RoundRect(ClientRectangle, 2));
                    Pen Ip1 = new Pen(Color.FromArgb(75, Color.White));
                    G.DrawPath(Ip1, Draw.RoundRect(InnerRect, 2));
                    break;
                case MouseState.Down:
                    LinearGradientBrush lgb2 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(203, 201, 205), Color.FromArgb(188, 186, 190), 90);
                    G.FillPath(lgb2, Draw.RoundRect(ClientRectangle, 2));
                    Pen p2 = new Pen(new SolidBrush(Color.FromArgb(117, 120, 117)));
                    G.DrawPath(p2, Draw.RoundRect(ClientRectangle, 2));
                    Pen Ip2 = new Pen(Color.FromArgb(75, Color.White));
                    G.DrawPath(Ip2, Draw.RoundRect(InnerRect, 2));
                    break;
            }

            //G.DrawString(Text, drawFont, new SolidBrush(Color.FromArgb(50, 50, 50)), new Rectangle(0, 1, Width - 1, Height - 1), new StringFormat
            //{
            //    Alignment = StringAlignment.Center,
            //    LineAlignment = StringAlignment.Center
            //});

            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            //G.Dispose();
            //B.Dispose();
        }

        private void EffectualPaint(PaintEventArgs e)
        {
            switch (EffectualStyle)
            {
                case EffectualStyles.Blue:
                    EffectualButtonBlueOnPaint(e);
                    break;
                case EffectualStyles.Gray:
                    EffectualButtonGrayOnPaint(e);
                    break;
                case EffectualStyles.Orange:
                    EffectualButtonOrangeOnPaint(e);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }

}

