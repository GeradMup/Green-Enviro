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
        Logs _logs;
        
        public Main_Form(Database _data)
        {
            InitializeComponent();
            //initialiseItemList();
            _database = _data;
            _logs = new Logs(this);
            _receipt = new Receipt(this, _database, _logs);
        }

        //This function makes it impossible to move the main form around or to resize it
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
            _logs.DisplayPurchaseLog();
        }

		private void PurchaseLogMonth_SelectedIndexChanged(object sender, EventArgs e)
		{
            _logs.MonthSelected();
		}

		private void removeFiltersBtn_Click(object sender, EventArgs e)
		{
            _logs.RemoveFilters();
		}

		private void TotalsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
