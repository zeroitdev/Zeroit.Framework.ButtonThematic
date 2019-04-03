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
        private Color[] customRoasterGradientColors = new Color[]
        {
            Color.FromArgb(0, 0, 0),
            Color.FromArgb(95, 0, 0),
            Color.FromArgb(73, 73, 73),
            Color.FromArgb(93, 93, 93)
        };

        private Color customRoasterBorderColor = Color.Black;

        private Color[] customRoasterBackgroundStateColors = new Color[]
        {
            Color.White,
            Color.Black
        };
        #endregion
        
        #region Public Properties
        public Color[] CustomRoasterGradientColors
        {
            get { return customRoasterGradientColors; }
            set
            {
                customRoasterGradientColors = value;
                Invalidate();
            }
        }

        public Color CustomRoasterBorderColor
        {
            get { return customRoasterBorderColor; }
            set
            {
                customRoasterBorderColor = value;
                Invalidate();
            }
        }

        public Color[] CustomRoasterBackgroundStateColors
        {
            get { return customRoasterBackgroundStateColors; }
            set
            {
                customRoasterBackgroundStateColors = value;
                Invalidate();
            }
        }
        #endregion

        #region Paint
        private void CustomRoasterPaintHook()
        {
            G.Clear(Parent.BackColor);
            DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[1], 0, 2, Width / 2, Height / 2, 45);
            DrawGradient(CustomRoasterGradientColors[1], CustomRoasterGradientColors[0], Width / 2, 2, Width - 15, Height / 2, -45);
            DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[1], 0, Height / 2, Width / 2, Height, 45);
            DrawGradient(CustomRoasterGradientColors[1], CustomRoasterGradientColors[0], Width / 2, Height / 2, Width, Height / 2, 315);

            DrawBorders(new Pen(CustomRoasterBorderColor), 0);
            DrawBorders(new Pen(CustomRoasterBorderColor), 1);
            DrawBorders(new Pen(CustomRoasterGradientColors[1]), 3);
            G.DrawLine(new Pen(CustomRoasterGradientColors[3]), 3, 3, Width - 5, 3);
            G.DrawLine(new Pen(CustomRoasterGradientColors[2]), 0, Height - 1, Width, Height - 1);
            DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[2], 0, 0, 1, Height);
            DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[2], Width - 1, 0, 1, Height);

            if (State == MouseState.Over)
            {
                DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[1], 0, 2, Width / 2, Height / 2, 45);
                DrawGradient(CustomRoasterGradientColors[1], CustomRoasterGradientColors[0], Width / 2, 2, Width - 15, Height / 2, -45);
                DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[1], 0, Height / 2, Width / 2, Height, 45);
                DrawGradient(CustomRoasterGradientColors[1], CustomRoasterGradientColors[0], Width / 2, Height / 2, Width, Height / 2, 315);
                G.FillRectangle(new SolidBrush(Color.FromArgb(13, CustomRoasterBackgroundStateColors[0])), 0, 0, Width, (Height / 2) - 7);
                DrawBorders(new Pen(CustomRoasterBorderColor), 0);
                DrawBorders(new Pen(CustomRoasterBorderColor), 1);
                DrawBorders(new Pen(CustomRoasterGradientColors[1]), 3);
                G.DrawLine(new Pen(CustomRoasterGradientColors[3]), 3, 3, Width - 5, 3);
                G.DrawLine(new Pen(CustomRoasterGradientColors[2]), 0, Height - 1, Width, Height - 1);
                DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[2], 0, 0, 1, Height);
                DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[2], Width - 1, 0, 1, Height);
            }
            else if (State == MouseState.Down)
            {
                DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[1], 0, 2, Width / 2, Height / 2, 45);
                DrawGradient(CustomRoasterGradientColors[1], CustomRoasterGradientColors[0], Width / 2, 2, Width - 15, Height / 2, -45);
                DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[1], 0, Height / 2, Width / 2, Height, 45);
                DrawGradient(CustomRoasterGradientColors[1], CustomRoasterGradientColors[0], Width / 2, Height / 2, Width, Height / 2, 315);
                G.FillRectangle(new SolidBrush(Color.FromArgb(20, CustomRoasterBackgroundStateColors[1])), 0, 0, Width, (Height / 2) - 7);
                DrawBorders(new Pen(CustomRoasterBorderColor), 0);
                DrawBorders(new Pen(CustomRoasterBorderColor), 1);
                DrawBorders(new Pen(CustomRoasterGradientColors[1]), 3);
                G.DrawLine(new Pen(CustomRoasterGradientColors[3]), 3, 3, Width - 5, 3);
                G.DrawLine(new Pen(CustomRoasterGradientColors[2]), 0, Height - 1, Width, Height - 1);
                DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[2], 0, 0, 1, Height);
                DrawGradient(CustomRoasterGradientColors[0], CustomRoasterGradientColors[2], Width - 1, 0, 1, Height);
            }
            else
            {
            }

            DrawCorners(BackColor);
            //DrawText(Brushes.White, HorizontalAlignment.Center, 0, 0);

        } 
        #endregion

    }

}
