namespace App.WindowsApp.Forms
{
    partial class ProductForm
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
            components = new System.ComponentModel.Container();
            pnlProductForm = new Panel();
            pnlproductBottom = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tblProductForm = new TableLayoutPanel();
            lblName = new Label();
            lblCategory = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            lblStatus = new Label();
            lblID = new Label();
            txbName = new TextBox();
            txbID = new TextBox();
            cmbCategory = new ComboBox();
            cmbStatus = new ComboBox();
            nudPrice = new NumericUpDown();
            nudStock = new NumericUpDown();
            contextMenuStrip1 = new ContextMenuStrip(components);
            pnlProductForm.SuspendLayout();
            pnlproductBottom.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tblProductForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
            SuspendLayout();
            // 
            // pnlProductForm
            // 
            pnlProductForm.BackColor = SystemColors.Window;
            pnlProductForm.Controls.Add(pnlproductBottom);
            pnlProductForm.Controls.Add(tblProductForm);
            pnlProductForm.Dock = DockStyle.Fill;
            pnlProductForm.Location = new Point(0, 0);
            pnlProductForm.Name = "pnlProductForm";
            pnlProductForm.Padding = new Padding(16);
            pnlProductForm.Size = new Size(800, 450);
            pnlProductForm.TabIndex = 0;
            pnlProductForm.Paint += pnlProductForm_Paint;
            // 
            // pnlproductBottom
            // 
            pnlproductBottom.Controls.Add(flowLayoutPanel1);
            pnlproductBottom.Dock = DockStyle.Bottom;
            pnlproductBottom.Location = new Point(16, 346);
            pnlproductBottom.Name = "pnlproductBottom";
            pnlproductBottom.Padding = new Padding(16);
            pnlproductBottom.Size = new Size(768, 88);
            pnlproductBottom.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(16, 19);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(736, 53);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Dock = DockStyle.Fill;
            btnSave.Image = Properties.Resources.file_download;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(639, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 47);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleLeft;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Image = Properties.Resources.cancel1;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(539, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 47);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleLeft;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // tblProductForm
            // 
            tblProductForm.ColumnCount = 2;
            tblProductForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tblProductForm.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tblProductForm.Controls.Add(lblName, 0, 0);
            tblProductForm.Controls.Add(lblCategory, 0, 1);
            tblProductForm.Controls.Add(lblPrice, 0, 2);
            tblProductForm.Controls.Add(lblStock, 0, 3);
            tblProductForm.Controls.Add(lblStatus, 0, 4);
            tblProductForm.Controls.Add(lblID, 0, 5);
            tblProductForm.Controls.Add(txbName, 1, 0);
            tblProductForm.Controls.Add(txbID, 1, 5);
            tblProductForm.Controls.Add(cmbCategory, 1, 1);
            tblProductForm.Controls.Add(cmbStatus, 1, 4);
            tblProductForm.Controls.Add(nudPrice, 1, 2);
            tblProductForm.Controls.Add(nudStock, 1, 3);
            tblProductForm.Dock = DockStyle.Top;
            tblProductForm.Location = new Point(16, 16);
            tblProductForm.Name = "tblProductForm";
            tblProductForm.RowCount = 6;
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Percent, 15.8878508F));
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Percent, 16.82243F));
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblProductForm.Size = new Size(768, 214);
            tblProductForm.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(114, 35);
            lblName.TabIndex = 6;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Location = new Point(3, 35);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(114, 35);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            lblCategory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Dock = DockStyle.Fill;
            lblPrice.Location = new Point(3, 70);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(114, 34);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price";
            lblPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Dock = DockStyle.Fill;
            lblStock.Location = new Point(3, 104);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(114, 36);
            lblStock.TabIndex = 9;
            lblStock.Text = "Stock";
            lblStock.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Location = new Point(3, 140);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(114, 35);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Dock = DockStyle.Fill;
            lblID.Location = new Point(3, 175);
            lblID.Name = "lblID";
            lblID.Size = new Size(114, 39);
            lblID.TabIndex = 11;
            lblID.Text = "ID";
            lblID.TextAlign = ContentAlignment.MiddleLeft;
            lblID.Click += lblID_Click;
            // 
            // txbName
            // 
            txbName.Dock = DockStyle.Fill;
            txbName.Location = new Point(123, 3);
            txbName.Name = "txbName";
            txbName.Size = new Size(642, 27);
            txbName.TabIndex = 0;
            // 
            // txbID
            // 
            txbID.BackColor = SystemColors.Window;
            txbID.Dock = DockStyle.Fill;
            txbID.Location = new Point(123, 178);
            txbID.Name = "txbID";
            txbID.ReadOnly = true;
            txbID.Size = new Size(642, 27);
            txbID.TabIndex = 5;
            // 
            // cmbCategory
            // 
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(123, 38);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(642, 28);
            cmbCategory.TabIndex = 1;
            // 
            // cmbStatus
            // 
            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(123, 143);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(642, 28);
            cmbStatus.TabIndex = 4;
            // 
            // nudPrice
            // 
            nudPrice.Dock = DockStyle.Fill;
            nudPrice.Location = new Point(123, 73);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(642, 27);
            nudPrice.TabIndex = 2;
            nudPrice.ValueChanged += nudprice_ValueChanged;
            // 
            // nudStock
            // 
            nudStock.Dock = DockStyle.Fill;
            nudStock.Location = new Point(123, 107);
            nudStock.Name = "nudStock";
            nudStock.Size = new Size(642, 27);
            nudStock.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlProductForm);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductForm";
            FormClosing += ProductForm_FormClosing;
            pnlProductForm.ResumeLayout(false);
            pnlproductBottom.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tblProductForm.ResumeLayout(false);
            tblProductForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlProductForm;
        private TableLayoutPanel tblProductForm;
        private Panel pnlproductBottom;
        private Label lblName;
        private Label lblCategory;
        private Label lblPrice;
        private Label lblStock;
        private Label lblStatus;
        private Label lblID;
        private TextBox txbName;
        private TextBox txbID;
        private ComboBox cmbCategory;
        private ComboBox cmbStatus;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnCancel;
        private Button btnSave;
        private NumericUpDown nudPrice;
        private NumericUpDown nudStock;
        private ContextMenuStrip contextMenuStrip1;
    }
}