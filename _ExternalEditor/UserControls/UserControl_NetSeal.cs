// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_NetSeal.cs" company="Zeroit Dev Technologies">
//     Copyright © Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Zeroit.Framework.ButtonThematic.Controls
{
    [ToolboxItem(false)]
    public partial class UserControl_NetSeal : UserControl
    {
        public UserControl_NetSeal()
        {
            InitializeComponent();
        }

        private void customNetSeal_FocusScale1_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.CustomFocusScales = new PointF((float)customNetSeal_FocusScale1_Numeric.Value,
                (float)customNetSeal_FocusScale2_Numeric.Value);

            previewBtn.Invalidate();
        }

        private void customNetSeal_FocusScale2_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.CustomFocusScales = new PointF((float)customNetSeal_FocusScale1_Numeric.Value,
                (float)customNetSeal_FocusScale2_Numeric.Value);

            previewBtn.Invalidate();
        }

        private void customNetSeal_PathBorder0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNetSeal_PathBorder0_Btn.BackColor = color.Color;
                previewBtn.CustomNetSealPathBorders[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNetSeal_PathBorder1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNetSeal_PathBorder1_Btn.BackColor = color.Color;
                previewBtn.CustomNetSealPathBorders[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNetSeal_Centre_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNetSeal_Centre_Btn.BackColor = color.Color;
                previewBtn.CustomNetSealCenterColor = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNetSeal_Surround_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNetSeal_Surround_Btn.BackColor = color.Color;
                previewBtn.CustomNetSealSurroundColor = color.Color;
                previewBtn.Invalidate();
            }
        }
    }
}
