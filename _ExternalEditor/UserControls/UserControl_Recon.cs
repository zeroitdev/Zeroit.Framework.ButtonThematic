// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_Recon.cs" company="Zeroit Dev Technologies">
//    This program is for creating a Button control.
//    Copyright ©  2017  Zeroit Dev Technologies
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.
//
//    You can contact me at zeroitdevnet@gmail.com or zeroitdev@outlook.com
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
