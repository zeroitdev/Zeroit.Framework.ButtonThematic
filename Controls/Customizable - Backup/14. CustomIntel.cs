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
        private int customIntelGlow = 180;
        private Color customIntelBackgroundColor = Color.SteelBlue;
        private Color customIntelBorderColor = Color.DeepSkyBlue;
        private Color customIntelShade = Color.Black;
        private int customIntelCurve = 8;
        #endregion

        #region Public Properties
        public int CustomIntelGlow
        {
            get { return customIntelGlow; }
            set
            {
                customIntelGlow = value;
                Invalidate();
            }
        }

        public Color CustomIntelBackgroundColor
        {
            get { return customIntelBackgroundColor; }
            set { customIntelBackgroundColor = value; Invalidate(); }
        }

        public Color CustomIntelBorderColor
        {
            get { return customIntelBorderColor; }
            set { customIntelBorderColor = value; Invalidate(); }
        }

        public Color CustomIntelShade
        {
            get { return customIntelShade; }
            set { customIntelShade = value; Invalidate(); }
        }

        public int CustomIntelCurve
        {
            get { return customIntelCurve; }
            set
            {
                customIntelCurve = value;
                Invalidate();
            }
        } 
        #endregion

        #region Paint and Private Methods
        public void CustomiButton()
        {
            IsAnimated = true;

        }

        private void CustomIntelPaintHook()
        {
            //G.Clear(Color.FromArgb(45, 45, 45));

            G.Clear(Parent.BackColor);

            GraphicsPath gp = CreateRound(new Rectangle(0, 0, Width - 1, Height - 1), CustomIntelCurve);
            PathGradientBrush pgb = new PathGradientBrush(gp);

            G.FillPath(new SolidBrush(customIntelShade), gp);

            pgb.CenterColor = Color.FromArgb(200, CustomIntelBackgroundColor);
            pgb.SurroundColors = new Color[] { Color.FromArgb(customIntelGlow, CustomIntelBackgroundColor) };
            pgb.CenterPoint = new Point((this.Width - 1) / 2, (this.Height - 1) / 2);

            G.FillPath(pgb, gp);
            G.DrawPath(new Pen(CustomIntelBorderColor), gp);

            int textWidth = (int)this.CreateGraphics().MeasureString(Text, Font).Width;
            int textHeight = (int)this.CreateGraphics().MeasureString(Text, Font).Height;
            SolidBrush textShadow = new SolidBrush(Color.FromArgb(30, 15, 0));
            Rectangle textRect = new Rectangle(3, 3, textWidth + 10, textHeight);
            Point textPoint = new Point((Width / 2) - (textWidth / 2), (Height / 2) - (textHeight / 2));
            Point textShadowPoint = new Point((Width / 2) - (textWidth / 2) + 1, (Height / 2) - (textHeight / 2) + 1);

            //G.DrawString(Text, Font, textShadow, textShadowPoint);
            //G.DrawString(Text, Font, Brushes.WhiteSmoke, textPoint);

        }

        private void CustomIntelOnAnimation()
        {
            if (State == MouseState.Over)
            {
                if (customIntelGlow < 230)
                    customIntelGlow += 1;
            }
            else
            {
                if (customIntelGlow > 182)
                {
                    customIntelGlow -= 2;
                }
                else if (customIntelGlow > 180 & customIntelGlow < 182)
                {
                    customIntelGlow = 180;
                }
            }
        }

        #endregion

    }

}

