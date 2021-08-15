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

		/// <summary>Determines whether the user is trying to filter data by the dates and
		/// if the selected date ranges are valid.</summary>
		/// <param name="startDate">The start date.</param>
		/// <param name="endDate">The end date.</param>
		/// <param name="parentForm">The parent form.</param>
		/// <returns>
		///   <c>true</c> if [Valid date ranges have been selected for filtering] [the specified start date]; otherwise, <c>false</c>.</returns>
		public bool isDateFiltered()
		{
			if ((startDateBox.SelectedItem == null) && (endDateBox.SelectedItem == null))
			{
				//Do nothing if there are not filters selected
				return false;
			}

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
	}
}
