using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{
    public partial class ButtonThematic
    {

        #region Private Fields
        private Color customizableadvancedSystemGlow = Color.FromArgb(40, 95, 210);
        int slope = 5;
        //int customAdvSysGlow = 0;
        private Color customizableAdvSysBackColor = Color.FromArgb(25, 25, 25);
        private Color customAdvSysColorDilution = Color.FromArgb(25, Color.Black);

        #endregion

        #region Public Properties

        public Color CustomizableAdvancedSystemGlow
        {
            get { return customizableadvancedSystemGlow; }
            set
            {
                customizableadvancedSystemGlow = value;
                Invalidate();
            }
        }

        public int CustomizableAdvancedSystemSlope
        {
            get { return slope; }
            set { slope = value; }
        }

        public Color CustomizableAdvSysBackColor
        {
            get { return customizableAdvSysBackColor; }
            set
            {
                customizableAdvSysBackColor = value;
                Invalidate();
            }
        }

        

        public Color CustomAdvSysColorDilution
        {
            get { return customAdvSysColorDilution; }
            set
            {
                customAdvSysColorDilution = value;
                Invalidate();
            }
        }
        #endregion

        #region Paint

        private void CustomizableAdvancedSystemPaint(System.Windows.Forms.PaintEventArgs e)
        {
            G.Clear(Parent.BackColor);

            Rectangle mainRect = new Rectangle(0, 0, Width - 1, Height - 1);
            GraphicsPath mainPath = Draw.RoundRect(mainRect, CustomizableAdvancedSystemSlope);
            G.FillPath(new LinearGradientBrush(mainRect, CustomizableAdvSysBackColor, CustomAdvSysColorDilution, 90f), mainPath);
            G.DrawPath(new Pen(Color.FromArgb(CustomizableAdvSysBackColor.R / 2, CustomizableAdvSysBackColor.G / 2, CustomizableAdvSysBackColor.B / 2)), mainPath);

            int glow = 0;


            if (State == MouseState.Over)
            {
                glow = 200;
            }
            else if (State == MouseState.Down)
            {
                glow = 255;
            }
            else
            {
                glow = 100;
            }
            G.DrawPath(new Pen(Color.FromArgb(glow, customizableadvancedSystemGlow)), mainPath);

            int textX = ((Width - 1) / 2) - Convert.ToInt32((G.MeasureString(Text, Font).Width / 2));
            int textY = ((Height - 1) / 2) - Convert.ToInt32((G.MeasureString(Text, Font).Height / 2));

            //G.DrawString(Text, Font, new SolidBrush(ForeColor), new Point(textX, textY));

        }

        #endregion

    }
}
