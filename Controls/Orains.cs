// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Orains.cs" company="Zeroit Dev Technologies">
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

        
        Color orainsButtonColor1 = Color.FromArgb(35, 35, 35);
        Color orainsButtonColor2 = Color.FromArgb(20, 20, 20);
        Color orainsInnerBorder = Color.FromArgb(40, 40, 40);
        Color orainsHeader = Color.FromArgb(40, 40, 40);

        Color orainsOuterBorder = Color.Black;
        
        private void OrainsPaintHook()
        {
            //G.Clear(BackColor)


            switch (State)
            {
                case MouseState.None:

                    LinearGradientBrush LGB = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), orainsButtonColor1, orainsButtonColor2, 90);
                    G.FillRectangle(LGB, new Rectangle(0, 0, Width - 1, Height - 1));
                    HatchBrush BodyHatch = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(30, Color.Black), Color.Transparent);
                    G.FillRectangle(BodyHatch, new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(Color.DarkOrange), HorizontalAlignment.Center, 0, 0);

                    G.DrawRectangle(new Pen(orainsOuterBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(orainsInnerBorder), new Rectangle(1, 1, Width - 3, Height - 3));
                    break;
                case MouseState.Over:

                    LinearGradientBrush LGB1 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), orainsButtonColor1, Color.FromArgb(20, 20, 20), 90);
                    G.FillRectangle(LGB1, new Rectangle(0, 0, Width - 1, Height - 1));
                    HatchBrush BodyHatch1 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(30, Color.Black), Color.Transparent);
                    G.FillRectangle(BodyHatch1, new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, -1, -1);

                    G.DrawRectangle(new Pen(orainsOuterBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(Color.FromArgb(45, 45, 45)), new Rectangle(1, 1, Width - 3, Height - 3));
                    break;
                case MouseState.Down:
                    LinearGradientBrush LGB2 = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(20, 20, 20), orainsButtonColor2, 90);
                    G.FillRectangle(LGB2, new Rectangle(0, 0, Width - 1, Height - 1));
                    HatchBrush BodyHatch2 = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.FromArgb(30, Color.Black), Color.Transparent);
                    G.FillRectangle(BodyHatch2, new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(Color.DarkOrange), HorizontalAlignment.Center, 1, 1);

                    G.DrawRectangle(new Pen(orainsOuterBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(Color.FromArgb(32, 32, 32)), new Rectangle(1, 1, Width - 3, Height - 3));
                    break;
            }




            //Dim BodyHatch As New HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(20, Color.Black), Color.Transparent)
            // G.FillRectangle(BodyHatch, New Rectangle(0, 0, Width - 1, Height - 1))
        }


    }

}

