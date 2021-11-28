using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	/// <summary>
	/// This class will be used to handle all the common Data Grid View related tasks.
	///   <br />
	/// These may include filtering, removing filters, Sorting, etc.
	/// </summary>
	public class DGVOps
	{
		DataGridView dataGridView;
		ComboBox monthBox;
		ComboBox startDateBox;
		ComboBox endDateBox;
		ComboBox typeBox;
		Form parentForm;
		private BindingSource bindingSource;
		private DataTable dataTable;
		string _totals = "TOTALS";

		/// <summary>
		/// Initializes a new instance of the <see cref="DGVOps" /> class.
		/// </summary>
		public DGVOps(DataGridView grid, ComboBox month, ComboBox startDate, ComboBox endDate, ComboBox type, Form parent) 
		{
			dataGridView = grid;
			monthBox = month;
			startDateBox = startDate;
			endDateBox = endDate;
			typeBox = type;
			parentForm = parent;
			bindingSource = new BindingSource();
			dataTable = new DataTable();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DGVOps"/> class.
		/// </summary>
		/// <param name="parent">The parent form on which the data grid view will be on.</param>
		public DGVOps(Form parent) 
		{
			parentForm = parent;
			
		}
		
		/// <summary>
		/// Determines whether a valid date range is select for filtering the Purchase Log.
		/// </summary>
		/// <returns>
		///   <c>true</c> if a valid date range is selected; otherwise, <c>false</c>.
		/// </returns>
		/// <remark>
		/// If an invalid date range is selected, the date fields are set back to null
		/// </remark>
		public bool isDateFiltered()
		{
			if ((startDateBox.SelectedItem == null) && (endDateBox.SelectedItem == null)) return false;

			//Start by assuming that the dates are filtered correctly.
			bool dateCorrectlyFiltered = true;
			const string errorMessage = "INVALID DATE RANGE!";
			DateTime startDate = Convert.ToDateTime(startDateBox.SelectedItem.ToString());
			DateTime endDate = Convert.ToDateTime(endDateBox.SelectedItem.ToString());

			//Check that the dates are filtered correctly.
			if ((startDateBox.SelectedItem != null) && (endDateBox.SelectedItem == null)) dateCorrectlyFiltered = false;
			else if ((startDateBox.SelectedItem == null) && (endDateBox.SelectedItem != null)) dateCorrectlyFiltered = false;
			else if (startDate > endDate) dateCorrectlyFiltered = false;
			
			//If the dates are not selected correctly, report the error.
			if (!dateCorrectlyFiltered) GenericControllers.reportError(parentForm, errorMessage);

			return dateCorrectlyFiltered;
		}

		/// <summary>
		/// Determines whether the Material Type is type filtered or not
		/// </summary>
		/// <returns>
		///   <c>true</c> if either Ferrous or Non-Ferrous is selected; otherwise, <c>false</c>.
		/// </returns>
		public bool isTypeFiltered()
		{
			if (typeBox.SelectedItem == null) return false;
			return true;
		}

		/// <summary>
		/// Removes the filters when DataGridView Was being filtered.
		/// </summary>
		public void RemoveFilters()
		{
			startDateBox.SelectedItem = null;
			endDateBox.SelectedItem = null;
			typeBox.SelectedItem = null;
		}

		/// <summary>
		/// Filters the grid view based on the selected dates and types.
		/// </summary>
		public void filterGridView()
		{
			string filterString;
			//Filter according to the date ranges if the dates have been selected correctly
			if (isDateFiltered() == true)
			{
				string filterStartDate = startDateBox.SelectedItem.ToString();
				string filterEndDate = endDateBox.SelectedItem.ToString();


				if (isTypeFiltered() == true)
				{
					string _item_type = typeBox.SelectedItem.ToString();
					filterString = "Date = '{0}' OR Date = '{1}' OR Date >= '{2}' AND Date <= '{3}' AND Type = '{4}'";
					bindingSource.Filter = string.Format(filterString, _totals, Constants.EMPTY_TEXT, filterStartDate, filterEndDate, _item_type);
				}
				else
				{
					filterString = "Date = '{0}' OR Date = '{1}' OR Date >= '{2}' AND Date <= '{3}'";
					bindingSource.Filter = string.Format(filterString, _totals, Constants.EMPTY_TEXT, filterStartDate, filterEndDate);
				}
			}
			else
			{
				bindingSource.RemoveFilter();

				if (isTypeFiltered() == true)
				{
					string _item_type = typeBox.SelectedItem.ToString();
					filterString = "Date = '{0}' OR Date = '{1}' OR Type = '{2}'";
					bindingSource.Filter = string.Format(filterString, _totals, Constants.EMPTY_TEXT, _item_type);
				}
			}
		}

		/// <summary>
		/// Highlights the totals row in the grid view to yellow.
		/// </summary>
		public void highlightTotalsRow() 
		{
			int _last_row_index = 0;
			_last_row_index = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Visible) - 1;

			//Highlight the totals row
			dataGridView.Rows[_last_row_index].DefaultCellStyle.BackColor = Color.Yellow;
			dataGridView.Refresh();
		}

		/// <summary>
		/// This function will add up the KG's and Amount column on the Data Grid View and adds a row to show the totals
		/// </summary>
		/// <param name="kgCol"></param>
		/// <param name="amountCol"></param>
		public void addTotalsRow(int kgCol, int amountCol)
		{
			float _total_kg = 0;
			float _total_amount = 0;

			for (int _row = 0; _row < dataGridView.Rows.Count; _row++)
			{
				_total_amount += float.Parse(dataGridView.Rows[_row].Cells[amountCol].Value.ToString(), CultureInfo.InvariantCulture);
				_total_kg += float.Parse(dataGridView.Rows[_row].Cells[kgCol].Value.ToString(), CultureInfo.InvariantCulture);
			}

			//CustomMessageBox box = new CustomMessageBox("Total", "Kg's : " + _total_kg.ToString() + "\n" + "Amount : " + _total_amount.ToString());

			DataTable _totals_table = new DataTable();

			for (int _cols = 0; _cols < dataGridView.Columns.Count; _cols++)
			{
				DataColumn _new_column = new DataColumn();
				_totals_table.Columns.Add(_new_column);
			}

			DataRow _last_row = dataTable.NewRow();

			_last_row[0] = _totals;
			for (int _cell = 1; _cell < _last_row.ItemArray.Length; _cell++)
			{
				if (_cell == amountCol)
				{
					_last_row[_cell] = _total_amount;
				}
				else if (_cell == kgCol)
				{
					_last_row[_cell] = _total_kg;
				}
				else
				{
					_last_row[_cell] = Constants.EMPTY_TEXT;
				}
			}
			dataTable.Rows.Add(_last_row);
		}

		/// <summary>Populates the start and end dates used to filter the grid view.</summary>
		/// <param name="dates">A list of strings representing the dates.</param>
		public void populateDates(HashSet<String> dates) 
		{
			//First Clear the start and end date fields to prepare them for the new entry
			startDateBox.Items.Clear();
			endDateBox.Items.Clear();

			//Now Populate the drop down list with available dates only.
			foreach (string _date in dates)
			{
				startDateBox.Items.Add(_date);
				endDateBox.Items.Add(_date);
			}

			//Remove any previous filters
			RemoveFilters();
		}

		/// <summary>Populates the months drop down list used for selecting a data grid.</summary>
		/// <param name="months">A List of strings representing the months.</param>
		public void populateLogMonths(List<String> months) 
		{
			monthBox.Items.Clear();
			monthBox.Items.AddRange(months.Cast<object>().ToArray());
		}


		/// <summary>Populates a general given ComboBox with the given data as a list of strings.</summary>
		/// <param name="comboBox">The combo box.</param>
		/// <param name="data">The data.</param>
		public void populateComboBox(ComboBox comboBox, List<string> data) 
		{
			comboBox.Items.Clear();
			comboBox.Items.AddRange(data.Cast<object>().ToArray());
		}

		/// <summary>Populates the grid view that does not need to be filtered after populating</summary>
		/// <param name="colWidths">The widths of each column in the grid view</param>
		/// <param name="includesTotals">Indicates whether the data grid already contains a totals row or not.</param>
		public void populateGridView(List<float> colWidths, bool includesTotals = true) 
		{
			//Disable automatic re-sizing so that the grid can populate quickly
			dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
		
			//Populate the grid
			dataGridView.DataSource = bindingSource;

			//Re-size the columns so that all the data can be visible
			dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
			dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

			for (int column = 0; column < colWidths.Count(); column++) dataGridView.Columns[column].FillWeight = colWidths[column];
			if (includesTotals) highlightTotalsRow();

			dataGridView.Refresh();
		}

		/// <summary>
		/// Clears the grid view.
		/// </summary>
		public void clearGridView() 
		{
			dataGridView.DataSource = null;
			dataGridView.Refresh();
		}

		/// <summary>Populates and filters the grid view.</summary>
		/// <param name="colWidths">The column widths.</param>
		/// <param name="kgColumn">The kg column.</param>
		/// <param name="amountCol">The amount column.</param>
		public void populateAndFilterGrid(List<float> colWidths, int kgColumn = 0, int amountCol = 0) 
		{
			bool includesTotals = false;
			populateGridView(colWidths, includesTotals);

			//Check first if anything is being filtered 
			filterGridView();

			if ((kgColumn != 0) && (amountCol != 0))
			{
				addTotalsRow(kgColumn, amountCol);
				highlightTotalsRow();
			}

			dataGridView.Refresh();
		}

		/// <summary>Gives the default column widths for DataGridViews consisting of 9 Columns.</summary>
		/// <returns>A list of floats containing the dafault column widths.</returns>
		public List<float> defaultColWidths()
		{
			List<float> colWidths = new List<float>();
			colWidths.Add(180F);
			colWidths.Add(110F);
			colWidths.Add(130F);
			colWidths.Add(130F);
			colWidths.Add(40F);
			colWidths.Add(80F);
			colWidths.Add(50F);
			colWidths.Add(50F);
			colWidths.Add(60F);

			return colWidths;
		}

		/// <summary>Sets the types of the products and populates the types combo box. 
		/// There are only two types, Ferrous or Non-ferrous.</summary>
		public void setTypes() 
		{
			typeBox.Items.Clear();
			typeBox.Items.Add(Constants.FERROUS);
			typeBox.Items.Add(Constants.NON_FERROUS);
		}

		/// <summary>Changes the binding source being used by a data grid view from a given datatable.</summary>
		/// <param name="dt">The DataTable.</param>
		public void changeBindingSource(DataTable dt) 
		{
			dataTable = dt;
			bindingSource.DataSource = dt;
		}

		/// <summary>
		/// Highlights the selected row in the data grid view.
		/// </summary>
		/// <param name="selectedRow">The selected row.</param>
		public void highlightRowRed(int selectedRow)
		{
			dataGridView.Rows[selectedRow].DefaultCellStyle.BackColor = Color.Red;
		}

		/// <summary>Removes the row highlights from the given row number.</summary>
		/// <param name="rowNumber">The row number.</param>
		public void removeRowHighlights(int rowNumber) 
		{
			dataGridView.Rows[rowNumber].DefaultCellStyle.BackColor = Color.White;
		}

		/// <summary>Converts the columns of a row into a comma seperated string.</summary>
		/// <param name="rowNumber">The row number.</param>
		/// <returns>A string containg the information from the row.</returns>
		public string getRowInfo(int rowNumber) 
		{
			List<string> columnInfo = new List<string>();
			string rowInfo = "";
			string columnValue = "";
			int numberOfColumns = dataGridView.Columns.Count;
			//Here we try to extract the entire row that is to be deleted. We want to get all the column entries into a
			//comma seperated string
			for (int columnIndex = 0; columnIndex < numberOfColumns; columnIndex++)
			{
				columnValue = dataGridView.Rows[rowNumber].Cells[columnIndex].Value.ToString();
				rowInfo += columnValue + ",";
			}

			//remove the last comma in the string
			rowInfo = rowInfo.Remove(rowInfo.Length - 1, 1);

			return rowInfo;
		}

		/// <summary>
		/// Class to describe the data that gets filled onto a grid view.
		/// </summary>
		internal class GridViewData 
		{	
			/// <summary>
			/// Gets or sets the data into a DataTable.
			/// </summary>
			/// <value>
			/// The data.
			/// </value>
			public DataTable data { set; get; }

			/// <summary>
			/// Gets or sets a list of strings containing the dates to be used on the grid view for filtering.
			/// </summary>
			/// <value>
			/// The dates.
			/// </value>
			public HashSet<string> dates { set; get; }

			/// <summary>
			/// Gets or sets the total KGS.
			/// </summary>
			/// <value>
			/// The total KGS.
			/// </value>
			public double totalKgs { set; get; }

			/// <summary>
			/// Gets or sets the total amount.
			/// </summary>
			/// <value>
			/// The total amount.
			/// </value>
			public double totalAmount { get; set; }
		}
	}
}
