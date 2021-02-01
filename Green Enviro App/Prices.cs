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
	public partial class Prices : Form
	{

		Database _database;
		Receipt _receit;
		string _previous_value = "";
		/// <summary>
		/// Initializes a new instance of the <see cref="Prices" /> class.
		/// Class/Form used to all the price related editing
		/// </summary>
		public Prices(Receipt rcpt, Database db)
		{
			InitializeComponent();

			_database = db;
			_receit = rcpt;
			LoadPrices();
		}

		private void LoadPrices() 
		{
			DataTable items = _database.SelectAll("Items");

			/*PricesGridView.DataSource = items;
			PricesGridView.Columns[0].ReadOnly = true;
			PricesGridView.Columns[1].ReadOnly = true;
			PricesGridView.Columns[4].ReadOnly = true;

			//Makes sure that users cannot add the wrong data types
			PricesGridView.Columns[2].ValueType = typeof(float);
			PricesGridView.Columns[3].ValueType = typeof(float);

			foreach (DataGridViewColumn _column in PricesGridView.Columns)
			{
				_column.SortMode = DataGridViewColumnSortMode.NotSortable;
			}*/
		}

		private void PricesGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			/*string _item_name = PricesGridView[1, e.RowIndex].Value.ToString();
			string _price = PricesGridView[2, e.RowIndex].Value.ToString();
			string _dealer_price = PricesGridView[3, e.RowIndex].Value.ToString();*/

			DialogResult dialogResult = MessageBox.Show("Are you sure you want to change the price?", "Confirm Edit", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				/*string _table_name = "Items";
				string _column_value_pairs = "Price = '" + _price + "', DealerPrice = '" + _dealer_price + "'";   
				string _identification_column = "Name";
				string _identifier = "'" + _item_name + "'";

				Int32 rowsAffected = _database.UpdateDatabase(_table_name,_column_value_pairs, _identification_column, _identifier);

				if (rowsAffected == 1)
				{
					CustomMessageBox mb = new CustomMessageBox("Success", "Price has been updated");
				}
				else 
				{
					CustomMessageBox mb = new CustomMessageBox("Failure", "Failed to update price");
				}*/
			}
			else if (dialogResult == DialogResult.No)
			{
				/*PricesGridView[e.ColumnIndex, e.RowIndex].Value = _previous_value;
				PricesGridView.Refresh();*/
			}
		}

		private void PricesGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
		{
			//_previous_value = PricesGridView[e.ColumnIndex, e.RowIndex].Value.ToString();
		}

		private void PriceChangeCpltBtn_Click(object sender, EventArgs e)
		{
			_receit.SetupPriceList();
			this.Hide();
			this.Enabled = false;

		}

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Prices
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Prices";
            this.Load += new System.EventHandler(this.Prices_Load);
            this.ResumeLayout(false);

        }

        private void Prices_Load(object sender, EventArgs e)
        {

        }
    }
}
