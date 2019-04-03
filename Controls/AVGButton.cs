// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="AVGButton.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using System.Drawing;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic 
    {
        Color avgbackground = Color.FromArgb(24, 143, 124);
        Color avgBorder = Color.Transparent;

        [Browsable(false)]
        public Color Avgbackground
        {
            get
            {
                return avgbackground;
            }
            set { avgbackground = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color AvgBorder
        {
            get { return avgBorder; }
            set { avgBorder = value; Invalidate();}
        }


        private void AVGPaint()
        {
            G.Clear(Avgbackground);
            switch (State)
            {
                case MouseState.None:
                    G.DrawRectangle(new Pen(AvgBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    break;
                case MouseState.Over:
                    G.FillRectangle(new SolidBrush(Color.FromArgb(24, 143, 124)), new Rectangle(0, 0, Width - 1, Height - 1));
                    G.DrawRectangle(new Pen(AvgBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    break;
            }
        }
    }

    
}
