namespace App.WindowsApp.Views
{
    partial class ProductsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsView));
            tblProducts = new TableLayoutPanel();
            pnlToolbar = new Panel();
            tsProducts = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbView = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            tsbRefresh = new ToolStripButton();
            pnlFilters = new Panel();
            tblFilter = new TableLayoutPanel();
            lblSearch = new Label();
            lblCategory = new Label();
            lblStockStatus = new Label();
            txbSearch = new TextBox();
            cmbCategory = new ComboBox();
            cmbStockStatus = new ComboBox();
            pnlGrid = new Panel();
            dgvProducts = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColName = new DataGridViewTextBoxColumn();
            ColCategory = new DataGridViewTextBoxColumn();
            ColPrice = new DataGridViewTextBoxColumn();
            ColStock = new DataGridViewTextBoxColumn();
            ColStatus = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tblProducts.SuspendLayout();
            pnlToolbar.SuspendLayout();
            tsProducts.SuspendLayout();
            pnlFilters.SuspendLayout();
            tblFilter.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // tblProducts
            // 
            tblProducts.ColumnCount = 1;
            tblProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblProducts.Controls.Add(pnlToolbar, 0, 0);
            tblProducts.Controls.Add(pnlFilters, 0, 1);
            tblProducts.Controls.Add(pnlGrid, 0, 2);
            tblProducts.Dock = DockStyle.Fill;
            tblProducts.Location = new Point(0, 0);
            tblProducts.Margin = new Padding(3, 4, 3, 4);
            tblProducts.Name = "tblProducts";
            tblProducts.Padding = new Padding(16, 20, 16, 20);
            tblProducts.RowCount = 3;
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblProducts.Size = new Size(925, 539);
            tblProducts.TabIndex = 0;
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = SystemColors.Window;
            pnlToolbar.Controls.Add(tsProducts);
            pnlToolbar.Dock = DockStyle.Fill;
            pnlToolbar.Location = new Point(19, 24);
            pnlToolbar.Margin = new Padding(3, 4, 3, 4);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(887, 62);
            pnlToolbar.TabIndex = 0;
            // 
            // tsProducts
            // 
            tsProducts.Dock = DockStyle.Fill;
            tsProducts.GripStyle = ToolStripGripStyle.Hidden;
            tsProducts.ImageScalingSize = new Size(20, 20);
            tsProducts.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbView, tsbDelete, tsbRefresh });
            tsProducts.Location = new Point(0, 0);
            tsProducts.Name = "tsProducts";
            tsProducts.Size = new Size(887, 62);
            tsProducts.TabIndex = 0;
            tsProducts.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            tsbAdd.Image = (Image)resources.GetObject("tsbAdd.Image");
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(61, 59);
            tsbAdd.Text = "Add";
            tsbAdd.Click += tsbAdd_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.Image = (Image)resources.GetObject("tsbEdit.Image");
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(59, 59);
            tsbEdit.Text = "Edit";
            tsbEdit.Click += tsbEdit_Click;
            // 
            // tsbView
            // 
            tsbView.Image = (Image)resources.GetObject("tsbView.Image");
            tsbView.ImageTransparentColor = Color.Magenta;
            tsbView.Name = "tsbView";
            tsbView.Size = new Size(65, 59);
            tsbView.Text = "View";
            tsbView.Click += tsbView_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.Image = (Image)resources.GetObject("tsbDelete.Image");
            tsbDelete.ImageTransparentColor = Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(77, 59);
            tsbDelete.Text = "Delete";
            // 
            // tsbRefresh
            // 
            tsbRefresh.Image = (Image)resources.GetObject("tsbRefresh.Image");
            tsbRefresh.ImageTransparentColor = Color.Magenta;
            tsbRefresh.Name = "tsbRefresh";
            tsbRefresh.Size = new Size(82, 59);
            tsbRefresh.Text = "Refresh";
            // 
            // pnlFilters
            // 
            pnlFilters.BackColor = SystemColors.Window;
            pnlFilters.Controls.Add(tblFilter);
            pnlFilters.Dock = DockStyle.Fill;
            pnlFilters.Location = new Point(19, 94);
            pnlFilters.Margin = new Padding(3, 4, 3, 4);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Padding = new Padding(12);
            pnlFilters.Size = new Size(887, 97);
            pnlFilters.TabIndex = 1;
            // 
            // tblFilter
            // 
            tblFilter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblFilter.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblFilter.ColumnCount = 3;
            tblFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblFilter.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblFilter.Controls.Add(lblSearch, 0, 0);
            tblFilter.Controls.Add(lblCategory, 1, 0);
            tblFilter.Controls.Add(lblStockStatus, 2, 0);
            tblFilter.Controls.Add(txbSearch, 0, 1);
            tblFilter.Controls.Add(cmbCategory, 1, 1);
            tblFilter.Controls.Add(cmbStockStatus, 2, 1);
            tblFilter.Dock = DockStyle.Fill;
            tblFilter.Location = new Point(12, 12);
            tblFilter.Margin = new Padding(3, 4, 3, 4);
            tblFilter.Name = "tblFilter";
            tblFilter.RowCount = 2;
            tblFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFilter.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFilter.Size = new Size(863, 73);
            tblFilter.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Fill;
            lblSearch.Location = new Point(4, 1);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(337, 35);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Location = new Point(348, 1);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(251, 35);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category";
            // 
            // lblStockStatus
            // 
            lblStockStatus.AutoSize = true;
            lblStockStatus.Dock = DockStyle.Fill;
            lblStockStatus.Location = new Point(606, 1);
            lblStockStatus.Name = "lblStockStatus";
            lblStockStatus.Size = new Size(253, 35);
            lblStockStatus.TabIndex = 2;
            lblStockStatus.Text = "StockStatus";
            // 
            // txbSearch
            // 
            txbSearch.Dock = DockStyle.Fill;
            txbSearch.Location = new Point(4, 41);
            txbSearch.Margin = new Padding(3, 4, 3, 4);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(337, 27);
            txbSearch.TabIndex = 3;
            txbSearch.TextChanged += txbSearch_TextChanged;
            // 
            // cmbCategory
            // 
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(348, 41);
            cmbCategory.Margin = new Padding(3, 4, 3, 4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(251, 28);
            cmbCategory.TabIndex = 4;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // cmbStockStatus
            // 
            cmbStockStatus.Dock = DockStyle.Fill;
            cmbStockStatus.FormattingEnabled = true;
            cmbStockStatus.Location = new Point(606, 41);
            cmbStockStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStockStatus.Name = "cmbStockStatus";
            cmbStockStatus.Size = new Size(253, 28);
            cmbStockStatus.TabIndex = 5;
            cmbStockStatus.SelectedIndexChanged += cmbStockStatus_SelectedIndexChanged;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = SystemColors.Window;
            pnlGrid.Controls.Add(dgvProducts);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(19, 199);
            pnlGrid.Margin = new Padding(3, 4, 3, 4);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(12, 15, 12, 15);
            pnlGrid.Size = new Size(887, 316);
            pnlGrid.TabIndex = 2;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = SystemColors.Window;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { ColId, ColName, ColCategory, ColPrice, ColStock, ColStatus });
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(12, 15);
            dgvProducts.Margin = new Padding(3, 4, 3, 4);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.RowTemplate.Height = 24;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(863, 286);
            dgvProducts.TabIndex = 0;
            // 
            // ColId
            // 
            ColId.DataPropertyName = "Id";
            ColId.HeaderText = "Id";
            ColId.MinimumWidth = 6;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            // 
            // ColName
            // 
            ColName.DataPropertyName = "Name";
            ColName.HeaderText = "Name";
            ColName.MinimumWidth = 6;
            ColName.Name = "ColName";
            ColName.ReadOnly = true;
            // 
            // ColCategory
            // 
            ColCategory.DataPropertyName = "Category";
            ColCategory.HeaderText = "Category";
            ColCategory.MinimumWidth = 6;
            ColCategory.Name = "ColCategory";
            ColCategory.ReadOnly = true;
            // 
            // ColPrice
            // 
            ColPrice.DataPropertyName = "Price";
            ColPrice.HeaderText = "Price";
            ColPrice.MinimumWidth = 6;
            ColPrice.Name = "ColPrice";
            ColPrice.ReadOnly = true;
            // 
            // ColStock
            // 
            ColStock.DataPropertyName = "Stock";
            ColStock.HeaderText = "Stock";
            ColStock.MinimumWidth = 6;
            ColStock.Name = "ColStock";
            ColStock.ReadOnly = true;
            // 
            // ColStatus
            // 
            ColStatus.DataPropertyName = "Status";
            ColStatus.HeaderText = "Status";
            ColStatus.MinimumWidth = 6;
            ColStatus.Name = "ColStatus";
            ColStatus.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblProducts);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductsView";
            Size = new Size(925, 539);
            Load += ProductsView_Load;
            tblProducts.ResumeLayout(false);
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            tsProducts.ResumeLayout(false);
            tsProducts.PerformLayout();
            pnlFilters.ResumeLayout(false);
            tblFilter.ResumeLayout(false);
            tblFilter.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblProducts;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.ToolStrip tsProducts;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbView;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.TableLayoutPanel tblFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblStockStatus;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbStockStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvProducts;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColName;
        private DataGridViewTextBoxColumn ColCategory;
        private DataGridViewTextBoxColumn ColPrice;
        private DataGridViewTextBoxColumn ColStock;
        private DataGridViewTextBoxColumn ColStatus;
    }
}
