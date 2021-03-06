﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.BaseContainer;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        #region Enum
        public enum CustomExcisionStyles
        {
            Default,
            Circle,
            BlueMode,
            WhiteMode,
        };
        #endregion
        
        #region Private Fields
        private CustomExcisionStyles customExcisionStyle = CustomExcisionStyles.Default;

        private string imageCodeString =
            "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";

        private Color[] customExcisionBorderColors = new Color[]
        {
            Color.Black,
            Color.White
        };
        #endregion

        #region Public Properties
        public CustomExcisionStyles CustomExcisionStyle
        {
            get { return customExcisionStyle; }
            set
            {
                customExcisionStyle = value;
                Invalidate();
            }
        }

        [Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
        public string ImageCodeString
        {
            get { return imageCodeString; }
            set
            {
                imageCodeString = value;
                Invalidate();
            }
        }

        public Color[] CustomExcisionBorderColors
        {
            get { return customExcisionBorderColors; }
            set { customExcisionBorderColors = value;
                Invalidate();
            }
        }

        #endregion

        #region Paint
        private void CustomExcisionDefaultButtonPaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle InnerRect = new Rectangle(1, 1, Width - 3, Height - 3);
            
            G.Clear(Parent.BackColor);
            Font drawFont = new Font("Tahoma", 10, FontStyle.Bold);

            //G.CompositingQuality = CompositingQuality.HighQuality
            //G.SmoothingMode = SmoothingMode.HighQuality;
            ImageToCodeClass cti = new ImageToCodeClass();

            Bitmap BUTTONGRAIN = (Bitmap)cti.CodeToImage(ImageCodeString);
            TextureBrush BUTTONIMAGE = new TextureBrush(BUTTONGRAIN, WrapMode.TileFlipXY);
            G.FillPath(BUTTONIMAGE, Draw.RoundRect(ClientRectangle, 4));
            //Pen p = new Pen(new SolidBrush(Color.FromArgb(117, 120, 117)));
            G.DrawPath(new Pen(CustomExcisionBorderColors[0]), Draw.RoundRect(ClientRectangle, 4));
            Pen Ip = new Pen(Color.FromArgb(45, CustomExcisionBorderColors[1]));
            G.DrawPath(Ip, Draw.RoundRect(InnerRect, 4));
            
            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            DrawImage(e.Graphics, this.ClientRectangle);
            //G.Dispose();
            //B.Dispose();
        }
     
        private void CustomExcisionCircleButtonPaint(System.Windows.Forms.PaintEventArgs e)
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

            Bitmap BUTTONGRAIN = (Bitmap) cti.CodeToImage(ImageCodeString);
            TextureBrush BUTTONIMAGE = new TextureBrush(BUTTONGRAIN, WrapMode.TileFlipXY);
            G.FillEllipse(BUTTONIMAGE, ClientRectangle);
            //Pen p = new Pen(new SolidBrush(Color.FromArgb(117, 120, 117)));
            G.DrawEllipse(new Pen(CustomExcisionBorderColors[0]), ClientRectangle);
            Pen Ip = new Pen(Color.FromArgb(45, CustomExcisionBorderColors[1]));
            G.DrawEllipse(Ip, InnerRect);

            
            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            DrawImage(e.Graphics, this.ClientRectangle);
            //G.Dispose();
            //B.Dispose();
        }
    
        private void CustomExcisionButtonBluePaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle InnerRect = new Rectangle(1, 1, Width - 3, Height - 3);
            
            G.Clear(Parent.BackColor);
            //Font drawFont = new Font("Tahoma", 10, FontStyle.Bold);

            //G.CompositingQuality = CompositingQuality.HighQuality
            G.SmoothingMode = Smoothing;

            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush BBG = new LinearGradientBrush(ClientRectangle, Color.FromArgb(85, 156, 188), Color.FromArgb(58, 136, 175), 90);
                    G.FillPath(BBG, Draw.RoundRect(ClientRectangle, 4));
                    Pen p = new Pen(new SolidBrush(Color.FromArgb(29, 46, 54)));
                    G.DrawPath(new Pen(CustomExcisionBorderColors[0]), Draw.RoundRect(ClientRectangle, 4));
                    Pen Ip = new Pen(Color.FromArgb(129, 175, 201));
                    G.DrawPath(Ip, Draw.RoundRect(InnerRect, 4));
                    break;
                case MouseState.Over:
                    LinearGradientBrush BBG1 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(45, 105, 135), Color.FromArgb(30, 90, 120), 90);
                    G.FillPath(BBG1, Draw.RoundRect(ClientRectangle, 4));
                    Pen p1 = new Pen(new SolidBrush(Color.FromArgb(29, 46, 54)));
                    G.DrawPath(new Pen(CustomExcisionBorderColors[0]), Draw.RoundRect(ClientRectangle, 4));
                    Pen Ip1 = new Pen(Color.FromArgb(114, 160, 186));
                    G.DrawPath(Ip1, Draw.RoundRect(InnerRect, 4));
                    break;
                case MouseState.Down:
                    LinearGradientBrush BBG2 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(85, 156, 188), Color.FromArgb(58, 136, 175), 90);
                    G.FillPath(BBG2, Draw.RoundRect(ClientRectangle, 4));
                    Pen p2 = new Pen(new SolidBrush(Color.FromArgb(29, 46, 54)));
                    G.DrawPath(new Pen(CustomExcisionBorderColors[0]), Draw.RoundRect(ClientRectangle, 4));
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
    
        private void CustomExcisionButtonWhitePaint(System.Windows.Forms.PaintEventArgs e)
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
                    G.DrawPath(new Pen(CustomExcisionBorderColors[0]), Draw.RoundRect(ClientRectangle, 4));
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
                    G.DrawPath(new Pen(CustomExcisionBorderColors[0]), Draw.RoundRect(ClientRectangle, 4));
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
                    G.DrawPath(new Pen(CustomExcisionBorderColors[0]), Draw.RoundRect(ClientRectangle, 4));
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
        
        private void CustomExcisionPaint(PaintEventArgs e)
        {
            switch (CustomExcisionStyle)
            {
                case CustomExcisionStyles.Default:
                    CustomExcisionDefaultButtonPaint(e);
                    break;
                case CustomExcisionStyles.Circle:
                    CustomExcisionCircleButtonPaint(e);
                    break;
                case CustomExcisionStyles.BlueMode:
                    CustomExcisionButtonBluePaint(e);
                    break;
                case CustomExcisionStyles.WhiteMode:
                    CustomExcisionButtonWhitePaint(e);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        #endregion
    }

}

