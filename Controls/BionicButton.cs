// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="BionicButton.cs" company="Zeroit Dev Technologies">
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
        
        private void BionicPaint()
        {
            
            G.Clear(Color.FromArgb(206, 145, 60));
            G.FillRectangle(new LinearGradientBrush(new Point(1, 1), new Point(1, Height - 2), Color.FromArgb(252, 132, 19), Color.FromArgb(212, 75, 31)), new Rectangle(1, 1, Width - 2, Height - 2));

            switch (State)
            {
                case MouseState.Over:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(20, Color.White)), new Rectangle(1, 1, Width - 2, Height - 2));
                    break;
                case MouseState.Down:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(30, Color.Black)), new Rectangle(1, 1, Width - 2, Height - 2));
                    break;
            }

            //StringFormat _StringF = new StringFormat();
            //_StringF.Alignment = StringAlignment.Center;
            //_StringF.LineAlignment = StringAlignment.Center;
            //G.DrawString(Text, new Font("Arial", 9), Brushes.White, new RectangleF(0, 0, Width, Height), _StringF);


        }

    }
}
