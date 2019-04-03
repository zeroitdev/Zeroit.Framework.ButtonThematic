// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Light.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        private void LightPaintHook()
        {
            DrawText(HorizontalAlignment.Center, Color.Lime, 0);
            switch (State)
            {
                case MouseState.None:
                    HatchBrush hb = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(20, Color.White), Color.Transparent);
                    HatchBrush hb2 = new HatchBrush(HatchStyle.BackwardDiagonal, Color.FromArgb(35, Color.White), Color.Transparent);
                    G.FillRectangle(new SolidBrush(Color.FromArgb(196, 196, 196)), 0, 0, Width, Height);
                    DrawGradient(Color.FromArgb(196, 196, 196), Color.FromArgb(230, 230, 230), 0, 0, Width, 30, 270);
                    G.FillRectangle(hb, 1, 1, Width, Height);
                    DrawBorders(Pens.Gray, Pens.White, ClientRectangle);
                    DrawGradient(Color.FromArgb(50, Color.White), Color.Transparent, 1, 1, Width - 2, Height / 2 - 3, 270);
                    //DrawText(HorizontalAlignment.Center, this.ForeColor, 0);
                    DrawCorners(this.Parent.BackColor, ClientRectangle);
                    break;
                case MouseState.Down:
                    HatchBrush hb1 = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(20, Color.White), Color.Transparent);
                    HatchBrush hb21 = new HatchBrush(HatchStyle.BackwardDiagonal, Color.FromArgb(35, Color.White), Color.Transparent);
                    G.FillRectangle(new SolidBrush(Color.FromArgb(196, 196, 196)), 0, 0, Width, Height);
                    DrawGradient(Color.FromArgb(196, 196, 196), Color.FromArgb(230, 230, 230), 0, 0, Width, 30, 270);
                    G.FillRectangle(hb1, 1, 1, Width, Height);
                    DrawBorders(Pens.Gray, Pens.LightGray, ClientRectangle);
                    //DrawText(HorizontalAlignment.Center, this.ForeColor, 1);
                    DrawGradient(Color.FromArgb(60, Color.RoyalBlue), Color.Transparent, 0, 0, Width, Height, 90);
                    DrawGradient(Color.FromArgb(25, Color.Black), Color.Transparent, 0, 0, Width, Height, 270);
                    DrawGradient(Color.FromArgb(20, Color.White), Color.Transparent, 1, 1, Width - 2, Height / 2, 270);
                    DrawCorners(this.Parent.BackColor, ClientRectangle);
                    break;
                case MouseState.Over:
                    HatchBrush hb24 = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(20, Color.White), Color.Transparent);
                    HatchBrush hb22 = new HatchBrush(HatchStyle.BackwardDiagonal, Color.FromArgb(35, Color.White), Color.Transparent);
                    G.FillRectangle(new SolidBrush(Color.FromArgb(196, 196, 196)), 0, 0, Width, Height);
                    DrawGradient(Color.FromArgb(196, 196, 196), Color.FromArgb(230, 230, 230), 0, 0, Width, 30, 270);
                    G.FillRectangle(hb24, 1, 1, Width, Height);
                    DrawBorders(Pens.Gray, Pens.LightGray, ClientRectangle);
                    //DrawText(HorizontalAlignment.Center, this.ForeColor, -1);
                    DrawGradient(Color.FromArgb(35, Color.RoyalBlue), Color.Transparent, 0, 0, Width, Height, 90);
                    DrawGradient(Color.FromArgb(35, Color.White), Color.Transparent, 1, 1, Width - 2, Height / 2 - 5, 270);
                    DrawCorners(this.Parent.BackColor, ClientRectangle);
                    break;
            }
            this.Cursor = Cursors.Hand;
            DrawCorners(this.Parent.BackColor, ClientRectangle);
        }

    }

}

