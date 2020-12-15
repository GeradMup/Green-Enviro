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
        public Main_Form()
        {
            InitializeComponent();
            initialiseItemList();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            setFormSize();
            receiptBox.Controls.Add(logo);

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
    }
}
