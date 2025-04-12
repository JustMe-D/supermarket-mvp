using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.Presenters
{
    internal class CustomerPresenter
    {
        private ICustomerView view;
        private ICustomerRepository repository;
        private BindingSource customerBindingSource;
        private IEnumerable<CustomerModel> customerList;

        public CustomerPresenter(ICustomerView view, ICustomerRepository repository)
        {
            this.customerBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCustomer;
            this.view.AddNewEvent += AddNewCustomer;
            this.view.EditEvent += LoadSelectCustomerToEdit;
            this.view.DeleteEvent += DeleteSelectedCustomer;
            this.view.SaveEvent += SaveCustomer;
            this.view.CancelEvent += CancelAction;

            this.view.SetCustomerListBindingSource(customerBindingSource);

            LoadAllCustomerList();
            this.view.Show();
        }

        private void LoadAllCustomerList()
        {
            customerList = repository.GetAll();
            customerBindingSource.DataSource = customerList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();

        }

        private void SaveCustomer(object? sender, EventArgs e)
        {
            var customer = new CustomerModel();
            customer.Id = Convert.ToInt32(view.Customer_Id);
            customer.DocumentNumber = view.Customer_Document;
            customer.FirstName = view.Customer_FirstName;
            customer.LastName = view.Customer_LastName;
            customer.Address = view.Customer_Address;
            customer.Birthday = view.Customer_Birthday;
            customer.PhoneNumber = view.Customer_PhoneNumber;
            customer.Email = view.Customer_Email;

            try
            {
                new Common.ModelDataValidation().Validate(customer);
                if (view.IsEdit)
                {
                    repository.Edit(customer);
                    view.Message = "Customer updated successfully";
                }
                else
                {
                    repository.Add(customer);
                    view.Message = "Customer added successfully";
                }
                view.IsSuccesful = true;
                LoadAllCustomerList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = ex.Message;
            }
            
        }

        private void CleanViewFields()
        {
            view.Customer_Id = "0";
            view.Customer_Document = "";
            view.Customer_FirstName = "";
            view.Customer_LastName = "";
            view.Customer_Address = "";
            view.Customer_Birthday = null;
            view.Customer_PhoneNumber = "";
            view.Customer_Email = "";
        }
        private void DeleteSelectedCustomer(object? sender, EventArgs e)
        {
            try
            {
                var customer = (CustomerModel)customerBindingSource.Current;
                if (customer != null)
                {
                    repository.Delete(customer.Id);
                    view.IsSuccesful = true;
                    view.Message = "Customer deleted successfully";
                    LoadAllCustomerList();
                }
            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = "An error ocurred, could not delete Customer";
            }
        }

        private void LoadSelectCustomerToEdit(object? sender, EventArgs e)
        {
            var customer = (CustomerModel)customerBindingSource.Current;

            view.Customer_Id = customer.Id.ToString();
            view.Customer_Document = customer.DocumentNumber;
            view.Customer_FirstName = customer.FirstName;
            view.Customer_LastName = customer.LastName;
            view.Customer_Address = customer.Address;
            view.Customer_Birthday = customer.Birthday;
            view.Customer_PhoneNumber = customer.PhoneNumber;
            view.Customer_Email = customer.Email;

            view.IsEdit = true;
        }

        private void AddNewCustomer(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCustomer(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                customerList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                customerList = repository.GetAll();
            }
            customerBindingSource.DataSource = customerList;
        }
    }
}
