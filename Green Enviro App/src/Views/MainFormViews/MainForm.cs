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
        LoginViews _login_form;
        Receipt _receipt;
        //Purchases _purchases;
		
        CustomersViews _customers;
        Email _email;
        Inventory _inventory;
        Employees _employees;
        //Purchases_PR _purchasesPR;
        FileHandles _fileHandles;
        CSVHandles _csvHandles;
        DGVOps _dgvOps;
        Form _mainForm;

        TabPage _previous_tab_page;
        TabPage _current_tab_page;

        //Main Form Models
        DestructionCertificatesModel _destructionCertificatesModel;
        DeliveryNotesModel _deliveryNotesModel;
        SummariesModel _summariesModel;
        WagesModel _wagesModel;
        ExpensesModel _expensesModel;
        EmployeesModel _employeesModel;
        SalesModel _salesModel;
        PurchasesModel _purchasesModel;
        ReceiptModel _receiptModel;

        //Other Models
        FixedExpensesModel _fixedExpensesModel;
        
        //Other Controllers

        //Other Views
        FixedExpensesViews _fixedExpensesViews;
        CustomWarning _warnings;

        public int userPermissionLevel = 0;
        private Form parentForm;
		/// <summary>This is the main class for the program. Co-ordinates all the objects of the program <see cref="Main_Form" /> class.</summary>
		/// <param name="loginForm">An object of the login form control</param>
		/// <param name="permissionLevel"></param>
		public Main_Form(LoginViews loginForm, int permissionLevel)
        {
            InitializeComponent();
            _login_form = loginForm;
            _fileHandles = new FileHandles();
            _csvHandles = new CSVHandles();
            _mainForm = this;
            //_purchasesPR = new Purchases_PR(this,_fileHandles);
            _email = new Email();
           
            //Main form models
            _destructionCertificatesModel = new DestructionCertificatesModel(this, _fileHandles);
            _deliveryNotesModel = new DeliveryNotesModel(_fileHandles);
            _summariesModel = new SummariesModel(_fileHandles, _csvHandles);
            _wagesModel = new WagesModel(_csvHandles,_fileHandles);
            _expensesModel = new ExpensesModel(_csvHandles,_fileHandles);
            _employeesModel = new EmployeesModel();
            _salesModel = new SalesModel(_fileHandles, _csvHandles);
            _purchasesModel = new PurchasesModel(_fileHandles, _csvHandles);
            _receiptModel = new ReceiptModel(_fileHandles, _csvHandles);
            
            _fixedExpensesModel = new FixedExpensesModel();
            _fixedExpensesViews = new FixedExpensesViews(_mainForm, _fixedExpensesModel);
            _employees = new Employees(this, _employeesModel);
            _dgvOps = new DGVOps(this);
            _warnings = new CustomWarning();
            userPermissionLevel = permissionLevel;

            this.Owner = loginForm;

            initializeDeliveryNotesTab();
            initializeDestructionCertificatesTab();
            intializeSummariesTab();
            initializeWagesTab();
            initializeExpensesTab();
            initializeSalesTab();
            initializePurchasesTab();
            initialiseReceiptTab();
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

		private void CancelPurchaseBtn_Click(object sender, EventArgs e)
		{
            //_receipt.ResetReceipt();
		}

        private void ReprintReceiptBtn_Click(object sender, EventArgs e)
        {
            if ((userPermissionLevel == 2))
            {
                PermissionDenied();
            }
            else
            {
                //_receipt.PrintReceipt();
            }
        }

        //******************************************************************************************************************************
        //PURCHASE LOG RELATED CALLS
        //******************************************************************************************************************************


        private void SendDstrctCertEmailBtn_Click(object sender, EventArgs e)
        {
            //_email.Show();
            //_email.sendEmailUsingGmail();
        }

        private void NewEmployee_Click(object sender, EventArgs e)
        {
            if ((userPermissionLevel == 4) || (userPermissionLevel == 5))
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
           // _inventory.MonthSelected();
		}

        private void InventoryLogFilterBtn_Click(object sender, EventArgs e)
        {
            //_inventory.DisplayLog();
        }

        private void InventoryLogRmvFilterBtn_Click(object sender, EventArgs e)
        {
            //_inventory.RemoveFilters();
        }

        private void InvetorySummedOrNot_SelectedIndexChanged(object sender, EventArgs e)
        {
            //_inventory.DisplayLog();
        }

        // *******************************************************************************************************************
        // FUNCTION CALLS WHEN CHANGING TABS
        // *******************************************************************************************************************

        private void mainTabControl_Deselected(object sender, TabControlEventArgs e)
		{
            _previous_tab_page = e.TabPage;
            resetWages();
            resetSummaries();
            resetDestructionCertificate();
            resetDeliveryNotes();
            resetExpenses();
            resetSales();
            resetPurchases();
        }

		private void mainTabControl_Selected(object sender, TabControlEventArgs e)
		{
            _current_tab_page = e.TabPage;

            if ((e.TabPage.Name == "ReceiptPage") && (userPermissionLevel == 1)) return;
            else if ((e.TabPage.Name == "Expenses") && (userPermissionLevel == 1)) return;
            else if ((e.TabPage.Name == "DestructionCertificates") && (userPermissionLevel == 1)) return;
            else if (userPermissionLevel < Constants.ELEVATED_PERMISSION_LEVEL)
            {
                PermissionDenied();
                mainTabControl.SelectedTab = _previous_tab_page;
            }
         }

        private void PermissionDenied() 
        {
            string message = "Permision Denied!"; 
            new CustomMessageBox(this, CustomMessageBox.MessageType.error, message);
        }

		/// <summary>
		/// Handles the 1 event of the LogOutBtn_Click control.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void LogOutBtn_Click_1(object sender, EventArgs e)
		{
            closeForm();
        }

		/// <summary>
		/// Activates the main form.
		/// </summary>
		/// <param name="parent">The parent.</param>
		public void activateForm(Form parent) 
        {
            this.Activate();
            this.Enabled = true;
            this.Show();
            parentForm = parent;
            parentForm.Enabled = false;
            parentForm.Hide();
        }

		/// <summary>
		/// Closes the main form.
		/// </summary>
		public void closeForm() 
        {
            this.Enabled = false;
            this.Hide();
            parentForm.Activate();
            parentForm.Enabled = true;
            parentForm.Show();
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


            PurchasesLogGridView.Rows[PurchasesLogGridView.Rows.Count - 1].Visible = false;
            var fontInfo = PurchasesLogGridView.Font;
            PurchasesLogGridView.DefaultCellStyle.Font = new Font("Consolas", 10);
            printer.PrintDataGridView(this.PurchasesLogGridView);
            PurchasesLogGridView.Rows[PurchasesLogGridView.Rows.Count - 1].Visible = true;

            PurchasesLogGridView.DefaultCellStyle.Font = fontInfo;
        }

		private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
		{
            Application.Exit();
		}


		private void PurchasesPRMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
            //_purchasesPR.monthSelected();
		}
	}
}
