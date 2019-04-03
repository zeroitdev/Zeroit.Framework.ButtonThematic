// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="BlueAndWhiteButton.cs" company="Zeroit Dev Technologies">
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
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {
        
        #region " Declarations "
        private int BaWState;
        private GraphicsPath BaWShape;
        private LinearGradientBrush BaWInactiveGB;
        private LinearGradientBrush BaWActiveGB;
        private LinearGradientBrush BaWActiveContourGB;
        private LinearGradientBrush BaWPressedGB;
        private LinearGradientBrush BaWPressedContourGB;
        private Rectangle BaWR1;
        private Rectangle BaWR2;
        private Pen BaWP1 = new Pen(Color.FromArgb(185, 185, 185));
        private Pen BaWP2;
        private Pen BaWP3;
        private Pen BaWP4 = new Pen(Color.FromArgb(135, 182, 233));
        private SolidBrush BaWB1 = new SolidBrush(Color.FromArgb(114, 114, 114));
        private SolidBrush BaWB2 = new SolidBrush(Color.FromArgb(246, 247, 250));
        private SolidBrush BaWB3 = new SolidBrush(Color.FromArgb(25, 55, 82));
        private StringFormat BaWCSF = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
            
        };
        #endregion
        
        private void BaWOnMouseDown(MouseEventArgs e)
        {
            BaWState = 2;
            Invalidate();

            base.OnMouseDown(e);
        }

        private void BaWOnMouseEnter(EventArgs e)
        {
            BaWState = 1;
            Invalidate();

            base.OnMouseEnter(e);
        }

        private void BaWOnMouseLeave(EventArgs e)
        {
            BaWState = 0;
            Invalidate();

            base.OnMouseLeave(e);
        }

        private void BaWOnMouseUp(MouseEventArgs e)
        {
            BaWState = 1;
            Invalidate();

            base.OnMouseUp(e);
        }

        
        private void BaWOnResize(System.EventArgs e)
        {
            //if (Width > 0 && Height > 0)
            //{
            //    BaWShape = new GraphicsPath();

            //    BaWR1 = new Rectangle(0, 0, Width, Height);
            //    BaWR2 = new Rectangle(0, 1, Width, Height);

            //    BaWInactiveGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(249, 249, 249), Color.FromArgb(222, 222, 222), 90);
            //    BaWActiveGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(171, 210, 244), Color.FromArgb(84, 153, 228), 90);
            //    BaWActiveContourGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(121, 180, 235), Color.FromArgb(70, 137, 201), 90);
            //    BaWPressedGB = new LinearGradientBrush(new Rectangle(0, 1, Width, Height), Color.FromArgb(97, 162, 228), Color.FromArgb(114, 173, 233), 90);
            //    BaWPressedContourGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(74, 141, 208), Color.FromArgb(114, 173, 230), 90);

            //    BaWP2 = new Pen(BaWActiveContourGB);
            //    BaWP3 = new Pen(BaWPressedContourGB);

            //    var _with1 = BaWShape;
            //    _with1.AddArc(0, 0, 10, 10, 180, 90);
            //    _with1.AddArc(Width - 11, 0, 10, 10, -90, 90);
            //    _with1.AddArc(Width - 11, Height - 11, 10, 10, 0, 90);
            //    _with1.AddArc(0, Height - 11, 10, 10, 90, 90);
            //    _with1.CloseAllFigures();
            //}

            Invalidate();
            base.OnResize(e);
        }

        private void BaWOnPaint(PaintEventArgs e)
        {
            
            G.Clear(Parent.BackColor);

            BaWShape = new GraphicsPath();

            BaWR1 = new Rectangle(0, 0, Width, Height);
            BaWR2 = new Rectangle(0, 1, Width, Height);

            BaWInactiveGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(249, 249, 249), Color.FromArgb(222, 222, 222), 90);
            BaWActiveGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(171, 210, 244), Color.FromArgb(84, 153, 228), 90);
            BaWActiveContourGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(121, 180, 235), Color.FromArgb(70, 137, 201), 90);
            BaWPressedGB = new LinearGradientBrush(new Rectangle(0, 1, Width, Height), Color.FromArgb(97, 162, 228), Color.FromArgb(114, 173, 233), 90);
            BaWPressedContourGB = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Color.FromArgb(74, 141, 208), Color.FromArgb(114, 173, 230), 90);

            BaWP2 = new Pen(BaWActiveContourGB);
            BaWP3 = new Pen(BaWPressedContourGB);

            var _with1 = BaWShape;
            _with1.AddArc(0, 0, 10, 10, 180, 90);
            _with1.AddArc(Width - 11, 0, 10, 10, -90, 90);
            _with1.AddArc(Width - 11, Height - 11, 10, 10, 0, 90);
            _with1.AddArc(0, Height - 11, 10, 10, 90, 90);
            _with1.CloseAllFigures();

            switch (BaWState)
            {
                case 0:
                    //Inactive
                    G.FillPath(BaWInactiveGB, BaWShape);
                    G.DrawPath(BaWP1, BaWShape);
                    //G.DrawString(Text, Font, BaWB1, BaWR1, BaWCSF);
                    break;
                case 1:
                    //Active
                    G.FillPath(BaWActiveGB, BaWShape);
                    G.DrawPath(BaWP2, BaWShape);
                    //G.DrawString(Text, Font, Brushes.DarkSlateGray, BaWR2, BaWCSF);
                    //G.DrawString(Text, Font, BaWB2, BaWR1, BaWCSF);
                    break;
                case 2:
                    //Pressed
                    G.FillPath(BaWPressedGB, BaWShape);
                    G.DrawPath(BaWP3, BaWShape);
                    G.DrawLine(BaWP4, 1, 1, Width - 2, 1);
                    //G.DrawString(Text, Font, Brushes.White, BaWR2, BaWCSF);
                    //G.DrawString(Text, Font, BaWB3, BaWR1, BaWCSF);
                    break;
            }
            
        }


    }


}
