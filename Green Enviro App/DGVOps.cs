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

		string _empty_string = " ";
		string _totals = "TOTALS";

		/// <summary>Initializes a new instance of the <see cref="DGVOps" /> class.</summary>
		public DGVOps(DataGridView grid, ComboBox month, ComboBox startDate, ComboBox endDate, ComboBox type, Form parent) 
		{
			dataGridView = grid;
			monthBox = month;
			startDateBox = startDate;
			endDateBox = endDate;
			typeBox = type;
			parentForm = parent;
		}

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
			//Do nothing if there are not filters selected
			if ((startDateBox.SelectedItem == null) && (endDateBox.SelectedItem == null)) return false;
			
			if ((startDateBox.SelectedItem != null) && (endDateBox.SelectedItem == null))
			{
				//Do nothing if there are not filters selected
				CustomMessageBox msg = new CustomMessageBox(parentForm, "Error!", "INVALID DATE RANGE!");
				startDateBox.SelectedItem = null;
				endDateBox.SelectedItem = null;
				return false;
			}

			if ((startDateBox.SelectedItem == null) && (endDateBox.SelectedItem != null))
			{
				//Do nothing if there are not filters selected
				CustomMessageBox msg = new CustomMessageBox(parentForm, "Error!", "INVALID DATE RANGE!");
				startDateBox.SelectedItem = null;
				endDateBox.SelectedItem = null;
				return false;
			}

			DateTime _start_date = Convert.ToDateTime(startDateBox.SelectedItem.ToString());
			DateTime _end_date = Convert.ToDateTime(endDateBox.SelectedItem.ToString());

			//Checks if the ending date is is not occuring before the start date.
			if (_start_date > _end_date)
			{
				CustomMessageBox msg = new CustomMessageBox(parentForm, "Error!", "INVALID DATE RANGE!");
				startDateBox.SelectedItem = null;
				endDateBox.SelectedItem = null;
				return false;
			}

			return true;
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

		/// <summary>Removes the filters when DataGridView Was being filtered</summary>
		public void RemoveFilters()
		{
			startDateBox.SelectedItem = null;
			endDateBox.SelectedItem = null;
			typeBox.SelectedItem = null;
		}

		/// <summary>Filters the grid view based on the selected dates and types.</summary>
		/// <param name="bindingSource">The binding source for the table displayed in the data grid view.</param>
		public void FilterGridView(ref BindingSource bindingSource)
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
					bindingSource.Filter = string.Format(filterString, _totals, _empty_string, filterStartDate, filterEndDate, _item_type);
				}
				else
				{
					filterString = "Date = '{0}' OR Date = '{1}' OR Date >= '{2}' AND Date <= '{3}'";
					bindingSource.Filter = string.Format(filterString, _totals, _empty_string, filterStartDate, filterEndDate);
				}
			}
			else
			{
				bindingSource.RemoveFilter();

				if (isTypeFiltered() == true)
				{
					string _item_type = typeBox.SelectedItem.ToString();
					filterString = "Date = '{0}' OR Date = '{1}' OR Type = '{2}'";
					bindingSource.Filter = string.Format(filterString, _totals, _empty_string, _item_type);
				}
			}
		}

		/// <summary>Highlights the totals row in the grid view to yellow.</summary>
		public void highlightTotalsRow() 
		{
			int _last_row_index = 0;
			_last_row_index = dataGridView.Rows.GetRowCount(DataGridViewElementStates.Visible) - 1;

			//Highlight the totals row
			dataGridView.Rows[_last_row_index].DefaultCellStyle.BackColor = Color.Yellow;
			dataGridView.Refresh();
		}

		//This function will add up the KG's and Amount column on the Data Grid View and adds a row to show the totals
		/// <summary>Adds the totals row to the data grid view</summary>
		/// <param name="dataTable"></param>
		/// <param name="kgCol"></param>
		/// <param name="amountCol"></param>
		public void addTotalsRow(DataTable dataTable, int kgCol, int amountCol)
		{
			float _total_kg = 0;
			float _total_amount = 0;
			int _kg_column = kgCol;
			int _amount_column = amountCol;

			for (int _row = 0; _row < dataGridView.Rows.Count; _row++)
			{
				_total_amount += float.Parse(dataGridView.Rows[_row].Cells[_amount_column].Value.ToString(), CultureInfo.InvariantCulture);
				_total_kg += float.Parse(dataGridView.Rows[_row].Cells[_kg_column].Value.ToString(), CultureInfo.InvariantCulture);
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
				if (_cell == _amount_column)
				{
					_last_row[_cell] = _total_amount;
				}
				else if (_cell == _kg_column)
				{
					_last_row[_cell] = _total_kg;
				}
				else
				{
					_last_row[_cell] = _empty_string;
				}
			}
			dataTable.Rows.Add(_last_row);
		}

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

		public void populateLogMonths(List<String> months) 
		{
			monthBox.Items.Clear();
			foreach(String month in months) 
			{
				monthBox.Items.Add(month);
			}
		}

	}
}
