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

        private void Main_Form_Load(object sender, EventArgs e)
        {
            setFormSize();
        }

        private void setFormSize()
        {
            //This function sets the size of the main form to maximum size allowable by the PC
            int _screen_width = Screen.PrimaryScreen.Bounds.Width;
            int _screen_height = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(_screen_height, _screen_width);
            this.MinimumSize = new Size(_screen_height, _screen_width);

        }

        //RECEIPT RELATED CALLS
        //******************************************************************************************************************************************
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

        //*****************************************************************************************************************************************
        //PURCHASE LOG RELATED CALLS
        //*****************************************************************************************************************************************

        private void GenerateLogBtn_Click(object sender, EventArgs e)
        {
            _logs.DisplayLog();
        }
	}
}
