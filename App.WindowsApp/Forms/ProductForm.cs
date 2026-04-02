using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App.WindowsApp.Forms
{
    public partial class ProductForm : Form
    {
        ProductFormModeEnum _mode;
        Product _product;
        IProductService _service;

        public ProductForm(ProductFormModeEnum mode, Product? p, IProductService service)
        {

            InitializeComponent();

            nudPrice.Maximum = Decimal.MaxValue;
            nudStock.Maximum = Int32.MaxValue;

            cmbCategory.Items.Clear();
            cmbCategory.DataSource = Enum.GetValues(typeof(ProductCategoryEnum));
            cmbCategory.SelectedIndex = 0;



            cmbStatus.Items.Clear();
            cmbStatus.DataSource = Enum.GetValues(typeof(ProductStatusEnum));
            cmbStatus.SelectedIndex = 0;

            _mode = mode;
            _product = p;
            _service = service;

            if (mode == ProductFormModeEnum.Edit)
            {
                btnSave.Text = "Update";
            }
            else if (mode == ProductFormModeEnum.View)
            {
                btnSave.Visible = false;

            }
            if (mode == ProductFormModeEnum.Edit || mode == ProductFormModeEnum.View)
            {
                txbID.Text = p.Id;
                txbName.Text = p.Name;
                cmbCategory.SelectedItem = p.Category;
                cmbStatus.SelectedItem = p.Status;
                nudPrice.Value = p.Price;
                nudStock.Value = p.Stock;
            }


        }

        private void dudPrice_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void nudprice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_mode == ProductFormModeEnum.Add)
            {
                Product newProduct = new Product();
                newProduct.Name = txbName.Text;
                newProduct.Category = (ProductCategoryEnum)cmbCategory.SelectedItem;
                newProduct.Status = (ProductStatusEnum)cmbStatus.SelectedItem;
                newProduct.Price = nudPrice.Value;
                newProduct.Stock = (int)nudStock.Value;

                Product temp = _service.Add(newProduct);
                txbID.Text = temp?.Id ?? "";


                // Add logic
            }
            else if (_mode == ProductFormModeEnum.Edit)
            {
                _product.Name = txbName.Text;
                _product.Category = (ProductCategoryEnum)cmbCategory.SelectedItem;
                _product.Status = (ProductStatusEnum)cmbStatus.SelectedItem;
                _product.Price = nudPrice.Value;
                _product.Stock = (int)nudStock.Value;

                bool isUpdated = _service.Update(_product);
                // Update logic
            }

            this.Close();
        }

        private void pnlProductForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
