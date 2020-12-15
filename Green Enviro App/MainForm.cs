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
        string _receipt_content = "\n\n";
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
            itemList.Items.Add("Copper");
            itemList.Items.Add("Steel");
            itemList.Items.Add("A Grade");
            itemList.Items.Add("Can");
            itemList.Items.Add("Lead");
            itemList.Items.Add("Battery");
        }

        private void setFormSize()
        {
            //This function sets the size of the main form to maximum size allowable by the PC
            int _screen_width = Screen.PrimaryScreen.Bounds.Width;
            int _screen_height = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(_screen_height, _screen_width);

        }

        private void setUpReceipt()
        {
            string _tabspace = "      ";
            string _date = " Date: " + DateTime.Now.ToString("dd MMMM yyyy       ") + "\n Time: " + DateTime.Now.ToString("hh:mm") + "\n";
            string _customer_details = " Gerry, 100\n" + " ID: 123455\n";
            
            Clipboard.SetImage(logo.Image);
            receiptBox.Paste();
            receiptBox.AppendText(" \n");
            receiptBox.AppendText(" ----------------------------------------------------------\n");
            receiptBox.AppendText(" 5 Shaft Road, Knights, Germiston, 1401\n");
            receiptBox.AppendText(" Phone: +27 63 236 3034\n");
            receiptBox.AppendText(" Tax Number: 9154951249\n");
            receiptBox.AppendText(" Registration: 2019/528743/07\n");
            receiptBox.AppendText(" ---------------------------------------------------------\n");
            receiptBox.AppendText(_date);
            receiptBox.AppendText(_customer_details);
            receiptBox.AppendText("\n ---------------------------------------------------------\n");
            receiptBox.AppendText(" ITEMS" + _tabspace + "PRICE" + _tabspace + "KGs" + _tabspace + "AMOUNT\n");
            receiptBox.AppendText(" ---------------------------------------------------------\n");
            receiptBox.AppendText(_receipt_content);
            receiptBox.AppendText(" ---------------------------------------------------------\n");
            receiptBox.AppendText("THANK YOU!");
            receiptBox.ReadOnly = true;
        }
    }
}
