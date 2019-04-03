// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Sharp.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        private bool sharpColor2 = false;

        [Browsable(false)]
        public bool SharpColor2
        {
            get { return sharpColor2; }
            set
            {
                sharpColor2 = value;
                this.Refresh();
            }
        }
        
        
        private void SharpPaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            
            switch (State)
            {
                case MouseState.None:
                    if (sharpColor2)
                    {
                        G.Clear(Color.FromArgb(43, 53, 63));
                        LinearGradientBrush BTNLGBOver = new LinearGradientBrush(new Rectangle(2, 1, Width - 3, Height / 2 - 2), Color.FromArgb(37, 47, 57), Color.FromArgb(140, 149, 155), 180);
                        G.FillRectangle(BTNLGBOver, new Rectangle(2, 1, Width - 3, Height / 2 - 2));
                        LinearGradientBrush BTNLGB1 = new LinearGradientBrush(new Rectangle(0, 1, Width - 2, Height / 2 - 2), Color.FromArgb(140, 149, 155), Color.FromArgb(37, 47, 57), 180);
                        G.FillRectangle(BTNLGB1, new Rectangle(1, 1, Width / 2, Height / 2 - 2));

                        
                        //----- Borders -----
                        G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(23, 33, 43))), new Rectangle(0, 0, Width - 1, Height - 1));
                        LinearGradientBrush InnerRect = new LinearGradientBrush(new Rectangle(1, 1, Width - 3, Height - 2), Color.FromArgb(113, 123, 133), Color.FromArgb(50, 50, 50), 90);
                        G.DrawRectangle(new Pen(InnerRect), new Rectangle(1, 1, Width - 3, Height - 3));
                        G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(63, 73, 83))), 2, Height - 2, Width - 2, Height - 2);
                        //G.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(0, -1, Width - 1, Height - 1), new StringFormat
                        //{
                        //    LineAlignment = StringAlignment.Center,
                        //    Alignment = StringAlignment.Center
                        //});
                    }
                    else
                    {
                        G.Clear(Color.FromArgb(43, 53, 63));
                        LinearGradientBrush BTNLGBOver = new LinearGradientBrush(new Rectangle(2, 1, Width - 3, Height / 2 - 2), Color.FromArgb(37, 47, 57), Color.FromArgb(140, 149, 155), LinearGradientMode.Horizontal);
                        G.FillRectangle(BTNLGBOver, new Rectangle(2, 1, Width - 3, Height / 2 - 2));
                        LinearGradientBrush BTNLGB1 = new LinearGradientBrush(new Rectangle(0, 1, Width - 2, Height / 2 - 2), Color.FromArgb(140, 149, 155), Color.FromArgb(37, 47, 57), LinearGradientMode.Horizontal);
                        G.FillRectangle(BTNLGB1, new Rectangle(1, 1, Width / 2, Height / 2 - 2));

                        
                        //----- Borders -----
                        G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(33, 43, 53))), new Rectangle(0, 0, Width - 1, Height - 1));
                        LinearGradientBrush InnerRect = new LinearGradientBrush(new Rectangle(1, 1, Width - 3, Height - 2), Color.FromArgb(153, 163, 173), Color.FromArgb(50, 50, 50), 90);
                        G.DrawRectangle(new Pen(InnerRect), new Rectangle(1, 1, Width - 3, Height - 3));
                        G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(73, 83, 93))), 1, Height - 2, Width - 2, Height - 2);
                        //G.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(0, -1, Width - 1, Height - 1), new StringFormat
                        //{
                        //    LineAlignment = StringAlignment.Center,
                        //    Alignment = StringAlignment.Center
                        //});
                    }
                    break;
                case MouseState.Over:
                    if (sharpColor2)
                    {
                        G.Clear(Color.FromArgb(47, 57, 67));
                        LinearGradientBrush LGBOver = new LinearGradientBrush(new Rectangle(2, 1, Width - 3, Height / 2 - 2), Color.FromArgb(43, 53, 63), Color.FromArgb(157, 166, 172), 180);
                        G.FillRectangle(LGBOver, new Rectangle(2, 1, Width - 3, Height / 2 - 2));
                        LinearGradientBrush LGBOver1 = new LinearGradientBrush(new Rectangle(0, 1, Width - 2, Height / 2 - 2), Color.FromArgb(157, 166, 172), Color.FromArgb(43, 53, 63), 180);
                        G.FillRectangle(LGBOver1, new Rectangle(1, 1, Width / 2, Height / 2 - 2));

                        
                        //----- Borders -----
                        G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(29, 39, 49))), new Rectangle(0, 0, Width - 1, Height - 1));
                        LinearGradientBrush InnerRect = new LinearGradientBrush(new Rectangle(1, 1, Width - 3, Height - 2), Color.FromArgb(153, 163, 173), Color.FromArgb(50, 50, 50), 90);
                        G.DrawRectangle(new Pen(InnerRect), new Rectangle(1, 1, Width - 3, Height - 3));
                        G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(73, 83, 93))), 1, Height - 2, Width - 2, Height - 2);
                        //G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(200, 210, 220)), new Rectangle(0, -1, Width - 1, Height - 1), new StringFormat
                        //{
                        //    LineAlignment = StringAlignment.Center,
                        //    Alignment = StringAlignment.Center
                        //});
                    }
                    else
                    {
                        G.Clear(Color.FromArgb(51, 61, 71));
                        LinearGradientBrush LGBOver = new LinearGradientBrush(new Rectangle(2, 1, Width - 3, Height / 2 - 2), Color.FromArgb(43, 53, 63), Color.FromArgb(154, 163, 169), LinearGradientMode.Horizontal);
                        G.FillRectangle(LGBOver, new Rectangle(2, 1, Width - 3, Height / 2 - 2));
                        LinearGradientBrush LGBOver1 = new LinearGradientBrush(new Rectangle(0, 1, Width - 2, Height / 2 - 2), Color.FromArgb(154, 163, 169), Color.FromArgb(43, 53, 63), LinearGradientMode.Horizontal);
                        G.FillRectangle(LGBOver1, new Rectangle(0, 1, Width / 2, Height / 2 - 2));

                        
                        //----- Borders -----
                        G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(43, 53, 63))), new Rectangle(0, 0, Width - 1, Height - 1));
                        LinearGradientBrush InnerRect = new LinearGradientBrush(new Rectangle(1, 1, Width - 3, Height - 2), Color.FromArgb(163, 173, 183), Color.FromArgb(60, 60, 60), 90);
                        G.DrawRectangle(new Pen(InnerRect), new Rectangle(1, 1, Width - 3, Height - 3));
                        G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(83, 93, 103))), 1, Height - 2, Width - 2, Height - 2);
                        //G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(200, 210, 220)), new Rectangle(0, -1, Width - 1, Height - 1), new StringFormat
                        //{
                        //    LineAlignment = StringAlignment.Center,
                        //    Alignment = StringAlignment.Center
                        //});
                    }
                    break;
                case MouseState.Down:
                    if (sharpColor2)
                    {
                        G.Clear(Color.FromArgb(37, 47, 57));
                        LinearGradientBrush BTNLGBOver = new LinearGradientBrush(new Rectangle(2, 1, Width - 3, Height / 2 - 2), Color.FromArgb(35, 45, 55), Color.FromArgb(132, 141, 147), 180);
                        G.FillRectangle(BTNLGBOver, new Rectangle(2, 1, Width - 3, Height / 2 - 2));
                        LinearGradientBrush BTNLGB1 = new LinearGradientBrush(new Rectangle(0, 1, Width - 2, Height / 2 - 2), Color.FromArgb(132, 141, 147), Color.FromArgb(35, 45, 55), 180);
                        G.FillRectangle(BTNLGB1, new Rectangle(0, 1, Width / 2, Height / 2 - 2));

                        
                        //----- Borders -----
                        G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(33, 43, 53))), new Rectangle(0, 0, Width - 1, Height - 1));
                        LinearGradientBrush InnerRect = new LinearGradientBrush(new Rectangle(1, 1, Width - 3, Height - 2), Color.FromArgb(93, 103, 113), Color.FromArgb(45, 45, 45), 90);
                        G.DrawRectangle(new Pen(InnerRect), new Rectangle(1, 1, Width - 3, Height - 3));
                        G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(53, 63, 73))), 1, Height - 2, Width - 2, Height - 2);
                        //G.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(1, -1, Width - 1, Height), new StringFormat
                        //{
                        //    LineAlignment = StringAlignment.Center,
                        //    Alignment = StringAlignment.Center
                        //});
                    }
                    else
                    {
                        G.Clear(Color.FromArgb(43, 53, 63));
                        LinearGradientBrush BTNLGBOver = new LinearGradientBrush(new Rectangle(2, 1, Width - 3, Height / 2 - 2), Color.FromArgb(27, 37, 47), Color.FromArgb(130, 139, 145), LinearGradientMode.Horizontal);
                        G.FillRectangle(BTNLGBOver, new Rectangle(2, 1, Width - 3, Height / 2 - 2));
                        LinearGradientBrush BTNLGB1 = new LinearGradientBrush(new Rectangle(0, 1, Width - 2, Height / 2 - 2), Color.FromArgb(130, 139, 145), Color.FromArgb(27, 37, 47), LinearGradientMode.Horizontal);
                        G.FillRectangle(BTNLGB1, new Rectangle(0, 1, Width / 2, Height / 2 - 2));

                        
                        //----- Borders -----
                        G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(33, 43, 53))), new Rectangle(0, 0, Width - 1, Height - 1));
                        LinearGradientBrush InnerRect = new LinearGradientBrush(new Rectangle(1, 1, Width - 3, Height - 2), Color.FromArgb(123, 133, 143), Color.FromArgb(55, 55, 55), 90);
                        G.DrawRectangle(new Pen(InnerRect), new Rectangle(1, 1, Width - 3, Height - 3));
                        G.DrawLine(new Pen(new SolidBrush(Color.FromArgb(73, 83, 93))), 2, Height - 2, Width - 2, Height - 2);
                        //G.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(1, -1, Width - 1, Height), new StringFormat
                        //{
                        //    LineAlignment = StringAlignment.Center,
                        //    Alignment = StringAlignment.Center
                        //});
                    }
                    break;
            }

            e.Graphics.DrawImage(B, 0, 0);
            //G.Dispose();
            //B.Dispose();

        }

    }

}

