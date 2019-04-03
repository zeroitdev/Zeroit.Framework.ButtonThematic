// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="AresioButton.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{
    /// <summary>
    /// Class AresioButton.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ButtonThematic
    {
        
        private void AresioPaint(System.Windows.Forms.PaintEventArgs e)
        {
            //Graphics G = e.Graphics;

            G.SmoothingMode = Smoothing;
            G.Clear(BackColor);

            //Background
            G.FillPath(new LinearGradientBrush(new Point(0, 0), new Point(0, Height), Color.FromArgb(250, 200, 70), Color.FromArgb(250, 160, 40)), DesignFunctions.RoundRect(0, 0, Width - 1, Height - 1, 4));

            G.DrawPath(DesignFunctions.ToPen(50, Color.White), DesignFunctions.RoundRect(0, 1, Width - 1, Height - 2, 4));
            G.DrawPath(DesignFunctions.ToPen(150, 100, 70), DesignFunctions.RoundRect(0, 0, Width - 1, Height - 1, 4));
            switch (Enabled)
            {
                case true:
                    switch (State)
                    {
                        case MouseState.Over:
                            G.FillPath(new LinearGradientBrush(new Point(0, 0), new Point(0, Height), Color.FromArgb(50, Color.White), Color.Transparent), DesignFunctions.RoundRect(0, 0, Width - 1, Height - 1, 4));
                            break;
                        case MouseState.Down:
                            G.FillPath(new LinearGradientBrush(new Point(0, 0), new Point(0, Height), Color.FromArgb(50, Color.Black), Color.Transparent), DesignFunctions.RoundRect(0, 0, Width - 1, Height - 1, 4));
                            break;
                    }

                    //G.DrawString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular), DesignFunctions.ToBrush(100, Color.White), new Point(Convert.ToInt32((Width / 2) - (G.MeasureString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Width / 2)), Convert.ToInt32((Height / 2) - (G.MeasureString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Height / 2)) + 1));
                    //G.DrawString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular), DesignFunctions.ToBrush(200, Color.Black), new Point(Convert.ToInt32((Width / 2) - (G.MeasureString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Width / 2)), Convert.ToInt32((Height / 2) - (G.MeasureString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Height / 2))));
                    break;
                case false:
                    //G.DrawString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular), Brushes.White, new Point(Convert.ToInt32((Width / 2) - (G.MeasureString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Width / 2)) + 1, Convert.ToInt32((Height / 2) - (G.MeasureString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Height / 2)) + 1));
                    //G.DrawString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular), Brushes.Gray, new Point(Convert.ToInt32((Width / 2) - (G.MeasureString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Width / 2)), Convert.ToInt32((Height / 2) - (G.MeasureString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Height / 2))));
                    break;
            }
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseEnter" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        private void AresioOnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);
            State = MouseState.Over;
            Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseLeave" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        private void AresioOnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
            State = MouseState.None;
            Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseDown" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        private void AresioOnMouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseDown(e);
            State = MouseState.Down;
            Invalidate();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.MouseUp" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.Forms.MouseEventArgs" /> that contains the event data.</param>
        private void AresioOnMouseUp(System.Windows.Forms.MouseEventArgs e)
        {
            base.OnMouseUp(e);
            State = MouseState.Over;
            Invalidate();
        }
    }
}
