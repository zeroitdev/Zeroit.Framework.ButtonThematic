// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="NeoBux.cs" company="Zeroit Dev Technologies">
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
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {
        public enum NeoBuxStyles
        {
            Blue,
            Orange,
            Purple,
            Gray
        };

        private NeoBuxStyles neoBuxStyle = NeoBuxStyles.Blue;

        Color clsBorder = Color.DarkGray;

        [Browsable(false)]
        public NeoBuxStyles NeoBuxStyle
        {
            get { return neoBuxStyle; }
            set { neoBuxStyle = value;
                Invalidate();
            }
        }

        private void NeoBuxPaintBlueHook()
        {
            DrawCorners(Color.Fuchsia);
            G.Clear(Parent.BackColor);
            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush LGB1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(23, 167, 237), Color.FromArgb(1, 145, 215), 90f);

                    G.FillPath(LGB1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(0, 116, 172)), CreateRound(0, 0, Width - 1, Height - 1, 5));

                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;

                case MouseState.Over:
                    LinearGradientBrush LGBO1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(49, 178, 241), Color.FromArgb(26, 169, 239), 90f);

                    G.FillPath(LGBO1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(0, 116, 172)), CreateRound(0, 0, Width - 1, Height - 1, 5));

                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;
                case MouseState.Down:
                    LinearGradientBrush LGBD1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(49, 178, 241), Color.FromArgb(26, 169, 239), 90f);

                    G.FillPath(LGBD1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(0, 116, 172)), CreateRound(0, 0, Width - 1, Height - 1, 5));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 1);
                    break;
            }
        }

        private void NeoBuxPaintOrangeHook()
        {
            DrawCorners(Color.Fuchsia);
            G.Clear(Parent.BackColor);
            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush LGB1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(253, 163, 23), Color.FromArgb(231, 141, 1), 90f);

                    //G.SmoothingMode = SmoothingMode.HighQuality;
                    G.FillPath(LGB1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(184, 112, 0)), CreateRound(0, 0, Width - 1, Height - 1, 5));

                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;

                case MouseState.Over:
                    LinearGradientBrush LGBO1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(255, 175, 49), Color.FromArgb(255, 166, 26), 90f);

                    //G.SmoothingMode = SmoothingMode.HighQuality;
                    G.FillPath(LGBO1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(184, 112, 0)), CreateRound(0, 0, Width - 1, Height - 1, 5));

                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;
                case MouseState.Down:
                    LinearGradientBrush LGBD1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(255, 175, 49), Color.FromArgb(255, 166, 26), 90f);

                    //G.SmoothingMode = SmoothingMode.HighQuality;
                    G.FillPath(LGBD1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(184, 112, 0)), CreateRound(0, 0, Width - 1, Height - 1, 5));


                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 1);
                    break;
            }
        }
    
        private void NeoBuxPaintPurpleHook()
        {
            DrawCorners(Color.Fuchsia);
            G.Clear(Parent.BackColor);
            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush LGB1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(229, 43, 245), Color.FromArgb(207, 21, 223), 90f);

                    //G.SmoothingMode = SmoothingMode.HighQuality;
                    G.FillPath(LGB1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(165, 16, 178)), CreateRound(0, 0, Width - 1, Height - 1, 5));

                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;

                case MouseState.Over:
                    LinearGradientBrush LGBO1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(234, 67, 248), Color.FromArgb(231, 46, 247), 90f);

                    //G.SmoothingMode = SmoothingMode.HighQuality;
                    G.FillPath(LGBO1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(165, 16, 178)), CreateRound(0, 0, Width - 1, Height - 1, 5));


                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;
                case MouseState.Down:
                    LinearGradientBrush LGBD1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(234, 67, 248), Color.FromArgb(231, 46, 247), 90f);

                    //G.SmoothingMode = SmoothingMode.HighQuality;
                    G.FillPath(LGBD1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(165, 16, 178)), CreateRound(0, 0, Width - 1, Height - 1, 5));

                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 1);
                    break;
            }
        }

        private void NeoBuxPaintGrayHook()
        {
            DrawCorners(Color.Fuchsia);
            G.Clear(Parent.BackColor);
            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush LGB1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(161, 161, 161), Color.FromArgb(139, 139, 139), 90f);

                    //G.SmoothingMode = SmoothingMode.HighQuality;
                    G.FillPath(LGB1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(111, 111, 111)), CreateRound(0, 0, Width - 1, Height - 1, 5));

                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;

                case MouseState.Over:
                    LinearGradientBrush LGBO1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(172, 172, 172), Color.FromArgb(163, 163, 163), 90f);

                    //G.SmoothingMode = SmoothingMode.HighQuality;
                    G.FillPath(LGBO1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(111, 111, 111)), CreateRound(0, 0, Width - 1, Height - 1, 5));

                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;
                case MouseState.Down:
                    LinearGradientBrush LGBD1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(172, 172, 172), Color.FromArgb(163, 163, 163), 90f);

                    //G.SmoothingMode = SmoothingMode.HighQuality;
                    G.FillPath(LGBD1, CreateRound(0, 1, Width - 1, Height - 2, 3));
                    G.DrawPath(new Pen(Color.FromArgb(111, 111, 111)), CreateRound(0, 0, Width - 1, Height - 1, 5));

                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 1);
                    break;
            }
        }

        private void NeoBuxPaint()
        {
            switch (NeoBuxStyle)
            {
                case NeoBuxStyles.Blue:
                    NeoBuxPaintBlueHook();
                    break;
                case NeoBuxStyles.Orange:
                    NeoBuxPaintOrangeHook();
                    break;
                case NeoBuxStyles.Purple:
                    NeoBuxPaintPurpleHook();
                    break;
                case NeoBuxStyles.Gray:
                    NeoBuxPaintGrayHook();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }


    }

}

