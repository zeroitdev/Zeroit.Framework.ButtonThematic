using System.Drawing;
using Zeroit.Framework.ButtonThematic.ThemeManagers;

namespace Zeroit.Framework.ButtonThematic.Controls
{

    public partial class ButtonThematic
    {


        
        private MouseState _State;
        
        private void HexPaint()
        {
            
            
            G.Clear(Color.FromArgb(30, 33, 40));
            G.DrawPath(new Pen(Color.FromArgb(236, 95, 75)), Draw.RoundRec(new Rectangle(0, 0, Width - 1, Height - 1), 4));
            G.FillPath(new SolidBrush(Color.FromArgb(236, 95, 75)), Draw.RoundRec(new Rectangle(0, 0, Width - 1, Height - 1), 4));

            switch (_State)
            {
                case MouseState.Over:
                    G.DrawPath(new Pen(Color.FromArgb(20, Color.White)), Draw.RoundRec(new Rectangle(0, 0, Width - 1, Height - 1), 4));
                    G.FillPath(new SolidBrush(Color.FromArgb(20, Color.White)), Draw.RoundRec(new Rectangle(0, 0, Width - 1, Height - 1), 4));
                    break;
                case MouseState.Down:
                    G.DrawPath(new Pen(Color.FromArgb(25, Color.Black)), Draw.RoundRec(new Rectangle(0, 0, Width - 1, Height - 1), 4));
                    G.FillPath(new SolidBrush(Color.FromArgb(25, Color.Black)), Draw.RoundRec(new Rectangle(0, 0, Width - 1, Height - 1), 4));
                    break;
            }

            StringFormat _StringF = new StringFormat();
            _StringF.Alignment = StringAlignment.Center;
            _StringF.LineAlignment = StringAlignment.Center;
            //G.DrawString(Text, new Font("Segoe UI", 9), Brushes.White, new RectangleF(0, 0, Width - 1, Height - 1), _StringF);
        }


    }

}

