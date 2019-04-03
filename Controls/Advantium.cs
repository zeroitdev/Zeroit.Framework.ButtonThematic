// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Advantium.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{
    public partial class ButtonThematic
    {

        
        Color advantiumC1 = Color.FromArgb(40, 40, 40);
        Color advantiumT1 = Color.LawnGreen;
        
        private void AdvantiumPaintHook()
        {
            G.Clear(advantiumC1);
            switch (State)
            {
                case MouseState.None:
                    //None
                    DrawGradient(Color.FromArgb(50, 50, 50), Color.FromArgb(42, 42, 42), ClientRectangle, 90);
                    Cursor = Cursors.Arrow;
                    break;
                case MouseState.Down:
                    //Down
                    DrawGradient(Color.FromArgb(50, 50, 50), Color.FromArgb(42, 42, 42), ClientRectangle, 90);
                    Cursor = Cursors.Hand;
                    break;
                case MouseState.Over:
                    //Over
                    DrawGradient(Color.FromArgb(42, 42, 42), Color.FromArgb(50, 50, 50), ClientRectangle, 90);
                    Cursor = Cursors.Hand;
                    break;
            }
            DrawBorders(new Pen(new SolidBrush(Color.FromArgb(59, 59, 59))), 1);
            DrawBorders(new Pen(new SolidBrush(Color.FromArgb(25, 25, 25))));
            DrawCorners(Color.FromArgb(35, 35, 35));
            //DrawText(new SolidBrush(advantiumT1), HorizontalAlignment.Center, 0, 0);
        }

    }
}
