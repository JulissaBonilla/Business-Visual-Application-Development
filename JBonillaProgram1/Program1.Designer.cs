
namespace JBonillaProgram1
{
    partial class Program1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnAnimal = new System.Windows.Forms.Button();
            this.btnSeason = new System.Windows.Forms.Button();
            this.btnHoliday = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(280, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Julissa\'s Favorites";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(147, 173);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(442, 25);
            this.lblResult.TabIndex = 1;
            // 
            // btnAnimal
            // 
            this.btnAnimal.Location = new System.Drawing.Point(125, 106);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(94, 29);
            this.btnAnimal.TabIndex = 2;
            this.btnAnimal.Text = "Animal";
            this.btnAnimal.UseVisualStyleBackColor = true;
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click_1);
            // 
            // btnSeason
            // 
            this.btnSeason.Location = new System.Drawing.Point(321, 106);
            this.btnSeason.Name = "btnSeason";
            this.btnSeason.Size = new System.Drawing.Size(94, 29);
            this.btnSeason.TabIndex = 3;
            this.btnSeason.Text = "Season";
            this.btnSeason.UseVisualStyleBackColor = true;
            this.btnSeason.Click += new System.EventHandler(this.btnSeason_Click);
            // 
            // btnHoliday
            // 
            this.btnHoliday.Location = new System.Drawing.Point(495, 106);
            this.btnHoliday.Name = "btnHoliday";
            this.btnHoliday.Size = new System.Drawing.Size(94, 29);
            this.btnHoliday.TabIndex = 4;
            this.btnHoliday.Text = "Holiday";
            this.btnHoliday.UseVisualStyleBackColor = true;
            this.btnHoliday.Click += new System.EventHandler(this.btnHoliday_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(147, 245);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Developed by: Julissa B";
            // 
            // Program1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHoliday);
            this.Controls.Add(this.btnSeason);
            this.Controls.Add(this.btnAnimal);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Name = "Program1";
            this.Text = "Assignment 1- Program1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.Button btnSeason;
        private System.Windows.Forms.Button btnHoliday;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
    }
}