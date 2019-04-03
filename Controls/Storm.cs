// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Storm.cs" company="Zeroit Dev Technologies">
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

        private ColorBlend Blend = new ColorBlend();

        
        private Color stormB1 = Color.FromArgb(20,Color.White);
        private Color stormB2 = Color.FromArgb(30, Color.White);
        private Color stormB3 = Color.White;
        private Color stormP1 = Color.FromArgb(150, 150, 165);

        private Color stormP2 = Color.FromArgb(70, 70, 90);

        private void StormPaintHook()
        {
            G.Clear(Parent.BackColor);

            Blend.Colors = new Color[]
            {
                Color.FromArgb(150, 150, 165),
                Color.FromArgb(120, 120, 140),
                Color.FromArgb(150, 150, 165)
            };
            Blend.Positions = new float[] { 0, 0.2f, 1.0f };
            
            DrawGradient(Blend, ClientRectangle, 90);

            G.FillRectangle(new SolidBrush(stormB1), 0, 0, Width, Height / 2);

            if (State == MouseState.Over)
            {
                G.FillRectangle(new SolidBrush(stormB2), ClientRectangle);
            }

            //DrawText(new SolidBrush(stormB3), HorizontalAlignment.Center, 0, 0);

            DrawBorders(new Pen(stormP1), 1);
            DrawBorders(new Pen(stormP2));
        }

    }

}

