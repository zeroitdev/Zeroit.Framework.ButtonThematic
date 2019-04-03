// ***********************************************************************
// Assembly         : Zeroit.Framework.ButtonThematic
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-15-2018
// ***********************************************************************
// <copyright file="UserControl_IntelDesigner.cs" company="Zeroit Dev Technologies">
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
namespace Zeroit.Framework.ButtonThematic.Controls
{
    partial class UserControl_Intel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.customIntel_Shade_Btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.customIntel_Glow_Numeric = new System.Windows.Forms.NumericUpDown();
            this.customIntel_Background_Btn = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.customIntel_Border_Btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.previewBtn = new Zeroit.Framework.ButtonThematic.Controls.IntelPreview();
            this.color = new System.Windows.Forms.ColorDialog();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customIntel_Glow_Numeric)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox11.Controls.Add(this.customIntel_Shade_Btn);
            this.groupBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox11.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.groupBox11.ForeColor = System.Drawing.Color.White;
            this.groupBox11.Location = new System.Drawing.Point(179, 25);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(71, 68);
            this.groupBox11.TabIndex = 80;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Shade";
            // 
            // customIntel_Shade_Btn
            // 
            this.customIntel_Shade_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.customIntel_Shade_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customIntel_Shade_Btn.FlatAppearance.BorderSize = 0;
            this.customIntel_Shade_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customIntel_Shade_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.customIntel_Shade_Btn.Location = new System.Drawing.Point(17, 24);
            this.customIntel_Shade_Btn.Name = "customIntel_Shade_Btn";
            this.customIntel_Shade_Btn.Size = new System.Drawing.Size(38, 33);
            this.customIntel_Shade_Btn.TabIndex = 65;
            this.customIntel_Shade_Btn.UseVisualStyleBackColor = false;
            this.customIntel_Shade_Btn.Click += new System.EventHandler(this.customIntel_Shade_Btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(10, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 92;
            this.label5.Text = "Glow";
            // 
            // customIntel_Glow_Numeric
            // 
            this.customIntel_Glow_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.customIntel_Glow_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.customIntel_Glow_Numeric.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.customIntel_Glow_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.customIntel_Glow_Numeric.Location = new System.Drawing.Point(54, 111);
            this.customIntel_Glow_Numeric.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.customIntel_Glow_Numeric.Name = "customIntel_Glow_Numeric";
            this.customIntel_Glow_Numeric.Size = new System.Drawing.Size(44, 25);
            this.customIntel_Glow_Numeric.TabIndex = 91;
            this.customIntel_Glow_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customIntel_Glow_Numeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.customIntel_Glow_Numeric.ValueChanged += new System.EventHandler(this.customIntel_Glow_Numeric_ValueChanged);
            // 
            // customIntel_Background_Btn
            // 
            this.customIntel_Background_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.customIntel_Background_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customIntel_Background_Btn.FlatAppearance.BorderSize = 0;
            this.customIntel_Background_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customIntel_Background_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.customIntel_Background_Btn.Location = new System.Drawing.Point(25, 24);
            this.customIntel_Background_Btn.Name = "customIntel_Background_Btn";
            this.customIntel_Background_Btn.Size = new System.Drawing.Size(38, 33);
            this.customIntel_Background_Btn.TabIndex = 65;
            this.customIntel_Background_Btn.UseVisualStyleBackColor = false;
            this.customIntel_Background_Btn.Click += new System.EventHandler(this.customIntel_Background_Btn_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox6.Controls.Add(this.customIntel_Background_Btn);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(12, 25);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(86, 68);
            this.groupBox6.TabIndex = 66;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Background";
            // 
            // customIntel_Border_Btn
            // 
            this.customIntel_Border_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(38)))));
            this.customIntel_Border_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customIntel_Border_Btn.FlatAppearance.BorderSize = 0;
            this.customIntel_Border_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customIntel_Border_Btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.customIntel_Border_Btn.Location = new System.Drawing.Point(15, 21);
            this.customIntel_Border_Btn.Name = "customIntel_Border_Btn";
            this.customIntel_Border_Btn.Size = new System.Drawing.Size(38, 33);
            this.customIntel_Border_Btn.TabIndex = 65;
            this.customIntel_Border_Btn.UseVisualStyleBackColor = false;
            this.customIntel_Border_Btn.Click += new System.EventHandler(this.customIntel_Border_Btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox1.Controls.Add(this.customIntel_Border_Btn);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(104, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(69, 68);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Border";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.label6.Font = new System.Drawing.Font("Verdana", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(316, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 96;
            this.label6.Text = "Preview";
            // 
            // previewBtn
            // 
            this.previewBtn.Colors = new Zeroit.Framework.ButtonThematic.ThemeManagers.Bloom[0];
            this.previewBtn.CustomIntelBackgroundColor = System.Drawing.Color.SteelBlue;
            this.previewBtn.CustomIntelBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.previewBtn.CustomIntelCurve = 8;
            this.previewBtn.CustomIntelGlow = 180;
            this.previewBtn.CustomIntelShade = System.Drawing.Color.Black;
            this.previewBtn.Customization = "";
            this.previewBtn.Font = new System.Drawing.Font("Verdana", 8F);
            this.previewBtn.Image = null;
            this.previewBtn.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.previewBtn.Location = new System.Drawing.Point(277, 53);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.NoRounding = false;
            this.previewBtn.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.None;
            this.previewBtn.Size = new System.Drawing.Size(130, 40);
            this.previewBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.previewBtn.TabIndex = 97;
            this.previewBtn.Text = "intelPreview1";
            this.previewBtn.TextRendering = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.previewBtn.Transparent = false;
            // 
            // UserControl_Intel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.previewBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.customIntel_Glow_Numeric);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox6);
            this.Name = "UserControl_Intel";
            this.Size = new System.Drawing.Size(418, 145);
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customIntel_Glow_Numeric)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox11;
        public System.Windows.Forms.Button customIntel_Shade_Btn;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button customIntel_Background_Btn;
        private System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.Button customIntel_Border_Btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.NumericUpDown customIntel_Glow_Numeric;
        public IntelPreview previewBtn;
        private System.Windows.Forms.ColorDialog color;
    }
}
