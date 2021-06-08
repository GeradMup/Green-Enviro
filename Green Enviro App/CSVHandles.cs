using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	class CSVHandles
	{
		private static string startingSubstringForLineToBeDeleted = "";

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
				infoToDelete += column + ",";
			}

			bool rowFalseMatch;
			//For loop to Highlight all the rows where information will be deleted
			foreach (DataGridViewRow row in dataGridView.Rows)
			{
				//False match is true if rows don't match and false if they do match
				//We start by assuming that the rows actually match
				rowFalseMatch = false;
				for (int colNum = 0; colNum < numberOfColumns; colNum++) 
				{
					if (row.Cells[colNum].Value.ToString() != columnInfo[colNum]) 
					{
						rowFalseMatch = true;
						break;
					}
				}

				if(rowFalseMatch == false)
				{
					row.DefaultCellStyle.BackColor = Color.Red;
				}
			}
			dataGridView.Refresh();

			return infoToDelete;
		}
		/// <summary>
		/// Deletes every entry in the CSV file at the given path where the starting substring matches the provide
		/// starting substring
		/// </summary>
		/// <param name="path">The path.</param>
		/// <param name="startingSubstring">The starting substring.</param>
		public void DeleteInCSV(string path, string startingSubstring)
		{
			startingSubstringForLineToBeDeleted = startingSubstring;
			string[] lines = System.IO.File.ReadAllLines(path);
			//Create a list from the array
			List<string> fileLines = new List<string>(lines);

			//This is a List method that passes each element in the List to the given Predicate
			//and deletes every element from the list where the Predicate returns a true value
			fileLines.RemoveAll(startsWithRequiredString);

			StringBuilder _csv_content = new StringBuilder();
			//Recreate
			foreach (string line in fileLines)
			{
				_csv_content.AppendLine(line);
			}

			//Replace the entire CSV file with the updated contents
			File.WriteAllText(path, _csv_content.ToString());
		}

		private Predicate<string> startsWithRequiredString = delegate (string line)
		{
			//return true if the given line starts with the given condition
			return line.StartsWith(startingSubstringForLineToBeDeleted);
		};

	}
}
