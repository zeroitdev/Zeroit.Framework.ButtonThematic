// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_Basic.cs" company="Zeroit Dev Technologies">
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
    public partial class UserControl_Basic : UserControl
    {
        public UserControl_Basic()
        {
            InitializeComponent();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void customBasic_Offset_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.CustomBasicOffset = (int) customBasic_Offset_Numeric.Value;
            previewBtn.Invalidate();
        }

        private void customBasic_Colors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBasic_Colors0_Btn.BackColor = color.Color;
                previewBtn.CustomBasicColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBasic_Colors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBasic_Colors1_Btn.BackColor = color.Color;
                previewBtn.CustomBasicColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBasic_Colors2_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBasic_Colors2_Btn.BackColor = color.Color;
                previewBtn.CustomBasicColors[2] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBasic_Colors3_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBasic_Colors1_Btn.BackColor = color.Color;
                previewBtn.CustomBasicColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBasic_StateColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBasic_StateColors0_Btn.BackColor = color.Color;
                previewBtn.CustomBasicStateColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBasic_StateColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBasic_StateColors1_Btn.BackColor = color.Color;
                previewBtn.CustomBasicStateColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBasic_HighlightColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBasic_HighlightColors0_Btn.BackColor = color.Color;
                previewBtn.CustomBasicHighlights[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBasic_HighlightColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBasic_HighlightColors1_Btn.BackColor = color.Color;
                previewBtn.CustomBasicHighlights[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBasic_HighlightColors2_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBasic_HighlightColors2_Btn.BackColor = color.Color;
                previewBtn.CustomBasicHighlights[2] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBasic_DisabledColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBasic_DisabledColors0_Btn.BackColor = color.Color;
                previewBtn.CustomBasicDisabled[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBasic_DisabledColors2_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBasic_DisabledColors1_Btn.BackColor = color.Color;
                previewBtn.CustomBasicDisabled[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBasic_DisabledColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBasic_DisabledColors1_Btn.BackColor = color.Color;
                previewBtn.CustomBasicDisabled[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBasic_BorderColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBasic_BorderColors0_Btn.BackColor = color.Color;
                previewBtn.CustomBasicBorderColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBasic_BorderColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBasic_BorderColors1_Btn.BackColor = color.Color;
                previewBtn.CustomBasicBorderColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBasic_BorderColors2_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBasic_BorderColors2_Btn.BackColor = color.Color;
                previewBtn.CustomBasicBorderColors[2] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBasic_BorderColors3_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBasic_BorderColors3_Btn.BackColor = color.Color;
                previewBtn.CustomBasicBorderColors[3] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBasic_BorderColors4_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBasic_BorderColors4_Btn.BackColor = color.Color;
                previewBtn.CustomBasicBorderColors[4] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBasic_BorderColors5_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBasic_BorderColors5_Btn.BackColor = color.Color;
                previewBtn.CustomBasicBorderColors[5] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBasic_BorderColors6_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customBasic_BorderColors6_Btn.BackColor = color.Color;
                previewBtn.CustomBasicBorderColors[6] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customBasic_Colors0_Btn_MouseEnter(object sender, EventArgs e)
        {
            customBasic_Colors0_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customBasic_Colors0_Btn_MouseLeave(object sender, EventArgs e)
        {
            customBasic_Colors0_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customBasic_Colors1_Btn_MouseEnter(object sender, EventArgs e)
        {
            customBasic_Colors1_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customBasic_Colors1_Btn_MouseLeave(object sender, EventArgs e)
        {
            customBasic_Colors1_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customBasic_Colors2_Btn_MouseEnter(object sender, EventArgs e)
        {
            customBasic_Colors2_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customBasic_Colors2_Btn_MouseLeave(object sender, EventArgs e)
        {
            customBasic_Colors2_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customBasic_Colors3_Btn_MouseEnter(object sender, EventArgs e)
        {
            customBasic_Colors3_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customBasic_Colors3_Btn_MouseLeave(object sender, EventArgs e)
        {
            customBasic_Colors3_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customBasic_StateColors0_Btn_MouseEnter(object sender, EventArgs e)
        {
            customBasic_StateColors0_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customBasic_StateColors0_Btn_MouseLeave(object sender, EventArgs e)
        {
            customBasic_StateColors0_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customBasic_StateColors1_Btn_MouseEnter(object sender, EventArgs e)
        {
            customBasic_StateColors1_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customBasic_StateColors1_Btn_MouseLeave(object sender, EventArgs e)
        {
            customBasic_StateColors1_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customBasic_HighlightColors0_Btn_MouseEnter(object sender, EventArgs e)
        {
            customBasic_HighlightColors0_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customBasic_HighlightColors0_Btn_MouseLeave(object sender, EventArgs e)
        {
            customBasic_HighlightColors0_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customBasic_HighlightColors1_Btn_MouseEnter(object sender, EventArgs e)
        {
            customBasic_HighlightColors1_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customBasic_HighlightColors1_Btn_MouseLeave(object sender, EventArgs e)
        {
            customBasic_HighlightColors1_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customBasic_HighlightColors2_Btn_MouseHover(object sender, EventArgs e)
        {
            customBasic_HighlightColors2_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customBasic_HighlightColors2_Btn_MouseMove(object sender, MouseEventArgs e)
        {
            customBasic_HighlightColors2_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customBasic_DisabledColors0_Btn_MouseEnter(object sender, EventArgs e)
        {
            customBasic_DisabledColors0_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customBasic_DisabledColors0_Btn_MouseLeave(object sender, EventArgs e)
        {
            customBasic_DisabledColors0_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customBasic_DisabledColors2_Btn_MouseEnter(object sender, EventArgs e)
        {
            customBasic_DisabledColors2_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customBasic_DisabledColors2_Btn_MouseLeave(object sender, EventArgs e)
        {
            customBasic_DisabledColors2_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customBasic_BorderColors0_Btn_MouseEnter(object sender, EventArgs e)
        {
            customBasic_BorderColors0_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customBasic_BorderColors0_Btn_MouseLeave(object sender, EventArgs e)
        {
            customBasic_BorderColors0_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customBasic_BorderColors1_Btn_MouseEnter(object sender, EventArgs e)
        {
            customBasic_BorderColors1_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customBasic_BorderColors1_Btn_MouseLeave(object sender, EventArgs e)
        {
            customBasic_BorderColors1_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customBasic_BorderColors2_Btn_MouseEnter(object sender, EventArgs e)
        {
            customBasic_BorderColors2_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customBasic_BorderColors2_Btn_MouseLeave(object sender, EventArgs e)
        {
            customBasic_BorderColors2_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customBasic_BorderColors3_Btn_MouseEnter(object sender, EventArgs e)
        {
            customBasic_BorderColors3_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customBasic_BorderColors3_Btn_MouseLeave(object sender, EventArgs e)
        {
            customBasic_BorderColors3_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customBasic_BorderColors4_Btn_MouseEnter(object sender, EventArgs e)
        {
            customBasic_BorderColors4_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customBasic_BorderColors4_Btn_MouseLeave(object sender, EventArgs e)
        {
            customBasic_BorderColors4_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customBasic_BorderColors5_Btn_MouseEnter(object sender, EventArgs e)
        {
            customBasic_BorderColors5_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customBasic_BorderColors5_Btn_MouseLeave(object sender, EventArgs e)
        {
            customBasic_BorderColors5_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customBasic_BorderColors6_Btn_MouseEnter(object sender, EventArgs e)
        {
            customBasic_BorderColors6_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customBasic_BorderColors6_Btn_MouseLeave(object sender, EventArgs e)
        {
            customBasic_BorderColors6_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customBasic_DisabledColors1_Btn_MouseEnter(object sender, EventArgs e)
        {
            customBasic_DisabledColors1_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customBasic_DisabledColors1_Btn_MouseLeave(object sender, EventArgs e)
        {
            customBasic_DisabledColors1_Btn.FlatAppearance.BorderSize = 0;
        }
    }
}
