// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_Nameless.cs" company="Zeroit Dev Technologies">
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
    public partial class UserControl_Nameless : UserControl
    {
        public UserControl_Nameless()
        {
            InitializeComponent();
        }

        private void UserControl_Intel_Load(object sender, EventArgs e)
        {

        }

        private void customNameless_BorderColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_BorderColors0_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessBorderColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNameless_BorderColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_BorderColors1_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessBorderColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNameless_BorderColors2_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_BorderColors2_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessBorderColors[2] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNameless_NoneHighlight0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_NoneHighlight0_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessNoneHighlight[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNameless_NoneHighlight1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_NoneHighlight1_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessNoneHighlight[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNameless_NoneHighlight2_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_NoneHighlight2_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessNoneHighlight[2] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNameless_OverHighlight0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_OverHighlight0_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessOverHighlight[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNameless_OverHighlight1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_OverHighlight1_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessOverHighlight[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNameless_OverHighlight2_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_OverHighlight2_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessOverHighlight[2] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNameless_DownHighlight0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_DownHighlight0_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessDownHighlight[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNameless_DownHighlight1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_DownHighlight1_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessDownHighlight[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNameless_DownHighlight2_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_DownHighlight2_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessDownHighlight[2] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customNameless_Corners_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customNameless_Corners_Btn.BackColor = color.Color;
                previewBtn.CustomNamelessCorners = color.Color;
                previewBtn.Invalidate();
            }
        }
    }
}
