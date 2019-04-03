// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="BloodyButton.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {
        Color bloodyButtonColor = Color.WhiteSmoke;
        Color bloodyBorder = Color.Black;

        ColorBlend bicouleur = new ColorBlend(2);

        [Browsable(false)]
        public Color BloodyButtonColor
        {
            get { return bloodyButtonColor; }
            set { bloodyButtonColor = value; }
        }

        [Browsable(false)]
        public Color BloodyBorder
        {
            get { return bloodyBorder; }
            set { bloodyBorder = value; }
        }

        private void BloodyPaint()
        {
            G.Clear(bloodyButtonColor);
            switch (State)
            {
                case MouseState.None:


                    bicouleur.Colors[0] = Color.FromArgb(255, 40, 0, 0);
                    //Rouge foncé
                    bicouleur.Colors[1] = Color.FromArgb(240, 90, 0, 0);
                    //Rouge
                    bicouleur.Positions[0] = 0;
                    bicouleur.Positions[1] = 1;
                    DrawGradient(bicouleur, new Rectangle(0, 0, Width, Height));
                    bicouleur.Colors[0] = Color.FromArgb(0, 0, 0, 0);
                    bicouleur.Colors[1] = Color.FromArgb(40, Color.White);
                    G.DrawRectangle(new Pen(bloodyBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;


                case MouseState.Over:

                    bicouleur.Colors[0] = Color.FromArgb(235, 40, 0, 0);
                    //Rouge foncé
                    bicouleur.Colors[1] = Color.FromArgb(200, 90, 0, 0);
                    //Rouge
                    bicouleur.Positions[0] = 0;
                    bicouleur.Positions[1] = 1;
                    DrawGradient(bicouleur, new Rectangle(0, 0, Width, Height));
                    bicouleur.Colors[0] = Color.FromArgb(0, 0, 0, 0);
                    bicouleur.Colors[1] = Color.FromArgb(40, Color.White);
                    G.DrawRectangle(new Pen(bloodyBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;

                case MouseState.Down:

                    bicouleur.Colors[0] = Color.FromArgb(205, 40, 0, 0);
                    //Rouge foncé
                    bicouleur.Colors[1] = Color.FromArgb(185, 90, 0, 0);
                    //Rouge
                    bicouleur.Positions[0] = 0;
                    bicouleur.Positions[1] = 1;
                    DrawGradient(bicouleur, new Rectangle(0, 0, Width, Height));
                    bicouleur.Colors[0] = Color.FromArgb(0, 0, 0, 0);
                    bicouleur.Colors[1] = Color.FromArgb(40, Color.White);
                    G.DrawRectangle(new Pen(bloodyBorder), new Rectangle(0, 0, Width - 1, Height - 1));
                    //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

                    break;
            }
        }

    }


}
