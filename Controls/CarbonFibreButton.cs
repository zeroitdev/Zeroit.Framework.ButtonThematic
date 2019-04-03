﻿// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="CarbonFibreButton.cs" company="Zeroit Dev Technologies">
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
        
        #region "Color Of Control"

        private void CarbonFibrePaintHook()
        {
            G.Clear(Color.FromArgb(22, 22, 22));

            LinearGradientBrush Header = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(25, 25, 25), Color.FromArgb(42, 42, 42), 270);
            G.FillRectangle(Header, new Rectangle(0, 0, Width - 1, Height - 1));


            HatchBrush HeaderHatch = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(35, Color.Black), Color.Transparent);
            G.FillRectangle(HeaderHatch, new Rectangle(0, 0, Width - 1, Height - 1));

            switch (State)
            {
                case MouseState.Over:
                    LinearGradientBrush Header1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(25, 25, 25), Color.FromArgb(50, 50, 50), 270);
                    G.FillRectangle(Header1, new Rectangle(0, 0, Width - 1, Height - 1));


                    HatchBrush HeaderHatch1 = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(35, Color.Black), Color.Transparent);
                    G.FillRectangle(HeaderHatch1, new Rectangle(0, 0, Width - 1, Height - 1));

                    break;
                case MouseState.Down:
                    LinearGradientBrush Header2 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(25, 25, 25), Color.FromArgb(35, 35, 35), 270);
                    G.FillRectangle(Header2, new Rectangle(0, 0, Width - 1, Height - 1));


                    HatchBrush HeaderHatch2 = new HatchBrush(HatchStyle.Trellis, Color.FromArgb(35, Color.Black), Color.Transparent);
                    G.FillRectangle(HeaderHatch2, new Rectangle(0, 0, Width - 1, Height - 1));
                    break;
            }

            //G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(6, 6, 6)), new Rectangle(-1, -1, Width - 1, Height - 1), new StringFormat
            //{
            //    Alignment = StringAlignment.Center,
            //    LineAlignment = StringAlignment.Center
            //});
            //G.DrawString(Text, Font, new SolidBrush(Color.FromArgb(255, 150, 0)), new Rectangle(0, 0, Width - 1, Height - 1), new StringFormat
            //{
            //    Alignment = StringAlignment.Center,
            //    LineAlignment = StringAlignment.Center
            //});

            DrawBorders(Pens.Black);
            DrawBorders(new Pen(Color.FromArgb(32, 32, 32)), 1);

            DrawCorners(Color.FromArgb(22, 22, 22), 1);
            DrawCorners(Color.FromArgb(22, 22, 22));
        }
        
        #endregion
    }

}

