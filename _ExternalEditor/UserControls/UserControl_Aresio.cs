// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_Aresio.cs" company="Zeroit Dev Technologies">
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
    public partial class UserControl_Aresio : UserControl
    {
        public UserControl_Aresio()
        {
            InitializeComponent();
        }

        private void customAresio_NoneColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customAresio_NoneColors0_Btn.BackColor = color.Color;
                previewBtn.CustomAresioNoneColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customAresio_NoneColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customAresio_NoneColors1_Btn.BackColor = color.Color;
                previewBtn.CustomAresioNoneColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customAresio_DownColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customAresio_DownColors0_Btn.BackColor = color.Color;
                previewBtn.CustomAresioDownColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customAresio_DownColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customAresio_DownColors1_Btn.BackColor = color.Color;
                previewBtn.CustomAresioDownColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customAresio_OverColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customAresio_OverColors0_Btn.BackColor = color.Color;
                previewBtn.CustomAresioOverColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customAresio_OverColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customAresio_OverColors1_Btn.BackColor = color.Color;
                previewBtn.CustomAresioOverColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customAresio_BorderColors0_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customAresio_BorderColors0_Btn.BackColor = color.Color;
                previewBtn.CustomAresioBorderColors[0] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customAresio_BorderColors1_Btn_Click(object sender, EventArgs e)
        {
            if (color.ShowDialog() == DialogResult.OK)
            {
                customAresio_BorderColors1_Btn.BackColor = color.Color;
                previewBtn.CustomAresioBorderColors[1] = color.Color;
                previewBtn.Invalidate();
            }
        }

        private void customAresio_NoneColors0_Btn_MouseEnter(object sender, EventArgs e)
        {
            customAresio_NoneColors0_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customAresio_NoneColors0_Btn_MouseLeave(object sender, EventArgs e)
        {
            customAresio_NoneColors0_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customAresio_NoneColors1_Btn_MouseEnter(object sender, EventArgs e)
        {
            customAresio_NoneColors1_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customAresio_NoneColors1_Btn_MouseLeave(object sender, EventArgs e)
        {
            customAresio_NoneColors1_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customAresio_DownColors0_Btn_MouseEnter(object sender, EventArgs e)
        {
            customAresio_DownColors0_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customAresio_DownColors0_Btn_MouseLeave(object sender, EventArgs e)
        {
            customAresio_DownColors0_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customAresio_DownColors1_Btn_MouseEnter(object sender, EventArgs e)
        {
            customAresio_DownColors1_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customAresio_DownColors1_Btn_MouseLeave(object sender, EventArgs e)
        {
            customAresio_DownColors1_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customAresio_OverColors0_Btn_MouseEnter(object sender, EventArgs e)
        {
            customAresio_OverColors0_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customAresio_OverColors0_Btn_MouseLeave(object sender, EventArgs e)
        {
            customAresio_OverColors0_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customAresio_OverColors1_Btn_MouseEnter(object sender, EventArgs e)
        {
            customAresio_OverColors1_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customAresio_OverColors1_Btn_MouseLeave(object sender, EventArgs e)
        {
            customAresio_OverColors1_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customAresio_BorderColors0_Btn_MouseEnter(object sender, EventArgs e)
        {
            customAresio_BorderColors0_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customAresio_BorderColors0_Btn_MouseLeave(object sender, EventArgs e)
        {
            customAresio_BorderColors0_Btn.FlatAppearance.BorderSize = 0;
        }

        private void customAresio_BorderColors1_Btn_MouseEnter(object sender, EventArgs e)
        {
            customAresio_BorderColors1_Btn.FlatAppearance.BorderSize = 1;
        }

        private void customAresio_BorderColors1_Btn_MouseLeave(object sender, EventArgs e)
        {
            customAresio_BorderColors1_Btn.FlatAppearance.BorderSize = 0;
        }
    }
}
