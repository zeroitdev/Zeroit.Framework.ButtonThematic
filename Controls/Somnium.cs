// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Somnium.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        //G.Clear
        private Color somniumC1 = Color.White;
        private Color somniumC2 = Color.FromArgb(50, 50, 50);
        //Lime Gradient
        private Color somniumC3 = Color.FromArgb(0, 0, 0);
        //Gloss
        private Color somniumB1 = Color.FromArgb(60, Color.White);
        //Grey Text
        private Color somniumB2 = Color.White;
        //DrawRectangle
        private Color somniumP1 = Color.White;
        
        
        private void SomniumPaintHook()
        {
            G.Clear(somniumC1);
            DrawGradient(somniumC2, somniumC3, 0, 0, Width, Height, 90);
            //Gloss'
            if ((State == MouseState.Over))
            {
                G.FillRectangle(new SolidBrush(somniumB1), 0, Convert.ToInt32(Height / 2), Width, Convert.ToInt32(Height / 2));
            }
            else if ((State == MouseState.Down))
            {
                G.FillRectangle(new SolidBrush(somniumB1), 0, 0, Width, Convert.ToInt32(Height / 2));
            }
            else
            {
                G.FillRectangle(new SolidBrush(somniumB1), 0, 0, Width, Convert.ToInt32(Height / 2));
            }
            DrawBorders(new Pen(somniumP1), 0, 0, Width, Height);
            //DrawText(new SolidBrush(somniumB2), HorizontalAlignment.Center, 0, 0);
        }

    }

}

