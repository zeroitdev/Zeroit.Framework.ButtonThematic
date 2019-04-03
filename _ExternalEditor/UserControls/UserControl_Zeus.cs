// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_Zeus.cs" company="Zeroit Dev Technologies">
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
    public partial class UserControl_Zeus : UserControl
    {
        public UserControl_Zeus()
        {
            InitializeComponent();
        }

        private void customZeus_ClickReduce_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.CustomZeusClickReduce = (int)customZeus_ClickReduce_Numeric.Value;
            previewBtn.Invalidate();
        }

        private void customZeus_ClickLocate_Numeric_ValueChanged(object sender, EventArgs e)
        {
            previewBtn.CustomZeusClickLocate = (int)customZeus_ClickLocate_Numeric.Value;
            previewBtn.Invalidate();
        }

        private void customZeus_Background_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customZeus_Background_Btn.BackColor = color.Color;
                previewBtn.CustomZeusBackground = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customZeus_GradientColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customZeus_GradientColors0_Btn.BackColor = color.Color;
                previewBtn.CustomZeusGradientColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customZeus_GradientColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customZeus_GradientColors1_Btn.BackColor = color.Color;
                previewBtn.CustomZeusGradientColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customZeus_BorderColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customZeus_BorderColors0_Btn.BackColor = color.Color;
                previewBtn.CustomZeusBorderColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customZeus_BorderColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customZeus_BorderColors1_Btn.BackColor = color.Color;
                previewBtn.CustomZeusBorderColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }
    }
}
