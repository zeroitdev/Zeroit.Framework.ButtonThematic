// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Simpla.cs" company="Zeroit Dev Technologies">
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

        
        public enum SimplaColorSchemes
        {
            DarkGray,
            Green,
            Blue,
            White,
            Red
        }
        private SimplaColorSchemes simplaColorScheme;

        [Browsable(false)]
        public SimplaColorSchemes SimplaColorScheme
        {
            get { return simplaColorScheme; }
            set
            {
                simplaColorScheme = value;
                Invalidate();
            }
        }

        

        private void SimplaPaint(System.Windows.Forms.PaintEventArgs e)
        {
            B = new Bitmap(Width, Height);
            G = Graphics.FromImage(B);
            Rectangle ClientRectangle = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle InnerRectangle = new Rectangle(1, 1, Width - 3, Height - 3);

            G.Clear(BackColor);
            Font drawFont = new Font("Calibri (Body)", 10, FontStyle.Bold);

            switch (SimplaColorScheme)
            {
                case SimplaColorSchemes.DarkGray:
                    LinearGradientBrush gradientBackground = new LinearGradientBrush(ClientRectangle, Color.FromArgb(23, 23, 23), Color.FromArgb(17, 17, 17), 90);
                    G.FillPath(gradientBackground, Draw.RoundRect(ClientRectangle, 4));
                    Pen p = new Pen(new SolidBrush(Color.FromArgb(56, 56, 56)));
                    G.DrawPath(p, Draw.RoundRect(ClientRectangle, 4));

                    Pen p2 = new Pen(new SolidBrush(Color.FromArgb(5, 240, 240, 240)));
                    G.DrawPath(p2, Draw.RoundRect(InnerRectangle, 4));
                    break;
                case SimplaColorSchemes.Green:
                    LinearGradientBrush gradientBackground1 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(121, 185, 0), Color.FromArgb(94, 165, 1), 90);
                    G.FillPath(gradientBackground1, Draw.RoundRect(ClientRectangle, 4));

                    Pen p1 = new Pen(new SolidBrush(Color.FromArgb(159, 207, 1)));
                    G.DrawPath(p1, Draw.RoundRect(ClientRectangle, 4));

                    Pen p21 = new Pen(new SolidBrush(Color.FromArgb(30, 240, 240, 240)));
                    G.DrawPath(p21, Draw.RoundRect(InnerRectangle, 4));
                    break;
                case SimplaColorSchemes.Blue:
                    LinearGradientBrush gradientBackground2 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(0, 124, 186), Color.FromArgb(0, 97, 166), 90);
                    G.FillPath(gradientBackground2, Draw.RoundRect(ClientRectangle, 4));

                    Pen p22 = new Pen(new SolidBrush(Color.FromArgb(0, 161, 207)));
                    G.DrawPath(p22, Draw.RoundRect(ClientRectangle, 4));

                    Pen p220 = new Pen(new SolidBrush(Color.FromArgb(10, 240, 240, 240)));
                    G.DrawPath(p220, Draw.RoundRect(InnerRectangle, 4));
                    break;
                case SimplaColorSchemes.White:
                    LinearGradientBrush gradientBackground22 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(245, 245, 245), Color.FromArgb(246, 246, 246), 90);
                    G.FillPath(gradientBackground22, Draw.RoundRect(ClientRectangle, 4));

                    Pen p221 = new Pen(new SolidBrush(Color.FromArgb(254, 254, 254)));
                    G.DrawPath(p221, Draw.RoundRect(ClientRectangle, 4));

                    Pen p223 = new Pen(new SolidBrush(Color.FromArgb(10, 240, 240, 240)));
                    G.DrawPath(p223, Draw.RoundRect(InnerRectangle, 4));
                    break;
                case SimplaColorSchemes.Red:
                    LinearGradientBrush gradientBackground3 = new LinearGradientBrush(ClientRectangle, Color.FromArgb(185, 0, 0), Color.FromArgb(170, 0, 0), 90);
                    G.FillPath(gradientBackground3, Draw.RoundRect(ClientRectangle, 4));

                    Pen p3 = new Pen(new SolidBrush(Color.FromArgb(209, 1, 1)));
                    G.DrawPath(p3, Draw.RoundRect(ClientRectangle, 4));

                    Pen p23 = new Pen(new SolidBrush(Color.FromArgb(2, 240, 240, 240)));
                    G.DrawPath(p23, Draw.RoundRect(InnerRectangle, 4));
                    break;
                default:
                    break;
            }

            //switch (State)
            //{
            //    case MouseState.None:
            //        if (SimplaColorScheme == SimplaColorSchemes.White)
            //        {
            //            G.DrawString(Text, drawFont, new SolidBrush(Color.FromArgb(51, 51, 51)), new Rectangle(0, 1, Width - 1, Height - 1), new StringFormat
            //            {
            //                Alignment = StringAlignment.Center,
            //                LineAlignment = StringAlignment.Center
            //            });
            //        }
            //        else
            //        {
            //            LinearGradientBrush textGradient = new LinearGradientBrush(ClientRectangle, Color.FromArgb(235, 235, 235), Color.FromArgb(212, 212, 212), 90);
            //            G.DrawString(Text, drawFont, textGradient, new Rectangle(0, 1, Width - 1, Height - 1), new StringFormat
            //            {
            //                Alignment = StringAlignment.Center,
            //                LineAlignment = StringAlignment.Center
            //            });
            //        }
            //        break;
            //    case MouseState.Over:
            //        G.DrawString(Text, drawFont, new SolidBrush(Color.Silver), new Rectangle(0, 1, Width - 1, Height - 1), new StringFormat
            //        {
            //            Alignment = StringAlignment.Center,
            //            LineAlignment = StringAlignment.Center
            //        });
            //        break;
            //    case MouseState.Down:
            //        G.DrawString(Text, drawFont, new SolidBrush(Color.DimGray), new Rectangle(0, 1, Width - 1, Height - 1), new StringFormat
            //        {
            //            Alignment = StringAlignment.Center,
            //            LineAlignment = StringAlignment.Center
            //        });
            //        break;
            //}


            e.Graphics.DrawImage((Bitmap)B.Clone(), 0, 0);
            //G.Dispose();
            //B.Dispose();
        }

    }

}

