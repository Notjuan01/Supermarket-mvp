﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.views
{
    internal interface ICategoriesView
    {
        String CategoriesId { get; set; }
        string CategoriesName { get; set; }
        string CategoriesDescription { get; set; }

        string SearchValue { get; set; }
        bool IsEdit {  get; set; }
        bool IsSusccesful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;


        void SetCategoriesListBildingSource(BindingSource customersList);
        void Show();
    }
}
