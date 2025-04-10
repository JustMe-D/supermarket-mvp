using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;
using System.Globalization;

namespace Supermarket_mvp.Presenters
{
    internal class ProductPresenter
    {
    private IProductView view;
    private IProductRepository repository;
    private BindingSource productBindingSource;
    private IEnumerable<ProductModel> productList;

        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.productBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewProduct;
            this.view.EditEvent += LoadSelectedProductToEdit;
            this.view.DeleteEvent += DeleteSelectedProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelProduct;

            this.view.SetProductListBindingSource(productBindingSource);

            LoadAllProductList();
            this.view.Show();
        }
        private void LoadAllProductList()
        {
            productList = repository.GetAll();
            productBindingSource.DataSource = productList;
        }

        private void SearchProduct(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                productList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productList = repository.GetAll();
            }
            productBindingSource.DataSource = productList;
        }

        private void AddNewProduct(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void LoadSelectedProductToEdit(object? sender, EventArgs e)
        {
            var product = (ProductModel) productBindingSource.Current;

            view.ProductId = product.Id.ToString();
            view.ProductNameText = product.Name;
            view.ProductNameText = product.Price.ToString();
        }

        private void DeleteSelectedProduct(object? sender, EventArgs e)
        {
            try
            {
                var payMode = (ProductModel)productBindingSource.Current;
                repository.Delete(payMode.Id);
                view.IsSuccessful = true;
                view.Message = "Product deleted successfully";
                LoadAllProductList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could'nt delete pay mode";
            }
        }

        private void SaveProduct(object? sender, EventArgs e)
        {
            var product = new ProductModel();

            product.Id = Convert.ToInt32(view.ProductId);
            product.Name = view.ProductNameText;
            product.Price = Convert.ToDecimal(view.ProductPrice, CultureInfo.InvariantCulture);
            

            try
            {
                new Common.ModelDataValidation().Validate(product);
                if (view.IsEdit)
                {
                    repository.Edit(product);
                    view.Message = "Product edited successfully";
                }
                else
                {
                    repository.Add(product);
                    view.Message = "Product added successfully";
                }
                view.IsSuccessful = true;
                LoadAllProductList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }
        private void CleanViewFields()
        {
            view.ProductId = "0";
            view.ProductNameText = "";
            view.ProductPrice = "";
        }

        private void CancelProduct(object? sender, EventArgs e)
        {
            CleanViewFields();
        }


    }
}
