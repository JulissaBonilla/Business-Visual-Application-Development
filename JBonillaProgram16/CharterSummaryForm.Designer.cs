
namespace JBonillaProgram16
{
    partial class CharterSummaryForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAverageCha = new System.Windows.Forms.Label();
            this.lblTotalCha = new System.Windows.Forms.Label();
            this.lblLowestCha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAverageCha);
            this.groupBox1.Controls.Add(this.lblTotalCha);
            this.groupBox1.Controls.Add(this.lblLowestCha);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 276);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Charter Summary";
            // 
            // lblAverageCha
            // 
            this.lblAverageCha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverageCha.Location = new System.Drawing.Point(208, 197);
            this.lblAverageCha.Name = "lblAverageCha";
            this.lblAverageCha.Size = new System.Drawing.Size(166, 33);
            this.lblAverageCha.TabIndex = 5;
            // 
            // lblTotalCha
            // 
            this.lblTotalCha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCha.Location = new System.Drawing.Point(208, 125);
            this.lblTotalCha.Name = "lblTotalCha";
            this.lblTotalCha.Size = new System.Drawing.Size(166, 33);
            this.lblTotalCha.TabIndex = 4;
            // 
            // lblLowestCha
            // 
            this.lblLowestCha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLowestCha.Location = new System.Drawing.Point(208, 52);
            this.lblLowestCha.Name = "lblLowestCha";
            this.lblLowestCha.Size = new System.Drawing.Size(166, 33);
            this.lblLowestCha.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Average Charter Fee:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Charter Fees:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lowest Charter Fee:";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(150, 364);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // CharterSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Name = "CharterSummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Charter Summary - JulissaB";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label lblAverageCha;
        internal System.Windows.Forms.Label lblTotalCha;
        internal System.Windows.Forms.Label lblLowestCha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}