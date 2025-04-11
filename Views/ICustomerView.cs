using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Views
{
    internal interface ICustomerView
    {
        string Customer_Id { get; set; }
        string Customer_Document { get; set; }
        string Customer_FirstName { get; set; }
        string Customer_LastName { get; set; }
        string Customer_Address { get; set; }
        DateTime? Customer_Birthday { get; set; }
        string Customer_PhoneNumber { get; set; }
        string Customer_Email { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetCustomerListBindingSource(BindingSource customerList);
        void Show();
    }
}
