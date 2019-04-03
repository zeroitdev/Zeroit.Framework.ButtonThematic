// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Empress.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;
using System.Drawing.Drawing2D;
using Zeroit.Framework.ButtonThematic.ThemeManagers;
using ColorConverter = Zeroit.Framework.ButtonThematic.ThemeManagers.ColorConverter;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        Color ButtonColor = ColorConverter.HexToColor("#A12F35");
        Color InnerBorder = Color.FromArgb(55, Color.White);
        
        Color border = Color.Black;
        
        
        private void EmpressPaintHook()
        {
            G.Clear(ButtonColor);
            switch (State)
            {
                case MouseState.None:
                    LinearGradientBrush ButtonDefinition = new LinearGradientBrush(new Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(5, Color.White), Color.FromArgb(55, Color.Black), 90);
                    G.FillRectangle(new SolidBrush(ButtonColor), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.FillRectangle(ButtonDefinition, ButtonDefinition.Rectangle);
                    G.DrawRectangle(new Pen(border), new Rectangle(0, 0, Width - 1, Height - 1));
                    break;
                case MouseState.Over:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(50, Color.PeachPuff)), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(border), new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);
                    break;
                case MouseState.Down:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(50, Color.Violet)), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(border), new Rectangle(0, 0, Width - 1, Height - 1));
                    break;
            }
            G.DrawRectangle(new Pen(InnerBorder), new Rectangle(1, 1, Width - 3, Height - 3));
            //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);


            HatchBrush BodyHatch = new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(20, Color.Black), Color.Transparent);
            G.FillRectangle(BodyHatch, new Rectangle(0, 0, Width - 1, Height - 1));
        }
    }

}

