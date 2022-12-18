
namespace JBonillaProgram3
{
    partial class program3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(program3));
            this.lblName = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.chbxName = new System.Windows.Forms.CheckBox();
            this.chbxDev = new System.Windows.Forms.CheckBox();
            this.chbxLogo = new System.Windows.Forms.CheckBox();
            this.chbxTagline = new System.Windows.Forms.CheckBox();
            this.rdbtnBlue = new System.Windows.Forms.RadioButton();
            this.rdbtnPink = new System.Windows.Forms.RadioButton();
            this.rdbtnRed = new System.Windows.Forms.RadioButton();
            this.rdbtnGreen = new System.Windows.Forms.RadioButton();
            this.lblDev = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Script MT Bold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(196, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(340, 52);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Sac Food && Booze";
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSlogan.ForeColor = System.Drawing.Color.Blue;
            this.lblSlogan.Location = new System.Drawing.Point(28, 75);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(749, 23);
            this.lblSlogan.TabIndex = 1;
            this.lblSlogan.Text = "A city guide and food blog, sharing Sacramento\'s best restaurants, bars, coffee s" +
    "hops and events.";
            // 
            // chbxName
            // 
            this.chbxName.AutoSize = true;
            this.chbxName.Checked = true;
            this.chbxName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxName.Location = new System.Drawing.Point(17, 26);
            this.chbxName.Name = "chbxName";
            this.chbxName.Size = new System.Drawing.Size(71, 24);
            this.chbxName.TabIndex = 4;
            this.chbxName.Text = "&Name";
            this.chbxName.UseVisualStyleBackColor = true;
            this.chbxName.CheckedChanged += new System.EventHandler(this.chbxName_CheckedChanged);
            // 
            // chbxDev
            // 
            this.chbxDev.AutoSize = true;
            this.chbxDev.Checked = true;
            this.chbxDev.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxDev.Location = new System.Drawing.Point(17, 116);
            this.chbxDev.Name = "chbxDev";
            this.chbxDev.Size = new System.Drawing.Size(100, 24);
            this.chbxDev.TabIndex = 5;
            this.chbxDev.Text = "&Developer";
            this.chbxDev.UseVisualStyleBackColor = true;
            this.chbxDev.CheckedChanged += new System.EventHandler(this.chbxDev_CheckedChanged);
            // 
            // chbxLogo
            // 
            this.chbxLogo.AutoSize = true;
            this.chbxLogo.Checked = true;
            this.chbxLogo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxLogo.Location = new System.Drawing.Point(17, 86);
            this.chbxLogo.Name = "chbxLogo";
            this.chbxLogo.Size = new System.Drawing.Size(65, 24);
            this.chbxLogo.TabIndex = 6;
            this.chbxLogo.Text = "&Logo";
            this.chbxLogo.UseVisualStyleBackColor = true;
            this.chbxLogo.CheckedChanged += new System.EventHandler(this.chbxLogo_CheckedChanged);
            // 
            // chbxTagline
            // 
            this.chbxTagline.AutoSize = true;
            this.chbxTagline.Checked = true;
            this.chbxTagline.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxTagline.Location = new System.Drawing.Point(17, 56);
            this.chbxTagline.Name = "chbxTagline";
            this.chbxTagline.Size = new System.Drawing.Size(80, 24);
            this.chbxTagline.TabIndex = 7;
            this.chbxTagline.Text = "&Tagline";
            this.chbxTagline.UseVisualStyleBackColor = true;
            this.chbxTagline.CheckedChanged += new System.EventHandler(this.chbxTagline_CheckedChanged);
            // 
            // rdbtnBlue
            // 
            this.rdbtnBlue.AutoSize = true;
            this.rdbtnBlue.Checked = true;
            this.rdbtnBlue.Location = new System.Drawing.Point(42, 26);
            this.rdbtnBlue.Name = "rdbtnBlue";
            this.rdbtnBlue.Size = new System.Drawing.Size(59, 24);
            this.rdbtnBlue.TabIndex = 8;
            this.rdbtnBlue.TabStop = true;
            this.rdbtnBlue.Text = "&Blue";
            this.rdbtnBlue.UseVisualStyleBackColor = true;
            this.rdbtnBlue.CheckedChanged += new System.EventHandler(this.rdbtnBlue_CheckedChanged);
            // 
            // rdbtnPink
            // 
            this.rdbtnPink.AutoSize = true;
            this.rdbtnPink.Location = new System.Drawing.Point(42, 113);
            this.rdbtnPink.Name = "rdbtnPink";
            this.rdbtnPink.Size = new System.Drawing.Size(57, 24);
            this.rdbtnPink.TabIndex = 9;
            this.rdbtnPink.TabStop = true;
            this.rdbtnPink.Text = "&Pink";
            this.rdbtnPink.UseVisualStyleBackColor = true;
            this.rdbtnPink.CheckedChanged += new System.EventHandler(this.rdbtnPink_CheckedChanged);
            // 
            // rdbtnRed
            // 
            this.rdbtnRed.AutoSize = true;
            this.rdbtnRed.Location = new System.Drawing.Point(42, 83);
            this.rdbtnRed.Name = "rdbtnRed";
            this.rdbtnRed.Size = new System.Drawing.Size(56, 24);
            this.rdbtnRed.TabIndex = 10;
            this.rdbtnRed.TabStop = true;
            this.rdbtnRed.Text = "&Red";
            this.rdbtnRed.UseVisualStyleBackColor = true;
            this.rdbtnRed.CheckedChanged += new System.EventHandler(this.rdbtnRed_CheckedChanged);
            // 
            // rdbtnGreen
            // 
            this.rdbtnGreen.AutoSize = true;
            this.rdbtnGreen.Location = new System.Drawing.Point(42, 56);
            this.rdbtnGreen.Name = "rdbtnGreen";
            this.rdbtnGreen.Size = new System.Drawing.Size(69, 24);
            this.rdbtnGreen.TabIndex = 11;
            this.rdbtnGreen.TabStop = true;
            this.rdbtnGreen.Text = "&Green";
            this.rdbtnGreen.UseVisualStyleBackColor = true;
            this.rdbtnGreen.CheckedChanged += new System.EventHandler(this.rdbtnGreen_CheckedChanged);
            // 
            // lblDev
            // 
            this.lblDev.AutoSize = true;
            this.lblDev.Location = new System.Drawing.Point(64, 361);
            this.lblDev.Name = "lblDev";
            this.lblDev.Size = new System.Drawing.Size(159, 20);
            this.lblDev.TabIndex = 12;
            this.lblDev.Text = "Developed by: JulissaB";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(257, 137);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(271, 198);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 14;
            this.picLogo.TabStop = false;
            this.toolTip1.SetToolTip(this.picLogo, "Our Logo");
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(619, 361);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtnBlue);
            this.groupBox1.Controls.Add(this.rdbtnGreen);
            this.groupBox1.Controls.Add(this.rdbtnRed);
            this.groupBox1.Controls.Add(this.rdbtnPink);
            this.groupBox1.Location = new System.Drawing.Point(51, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 157);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick Color";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbxName);
            this.groupBox2.Controls.Add(this.chbxTagline);
            this.groupBox2.Controls.Add(this.chbxLogo);
            this.groupBox2.Controls.Add(this.chbxDev);
            this.groupBox2.Location = new System.Drawing.Point(579, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 157);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Show/Hide";
            // 
            // program3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblDev);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.lblName);
            this.Name = "program3";
            this.Text = "Assignment Set 2- Program 3";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.CheckBox chbxName;
        private System.Windows.Forms.CheckBox chbxDev;
        private System.Windows.Forms.CheckBox chbxLogo;
        private System.Windows.Forms.CheckBox chbxTagline;
        private System.Windows.Forms.RadioButton rdbtnBlue;
        private System.Windows.Forms.RadioButton rdbtnPink;
        private System.Windows.Forms.RadioButton rdbtnRed;
        private System.Windows.Forms.RadioButton rdbtnGreen;
        private System.Windows.Forms.Label lblDev;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

