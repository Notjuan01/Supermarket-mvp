using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.views;
using Supermarket_mvp.Repositories;
using Supermarket_mvp._Repositories;
using Supermarket_mvp.Presenters;

namespace Supermarket_mvp.presenters
{
    internal class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;

            this.mainView.ShowPayModeView += ShowPayModeView;
            this.mainView.ShowCustomerView += ShowCustomersView;
        }

        private void ShowCustomersView(object? sender, EventArgs e)
        {
            ICustomersView view = CustomersView.GetInstance((MainView)mainView);
            ICustomersRepostory repository = new CustomersRepository(sqlConnectionString);
            new CustomersPresenter(view, repository);
        }

        private void ShowPayModeView(object? sender, EventArgs e)
        {
            IPayModeView view = PayModeView.GetInstance((MainView)mainView);
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);
        }
    }
}
