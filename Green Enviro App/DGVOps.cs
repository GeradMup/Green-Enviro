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

	}
}
