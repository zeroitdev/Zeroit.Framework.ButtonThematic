// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Mumtz.cs" company="Zeroit Dev Technologies">
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

        Color mumtzButtonColor = Color.White;
        
        Color mumtzBorder = Color.Black;

        

        private void MumtzPaintHook()
        {
            G.Clear(mumtzButtonColor);
            switch (State)
            {
                case MouseState.None:
                    G.DrawRectangle(new Pen(mumtzBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);
                    break;
                case MouseState.Over:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(50, Color.Turquoise)), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(mumtzBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);
                    break;
                case MouseState.Down:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(50, Color.DarkCyan)), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(mumtzBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);
                    break;
            }
        }

    }

}

