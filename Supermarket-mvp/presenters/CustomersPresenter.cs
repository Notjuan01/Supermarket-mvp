using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.views;
using Supermarket_mvp.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Supermarket_mvp.presenters
{
    internal class CustomersPresenter
    {
        private ICustomersView view;
        private ICustomersRepostory repository;
        private BindingSource customersBindingSource;
        private IEnumerable<CustomersModel> customersList;

        public CustomersPresenter(ICustomersView view, ICustomersRepostory repository)
        {
            this.customersBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCustomers;
            this.view.AddNewEvent += AddNewCustomers;
            this.view.EditEvent += LoadSelecCustomersToEdit;
            this.view.DeleteEvent += DeleteSelectedCustomers;
            this.view.SaveEvent += SaveCustomers;
            this.view.CancelEvent += CancelAction;

            this.view.SetCustomersListBildingSource(customersBindingSource);

            LoadAllCustomersList();

            this.view.Show();
        }

        private void LoadAllCustomersList()
        {
            customersList = repository.GetAll();
            customersBindingSource.DataSource = customersList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
        CleanViewFields();
        }

        private void SaveCustomers(object? sender, EventArgs e)
        {
            var customers = new CustomersModel();
            customers.Id = Convert.ToInt32(view.CustomersId);
            customers.document_number = view.CustomersDocument_Number;
            customers.firts_name = view.CustomersFirts_Name;
            customers.last_name = view.CustomersLast_Name;
            customers.address = view.CustomersAddress;
            customers.birthday = DateTime.TryParse(view.CustomersBirthday, out var parsedDate) ? parsedDate : customers.birthday;
            customers.phone_numbers = view.CustomersPhone_Numbers;
            customers.email = view.CustomersEmail;

            try
            {
                if (view.IsEdit)
                {
                    repository.Edit(customers);
                    view.Message = "Customers edited sucessfuly";
                }
                else
                {
                    repository.Add(customers);
                    view.Message = "Customers added succesfuly";
                }
            }
            catch(Exception ex) 
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }
        private void CleanViewFields()
        {
            view.CustomersId = "0";
            view.CustomersDocument_Number = "";
            view.CustomersFirts_Name = "";
            view.CustomersLast_Name = "";
            view.CustomersAddress = "";
            view.CustomersBirthday = "";
            view.CustomersPhone_Numbers = "";
            view.CustomersEmail = "";


        }



        private void DeleteSelectedCustomers(object? sender, EventArgs e)
        {
            try
            {
                var customers = (CustomersModel)customersBindingSource.Current;
                repository.Delete(customers.Id);
                view.IsSuccessful = true;
                view.Message = "Customers deleted Successfuly";
                LoadAllCustomersList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete customer";
            }
        }

        private void LoadSelecCustomersToEdit(object? sender, EventArgs e)
        {
        var customers = (CustomersModel)customersBindingSource.Current;

            view.CustomersId = customers.Id.ToString();
            view.CustomersDocument_Number = customers.document_number;
            view.CustomersFirts_Name = customers.firts_name;
            view.CustomersLast_Name = customers.last_name;
            view.CustomersAddress = customers.address;
            view.CustomersBirthday = customers.birthday.ToString();
            view.CustomersPhone_Numbers = customers.phone_numbers;
            view.CustomersEmail = customers.email;

        }

        private void AddNewCustomers(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchCustomers(object? sender, EventArgs e)
        {
            bool emptyvalue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if(emptyvalue == false)
            {
                customersList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                customersList = repository.GetAll();
            }
            customersBindingSource.DataSource = customersList;
        }
    }
}
