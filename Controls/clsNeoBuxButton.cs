// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="clsNeoBuxButton.cs" company="Zeroit Dev Technologies">
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
        public enum ClsStyles
        {
            Green,
            Blue,
            Orange,
            Purple,
            Grey
        }

        private ClsStyles classicStyles = ClsStyles.Blue;

        Color classicBorder = Color.DarkGray;

        [Browsable(false)]
        public ClsStyles ClsStyle
        {
            get { return classicStyles; }
            set { classicStyles = value;
                Invalidate();
            }
        }


        private void ClsGreenPaintHook()
        {
            DrawCorners(Color.Fuchsia);
            G.Clear(BackColor);
            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush LGB1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(23, 178, 23), Color.FromArgb(1, 156, 1), 90f);

                    G.SmoothingMode = SmoothingMode.HighQuality;
                    G.FillPath(LGB1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(0, 124, 0)), CreateRound(0, 0, Width - 1, Height - 1, 5));

                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;

                case MouseState.Over:
                    LinearGradientBrush LGBO1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(49, 188, 49), Color.FromArgb(26, 180, 26), 90f);

                    G.SmoothingMode = SmoothingMode.HighQuality;
                    G.FillPath(LGBO1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(0, 124, 0)), CreateRound(0, 0, Width - 1, Height - 1, 5));

                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;
                case MouseState.Down:
                    LinearGradientBrush LGBD1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(49, 188, 49), Color.FromArgb(26, 180, 26), 90f);

                    G.SmoothingMode = SmoothingMode.HighQuality;
                    G.FillPath(LGBD1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(0, 124, 0)), CreateRound(0, 0, Width - 1, Height - 1, 5));

                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 1);
                    break;
            }
        }
    

        private void ClsBluePaintHook()
        {
            DrawCorners(Color.Fuchsia);
            G.Clear(BackColor);
            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush LGB1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(23, 167, 237), Color.FromArgb(1, 145, 215), 90f);

                    G.SmoothingMode = SmoothingMode.HighQuality;
                    G.FillPath(LGB1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(0, 116, 172)), CreateRound(0, 0, Width - 1, Height - 1, 5));

                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;

                case MouseState.Over:
                    LinearGradientBrush LGBO1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(49, 178, 241), Color.FromArgb(26, 169, 239), 90f);

                    G.SmoothingMode = SmoothingMode.HighQuality;
                    G.FillPath(LGBO1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(0, 116, 172)), CreateRound(0, 0, Width - 1, Height - 1, 5));

                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;
                case MouseState.Down:
                    LinearGradientBrush LGBD1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(49, 178, 241), Color.FromArgb(26, 169, 239), 90f);

                    G.SmoothingMode = SmoothingMode.HighQuality;
                    G.FillPath(LGBD1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(0, 116, 172)), CreateRound(0, 0, Width - 1, Height - 1, 5));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 1);
                    break;
            }
        }
    
        private void ClsOrangePaintHook()
        {
            DrawCorners(Color.Fuchsia);
            G.Clear(BackColor);
            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush LGB1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(253, 163, 23), Color.FromArgb(231, 141, 1), 90f);

                    G.SmoothingMode = SmoothingMode.HighQuality;
                    G.FillPath(LGB1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(184, 112, 0)), CreateRound(0, 0, Width - 1, Height - 1, 5));

                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;

                case MouseState.Over:
                    LinearGradientBrush LGBO1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(255, 175, 49), Color.FromArgb(255, 166, 26), 90f);

                    G.SmoothingMode = SmoothingMode.HighQuality;
                    G.FillPath(LGBO1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(184, 112, 0)), CreateRound(0, 0, Width - 1, Height - 1, 5));

                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;
                case MouseState.Down:
                    LinearGradientBrush LGBD1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(255, 175, 49), Color.FromArgb(255, 166, 26), 90f);

                    G.SmoothingMode = SmoothingMode.HighQuality;
                    G.FillPath(LGBD1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(184, 112, 0)), CreateRound(0, 0, Width - 1, Height - 1, 5));


                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 1);
                    break;
            }
        }
    
        private void ClsPurplePaintHook()
        {
            DrawCorners(Color.Fuchsia);
            G.Clear(BackColor);
            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush LGB1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(229, 43, 245), Color.FromArgb(207, 21, 223), 90f);

                    G.SmoothingMode = SmoothingMode.HighQuality;
                    G.FillPath(LGB1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(165, 16, 178)), CreateRound(0, 0, Width - 1, Height - 1, 5));

                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;

                case MouseState.Over:
                    LinearGradientBrush LGBO1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(234, 67, 248), Color.FromArgb(231, 46, 247), 90f);

                    G.SmoothingMode = SmoothingMode.HighQuality;
                    G.FillPath(LGBO1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(165, 16, 178)), CreateRound(0, 0, Width - 1, Height - 1, 5));


                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;
                case MouseState.Down:
                    LinearGradientBrush LGBD1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(234, 67, 248), Color.FromArgb(231, 46, 247), 90f);

                    G.SmoothingMode = SmoothingMode.HighQuality;
                    G.FillPath(LGBD1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(165, 16, 178)), CreateRound(0, 0, Width - 1, Height - 1, 5));

                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 1);
                    break;
            }
        }
    
        private void ClsGreyPaintHook()
        {
            DrawCorners(Color.Fuchsia);
            G.Clear(BackColor);
            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush LGB1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(161, 161, 161), Color.FromArgb(139, 139, 139), 90f);

                    G.SmoothingMode = SmoothingMode.HighQuality;
                    G.FillPath(LGB1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(111, 111, 111)), CreateRound(0, 0, Width - 1, Height - 1, 5));

                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;

                case MouseState.Over:
                    LinearGradientBrush LGBO1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(172, 172, 172), Color.FromArgb(163, 163, 163), 90f);

                    G.SmoothingMode = SmoothingMode.HighQuality;
                    G.FillPath(LGBO1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(111, 111, 111)), CreateRound(0, 0, Width - 1, Height - 1, 5));

                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;
                case MouseState.Down:
                    LinearGradientBrush LGBD1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(172, 172, 172), Color.FromArgb(163, 163, 163), 90f);

                    G.SmoothingMode = SmoothingMode.HighQuality;
                    G.FillPath(LGBD1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(111, 111, 111)), CreateRound(0, 0, Width - 1, Height - 1, 5));

                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 1);
                    break;
            }
        }

        private void ClsPaintHook()
        {
            switch (ClsStyle)
            {
                case ClsStyles.Green:
                    ClsGreenPaintHook();
                    break;
                case ClsStyles.Blue:
                    ClsBluePaintHook();
                    break;
                case ClsStyles.Orange:
                    ClsOrangePaintHook();
                    break;
                case ClsStyles.Purple:
                    ClsPurplePaintHook();
                    break;
                case ClsStyles.Grey:
                    ClsGreyPaintHook();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

    }

}

