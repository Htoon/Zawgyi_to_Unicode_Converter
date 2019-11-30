namespace Zawgyi_to_Unicode_Converter
{
    partial class frmMain
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
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdCopy = new System.Windows.Forms.Button();
            this.lblOutputSize = new System.Windows.Forms.Label();
            this.cboOutputSize = new System.Windows.Forms.ComboBox();
            this.lblInputSize = new System.Windows.Forms.Label();
            this.cboInputSize = new System.Windows.Forms.ComboBox();
            this.cboOutput = new System.Windows.Forms.ComboBox();
            this.cboInput = new System.Windows.Forms.ComboBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.cmdClose = new System.Windows.Forms.Button();
            this.cmdConvert = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(395, 47);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(77, 26);
            this.cmdDelete.TabIndex = 133;
            this.cmdDelete.Text = "Delete All";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdCopy
            // 
            this.cmdCopy.Location = new System.Drawing.Point(819, 329);
            this.cmdCopy.Name = "cmdCopy";
            this.cmdCopy.Size = new System.Drawing.Size(77, 26);
            this.cmdCopy.TabIndex = 132;
            this.cmdCopy.Text = "Copy All";
            this.cmdCopy.UseVisualStyleBackColor = true;
            this.cmdCopy.Click += new System.EventHandler(this.cmdCopy_Click);
            // 
            // lblOutputSize
            // 
            this.lblOutputSize.AutoSize = true;
            this.lblOutputSize.Location = new System.Drawing.Point(789, 54);
            this.lblOutputSize.Name = "lblOutputSize";
            this.lblOutputSize.Size = new System.Drawing.Size(27, 13);
            this.lblOutputSize.TabIndex = 131;
            this.lblOutputSize.Text = "Size";
            // 
            // cboOutputSize
            // 
            this.cboOutputSize.FormattingEnabled = true;
            this.cboOutputSize.Location = new System.Drawing.Point(823, 50);
            this.cboOutputSize.Name = "cboOutputSize";
            this.cboOutputSize.Size = new System.Drawing.Size(50, 21);
            this.cboOutputSize.TabIndex = 130;
            this.cboOutputSize.SelectedIndexChanged += new System.EventHandler(this.cboOutputSize_SelectedIndexChanged);
            // 
            // lblInputSize
            // 
            this.lblInputSize.AutoSize = true;
            this.lblInputSize.Location = new System.Drawing.Point(285, 54);
            this.lblInputSize.Name = "lblInputSize";
            this.lblInputSize.Size = new System.Drawing.Size(27, 13);
            this.lblInputSize.TabIndex = 129;
            this.lblInputSize.Text = "Size";
            // 
            // cboInputSize
            // 
            this.cboInputSize.FormattingEnabled = true;
            this.cboInputSize.Location = new System.Drawing.Point(319, 50);
            this.cboInputSize.Name = "cboInputSize";
            this.cboInputSize.Size = new System.Drawing.Size(50, 21);
            this.cboInputSize.TabIndex = 128;
            this.cboInputSize.SelectedIndexChanged += new System.EventHandler(this.cboInputSize_SelectedIndexChanged);
            // 
            // cboOutput
            // 
            this.cboOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOutput.FormattingEnabled = true;
            this.cboOutput.Location = new System.Drawing.Point(569, 50);
            this.cboOutput.Name = "cboOutput";
            this.cboOutput.Size = new System.Drawing.Size(207, 21);
            this.cboOutput.TabIndex = 125;
            // 
            // cboInput
            // 
            this.cboInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInput.FormattingEnabled = true;
            this.cboInput.Location = new System.Drawing.Point(68, 50);
            this.cboInput.Name = "cboInput";
            this.cboInput.Size = new System.Drawing.Size(207, 21);
            this.cboInput.TabIndex = 124;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(31, 336);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(334, 13);
            this.lblCopyright.TabIndex = 123;
            this.lblCopyright.Text = "Copyright (c) 2019 by Htoon Aung Kyaw, Star Light Group, Taungtha.";
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(904, 329);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(77, 26);
            this.cmdClose.TabIndex = 122;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // cmdConvert
            // 
            this.cmdConvert.Location = new System.Drawing.Point(685, 329);
            this.cmdConvert.Name = "cmdConvert";
            this.cmdConvert.Size = new System.Drawing.Size(126, 26);
            this.cmdConvert.TabIndex = 121;
            this.cmdConvert.Text = "Convert";
            this.cmdConvert.UseVisualStyleBackColor = true;
            this.cmdConvert.Click += new System.EventHandler(this.cmdConvert_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.Window;
            this.txtOutput.Font = new System.Drawing.Font("Zawgyi-One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(503, 79);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(484, 238);
            this.txtOutput.TabIndex = 120;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(503, 54);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(60, 13);
            this.lblOutput.TabIndex = 119;
            this.lblOutput.Text = "Output font";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(10, 79);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(484, 238);
            this.txtInput.TabIndex = 118;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(10, 54);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(52, 13);
            this.lblInput.TabIndex = 117;
            this.lblInput.Text = "Input font";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 366);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdCopy);
            this.Controls.Add(this.lblOutputSize);
            this.Controls.Add(this.cboOutputSize);
            this.Controls.Add(this.lblInputSize);
            this.Controls.Add(this.cboInputSize);
            this.Controls.Add(this.cboOutput);
            this.Controls.Add(this.cboInput);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdConvert);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zawgyi to Unicode Converter";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdCopy;
        internal System.Windows.Forms.Label lblOutputSize;
        internal System.Windows.Forms.ComboBox cboOutputSize;
        internal System.Windows.Forms.Label lblInputSize;
        internal System.Windows.Forms.ComboBox cboInputSize;
        internal System.Windows.Forms.ComboBox cboOutput;
        internal System.Windows.Forms.ComboBox cboInput;
        internal System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.Button cmdConvert;
        internal System.Windows.Forms.TextBox txtOutput;
        internal System.Windows.Forms.Label lblOutput;
        internal System.Windows.Forms.TextBox txtInput;
        internal System.Windows.Forms.Label lblInput;
    }
}

