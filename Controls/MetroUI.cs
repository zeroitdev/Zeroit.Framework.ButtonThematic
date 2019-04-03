// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="MetroUI.cs" company="Zeroit Dev Technologies">
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

        
        Color metroUIButtonC = Color.FromArgb(53, 157, 181);
        
        private void MetroUIPaintHook()
        {
            G.Clear(metroUIButtonC);

            switch (State)
            {
                case MouseState.None:
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);
                    break;
                case MouseState.Over:
                    G.Clear(Color.FromArgb(49, 144, 166));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);
                    break;
                case MouseState.Down:
                    G.Clear(Color.FromArgb(34, 100, 115));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);
                    break;
            }
        }
    }

}

