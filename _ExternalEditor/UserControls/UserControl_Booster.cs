// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_Booster.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
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
