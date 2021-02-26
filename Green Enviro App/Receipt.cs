using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Green_Enviro_App
{
    public class Receipt
    {

        Main_Form _main_form;
        Database _database;
        Purchases _purchases;
        Sales _sales;
        Items _items_form;
        Float _float;
        Inventory _inventory;

        DataTable _items;
        DataTable _customers;
        List<string> _purchased_items = new List<string>();
        List<string> _purchased_quantities = new List<string>();
        List<CasualSale> _sold_items = new List<CasualSale>();

        string _receipt_content = "";
        float _running_total = 0;
        string _customer_details = " Customer: None, 0\n" + " ID: 0000000000000000\n";
        string _single_purchase_entry;
        string _single_quantity_entry;
        RichTextBox _receipt_print_content = new RichTextBox();

        float _float_value = 0F;
        static string _month = DateTime.Now.ToString("MMMM yyyy");
        string _path_to_float = @"..//..//resources//Float//" + _month + "_float.csv";
        string _path_to_total_float = @"..//..//resources//Float//" + _month + "_total_float.csv";
        //Constructor

        //Customer information
        string _customer_number = "";
        string _customer_id_number = "";
        string _customer_name = "";
        string _customer_surname = "";
        bool _customer_selected = false;

        string _purchase = "Purchase";
        string _formal_sale = "Formal Sale";
        string _casual_sale = "Casual sale";

        public struct PurchaseOrSaleType { 
            public string purchase { get { return "Purchase"; } }

            public string formalSale { get { return "Formal Sale"; } }

            public string casualSale { get { return "Casual sale"; } }
        }

        public PurchaseOrSaleType purchaseOrSaleType = new PurchaseOrSaleType();


        public Receipt(Main_Form form, Database data, Purchases logs, Sales sales, Inventory inventory) 
        {
            _main_form = form;
            _database = data;
            _purchases = logs;
            _inventory = inventory;
            _sales = sales;
            _items_form = new Items(this,_database);
            _float = new Float(this, _main_form);
            _items_form.Owner = _main_form;
            _float.Owner = _main_form;

            SetupPriceList();
            setupReceipt();
            SetSalePurchase();
            setupCustomerList();
            //SetupFloat();
        }
        
        public void SetupPriceList()
        {
            //Gets all items from the database and stores them in a DataTable named _items
            _items = _database.SelectAll("Items");

            //MessageBox.Show("All Items: " + _items.Rows.Count.ToString());

            int _name_column = 1;
            int _type_column = 4;

            HashSet<string> _types = new HashSet<string>();

            _main_form.itemList.Items.Clear();
            foreach (DataRow row in _items.Rows) 
            {
                //Selects only the name of the items and stores them in a drop down list that will appear on the receipt page
                _main_form.itemList.Items.Add(row[_name_column]);
                _types.Add(row[_type_column].ToString());
            }

            string _first_arg = "";
            string _second_arg = "";

            foreach (string type in _types) 
            {
                if (type[0] == 'F') 
                {
                    _first_arg = type;
                }

                if (type[0] == 'N') 
                {
                    _second_arg = type;
                }
            }

            _purchases.setTypes(_first_arg, _second_arg);
        }

        public void setupCustomerList() 
        {
            //Gets all customer details and stores them in a DataTable name _customers
            _customers = _database.SelectAll("Customers");

            //MessageBox.Show("All Customers: " + _customers.Rows.Count.ToString());

            int _customer_number_column = 0;

            _main_form.customerNumbersList.Items.Clear();
            foreach (DataRow row in _customers.Rows)
            {
                //Selects the customer numbers and adds to the drop down list on the receipt page
                _main_form.customerNumbersList.Items.Add(row[_customer_number_column]);
            }
        }

        private void setupReceipt()
		{
            _main_form.receiptBox.ReadOnly = false;
            _main_form.receiptBox.Clear();

            string _date = " Date: " + DateTime.Now.ToString("dd MMMM yyyy       ") + "\n Time: " + DateTime.Now.ToString("hh:mm") + "\n";
            
            Clipboard.SetImage(_main_form.logo.Image);
            _main_form.receiptBox.Paste();
            _main_form.receiptBox.AppendText(" \n");
            _main_form.receiptBox.AppendText(" ----------------------------\n");
            _main_form.receiptBox.AppendText(" 5 Shaft Road, Knights,\n");
            _main_form.receiptBox.AppendText(" Germiston, 1401\n");
            _main_form.receiptBox.AppendText(" Phone: +27 61 588 7074\n");
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

        private void SetSalePurchase() 
        {
            _main_form.ReceiptSaleOrPurchase.Items.Clear();
            _main_form.ReceiptSaleOrPurchase.Items.Insert(0, _purchase);
            _main_form.ReceiptSaleOrPurchase.Items.Insert(1, _formal_sale);
            _main_form.ReceiptSaleOrPurchase.Items.Insert(2, _casual_sale);
            _main_form.ReceiptSaleOrPurchase.SelectedIndex = 0;
        }

        public void addItems() 
        {
            //If the user did not enter something correctly, do nothing, only exit
            if (ValidEntries() == false) 
            {
                return;
            }

            string _item_name = _main_form.itemList.SelectedItem.ToString();
            float _price;
            //Checks if manual price override is selected
            //Determines whether to read the price from the user or from the database
            if (_main_form.PriceOverrideCheckBox.CheckState == CheckState.Checked)
            {
                //Start by checking that the user entered a price
                if (_main_form.PriceBox.Value == (decimal)0.00) 
                {
                    MessageBox.Show("Please insert the Price");
                    return;
                }
                _price = float.Parse(_main_form.PriceBox.Text);
            }
            else 
            {
                //Check if the customer is getting dealer prices or not
                _price = getPrice(_item_name);
            }

            //Converts the string value into a floating point value
            float _kilos = float.Parse(_main_form.quantityBox.Text);
            float _amount = _price * _kilos;
            _running_total += _amount;

            _receipt_content += string.Format("{0,-11}", " " + _item_name);
            _receipt_content += string.Format("{0,-5}", _kilos);
            _receipt_content += string.Format("{0,-7}", _price);
            _receipt_content += string.Format("{0,-8}", _amount);
            _receipt_content += "\n";
            setupReceipt();

            //Create the record for Logging
            string _date = DateTime.Now.ToString("dd MMMM yyyy");
            string _item_type = ItemType(_item_name);
            if (_main_form.ReceiptSaleOrPurchase.SelectedItem.ToString() == _purchase)
            {
                _single_purchase_entry += _date + "," + _customer_name + "," + _customer_surname + "," + _customer_id_number + "," + _customer_number + ",";
                _single_purchase_entry += _item_name + "," + _kilos.ToString() + "," + _price.ToString() + "," + _amount.ToString() + "," + _item_type;
                _purchased_items.Add(_single_purchase_entry);
            }
            else if (_main_form.ReceiptSaleOrPurchase.SelectedItem.ToString() == _casual_sale) 
            {
                CasualSale newSale = new CasualSale();
                newSale.item = _item_name;
                newSale.itemType = _item_type;
                newSale.price = _amount.ToString();
                newSale.quantity = _kilos.ToString();

                _sold_items.Add(newSale);
            }
          

            //Clear the _single_purchase_entry to make it ready for the next entry
            _single_purchase_entry = "";

            float _quantity_kilos = _kilos;
            if (_main_form.ReceiptSaleOrPurchase.SelectedItem.ToString() == "Sale")
            {
				_quantity_kilos = -1 * _quantity_kilos;
            }

            _single_quantity_entry += _date + "," + _item_name + "," + _item_type + "," + _quantity_kilos.ToString();
            _purchased_quantities.Add(_single_quantity_entry);
            _single_quantity_entry = "";

            //Clear the input fields and get them ready for the next entry
            ClearFields();
            _main_form.DealerPriceCheckBox.CheckState = CheckState.Unchecked;
            _main_form.PriceOverrideCheckBox.CheckState = CheckState.Unchecked;
            _main_form.PriceBox.ReadOnly = true;       
        }

        private bool ValidEntries() 
        {
            string _error_message = "";
            string _message_title = "Error!";
            bool _all_good = false;
            decimal _zero = (decimal)0.00;
            
            if (((_main_form.customerNumbersList.SelectedItem == null) && (_main_form.ReceiptDefaultCustomerCheckBox.CheckState == CheckState.Unchecked))
                && (_main_form.ReceiptSaleOrPurchase.SelectedItem.ToString() == _purchase))
            {
                //First check if customer details have been selected
                _error_message = "Please select customer number";
                _all_good = false;
            }
            else if (_main_form.itemList.SelectedItem == null)
            {
                //Checks if there is nothing selected from the item list
                _error_message = "Please Select an Item";
                _all_good = false;
            }
            else if (_main_form.quantityBox.Value == _zero)
            {
                //Checks if there is something in the Quantity textbox
                _error_message = "Please insert the Quantity";
                _all_good = false;
            }
            else 
            {
                _all_good = true;
            }

            if (_all_good == false) 
            {
                CustomMessageBox newBox = new CustomMessageBox(_main_form, _message_title, _error_message);
            }

            return _all_good;
        }

        private float getPrice(string itemName) 
        {
            string _filter_expression = "Name = '" + itemName + "'";

            DataView dataView = _items.DefaultView;
            //Selects all the rows were the filter value matches
            DataRow[] _row = _items.Select(_filter_expression);

            //We are only interested in the first value. 
            //There will be only one row since all the rows have unique names

            int _only_row = 0;
            int _price_column;

            if ((_main_form.DealerPriceCheckBox.CheckState == CheckState.Checked))
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
            _main_form.PriceBox.Value = 0;
            _main_form.itemList.SelectedItem = null;
            _main_form.quantityBox.Value = 0;
        }

        public void UpdateCustomerDetails() 
        {
            //Check if the purchase has been cancelled. Reset the customer details if purchase was cancelled
            if (_main_form.customerNumbersList.SelectedItem == null) 
            {
                _main_form.CustomerIDNumberTextBox.Text = "";
                _main_form.CustomerNameTextBox.Text = "";
                _main_form.CustomerSurnameTextBox.Text = "";
                _main_form.IDPictureBox.Image = null;
                _customer_selected = false;
                return;
            }

            //Check if the customer is already selected. You cannot change the customer details in the middle of a purchase
            if (_customer_selected == true) 
            {
                MessageBox.Show("Error! \n Can not change customer details during purchase. \n Cancel purchase and start from the begining!");
                return;
            }

            _customer_number = _main_form.customerNumbersList.SelectedItem.ToString();
            string _filter_expression = "CustomerNumber = '" + _customer_number + "'";

            DataView _data_view = _customers.DefaultView;
            DataRow[] _row = _customers.Select(_filter_expression);

            int _only_row = 0;
            int ID_column = 1;
            int _name_column = 2;
            int _surname_column = 3;

             
            _customer_id_number = _row[_only_row][ID_column].ToString();
            _customer_name = _row[_only_row][_name_column].ToString();
            _customer_surname = _row[_only_row][_surname_column].ToString();

            _main_form.CustomerIDNumberTextBox.Text = _customer_id_number;
            _main_form.CustomerNameTextBox.Text = _customer_name;
            _main_form.CustomerSurnameTextBox.Text = _customer_surname;

            string _path_to_id_picture = @"..//..//resources//Customers//"+ _customer_number +".jpg";
            Image _id_picture = Image.FromFile(_path_to_id_picture);
            _main_form.IDPictureBox.Image = _id_picture;
           
            _customer_details = " Customer: " + _customer_name + ", " + _customer_number + "\n" + " ID: " + _customer_id_number+ "\n";

            //Call this function update the info on the receipt
            setupReceipt();
            _customer_selected = true;
        }

        public void CompletePurchaseOrSale() 
        {
            if ((_purchased_items.Count == 0) 
                && (_main_form.ReceiptSaleOrPurchase.SelectedItem.ToString() == purchaseOrSaleType.purchase))
            {
                CustomMessageBox box = new CustomMessageBox(_main_form, "Error!", "NO ITEMS HAVE BEEN ADDED");
                return;
            }

            if ((_purchased_items.Count == 0)
                && (_main_form.ReceiptSaleOrPurchase.SelectedItem.ToString() == purchaseOrSaleType.formalSale))
            {
                CustomMessageBox box = new CustomMessageBox(_main_form, "Error!", "NO ITEMS HAVE BEEN ADDED");
                return;
            }

            if ((_sold_items.Count == 0) && (_main_form.ReceiptSaleOrPurchase.SelectedItem.ToString() == purchaseOrSaleType.casualSale))
            {
                CustomMessageBox box = new CustomMessageBox(_main_form, "Error!", "NO ITEMS HAVE BEEN ADDED");
                return;
            }

            _receipt_print_content.Text = _main_form.receiptBox.Text;

            if (_main_form.ReceiptSaleOrPurchase.SelectedItem.ToString() == purchaseOrSaleType.purchase)
            {
                _purchases.AddPurchase(_purchased_items);
                _float.UpdateFloat(-1 * _running_total);
            }
            else if (_main_form.ReceiptSaleOrPurchase.SelectedItem.ToString() == purchaseOrSaleType.casualSale) {
				_sales.AddCasualSale(_sold_items);
                _float.UpdateFloat(_running_total);
            }
            
            _inventory.AddItems(_purchased_quantities);
            
            
            PrintReceipt();
            ResetReceipt();

            _purchased_items.Clear();
            _purchased_quantities.Clear();
            _sold_items.Clear();

            _main_form.ReceiptSaleOrPurchase.SelectedIndex = 0;
        }

        public void ResetReceipt() 
        {
            _main_form.itemList.SelectedItem = null;
            _main_form.customerNumbersList.SelectedItem = null;
            _main_form.ReceiptSaleOrPurchase.SelectedIndex = 0;

            _receipt_content = "";
            _running_total = 0;
            _customer_details = " Customer: None, 0\n" + " ID: 0000000000000000\n";
            _purchased_items.Clear();
            _purchased_quantities.Clear();
            setupReceipt();
        }

        private string ItemType(string itemName) 
        {
            string _filter_expression = "Name = '" + itemName + "'";

            DataView dataView = _items.DefaultView;
            //Selects all the rows were the filter value matches
            DataRow[] _row = _items.Select(_filter_expression);

            int _only_row = 0;
            int _type_column = 4;
            string type = _row[_only_row][_type_column].ToString();

            return type;
        }

        public void ManualPrice() 
        {
            if (_main_form.PriceOverrideCheckBox.CheckState == CheckState.Checked)
            {
                _main_form.PriceBox.ReadOnly = false;
            }
            else
            {
               _main_form.PriceBox.ReadOnly = true;
            }
        }

        public void ItemChanged() 
        {
            if (_main_form.itemList.SelectedItem == null)
            {
                return;
            }
            else 
            {
                _main_form.PriceBox.Value = (decimal)getPrice(_main_form.itemList.SelectedItem.ToString());
            }
        }

        public void EditPrices() 
        {
            ClearFields();
            _items_form.Enabled = true;
            _items_form.Activate();
            _items_form.Show();
        }

        public void PrintReceipt() 
        {
            int _width_offset = 30;
            
            int _content_height = _main_form.receiptBox.Lines.Count() * 20;
            int _header_height = 50;

            PrintDocument _receipt_content = new PrintDocument();
            PrintDocument _receipt_header = new PrintDocument();

            _receipt_header.DefaultPageSettings.PaperSize = new PaperSize("Custom", _main_form.receiptBox.Size.Width - _width_offset, _header_height);
            _receipt_header.PrintPage += new PrintPageEventHandler(this.PrintDocument_PrintPage_0);
            
            _receipt_content.DefaultPageSettings.PaperSize = new PaperSize("Custom", _main_form.receiptBox.Size.Width - _width_offset, _content_height);
            _receipt_content.PrintPage += new PrintPageEventHandler(this.PrintDocument_PrintPage);

            _receipt_header.PrinterSettings.PrinterName = "58mm Series Printer";
            _receipt_content.PrinterSettings.PrinterName = "58mm Series Printer";
              
            _receipt_header.Print();
            _receipt_content.Print();
            
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) 
        {
            float _font_size = 8.5F;
            e.Graphics.DrawString(_receipt_print_content.Text, new Font("Consolas", _font_size), System.Drawing.Brushes.Black,-10,-5);
        }  
        
        private void PrintDocument_PrintPage_0(object sender, System.Drawing.Printing.PrintPageEventArgs e) 
        {
            float _font_size = 15F;
            string _header_text = "GREEN ENVIRO\nSA RECYCLING";
            e.Graphics.DrawString(_header_text, new Font("Consolas", _font_size), System.Drawing.Brushes.Black, 0,-5);
        }

        public void EditFloat() 
        {
            _float.Activate();
            _float.Show();
            _float.Enabled = true;
            _main_form.Enabled = false;
        }

	}
}
