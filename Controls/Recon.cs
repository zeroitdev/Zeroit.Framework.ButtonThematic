// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Recon.cs" company="Zeroit Dev Technologies">
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

        
        private void ReconPaintHook()
        {
            switch (State)
            {
                case MouseState.None:
                    G.Clear(Color.FromArgb(49, 49, 49));
                    DrawGradient(Color.FromArgb(22, 22, 22), Color.FromArgb(34, 34, 34), 1, 1, ClientRectangle.Width, ClientRectangle.Height, 270);
                    DrawBorders(Pens.Black, new Pen(Color.FromArgb(52, 52, 52)), ClientRectangle);
                    //DrawText(HorizontalAlignment.Center, this.ForeColor, 0);
                    DrawCorners(this.BackColor, ClientRectangle);
                    break;
                case MouseState.Down:
                    G.Clear(Color.FromArgb(49, 49, 49));
                    DrawGradient(Color.FromArgb(28, 28, 28), Color.FromArgb(38, 38, 38), 1, 1, ClientRectangle.Width, ClientRectangle.Height, 270);
                    DrawGradient(Color.FromArgb(100, 0, 0, 0), Color.Transparent, 1, 1, ClientRectangle.Width, ClientRectangle.Height / 2, 90);
                    DrawBorders(Pens.Black, new Pen(Color.FromArgb(52, 52, 52)), ClientRectangle);
                    //DrawText(HorizontalAlignment.Center, this.ForeColor, 1);
                    DrawCorners(this.BackColor, ClientRectangle);
                    break;
                case MouseState.Over:
                    G.Clear(Color.FromArgb(49, 49, 49));
                    DrawGradient(Color.FromArgb(28, 28, 28), Color.FromArgb(38, 38, 38), 1, 1, ClientRectangle.Width, ClientRectangle.Height, 270);
                    DrawGradient(Color.FromArgb(100, 50, 50, 50), Color.Transparent, 1, 1, ClientRectangle.Width, ClientRectangle.Height / 2, 90);
                    DrawBorders(Pens.Black, new Pen(Color.FromArgb(52, 52, 52)), ClientRectangle);
                    //DrawText(HorizontalAlignment.Center, this.ForeColor, -1);
                    DrawCorners(this.BackColor, ClientRectangle);
                    break;
            }
            
        }

    }

}

