using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.View
{
    partial class GridView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.revenueExpenditureBooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.revenueAccountBookDataSet = new WindowsFormsApp1.Data.RevenueAccountBookDataSet();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.spartaToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.spartaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.revenueExpenditureBooksTableAdapter = new WindowsFormsApp1.Data.RevenueAccountBookDataSetTableAdapters.RevenueExpenditureBooksTableAdapter();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rawMaterialsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOutPlusAndMinus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserRegisteredId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueExpenditureBooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueAccountBookDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.incomeDataGridViewTextBoxColumn,
            this.rawMaterialsDataGridViewTextBoxColumn,
            this.expenseDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.countedDataGridViewTextBoxColumn,
            this.CheckOutPlusAndMinus,
            this.UserRegisteredId});
            this.dataGridView1.DataSource = this.revenueExpenditureBooksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(841, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // revenueExpenditureBooksBindingSource
            // 
            this.revenueExpenditureBooksBindingSource.DataMember = "RevenueExpenditureBooks";
            this.revenueExpenditureBooksBindingSource.DataSource = this.revenueAccountBookDataSet;
            // 
            // revenueAccountBookDataSet
            // 
            this.revenueAccountBookDataSet.DataSetName = "RevenueAccountBookDataSet";
            this.revenueAccountBookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spartaToolStripLabel,
            this.spartaToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(841, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.FillByToolStrip_ItemClicked);
            // 
            // spartaToolStripLabel
            // 
            this.spartaToolStripLabel.Name = "spartaToolStripLabel";
            this.spartaToolStripLabel.Size = new System.Drawing.Size(49, 22);
            this.spartaToolStripLabel.Text = "FilterBy:";
            // 
            // spartaToolStripTextBox
            // 
            this.spartaToolStripTextBox.Name = "spartaToolStripTextBox";
            this.spartaToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(26, 22);
            this.fillByToolStripButton.Text = "Go";
            this.fillByToolStripButton.Click += new System.EventHandler(this.FillByToolStripButton_Click);
            // 
            // revenueExpenditureBooksTableAdapter
            // 
            this.revenueExpenditureBooksTableAdapter.ClearBeforeFill = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incomeDataGridViewTextBoxColumn
            // 
            this.incomeDataGridViewTextBoxColumn.DataPropertyName = "Income";
            this.incomeDataGridViewTextBoxColumn.HeaderText = "Income";
            this.incomeDataGridViewTextBoxColumn.Name = "incomeDataGridViewTextBoxColumn";
            this.incomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rawMaterialsDataGridViewTextBoxColumn
            // 
            this.rawMaterialsDataGridViewTextBoxColumn.DataPropertyName = "RawMaterials";
            this.rawMaterialsDataGridViewTextBoxColumn.HeaderText = "RawMaterials";
            this.rawMaterialsDataGridViewTextBoxColumn.Name = "rawMaterialsDataGridViewTextBoxColumn";
            this.rawMaterialsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenseDataGridViewTextBoxColumn
            // 
            this.expenseDataGridViewTextBoxColumn.DataPropertyName = "Expense";
            this.expenseDataGridViewTextBoxColumn.HeaderText = "Expense";
            this.expenseDataGridViewTextBoxColumn.Name = "expenseDataGridViewTextBoxColumn";
            this.expenseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countedDataGridViewTextBoxColumn
            // 
            this.countedDataGridViewTextBoxColumn.DataPropertyName = "Counted";
            this.countedDataGridViewTextBoxColumn.HeaderText = "Counted";
            this.countedDataGridViewTextBoxColumn.Name = "countedDataGridViewTextBoxColumn";
            this.countedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CheckOutPlusAndMinus
            // 
            this.CheckOutPlusAndMinus.DataPropertyName = "CheckOutPlusAndMinus";
            this.CheckOutPlusAndMinus.HeaderText = "CheckOutPlusAndMinus";
            this.CheckOutPlusAndMinus.Name = "CheckOutPlusAndMinus";
            this.CheckOutPlusAndMinus.ReadOnly = true;
            // 
            // UserRegisteredId
            // 
            this.UserRegisteredId.DataPropertyName = "UserRegisteredId";
            this.UserRegisteredId.HeaderText = "UserRegisteredId";
            this.UserRegisteredId.Name = "UserRegisteredId";
            this.UserRegisteredId.ReadOnly = true;
            // 
            // GridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 393);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GridView";
            this.Text = "GridView";
            this.Load += new System.EventHandler(this.GridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueExpenditureBooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueAccountBookDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RevenueAccountBookDataSet revenueAccountBookDataSet;
        private System.Windows.Forms.BindingSource revenueExpenditureBooksBindingSource;
        private Data.RevenueAccountBookDataSetTableAdapters.RevenueExpenditureBooksTableAdapter revenueExpenditureBooksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutPlusAndMinusDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel spartaToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox spartaToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawMaterialsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOutPlusAndMinus;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserRegisteredId;
    }
}