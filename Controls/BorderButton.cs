// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="BorderButton.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Drawing;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        public enum BorderButtonStyles
        {
            Full,
            Sub
        }

        private BorderButtonStyles borderButtonStyles = BorderButtonStyles.Full;

        [Browsable(false)]
        public BorderButtonStyles BorderButtonStyle
        {
            get { return borderButtonStyles; }
            set
            {
                borderButtonStyles = value;
                Invalidate();
            }
        }

        private void BorderButtonFullPaintHook()
        {
            
            switch (State)
            {
                case MouseState.None:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(35, 35, 35)), ClientRectangle);
                    break;
                case MouseState.Over:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(30, 30, 30)), ClientRectangle);
                    break;
                case MouseState.Down:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(38, 38, 38)), ClientRectangle);
                    break;
            }

            //G.DrawString(Text, Font, Brushes.White,
            //    new Point(Convert.ToInt32((this.Width / 2) - (Measure(Text).Width / 2)),
            //        Convert.ToInt32((this.Height / 2) - (Measure(Text).Height / 2))));

            G.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));
            DrawCorners(Color.FromArgb(15, 15, 15));
        }


        private string borderButtonSubText;

        [Browsable(false)]
        public string BorderButtonSubText
        {
            get { return borderButtonSubText; }
            set
            {
                borderButtonSubText = value;
                Invalidate();
            }
        }

        
        private void BorderButtonSubPaintHook()
        {
            switch (State)
            {
                case MouseState.None:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(35, 35, 35)), ClientRectangle);
                    break;
                case MouseState.Over:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(30, 30, 30)), ClientRectangle);
                    break;
                case MouseState.Down:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(38, 38, 38)), ClientRectangle);
                    break;
            }

            //G.DrawString(Text, Font, Brushes.White, new Point(6, 8));
            Font SubFont = new Font(DefaultFont.FontFamily, Font.Size - 1);
            //G.DrawString(borderButtonSubText, SubFont, new SolidBrush(Color.FromArgb(48, 48, 48)), new Point(6, 21));
            G.DrawRectangle(Pens.Black, new Rectangle(0, 0, Width - 1, Height - 1));
            DrawCorners(Color.FromArgb(15, 15, 15));
        }

        private void BorderButtonPaint()
        {
            G.Clear(BackColor);

            switch (BorderButtonStyle)
            {
                case BorderButtonStyles.Full:
                    BorderButtonFullPaintHook();
                    break;
                case BorderButtonStyles.Sub:
                    BorderButtonSubPaintHook();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

    }

}

