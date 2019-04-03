using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.BaseContainer;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{
    /// <summary>
    /// Class AresioButton.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Control" />
    public partial class ButtonThematic
    {

        #region Private Fields

        private Color[] customAresioBorderColors = new Color[]
        {
            Color.FromArgb(50,Color.White),
            Color.FromArgb(150, 100, 70)
        };

        
        private Color[] customAresioNoneColors = new Color[]
        {
            Color.FromArgb(250, 200, 70),
            Color.FromArgb(250, 160, 40)
        };

        private Color[] customAresioOverColors = new Color[]
        {
            Color.FromArgb(50, Color.White),
            Color.Transparent
        };

        private Color[] customAresioDownColors = new Color[]
        {
            Color.FromArgb(50, Color.Black),
            Color.Transparent
        };
        #endregion

        #region Public Properties
        public Color[] CustomAresioBorderColors
        {
            get { return customAresioBorderColors; }
            set
            {
                customAresioBorderColors = value;
                Invalidate();
            }
        }

        //public int CustomAresioCurve
        //{
        //    get { return Curve; }
        //    set
        //    {
        //        Curve = value;
        //        Invalidate();
        //    }
        //}

        public Color[] CustomAresioNoneColors
        {
            get { return customAresioNoneColors; }
            set { customAresioNoneColors = value; Invalidate(); }
        }

        public Color[] CustomAresioOverColors
        {
            get { return customAresioOverColors; }
            set { customAresioOverColors = value; Invalidate(); }
        }

        public Color[] CustomAresioDownColors
        {
            get { return customAresioDownColors; }
            set
            {
                customAresioDownColors = value;
                Invalidate();
            }
        }

        #endregion

        #region Paint

        private void CustomAresioPaint(System.Windows.Forms.PaintEventArgs e)
        {
            G.Clear(Parent.BackColor);

            G.DrawPath(DesignFunctions.ToPen(CustomAresioBorderColors[0]), DesignFunctions.RoundRect(0, 1, Width - 1, Height - 2, Curve));
            G.DrawPath(DesignFunctions.ToPen(CustomAresioBorderColors[1]), DesignFunctions.RoundRect(0, 0, Width - 1, Height - 1, Curve));
            switch (Enabled)
            {
                case true:
                    switch (State)
                    {
                        case MouseState.None:
                            G.FillPath(new LinearGradientBrush(new Point(0, 0), new Point(0, Height), CustomAresioNoneColors[0], CustomAresioNoneColors[1]), DesignFunctions.RoundRect(0, 0, Width - 1, Height - 1, Curve));
                            break;
                        case MouseState.Over:
                            G.FillPath(new LinearGradientBrush(new Point(0, 0), new Point(0, Height), CustomAresioOverColors[0], CustomAresioOverColors[1]), DesignFunctions.RoundRect(0, 0, Width - 1, Height - 1, Curve));
                            break;
                        case MouseState.Down:
                            G.FillPath(new LinearGradientBrush(new Point(0, 0), new Point(0, Height), CustomAresioDownColors[0], CustomAresioDownColors[1]), DesignFunctions.RoundRect(0, 0, Width - 1, Height - 1, Curve));
                            break;
                    }

                    break;
                case false:
                    //G.DrawString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular), Brushes.White, new Point(Convert.ToInt32((Width / 2) - (G.MeasureString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Width / 2)) + 1, Convert.ToInt32((Height / 2) - (G.MeasureString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Height / 2)) + 1));
                    //G.DrawString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular), Brushes.Gray, new Point(Convert.ToInt32((Width / 2) - (G.MeasureString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Width / 2)), Convert.ToInt32((Height / 2) - (G.MeasureString(Text, new Font(Font.FontFamily, Font.Size, FontStyle.Regular)).Height / 2))));
                    break;
            }

        }

        #endregion

    }


}
