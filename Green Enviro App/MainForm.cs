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
        
        public Main_Form(Database _data)
        {
            InitializeComponent();
            //initialiseItemList();
            _receipt = new Receipt(this);
            _database = _data;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            setFormSize();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
        private void addItemBtn_Click(object sender, EventArgs e)
        {
            _receipt.addItems();
        }

		private void SyncDataBtn_Click(object sender, EventArgs e)
		{
            //This function wants to make changes to the controls, thefore it needs the object of the main form
            _database.SynchroniseData(this);
		}
	}
}
