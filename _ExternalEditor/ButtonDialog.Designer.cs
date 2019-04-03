namespace Zeroit.Framework.ButtonThematic.Controls
{
    partial class ButtonDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundTheme = new Zeroit.Framework.ButtonThematic.ThemeManagers.SpicyLips();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainControl_HatchStyle_ComboBox = new Zeroit.Framework.ButtonThematic.Editors.HatchStyleComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mainControl_GradientMode_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mainControl_Curve_Numeric = new System.Windows.Forms.NumericUpDown();
            this.mainControl_ButtonType_ComboBox = new System.Windows.Forms.ComboBox();
            this.mainControl_RenderMode_ComboBox = new System.Windows.Forms.ComboBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.backgroundTheme.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainControl_Curve_Numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundTheme
            // 
            this.backgroundTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.backgroundTheme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.backgroundTheme.Colors = new Zeroit.Framework.ButtonThematic.ThemeManagers.Bloom[0];
            this.backgroundTheme.Controls.Add(this.okBtn);
            this.backgroundTheme.Controls.Add(this.cancelBtn);
            this.backgroundTheme.Controls.Add(this.groupBox1);
            this.backgroundTheme.Controls.Add(this.closeBtn);
            this.backgroundTheme.Customization = "";
            this.backgroundTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backgroundTheme.Font = new System.Drawing.Font("Verdana", 9F);
            this.backgroundTheme.Image = null;
            this.backgroundTheme.Location = new System.Drawing.Point(0, 0);
            this.backgroundTheme.Movable = true;
            this.backgroundTheme.Name = "backgroundTheme";
            this.backgroundTheme.NoRounding = false;
            this.backgroundTheme.Sizable = false;
            this.backgroundTheme.Size = new System.Drawing.Size(1129, 653);
            this.backgroundTheme.SmartBounds = true;
            this.backgroundTheme.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.backgroundTheme.TabIndex = 0;
            this.backgroundTheme.Text = "Button Creator";
            this.backgroundTheme.TransparencyKey = System.Drawing.Color.Empty;
            this.backgroundTheme.Transparent = false;
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.okBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okBtn.FlatAppearance.BorderSize = 0;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.okBtn.Location = new System.Drawing.Point(913, 601);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(96, 39);
            this.okBtn.TabIndex = 57;
            this.okBtn.Text = "&OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(129)))));
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.cancelBtn.Location = new System.Drawing.Point(1014, 601);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(96, 39);
            this.cancelBtn.TabIndex = 58;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.groupBox1.Controls.Add(this.mainControl_HatchStyle_ComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mainControl_GradientMode_ComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.mainControl_Curve_Numeric);
            this.groupBox1.Controls.Add(this.mainControl_ButtonType_ComboBox);
            this.groupBox1.Controls.Add(this.mainControl_RenderMode_ComboBox);
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(26, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 373);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // mainControl_HatchStyle_ComboBox
            // 
            this.mainControl_HatchStyle_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mainControl_HatchStyle_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainControl_HatchStyle_ComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainControl_HatchStyle_ComboBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.mainControl_HatchStyle_ComboBox.FormattingEnabled = true;
            this.mainControl_HatchStyle_ComboBox.Location = new System.Drawing.Point(179, 236);
            this.mainControl_HatchStyle_ComboBox.Name = "mainControl_HatchStyle_ComboBox";
            this.mainControl_HatchStyle_ComboBox.SelectedHatchStyle = System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal;
            this.mainControl_HatchStyle_ComboBox.Size = new System.Drawing.Size(134, 30);
            this.mainControl_HatchStyle_ComboBox.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(18, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 102;
            this.label2.Text = "HatchStyle";
            // 
            // mainControl_GradientMode_ComboBox
            // 
            this.mainControl_GradientMode_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mainControl_GradientMode_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainControl_GradientMode_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainControl_GradientMode_ComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainControl_GradientMode_ComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mainControl_GradientMode_ComboBox.FormattingEnabled = true;
            this.mainControl_GradientMode_ComboBox.Location = new System.Drawing.Point(179, 169);
            this.mainControl_GradientMode_ComboBox.Name = "mainControl_GradientMode_ComboBox";
            this.mainControl_GradientMode_ComboBox.Size = new System.Drawing.Size(134, 29);
            this.mainControl_GradientMode_ComboBox.Sorted = true;
            this.mainControl_GradientMode_ComboBox.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 82;
            this.label1.Text = "Button Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(17, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 86;
            this.label3.Text = "Gradient Mode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(17, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 87;
            this.label4.Text = "Render Mode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(17, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 90;
            this.label5.Text = "Curve";
            // 
            // mainControl_Curve_Numeric
            // 
            this.mainControl_Curve_Numeric.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mainControl_Curve_Numeric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainControl_Curve_Numeric.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainControl_Curve_Numeric.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.mainControl_Curve_Numeric.Location = new System.Drawing.Point(179, 306);
            this.mainControl_Curve_Numeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.mainControl_Curve_Numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mainControl_Curve_Numeric.Name = "mainControl_Curve_Numeric";
            this.mainControl_Curve_Numeric.Size = new System.Drawing.Size(134, 29);
            this.mainControl_Curve_Numeric.TabIndex = 89;
            this.mainControl_Curve_Numeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainControl_Curve_Numeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.mainControl_Curve_Numeric.ValueChanged += new System.EventHandler(this.mainControl_Curve_Numeric_ValueChanged);
            // 
            // mainControl_ButtonType_ComboBox
            // 
            this.mainControl_ButtonType_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mainControl_ButtonType_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainControl_ButtonType_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainControl_ButtonType_ComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainControl_ButtonType_ComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mainControl_ButtonType_ComboBox.FormattingEnabled = true;
            this.mainControl_ButtonType_ComboBox.Location = new System.Drawing.Point(179, 42);
            this.mainControl_ButtonType_ComboBox.Name = "mainControl_ButtonType_ComboBox";
            this.mainControl_ButtonType_ComboBox.Size = new System.Drawing.Size(134, 29);
            this.mainControl_ButtonType_ComboBox.Sorted = true;
            this.mainControl_ButtonType_ComboBox.TabIndex = 83;
            this.mainControl_ButtonType_ComboBox.SelectedIndexChanged += new System.EventHandler(this.mainControl_ButtonType_ComboBox_SelectedIndexChanged);
            // 
            // mainControl_RenderMode_ComboBox
            // 
            this.mainControl_RenderMode_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.mainControl_RenderMode_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mainControl_RenderMode_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainControl_RenderMode_ComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mainControl_RenderMode_ComboBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mainControl_RenderMode_ComboBox.FormattingEnabled = true;
            this.mainControl_RenderMode_ComboBox.Location = new System.Drawing.Point(179, 105);
            this.mainControl_RenderMode_ComboBox.Name = "mainControl_RenderMode_ComboBox";
            this.mainControl_RenderMode_ComboBox.Size = new System.Drawing.Size(134, 29);
            this.mainControl_RenderMode_ComboBox.Sorted = true;
            this.mainControl_RenderMode_ComboBox.TabIndex = 88;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Verdana", 7F);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(1108, 1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(19, 19);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "x";
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeBtn.UseCompatibleTextRendering = true;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            // 
            // ButtonDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 653);
            this.Controls.Add(this.backgroundTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ButtonDialog";
            this.Text = "ButtonDialog";
            this.backgroundTheme.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainControl_Curve_Numeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ThemeManagers.SpicyLips backgroundTheme;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Button okBtn;
        public System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown mainControl_Curve_Numeric;
        private System.Windows.Forms.ComboBox mainControl_ButtonType_ComboBox;
        private System.Windows.Forms.ComboBox mainControl_RenderMode_ComboBox;
        private System.Windows.Forms.ComboBox mainControl_GradientMode_ComboBox;
        private System.Windows.Forms.Label label2;
        private Editors.HatchStyleComboBox mainControl_HatchStyle_ComboBox;
    }
}