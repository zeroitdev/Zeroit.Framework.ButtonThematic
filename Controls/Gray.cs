// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Gray.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {
        private void GrayPaint()
        {
            
            G.Clear(Parent.BackColor);

            LinearGradientBrush BackgroundGradient = new LinearGradientBrush(new Point(0, 0), new Point(0, Height), Color.Transparent, Color.Transparent);

            switch (State)
            {
                case MouseState.None:
                    BackgroundGradient.LinearColors = new Color[] {
                    Color.FromArgb(127, 127, 127),
                    Color.FromArgb(93, 93, 93)
                };
                    break;
                case MouseState.Over:
                    BackgroundGradient.LinearColors = new Color[] {
                    Color.FromArgb(75, 130, 195),
                    Color.FromArgb(40, 80, 135)
                };
                    break;
                case MouseState.Down:
                    BackgroundGradient.LinearColors = new Color[] {
                    Color.FromArgb(55, 110, 175),
                    Color.FromArgb(40, 80, 135)
                };
                    break;
            }

            G.FillPath(BackgroundGradient, DesignFunctions.RoundRect(0, 0, Width - 1, Height - 1, 3));
            G.DrawLine(DesignFunctions.ToPen(100, Color.White), new Point(2, 1), new Point(Width - 3, 1));
            G.DrawPath(Pens.Gray, DesignFunctions.RoundRect(0, 0, Width - 1, Height - 1, 3));
            G.DrawPath(Pens.Black, DesignFunctions.RoundRect(0, 0, Width - 1, Height - 2, 3));

            BackgroundGradient.Dispose();

            //G.DrawString(Text, new Font(Font.Name, Font.Size, FontStyle.Bold), Brushes.Black, new Rectangle(0, 0, Width - 1, Height - 1), new StringFormat
            //{
            //    LineAlignment = StringAlignment.Center,
            //    Alignment = StringAlignment.Center
            //});
            //G.DrawString(Text, new Font(Font.Name, Font.Size, FontStyle.Bold), Brushes.White, new Rectangle(0, 1, Width - 1, Height - 1), new StringFormat
            //{
            //    LineAlignment = StringAlignment.Center,
            //    Alignment = StringAlignment.Center
            //});
        }
        
    }

}

