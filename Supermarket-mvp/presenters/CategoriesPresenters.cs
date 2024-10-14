using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.views;
using Supermarket_mvp.Models;

namespace Supermarket_mvp.presenters
{
    internal class CategoriesPresenters
    {
        private ICategoriesView view;
        private ICategoriesRepository repository;
        private BindingSource categoriesBindingSource;
        private IEnumerable<CategoriesModel> categoriesList;


        public CategoriesPresenters(ICategoriesView view, ICategoriesRepository repository)
        {
            categoriesBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCustomers;
            this.view.AddNewEvent += AddNewCustomers;
            this.view.EditEvent += LoadSelectCategoriesToEdit;
            this.view.DeleteEvent += DeleteSelectedCategories;
            this.view.SaveEvent += SaveCategories;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategoriesListBildingSource(categoriesBindingSource);

            loadAllCategorieslist();

            this.view.Show();
        }
        private void loadAllCategorieslist()
        {
            categoriesList = repository.GetAll();
            categoriesBindingSource.DataSource = categoriesList;
        }
        private void SearchCustomers(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrEmpty(view.SearchValue);
            if (emptyValue == false)
            {
                categoriesList = repository.GetByValue(view.SearchValue);
            }
            else
            {
                categoriesList = repository.GetAll();
            }
            categoriesBindingSource.DataSource = categoriesList;
        }

        private void AddNewCustomers(object? sender, EventArgs e)
        {
            MessageBox.Show("Hizo clic en el boton nuevo");
        }

        private void LoadSelectCategoriesToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelectedCategories(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SaveCategories(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
