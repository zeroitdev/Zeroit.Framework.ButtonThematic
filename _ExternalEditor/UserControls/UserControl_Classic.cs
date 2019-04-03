// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_Classic.cs" company="Zeroit Dev Technologies">
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
    public partial class UserControl_Classic : UserControl
    {
        public UserControl_Classic()
        {
            InitializeComponent();
        }

        private void customClassic_Colors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customClassic_Colors0_Btn.BackColor = color.Color;
                previewBtn.CustomClassicColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customClassic_Colors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customClassic_Colors1_Btn.BackColor = color.Color;
                previewBtn.CustomClassicColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customClassic_Background_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customClassic_Background_Btn.BackColor = color.Color;
                previewBtn.CustomClassicBackground = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customClassic_Border_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customClassic_Border_Btn.BackColor = color.Color;
                previewBtn.CustomClassicBorder = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customClassic_Highlight_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customClassic_Highlight_Btn.BackColor = color.Color;
                previewBtn.CustomClassicHighlight = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customClassic_Shadow_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customClassic_Shadow_Btn.BackColor = color.Color;
                previewBtn.CustomClassicShadow = color.Color;
                previewBtn.Invalidate();
            }
        }
    }
}
