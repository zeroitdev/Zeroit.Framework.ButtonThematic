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

    public partial class ButtonThematic
    {

        #region Private Fields
        private Color[] customBasicColors = new Color[]
        {
            Color.FromArgb(255, 55, 55, 55),
            Color.FromArgb(255, 22, 22, 22),
            Color.FromArgb(255, 100, 0, 0),
            Color.FromArgb(255, 60, 0, 0)
        };

        private Color[] customBasicStateColors = new Color[]
        {
            Color.FromArgb(255, 60, 0, 0),
            Color.FromArgb(255, 100, 0, 0)
        };

        private Color[] customBasicHighlights = new Color[]
        {
            Color.FromArgb(25, 255, 255, 255),
            Color.FromArgb(25, 255, 255, 255),
            Color.FromArgb(25, 255, 255, 255)
        };

        private Color[] customBasicBorderColors = new Color[]
        {
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black,
            Color.Black
        };

        private Color[] customBasicDisabled = new Color[]
        {
            Color.FromArgb(255, 40, 40, 40),
            Color.FromArgb(255, 20, 20, 20),
            Color.FromArgb(13, 255, 255, 255)
        };

        
        private int customBasicOffset = 3;
        #endregion
        
        #region Public Properties
        public Color[] CustomBasicBorderColors
        {
            get { return customBasicBorderColors; }
            set
            {
                customBasicBorderColors = value;
                Invalidate();
            }
        }

        public Color[] CustomBasicStateColors
        {
            get { return customBasicStateColors; }
            set
            {
                customBasicStateColors = value;
                Invalidate();
            }
        }

        public Color[] CustomBasicColors
        {
            get { return customBasicColors; }
            set
            {
                customBasicColors = value;
                Invalidate();
            }
        }

        public Color[] CustomBasicHighlights
        {
            get { return customBasicHighlights; }
            set
            {
                customBasicHighlights = value;
                Invalidate();
            }
        }

        public Color[] CustomBasicDisabled
        {
            get { return customBasicDisabled; }
            set
            {
                customBasicDisabled = value;
                Invalidate();
            }
        }

        public int CustomBasicOffset
        {
            get { return customBasicOffset; }
            set
            {
                customBasicOffset = value;
                Invalidate();
            }
        } 
        #endregion

        #region Paint

        private void CustomBasicPaint()
        {
            GraphicsPath customBasicBPath;
            GraphicsPath customBasicTPath;
            Point[] customBasicBITPoints;
            Rectangle customBasicBRect;
            Rectangle customBasicTRect;
            Rectangle customBasicBIRect;
            LinearGradientBrush customBasicBBrush;
            LinearGradientBrush customBasicBIBrush;

            customBasicBRect = new Rectangle(0, 0, ClientRectangle.Width - 1, ClientRectangle.Height - 1);
            customBasicTRect = new Rectangle(0, 0, ClientRectangle.Width - 2, Convert.ToInt32(ClientRectangle.Height / 2));
            customBasicBITPoints = new Point[] {
                new Point(4, 4),
                new Point(ClientRectangle.Width - 4, 4),
                new Point(ClientRectangle.Width - 4, ClientRectangle.Height - 4),
                new Point(4, ClientRectangle.Height - 4),
                new Point(4, 4)
            };
            customBasicBIRect = new Rectangle(3, 3, ClientRectangle.Width - 4, ClientRectangle.Height - 4);
            customBasicBBrush = new LinearGradientBrush(ClientRectangle, CustomBasicColors[0], CustomBasicColors[1], LinearGradientMode.Vertical);
            customBasicBIBrush = new LinearGradientBrush(customBasicBIRect, CustomBasicColors[2], CustomBasicColors[3], LinearGradientMode.Vertical);

            switch (State)
            {
                case MouseState.Over:
                    customBasicBIBrush = new LinearGradientBrush(customBasicBIRect, CustomBasicStateColors[0], CustomBasicStateColors[1], LinearGradientMode.Vertical);
                    G.FillRectangle(customBasicBBrush, customBasicBRect);
                    G.DrawRectangle(new Pen(CustomBasicBorderColors[0]), customBasicBRect);
                    G.FillPolygon(customBasicBIBrush, customBasicBITPoints);
                    DrawBorders(new Pen(CustomBasicBorderColors[1]), CustomBasicOffset);
                    G.FillRectangle(new SolidBrush(CustomBasicHighlights[0]), customBasicTRect);
                    break;
                case MouseState.Down:
                    G.FillRectangle(customBasicBBrush, customBasicBRect);
                    G.DrawRectangle(new Pen(CustomBasicBorderColors[2]), customBasicBRect);
                    G.FillPolygon(customBasicBIBrush, customBasicBITPoints);
                    DrawBorders(new Pen(CustomBasicBorderColors[3]), CustomBasicOffset);
                    G.FillRectangle(new SolidBrush(CustomBasicHighlights[1]), customBasicTRect);
                    break;
                case MouseState.None:
                    G.FillRectangle(customBasicBBrush, customBasicBRect);
                    G.DrawRectangle(new Pen(CustomBasicBorderColors[4]), customBasicBRect);
                    G.FillPolygon(customBasicBIBrush, customBasicBITPoints);
                    DrawBorders(new Pen(CustomBasicBorderColors[5]), CustomBasicOffset);
                    G.FillRectangle(new SolidBrush(CustomBasicHighlights[2]), customBasicTRect);
                    break;
            }

            //DrawText(new SolidBrush(ForeColor), HorizontalAlignment.Center, 0, 0);

            if (Enabled == false)
            {
                customBasicBIBrush = new LinearGradientBrush(customBasicBIRect, CustomBasicDisabled[0], CustomBasicDisabled[1], LinearGradientMode.Vertical);
                G.FillRectangle(customBasicBBrush, customBasicBRect);
                G.DrawRectangle(new Pen(CustomBasicBorderColors[6]), customBasicBRect);
                G.FillPolygon(customBasicBIBrush, customBasicBITPoints);
                DrawBorders(new Pen(CustomBasicBorderColors[7]), CustomBasicOffset);
                G.FillRectangle(new SolidBrush(CustomBasicDisabled[2]), customBasicTRect);
                //DrawText(Brushes.Gray, HorizontalAlignment.Center, 0, 0);
            }
            else
            {
            }
        }

        #endregion

    }

}
