using System.Windows.Forms;
namespace App.WindowsApp.Views
{
    partial class DashboardView
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
            tblDashboard = new TableLayoutPanel();
            tblKpi = new TableLayoutPanel();
            pnlSales = new Panel();
            lblSalesValue = new Label();
            lblSalesTitle = new Label();
            pnlRevenue = new Panel();
            lblRevenueValue = new Label();
            lblRevenueTitle = new Label();
            pnlOrder = new Panel();
            lblOrderValue = new Label();
            lblOrderTitle = new Label();
            pnlLowStock = new Panel();
            lvLowStock = new ListView();
            Products = new ColumnHeader();
            Stock = new ColumnHeader();
            lblLowStock = new Label();
            pnlRecentOrders = new Panel();
            lvRecentOrders = new ListView();
            OrdersId = new ColumnHeader();
            CustomerName = new ColumnHeader();
            Total = new ColumnHeader();
            Status = new ColumnHeader();
            lblRecentOrders = new Label();
            tblDashboard.SuspendLayout();
            tblKpi.SuspendLayout();
            pnlSales.SuspendLayout();
            pnlRevenue.SuspendLayout();
            pnlOrder.SuspendLayout();
            pnlLowStock.SuspendLayout();
            pnlRecentOrders.SuspendLayout();
            SuspendLayout();
            // 
            // tblDashboard
            // 
            tblDashboard.ColumnCount = 1;
            tblDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblDashboard.Controls.Add(tblKpi, 0, 0);
            tblDashboard.Controls.Add(pnlLowStock, 0, 1);
            tblDashboard.Controls.Add(pnlRecentOrders, 0, 2);
            tblDashboard.Dock = DockStyle.Fill;
            tblDashboard.Location = new Point(0, 0);
            tblDashboard.Margin = new Padding(3, 4, 3, 4);
            tblDashboard.Name = "tblDashboard";
            tblDashboard.Padding = new Padding(16, 20, 16, 20);
            tblDashboard.RowCount = 3;
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 150F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboard.Size = new Size(864, 637);
            tblDashboard.TabIndex = 0;
            // 
            // tblKpi
            // 
            tblKpi.BackColor = SystemColors.Window;
            tblKpi.ColumnCount = 3;
            tblKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tblKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tblKpi.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34F));
            tblKpi.Controls.Add(pnlSales, 0, 0);
            tblKpi.Controls.Add(pnlRevenue, 2, 0);
            tblKpi.Controls.Add(pnlOrder, 1, 0);
            tblKpi.Dock = DockStyle.Fill;
            tblKpi.Location = new Point(19, 24);
            tblKpi.Margin = new Padding(3, 4, 3, 4);
            tblKpi.Name = "tblKpi";
            tblKpi.RowCount = 1;
            tblKpi.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblKpi.Size = new Size(826, 142);
            tblKpi.TabIndex = 0;
            // 
            // pnlSales
            // 
            pnlSales.BackColor = Color.White;
            pnlSales.Controls.Add(lblSalesValue);
            pnlSales.Controls.Add(lblSalesTitle);
            pnlSales.Dock = DockStyle.Fill;
            pnlSales.Location = new Point(3, 4);
            pnlSales.Margin = new Padding(3, 4, 3, 4);
            pnlSales.Name = "pnlSales";
            pnlSales.Size = new Size(266, 134);
            pnlSales.TabIndex = 0;
            // 
            // lblSalesValue
            // 
            lblSalesValue.AutoSize = true;
            lblSalesValue.Location = new Point(136, 62);
            lblSalesValue.Name = "lblSalesValue";
            lblSalesValue.Size = new Size(50, 20);
            lblSalesValue.TabIndex = 1;
            lblSalesValue.Text = "label2";
            // 
            // lblSalesTitle
            // 
            lblSalesTitle.AutoSize = true;
            lblSalesTitle.Location = new Point(42, 62);
            lblSalesTitle.Name = "lblSalesTitle";
            lblSalesTitle.Size = new Size(43, 20);
            lblSalesTitle.TabIndex = 0;
            lblSalesTitle.Text = "Sales";
            // 
            // pnlRevenue
            // 
            pnlRevenue.BackColor = Color.White;
            pnlRevenue.Controls.Add(lblRevenueValue);
            pnlRevenue.Controls.Add(lblRevenueTitle);
            pnlRevenue.Dock = DockStyle.Fill;
            pnlRevenue.Location = new Point(547, 4);
            pnlRevenue.Margin = new Padding(3, 4, 3, 4);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new Size(276, 134);
            pnlRevenue.TabIndex = 2;
            // 
            // lblRevenueValue
            // 
            lblRevenueValue.AutoSize = true;
            lblRevenueValue.Location = new Point(139, 62);
            lblRevenueValue.Name = "lblRevenueValue";
            lblRevenueValue.Size = new Size(50, 20);
            lblRevenueValue.TabIndex = 1;
            lblRevenueValue.Text = "label4";
            // 
            // lblRevenueTitle
            // 
            lblRevenueTitle.AutoSize = true;
            lblRevenueTitle.Location = new Point(40, 62);
            lblRevenueTitle.Name = "lblRevenueTitle";
            lblRevenueTitle.Size = new Size(65, 20);
            lblRevenueTitle.TabIndex = 0;
            lblRevenueTitle.Text = "Revenue";
            // 
            // pnlOrder
            // 
            pnlOrder.BackColor = Color.White;
            pnlOrder.Controls.Add(lblOrderValue);
            pnlOrder.Controls.Add(lblOrderTitle);
            pnlOrder.Dock = DockStyle.Fill;
            pnlOrder.Location = new Point(275, 4);
            pnlOrder.Margin = new Padding(3, 4, 3, 4);
            pnlOrder.Name = "pnlOrder";
            pnlOrder.Size = new Size(266, 134);
            pnlOrder.TabIndex = 3;
            // 
            // lblOrderValue
            // 
            lblOrderValue.AutoSize = true;
            lblOrderValue.Location = new Point(145, 66);
            lblOrderValue.Name = "lblOrderValue";
            lblOrderValue.Size = new Size(50, 20);
            lblOrderValue.TabIndex = 1;
            lblOrderValue.Text = "label2";
            // 
            // lblOrderTitle
            // 
            lblOrderTitle.AutoSize = true;
            lblOrderTitle.Location = new Point(32, 62);
            lblOrderTitle.Name = "lblOrderTitle";
            lblOrderTitle.Size = new Size(47, 20);
            lblOrderTitle.TabIndex = 0;
            lblOrderTitle.Text = "Order";
            // 
            // pnlLowStock
            // 
            pnlLowStock.BackColor = SystemColors.Window;
            pnlLowStock.Controls.Add(lvLowStock);
            pnlLowStock.Controls.Add(lblLowStock);
            pnlLowStock.Dock = DockStyle.Fill;
            pnlLowStock.Location = new Point(19, 174);
            pnlLowStock.Margin = new Padding(3, 4, 3, 4);
            pnlLowStock.Name = "pnlLowStock";
            pnlLowStock.Padding = new Padding(16, 20, 16, 20);
            pnlLowStock.Size = new Size(826, 215);
            pnlLowStock.TabIndex = 1;
            pnlLowStock.Paint += pnlLowStock_Paint;
            // 
            // lvLowStock
            // 
            lvLowStock.Columns.AddRange(new ColumnHeader[] { Products, Stock });
            lvLowStock.Dock = DockStyle.Fill;
            lvLowStock.FullRowSelect = true;
            lvLowStock.GridLines = true;
            lvLowStock.Location = new Point(16, 40);
            lvLowStock.Margin = new Padding(3, 4, 3, 4);
            lvLowStock.Name = "lvLowStock";
            lvLowStock.Size = new Size(794, 155);
            lvLowStock.TabIndex = 1;
            lvLowStock.UseCompatibleStateImageBehavior = false;
            lvLowStock.View = View.Details;
            lvLowStock.SelectedIndexChanged += lstLowStock_SelectedIndexChanged;
            // 
            // Products
            // 
            Products.Text = "Products";
            // 
            // Stock
            // 
            Stock.Text = "Stock";
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Dock = DockStyle.Top;
            lblLowStock.Location = new Point(16, 20);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(76, 20);
            lblLowStock.TabIndex = 0;
            lblLowStock.Text = "Low Stock";
            // 
            // pnlRecentOrders
            // 
            pnlRecentOrders.BackColor = SystemColors.Window;
            pnlRecentOrders.Controls.Add(lvRecentOrders);
            pnlRecentOrders.Controls.Add(lblRecentOrders);
            pnlRecentOrders.Dock = DockStyle.Fill;
            pnlRecentOrders.Location = new Point(19, 397);
            pnlRecentOrders.Margin = new Padding(3, 4, 3, 4);
            pnlRecentOrders.Name = "pnlRecentOrders";
            pnlRecentOrders.Padding = new Padding(16, 20, 16, 20);
            pnlRecentOrders.Size = new Size(826, 216);
            pnlRecentOrders.TabIndex = 2;
            // 
            // lvRecentOrders
            // 
            lvRecentOrders.Columns.AddRange(new ColumnHeader[] { OrdersId, CustomerName, Total, Status });
            lvRecentOrders.Dock = DockStyle.Fill;
            lvRecentOrders.GridLines = true;
            lvRecentOrders.Location = new Point(16, 40);
            lvRecentOrders.Margin = new Padding(3, 4, 3, 4);
            lvRecentOrders.Name = "lvRecentOrders";
            lvRecentOrders.Size = new Size(794, 156);
            lvRecentOrders.TabIndex = 1;
            lvRecentOrders.UseCompatibleStateImageBehavior = false;
            lvRecentOrders.View = View.Details;
            // 
            // OrdersId
            // 
            OrdersId.Text = "OrdersId";
            // 
            // CustomerName
            // 
            CustomerName.Text = "CustomerName";
            // 
            // Total
            // 
            Total.Text = "Total";
            // 
            // Status
            // 
            Status.Text = "Status";
            // 
            // lblRecentOrders
            // 
            lblRecentOrders.AutoSize = true;
            lblRecentOrders.Dock = DockStyle.Top;
            lblRecentOrders.Location = new Point(16, 20);
            lblRecentOrders.Name = "lblRecentOrders";
            lblRecentOrders.Size = new Size(106, 20);
            lblRecentOrders.TabIndex = 0;
            lblRecentOrders.Text = " Recent Orders";
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblDashboard);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardView";
            Size = new Size(864, 637);
            tblDashboard.ResumeLayout(false);
            tblKpi.ResumeLayout(false);
            pnlSales.ResumeLayout(false);
            pnlSales.PerformLayout();
            pnlRevenue.ResumeLayout(false);
            pnlRevenue.PerformLayout();
            pnlOrder.ResumeLayout(false);
            pnlOrder.PerformLayout();
            pnlLowStock.ResumeLayout(false);
            pnlLowStock.PerformLayout();
            pnlRecentOrders.ResumeLayout(false);
            pnlRecentOrders.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDashboard;
        private System.Windows.Forms.TableLayoutPanel tblKpi;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Label lblSalesValue;
        private System.Windows.Forms.Label lblSalesTitle;
        private System.Windows.Forms.Label lblRevenueValue;
        private System.Windows.Forms.Label lblRevenueTitle;
        private System.Windows.Forms.Label lblOrderValue;
        private System.Windows.Forms.Label lblOrderTitle;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.ListView lvLowStock;
        private System.Windows.Forms.Panel pnlRecentOrders;
        private System.Windows.Forms.Label lblRecentOrders;
        private System.Windows.Forms.ColumnHeader Products;
        private System.Windows.Forms.ColumnHeader Stock;
        private System.Windows.Forms.ListView lvRecentOrders;
        private System.Windows.Forms.ColumnHeader OrdersId;
        private System.Windows.Forms.ColumnHeader CustomerName;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.ColumnHeader Status;
    }
}
