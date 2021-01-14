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
		//DestructionCertificate _destruction_certificate;

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
            _receipt = new Receipt(this, _database, _purchase_logs);
            //_destruction_certificate = new DestructionCertificate(this);
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

        //******************************************************************************************************************************
        //PURCHASE LOG RELATED CALLS
        //******************************************************************************************************************************

        private void GeneratePurchaseLogBtn_Click(object sender, EventArgs e)
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
            //_destruction_certificate.ExportToPdf();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
    }
}
