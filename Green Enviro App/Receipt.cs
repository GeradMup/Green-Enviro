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
		string _receipt_content = "";
        List<ItemsNPrices> _items = new List<ItemsNPrices>();

        public struct ItemsNPrices
        {
            public ItemsNPrices(string name, int price)
            {
                _item_name = name;
                _price = price;
            }

            public string _item_name;
            public int _price;
        }

        public Receipt(Main_Form form) 
        {
            _main_form = form;
            setupPriceList();
            setupReceipt();
        }

        public void setupPriceList()
        {
            _main_form.itemList.Items.Add("Cu Mix");
            _main_form.itemList.Items.Add("Steel");
            _main_form.itemList.Items.Add("A Grade");
            _main_form.itemList.Items.Add("Can");
            _main_form.itemList.Items.Add("Lead");
            _main_form.itemList.Items.Add("Batt");
        }

        public void setupReceipt()
		{
            _main_form.receiptBox.ReadOnly = false;
            _main_form.receiptBox.Clear();

            string _date = " Date: " + DateTime.Now.ToString("dd MMMM yyyy       ") + "\n Time: " + DateTime.Now.ToString("hh:mm") + "\n";
            string _customer_details = " Customer: Gerry, 100\n" + " ID: 123455\n";


            //Clipboard.SetImage(logo.Image);
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
            _main_form.receiptBox.AppendText(string.Format("{0,-8}", "ITEMS"));
            _main_form.receiptBox.AppendText(string.Format("{0,-5}", "KGs"));
            _main_form.receiptBox.AppendText(string.Format("{0,-6}", "PRICE"));
            _main_form.receiptBox.AppendText(string.Format("{0,8}", "AMOUNT"));
            _main_form.receiptBox.AppendText("\n");
            _main_form.receiptBox.AppendText(" ----------------------------\n");
            _main_form.receiptBox.AppendText(_receipt_content);
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

            string _itemName = " " + _main_form.itemList.SelectedItem.ToString();
            string _price = "10";
            string _kilos = "10";
            string _amount = "10";


            _receipt_content += string.Format("{0,-9}", _itemName);
            _receipt_content += string.Format("{0,-6}", _kilos);
            _receipt_content += string.Format("{0,-8}", _price);
            _receipt_content += string.Format("{0,-10}", _amount);
            _receipt_content += "\n";
            setupReceipt();
        }
	}


}
