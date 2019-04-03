// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="06. CustomBitDefender.cs" company="Zeroit Dev Technologies">
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
using System.Threading;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        #region Private Fields

        //private Color customBitDefenderC1 = Color.FromArgb(100, 41, 41, 41);
        //private Color customBitDefenderC2 = Color.White;
        //private Color customBitDefenderC3 = Color.FromArgb(101, 101, 101);
        //private Color customBitDefenderC4 = Color.FromArgb(60, 60, 60);
        //private Color customBitDefenderC5 = Color.FromArgb(28, 28, 28);
        //private Color customBitDefenderC6 = Color.FromArgb(45, 45, 45);
        //private Color customBitDefenderBorder = Color.Black;
        private Rectangle customBitDefenderR1;
        private Rectangle customBitDefenderR2;
        private Rectangle customBitDefenderR3;
        private GraphicsPath customBitDefenderGP1;
        private GraphicsPath customBitDefenderGP2;
        private GraphicsPath customBitDefenderGP3;
        private SolidBrush customBitDefenderB1;
        private SolidBrush customBitDefenderB2;
        private Pen customBitDefenderP1;
        private Pen customBitDefenderP2;
        private LinearGradientBrush customBitDefenderLGB1;
        private LinearGradientBrush customBitDefenderLGB2;

        //private int curve = 11;
        //private Color customBitDefenderFadeColor = Color.White;
        private bool customBitDefDown;

        private Thread customOpenT;


        #endregion

        #region Public Properties
        [Browsable(false)]
        private bool CustomBitDefDown
        {
            get { return customBitDefDown; }
            set
            {
                customBitDefDown = value;
                Invalidate();
            }
        }

        //public int Curve
        //{
        //    get { return Curve; }
        //    set
        //    {
        //        Curve = value;
        //        Invalidate();
        //    }
        //}

        [Browsable(false)]
        public Color CustomBitDefenderC1
        {
            get { return buttonInput.CustomBitDefenderC1; }
            set { buttonInput.CustomBitDefenderC1 = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomBitDefenderC2
        {
            get { return buttonInput.CustomBitDefenderC2; }
            set { buttonInput.CustomBitDefenderC2 = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomBitDefenderC3
        {
            get { return buttonInput.CustomBitDefenderC3; }
            set { buttonInput.CustomBitDefenderC3 = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomBitDefenderC4
        {
            get { return buttonInput.CustomBitDefenderC4; }
            set { buttonInput.CustomBitDefenderC4 = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomBitDefenderC5
        {
            get { return buttonInput.CustomBitDefenderC5; }
            set { buttonInput.CustomBitDefenderC5 = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomBitDefenderC6
        {
            get { return buttonInput.CustomBitDefenderC6; }
            set { buttonInput.CustomBitDefenderC6 = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomBitDefenderBorder
        {
            get { return buttonInput.CustomBitDefenderBorder; }
            set { buttonInput.CustomBitDefenderBorder = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color CustomBitDefenderFadeColor
        {
            get { return buttonInput.CustomBitDefenderFadeColor; }
            set
            {
                buttonInput.CustomBitDefenderFadeColor = value;
                Invalidate();
            }
        }

        #endregion

        #region Mouse Events and Animation

        private void CustomBitDefenderOnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            customOpenT = new Thread(CustomEnterAnimation);
            if (!customOpenT.IsAlive)
            {
                customOpenT.IsBackground = true;
                customOpenT.Start();
            }
        }

        private void CustomBitDefenderOnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            CustomBitDefDown = true;
        }

        private void CustomBitDefenderOnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            CustomBitDefDown = false;
        }
        
        private void CustomEnterAnimation()
        {
            Graphics G = this.CreateGraphics();
            customBitDefenderR2 = new Rectangle(5, 5, Width - 10, Height - 10);
            customBitDefenderGP2 = Helper.RoundRect(customBitDefenderR2, Curve);
            G.SetClip(customBitDefenderGP2);
            for (int fade = 0; fade <= 5; fade += Convert.ToInt32(0.85f))
            {
                Thread.Sleep(50);
                G.FillRectangle(new SolidBrush(Color.FromArgb(fade, CustomBitDefenderFadeColor)), ClientRectangle);
            }
        }

        #endregion
        
        #region Paint
        
        private void CustomInit()
        {

            customBitDefenderR1 = new Rectangle(3, 3, Width - 6, Height - 6);
            customBitDefenderR2 = new Rectangle(5, 5, Width - 10, Height - 10);
            customBitDefenderR3 = new Rectangle(6, 6, Width - 12, Height - 12);

            customBitDefenderGP1 = Helper.RoundRect(customBitDefenderR1, Curve);
            customBitDefenderGP2 = Helper.RoundRect(customBitDefenderR2, Curve);
            customBitDefenderGP3 = Helper.RoundRect(customBitDefenderR3, Curve);

            customBitDefenderB1 = new SolidBrush(CustomBitDefenderC1);
            customBitDefenderB2 = new SolidBrush(CustomBitDefenderC2);
            customBitDefenderLGB1 = new LinearGradientBrush(customBitDefenderR2, CustomBitDefenderC4, CustomBitDefenderC5, LinearGradientMode.Vertical);
            customBitDefenderLGB2 = new LinearGradientBrush(customBitDefenderR3, CustomBitDefenderC3, CustomBitDefenderC6, LinearGradientMode.Vertical);

            customBitDefenderP1 = new Pen(CustomBitDefenderBorder);
            customBitDefenderP2 = new Pen(customBitDefenderLGB2);

        }
        
        private void CustomBitDefenderPaint(PaintEventArgs e)
        {
            G.Clear(Parent.BackColor);
            CustomInit();
            G.FillPath(customBitDefenderB1, customBitDefenderGP1);
            G.FillPath(customBitDefenderLGB1, customBitDefenderGP2);
            G.DrawPath(customBitDefenderP1, customBitDefenderGP2);
            G.DrawPath(customBitDefenderP2, customBitDefenderGP3);
            if (!CustomBitDefDown)
            {
                //G.DrawString(Text, Font, customBitDefenderB2, customBitDefenderR3, BitDefenderSF1);
            }
            else
            {
                customBitDefenderR3.X += 1;
                customBitDefenderR3.Y += 1;
                //G.DrawString(Text, Font, customBitDefenderB2, customBitDefenderR3, BitDefenderSF1);
            }


        }
        
        #endregion
        

    }

}
