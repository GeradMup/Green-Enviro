using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	/// <summary>This class handles all the reading, writing. deleting, etc from CSV Files.</summary>
	class CSVHandles
	{
		private static string startingSubstringForLineToBeDeleted = "";
		private List<int> highlightedRows = new List<int>();
		DataGridView dataGridView;
		int numberOfColumns;

		public CSVHandles() { }

		/// <summary>
		/// This function will highlight all the rows that need to be deleted so that the user can 
		/// confirm that they want to delete those rows
		/// </summary>
		public void RowsToDelete(int selectedRow)
		{
			List<string> columnInfo = new List<string>();
			string infoToDelete = "";
			highlightedRows.Clear();
			//NOTE !!!!
			//Number of unique columns are the columns that are unique to each entry
			//These will be used to choose the unique identifiers for each column so that
			//The correct entries can be deleted
			for (int columnIndex = 0; columnIndex < numberOfColumns; columnIndex++) 
			{
				string column = dataGridView.Rows[selectedRow].Cells[columnIndex].Value.ToString();
				columnInfo.Add(column);
				infoToDelete += column + ",";
			}

			//Remove the last comma inserted at the end of the string
			infoToDelete = infoToDelete.Remove(infoToDelete.Length - 1, 1);
			startingSubstringForLineToBeDeleted = infoToDelete;
			bool rowFalseMatch;
			//For loop to Highlight all the rows where information will be deleted
			foreach (DataGridViewRow row in dataGridView.Rows)
			{
				//False match is true if rows don't match and false if they do match
				//We start by assuming that the rows actually match
				rowFalseMatch = false;

				//This for loop checks to make sure that all the information in the row matches the info to be deleted
				//Note that info must match for every single column
				for (int colNum = 0; colNum < numberOfColumns; colNum++) 
				{
					if (row.Cells[colNum].Value.ToString() != columnInfo[colNum]) 
					{
						rowFalseMatch = true;
						break;
					}
				}

				//If rowFalseMatch is false, it means all the information matched exactly
				if(rowFalseMatch == false)
				{
					row.DefaultCellStyle.BackColor = Color.Red;
					highlightedRows.Add(row.Index);
				}
			}
			dataGridView.Refresh();
		}
		
		/// <summary>
		/// Deletes every entry in the CSV file at the given path where the starting substring matches the provide starting substring.
		/// Use the <see cref="setRowToDelete">setRowToDelete</see> method to set the starting substring to be deleted.
		/// </summary>
		/// <param name="path">The path.</param>
		public void deleteInCSV(string path)
		{
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

		/// <summary>
		/// The substring used to pickout the row to be deleted.
		/// </summary>
		/// <param name="rowInfo">The row information.</param>
		public void setRowToDelete(string rowInfo) 
		{
			startingSubstringForLineToBeDeleted = rowInfo;
		}

		/// <summary>
		/// Predicate to check if the passed row starts with the required substring.
		/// </summary>
		private Predicate<string> startsWithRequiredString = delegate (string line)
		{
			//return true if the given line starts with the given condition
			return line.StartsWith(startingSubstringForLineToBeDeleted);
		};

		/// <summary>
		/// Erases the highlight marks that were made when indicating which rows will be deleted
		/// </summary>
		public void eraseHighlightMarks() 
		{
			//Remove the red highlighting on the previously selected rows
			//if the user decides to cancel the deletion

			foreach(int rowNumber in highlightedRows)
			{
				dataGridView.Rows[rowNumber].DefaultCellStyle.BackColor = Color.White;
			}
		}

		/// <summary>
		/// Reads contents of a csv file given the path. 
		/// </summary>
		/// <param name="filePath">Path to the read file.</param>
		/// <returns name="_data_table">A data table containing the contents of the csv file</returns>
		public DataTable getCSVContents(string filePath) 
		{
			DataTable _data_table = new DataTable();

			string[] lines = System.IO.File.ReadAllLines(filePath);
			if (lines.Length > 0)
			{
				//first line to create the table headers
				string _first_line = lines[0];
				string[] _header_labels = _first_line.Split(',');
				if (!_data_table.Columns.Contains(_header_labels[0]))
				{
					foreach (string _header_word in _header_labels)
					{
						_data_table.Columns.Add(new DataColumn(_header_word));
					}
				}

				//Now we populate the table with the rest of the information that we want to view
				for (int _row = 1; _row < lines.Length; _row++)
				{
					//For each line, we want a list of the words on the line seperated by the comma
					string[] dataWords = lines[_row].Split(',');
					DataRow _data_row = _data_table.NewRow();
					int columnIndex = 0;
					foreach (string headerWord in _header_labels)
					{
						_data_row[headerWord] = dataWords[columnIndex++];
					}
					_data_table.Rows.Add(_data_row);
				}
			}
			return _data_table;
		}

		/// <summary>Adds strings to a CSV file given a list of the strings and the path to the file</summary>
		/// <param name="path">The path.</param>
		/// <param name="lines">The lines.</param>
		/// <exception cref="FailedToAddToCSVFile">Throws an exception if something goes wrong in the process of
		/// adding content to a CSV file.</exception>
		/// <exception cref="PathDoesNotExist">Throws an exception if the given file path is invalid.</exception>
		public void addToCSV(string path, List<string> lines) 
		{
			//First let us check if the given file path is valid or not.
			//If the path does not exist, we throw an exception.
			if (!File.Exists(path)) throw new PathDoesNotExist();


			StringBuilder _csv_content = new StringBuilder();

			foreach (string line in lines)
			{
				_csv_content.AppendLine(line);
			}

			//Try to save your lines in the CSV file. If the process fails, through an exception.
			try
			{
				File.AppendAllText(path, _csv_content.ToString());
			}
			catch (Exception)
			{
				throw new FailedToAddToCSVFile();
			}
		}

		/// <summary>Highlights the row that is currently selected it the data gridview</summary>
		/// <param name="selectedRow">The selected row.</param>
		public void highlightRow(int selectedRow) 
		{
			dataGridView.Rows[selectedRow].DefaultCellStyle.BackColor = Color.GreenYellow;
			highlightedRows.Add(selectedRow);
		}

		/// <summary>Gets the dates in a CSV file</summary>
		/// <param name="path">The path.</param>
		/// <returns>
		///	  A Hashset of strings
		///   <br />
		///   The Hashset will contain all the unique dates in the file
		/// </returns>
		/// 
		public HashSet<string> getDatesInFile(string path) 
		{
			string[] lines = System.IO.File.ReadAllLines(path);
			HashSet<string> _dates = new HashSet<string>();

			if (lines.Length > 0)
			{
				for (int _row = 1; _row < lines.Length; _row++)
				{
					//For each line, we want a list of the words on the line seperated by the comma
					string[] dataWords = lines[_row].Split(',');

					//Now we want to add only the first word to a list of days if it is unique
					//In order to make sure that we do not repeat strings, we use a HashSet string
					_dates.Add(dataWords[0]);
				}
			}
			return _dates;
		}

		/// <summary>
		/// Checks if a given entry exists in the csv file with the given path
		/// </summary>
		/// <param name="path">The path.</param>
		/// <param name="entry">The information row.</param>
		/// <returns>Returns True if row exists, otherwise False.</returns>
		public bool entryExistsInCSV(string path, string entry) 
		{
			string[] lines = System.IO.File.ReadAllLines(path);
			if (lines.Contains(entry))
			{
				return true;
			}
			else 
			{
				return false;
			}
		}
	}

	/// <summary>The exception to be thrown when adding lines to a CSV file have failed.</summary>
	public class FailedToAddToCSVFile : Exception
	{
		const string EXCEPTION_MESSAGE = "FAILED TO ADD CONTENTS TO THE CSV FILE!";
		/// <summary>Initializes a new instance of the <see cref="FailedToAddToCSVFile" /> class.</summary>
		public FailedToAddToCSVFile() : base(EXCEPTION_MESSAGE){}
	}
}
