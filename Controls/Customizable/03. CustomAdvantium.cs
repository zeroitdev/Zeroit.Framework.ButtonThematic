// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="03. CustomAdvantium.cs" company="Zeroit Dev Technologies">
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
        //Color customAdvantiumBack = Color.FromArgb(40, 40, 40);

        //private Color[] customAdvantiumNoneColors = new Color[]
        //{
        //    Color.FromArgb(50, 50, 50),
        //    Color.FromArgb(42, 42, 42)
        //};

        //private Color[] customAdvantiumDownColors = new Color[]
        //{
        //    Color.FromArgb(50, 50, 50),
        //    Color.FromArgb(42, 42, 42)
        //};

        //private Color[] customAdvantiumOverColors = new Color[]
        //{
        //    Color.FromArgb(42, 42, 42),
        //    Color.FromArgb(50, 50, 50)

        //};

        //private Color[] customAdvantiumBorderColors = new Color[]
        //{
        //    Color.FromArgb(59, 59, 59),
        //    Color.FromArgb(25, 25, 25),
        //    Color.FromArgb(35, 35, 35)

        //};

        //private int[] customAdvantiumOffsets = new int[]
        //{
        //    1,
        //    0,
        //    0
        //};
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the custom advantium offsets.
        /// </summary>
        /// <value>The custom advantium offsets.</value>
        [Browsable(false)]
        public int[] CustomAdvantiumOffsets
        {
            get { return buttonInput.CustomAdvantiumOffsets; }
            set { buttonInput.CustomAdvantiumOffsets = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom advantium background.
        /// </summary>
        /// <value>The custom advantium background.</value>
        [Browsable(false)]
        public Color CustomAdvantiumBackground
        {
            get { return buttonInput.CustomAdvantiumBackground; }
            set { buttonInput.CustomAdvantiumBackground = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom advantium none colors.
        /// </summary>
        /// <value>The custom advantium none colors.</value>
        [Browsable(false)]
        public Color[] CustomAdvantiumNoneColors
        {
            get { return buttonInput.CustomAdvantiumNoneColors; }
            set { buttonInput.CustomAdvantiumNoneColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom advantium down colors.
        /// </summary>
        /// <value>The custom advantium down colors.</value>
        [Browsable(false)]
        public Color[] CustomAdvantiumDownColors
        {
            get { return buttonInput.CustomAdvantiumDownColors; }
            set { buttonInput.CustomAdvantiumDownColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom advantium over colors.
        /// </summary>
        /// <value>The custom advantium over colors.</value>
        [Browsable(false)]
        public Color[] CustomAdvantiumOverColors
        {
            get { return buttonInput.CustomAdvantiumOverColors; }
            set { buttonInput.CustomAdvantiumOverColors = value; Invalidate(); }
        }

        /// <summary>
        /// Gets or sets the custom advantium border colors.
        /// </summary>
        /// <value>The custom advantium border colors.</value>
        [Browsable(false)]
        public Color[] CustomAdvantiumBorderColors
        {
            get { return buttonInput.CustomAdvantiumBorderColors; }
            set { buttonInput.CustomAdvantiumBorderColors = value; Invalidate(); }
        }
        #endregion

        #region Paint
        private void CustomAdvantiumPaintHook()
        {
            G.Clear(Color.Red);
            switch (State)
            {
                case MouseState.None:
                    //None
                    DrawGradient(CustomAdvantiumNoneColors[0], CustomAdvantiumNoneColors[1], ClientRectangle, 90);
                    break;
                case MouseState.Down:
                    //Down
                    DrawGradient(CustomAdvantiumDownColors[0], CustomAdvantiumDownColors[1], ClientRectangle, 90);
                    break;
                case MouseState.Over:
                    //Over
                    DrawGradient(CustomAdvantiumOverColors[0], CustomAdvantiumOverColors[1], ClientRectangle, 90);
                    break;
            }
            DrawBorders(new Pen(new SolidBrush(CustomAdvantiumBorderColors[0])), CustomAdvantiumOffsets[0]);
            DrawBorders(new Pen(new SolidBrush(CustomAdvantiumBorderColors[1])), CustomAdvantiumOffsets[1]);
            DrawCorners(CustomAdvantiumBorderColors[2], CustomAdvantiumOffsets[2]);
            //DrawText(new SolidBrush(CustomadvantiumT1), HorizontalAlignment.Center, 0, 0);
        } 
        #endregion

    }
}
