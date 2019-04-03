// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Sasi.cs" company="Zeroit Dev Technologies">
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

        Color SasiButtonColor = Color.FromArgb(218, 240, 139);
        Color SasiBorder = Color.White;
        

        private void SasiPaintHook()
        {
            G.Clear(SasiButtonColor);

            DrawCorners(BackColor);
            switch (State)
            {
                case MouseState.None:

                    HatchBrush HB = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(30, Color.White), Color.Transparent);
                    G.DrawRectangle(new Pen(SasiBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.FillRectangle(HB, new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;
                case MouseState.Over:

                    HatchBrush HB1 = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(30, Color.White), Color.Transparent);
                    G.FillRectangle(new SolidBrush(Color.FromArgb(199, 211, 229)), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(SasiBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.FillRectangle(HB1, new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);
                    break;
                case MouseState.Down:

                    HatchBrush HB2 = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(30, Color.White), Color.Transparent);
                    G.FillRectangle(new SolidBrush(Color.FromArgb(50, Color.Black)), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(SasiBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.FillRectangle(HB2, new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);
                    break;
            }
        }

    }

}

