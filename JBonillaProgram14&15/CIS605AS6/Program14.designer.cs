namespace CIS605AS6
{
    partial class Program14
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
            this.grpStockInfo = new System.Windows.Forms.GroupBox();
            this.txtPrices = new System.Windows.Forms.TextBox();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSmallest = new System.Windows.Forms.Label();
            this.grpTriggers = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.grpAnalysis = new System.Windows.Forms.GroupBox();
            this.lblLongest = new System.Windows.Forms.Label();
            this.btnLongest = new System.Windows.Forms.Button();
            this.lblNegative = new System.Windows.Forms.Label();
            this.lblLargest = new System.Windows.Forms.Label();
            this.btnNegative = new System.Windows.Forms.Button();
            this.btnSmallest = new System.Windows.Forms.Button();
            this.btnLargest = new System.Windows.Forms.Button();
            this.grpStockInfo.SuspendLayout();
            this.grpTriggers.SuspendLayout();
            this.grpAnalysis.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStockInfo
            // 
            this.grpStockInfo.Controls.Add(this.txtPrices);
            this.grpStockInfo.Controls.Add(this.txtSymbol);
            this.grpStockInfo.Controls.Add(this.btnCreate);
            this.grpStockInfo.Controls.Add(this.label2);
            this.grpStockInfo.Controls.Add(this.label1);
            this.grpStockInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpStockInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpStockInfo.Location = new System.Drawing.Point(10, 55);
            this.grpStockInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpStockInfo.Name = "grpStockInfo";
            this.grpStockInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpStockInfo.Size = new System.Drawing.Size(252, 548);
            this.grpStockInfo.TabIndex = 0;
            this.grpStockInfo.TabStop = false;
            this.grpStockInfo.Text = "Stock Info:";
            // 
            // txtPrices
            // 
            this.txtPrices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrices.Location = new System.Drawing.Point(133, 77);
            this.txtPrices.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrices.Multiline = true;
            this.txtPrices.Name = "txtPrices";
            this.txtPrices.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrices.Size = new System.Drawing.Size(107, 452);
            this.txtPrices.TabIndex = 10;
            this.txtPrices.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSymbol
            // 
            this.txtSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSymbol.Location = new System.Drawing.Point(133, 35);
            this.txtSymbol.Margin = new System.Windows.Forms.Padding(2);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(107, 22);
            this.txtSymbol.TabIndex = 9;
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(7, 467);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(122, 62);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "&Create StockAnalyzer";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock Prices:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticker Symbol:";
            // 
            // lblSmallest
            // 
            this.lblSmallest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSmallest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSmallest.Location = new System.Drawing.Point(292, 26);
            this.lblSmallest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSmallest.Name = "lblSmallest";
            this.lblSmallest.Size = new System.Drawing.Size(115, 32);
            this.lblSmallest.TabIndex = 16;
            this.lblSmallest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpTriggers
            // 
            this.grpTriggers.Controls.Add(this.btnExit);
            this.grpTriggers.Controls.Add(this.btnReset);
            this.grpTriggers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpTriggers.Location = new System.Drawing.Point(266, 301);
            this.grpTriggers.Margin = new System.Windows.Forms.Padding(2);
            this.grpTriggers.Name = "grpTriggers";
            this.grpTriggers.Padding = new System.Windows.Forms.Padding(2);
            this.grpTriggers.Size = new System.Drawing.Size(290, 66);
            this.grpTriggers.TabIndex = 1;
            this.grpTriggers.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(157, 16);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 35);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(30, 16);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(102, 35);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(233, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Create and use StockAnalyzer";
            // 
            // grpAnalysis
            // 
            this.grpAnalysis.Controls.Add(this.lblLongest);
            this.grpAnalysis.Controls.Add(this.btnLongest);
            this.grpAnalysis.Controls.Add(this.lblNegative);
            this.grpAnalysis.Controls.Add(this.lblLargest);
            this.grpAnalysis.Controls.Add(this.btnNegative);
            this.grpAnalysis.Controls.Add(this.btnSmallest);
            this.grpAnalysis.Controls.Add(this.btnLargest);
            this.grpAnalysis.Controls.Add(this.lblSmallest);
            this.grpAnalysis.Enabled = false;
            this.grpAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpAnalysis.Location = new System.Drawing.Point(266, 55);
            this.grpAnalysis.Margin = new System.Windows.Forms.Padding(2);
            this.grpAnalysis.Name = "grpAnalysis";
            this.grpAnalysis.Padding = new System.Windows.Forms.Padding(2);
            this.grpAnalysis.Size = new System.Drawing.Size(429, 233);
            this.grpAnalysis.TabIndex = 17;
            this.grpAnalysis.TabStop = false;
            this.grpAnalysis.Text = "Display Stats:";
            // 
            // lblLongest
            // 
            this.lblLongest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLongest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLongest.Location = new System.Drawing.Point(292, 181);
            this.lblLongest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLongest.Name = "lblLongest";
            this.lblLongest.Size = new System.Drawing.Size(115, 32);
            this.lblLongest.TabIndex = 24;
            this.lblLongest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLongest
            // 
            this.btnLongest.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLongest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLongest.Location = new System.Drawing.Point(0, 180);
            this.btnLongest.Margin = new System.Windows.Forms.Padding(2);
            this.btnLongest.Name = "btnLongest";
            this.btnLongest.Size = new System.Drawing.Size(273, 35);
            this.btnLongest.TabIndex = 23;
            this.btnLongest.Text = "Longest Price Gain Streak";
            this.btnLongest.UseVisualStyleBackColor = true;
            this.btnLongest.Click += new System.EventHandler(this.btnLongest_Click);
            // 
            // lblNegative
            // 
            this.lblNegative.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNegative.Location = new System.Drawing.Point(292, 127);
            this.lblNegative.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNegative.Name = "lblNegative";
            this.lblNegative.Size = new System.Drawing.Size(115, 32);
            this.lblNegative.TabIndex = 21;
            this.lblNegative.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLargest
            // 
            this.lblLargest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLargest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLargest.Location = new System.Drawing.Point(292, 79);
            this.lblLargest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLargest.Name = "lblLargest";
            this.lblLargest.Size = new System.Drawing.Size(115, 32);
            this.lblLargest.TabIndex = 20;
            this.lblLargest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNegative
            // 
            this.btnNegative.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNegative.Location = new System.Drawing.Point(0, 129);
            this.btnNegative.Margin = new System.Windows.Forms.Padding(2);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(273, 35);
            this.btnNegative.TabIndex = 18;
            this.btnNegative.Text = "Times Negative Change in Price";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // btnSmallest
            // 
            this.btnSmallest.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSmallest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSmallest.Location = new System.Drawing.Point(0, 26);
            this.btnSmallest.Margin = new System.Windows.Forms.Padding(2);
            this.btnSmallest.Name = "btnSmallest";
            this.btnSmallest.Size = new System.Drawing.Size(273, 35);
            this.btnSmallest.TabIndex = 17;
            this.btnSmallest.Text = "Smallest Perentage Gain in Price";
            this.btnSmallest.UseVisualStyleBackColor = true;
            this.btnSmallest.Click += new System.EventHandler(this.btnSmallest_Click);
            // 
            // btnLargest
            // 
            this.btnLargest.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLargest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLargest.Location = new System.Drawing.Point(0, 77);
            this.btnLargest.Margin = new System.Windows.Forms.Padding(2);
            this.btnLargest.Name = "btnLargest";
            this.btnLargest.Size = new System.Drawing.Size(273, 36);
            this.btnLargest.TabIndex = 1;
            this.btnLargest.Text = "Largest Absolute Price Change";
            this.btnLargest.UseVisualStyleBackColor = true;
            this.btnLargest.Click += new System.EventHandler(this.btnLargest_Click);
            // 
            // Program14
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(706, 607);
            this.Controls.Add(this.grpAnalysis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpTriggers);
            this.Controls.Add(this.grpStockInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Program14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment Set 6 - Program 14";
            this.grpStockInfo.ResumeLayout(false);
            this.grpStockInfo.PerformLayout();
            this.grpTriggers.ResumeLayout(false);
            this.grpAnalysis.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStockInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTriggers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSmallest;
        private System.Windows.Forms.TextBox txtPrices;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.GroupBox grpAnalysis;
        private System.Windows.Forms.Button btnLargest;
        private System.Windows.Forms.Label lblLongest;
        private System.Windows.Forms.Button btnLongest;
        private System.Windows.Forms.Label lblNegative;
        private System.Windows.Forms.Label lblLargest;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.Button btnSmallest;
    }
}

