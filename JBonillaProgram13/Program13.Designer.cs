
namespace JBonillaProgram13
{
    partial class Program13
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.coboTopPlayers = new System.Windows.Forms.ComboBox();
            this.coboChampions = new System.Windows.Forms.ComboBox();
            this.btnWins = new System.Windows.Forms.Button();
            this.btnBackToBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Top Players";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wimbledon Champions";
            // 
            // lblDisplay
            // 
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Location = new System.Drawing.Point(526, 90);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(415, 25);
            this.lblDisplay.TabIndex = 2;
            // 
            // coboTopPlayers
            // 
            this.coboTopPlayers.FormattingEnabled = true;
            this.coboTopPlayers.Items.AddRange(new object[] {
            "Agnieszka Radwanska",
            "Amelie Mauresmo",
            "Andrea Jaeger",
            "Angelique Kerber",
            "Ann Jones",
            "Arantxa Sanchez Vicario",
            "Ashleigh Barty",
            "Betty Stove",
            "Billie Jean King",
            "Chris Evert",
            "Conchita Martinez",
            "Elena Rybakina",
            "Eugenie Bouchard",
            "Evonne Goolagong",
            "Gabriela Sabatini",
            "Garbine Muguruza",
            "Hana Mandlikova",
            "Helena Sukova",
            "Jana Novotna",
            "Jennifer Capriati",
            "Judy Tegart",
            "Justine Henin",
            "Karolina Pliskova",
            "Kim Clijsters",
            "Lindsay Davenport",
            "Margaret Court",
            "Maria Sharapova",
            "Marion Bartoli",
            "Martina Hingis",
            "Martina Navratilova",
            "Mary Pierce",
            "Monica Seles",
            "Nathalie Tauziat",
            "Olga Morozova",
            "Ons Jabeur",
            "Petra Kvitova",
            "Sabine Lisicki",
            "Serena Williams",
            "Simona Halep",
            "Steffi Graf",
            "Tracy Austin",
            "Venus Williams",
            "Vera Zvonareva",
            "Virginia Wade",
            "Zina Garrison"});
            this.coboTopPlayers.Location = new System.Drawing.Point(12, 90);
            this.coboTopPlayers.Name = "coboTopPlayers";
            this.coboTopPlayers.Size = new System.Drawing.Size(182, 28);
            this.coboTopPlayers.TabIndex = 3;
            // 
            // coboChampions
            // 
            this.coboChampions.FormattingEnabled = true;
            this.coboChampions.Items.AddRange(new object[] {
            "Billie Jean King",
            "Ann Jones",
            "Margaret Court",
            "Evonne Goolagong",
            "Billie Jean King",
            "Billie Jean King",
            "Chris Evert",
            "Billie Jean King",
            "Chris Evert",
            "Virginia Wade",
            "Martina Navratilova",
            "Martina Navratilova",
            "Evonne Goolagong",
            "Chris Evert",
            "Martina Navratilova",
            "Martina Navratilova",
            "Martina Navratilova",
            "Martina Navratilova",
            "Martina Navratilova",
            "Martina Navratilova",
            "Steffi Graf",
            "Steffi Graf",
            "Martina Navratilova",
            "Steffi Graf",
            "Steffi Graf",
            "Steffi Graf",
            "Conchita Martinez",
            "Steffi Graf",
            "Steffi Graf",
            "Martina Hingis",
            "Jana Novotna",
            "Lindsay Davenport",
            "Venus Williams",
            "Venus Williams",
            "Serena Williams",
            "Serena Williams",
            "Maria Sharapova",
            "Venus Williams",
            "Amelie Mauresmo",
            "Venus Williams",
            "Venus Williams",
            "Serena Williams",
            "Serena Williams",
            "Petra Kvitova",
            "Serena Williams",
            "Marion Bartoli",
            "Petra Kvitova",
            "Serena Williams",
            "Serena Williams",
            "Garbine Muguruza",
            "Angelique Kerber",
            "Simona Halep",
            "Ashleigh Barty",
            "Elena Rybakina"});
            this.coboChampions.Location = new System.Drawing.Point(242, 90);
            this.coboChampions.Name = "coboChampions";
            this.coboChampions.Size = new System.Drawing.Size(198, 28);
            this.coboChampions.TabIndex = 4;
            // 
            // btnWins
            // 
            this.btnWins.Location = new System.Drawing.Point(526, 37);
            this.btnWins.Name = "btnWins";
            this.btnWins.Size = new System.Drawing.Size(147, 29);
            this.btnWins.TabIndex = 5;
            this.btnWins.Text = "How many wins?";
            this.btnWins.UseVisualStyleBackColor = true;
            this.btnWins.Click += new System.EventHandler(this.btnWins_Click);
            // 
            // btnBackToBack
            // 
            this.btnBackToBack.Location = new System.Drawing.Point(696, 37);
            this.btnBackToBack.Name = "btnBackToBack";
            this.btnBackToBack.Size = new System.Drawing.Size(245, 29);
            this.btnBackToBack.TabIndex = 6;
            this.btnBackToBack.Text = "How many times back-to-back champions?";
            this.btnBackToBack.UseVisualStyleBackColor = true;
            this.btnBackToBack.Click += new System.EventHandler(this.btnBackToBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(651, 137);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 29);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Program13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 178);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBackToBack);
            this.Controls.Add(this.btnWins);
            this.Controls.Add(this.coboChampions);
            this.Controls.Add(this.coboTopPlayers);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Program13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assignment Set 5 - Program 13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.ComboBox coboTopPlayers;
        private System.Windows.Forms.ComboBox coboChampions;
        private System.Windows.Forms.Button btnWins;
        private System.Windows.Forms.Button btnBackToBack;
        private System.Windows.Forms.Button btnExit;
    }
}

