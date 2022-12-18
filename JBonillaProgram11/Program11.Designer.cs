
namespace JBonillaProgram11
{
    partial class Program11
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpData = new System.Windows.Forms.GroupBox();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnCurrent = new System.Windows.Forms.Button();
            this.grpFillDrain = new System.Windows.Forms.GroupBox();
            this.txtFillDrainResult = new System.Windows.Forms.TextBox();
            this.btnFillDrain = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.radDrain = new System.Windows.Forms.RadioButton();
            this.grpTriggers = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.radFill = new System.Windows.Forms.RadioButton();
            this.nudLitersPerSecond = new System.Windows.Forms.NumericUpDown();
            this.grpAddWithdraw = new System.Windows.Forms.GroupBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.btnAddWithdraw = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radWithdraw = new System.Windows.Forms.RadioButton();
            this.radAdd = new System.Windows.Forms.RadioButton();
            this.nudLiters = new System.Windows.Forms.NumericUpDown();
            this.grpDimensions = new System.Windows.Forms.GroupBox();
            this.nudDepth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudRadius = new System.Windows.Forms.NumericUpDown();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpData.SuspendLayout();
            this.grpFillDrain.SuspendLayout();
            this.grpTriggers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLitersPerSecond)).BeginInit();
            this.grpAddWithdraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLiters)).BeginInit();
            this.grpDimensions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // grpData
            // 
            this.grpData.Controls.Add(this.lblMax);
            this.grpData.Controls.Add(this.lblCurrent);
            this.grpData.Controls.Add(this.btnMax);
            this.grpData.Controls.Add(this.btnCurrent);
            this.grpData.Enabled = false;
            this.grpData.Location = new System.Drawing.Point(33, 166);
            this.grpData.Name = "grpData";
            this.grpData.Size = new System.Drawing.Size(463, 141);
            this.grpData.TabIndex = 19;
            this.grpData.TabStop = false;
            this.grpData.Text = "Water Tank Data:";
            // 
            // lblMax
            // 
            this.lblMax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMax.Location = new System.Drawing.Point(240, 93);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(177, 36);
            this.lblMax.TabIndex = 3;
            // 
            // lblCurrent
            // 
            this.lblCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCurrent.Location = new System.Drawing.Point(240, 44);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(177, 36);
            this.lblCurrent.TabIndex = 2;
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(15, 93);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(171, 36);
            this.btnMax.TabIndex = 1;
            this.btnMax.Text = "Maximum Water Capacity";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnCurrent
            // 
            this.btnCurrent.Location = new System.Drawing.Point(15, 44);
            this.btnCurrent.Name = "btnCurrent";
            this.btnCurrent.Size = new System.Drawing.Size(171, 36);
            this.btnCurrent.TabIndex = 0;
            this.btnCurrent.Text = "Current Water Level";
            this.btnCurrent.UseVisualStyleBackColor = true;
            this.btnCurrent.Click += new System.EventHandler(this.btnCurrent_Click);
            // 
            // grpFillDrain
            // 
            this.grpFillDrain.Controls.Add(this.txtFillDrainResult);
            this.grpFillDrain.Controls.Add(this.btnFillDrain);
            this.grpFillDrain.Controls.Add(this.label6);
            this.grpFillDrain.Controls.Add(this.radDrain);
            this.grpFillDrain.Controls.Add(this.grpTriggers);
            this.grpFillDrain.Controls.Add(this.radFill);
            this.grpFillDrain.Controls.Add(this.nudLitersPerSecond);
            this.grpFillDrain.Enabled = false;
            this.grpFillDrain.Location = new System.Drawing.Point(528, 45);
            this.grpFillDrain.Name = "grpFillDrain";
            this.grpFillDrain.Size = new System.Drawing.Size(489, 507);
            this.grpFillDrain.TabIndex = 18;
            this.grpFillDrain.TabStop = false;
            this.grpFillDrain.Text = "Fill/Drain";
            // 
            // txtFillDrainResult
            // 
            this.txtFillDrainResult.Location = new System.Drawing.Point(41, 165);
            this.txtFillDrainResult.Multiline = true;
            this.txtFillDrainResult.Name = "txtFillDrainResult";
            this.txtFillDrainResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFillDrainResult.Size = new System.Drawing.Size(156, 322);
            this.txtFillDrainResult.TabIndex = 16;
            // 
            // btnFillDrain
            // 
            this.btnFillDrain.Location = new System.Drawing.Point(246, 102);
            this.btnFillDrain.Name = "btnFillDrain";
            this.btnFillDrain.Size = new System.Drawing.Size(219, 45);
            this.btnFillDrain.TabIndex = 15;
            this.btnFillDrain.Text = "Fill/Drain";
            this.btnFillDrain.UseVisualStyleBackColor = true;
            this.btnFillDrain.Click += new System.EventHandler(this.btnFillDrain_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Liters/Second:";
            // 
            // radDrain
            // 
            this.radDrain.AutoSize = true;
            this.radDrain.Location = new System.Drawing.Point(41, 91);
            this.radDrain.Name = "radDrain";
            this.radDrain.Size = new System.Drawing.Size(66, 24);
            this.radDrain.TabIndex = 1;
            this.radDrain.Text = "Drain";
            this.radDrain.UseVisualStyleBackColor = true;
            // 
            // grpTriggers
            // 
            this.grpTriggers.Controls.Add(this.btnReset);
            this.grpTriggers.Controls.Add(this.btnExit);
            this.grpTriggers.Location = new System.Drawing.Point(246, 234);
            this.grpTriggers.Name = "grpTriggers";
            this.grpTriggers.Size = new System.Drawing.Size(219, 171);
            this.grpTriggers.TabIndex = 16;
            this.grpTriggers.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(27, 37);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(148, 45);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(27, 102);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 45);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // radFill
            // 
            this.radFill.AutoSize = true;
            this.radFill.Checked = true;
            this.radFill.Location = new System.Drawing.Point(41, 47);
            this.radFill.Name = "radFill";
            this.radFill.Size = new System.Drawing.Size(49, 24);
            this.radFill.TabIndex = 0;
            this.radFill.TabStop = true;
            this.radFill.Text = "Fill";
            this.radFill.UseVisualStyleBackColor = true;
            // 
            // nudLitersPerSecond
            // 
            this.nudLitersPerSecond.Location = new System.Drawing.Point(280, 43);
            this.nudLitersPerSecond.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudLitersPerSecond.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLitersPerSecond.Name = "nudLitersPerSecond";
            this.nudLitersPerSecond.Size = new System.Drawing.Size(185, 27);
            this.nudLitersPerSecond.TabIndex = 13;
            this.nudLitersPerSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudLitersPerSecond.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grpAddWithdraw
            // 
            this.grpAddWithdraw.Controls.Add(this.lblSummary);
            this.grpAddWithdraw.Controls.Add(this.btnAddWithdraw);
            this.grpAddWithdraw.Controls.Add(this.label3);
            this.grpAddWithdraw.Controls.Add(this.radWithdraw);
            this.grpAddWithdraw.Controls.Add(this.radAdd);
            this.grpAddWithdraw.Controls.Add(this.nudLiters);
            this.grpAddWithdraw.Enabled = false;
            this.grpAddWithdraw.Location = new System.Drawing.Point(33, 316);
            this.grpAddWithdraw.Name = "grpAddWithdraw";
            this.grpAddWithdraw.Size = new System.Drawing.Size(463, 236);
            this.grpAddWithdraw.TabIndex = 17;
            this.grpAddWithdraw.TabStop = false;
            this.grpAddWithdraw.Text = "Add/Withdraw Water:";
            // 
            // lblSummary
            // 
            this.lblSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSummary.Location = new System.Drawing.Point(15, 142);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(415, 74);
            this.lblSummary.TabIndex = 16;
            // 
            // btnAddWithdraw
            // 
            this.btnAddWithdraw.Location = new System.Drawing.Point(247, 89);
            this.btnAddWithdraw.Name = "btnAddWithdraw";
            this.btnAddWithdraw.Size = new System.Drawing.Size(170, 45);
            this.btnAddWithdraw.TabIndex = 15;
            this.btnAddWithdraw.Text = "Add/Withdraw";
            this.btnAddWithdraw.UseVisualStyleBackColor = true;
            this.btnAddWithdraw.Click += new System.EventHandler(this.btnAddWithdraw_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Liters:";
            // 
            // radWithdraw
            // 
            this.radWithdraw.AutoSize = true;
            this.radWithdraw.Location = new System.Drawing.Point(15, 102);
            this.radWithdraw.Name = "radWithdraw";
            this.radWithdraw.Size = new System.Drawing.Size(94, 24);
            this.radWithdraw.TabIndex = 1;
            this.radWithdraw.Text = "Withdraw";
            this.radWithdraw.UseVisualStyleBackColor = true;
            // 
            // radAdd
            // 
            this.radAdd.AutoSize = true;
            this.radAdd.Checked = true;
            this.radAdd.Location = new System.Drawing.Point(15, 48);
            this.radAdd.Name = "radAdd";
            this.radAdd.Size = new System.Drawing.Size(58, 24);
            this.radAdd.TabIndex = 0;
            this.radAdd.TabStop = true;
            this.radAdd.Text = "Add";
            this.radAdd.UseVisualStyleBackColor = true;
            // 
            // nudLiters
            // 
            this.nudLiters.Location = new System.Drawing.Point(247, 45);
            this.nudLiters.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudLiters.Name = "nudLiters";
            this.nudLiters.Size = new System.Drawing.Size(170, 27);
            this.nudLiters.TabIndex = 13;
            this.nudLiters.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // grpDimensions
            // 
            this.grpDimensions.Controls.Add(this.nudDepth);
            this.grpDimensions.Controls.Add(this.label2);
            this.grpDimensions.Controls.Add(this.nudRadius);
            this.grpDimensions.Controls.Add(this.btnCreate);
            this.grpDimensions.Controls.Add(this.label1);
            this.grpDimensions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpDimensions.Location = new System.Drawing.Point(33, 39);
            this.grpDimensions.Name = "grpDimensions";
            this.grpDimensions.Size = new System.Drawing.Size(463, 121);
            this.grpDimensions.TabIndex = 15;
            this.grpDimensions.TabStop = false;
            this.grpDimensions.Text = "Water Tank Dimensions:";
            // 
            // nudDepth
            // 
            this.nudDepth.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudDepth.Location = new System.Drawing.Point(113, 80);
            this.nudDepth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDepth.Name = "nudDepth";
            this.nudDepth.Size = new System.Drawing.Size(140, 27);
            this.nudDepth.TabIndex = 16;
            this.nudDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDepth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Depth:";
            // 
            // nudRadius
            // 
            this.nudRadius.Location = new System.Drawing.Point(113, 46);
            this.nudRadius.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRadius.Name = "nudRadius";
            this.nudRadius.Size = new System.Drawing.Size(140, 27);
            this.nudRadius.TabIndex = 14;
            this.nudRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudRadius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(287, 37);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(143, 45);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "&Create Water";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radius:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(327, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(321, 33);
            this.label5.TabIndex = 20;
            this.label5.Text = "Create and Manage Water";
            // 
            // Program11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 555);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.grpFillDrain);
            this.Controls.Add(this.grpAddWithdraw);
            this.Controls.Add(this.grpDimensions);
            this.Name = "Program11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment 5 - Program 11";
            this.grpData.ResumeLayout(false);
            this.grpFillDrain.ResumeLayout(false);
            this.grpFillDrain.PerformLayout();
            this.grpTriggers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudLitersPerSecond)).EndInit();
            this.grpAddWithdraw.ResumeLayout(false);
            this.grpAddWithdraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLiters)).EndInit();
            this.grpDimensions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblCurrent;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnCurrent;
        private System.Windows.Forms.GroupBox grpFillDrain;
        private System.Windows.Forms.TextBox txtFillDrainResult;
        private System.Windows.Forms.Button btnFillDrain;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radDrain;
        private System.Windows.Forms.RadioButton radFill;
        private System.Windows.Forms.NumericUpDown nudLitersPerSecond;
        private System.Windows.Forms.GroupBox grpAddWithdraw;
        private System.Windows.Forms.Button btnAddWithdraw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radWithdraw;
        private System.Windows.Forms.RadioButton radAdd;
        private System.Windows.Forms.NumericUpDown nudLiters;
        private System.Windows.Forms.GroupBox grpTriggers;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpDimensions;
        private System.Windows.Forms.NumericUpDown nudDepth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudRadius;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSummary;
    }
}

