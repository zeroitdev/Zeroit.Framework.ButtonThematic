// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="JTheme.cs" company="Zeroit Dev Technologies">
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

        Color jColor1 = Color.FromArgb(15, 15, 15);
        Color jColor3 = Color.FromArgb(30, 30, 30);
        Color jColor4 = Color.FromArgb(20, 20, 20);
        

        private void JPaintHook()
        {
            G.Clear(jColor1);
            //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);
            DrawBorders(new Pen(jColor3));

            switch (State)
            {
                case MouseState.Over:
                    G.Clear(jColor4);
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);
                    DrawBorders(new Pen(jColor3));

                    break;
            }

        }

    }

}

