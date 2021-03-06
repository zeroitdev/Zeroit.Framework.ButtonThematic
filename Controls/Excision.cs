﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Excision.cs" company="Zeroit Dev Technologies">
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

        public enum ExcisionStyles
        {
            Default,
            Circle,
            BlueMode,
            WhiteMode,
        };

        private ExcisionStyles excisionStyle = ExcisionStyles.Default;

        [Browsable(false)]
        public ExcisionStyles ExcisionStyle
        {
            get { return excisionStyle; }
            set { excisionStyle = value;
                Invalidate();
            }
        }


        private void ExcisionDefaultButtonPaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle InnerRect = new Rectangle(1, 1, Width - 3, Height - 3);
            
            G.Clear(Parent.BackColor);
            Font drawFont = new Font("Tahoma", 10, FontStyle.Bold);

            //G.CompositingQuality = CompositingQuality.HighQuality
            G.SmoothingMode = SmoothingMode.HighQuality;
            ImageToCodeClass cti = new ImageToCodeClass();

            Bitmap BUTTONGRAIN = (Bitmap)cti.CodeToImage("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");
            TextureBrush BUTTONIMAGE = new TextureBrush(BUTTONGRAIN, WrapMode.TileFlipXY);
            G.FillPath(BUTTONIMAGE, Draw.RoundRect(ClientRectangle, 4));
            Pen p = new Pen(new SolidBrush(Color.FromArgb(117, 120, 117)));
            G.DrawPath(Pens.Black, Draw.RoundRect(ClientRectangle, 4));
            Pen Ip = new Pen(Color.FromArgb(45, Color.White));
            G.DrawPath(Ip, Draw.RoundRect(InnerRect, 4));

            switch (State)
            {
                case MouseState.None:
                    //G.DrawString(Text, drawFont, new SolidBrush(Color.FromArgb(178, 178, 178)), new Rectangle(0, 1, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Over:
                    //G.DrawString(Text, drawFont, new SolidBrush(Color.WhiteSmoke), new Rectangle(0, 1, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Down:
                    //G.DrawString(Text, drawFont, new SolidBrush(Color.FromArgb(178, 178, 178)), new Rectangle(0, 1, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});

                    break;
            }

            
            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            DrawImage(e.Graphics, this.ClientRectangle);
            //G.Dispose();
            //B.Dispose();
        }
     
        private void ExcisionCircleButtonPaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle InnerRect = new Rectangle(1, 1, Width - 3, Height - 3);
            
            G.Clear(BackColor);
            Font drawFont = new Font("Tahoma", 10, FontStyle.Bold);

            //G.CompositingQuality = CompositingQuality.HighQuality
            G.SmoothingMode = SmoothingMode.HighQuality;
            ImageToCodeClass cti = new ImageToCodeClass();

            Bitmap BUTTONGRAIN = (Bitmap)cti.CodeToImage("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");
            TextureBrush BUTTONIMAGE = new TextureBrush(BUTTONGRAIN, WrapMode.TileFlipXY);
            G.FillEllipse(BUTTONIMAGE, ClientRectangle);
            Pen p = new Pen(new SolidBrush(Color.FromArgb(117, 120, 117)));
            G.DrawEllipse(Pens.Black, ClientRectangle);
            Pen Ip = new Pen(Color.FromArgb(45, Color.White));
            G.DrawEllipse(Ip, InnerRect);

            switch (State)
            {
                case MouseState.None:
                    //G.DrawString(Text, drawFont, new SolidBrush(Color.FromArgb(178, 178, 178)), new Rectangle(0, 1, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Over:
                    //G.DrawString(Text, drawFont, new SolidBrush(Color.WhiteSmoke), new Rectangle(0, 1, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Down:
                    //G.DrawString(Text, drawFont, new SolidBrush(Color.FromArgb(178, 178, 178)), new Rectangle(0, 1, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});

                    break;
            }
            
            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            DrawImage(e.Graphics, this.ClientRectangle);
            //G.Dispose();
            //B.Dispose();
        }
    
        private void ExcisionButtonBluePaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle InnerRect = new Rectangle(1, 1, Width - 3, Height - 3);
            
            G.Clear(Parent.BackColor);
            Font drawFont = new Font("Tahoma", 10, FontStyle.Bold);

            //G.CompositingQuality = CompositingQuality.HighQuality
            G.SmoothingMode = Smoothing;

            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush BBG = new LinearGradientBrush(ClientRectangle, Color.FromArgb(85, 156, 188), Color.FromArgb(58, 136, 175), 90);
                    G.FillPath(BBG, Draw.RoundRect(ClientRectangle, 4));
                    Pen p = new Pen(new SolidBrush(Color.FromArgb(29, 46, 54)));
                    G.DrawPath(Pens.Black, Draw.RoundRect(ClientRectangle, 4));
                    Pen Ip = new Pen(Color.FromArgb(129, 175, 201));
                    G.DrawPath(Ip, Draw.RoundRect(InnerRect, 4));
                    break;
                case MouseState.Over:
                    LinearGradientBrush BBG1 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(45, 105, 135), Color.FromArgb(30, 90, 120), 90);
                    G.FillPath(BBG1, Draw.RoundRect(ClientRectangle, 4));
                    Pen p1 = new Pen(new SolidBrush(Color.FromArgb(29, 46, 54)));
                    G.DrawPath(Pens.Black, Draw.RoundRect(ClientRectangle, 4));
                    Pen Ip1 = new Pen(Color.FromArgb(114, 160, 186));
                    G.DrawPath(Ip1, Draw.RoundRect(InnerRect, 4));
                    break;
                case MouseState.Down:
                    LinearGradientBrush BBG2 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(85, 156, 188), Color.FromArgb(58, 136, 175), 90);
                    G.FillPath(BBG2, Draw.RoundRect(ClientRectangle, 4));
                    Pen p2 = new Pen(new SolidBrush(Color.FromArgb(29, 46, 54)));
                    G.DrawPath(Pens.Black, Draw.RoundRect(ClientRectangle, 4));
                    Pen Ip2 = new Pen(Color.FromArgb(129, 175, 201));
                    G.DrawPath(Ip2, Draw.RoundRect(InnerRect, 4));
                    break;
            }

            //G.DrawString(Text, drawFont, new SolidBrush(Color.WhiteSmoke), new Rectangle(0, 1, Width - 1, Height - 1), new StringFormat
            //{
            //    Alignment = StringAlignment.Center,
            //    LineAlignment = StringAlignment.Center
            //});


            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            DrawImage(e.Graphics, this.ClientRectangle);
            //G.Dispose();
            //B.Dispose();
        }
    
        private void ExcisionButtonWhitePaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle InnerRect = new Rectangle(1, 1, Width - 3, Height - 3);

            
            G.Clear(Parent.BackColor);
            Font drawFont = new Font("Tahoma", 10, FontStyle.Bold);

            //G.CompositingQuality = CompositingQuality.HighQuality
            G.SmoothingMode = Smoothing;

            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush BBG = new LinearGradientBrush(ClientRectangle, Color.FromArgb(225, 225, 225), Color.FromArgb(210, 210, 210), 90);
                    G.FillPath(BBG, Draw.RoundRect(ClientRectangle, 4));
                    Pen p = new Pen(new SolidBrush(Color.FromArgb(254, 254, 254)));
                    G.DrawPath(Pens.Black, Draw.RoundRect(ClientRectangle, 4));
                    Pen Ip = new Pen(Color.FromArgb(255, 255, 255));
                    G.DrawPath(Ip, Draw.RoundRect(InnerRect, 4));
                    //G.DrawString(Text, drawFont, new SolidBrush(Color.FromArgb(82, 87, 93)), new Rectangle(0, 1, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Over:
                    LinearGradientBrush BBG1 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(222, 222, 222), Color.FromArgb(222, 222, 222), 90);
                    G.FillPath(BBG1, Draw.RoundRect(ClientRectangle, 4));
                    Pen p1 = new Pen(new SolidBrush(Color.FromArgb(222, 222, 222)));
                    G.DrawPath(Pens.Black, Draw.RoundRect(ClientRectangle, 4));
                    Pen Ip1 = new Pen(Color.FromArgb(255, 255, 255));
                    G.DrawPath(Ip1, Draw.RoundRect(InnerRect, 4));
                    //G.DrawString(Text, drawFont, new SolidBrush(Color.FromArgb(85, 85, 85)), new Rectangle(0, 1, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});

                    break;
                case MouseState.Down:
                    LinearGradientBrush BBG2 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(254, 254, 254), Color.FromArgb(248, 246, 247), 90);
                    G.FillPath(BBG2, Draw.RoundRect(ClientRectangle, 4));
                    Pen p2 = new Pen(new SolidBrush(Color.FromArgb(254, 254, 254)));
                    G.DrawPath(Pens.Black, Draw.RoundRect(ClientRectangle, 4));
                    Pen Ip2 = new Pen(Color.FromArgb(255, 255, 255));
                    G.DrawPath(Ip2, Draw.RoundRect(InnerRect, 4));
                    //G.DrawString(Text, drawFont, new SolidBrush(Color.FromArgb(82, 87, 93)), new Rectangle(0, 1, Width - 1, Height - 1), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
            }


            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            DrawImage(e.Graphics, this.ClientRectangle);
            //G.Dispose();
            //B.Dispose();
        }

        private void ExcisionPaint(PaintEventArgs e)
        {
            switch (ExcisionStyle)
            {
                case ExcisionStyles.Default:
                    ExcisionDefaultButtonPaint(e);
                    break;
                case ExcisionStyles.Circle:
                    ExcisionCircleButtonPaint(e);
                    break;
                case ExcisionStyles.BlueMode:
                    ExcisionButtonBluePaint(e);
                    break;
                case ExcisionStyles.WhiteMode:
                    ExcisionButtonWhitePaint(e);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

    }

}

