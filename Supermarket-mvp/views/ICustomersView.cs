using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.views
{
    internal interface ICustomersView
    {
            string CustomersId { get; set; }
            string CustomersDocument_Number { get; set; }
            string CustomersFirts_Name { get; set; }
            string CustomersLast_Name { get; set; }
            string CustomersAddress { get; set; }
            string CustomersBirthday { get; set; }
            string CustomersPhone_Numbers { get; set; }
            string CustomersEmail { get; set; }
            string SearchValue { get; set; }
            bool IsEdit { get; set; }
            bool IsSuccessful { get; set; }
            string Message { get; set; }

            event EventHandler AddNewEvent;
            event EventHandler EditEvent;
            event EventHandler DeleteEvent;
            event EventHandler SaveEvent;
            event EventHandler CancelEvent;
            event EventHandler SearchEvent;


        void SetCustomersListBildingSource(BindingSource CustomersList);
            void Show();
        }
}
