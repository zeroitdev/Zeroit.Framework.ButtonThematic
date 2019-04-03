// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_Recon.cs" company="Zeroit Dev Technologies">
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
    public partial class UserControl_Recon : UserControl
    {
        public UserControl_Recon()
        {
            InitializeComponent();
        }

        private void customRecon_NoneColor0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customRecon_NoneColor0_Btn.BackColor = color.Color;
                previewBtn.CustomReconNoneStateColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customRecon_NoneColor1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customRecon_NoneColor1_Btn.BackColor = color.Color;
                previewBtn.CustomReconNoneStateColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customRecon_Background_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customRecon_Background_Btn.BackColor = color.Color;
                previewBtn.CustomReconBackground = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customRecon_OverColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customRecon_OverColors0_Btn.BackColor = color.Color;
                previewBtn.CustomReconOverStateColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customRecon_OverColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customRecon_OverColors1_Btn.BackColor = color.Color;
                previewBtn.CustomReconOverStateColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customRecon_OverColors2_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customRecon_OverColors2_Btn.BackColor = color.Color;
                previewBtn.CustomReconOverStateColors[2] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customRecon_OverColors3_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customRecon_OverColors3_Btn.BackColor = color.Color;
                previewBtn.CustomReconOverStateColors[3] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customRecon_DownColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customRecon_DownColors0_Btn.BackColor = color.Color;
                previewBtn.CustomReconDownStateColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customRecon_DownColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customRecon_DownColors1_Btn.BackColor = color.Color;
                previewBtn.CustomReconDownStateColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customRecon_DownColors2_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customRecon_DownColors2_Btn.BackColor = color.Color;
                previewBtn.CustomReconDownStateColors[2] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customRecon_DownColors3_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customRecon_DownColors3_Btn.BackColor = color.Color;
                previewBtn.CustomReconDownStateColors[3] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customRecon_BorderColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customRecon_BorderColors0_Btn.BackColor = color.Color;
                previewBtn.CustomReconBorder[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customRecon_BorderColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customRecon_BorderColors1_Btn.BackColor = color.Color;
                previewBtn.CustomReconBorder[1] = color.Color;
                previewBtn.Invalidate();
            }
        }
    }
}
