// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="21. CustomZeus.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
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

        #region Private Fields
        //Color customZeusBackground = Color.FromArgb(38, 38, 38);

        //private Color[] customZeusGradientColors = new Color[]
        //{
        //    Color.AliceBlue,
        //    Color.FromArgb(150, 255, 255)
        //};

        //private Color[] customZeusBorderColors = new Color[]
        //{
        //    Color.Black,
        //    Color.AliceBlue
        //};

        //private int customZeusClickReduce = 5;

        //private int customZeusClickLocate = 2;
        #endregion

        #region Public Properties
        [Browsable(false)]
        public Color CustomZeusBackground
        {
            get { return buttonInput.CustomZeusBackground; }
            set
            {
                buttonInput.CustomZeusBackground = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] CustomZeusGradientColors
        {
            get { return buttonInput.CustomZeusGradientColors; }
            set
            {
                buttonInput.CustomZeusGradientColors = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public Color[] CustomZeusBorderColors
        {
            get { return buttonInput.CustomZeusBorderColors; }
            set
            {
                buttonInput.CustomZeusBorderColors = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public int CustomZeusClickReduce
        {
            get { return buttonInput.CustomZeusClickReduce; }
            set {
                buttonInput.CustomZeusClickReduce = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        public int CustomZeusClickLocate
        {
            get { return buttonInput.CustomZeusClickLocate; }
            set {
                buttonInput.CustomZeusClickLocate = value;
                Invalidate();
            }
        }

        #endregion

        #region Paint

        private void CustomZeusPaintHook()
        {

            switch (State)
            {

                case MouseState.None:
                    G.Clear(CustomZeusBackground);
                    DrawGradient(CustomZeusGradientColors[0], CustomZeusGradientColors[1], 0, 0, Width, Height, 90);
                    //DrawText(HorizontalAlignment.Center, CustomZeusBackground, 0);
                    DrawBorders(new Pen(CustomZeusBorderColors[0]), new Pen(CustomZeusBorderColors[1]), ClientRectangle);
                    break;
                case MouseState.Over:
                    G.Clear(CustomZeusBackground);
                    DrawGradient(CustomZeusGradientColors[0], CustomZeusGradientColors[1], 0, 0, Width, Height, 90);
                    //DrawText(HorizontalAlignment.Center, CustomZeusBackground, 0);
                    DrawBorders(new Pen(CustomZeusBorderColors[0]), new Pen(CustomZeusBorderColors[1]), ClientRectangle);
                    break;
                case MouseState.Down:
                    G.Clear(CustomZeusBackground);
                    DrawGradient(CustomZeusGradientColors[0], CustomZeusGradientColors[1], 0, 0, Width - (CustomZeusClickLocate / 2), Height - (CustomZeusClickLocate / 2), 90);
                    G.DrawRectangle(new Pen(CustomZeusBorderColors[0]), CustomZeusClickLocate, CustomZeusClickLocate, Width - CustomZeusClickReduce, Height - CustomZeusClickReduce);
                    //DrawText(HorizontalAlignment.Center, CustomZeusBackground, 0);
                    DrawBorders(new Pen(CustomZeusBorderColors[0]), new Pen(CustomZeusBorderColors[1]), ClientRectangle);
                    break;
            }

        }

        #endregion
        
    }

}

