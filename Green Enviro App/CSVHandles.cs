using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	class CSVHandles
	{
		/// <summary>
		/// This function will request the user to confirm that they want to go ahead with deleting the entries
		/// After confirmation, the WarningWaitingFunction will be excecuted (Called from the warning class)
		/// </summary>
		public void RequestUserConfirmation(Form returnForm, WarningInterface returnClass)
		{
			string warningMessage = "YOU ARE ABOUT TO DELETE ALL THE ENTRIES HIGHLIGHTED IN RED!!!";
			Warning warning = new Warning(returnForm, warningMessage, returnClass);
		}

		/// <summary>
		/// This function will highlight all the rows that need to be deleted so that the user can 
		/// confirm that they want to delete those rows
		/// </summary>
		public string RowsToDelete(int selectedRow,DataGridView dataGridView,int numberOfColumns)
		{
			List<string> columnInfo = new List<string>();
			string infoToDelete = "";

			for (int columnIndex = 0; columnIndex < numberOfColumns; columnIndex++) 
			{
				string column = dataGridView.Rows[selectedRow].Cells[columnIndex].Value.ToString();
				columnInfo.Add(column);
				infoToDelete += columnInfo[columnIndex] + ",";
			}
			int columnNumber;
			//For loop to Highlight all the rows where information will be deleted
			foreach (DataGridViewRow row in dataGridView.Rows)
			{
				columnNumber = 0;
				if ((row.Cells[columnNumber].Value.ToString() == columnInfo[columnNumber++]) &&
					(row.Cells[columnNumber].Value.ToString() == columnInfo[columnNumber++]) &&
					(row.Cells[columnNumber].Value.ToString() == columnInfo[columnNumber++]) &&
					(row.Cells[columnNumber].Value.ToString() == columnInfo[columnNumber++]) &&
					(row.Cells[columnNumber].Value.ToString() == columnInfo[columnNumber++]))
				{
					row.DefaultCellStyle.BackColor = Color.Red;
				}
			}
			dataGridView.Refresh();

			return infoToDelete;
		}

	}
}
