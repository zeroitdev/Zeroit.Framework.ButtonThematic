// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_Intel.cs" company="Zeroit Dev Technologies">
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
    public partial class UserControl_Intel : UserControl
    {
        public UserControl_Intel()
        {
            InitializeComponent();
        }

        private void customIntel_Background_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customIntel_Background_Btn.BackColor = color.Color;
                previewBtn.CustomIntelBackgroundColor = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customIntel_Border_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customIntel_Border_Btn.BackColor = color.Color;
                previewBtn.CustomIntelBorderColor = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customIntel_Shade_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customIntel_Shade_Btn.BackColor = color.Color;
                previewBtn.CustomIntelShade = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customIntel_Glow_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.CustomIntelGlow = (int)customIntel_Glow_Numeric.Value;
            previewBtn.Invalidate();
        }
    }
}
