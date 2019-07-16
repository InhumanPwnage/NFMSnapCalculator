namespace SnapCalculator
{
    partial class Form1
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
            this.grpSnap = new System.Windows.Forms.GroupBox();
            this.numSnapRed = new System.Windows.Forms.NumericUpDown();
            this.lblSnapRed = new System.Windows.Forms.Label();
            this.numSnapGreen = new System.Windows.Forms.NumericUpDown();
            this.numSnapBlue = new System.Windows.Forms.NumericUpDown();
            this.lblSnapGreen = new System.Windows.Forms.Label();
            this.lblSnapBlue = new System.Windows.Forms.Label();
            this.grpGetColor = new System.Windows.Forms.GroupBox();
            this.numGetRed = new System.Windows.Forms.NumericUpDown();
            this.lblGetRed = new System.Windows.Forms.Label();
            this.numGetGreen = new System.Windows.Forms.NumericUpDown();
            this.numGetBlue = new System.Windows.Forms.NumericUpDown();
            this.lblGetGeen = new System.Windows.Forms.Label();
            this.lblGetBlue = new System.Windows.Forms.Label();
            this.pnlGetColor = new System.Windows.Forms.Panel();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.lblResRed = new System.Windows.Forms.Label();
            this.txtResRed = new System.Windows.Forms.TextBox();
            this.txtResGreen = new System.Windows.Forms.TextBox();
            this.txtResBlue = new System.Windows.Forms.TextBox();
            this.lblResGreen = new System.Windows.Forms.Label();
            this.lblResBlue = new System.Windows.Forms.Label();
            this.btnCalculateResult = new System.Windows.Forms.Button();
            this.grpSnap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSnapRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSnapGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSnapBlue)).BeginInit();
            this.grpGetColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGetRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGetGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGetBlue)).BeginInit();
            this.grpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSnap
            // 
            this.grpSnap.Controls.Add(this.lblSnapBlue);
            this.grpSnap.Controls.Add(this.lblSnapGreen);
            this.grpSnap.Controls.Add(this.numSnapBlue);
            this.grpSnap.Controls.Add(this.numSnapGreen);
            this.grpSnap.Controls.Add(this.lblSnapRed);
            this.grpSnap.Controls.Add(this.numSnapRed);
            this.grpSnap.Location = new System.Drawing.Point(12, 12);
            this.grpSnap.Name = "grpSnap";
            this.grpSnap.Size = new System.Drawing.Size(168, 70);
            this.grpSnap.TabIndex = 0;
            this.grpSnap.TabStop = false;
            this.grpSnap.Text = "Snap";
            // 
            // numSnapRed
            // 
            this.numSnapRed.Location = new System.Drawing.Point(6, 41);
            this.numSnapRed.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numSnapRed.Minimum = new decimal(new int[] {
            99,
            0,
            0,
            -2147483648});
            this.numSnapRed.Name = "numSnapRed";
            this.numSnapRed.Size = new System.Drawing.Size(47, 20);
            this.numSnapRed.TabIndex = 0;
            // 
            // lblSnapRed
            // 
            this.lblSnapRed.AutoSize = true;
            this.lblSnapRed.Location = new System.Drawing.Point(6, 25);
            this.lblSnapRed.Name = "lblSnapRed";
            this.lblSnapRed.Size = new System.Drawing.Size(15, 13);
            this.lblSnapRed.TabIndex = 1;
            this.lblSnapRed.Text = "R";
            // 
            // numSnapGreen
            // 
            this.numSnapGreen.Location = new System.Drawing.Point(59, 41);
            this.numSnapGreen.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numSnapGreen.Minimum = new decimal(new int[] {
            99,
            0,
            0,
            -2147483648});
            this.numSnapGreen.Name = "numSnapGreen";
            this.numSnapGreen.Size = new System.Drawing.Size(47, 20);
            this.numSnapGreen.TabIndex = 2;
            // 
            // numSnapBlue
            // 
            this.numSnapBlue.Location = new System.Drawing.Point(112, 41);
            this.numSnapBlue.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numSnapBlue.Minimum = new decimal(new int[] {
            99,
            0,
            0,
            -2147483648});
            this.numSnapBlue.Name = "numSnapBlue";
            this.numSnapBlue.Size = new System.Drawing.Size(47, 20);
            this.numSnapBlue.TabIndex = 3;
            // 
            // lblSnapGreen
            // 
            this.lblSnapGreen.AutoSize = true;
            this.lblSnapGreen.Location = new System.Drawing.Point(56, 25);
            this.lblSnapGreen.Name = "lblSnapGreen";
            this.lblSnapGreen.Size = new System.Drawing.Size(15, 13);
            this.lblSnapGreen.TabIndex = 4;
            this.lblSnapGreen.Text = "G";
            // 
            // lblSnapBlue
            // 
            this.lblSnapBlue.AutoSize = true;
            this.lblSnapBlue.Location = new System.Drawing.Point(112, 25);
            this.lblSnapBlue.Name = "lblSnapBlue";
            this.lblSnapBlue.Size = new System.Drawing.Size(14, 13);
            this.lblSnapBlue.TabIndex = 5;
            this.lblSnapBlue.Text = "B";
            // 
            // grpGetColor
            // 
            this.grpGetColor.Controls.Add(this.lblGetBlue);
            this.grpGetColor.Controls.Add(this.lblGetGeen);
            this.grpGetColor.Controls.Add(this.numGetBlue);
            this.grpGetColor.Controls.Add(this.numGetGreen);
            this.grpGetColor.Controls.Add(this.lblGetRed);
            this.grpGetColor.Controls.Add(this.numGetRed);
            this.grpGetColor.Location = new System.Drawing.Point(12, 88);
            this.grpGetColor.Name = "grpGetColor";
            this.grpGetColor.Size = new System.Drawing.Size(168, 70);
            this.grpGetColor.TabIndex = 1;
            this.grpGetColor.TabStop = false;
            this.grpGetColor.Text = "Color to get";
            // 
            // numGetRed
            // 
            this.numGetRed.Location = new System.Drawing.Point(6, 41);
            this.numGetRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numGetRed.Name = "numGetRed";
            this.numGetRed.Size = new System.Drawing.Size(47, 20);
            this.numGetRed.TabIndex = 2;
            this.numGetRed.ValueChanged += new System.EventHandler(this.numGetRed_ValueChanged);
            // 
            // lblGetRed
            // 
            this.lblGetRed.AutoSize = true;
            this.lblGetRed.Location = new System.Drawing.Point(6, 25);
            this.lblGetRed.Name = "lblGetRed";
            this.lblGetRed.Size = new System.Drawing.Size(15, 13);
            this.lblGetRed.TabIndex = 3;
            this.lblGetRed.Text = "R";
            // 
            // numGetGreen
            // 
            this.numGetGreen.Location = new System.Drawing.Point(59, 41);
            this.numGetGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numGetGreen.Name = "numGetGreen";
            this.numGetGreen.Size = new System.Drawing.Size(47, 20);
            this.numGetGreen.TabIndex = 2;
            this.numGetGreen.ValueChanged += new System.EventHandler(this.numGetGreen_ValueChanged);
            // 
            // numGetBlue
            // 
            this.numGetBlue.Location = new System.Drawing.Point(112, 41);
            this.numGetBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numGetBlue.Name = "numGetBlue";
            this.numGetBlue.Size = new System.Drawing.Size(47, 20);
            this.numGetBlue.TabIndex = 2;
            this.numGetBlue.ValueChanged += new System.EventHandler(this.numGetBlue_ValueChanged);
            // 
            // lblGetGeen
            // 
            this.lblGetGeen.AutoSize = true;
            this.lblGetGeen.Location = new System.Drawing.Point(56, 25);
            this.lblGetGeen.Name = "lblGetGeen";
            this.lblGetGeen.Size = new System.Drawing.Size(15, 13);
            this.lblGetGeen.TabIndex = 2;
            this.lblGetGeen.Text = "G";
            // 
            // lblGetBlue
            // 
            this.lblGetBlue.AutoSize = true;
            this.lblGetBlue.Location = new System.Drawing.Point(112, 25);
            this.lblGetBlue.Name = "lblGetBlue";
            this.lblGetBlue.Size = new System.Drawing.Size(14, 13);
            this.lblGetBlue.TabIndex = 2;
            this.lblGetBlue.Text = "B";
            // 
            // pnlGetColor
            // 
            this.pnlGetColor.Location = new System.Drawing.Point(186, 88);
            this.pnlGetColor.Name = "pnlGetColor";
            this.pnlGetColor.Size = new System.Drawing.Size(70, 70);
            this.pnlGetColor.TabIndex = 3;
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.lblResBlue);
            this.grpResult.Controls.Add(this.lblResGreen);
            this.grpResult.Controls.Add(this.txtResBlue);
            this.grpResult.Controls.Add(this.txtResGreen);
            this.grpResult.Controls.Add(this.txtResRed);
            this.grpResult.Controls.Add(this.lblResRed);
            this.grpResult.Location = new System.Drawing.Point(12, 165);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(168, 70);
            this.grpResult.TabIndex = 4;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Result";
            // 
            // lblResRed
            // 
            this.lblResRed.AutoSize = true;
            this.lblResRed.Location = new System.Drawing.Point(6, 26);
            this.lblResRed.Name = "lblResRed";
            this.lblResRed.Size = new System.Drawing.Size(15, 13);
            this.lblResRed.TabIndex = 6;
            this.lblResRed.Text = "R";
            // 
            // txtResRed
            // 
            this.txtResRed.Location = new System.Drawing.Point(6, 42);
            this.txtResRed.MaxLength = 3;
            this.txtResRed.Name = "txtResRed";
            this.txtResRed.ReadOnly = true;
            this.txtResRed.Size = new System.Drawing.Size(47, 20);
            this.txtResRed.TabIndex = 5;
            // 
            // txtResGreen
            // 
            this.txtResGreen.Location = new System.Drawing.Point(59, 42);
            this.txtResGreen.MaxLength = 3;
            this.txtResGreen.Name = "txtResGreen";
            this.txtResGreen.ReadOnly = true;
            this.txtResGreen.Size = new System.Drawing.Size(47, 20);
            this.txtResGreen.TabIndex = 5;
            // 
            // txtResBlue
            // 
            this.txtResBlue.Location = new System.Drawing.Point(112, 42);
            this.txtResBlue.MaxLength = 3;
            this.txtResBlue.Name = "txtResBlue";
            this.txtResBlue.ReadOnly = true;
            this.txtResBlue.Size = new System.Drawing.Size(47, 20);
            this.txtResBlue.TabIndex = 5;
            // 
            // lblResGreen
            // 
            this.lblResGreen.AutoSize = true;
            this.lblResGreen.Location = new System.Drawing.Point(56, 26);
            this.lblResGreen.Name = "lblResGreen";
            this.lblResGreen.Size = new System.Drawing.Size(15, 13);
            this.lblResGreen.TabIndex = 5;
            this.lblResGreen.Text = "G";
            // 
            // lblResBlue
            // 
            this.lblResBlue.AutoSize = true;
            this.lblResBlue.Location = new System.Drawing.Point(112, 26);
            this.lblResBlue.Name = "lblResBlue";
            this.lblResBlue.Size = new System.Drawing.Size(14, 13);
            this.lblResBlue.TabIndex = 5;
            this.lblResBlue.Text = "B";
            // 
            // btnCalculateResult
            // 
            this.btnCalculateResult.Location = new System.Drawing.Point(186, 205);
            this.btnCalculateResult.Name = "btnCalculateResult";
            this.btnCalculateResult.Size = new System.Drawing.Size(70, 23);
            this.btnCalculateResult.TabIndex = 5;
            this.btnCalculateResult.Text = "Calculate";
            this.btnCalculateResult.UseVisualStyleBackColor = true;
            this.btnCalculateResult.Click += new System.EventHandler(this.btnCalculateResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 248);
            this.Controls.Add(this.btnCalculateResult);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.pnlGetColor);
            this.Controls.Add(this.grpGetColor);
            this.Controls.Add(this.grpSnap);
            this.Name = "Form1";
            this.Text = "NFM Snap Calculator";
            this.grpSnap.ResumeLayout(false);
            this.grpSnap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSnapRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSnapGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSnapBlue)).EndInit();
            this.grpGetColor.ResumeLayout(false);
            this.grpGetColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGetRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGetGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGetBlue)).EndInit();
            this.grpResult.ResumeLayout(false);
            this.grpResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSnap;
        private System.Windows.Forms.Label lblSnapBlue;
        private System.Windows.Forms.Label lblSnapGreen;
        private System.Windows.Forms.NumericUpDown numSnapBlue;
        private System.Windows.Forms.NumericUpDown numSnapGreen;
        private System.Windows.Forms.Label lblSnapRed;
        private System.Windows.Forms.NumericUpDown numSnapRed;
        private System.Windows.Forms.GroupBox grpGetColor;
        private System.Windows.Forms.Label lblGetBlue;
        private System.Windows.Forms.Label lblGetGeen;
        private System.Windows.Forms.NumericUpDown numGetBlue;
        private System.Windows.Forms.NumericUpDown numGetGreen;
        private System.Windows.Forms.Label lblGetRed;
        private System.Windows.Forms.NumericUpDown numGetRed;
        private System.Windows.Forms.Panel pnlGetColor;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Label lblResBlue;
        private System.Windows.Forms.Label lblResGreen;
        private System.Windows.Forms.TextBox txtResBlue;
        private System.Windows.Forms.TextBox txtResGreen;
        private System.Windows.Forms.TextBox txtResRed;
        private System.Windows.Forms.Label lblResRed;
        private System.Windows.Forms.Button btnCalculateResult;
    }
}

