// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="Adobe.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Drawing;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{
    /// <summary>
    /// Class ButtonThematic.
    /// </summary>
    /// <seealso cref="Zeroit.Framework.ButtonThematic.ThemeManagers.ThemeControl" />
    public partial class ButtonThematic
    {



        #region " Properties "

        /// <summary>
        /// The adobe alternate
        /// </summary>
        private bool adobeAlternate = false;
        /// <summary>
        /// Gets or sets a value indicating whether [adobe alternate].
        /// </summary>
        /// <value><c>true</c> if [adobe alternate]; otherwise, <c>false</c>.</value>
        [Browsable(false)]
        public bool AdobeAlternate
        {
            get { return adobeAlternate; }
            set { adobeAlternate = value; }
        }

        #endregion

        /// <summary>
        /// Adobes the paint hook.
        /// </summary>
        private void AdobePaintHook()
        {
            G.Clear(Color.FromArgb(102, 102, 102));

            Rectangle R1 = new Rectangle(0, 0, Width, Height);                                          //
                                                                                                        //
            PointF ipt = ImageLocation(GetStringFormat(ImageAlign), Size, ImageSize);                   //
                                                                                                        //


            int gC = 15;
            Color _text = Color.White;
            Color C1 = default(Color);
            Color C2 = default(Color);
            Color C3 = default(Color);
            Color C4 = default(Color);

            switch (AdobeAlternate)
            {
                case true:
                    C1 = Color.FromArgb(255, 209, 51);
                    C2 = Color.FromArgb(255, 165, 13);
                    C3 = Color.FromArgb(255, 195, 13);
                    C4 = Color.FromArgb(255, 163, 0);
                    break;
                case false:
                    C1 = Color.FromArgb(105, 105, 105);
                    C2 = Color.FromArgb(56, 56, 56);
                    C3 = Color.FromArgb(73, 73, 73);
                    C4 = Color.FromArgb(48, 48, 48);
                    break;
            }

            DrawGradient(C1, C2, 0, 0, Width, Height, 90);
            DrawGradient(C3, C4, 1, 1, Width - 2, Height - 2, 90);

            switch (State)
            {
                case MouseState.None:
                    break;
                //NULL
                case MouseState.Over:
                    switch (AdobeAlternate)
                    {
                        case true:
                            _text = Color.Black;
                            break;
                    }
                    gC = 5;
                    break;
                case MouseState.Down:
                    switch (AdobeAlternate)
                    {
                        case true:
                            _text = Color.White;
                            break;
                    }
                    gC = 10;
                    break;
            }

            for (int i = 1; i <= 5; i++)
            {
                G.DrawRectangle(new Pen(new SolidBrush(Color.FromArgb(Convert.ToInt32(255 / (i * gC)), Color.White))), new Rectangle(i, i, Width - 2 - (i * 2), Height - 2 - (i * 2)));
            }

            DrawBorders(Pens.Black);
            //DrawText(Draw.ConvertToBrush(Color.FromArgb(180, Color.Black)), HorizontalAlignment.Center, 0, 2);
            //DrawText(Draw.ConvertToBrush(_text), HorizontalAlignment.Center, -1, 1);

            
        }

    }
}
