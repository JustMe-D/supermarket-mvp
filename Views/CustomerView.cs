using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class CustomerView : Form, ICustomerView
    {
        private bool isEdit;
        private bool isSuccesful;
        private string message;
        public CustomerView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageCustomerDetail);

            BtnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        public string Customer_Id 
        { 
            get { return TxtCustomerId.Text; }
            set { TxtCustomerId.Text = value; }

        }
        public string Customer_Document
        {
            get { return TxtCustomerDocument.Text; }
            set { TxtCustomerDocument.Text = value; }

        }
        public string Customer_FirstName
        {
            get { return TxtCustomerFirstName.Text; }
            set { TxtCustomerFirstName.Text = value; }

        }
        public string Customer_LastName
        {
            get { return TxtCustomerLastName.Text; }
            set { TxtCustomerLastName.Text = value; }

        }
        public string Customer_Address
        {
            get { return TxtCustomerAddress.Text; }
            set { TxtCustomerAddress.Text = value; }

        }
        public DateTime? Customer_Birthday 
        {
            get { return DtpCustomerBirthday.Value; }
            set { DtpCustomerBirthday.Value = value ?? DateTime.Now; }

        }
        public string Customer_PhoneNumber 
        {
            get { return TxtCustomerPhoneNumber.Text; }
            set { TxtCustomerPhoneNumber.Text = value; }

        }
        public string Customer_Email 
        {
            get { return TxtCustomerEmail.Text; }
            set { TxtCustomerEmail.Text = value; }

        }

        public string SearchValue 
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }

        public bool IsEdit 
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccesful
        {
            get { return isSuccesful; }
            set { isSuccesful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetCustomerListBindingSource(BindingSource customerList)
        {
            DgCustomer.DataSource = customerList;
        }
        private static CustomerView instance;

        public static CustomerView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CustomerView();  
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
                return instance;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
