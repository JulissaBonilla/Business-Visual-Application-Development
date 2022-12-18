
namespace JBonillaProgram9
{
    partial class Program9
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbServices = new System.Windows.Forms.GroupBox();
            this.cbRecCenter = new System.Windows.Forms.CheckBox();
            this.cbInternet = new System.Windows.Forms.CheckBox();
            this.Accommodationgrp = new System.Windows.Forms.GroupBox();
            this.radSuite = new System.Windows.Forms.RadioButton();
            this.radDouble = new System.Windows.Forms.RadioButton();
            this.radSingle = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.nudNights = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudAttendees = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnCreateConference = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblConferenceSummary = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbServices.SuspendLayout();
            this.Accommodationgrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttendees)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CSU Conference Services";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(257, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Conference Calculator";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbServices);
            this.groupBox1.Controls.Add(this.Accommodationgrp);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.nudNights);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nudAttendees);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(30, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 394);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conference Info:";
            // 
            // gbServices
            // 
            this.gbServices.Controls.Add(this.cbRecCenter);
            this.gbServices.Controls.Add(this.cbInternet);
            this.gbServices.Location = new System.Drawing.Point(148, 208);
            this.gbServices.Name = "gbServices";
            this.gbServices.Size = new System.Drawing.Size(171, 122);
            this.gbServices.TabIndex = 17;
            this.gbServices.TabStop = false;
            this.gbServices.Text = "Optional Services";
            // 
            // cbRecCenter
            // 
            this.cbRecCenter.AutoSize = true;
            this.cbRecCenter.Location = new System.Drawing.Point(18, 82);
            this.cbRecCenter.Name = "cbRecCenter";
            this.cbRecCenter.Size = new System.Drawing.Size(150, 24);
            this.cbRecCenter.TabIndex = 1;
            this.cbRecCenter.Text = "Rec Center Access";
            this.cbRecCenter.UseVisualStyleBackColor = true;
            // 
            // cbInternet
            // 
            this.cbInternet.AutoSize = true;
            this.cbInternet.Location = new System.Drawing.Point(18, 42);
            this.cbInternet.Name = "cbInternet";
            this.cbInternet.Size = new System.Drawing.Size(130, 24);
            this.cbInternet.TabIndex = 0;
            this.cbInternet.Text = "Internet Access";
            this.cbInternet.UseVisualStyleBackColor = true;
            // 
            // Accommodationgrp
            // 
            this.Accommodationgrp.Controls.Add(this.radSuite);
            this.Accommodationgrp.Controls.Add(this.radDouble);
            this.Accommodationgrp.Controls.Add(this.radSingle);
            this.Accommodationgrp.Location = new System.Drawing.Point(8, 208);
            this.Accommodationgrp.Name = "Accommodationgrp";
            this.Accommodationgrp.Size = new System.Drawing.Size(134, 122);
            this.Accommodationgrp.TabIndex = 16;
            this.Accommodationgrp.TabStop = false;
            this.Accommodationgrp.Text = "Accommodation";
            // 
            // radSuite
            // 
            this.radSuite.AutoSize = true;
            this.radSuite.Location = new System.Drawing.Point(16, 87);
            this.radSuite.Name = "radSuite";
            this.radSuite.Size = new System.Drawing.Size(63, 24);
            this.radSuite.TabIndex = 2;
            this.radSuite.Text = "Suite";
            this.radSuite.UseVisualStyleBackColor = true;
            // 
            // radDouble
            // 
            this.radDouble.AutoSize = true;
            this.radDouble.Location = new System.Drawing.Point(16, 57);
            this.radDouble.Name = "radDouble";
            this.radDouble.Size = new System.Drawing.Size(83, 24);
            this.radDouble.TabIndex = 1;
            this.radDouble.Text = "Double ";
            this.radDouble.UseVisualStyleBackColor = true;
            // 
            // radSingle
            // 
            this.radSingle.AutoSize = true;
            this.radSingle.Checked = true;
            this.radSingle.Location = new System.Drawing.Point(17, 24);
            this.radSingle.Name = "radSingle";
            this.radSingle.Size = new System.Drawing.Size(71, 24);
            this.radSingle.TabIndex = 0;
            this.radSingle.TabStop = true;
            this.radSingle.Text = "Single";
            this.radSingle.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(115, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(204, 27);
            this.txtName.TabIndex = 15;
            // 
            // nudNights
            // 
            this.nudNights.Location = new System.Drawing.Point(201, 161);
            this.nudNights.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudNights.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudNights.Name = "nudNights";
            this.nudNights.Size = new System.Drawing.Size(80, 27);
            this.nudNights.TabIndex = 14;
            this.nudNights.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudNights.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Number of NIghts:";
            // 
            // nudAttendees
            // 
            this.nudAttendees.Location = new System.Drawing.Point(201, 113);
            this.nudAttendees.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAttendees.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudAttendees.Name = "nudAttendees";
            this.nudAttendees.Size = new System.Drawing.Size(80, 27);
            this.nudAttendees.TabIndex = 12;
            this.nudAttendees.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAttendees.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Number of Attendees:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnModify);
            this.groupBox3.Controls.Add(this.btnCreateConference);
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Location = new System.Drawing.Point(428, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 220);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // btnModify
            // 
            this.btnModify.Enabled = false;
            this.btnModify.Location = new System.Drawing.Point(18, 89);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(280, 42);
            this.btnModify.TabIndex = 17;
            this.btnModify.Text = "Modify Conference";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnCreateConference
            // 
            this.btnCreateConference.Location = new System.Drawing.Point(19, 26);
            this.btnCreateConference.Name = "btnCreateConference";
            this.btnCreateConference.Size = new System.Drawing.Size(280, 42);
            this.btnCreateConference.TabIndex = 16;
            this.btnCreateConference.Text = "Create Conference";
            this.btnCreateConference.UseVisualStyleBackColor = true;
            this.btnCreateConference.Click += new System.EventHandler(this.btnCreateConference_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(168, 161);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 42);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(19, 161);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(131, 42);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblConferenceSummary
            // 
            this.lblConferenceSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConferenceSummary.Location = new System.Drawing.Point(428, 106);
            this.lblConferenceSummary.Name = "lblConferenceSummary";
            this.lblConferenceSummary.Size = new System.Drawing.Size(317, 128);
            this.lblConferenceSummary.TabIndex = 4;
            this.lblConferenceSummary.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Conference Summary:";
            // 
            // Program9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblConferenceSummary);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Program9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment Set 4- Program 9";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbServices.ResumeLayout(false);
            this.gbServices.PerformLayout();
            this.Accommodationgrp.ResumeLayout(false);
            this.Accommodationgrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAttendees)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbServices;
        private System.Windows.Forms.CheckBox cbRecCenter;
        private System.Windows.Forms.CheckBox cbInternet;
        private System.Windows.Forms.GroupBox Accommodationgrp;
        private System.Windows.Forms.RadioButton radSuite;
        private System.Windows.Forms.RadioButton radDouble;
        private System.Windows.Forms.RadioButton radSingle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown nudNights;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudAttendees;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnCreateConference;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblConferenceSummary;
        private System.Windows.Forms.Label label4;
    }
}

