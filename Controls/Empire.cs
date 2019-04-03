// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Empire.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        #region "CreateRound"
        private GraphicsPath CreateRoundPath;

        private Rectangle CreateRoundRectangle;

        

        public GraphicsPath CreateRound(int x, int y, int width, int height, int slope)
        {
            CreateRoundRectangle = new Rectangle(x, y, width, height);
            return CreateRound(CreateRoundRectangle, slope);
        }

        public GraphicsPath CreateRound(Rectangle r, int slope)
        {
            CreateRoundPath = new GraphicsPath(FillMode.Winding);
            CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180f, 90f);
            CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270f, 90f);
            CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0f, 90f);
            CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90f, 90f);
            CreateRoundPath.CloseFigure();
            return CreateRoundPath;
        }
        #endregion



        public enum EmpireButtonStyles
        {
            Header,
            Normal
        };

        private EmpireButtonStyles empireButtonStyle = EmpireButtonStyles.Normal;


        Color EmpirePurple = Color.FromArgb(55, 173, 242);

        [Browsable(false)]
        public EmpireButtonStyles EmpireButtonStyle
        {
            get { return empireButtonStyle; }
            set { empireButtonStyle = value;
                Invalidate();
            }
        }

        private void EmpireHeaderButtonPaint()
        {
            G.Clear(Parent.BackColor);

            LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(0, 0, Width, 37), Color.FromArgb(36, 36, 36), Color.FromArgb(25, 25, 25), 90f);
            G.FillRectangle(LGB, LGB.Rectangle);
            LGB = new LinearGradientBrush(new Rectangle(0, 37, Width, 8), Color.FromArgb(80, Color.Black), Color.Transparent, 90f);
            G.FillRectangle(LGB, LGB.Rectangle);
            G.FillRectangle(new SolidBrush(EmpirePurple), new Rectangle(0, 35, Width, 2));

            LGB = new LinearGradientBrush(new Rectangle(1, 5, 1, 30), Color.FromArgb(180, EmpirePurple), Color.Transparent, -90f);
            G.FillRectangle(LGB, LGB.Rectangle);
            G.FillRectangle(LGB, new Rectangle(Width - 2, 5, 1, 30));

            LGB = new LinearGradientBrush(new Rectangle(0, 5, 1, 30), Color.FromArgb(180, Color.Black), Color.Transparent, -90f);
            G.FillRectangle(LGB, LGB.Rectangle);
            G.FillRectangle(LGB, new Rectangle(Width - 1, 5, 1, 30));

            switch (State)
            {
                case MouseState.Over:
                    LGB = new LinearGradientBrush(new Rectangle(2, 15, Width - 5, 20), Color.Transparent, Color.FromArgb(15, Color.White), 90f);
                    G.FillRectangle(LGB, LGB.Rectangle);
                    break;
                case MouseState.Down:
                    LGB = new LinearGradientBrush(new Rectangle(2, 13, Width - 5, 22), Color.Transparent, Color.FromArgb(7, Color.White), 90f);
                    G.FillRectangle(LGB, LGB.Rectangle);
                    break;
            }

            //G.DrawString(Text, Font, Brushes.White, new Rectangle(3, 9, Width - 7, Height - 14), new StringFormat
            //{
            //    Alignment = StringAlignment.Center,
            //    LineAlignment = StringAlignment.Center,
            //    Trimming = StringTrimming.EllipsisCharacter
            //});
            
        }

        private void EmpireButtonPaint()
        {
            G.SmoothingMode = Smoothing;
            G.Clear(Parent.BackColor);

            Brush LGB = default(Brush);

            switch (State)
            {
                case MouseState.None:
                    LGB = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(36, 36, 36), Color.FromArgb(25, 25, 25), 90f);
                    break;
                case MouseState.Over:
                    LGB = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(42, 42, 42), Color.FromArgb(25, 25, 25), 90f);
                    break;
                default:
                    LGB = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(36, 36, 36), Color.FromArgb(18, 18, 18), 90f);
                    break;
            }
            if (!Enabled)
            {
                LGB = new SolidBrush(Color.FromArgb(55, 55, 55));
            }
            G.FillPath(LGB, CreateRound(0, 0, Width - 1, Height - 1, 6));

            //if ((_Image == null))
            //{
            //    //G.DrawString(Text, Font, Brushes.White, new Rectangle(3, 2, Width - 7, Height - 5), new StringFormat
            //    //{
            //    //    Alignment = StringAlignment.Center,
            //    //    LineAlignment = StringAlignment.Center,
            //    //    Trimming = StringTrimming.EllipsisCharacter
            //    //});
            //}
            //else
            //{
            //    G.InterpolationMode = InterpolationMode.HighQualityBicubic;

            //    switch (ImageAlign)
            //    {
            //        case ContentAlignment.MiddleLeft:
            //            Rectangle ImageRect = new Rectangle(9, 6, Height - 13, Height - 13);
            //            G.DrawImage(_Image, ImageRect);
            //            //G.DrawString(Text, Font, Brushes.White, new Rectangle(ImageRect.X + ImageRect.Width + 6, 2, Width - ImageRect.Width - 22, Height - 5), new StringFormat
            //            //{
            //            //    Alignment = StringAlignment.Center,
            //            //    LineAlignment = StringAlignment.Center,
            //            //    Trimming = StringTrimming.EllipsisCharacter
            //            //});
            //            break;
            //        case ContentAlignment.MiddleCenter:
            //            Rectangle ImageRect1 = new Rectangle(((Width - 1) / 2) - (Height - 13) / 2, 6, Height - 13, Height - 13);
            //            G.DrawImage(_Image, ImageRect1);
            //            break;
            //        case ContentAlignment.MiddleRight:
            //            Rectangle ImageRect2 = new Rectangle(Width - Height + 3, 6, Height - 13, Height - 13);
            //            G.DrawImage(_Image, ImageRect2);
            //            //G.DrawString(Text, Font, Brushes.White, new Rectangle(3, 2, Width - ImageRect2.Width - 22, Height - 5), new StringFormat
            //            //{
            //            //    Alignment = StringAlignment.Center,
            //            //    LineAlignment = StringAlignment.Center,
            //            //    Trimming = StringTrimming.EllipsisCharacter
            //            //});
            //            break;
            //    }

            //}

            
        }

        private void EmpirePaint()
        {
            switch (EmpireButtonStyle)
            {
                case EmpireButtonStyles.Header:
                    EmpireHeaderButtonPaint();
                    break;
                case EmpireButtonStyles.Normal:
                    EmpireButtonPaint();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

    }

}

