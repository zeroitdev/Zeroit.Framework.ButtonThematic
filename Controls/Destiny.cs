// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Destiny.cs" company="Zeroit Dev Technologies">
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
        Color destinyG1 = Color.Teal;
        Color destinyG2 = Color.Black;
        Color destinyG3 = Color.Black;
        Color destinyG4 = Color.Teal;
        Color destinyBorder = Color.Black;
        Color destinyG5 = Color.Teal;

        [Browsable(false)]
        public Color DestinyG1
        {
            get { return destinyG1; }
            set { destinyG1 = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color DestinyG2
        {
            get { return destinyG2; }
            set { destinyG2 = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color DestinyG3
        {
            get { return destinyG3; }
            set { destinyG3 = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color DestinyG4
        {
            get { return destinyG4; }
            set { destinyG4 = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color DestinyBorder
        {
            get { return destinyBorder; }
            set { destinyBorder = value; Invalidate(); }
        }

        [Browsable(false)]
        public Color DestinyG5
        {
            get { return destinyG5; }
            set { destinyG5 = value; Invalidate(); }
        }

        //Color N;
        private void DestinyPaintHook()
        {
            //N = BackColor;
            G.Clear(Parent.BackColor);

            if (State == MouseState.None)
            {
                DrawGradient(DestinyG1, DestinyG2, 0, 0, Width, Height, 90);
            }
            else if (State == MouseState.Over)
            {
                DrawGradient(DestinyG3, DestinyG5, 0, 0, Width, Height, 90);
            }
            else if (State == MouseState.Down)
            {
                DrawGradient(DestinyG4, DestinyG4, 0, 0, Width, Height, 90);
            }

            //DrawText(HorizontalAlignment.Center, ForeColor, 0);
            G.DrawRectangle(new Pen(destinyBorder), ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width - 1, ClientRectangle.Height - 1);
        }

    }

}

