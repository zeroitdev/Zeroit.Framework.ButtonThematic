// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Positron.cs" company="Zeroit Dev Technologies">
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

        private Color positronTopG = Color.FromArgb(220, 220, 220);
        private Color BottomG = Color.FromArgb(200, 200, 200);
        private Color positronText = Color.FromArgb(100, 100, 100);
        private Color positronHover = Color.FromArgb(210, 210, 210);
        private Color positronBorder = Color.FromArgb(150, 150, 150);
        private Color positronInside = Color.FromArgb(200, 200, 200);
        

        private void PositronPaintHook()
        {
            G.Clear(positronTopG);
            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush LGB1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), positronTopG, BottomG, 90f);
                    G.FillRectangle(LGB1, new Rectangle(2, 2, Width - 4, Height - 4));
                    break; // TODO: might not be correct. Was : Exit Select
                    
                case MouseState.Over:
                    G.FillRectangle(new SolidBrush(positronHover), new Rectangle(2, 2, Width - 4, Height - 4));
                    break; // TODO: might not be correct. Was : Exit Select

                case MouseState.Down:
                    LinearGradientBrush LGB3 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), BottomG, positronTopG, 90f);
                    G.FillRectangle(LGB3, new Rectangle(2, 2, Width - 4, Height - 4));
                    break; // TODO: might not be correct. Was : Exit Select
                    
            }
            DrawBorders(new Pen(positronInside));
            //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);
            G.DrawRectangle(new Pen(positronBorder), new Rectangle(1, 1, Width - 3, Height - 3));
        }

    }

}

