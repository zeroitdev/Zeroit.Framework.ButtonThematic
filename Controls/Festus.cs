// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Festus.cs" company="Zeroit Dev Technologies">
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

        private Pen FestusP1 = new Pen(Color.FromArgb(225, 225, 225));
        private Pen FestusP2 = new Pen(Color.FromArgb(205, 205, 205));
        private Pen FestusP11 = new Pen(Color.FromArgb(225, 225, 225));
        private Pen FestusP12 = new Pen(Color.FromArgb(200, 200, 200));

        private void FestusPaintHook()
        {
            
            G.Clear(Color.FromArgb(240, 240, 240));
            DrawGradient(Color.FromArgb(250, 250, 250), Color.FromArgb(247, 248, 248), 0, 0, Width, 3, 90);
            DrawGradient(Color.FromArgb(248, 248, 248), Color.FromArgb(0, 0, 0), 0, 0, Width, 275, 90);
            DrawBorders(FestusP11, FestusP12, ClientRectangle);

            switch (State)
            {

                case MouseState.Over:
                    DrawGradient(Color.FromArgb(250, 250, 250), Color.FromArgb(247, 248, 248), 0, 0, Width, 20, 90);
                    DrawGradient(Color.FromArgb(248, 248, 248), Color.FromArgb(0, 0, 0), 0, 0, Width, 250, 90);
                    DrawBorders(FestusP2, FestusP11, ClientRectangle);
                    //DrawText(HorizontalAlignment.Center, Color.Red, 0);

                    break;
                case MouseState.Down:
                    Rectangle _Rectangle = new Rectangle(0, -3, Width, Height / 2);
                    LinearGradientBrush _Gradient = new LinearGradientBrush(_Rectangle, Color.FromArgb(238, 238, 238), Color.FromArgb(240, 240, 240), 90);
                    G.FillRectangle(_Gradient, _Rectangle);
                    DrawBorders(new Pen(Color.FromArgb(240, 240, 240)), new Pen(Color.FromArgb(190, 190, 190)), ClientRectangle);
                    //DrawText(HorizontalAlignment.Center, Color.Gray, 0);
                    break;
            }
            
            DrawCorners(Color.FromArgb(240, 240, 240), ClientRectangle);
            //DrawText(HorizontalAlignment.Center, Color.Gray, 0);
        }
    }

}

