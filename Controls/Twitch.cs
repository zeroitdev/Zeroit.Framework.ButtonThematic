// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Twitch.cs" company="Zeroit Dev Technologies">
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
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        private bool twitchRounding = true;


        [Browsable(false)]
        public bool TwitchRounding
        {
            get { return twitchRounding;}
            set
            {
                twitchRounding = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public TwitchStyles TwitchStyle
        {
            get { return twitchStyle; }
            set { twitchStyle = value;
                Invalidate();
            }
        }

        public enum TwitchStyles
        {
            Default,
            Purple,
            White
        }

        private TwitchStyles twitchStyle = TwitchStyles.Default;



        private void TwitchPaintHook()
        {
            G.Clear(BackColor);
            switch (TwitchStyle)
            {
                case TwitchStyles.Purple:
                    switch (State)
                    {
                        case MouseState.Down:
                            if (TwitchRounding == true)
                            {
                                DrawGradient(Color.FromArgb(80, 56, 129), Color.FromArgb(58, 37, 103), new Rectangle(0, 0, Width, Height), 90f);
                                G.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));
                                //DrawText(new SolidBrush(Color.White), HorizontalAlignment.Center, 0, 0);
                            }
                            else
                            {
                                LinearGradientBrush BackGrad = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(80, 56, 129), Color.FromArgb(58, 37, 103), 90);
                                G.FillPath(BackGrad, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), 4));
                                G.DrawPath(Pens.Black, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), 4));
                                //Really easy to use. Instead of DrawRectangle, use DrawPath. Then instead of a rectangle, use my Draw function.
                                //The curve should be somewhere along the lines of 3-7
                            }
                            //DrawText(new SolidBrush(Color.White), HorizontalAlignment.Center, 0, 0);
                            break;
                        default:
                            if (TwitchRounding == true)
                            {
                                DrawGradient(Color.FromArgb(124, 96, 176), Color.FromArgb(87, 59, 139), new Rectangle(0, 0, Width, Height), 90f);
                                G.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));
                                //DrawText(new SolidBrush(Color.White), HorizontalAlignment.Center, 0, 0);
                            }
                            else
                            {
                                LinearGradientBrush BackGrad = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(124, 96, 176), Color.FromArgb(87, 59, 139), 90);
                                G.FillPath(BackGrad, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), 4));
                                G.DrawPath(Pens.Black, Draw.RoundRect(new Rectangle(0, 0, Width - 1, Height - 1), 4));
                                //DrawText(new SolidBrush(Color.White), HorizontalAlignment.Center, 0, 0);
                            }
                            break;
                    }
                    break;
                case TwitchStyles.White:
                    switch (State)
                    {
                        case MouseState.None:
                            DrawGradient(Color.FromArgb(242, 242, 242), Color.FromArgb(225, 225, 225), new Rectangle(0, 0, Width, Height), 90f);
                            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(158, 158, 158))), new Rectangle(0, 0, Width - 1, Height - 1));
                            //DrawText(new SolidBrush(Color.FromArgb(124, 124, 124)), HorizontalAlignment.Center, 0, 0);
                            break;
                        case MouseState.Down:
                            DrawGradient(Color.FromArgb(213, 213, 213), Color.FromArgb(188, 188, 188), new Rectangle(0, 0, Width, Height), 90f);
                            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(121, 121, 121))), new Rectangle(0, 0, Width - 1, Height - 1));
                            //DrawText(new SolidBrush(Color.FromArgb(124, 124, 124)), HorizontalAlignment.Center, 0, 0);
                            break;
                        case MouseState.Over:
                            DrawGradient(Color.FromArgb(242, 242, 242), Color.FromArgb(223, 223, 223), new Rectangle(0, 0, Width, Height), 90f);
                            G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(158, 158, 158))), new Rectangle(0, 0, Width - 1, Height - 1));
                            //DrawText(new SolidBrush(Color.FromArgb(124, 124, 124)), HorizontalAlignment.Center, 0, 0);
                            break;
                    }
                    break;
                default:
                    switch (State)
                    {
                        case MouseState.Down:
                            DrawGradient(Color.FromArgb(80, 56, 129), Color.FromArgb(58, 37, 103), new Rectangle(0, 0, Width, Height), 90f);
                            G.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));
                            //DrawText(new SolidBrush(Color.White), HorizontalAlignment.Center, 0, 0);
                            break;
                        default:
                            DrawGradient(Color.FromArgb(124, 96, 176), Color.FromArgb(87, 59, 139), new Rectangle(0, 0, Width, Height), 90f);
                            G.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));
                            //DrawText(new SolidBrush(Color.White), HorizontalAlignment.Center, 0, 0);
                            break;
                    }
                    break;
            }
        }

    }

}

