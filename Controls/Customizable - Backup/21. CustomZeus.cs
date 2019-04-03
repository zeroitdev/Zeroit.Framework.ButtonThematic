using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.BaseContainer;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {

        #region Private Fields
        Color customZeusBackground = Color.FromArgb(38, 38, 38);

        private Color[] customZeusGradientColors = new Color[]
        {
            Color.AliceBlue,
            Color.FromArgb(150, 255, 255)
        };

        private Color[] customZeusBorderColors = new Color[]
        {
            Color.Black,
            Color.AliceBlue
        };

        private int customZeusClickReduce = 5;

        private int customZeusClickLocate = 2;
        #endregion

        #region Public Properties
        public Color CustomZeusBackground
        {
            get { return customZeusBackground; }
            set
            {
                customZeusBackground = value;
                Invalidate();
            }
        }

        public Color[] CustomZeusGradientColors
        {
            get { return customZeusGradientColors; }
            set
            {
                customZeusGradientColors = value;
                Invalidate();
            }
        }

        public Color[] CustomZeusBorderColors
        {
            get { return customZeusBorderColors; }
            set
            {
                customZeusBorderColors = value;
                Invalidate();
            }
        }

        public int CustomZeusClickReduce
        {
            get { return customZeusClickReduce; }
            set { customZeusClickReduce = value;
                Invalidate();
            }
        }

        public int CustomZeusClickLocate
        {
            get { return customZeusClickLocate; }
            set { customZeusClickLocate = value;
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

