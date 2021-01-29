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
        Purchases _purchases;
        Sales _sales;
        Expenses _expenses;
        Wages _wages;
		Destruction_Certificate _destruction_certificate;
        Summaries _summaries;
        Email _email;

		/// <summary>
        /// This is the main class for the program. Co-ordinates all the objects of the program <see cref="Main_Form" /> class.
        /// </summary>
		/// <param name="_data">Database</param>
		public Main_Form(Database _data)
        {
            InitializeComponent();
            //initialiseItemList();
            _database = _data;
            _purchases = new Purchases(this);
            _email = new Email();
            _sales = new Sales(this, _database);
            _receipt = new Receipt(this, _database, _purchases);
            _destruction_certificate = new Destruction_Certificate(this,_database);
            _expenses = new Expenses(this, _database);
            _wages = new Wages(this, _database);
            _summaries = new Summaries(this);
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
            _receipt.EditPrices();
        }

        //******************************************************************************************************************************
        //PURCHASE LOG RELATED CALLS
        //******************************************************************************************************************************

        private void FilterPurchaseLogBtn_Click(object sender, EventArgs e)
        {
            _purchases.DisplayPurchaseLog();
        }

		private void PurchaseLogMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
            _purchases.MonthSelected();
		}

		private void removeFiltersBtn_Click(object sender, EventArgs e)
		{
            _purchases.RemoveFilters();
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
            _email.Show();
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
            _sales.AddSale();
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
            _wages.AddWage();
		}

		private void PartTimeEmployeeCheckBox_CheckedChanged(object sender, EventArgs e)
		{
            _wages.PartTimeEmployee();
		}

        private void ExpenseDate_ValueChanged(object sender, EventArgs e)
        {

        }

        // *******************************************************************************************************************
        // SUMMARIES RELATED CALLS
        // *******************************************************************************************************************

		private void SummariesMonthSelector_SelectedIndexChanged(object sender, EventArgs e)
		{
            _summaries.MonthSelected();
		}

    }

}
