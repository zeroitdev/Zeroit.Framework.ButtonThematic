// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Studio.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        
        private Color studioC1 = Color.FromArgb(45, 65, 95);
        private Color studioC2 = Color.FromArgb(65, 85, 115);
        private Color studioC3 = Color.FromArgb(65, 85, 115);
        private Color studioC4 = Color.FromArgb(45, 65, 95);
        private Color studioC5 = Color.FromArgb(30, Color.White);
        private Color studioC6 = Color.Transparent;
        private Color studioC7 = Color.FromArgb(20, 40, 70);
        private Color studioP1 = Color.FromArgb(30, Color.White);
        private Color studioP2 = Color.FromArgb(20, Color.White);
        private Color studioP3 = Color.FromArgb(50, Color.Black);
        private Color studioB1 = Color.White;
        private Color studioB2 = Color.FromArgb(10, Color.White);
        private Color studioB3 = Color.FromArgb(20, 40, 70);
        


        private void StudioPaintHook()
        {
            if (State == MouseState.Down)
            {
                DrawGradient(studioC1, studioC2, ClientRectangle, 90f);
            }
            else
            {
                DrawGradient(studioC3, studioC4, ClientRectangle, 90f);
            }

            G.DrawLine(new Pen(studioP1), 1, 1, Width, 1);
            DrawGradient(studioC5, studioC6, 1, 1, 1, Height);
            DrawGradient(studioC5, studioC6, Width - 2, 1, 1, Height);
            G.DrawLine(new Pen(studioP2), 1, Height - 2, Width, Height - 2);

            if (State == MouseState.Down)
            {
                //DrawText(new SolidBrush(studioB1), HorizontalAlignment.Center, 2, 2);
                //DrawText(new SolidBrush(studioB2), HorizontalAlignment.Center, 1, 1);
            }
            else
            {
                //DrawText(new SolidBrush(studioB1), HorizontalAlignment.Center, 1, 1);
                //DrawText(new SolidBrush(studioB2), HorizontalAlignment.Center, 0, 0);
            }

            if (State == MouseState.Over)
            {
                G.FillRectangle(new SolidBrush(studioB3), ClientRectangle);
            }

            DrawBorders(new Pen(studioP3));
            DrawCorners(studioC7, 1, 1, Width - 2, Height - 2);

            DrawCorners(Parent.BackColor);
        }

    }

}

