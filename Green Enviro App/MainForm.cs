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
        string _receipt_content = "";
        public Main_Form()
        {
            InitializeComponent();
            initialiseItemList();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
           setFormSize();
            setUpReceipt();

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReceiptPage_Click(object sender, EventArgs e)
        {

        }

        private void initialiseItemList() 
        {
            itemList.Items.Add("Cu Mix");
            itemList.Items.Add("Steel");
            itemList.Items.Add("A Grade");
            itemList.Items.Add("Can");
            itemList.Items.Add("Lead");
            itemList.Items.Add("Batt");
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

        private void setUpReceipt()
        {
            receiptBox.ReadOnly = false;
            receiptBox.Clear();
            string _tabspace = "   ";
            string _date = " Date: " + DateTime.Now.ToString("dd MMMM yyyy       ") + "\n Time: " + DateTime.Now.ToString("hh:mm") + "\n";
            string _customer_details = " Customer: Gerry, 100\n" + " ID: 123455\n";

            
            Clipboard.SetImage(logo.Image);
            receiptBox.Paste();
            receiptBox.AppendText(" \n");
            receiptBox.AppendText(" ----------------------------\n");
            receiptBox.AppendText(" 5 Shaft Road, Knights,\n");
            receiptBox.AppendText(" Germiston, 1401\n");
            receiptBox.AppendText(" Phone: +27 63 236 3034\n");
            receiptBox.AppendText(" Tax Number: 9154951249\n");
            receiptBox.AppendText(" Reg Number: 2019/528743/07\n");
            receiptBox.AppendText(" ----------------------------\n");
            receiptBox.AppendText(_date);
            receiptBox.AppendText(_customer_details);
            receiptBox.AppendText(" ----------------------------\n ");
            receiptBox.AppendText(string.Format("{0,-8}", "ITEMS"));
            receiptBox.AppendText(string.Format("{0,-5}", "KGs"));
            receiptBox.AppendText(string.Format("{0,-6}", "PRICE"));
            receiptBox.AppendText(string.Format("{0,8}", "AMOUNT"));
            receiptBox.AppendText("\n");
            receiptBox.AppendText(" ----------------------------\n");
            receiptBox.AppendText(_receipt_content);
            receiptBox.AppendText(" ----------------------------\n");
            receiptBox.AppendText(" THANK YOU!");

            //Scrolls the entire receipt down when new entries are added
            receiptBox.SelectionStart = receiptBox.Text.Length;
            receiptBox.ScrollToCaret();

            receiptBox.ReadOnly = true;
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            string _tabspace = "     ";

            //Checks if there is nothing selected from the item list
            if (itemList.SelectedItem == null)
            {
                return;
            }

            string _itemName = " " + itemList.SelectedItem.ToString();
            string _price = "10";
            string _kilos = "10";
            string _amount = "10";

            sixCharacters(ref _itemName);

            string _new_content = " " + _itemName + "\t" + _kilos + _tabspace + _price + _tabspace + _amount + "\n";
            _receipt_content += string.Format("{0,-9}", _itemName);
            _receipt_content += string.Format("{0,-6}", _kilos);
            _receipt_content += string.Format("{0,-8}", _price);
            _receipt_content += string.Format("{0,-10}", _amount);
            _receipt_content += "\n";
            setUpReceipt();
        }

        private void sixCharacters(ref string _string) 
        { 
            while(_string.Length < 8)
            {
                _string += " ";
            }
        }


    }
}
