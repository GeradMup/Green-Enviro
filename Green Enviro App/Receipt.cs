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
    class Receipt
	{

        Main_Form _main_form;
        Database _database;
        DataTable _items;
        string _receipt_content = "";
        float _running_total = 0;

        //Constructor
        public Receipt(Main_Form form, Database data) 
        {
            _main_form = form;
            _database = data;
            setupPriceList();
            setupReceipt();
        }

        public void setupPriceList()
        {
            _items = _database.SelectAll("Items");

            MessageBox.Show("All Items: " + _items.Rows.Count.ToString());

            int _name_column = 1;

            foreach (DataRow row in _items.Rows) 
            {
                _main_form.itemList.Items.Add(row[_name_column]);
            }
        }

        public void setupReceipt()
		{
            _main_form.receiptBox.ReadOnly = false;
            _main_form.receiptBox.Clear();

            string _date = " Date: " + DateTime.Now.ToString("dd MMMM yyyy       ") + "\n Time: " + DateTime.Now.ToString("hh:mm") + "\n";
            string _customer_details = " Customer: Gerry, 100\n" + " ID: 123455\n";


            Clipboard.SetImage(_main_form.logo.Image);
            _main_form.receiptBox.Paste();
            _main_form.receiptBox.AppendText(" \n");
            _main_form.receiptBox.AppendText(" ----------------------------\n");
            _main_form.receiptBox.AppendText(" 5 Shaft Road, Knights,\n");
            _main_form.receiptBox.AppendText(" Germiston, 1401\n");
            _main_form.receiptBox.AppendText(" Phone: +27 63 236 3034\n");
            _main_form.receiptBox.AppendText(" Tax Number: 9154951249\n");
            _main_form.receiptBox.AppendText(" Reg Number: 2019/528743/07\n");
            _main_form.receiptBox.AppendText(" ----------------------------\n");
            _main_form.receiptBox.AppendText(_date);
            _main_form.receiptBox.AppendText(_customer_details);
            _main_form.receiptBox.AppendText(" ----------------------------\n ");
            _main_form.receiptBox.AppendText(string.Format("{0,-10}", "ITEMS"));
            _main_form.receiptBox.AppendText(string.Format("{0,-5}", "KGs"));
            _main_form.receiptBox.AppendText(string.Format("{0,-6}", "PRICE"));
            _main_form.receiptBox.AppendText(string.Format("{0,7}", "AMOUNT"));
            _main_form.receiptBox.AppendText("\n");
            _main_form.receiptBox.AppendText(" ----------------------------\n");
            _main_form.receiptBox.AppendText(_receipt_content);
            _main_form.receiptBox.AppendText("\n");
            _main_form.receiptBox.AppendText(" Total\t:\tR " + _running_total.ToString());
            _main_form.receiptBox.AppendText("\n");
            _main_form.receiptBox.AppendText(" ----------------------------\n");
            _main_form.receiptBox.AppendText(" THANK YOU!");

            //Scrolls the entire receipt down when new entries are added
            _main_form.receiptBox.SelectionStart = _main_form.receiptBox.Text.Length;
            _main_form.receiptBox.ScrollToCaret();

            _main_form.receiptBox.ReadOnly = true;
        }

        public void addItems() 
        {
            //Checks if there is nothing selected from the item list
            if (_main_form.itemList.SelectedItem == null)
            {
                return;
            }

            //Checks if there is something in the Quantity textbox
            if (_main_form.quantityBox.Text == "") 
            {
                MessageBox.Show("Please insert the Quantity");
                return;
            }

            string _item_name = _main_form.itemList.SelectedItem.ToString();
            float _price;
            //Checks if manual price override is selected
            //Determines whether to read the price from the user or from the database
            if (_main_form.PriceOverrideCheckBox.CheckState == CheckState.Checked)
            {
                //Start by checking that the user entered a price
                if (_main_form.PriceBox.Text == "") 
                {
                    MessageBox.Show("Please insert the Price");
                    return;
                }
                _price = float.Parse(_main_form.PriceBox.Text);
            }
            else 
            {
                //Gets the prices from the items DataTable
                bool isDealer;

                //Check if the customer is getting dealer prices or not
                if (_main_form.DealerPriceCheckBox.CheckState == CheckState.Checked)
                {
                    isDealer = true;
                }
                else 
                {
                    isDealer = false;
                }

                _price = getPrice(_item_name, isDealer);
            }


            
            _item_name = " " + _item_name;
            //Converts the string value into a floating point value
            float _kilos = float.Parse(_main_form.quantityBox.Text);
            float _amount = _price * _kilos;
            _running_total += _amount;

            _receipt_content += string.Format("{0,-11}", _item_name);
            _receipt_content += string.Format("{0,-5}", _kilos);
            _receipt_content += string.Format("{0,-7}", _price);
            _receipt_content += string.Format("{0,-8}", _amount);
            _receipt_content += "\n";
            setupReceipt();
            
            //Clear the input fields and get them ready for the next entry
            ClearFields();
            _main_form.DealerPriceCheckBox.CheckState = CheckState.Unchecked;
            _main_form.PriceOverrideCheckBox.CheckState = CheckState.Unchecked;
            _main_form.PriceBox.ReadOnly = true;
            
        }

        private float getPrice(string itemName, bool isDealer) 
        {
            string _filter_expression = "Name = '" + itemName + "'";

            DataView dataView = _items.DefaultView;
            //Selects all the rows were the filter value matches
            DataRow[] _row = _items.Select(_filter_expression);

            //We are only interested in the first value. 
            //There will be only one row since all the rows have unique names

            int _only_row = 0;
            int _price_column;
            if (isDealer)
            {
                //Coloumn 3 contains dealer prices
                _price_column = 3;
            }
            else 
            {
                //Column 2 contains regular prices
                _price_column = 2;
            }
            
            float _price = float.Parse(_row[_only_row][_price_column].ToString());

            return _price;
        }

        private void ClearFields() 
        {
            _main_form.PriceBox.Clear();
            _main_form.itemList.SelectedItem = null;
            _main_form.quantityBox.Clear();
        }
	}
}
