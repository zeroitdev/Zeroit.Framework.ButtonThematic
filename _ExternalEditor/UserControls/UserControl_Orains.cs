// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_Orains.cs" company="Zeroit Dev Technologies">
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
    public partial class UserControl_Orains : UserControl
    {
        public UserControl_Orains()
        {
            InitializeComponent();
        }

        private void customOrains_Color0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customOrains_Color0_Btn.BackColor = color.Color;
                previewBtn.CustomOrainsButton[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customOrains_Color1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customOrains_Color1_Btn.BackColor = color.Color;
                previewBtn.CustomOrainsButton[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customOrains_Hatch0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customOrains_Hatch0_Btn.BackColor = color.Color;
                previewBtn.CustomOrainsHatch[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customOrains_Hatch1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customOrains_Hatch1_Btn.BackColor = color.Color;
                previewBtn.CustomOrainsHatch[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customOrains_Header_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customOrains_Header_Btn.BackColor = color.Color;
                previewBtn.CustomOrainsHeader = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customOrains_InnerBorder_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customOrains_InnerBorder_Btn.BackColor = color.Color;
                previewBtn.CustomOrainsInnerBorder = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customOrains_OuterBorder_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customOrains_OuterBorder_Btn.BackColor = color.Color;
                previewBtn.CustomOrainsOuterBorder = color.Color;
                previewBtn.Invalidate();
            }
        }
    }
}
