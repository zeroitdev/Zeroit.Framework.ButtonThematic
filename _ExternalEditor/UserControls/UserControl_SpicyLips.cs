// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_SpicyLips.cs" company="Zeroit Dev Technologies">
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
    public partial class UserControl_SpicyLips : UserControl
    {
        public UserControl_SpicyLips()
        {
            InitializeComponent();
        }

        private void customSpicy_NoneColor0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customSpicy_NoneColor0_Btn.BackColor = color.Color;
                previewBtn.CustomSpicyNoneStateColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customSpicy_NoneColor1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customSpicy_NoneColor1_Btn.BackColor = color.Color;
                previewBtn.CustomSpicyNoneStateColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customSpicy_HoverColor0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customSpicy_HoverColor0_Btn.BackColor = color.Color;
                previewBtn.CustomSpicyOverStateColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customSpicy_HoverColor1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customSpicy_HoverColor1_Btn.BackColor = color.Color;
                previewBtn.CustomSpicyOverStateColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customSpicy_PressedColor0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customSpicy_PressedColor0_Btn.BackColor = color.Color;
                previewBtn.CustomSpicyDownStateColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customSpicy_PressedColor1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customSpicy_PressedColor1_Btn.BackColor = color.Color;
                previewBtn.CustomSpicyDownStateColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customSpicy_Background_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customSpicy_Background_Btn.BackColor = color.Color;
                previewBtn.CustomSpicyBackground = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customSpicy_BorderColor0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customSpicy_BorderColor0_Btn.BackColor = color.Color;
                previewBtn.CustomSpicyBorderColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customSpicy_BorderColor1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customSpicy_BorderColor1_Btn.BackColor = color.Color;
                previewBtn.CustomSpicyBorderColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customSpicy_Corner_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customSpicy_Corner_Btn.BackColor = color.Color;
                previewBtn.CustomSpicyCornerColor = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customSpicy_Highlight_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customSpicy_Highlight_Btn.BackColor = color.Color;
                previewBtn.CustomSpicyHighlight = color.Color;
                previewBtn.Invalidate();
            }
        }
    }
}
