// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Alpha.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{
    public partial class ButtonThematic
    {

        private Color[] alphaBorders = new Color[]
        {
            Color.Lime,
            Color.DimGray
        };

        [Browsable(false)]
        public Color[] AlphaBorders
        {
            get { return alphaBorders; }
            set
            {
                alphaBorders = value;
                Invalidate();
            }
        }

        /// <summary>
        /// Paints the hook.
        /// </summary>
        /// 
        public void AlphaPaintHook(PaintEventArgs e)
        {
            switch (State)
            {
                case MouseState.None:
                    G.Clear(Color.DimGray);
                    break;
                case MouseState.Over:
                    G.Clear(Color.Gray);
                    break;
                case MouseState.Down:
                    G.Clear(Color.Green);
                    break;
            }
            
            //DrawText(HorizontalAlignment.Center, Color.Lime, 0);

            DrawBorders(new Pen(alphaBorders[0]), new Pen(alphaBorders[1]), ClientRectangle);
            DrawCorners(BackColor, ClientRectangle);
        }
    }
}
