using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DGVPrinterHelper;

namespace Green_Enviro_App
{
    public partial class Main_Form : Form
    {
        LoginForm _login_form;
        Receipt _receipt;
        Database _database;
        Purchases _purchases;
        Sales _sales;
        Expenses _expenses;
        Wages _wages;
		Destruction_Certificate _destruction_certificate;
        Summaries _summaries;
        Customers _customers;
        NewCustomer _new_customer;
        Email _email;
        Inventory _inventory;
        Employees _employees;
        Purchases_PR _purchasesPR;
        FileHandles _fileHandles;

        TabPage _previous_tab_page;
        TabPage _current_tab_page;

        DeliveryNotesModel _deliveryNotesModel;
        bool starting = true;

        public int _user_permission_level = 0;

		/// <summary>This is the main class for the program. Co-ordinates all the objects of the program <see cref="Main_Form" /> class.</summary>
		/// <param name="loginForm">An object of the login form control</param>
		/// <param name="_data">Database</param>
		/// <param name="permissionLevel"></param>
		public Main_Form(LoginForm loginForm, Database _data, int permissionLevel)
        {
            InitializeComponent();
            //initialiseItemList();
            _login_form = loginForm;
            _database = _data;
            _fileHandles = new FileHandles();
            _purchasesPR = new Purchases_PR(this,_fileHandles);
            _purchases = new Purchases(this, _purchasesPR, _fileHandles);
            _email = new Email();
            _sales = new Sales(this, _database, _fileHandles);
            _inventory = new Inventory(this);
            _receipt = new Receipt(this, _database, _purchases, _sales, _inventory);
            _destruction_certificate = new Destruction_Certificate(this,_database);
            _expenses = new Expenses(this, _database, _fileHandles);
            _wages = new Wages(this, _database, _fileHandles);
            _summaries = new Summaries(this);
            _customers = new Customers(this,_database, _receipt);
            _employees = new Employees(this, _database);
            _deliveryNotesModel = new DeliveryNotesModel(_database, _fileHandles);
            _user_permission_level = permissionLevel;

            this.Owner = loginForm;

            initialiseDeliveryNotesTab();
        }

		/// <summary>
        /// Method for making sure that the Main_Form's size cannot be changed and the Main_Form cannot be moved
        /// </summary>
		/// <param name="message">The message.</param>
		protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Makes sure that the app is completely killed when the form is closing
            //We do not want the application to end up running in the background
            Application.Exit();
        }

        //*************************************************************************************************************************
        //RECEIPT RELATED CALLS
        //*************************************************************************************************************************
        private void addItemBtn_Click(object sender, EventArgs e)
        {
            _receipt.addItems();
        }

		private void PriceOverrideCheckBox_CheckedChanged(object sender, EventArgs e)
		{
            _receipt.ManualPrice();
        }

		private void customerNumbersList_SelectedIndexChanged(object sender, EventArgs e)
		{
            _receipt.UpdateCustomerDetails();
		}

        private void PurchaseBtn_Click(object sender, EventArgs e)
        {
            //Check if the current transaction is to be a purchase or sale first
            if (ReceiptSaleOrPurchase.SelectedItem.ToString() == _receipt.purchaseOrSaleType.purchase)
            {
                /*if ((_user_permission_level == 2))
                {
                    PermissionDenied();
                }
                else
                {
                    _receipt.CompletePurchaseOrSale();
                }*/

                _receipt.CompletePurchaseOrSale();
            }
            else if ((ReceiptSaleOrPurchase.SelectedItem.ToString() == _receipt.purchaseOrSaleType.casualSale)
                ||(ReceiptSaleOrPurchase.SelectedItem.ToString() == _receipt.purchaseOrSaleType.formalSale)) 
            {
                /*if ((_user_permission_level == 3) || (_user_permission_level == 4) || (_user_permission_level == 5))
                {
					_receipt.CompletePurchaseOrSale();
                }
                else
                {
                    PermissionDenied();
                }*/

                _receipt.CompletePurchaseOrSale();
            } 
        }

