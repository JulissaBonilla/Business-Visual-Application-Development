
namespace JBonillaProgram16
{
    partial class AllChartersForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.charterManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.charterFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charterHoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yachtSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yachtTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.charterManagerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // charterManagerBindingSource
            // 
            this.charterManagerBindingSource.DataMember = "CharterList";
            this.charterManagerBindingSource.DataSource = typeof(JBonillaProgram16.CharterManager);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(610, 372);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // charterFeeDataGridViewTextBoxColumn
            // 
            this.charterFeeDataGridViewTextBoxColumn.DataPropertyName = "CharterFee";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle1.Format = "2C";
            this.charterFeeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.charterFeeDataGridViewTextBoxColumn.HeaderText = "Charter Fee";
            this.charterFeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.charterFeeDataGridViewTextBoxColumn.Name = "charterFeeDataGridViewTextBoxColumn";
            this.charterFeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.charterFeeDataGridViewTextBoxColumn.Width = 125;
            // 
            // charterHoursDataGridViewTextBoxColumn
            // 
            this.charterHoursDataGridViewTextBoxColumn.DataPropertyName = "CharterHours";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.charterHoursDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.charterHoursDataGridViewTextBoxColumn.HeaderText = "Charter Hours";
            this.charterHoursDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.charterHoursDataGridViewTextBoxColumn.Name = "charterHoursDataGridViewTextBoxColumn";
            this.charterHoursDataGridViewTextBoxColumn.ReadOnly = true;
            this.charterHoursDataGridViewTextBoxColumn.Width = 150;
            // 
            // yachtSizeDataGridViewTextBoxColumn
            // 
            this.yachtSizeDataGridViewTextBoxColumn.DataPropertyName = "YachtSize";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.yachtSizeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.yachtSizeDataGridViewTextBoxColumn.HeaderText = "Yacht Size";
            this.yachtSizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yachtSizeDataGridViewTextBoxColumn.Name = "yachtSizeDataGridViewTextBoxColumn";
            this.yachtSizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.yachtSizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // yachtTypeDataGridViewTextBoxColumn
            // 
            this.yachtTypeDataGridViewTextBoxColumn.DataPropertyName = "YachtType";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.yachtTypeDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.yachtTypeDataGridViewTextBoxColumn.HeaderText = "Yacht Type";
            this.yachtTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yachtTypeDataGridViewTextBoxColumn.Name = "yachtTypeDataGridViewTextBoxColumn";
            this.yachtTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.yachtTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.NullValue = null;
            this.customerNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNameDataGridViewTextBoxColumn,
            this.yachtTypeDataGridViewTextBoxColumn,
            this.yachtSizeDataGridViewTextBoxColumn,
            this.charterHoursDataGridViewTextBoxColumn,
            this.charterFeeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.charterManagerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(744, 354);
            this.dataGridView1.TabIndex = 0;
            // 
            // AllChartersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 418);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AllChartersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Charters -JulissaB";
            ((System.ComponentModel.ISupportInitialize)(this.charterManagerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.BindingSource charterManagerBindingSource;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn charterFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charterHoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yachtSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yachtTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}