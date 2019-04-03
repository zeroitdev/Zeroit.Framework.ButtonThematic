// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Login.cs" company="Zeroit Dev Technologies">
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
        public enum LoginStyles
        {
            Button,
            ButtonWithProgress,
            Log

        }

       
        #region Declarations
        
        private readonly Font _Font = new Font("Segoe UI", 9);
        private Color _ProgressColour = Color.FromArgb(0, 191, 255);
        private Color _BorderColour = Color.FromArgb(25, 25, 25);
        private Color _FontColour = Color.FromArgb(255, 255, 255);
        private Color _MainColour = Color.FromArgb(42, 42, 42);
        private Color _HoverColour = Color.FromArgb(52, 52, 52);
        private Color _PressedColour = Color.FromArgb(47, 47, 47);
        private int _Value = 0;
        private int _Maximum = 100;
        private Color _ArcColour = Color.FromArgb(43, 43, 43);
        private Color _ArrowColour = Color.FromArgb(235, 233, 234);
        private Color _ArrowBorderColour = Color.FromArgb(170, 170, 170);
        private Color _NormalColour = Color.FromArgb(0, 160, 199);
        private LoginStyles loginstyle = LoginStyles.Button;
        #endregion

        #region Properties

        [Browsable(false)]
        [Category("Colours")]
        public Color ProgressColour
        {
            get { return _ProgressColour; }
            set { _ProgressColour = value; Invalidate(); }
        }

        [Browsable(false)]
        [Category("Colours")]
        public Color BorderColour
        {
            get { return _BorderColour; }
            set { _BorderColour = value; Invalidate(); }
        }

        [Browsable(false)]
        [Category("Colours")]
        public Color FontColour
        {
            get { return _FontColour; }
            set { _FontColour = value; Invalidate(); }
        }

        [Browsable(false)]
        [Category("Colours")]
        public Color BaseColour
        {
            get { return _MainColour; }
            set { _MainColour = value; Invalidate(); }
        }

        [Browsable(false)]
        [Category("Colours")]
        public Color HoverColour
        {
            get { return _HoverColour; }
            set { _HoverColour = value; Invalidate(); }
        }

        [Browsable(false)]
        [Category("Colours")]
        public Color PressedColour
        {
            get { return _PressedColour; }
            set { _PressedColour = value; Invalidate(); }
        }

        [Browsable(false)]
        [Category("Control")]
        public int LoginMaximum
        {
            get { return _Maximum; }
            set
            {

                if (value == _Value)
                {
                    _Value = value;
                }
                #region Old Code

                //			switch (value) {
                //				case  // ERROR: Case labels with binary operators are unsupported : LessThan
                //_Value:
                //					_Value = value;
                //					break;
                //			} 
                #endregion

                _Maximum = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        [Category("Control")]
        public int LoginValue
        {
            get
            {
                switch (_Value)
                {
                    case 0:

                        return 0;
                    default:

                        return _Value;
                }
            }
            set
            {
                if (value == _Maximum)
                {
                    value = _Maximum;
                    Invalidate();
                }

                #region Old Code
                //			switch (value) {
                //				case  // ERROR: Case labels with binary operators are unsupported : GreaterThan
                //_Maximum:
                //					value = _Maximum;
                //					Invalidate();
                //					break;
                //			} 
                #endregion

                _Value = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        [Category("Colours")]
        public Color ArcColour
        {
            get { return _ArcColour; }
            set { _ArcColour = value; Invalidate(); }
        }

        [Browsable(false)]
        [Category("Colours")]
        public Color ArrowColour
        {
            get { return _ArrowColour; }
            set { _ArrowColour = value; Invalidate(); }
        }

        [Browsable(false)]
        [Category("Colours")]
        public Color ArrowBorderColour
        {
            get { return _ArrowBorderColour; }
            set { _ArrowBorderColour = value; Invalidate(); }
        }

        [Browsable(false)]
        [Category("Colours")]
        public Color NormalColour
        {
            get { return _NormalColour; }
            set { _NormalColour = value; Invalidate(); }
        }

        [Browsable(false)]
        public LoginStyles Loginstyle
        {
            get { return loginstyle; }
            set
            {
                if (value == LoginStyles.Log)
                {
                    Size = new Size(50, 50);
                    Invalidate();
                }

                loginstyle = value;
                Invalidate();
            }
        }

        #endregion
        
        private void Increment(int Amount)
        {
            LoginValue += Amount;
        }
        
        private void LoginButtonPaint(PaintEventArgs e)
        {
            G.PixelOffsetMode = PixelOffsetMode.HighQuality;
            G.InterpolationMode = (InterpolationMode)7;

            G.Clear(Parent.BackColor);

            switch (State)
            {
                case MouseState.None:
                    G.FillRectangle(new SolidBrush(_MainColour), new Rectangle(0, 0, Width, Height));
                    G.DrawRectangle(new Pen(_BorderColour, 2), new Rectangle(0, 0, Width, Height));
                    //G.DrawString(Text, _Font, Brushes.White, new Point(Convert.ToInt32(Width / 2), Convert.ToInt32(Height / 2)), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Over:
                    G.FillRectangle(new SolidBrush(_HoverColour), new Rectangle(0, 0, Width, Height));
                    G.DrawRectangle(new Pen(_BorderColour, 1), new Rectangle(1, 1, Width - 2, Height - 2));
                    //G.DrawString(Text, _Font, Brushes.White, new Point(Convert.ToInt32(Width / 2), Convert.ToInt32(Height / 2)), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Down:
                    G.FillRectangle(new SolidBrush(_PressedColour), new Rectangle(0, 0, Width, Height));
                    G.DrawRectangle(new Pen(_BorderColour, 1), new Rectangle(1, 1, Width - 2, Height - 2));
                    //G.DrawString(Text, _Font, Brushes.White, new Point(Convert.ToInt32(Width / 2), Convert.ToInt32(Height / 2)), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
            }

        }
        
        private void LoginButtonWithProgressPaint(PaintEventArgs e)
        {
            G.PixelOffsetMode = PixelOffsetMode.HighQuality;
            G.Clear(BackColor);
            switch (State)
            {
                case MouseState.None:
                    G.FillRectangle(new SolidBrush(_MainColour), new Rectangle(0, 0, Width, Height - 4));
                    G.DrawRectangle(new Pen(_BorderColour, 2), new Rectangle(0, 0, Width, Height - 4));
                    //G.DrawString(Text, _Font, Brushes.White, new Point(Convert.ToInt32(Width / 2), Convert.ToInt32(Height / 2 - 2)), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Over:
                    G.FillRectangle(new SolidBrush(_HoverColour), new Rectangle(0, 0, Width, Height - 4));
                    G.DrawRectangle(new Pen(_BorderColour, 1), new Rectangle(1, 1, Width - 2, Height - 5));
                    //G.DrawString(Text, _Font, Brushes.White, new Point(Convert.ToInt32(Width / 2), Convert.ToInt32(Height / 2 - 2)), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
                case MouseState.Down:
                    G.FillRectangle(new SolidBrush(_PressedColour), new Rectangle(0, 0, Width, Height - 4));
                    G.DrawRectangle(new Pen(_BorderColour, 1), new Rectangle(1, 1, Width - 2, Height - 5));
                    //G.DrawString(Text, _Font, Brushes.White, new Point(Convert.ToInt32(Width / 2), Convert.ToInt32(Height / 2 - 2)), new StringFormat
                    //{
                    //    Alignment = StringAlignment.Center,
                    //    LineAlignment = StringAlignment.Center
                    //});
                    break;
            }

            if (_Value == 0)
            {
                return;
            }
            else if (_Value == _Maximum)
            {
                G.FillRectangle(new SolidBrush(_ProgressColour), new Rectangle(0, Height - 4, Width, Height - 4));
                G.DrawRectangle(new Pen(_BorderColour, 2), new Rectangle(0, 0, Width, Height));

            }
            else
            {
                G.FillRectangle(new SolidBrush(_ProgressColour), new Rectangle(0, Height - 4, Convert.ToInt32(Width / _Maximum * _Value), Height - 4));
                G.DrawRectangle(new Pen(_BorderColour, 2), new Rectangle(0, 0, Width, Height));

            }

            #region Old Code
            //      switch (_Value) {
            //	case 0:
            //		break;
            //	case _Maximum:
            //		G.FillRectangle(new SolidBrush(_ProgressColour), new Rectangle(0, Height - 4, Width, Height - 4));
            //		G.DrawRectangle(new Pen(_BorderColour, 2), new Rectangle(0, 0, Width, Height));
            //		break;
            //	default:
            //		G.FillRectangle(new SolidBrush(_ProgressColour), new Rectangle(0, Height - 4, Convert.ToInt32(Width / _Maximum * _Value), Height - 4));
            //		G.DrawRectangle(new Pen(_BorderColour, 2), new Rectangle(0, 0, Width, Height));
            //		break;
            //} 
            #endregion

            G.InterpolationMode = (InterpolationMode)7;
        }
        
        private void LoginLogButtonOnPaint(PaintEventArgs e)
        {
            GraphicsPath GP = new GraphicsPath();
            GraphicsPath GP1 = new GraphicsPath();
            
            G.PixelOffsetMode = PixelOffsetMode.HighQuality;
            G.Clear(Parent.BackColor);
            Point[] P = {
            new Point(18, 22),
            new Point(28, 22),
            new Point(28, 18),
            new Point(34, 25),
            new Point(28, 32),
            new Point(28, 28),
            new Point(18, 28)
        };
            switch (State)
            {
                case MouseState.None:
                    G.FillEllipse(new SolidBrush(Color.FromArgb(56, 56, 56)), new Rectangle(Convert.ToInt32(3 / 2) + 1, Convert.ToInt32(3 / 2) + 1, Width - 3 - 3, Height - 3 - 3));
                    G.DrawArc(new Pen(new SolidBrush(_ArcColour), 1 + 3), Convert.ToInt32(3 / 2) + 1, Convert.ToInt32(3 / 2) + 1, Width - 3 - 3, Height - 3 - 3, -90, 360);
                    G.DrawEllipse(new Pen(_BorderColour), new Rectangle(1, 1, Height - 3, Height - 3));
                    G.FillEllipse(new SolidBrush(_NormalColour), new Rectangle(Convert.ToInt32(3 / 2) + 3, Convert.ToInt32(3 / 2) + 3, Height - 11, Height - 11));
                    G.FillPolygon(new SolidBrush(_ArrowColour), P);
                    G.DrawPolygon(new Pen(_ArrowBorderColour), P);
                    break;
                case MouseState.Over:
                    G.DrawArc(new Pen(new SolidBrush(_ArcColour), 1 + 3), Convert.ToInt32(3 / 2) + 1, Convert.ToInt32(3 / 2) + 1, Width - 3 - 3, Height - 3 - 3, -90, 360);
                    G.DrawEllipse(new Pen(_BorderColour), new Rectangle(1, 1, Height - 3, Height - 3));
                    G.FillEllipse(new SolidBrush(_HoverColour), new Rectangle(6, 6, Height - 13, Height - 13));
                    G.FillPolygon(new SolidBrush(_ArrowColour), P);
                    G.DrawPolygon(new Pen(_ArrowBorderColour), P);
                    break;
                case MouseState.Down:
                    G.DrawArc(new Pen(new SolidBrush(_ArcColour), 1 + 3), Convert.ToInt32(3 / 2) + 1, Convert.ToInt32(3 / 2) + 1, Width - 3 - 3, Height - 3 - 3, -90, 360);
                    G.DrawEllipse(new Pen(_BorderColour), new Rectangle(1, 1, Height - 3, Height - 3));
                    G.FillEllipse(new SolidBrush(_PressedColour), new Rectangle(6, 6, Height - 13, Height - 13));
                    G.FillPolygon(new SolidBrush(_ArrowColour), P);
                    G.DrawPolygon(new Pen(_ArrowBorderColour), P);
                    break;
            }
            GP.Dispose();
            GP1.Dispose();
            G.InterpolationMode = InterpolationMode.HighQualityBicubic;
        }

        private void LoginPaint(PaintEventArgs e)
        {
            switch (Loginstyle)
            {
                case LoginStyles.Button:
                    LoginButtonPaint(e);
                    break;
                case LoginStyles.ButtonWithProgress:
                    LoginButtonWithProgressPaint(e);
                    break;
                case LoginStyles.Log:
                    LoginLogButtonOnPaint(e);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        
    }

}

