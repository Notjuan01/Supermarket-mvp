using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.views;
using Supermarket_mvp.Models;


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
            throw new NotImplementedException();
        }

        private void SaveCustomers(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedCustomers(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelecCustomersToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewCustomers(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
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
