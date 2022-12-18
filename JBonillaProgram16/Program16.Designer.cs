
namespace JBonillaProgram16
{
    partial class Program16
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCharters = new System.Windows.Forms.ToolStripMenuItem();
            this.numberOfChartersForYachtSize = new System.Windows.Forms.ToolStripMenuItem();
            this.charterSummary = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetForNextCharter = new System.Windows.Forms.ToolStripMenuItem();
            this.addFoodTypeToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.addYachtType = new System.Windows.Forms.ToolStripMenuItem();
            this.removeYachtTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpCharterInfo = new System.Windows.Forms.GroupBox();
            this.cbYachtSize = new System.Windows.Forms.ComboBox();
            this.cbYachtType = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addYachtTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeYachtTypeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudHours = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpCharterInfo.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayToolStripMenuItem,
            this.editToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(376, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allCharters,
            this.numberOfChartersForYachtSize,
            this.charterSummary,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // allCharters
            // 
            this.allCharters.Enabled = false;
            this.allCharters.Name = "allCharters";
            this.allCharters.Size = new System.Drawing.Size(316, 26);
            this.allCharters.Text = "All Charters";
            this.allCharters.Click += new System.EventHandler(this.allCharters_Click);
            // 
            // numberOfChartersForYachtSize
            // 
            this.numberOfChartersForYachtSize.AutoSize = false;
            this.numberOfChartersForYachtSize.Enabled = false;
            this.numberOfChartersForYachtSize.Name = "numberOfChartersForYachtSize";
            this.numberOfChartersForYachtSize.Size = new System.Drawing.Size(321, 26);
            this.numberOfChartersForYachtSize.Text = "Number of Charters for Yacht Size";
            this.numberOfChartersForYachtSize.Click += new System.EventHandler(this.numberOfChartersForYachtType_Click);
            // 
            // charterSummary
            // 
            this.charterSummary.Enabled = false;
            this.charterSummary.Name = "charterSummary";
            this.charterSummary.Size = new System.Drawing.Size(316, 26);
            this.charterSummary.Text = "Charter Summary";
            this.charterSummary.Click += new System.EventHandler(this.charterSummary_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(313, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(316, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetForNextCharter,
            this.addFoodTypeToolStripMenuItem,
            this.addYachtType,
            this.removeYachtTypeToolStripMenuItem});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(49, 24);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // resetForNextCharter
            // 
            this.resetForNextCharter.Name = "resetForNextCharter";
            this.resetForNextCharter.Size = new System.Drawing.Size(238, 26);
            this.resetForNextCharter.Text = "Reset for Next Charter";
            this.resetForNextCharter.Click += new System.EventHandler(this.resetForNextCharter_Click);
            // 
            // addFoodTypeToolStripMenuItem
            // 
            this.addFoodTypeToolStripMenuItem.Name = "addFoodTypeToolStripMenuItem";
            this.addFoodTypeToolStripMenuItem.Size = new System.Drawing.Size(235, 6);
            // 
            // addYachtType
            // 
            this.addYachtType.Name = "addYachtType";
            this.addYachtType.Size = new System.Drawing.Size(238, 26);
            this.addYachtType.Text = "Add Yacht Type";
            this.addYachtType.Click += new System.EventHandler(this.addYachtType_Click);
            // 
            // removeYachtTypeToolStripMenuItem
            // 
            this.removeYachtTypeToolStripMenuItem.Name = "removeYachtTypeToolStripMenuItem";
            this.removeYachtTypeToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.removeYachtTypeToolStripMenuItem.Text = "Remove Yacht Type";
            this.removeYachtTypeToolStripMenuItem.Click += new System.EventHandler(this.removeYachtTypeToolStripMenuItem_Click);
            // 
            // grpCharterInfo
            // 
            this.grpCharterInfo.Controls.Add(this.cbYachtSize);
            this.grpCharterInfo.Controls.Add(this.cbYachtType);
            this.grpCharterInfo.Controls.Add(this.label5);
            this.grpCharterInfo.Controls.Add(this.btnCreate);
            this.grpCharterInfo.Controls.Add(this.txtCustomerName);
            this.grpCharterInfo.Controls.Add(this.label4);
            this.grpCharterInfo.Controls.Add(this.nudHours);
            this.grpCharterInfo.Controls.Add(this.label2);
            this.grpCharterInfo.Controls.Add(this.label1);
            this.grpCharterInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpCharterInfo.Location = new System.Drawing.Point(31, 45);
            this.grpCharterInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grpCharterInfo.Name = "grpCharterInfo";
            this.grpCharterInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grpCharterInfo.Size = new System.Drawing.Size(313, 289);
            this.grpCharterInfo.TabIndex = 10;
            this.grpCharterInfo.TabStop = false;
            this.grpCharterInfo.Text = "Charter Info:";
            // 
            // cbYachtSize
            // 
            this.cbYachtSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYachtSize.FormattingEnabled = true;
            this.cbYachtSize.Items.AddRange(new object[] {
            "22",
            "24",
            "30",
            "32",
            "36",
            "38",
            "45 "});
            this.cbYachtSize.Location = new System.Drawing.Point(140, 118);
            this.cbYachtSize.Name = "cbYachtSize";
            this.cbYachtSize.Size = new System.Drawing.Size(151, 28);
            this.cbYachtSize.TabIndex = 14;
            // 
            // cbYachtType
            // 
            this.cbYachtType.ContextMenuStrip = this.contextMenuStrip1;
            this.cbYachtType.FormattingEnabled = true;
            this.cbYachtType.Items.AddRange(new object[] {
            "Express Cruiser",
            "Flybridge",
            "Sedan Bridge",
            "Motor Yacht",
            "Tri-Deck",
            "Sportfish",
            "Skylounge",
            "Mega Yacht"});
            this.cbYachtType.Location = new System.Drawing.Point(140, 80);
            this.cbYachtType.Name = "cbYachtType";
            this.cbYachtType.Size = new System.Drawing.Size(151, 28);
            this.cbYachtType.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addYachtTypeToolStripMenuItem,
            this.removeYachtTypeToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // addYachtTypeToolStripMenuItem
            // 
            this.addYachtTypeToolStripMenuItem.Name = "addYachtTypeToolStripMenuItem";
            this.addYachtTypeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addYachtTypeToolStripMenuItem.Text = "Add Yacht Type";
            this.addYachtTypeToolStripMenuItem.Click += new System.EventHandler(this.addYachtTypeToolStripMenuItem_Click);
            // 
            // removeYachtTypeToolStripMenuItem1
            // 
            this.removeYachtTypeToolStripMenuItem1.Name = "removeYachtTypeToolStripMenuItem1";
            this.removeYachtTypeToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.removeYachtTypeToolStripMenuItem1.Text = "Remove Yacht Type";
            this.removeYachtTypeToolStripMenuItem1.Click += new System.EventHandler(this.removeYachtTypeToolStripMenuItem1_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Yacht Type:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(73, 219);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(150, 35);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "&Add Charter";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(140, 41);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(151, 27);
            this.txtCustomerName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Customer:";
            // 
            // nudHours
            // 
            this.nudHours.Location = new System.Drawing.Point(140, 159);
            this.nudHours.Margin = new System.Windows.Forms.Padding(2);
            this.nudHours.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudHours.Name = "nudHours";
            this.nudHours.Size = new System.Drawing.Size(151, 27);
            this.nudHours.TabIndex = 7;
            this.nudHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Charter Hours:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yacht Size:";
            // 
            // Program16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 347);
            this.Controls.Add(this.grpCharterInfo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Program16";
            this.Text = "Assignment Set 7- Program 16";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpCharterInfo.ResumeLayout(false);
            this.grpCharterInfo.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetForNextCharter;
        private System.Windows.Forms.ToolStripSeparator addFoodTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addYachtType;
        private System.Windows.Forms.ToolStripMenuItem removeYachtTypeToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpCharterInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cbYachtSize;
        internal System.Windows.Forms.ComboBox cbYachtType;
        internal System.Windows.Forms.TextBox txtCustomerName;
        internal System.Windows.Forms.NumericUpDown nudHours;
        internal System.Windows.Forms.ToolStripMenuItem allCharters;
        internal System.Windows.Forms.ToolStripMenuItem numberOfChartersForYachtSize;
        internal System.Windows.Forms.ToolStripMenuItem charterSummary;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addYachtTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeYachtTypeToolStripMenuItem1;
    }
}

