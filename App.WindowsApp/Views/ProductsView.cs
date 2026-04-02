
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core.Contracts;
using App.Core.Utilities;
using App.WindowsApp.Forms;
using App.Core.Models;


namespace App.WindowsApp.Views
{
    public partial class ProductsView : UserControl
    {
        IProductService _service;
        BindingSource _dgvBindingSource = new BindingSource();

        public ProductsView(IProductService _ser)
        {
            _service = _ser;
            InitializeComponent();
            dgvProducts.DataSource = _dgvBindingSource;
        }

        private void ProductsView_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Clear();
            var categories = new List<object> { "--All--" };
            categories.AddRange(Enum.GetValues(typeof(ProductCategoryEnum)).Cast<object>());
            cmbCategory.DataSource = categories;
            cmbCategory.SelectedIndex = 0;
           


            cmbStockStatus.Items.Clear();
            var stockstatus = new List<object> { "--All--" };
            stockstatus.AddRange(Enum.GetValues(typeof(ProductStatusEnum)).Cast<object>());
            cmbStockStatus.DataSource = stockstatus;
            cmbStockStatus.SelectedIndex = 0;
           

            if (_service == null)
                return;

            // _service.GetAll();
            _dgvBindingSource.DataSource = _service.GetAll();

        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            ProductForm prodForm = new ProductForm(ProductFormModeEnum.Add, null, _service);
            prodForm.ShowDialog();

            RefreshGrid();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.Edit, selectedProduct, _service);
                prodForm.ShowDialog();

                RefreshGrid();
            }
        }

        private void tsbView_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.View, selectedProduct, _service);
                prodForm.ShowDialog();
            }
        }
        private void RefreshGrid()
        {
            string searchText = txbSearch.Text;
            ProductCategoryEnum? selectedCategory = null;
            if (cmbCategory.SelectedItem != null)
            {
                if (cmbCategory.SelectedItem.ToString().Equals("--All--"))
                {
                    selectedCategory = null;
                }
                else
                {
                    selectedCategory = (ProductCategoryEnum)cmbCategory.SelectedItem;
                }
                ProductStatusEnum? selectedStatus = null;
                if (cmbStockStatus.SelectedItem != null)
                {
                    if (cmbStockStatus.SelectedItem.ToString().Equals("--All--"))
                    {
                        selectedStatus = null;
                    }
                    else
                    {
                        selectedStatus = (ProductStatusEnum)cmbStockStatus.SelectedItem;
                    }



                    _dgvBindingSource.DataSource = _service.Search(searchText, selectedCategory, selectedStatus);

                }
            }
        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmbStockStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
