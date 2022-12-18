
namespace JBonillaProgram7
{
    partial class Program7
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
            this.grpBxRentalInfo = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.nudNumDays = new System.Windows.Forms.NumericUpDown();
            this.nudEOR = new System.Windows.Forms.NumericUpDown();
            this.nudBOR = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpBxBtns = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnTruckRental = new System.Windows.Forms.Button();
            this.lblRentalCharge = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grpBxRentalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEOR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBOR)).BeginInit();
            this.grpBxBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(211, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Truck Rental - Rental Charge";
            // 
            // grpBxRentalInfo
            // 
            this.grpBxRentalInfo.Controls.Add(this.label9);
            this.grpBxRentalInfo.Controls.Add(this.label8);
            this.grpBxRentalInfo.Controls.Add(this.label7);
            this.grpBxRentalInfo.Controls.Add(this.label2);
            this.grpBxRentalInfo.Controls.Add(this.txtName);
            this.grpBxRentalInfo.Controls.Add(this.nudNumDays);
            this.grpBxRentalInfo.Controls.Add(this.nudEOR);
            this.grpBxRentalInfo.Controls.Add(this.nudBOR);
            this.grpBxRentalInfo.Controls.Add(this.label5);
            this.grpBxRentalInfo.Controls.Add(this.label4);
            this.grpBxRentalInfo.Controls.Add(this.label3);
            this.grpBxRentalInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpBxRentalInfo.Location = new System.Drawing.Point(31, 68);
            this.grpBxRentalInfo.Name = "grpBxRentalInfo";
            this.grpBxRentalInfo.Size = new System.Drawing.Size(667, 274);
            this.grpBxRentalInfo.TabIndex = 1;
            this.grpBxRentalInfo.TabStop = false;
            this.grpBxRentalInfo.Text = " Truck Rental Info:";
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
            this.label8.Location = new System.Drawing.Point(547, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "Miles";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Miles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 34);
            this.txtName.TabIndex = 3;
            // 
            // nudNumDays
            // 
            this.nudNumDays.Location = new System.Drawing.Point(391, 218);
            this.nudNumDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumDays.Name = "nudNumDays";
            this.nudNumDays.Size = new System.Drawing.Size(150, 34);
            this.nudNumDays.TabIndex = 5;
            this.nudNumDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudEOR
            // 
            this.nudEOR.Location = new System.Drawing.Point(391, 151);
            this.nudEOR.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudEOR.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudEOR.Name = "nudEOR";
            this.nudEOR.Size = new System.Drawing.Size(150, 34);
            this.nudEOR.TabIndex = 4;
            this.nudEOR.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudBOR
            // 
            this.nudBOR.Location = new System.Drawing.Point(391, 88);
            this.nudBOR.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudBOR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBOR.Name = "nudBOR";
            this.nudBOR.Size = new System.Drawing.Size(150, 34);
            this.nudBOR.TabIndex = 3;
            this.nudBOR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBOR.ValueChanged += new System.EventHandler(this.nudBOR_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(67, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Number of days rented:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(67, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ending odometer reading:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(67, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Beginning odometer reading:";
            // 
            // grpBxBtns
            // 
            this.grpBxBtns.Controls.Add(this.btnExit);
            this.grpBxBtns.Controls.Add(this.btnReset);
            this.grpBxBtns.Controls.Add(this.btnTruckRental);
            this.grpBxBtns.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpBxBtns.Location = new System.Drawing.Point(81, 342);
            this.grpBxBtns.Name = "grpBxBtns";
            this.grpBxBtns.Size = new System.Drawing.Size(617, 119);
            this.grpBxBtns.TabIndex = 4;
            this.grpBxBtns.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(465, 36);
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
            this.btnReset.Location = new System.Drawing.Point(17, 36);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(120, 50);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnTruckRental
            // 
            this.btnTruckRental.Location = new System.Drawing.Point(180, 29);
            this.btnTruckRental.Name = "btnTruckRental";
            this.btnTruckRental.Size = new System.Drawing.Size(243, 65);
            this.btnTruckRental.TabIndex = 0;
            this.btnTruckRental.Text = "&Create Truck Rental Objet";
            this.btnTruckRental.UseVisualStyleBackColor = true;
            this.btnTruckRental.Click += new System.EventHandler(this.btnTruckRental_Click);
            // 
            // lblRentalCharge
            // 
            this.lblRentalCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRentalCharge.Location = new System.Drawing.Point(250, 519);
            this.lblRentalCharge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRentalCharge.Name = "lblRentalCharge";
            this.lblRentalCharge.Size = new System.Drawing.Size(322, 50);
            this.lblRentalCharge.TabIndex = 6;
            this.lblRentalCharge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(67, 527);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Rental Charge:";
            // 
            // Program7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 622);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblRentalCharge);
            this.Controls.Add(this.grpBxBtns);
            this.Controls.Add(this.grpBxRentalInfo);
            this.Controls.Add(this.label1);
            this.Name = "Program7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment Set 3 Program 7";
            this.grpBxRentalInfo.ResumeLayout(false);
            this.grpBxRentalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEOR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBOR)).EndInit();
            this.grpBxBtns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBxRentalInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudNumDays;
        private System.Windows.Forms.NumericUpDown nudEOR;
        private System.Windows.Forms.NumericUpDown nudBOR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpBxBtns;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTruckRental;
        private System.Windows.Forms.Label lblRentalCharge;
        private System.Windows.Forms.Label label6;
    }
}

