
namespace JBonillaProgram8
{
    partial class Program8
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpBxlInfo = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.nudPayRate = new System.Windows.Forms.NumericUpDown();
            this.nudHoursWrkd = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHrsWrkd = new System.Windows.Forms.Label();
            this.grpBxBtns = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPaySlip = new System.Windows.Forms.Button();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSummary = new System.Windows.Forms.Button();
            this.grpBxlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursWrkd)).BeginInit();
            this.grpBxBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pay Slip Generator";
            // 
            // grpBxlInfo
            // 
            this.grpBxlInfo.Controls.Add(this.label9);
            this.grpBxlInfo.Controls.Add(this.label8);
            this.grpBxlInfo.Controls.Add(this.label7);
            this.grpBxlInfo.Controls.Add(this.label2);
            this.grpBxlInfo.Controls.Add(this.txtName);
            this.grpBxlInfo.Controls.Add(this.nudPayRate);
            this.grpBxlInfo.Controls.Add(this.nudHoursWrkd);
            this.grpBxlInfo.Controls.Add(this.label4);
            this.grpBxlInfo.Controls.Add(this.lblHrsWrkd);
            this.grpBxlInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpBxlInfo.Location = new System.Drawing.Point(22, 44);
            this.grpBxlInfo.Name = "grpBxlInfo";
            this.grpBxlInfo.Size = new System.Drawing.Size(496, 200);
            this.grpBxlInfo.TabIndex = 2;
            this.grpBxlInfo.TabStop = false;
            this.grpBxlInfo.Text = "Employee Info:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(547, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 28);
            this.label9.TabIndex = 8;
            this.label9.Text = "Days";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "$/Hour";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(417, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(163, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(250, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 34);
            this.txtName.TabIndex = 3;
            // 
            // nudPayRate
            // 
            this.nudPayRate.Location = new System.Drawing.Point(250, 132);
            this.nudPayRate.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudPayRate.Name = "nudPayRate";
            this.nudPayRate.Size = new System.Drawing.Size(150, 34);
            this.nudPayRate.TabIndex = 4;
            // 
            // nudHoursWrkd
            // 
            this.nudHoursWrkd.Location = new System.Drawing.Point(250, 83);
            this.nudHoursWrkd.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudHoursWrkd.Name = "nudHoursWrkd";
            this.nudHoursWrkd.Size = new System.Drawing.Size(150, 34);
            this.nudHoursWrkd.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(136, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Pay Rate:";
            // 
            // lblHrsWrkd
            // 
            this.lblHrsWrkd.AutoSize = true;
            this.lblHrsWrkd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHrsWrkd.Location = new System.Drawing.Point(15, 88);
            this.lblHrsWrkd.Name = "lblHrsWrkd";
            this.lblHrsWrkd.Size = new System.Drawing.Size(218, 25);
            this.lblHrsWrkd.TabIndex = 0;
            this.lblHrsWrkd.Text = "Number Hours Worked:";
            // 
            // grpBxBtns
            // 
            this.grpBxBtns.Controls.Add(this.btnExit);
            this.grpBxBtns.Controls.Add(this.btnReset);
            this.grpBxBtns.Controls.Add(this.btnPaySlip);
            this.grpBxBtns.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpBxBtns.Location = new System.Drawing.Point(557, 44);
            this.grpBxBtns.Name = "grpBxBtns";
            this.grpBxBtns.Size = new System.Drawing.Size(195, 313);
            this.grpBxBtns.TabIndex = 5;
            this.grpBxBtns.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(37, 224);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 50);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(37, 38);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 50);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPaySlip
            // 
            this.btnPaySlip.Location = new System.Drawing.Point(37, 109);
            this.btnPaySlip.Name = "btnPaySlip";
            this.btnPaySlip.Size = new System.Drawing.Size(120, 91);
            this.btnPaySlip.TabIndex = 0;
            this.btnPaySlip.Text = "&Create Pay Slip";
            this.btnPaySlip.UseVisualStyleBackColor = true;
            this.btnPaySlip.Click += new System.EventHandler(this.btnPaySlip_Click);
            // 
            // lblNetPay
            // 
            this.lblNetPay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNetPay.Location = new System.Drawing.Point(192, 258);
            this.lblNetPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(322, 36);
            this.lblNetPay.TabIndex = 7;
            this.lblNetPay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(37, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Net Pay:";
            // 
            // btnSummary
            // 
            this.btnSummary.Enabled = false;
            this.btnSummary.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSummary.Location = new System.Drawing.Point(229, 307);
            this.btnSummary.Margin = new System.Windows.Forms.Padding(4);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(154, 50);
            this.btnSummary.TabIndex = 4;
            this.btnSummary.Text = "&Summary";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // Program8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 396);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grpBxBtns);
            this.Controls.Add(this.lblNetPay);
            this.Controls.Add(this.grpBxlInfo);
            this.Controls.Add(this.label1);
            this.Name = "Program8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JBonillaProgram8";
            this.grpBxlInfo.ResumeLayout(false);
            this.grpBxlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursWrkd)).EndInit();
            this.grpBxBtns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBxlInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown nudPayRate;
        private System.Windows.Forms.NumericUpDown nudHoursWrkd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHrsWrkd;
        private System.Windows.Forms.GroupBox grpBxBtns;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPaySlip;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSummary;
    }
}