		private void CancelPurchaseBtn_Click(object sender, EventArgs e)
		{
            _receipt.ResetReceipt();
		}

        private void itemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            _receipt.ItemChanged();
        }

        private void DealerPriceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _receipt.ItemChanged();
        }

        private void ReceiptPriceEditBtn_Click(object sender, EventArgs e)
        {
            //We will no longer check the permission level before editing prices
            /*if ((_user_permission_level == 3) || (_user_permission_level == 4) || (_user_permission_level == 5))
            {
                _receipt.EditPrices();
            }
            else 
            {
                PermissionDenied();
            }*/

            _receipt.EditPrices();
        }

        private void ReprintReceiptBtn_Click(object sender, EventArgs e)
        {
            if ((_user_permission_level == 2))
            {
                PermissionDenied();
            }
            else
            {
                _receipt.PrintReceipt();
            }
        }

        private void AddFloatBtn_Click(object sender, EventArgs e)
        {
            if ((_user_permission_level == 3) || (_user_permission_level == 4) || (_user_permission_level == 5))
            {
                _receipt.EditFloat();
            }
            else
            {
                PermissionDenied();
            }
            
        }

        private void customerNumbersList_KeyDown(object sender, KeyEventArgs e)
        {

			
			if (e.KeyCode == Keys.Enter)
            {
                _receipt.UpdateCustomerDetails();
            }
        }

        //******************************************************************************************************************************
        //PURCHASE LOG RELATED CALLS
        //******************************************************************************************************************************

        private void FilterPurchaseLogBtn_Click(object sender, EventArgs e)
        {
            _purchases.filterGrid();
        }

		private void PurchaseLogMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
            _purchases.MonthSelected();
		}

		private void removeFiltersBtn_Click(object sender, EventArgs e)
		{
            _purchases.RemoveFilters();
		}

        //******************************************************************************************************************************
        //DESTRUCTION CERTIFICATE RELATED CALLS
        //******************************************************************************************************************************

        private void generateDstrCertBtn_Click(object sender, EventArgs e)
        {
            if ((_user_permission_level == 3) || (_user_permission_level == 4) || (_user_permission_level == 5))
            {
                _destruction_certificate.ExportToPdf();
            }
            else 
            {
                PermissionDenied();
            }
        }

        private void dstrctCertCompanyField_SelectedIndexChanged(object sender, EventArgs e)
        {
            _destruction_certificate.Company_Selected();
        }
        private void dstrctCertCompanyField_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            _destruction_certificate.Company_Selected();
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            _destruction_certificate.FieldSettings();
        }

        private void dstrctCertCompanyField_Leave(object sender, EventArgs e)
        {
            _destruction_certificate.Company_Selected();
        }

        private void SendDstrctCertEmailBtn_Click(object sender, EventArgs e)
        {
            //_email.Show();
            //_email.sendEmailUsingGmail();
        }

        //******************************************************************************************************************************
        //SALES LOG RELATED CALLS
        //******************************************************************************************************************************
        private void FilterSalesLogBtn_Click(object sender, EventArgs e)
		{
            _sales.DisplaySalesLog();
		}

		private void SalesLogMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
            _sales.MonthSelected();
        }

		private void NewCompanyCheckBox_CheckedChanged(object sender, EventArgs e)
		{
            _sales.UnknownCompany();
		}

		private void AddSaleBtn_Click(object sender, EventArgs e)
		{
            if ((_user_permission_level == 4) || (_user_permission_level == 5))
            {
                _sales.AddSale();
            }
            else 
            {
                PermissionDenied();
            }
            
		}

        private void RemoveSalesLogFiltersBtn_Click(object sender, EventArgs e)
        {
            _sales.RemoveFilters();
        }

		private void ClearSalesFields_Click(object sender, EventArgs e)
		{
            _sales.ClearFields();
		}


        //*************************************************************************************************************
        // EXPENSES RELATED CALLS
        //*************************************************************************************************************
		private void AddExpenseBtn_Click(object sender, EventArgs e)
		{
            _expenses.AddExpense();
            _expenses.DisplayExpensesLog();

            /*
            if ((_user_permission_level == 4) || (_user_permission_level == 5))
            {
                _expenses.AddExpense();
                _expenses.DisplayExpensesLog();
            }
            else 
            {
                PermissionDenied();
            }*/

        }

		private void ExpensesLogMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
            _expenses.MonthSelected();
		}

		private void ExpensesLogFilterBtn_Click(object sender, EventArgs e)
		{
            _expenses.DisplayExpensesLog();
		}

		private void ExpensesLogRemoveFiltersBtn_Click(object sender, EventArgs e)
		{
            _expenses.RemoveFilters();
		}

		private void ClearExpenseFieldsBtn_Click(object sender, EventArgs e)
		{
            _expenses.ClearFields();
		}

        //*************************************************************************************************************
        // WAGES RELATED CALLS
        //*************************************************************************************************************
        private void WageLogMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            _wages.MonthSelected();
        }

		private void WageLogFilterBtn_Click(object sender, EventArgs e)
		{
            _wages.DisplayWagesLog();
		}

		private void WageLogRemoveFiltersBtn_Click(object sender, EventArgs e)
		{
            _wages.RemoveFilters();
		}

		private void ClearWageFieldsBtn_Click(object sender, EventArgs e)
		{
            _wages.ClearFields();
		}

		private void AddWageBtn_Click(object sender, EventArgs e)
		{
            if ((_user_permission_level == 4) || (_user_permission_level == 5))
            {
                _wages.AddWage();
            }
            else 
            {
                PermissionDenied();
            }
            
		}

		private void PartTimeEmployeeCheckBox_CheckedChanged(object sender, EventArgs e)
		{
            _wages.PartTimeEmployee();
		}

        private void NewEmployee_Click(object sender, EventArgs e)
        {
            if ((_user_permission_level == 4) || (_user_permission_level == 5))
            {
                this.Enabled = false;
                _employees.Enabled = true;
                _employees.Activate();
                _employees.Show();
            }
            else
            {
                PermissionDenied();
            }
        }
        // *******************************************************************************************************************
        // SUMMARIES RELATED CALLS
        // *******************************************************************************************************************

        private void SummariesMonthSelector_SelectedIndexChanged(object sender, EventArgs e)
		{
            _summaries.MonthSelected();
		}

        // *******************************************************************************************************************
        // PRINTER RELATED CALLS
        // *******************************************************************************************************************

        private void PrintReceipt_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
            Graphics _printing_graphic = this.CreateGraphics();
            Bitmap map = new Bitmap(receiptBox.Size.Width, receiptBox.Size.Height, _printing_graphic);
            Graphics _print_image = Graphics.FromImage(map);
            _print_image.CopyFromScreen(receiptBox.Location.X, receiptBox.Location.Y, 0, 0, receiptBox.Size);
		}

        // *******************************************************************************************************************
        // INVENTORY RELATED CALLS
        // *******************************************************************************************************************
        private void InventoryLogMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
            _inventory.MonthSelected();
		}

        private void InventoryLogFilterBtn_Click(object sender, EventArgs e)
        {
            _inventory.DisplayLog();
        }

        private void InventoryLogRmvFilterBtn_Click(object sender, EventArgs e)
        {
            _inventory.RemoveFilters();
        }

        private void InvetorySummedOrNot_SelectedIndexChanged(object sender, EventArgs e)
        {
            _inventory.DisplayLog();
        }

        // *******************************************************************************************************************
        // FUNCTION CALLS WHEN CHANGING TABS
        // *******************************************************************************************************************

        private void mainTabControl_Deselected(object sender, TabControlEventArgs e)
		{
            _previous_tab_page = e.TabPage;
            _receipt.ResetReceipt();
            _purchases.Reset();
            _sales.Reset();
            _inventory.Reset();
            _expenses.Reset();
            _wages.Reset();
            _summaries.Reset();
            _destruction_certificate.Reset();
		}

		private void mainTabControl_Selected(object sender, TabControlEventArgs e)
		{
            _current_tab_page = e.TabPage;

            if ((e.TabPage.Name == "ReceiptPage") && (_user_permission_level == 1)) return;
            else if ((e.TabPage.Name == "Expenses") && (_user_permission_level == 1)) return;
            else if ((e.TabPage.Name == "DestructionCertificates") && (_user_permission_level == 1)) return;
            else if (_user_permission_level == 1)
            {
                PermissionDenied();
                mainTabControl.SelectedTab = _previous_tab_page;
            }
         }

        private void PermissionDenied() 
        {
            string message = "Permision Denied!";
            string messageTitle = CustomMessageBox.error;
            CustomMessageBox box = new CustomMessageBox(this, messageTitle, message);
        }

		private void LogOutBtn_Click_1(object sender, EventArgs e)
		{
            this.Hide();
            _login_form.Show();
        }

		private void EditCustomers_Click(object sender, EventArgs e)
		{
            _receipt.ResetReceipt();
            //We will no longer check the permission level before editing the customers
            /*if ((_user_permission_level == 4) || (_user_permission_level == 5))
            {
                _customers.ActivateForm();
            }
            else
            {
                PermissionDenied();
            }*/

            _customers.ActivateForm();
        }

		private void PrintPolice()
		{
            //Do nothing when this button is pressed
            //return;

            if (this.PurchaseLogMonth.SelectedItem == null) 
            {
                return;
            }

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Police Register";
            printer.SubTitle = DateTime.Now.ToString("dddd, dd MMMM yyyy, HH:mm ") + DateTime.Now.ToString("tt").ToUpper();
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            //printer.ColumnWidth = DGVPrinter.ColumnWidthSetting.CellWidth;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Green Enviro SA Recycling";
            printer.FooterSpacing = 5;
            printer.PageSettings.PrinterSettings.DefaultPageSettings.Landscape = true;

            IEnumerable<PaperSize> paperSizes = printer.PageSettings.PrinterSettings.PaperSizes.Cast<PaperSize>();
            PaperSize sizeA3 = new PaperSize();
            sizeA3.RawKind = (int)PaperKind.A3;
            printer.PageSettings.PrinterSettings.DefaultPageSettings.PaperSize = sizeA3;


            PurchseLogGridView.Rows[PurchseLogGridView.Rows.Count - 1].Visible = false;
            var fontInfo = PurchseLogGridView.Font;
            PurchseLogGridView.DefaultCellStyle.Font = new Font("Consolas", 10);
            printer.PrintDataGridView(this.PurchseLogGridView);
            PurchseLogGridView.Rows[PurchseLogGridView.Rows.Count - 1].Visible = true;

            PurchseLogGridView.DefaultCellStyle.Font = fontInfo;
        }

		private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
		{
            Application.Exit();
		}

		private void ReceiptSaleOrPurchase_SelectedIndexChanged(object sender, EventArgs e)
		{
            if (starting == true)
            {
                starting = false;
            }
            else 
            {
                _receipt.SaleOrPurchaseChanged();
            }
		}

		private void DeletePurchaseBtn_Click(object sender, EventArgs e)
		{
            _purchases.DeletePurchase();
		}

		private void DeleteExpenseBtn_Click(object sender, EventArgs e)
		{
            _expenses.DeleteExpense();
		}

		private void DeleteWageBtn_Click(object sender, EventArgs e)
		{
            _wages.DeleteWage();
		}

		private void DeleteSaleBtn_Click(object sender, EventArgs e)
		{
            _sales.DeleteSale();
		}

		private void PurchasesPRMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
            _purchasesPR.monthSelected();
		}

		private void AddToPRBtn_Click(object sender, EventArgs e)
		{
            _purchases.addToPRRequest();
		}

		private void ReceiptDefaultCustomerCheckBox_CheckedChanged(object sender, EventArgs e)
		{

		}
	}
}
