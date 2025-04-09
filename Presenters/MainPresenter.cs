using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Views;
using Supermarket_mvp.Models;
using Supermarket_mvp._Repositories;

namespace Supermarket_mvp.Presenters
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
            this.mainView.ShowProductsView += ShowProductsView;
        }

        private void ShowProductsView(object? sender, EventArgs e)
        {
            IProductView View = ProductView.GetInstance((MainView)mainView);
            IProductRepository Repository = new ProductRepository(sqlConnectionString);
            new ProductPresenter(View, Repository);
        }

        private void ShowPayModeView(object? sender, EventArgs e)
        {

            IPayModeView View = PayModeView.GetInstance((MainView)mainView);
            IPayModeRepository Repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(View, Repository);
        }
    }
}
