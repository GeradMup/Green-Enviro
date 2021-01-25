using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
    public partial class Main_Form : Form
    {
        Receipt _receipt;
        Database _database;
        PurchaseLogs _purchase_logs;
        SalesLogs _sales_logs;
        Expenses _expenses;
		Destruction_Certificate _destruction_certificate;

		/// <summary>
        /// This is the main class for the program. Co-ordinates all the objects of the program <see cref="Main_Form" /> class.
        /// </summary>
		/// <param name="_data">Database</param>
		public Main_Form(Database _data)
        {
            InitializeComponent();
            //initialiseItemList();
            _database = _data;
            _purchase_logs = new PurchaseLogs(this);
            _sales_logs = new SalesLogs(this, _database);
            _receipt = new Receipt(this, _database, _purchase_logs);
            _destruction_certificate = new Destruction_Certificate(this,_database);
            _expenses = new Expenses(this, _database);
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
            _receipt.CompletePurchase();
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

        }

        //******************************************************************************************************************************
        //PURCHASE LOG RELATED CALLS
        //******************************************************************************************************************************

        private void FilterPurchaseLogBtn_Click(object sender, EventArgs e)
        {
            _purchase_logs.DisplayPurchaseLog();
        }

		private void PurchaseLogMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
            _purchase_logs.MonthSelected();
		}

		private void removeFiltersBtn_Click(object sender, EventArgs e)
		{
            _purchase_logs.RemoveFilters();
		}

		private void TotalsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}


        //******************************************************************************************************************************
        //DESTRUCTION CERTIFICATE RELATED CALLS
        //******************************************************************************************************************************


        private void DestrctCertificatePage_Click(object sender, EventArgs e)
        {

        }

        private void generateDCBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void generateDstrCertBtn_Click(object sender, EventArgs e)
        {
            _destruction_certificate.ExportToPdf();
        }

        private void dstrctCertQuantityUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

		private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
            
        }

        private void DCNewCompany_CheckedChanged(object sender, EventArgs e)
        {
            _destruction_certificate.FieldSettings();
        }
        private void dstrctCertCompanyField_SelectedIndexChanged(object sender, EventArgs e)
        {
            //_destruction_certificate.Test();
            //if (dstrctCertCompanyField.SelectedItem != null)
            _destruction_certificate.Company_Selected();
            Console.WriteLine("It works");
            //_destruction_certificate.ClearDCFields();

        }


        //******************************************************************************************************************************
        //SALES LOG RELATED CALLS
        //******************************************************************************************************************************
        private void FilterSalesLogBtn_Click(object sender, EventArgs e)
		{
            _sales_logs.DisplaySalesLog();
		}

		private void SalesLogMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
            _sales_logs.MonthSelected();
        }

		private void NewCompanyCheckBox_CheckedChanged(object sender, EventArgs e)
		{
            _sales_logs.UnknownCompany();
		}

		private void AddSaleBtn_Click(object sender, EventArgs e)
		{
            _sales_logs.AddSale();
		}

        private void RemoveSalesLogFiltersBtn_Click(object sender, EventArgs e)
        {
            _sales_logs.RemoveFilters();
        }

		private void ClearSalesFields_Click(object sender, EventArgs e)
		{
            _sales_logs.ClearFields();
		}


        //*************************************************************************************************************
        // EXPENSES RELATED CALLS
        //*************************************************************************************************************
		private void AddExpenseBtn_Click(object sender, EventArgs e)
		{
            _expenses.AddExpense();
            _expenses.DisplayExpensesLog();
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
	}
}
