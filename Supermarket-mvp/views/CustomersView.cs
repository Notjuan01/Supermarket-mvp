﻿using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Azure.Core.HttpHeader;

namespace Supermarket_mvp.views
{
    public partial class CustomersView : Form, ICustomersView
    {
        private bool isEdit;
        private bool isSuccessfull;
        private string menssage;

        public CustomersView()
        {
            InitializeComponent();
            AssociateAndRaizeViewEvents();

            tabControl1.TabPages.Remove(tabPageCustomersDetails);
            BtnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaizeViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            TxtSearchC.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            BtnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCustomersLists);
                tabControl1.TabPages.Add(tabPageCustomersDetails);
                tabPageCustomersDetails.Text = "Add New Customers";
            };
            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCustomersLists);
                tabControl1.TabPages.Add(tabPageCustomersDetails);
                tabPageCustomersDetails.Text = "Edit New Customers";
            };
            BtnDelete.Click += delegate
            {
                DeleteEvent?.Invoke(this, EventArgs.Empty);
                var result = MessageBox.Show(

                    "Are you sure you want to delete the selected Customers",
                    "warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }

            };

            BtnSaveC.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessfull)
                {
                    tabControl1.TabPages.Remove(tabPageCustomersDetails);
                    tabControl1.TabPages.Add(tabPageCustomersLists);
                }
                MessageBox.Show(Message);
            };
            {
                {
                    AddNewEvent?.Invoke(this, EventArgs.Empty);
                    tabControl1.TabPages.Remove(tabPageCustomersDetails);
                    tabControl1.TabPages.Add(tabPageCustomersDetails);
                    tabPageCustomersDetails.Text = "Add Customers";
                };

                BtnCancelC.Click += delegate
                {
                    CancelEvent?.Invoke(this, EventArgs.Empty);

                    tabControl1.TabPages.Remove(tabPageCustomersDetails);
                    tabControl1.TabPages.Add(tabPageCustomersLists);
                };
            }
        }

        public string CustomersId
        {
            get { return TxtCId.Text; }
            set { TxtCId.Text = value; }
        }
        public string CustomersDocument_Number
        {
            get { return TxtDocument.Text; }
            set { TxtDocument.Text = value; }
        }
        public string CustomersFirts_Name
        {
            get { return TxtcName.Text; }
            set { TxtcName.Text = value; }
        }
        public string CustomersLast_Name
        {
            get { return TxtLastName.Text; }
            set { TxtLastName.Text = value; }
        }
        public string CustomersAddress
        {
            get { return TxtAddress.Text; }
            set { TxtAddress.Text = value; }
        }
        public string CustomersBirthday
        {
            get { return TxtBirthdayC.Text; }
            set { TxtBirthdayC.Text = value; }
        }
        public string CustomersPhone_Numbers
        {
            get { return TxtPhoneC.Text; }
            set { TxtPhoneC.Text = value; }
        }
        public string CustomersEmail
        {
            get { return TxtEmailC.Text; }
            set { TxtEmailC.Text = value; }
        }

        public string SearchValue
        {
            get { return TxtSearchC.Text; }
            set { TxtSearchC.Text = value; }
        }

        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessfull; }
            set { isSuccessfull = value; }
        }
        public string Message
        {
            get { return menssage; }
            set { menssage = value; }
        }
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler SearchEvent;

        public void SetCustomersListBildingSource(BindingSource CustomersList)
        {
            DgCustomers.DataSource = CustomersList;
        }
        private static CustomersView instance;


        public static CustomersView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CustomersView();
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
    }
}
