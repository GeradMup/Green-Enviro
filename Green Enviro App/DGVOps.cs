using System;
using System.Collections.Generic;
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
			string _empty_string = " ";
			string _totals = "TOTALS";
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

	}
}
