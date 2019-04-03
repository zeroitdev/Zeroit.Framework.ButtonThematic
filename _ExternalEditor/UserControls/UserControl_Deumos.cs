// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_Deumos.cs" company="Zeroit Dev Technologies">
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
    public partial class UserControl_Deumos : UserControl
    {
        public UserControl_Deumos()
        {
            InitializeComponent();
        }

        private void customDeumos_BorderColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDeumos_BorderColors0_Btn.BackColor = color.Color;
                previewBtn.CustomDeumosBorderColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDeumos_BorderColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDeumos_BorderColors1_Btn.BackColor = color.Color;
                previewBtn.CustomDeumosBorderColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDeumos_BorderColors2_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDeumos_BorderColors2_Btn.BackColor = color.Color;
                previewBtn.CustomDeumosBorderColors[2] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDeumos_DownColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDeumos_DownColors0_Btn.BackColor = color.Color;
                previewBtn.CustomDeumosDownStateColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDeumos_DownColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDeumos_DownColors1_Btn.BackColor = color.Color;
                previewBtn.CustomDeumosDownStateColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDeumos_Background_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDeumos_Background_Btn.BackColor = color.Color;
                previewBtn.CustomDeumosBackground = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDeumos_NoneColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDeumos_NoneColors0_Btn.BackColor = color.Color;
                previewBtn.CustomDeumosNoneStateColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDeumos_NoneColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDeumos_NoneColors1_Btn.BackColor = color.Color;
                previewBtn.CustomDeumosNoneStateColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDeumos_Corner_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDeumos_Corner_Btn.BackColor = color.Color;
                previewBtn.CustomDeumosCornerColor = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customDeumos_Over_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customDeumos_Over_Btn.BackColor = color.Color;
                previewBtn.CustomDeumosOverStateColor = color.Color;
                previewBtn.Invalidate();
            }
        }
    }
}
