// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_Booster.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Button control.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Zeroit.Framework.ButtonThematic.Controls
{
    [ToolboxItem(false)]
    public partial class UserControl_Booster : UserControl
    {
        public UserControl_Booster()
        {
            InitializeComponent();
        }

        private void customBooster_Colors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBooster_Colors0_Btn.BackColor = color.Color;
                previewBtn.CustomBoosterColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBooster_Colors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBooster_Colors1_Btn.BackColor = color.Color;
                previewBtn.CustomBoosterColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBooster_BorderColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBooster_BorderColors0_Btn.BackColor = color.Color;
                previewBtn.CustomBoosterInnerBorder = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBooster_BorderColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBooster_BorderColors1_Btn.BackColor = color.Color;
                previewBtn.CustomBoosterOuterBorder = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBooster_HatchColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBooster_HatchColors0_Btn.BackColor = color.Color;
                previewBtn.CustomBoosterHatchColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBooster_HatchColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBooster_HatchColors1_Btn.BackColor = color.Color;
                previewBtn.CustomBoosterHatchColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBooster_InfluenceOuter_Yes_RadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (customBooster_InfluenceOuter_Yes_RadioBtn.Checked == true)
            {
                previewBtn.CustomBoosterInfluenceOuter = true;
                previewBtn.Invalidate();
            }
            else
            {
                previewBtn.CustomBoosterInfluenceOuter = false;
                previewBtn.Invalidate();
            }
        }

        private void customBooster_UpperLeftCurve_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.UpperLeftCurve = (int)customBooster_UpperLeftCurve_Numeric.Value;
            previewBtn.Invalidate();
        }

        private void customBooster_UpperRightCurve_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.UpperRightCurve = (int)customBooster_UpperRightCurve_Numeric.Value;
            previewBtn.Invalidate();
        }

        private void customBooster_DownLeftCurve_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.DownLeftCurve = (int)customBooster_DownLeftCurve_Numeric.Value;
            previewBtn.Invalidate();
        }

        private void customBooster_DownRightCurve_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.DownRightCurve = (int)customBooster_DownRightCurve_Numeric.Value;
            previewBtn.Invalidate();
        }

        private void customBooster_Offset_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.CustomBoosterOffset = (int)customBooster_Offset_Numeric.Value;
            previewBtn.Invalidate();
        }

        private void customBooster_HoverTransparency_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.CustomBoosterHoverTransparency = (int)customBooster_HoverTransparency_Numeric.Value;
            previewBtn.Invalidate();
        }

        private void customBooster_GradientAngle_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.CustomBoosterGradientAngle = (int)customBooster_GradientAngle_Numeric.Value;
            previewBtn.Invalidate();
        }
    }
}
