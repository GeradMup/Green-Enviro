using System;
using System.Collections.Generic;
using System.Data;
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
		private List<int> highlightedRows = new List<int>();
		DataGridView dataGridView;
		int numberOfColumns;

		public CSVHandles(DataGridView grid, int unqCols) 
		{
			dataGridView = grid;
			numberOfColumns = unqCols;
		}

		/// <summary>
		/// This function will request the user to confirm that they want to go ahead with deleting the entries
		/// After confirmation, the WarningWaitingFunction will be excecuted (Called from the warning class)
		/// </summary>
		public void ConfirmDeletion(Form returnForm, WarningInterface returnClass)
		{
			string warningMessage = "YOU ARE ABOUT TO DELETE ALL THE ENTRIES HIGHLIGHTED IN RED!!!";
			Warning warning = new Warning(returnForm, warningMessage, returnClass, RequestedAction.DeleteEntry);
		}

		public void ConfirmPurchasePRAddition(Form returnForm, WarningInterface returnClass) 
		{
			string warningMessage = "YOU ARE ABOUT TO ADD THE HIGHLIGHTED ENTRY TO THE PURCHASE POLICE REGISTER";
			Warning warning = new Warning(returnForm, warningMessage, returnClass, RequestedAction.AddPurchaseToPr);
		}

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

			MessageBox.Show(infoToDelete);
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
		/// Deletes every entry in the CSV file at the given path where the starting substring matches the provide
		/// starting substring
		/// </summary>
		/// <param name="path">The path.</param>
		public void DeleteInCSV(string path)
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

		private Predicate<string> startsWithRequiredString = delegate (string line)
		{
			//return true if the given line starts with the given condition
			return line.StartsWith(startingSubstringForLineToBeDeleted);
		};

		/// <summary>
		/// Erases the highlight marks that were made when indicating which rows will be deleted
		/// </summary>
		/// <param name="dataGridView">The data grid view.</param>
		public void eraseHighlightMarks() 
		{
			//Remove the red highlighting on the previously selected rows
			//if the user decides to cancel the deletion

			foreach(int rowNumber in highlightedRows)
			{
				dataGridView.Rows[rowNumber].DefaultCellStyle.BackColor = Color.White;
			}
		}

		public void createCSVFile(string path, string headers) 
		{
			//First Check if the files exist for each month
			//If the file does not exist, create it
			if (!File.Exists(path))
			{
				StringBuilder _csv_content = new StringBuilder();
				_csv_content.AppendLine(headers);
				//_csv_content.AppendLine("\n");
				File.AppendAllText(path, _csv_content.ToString());
			}
		}

		/// <summary>
		/// Reads contents of a csv file given the path. 
		/// </summary>
		/// <param name="_path_to_log_file">The path to log file.</param>
		/// <returns name="_data_table">A data table containing the contents of the csv file</returns>
		public DataTable getCSVContents(string _path_to_log_file) 
		{
			DataTable _data_table = new DataTable();

			string[] lines = System.IO.File.ReadAllLines(_path_to_log_file);
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

		/// <summary>
		/// Gets the files in folder and adds them to the given combo box 
		/// </summary>
		/// <param name="folder">The path to the folder.</param>
		/// <param name="comboBox"></param>
		/// <returns name="fileNames">A list of all the file names in folder</returns>

		public List<string> getFilesInFolder(string folder, ComboBox comboBox) 
		{
			List<string> fileNames = new List<string>();

			DirectoryInfo _directory = new DirectoryInfo(folder);
			FileInfo[] _files = _directory.GetFiles("*.csv");   //Getting Text files
			foreach (FileInfo _file in _files)
			{
				char[] _remove_chars = { 'c', 's', 'v', '.' };
				string _file_name = _file.Name.TrimEnd(_remove_chars);
				comboBox.Items.Add(_file_name);
			}

			return fileNames;
		}

		/// <summary>Adds strings to a CSV file given a list of the strings and the path to the file</summary>
		/// <param name="path">The path.</param>
		/// <param name="lines">The lines.</param>
		/// <param name="parent_form">The form we will return to after showing the success CustomMessageBox Form</param>
		/// <param name="successMessage">The message to be displayed when writing to the csv file was successful</param>
		public void addToCSV(string path, List<string> lines, Form parent_form, string successMessage) 
		{
			StringBuilder _csv_content = new StringBuilder();

			foreach (string line in lines)
			{
				_csv_content.AppendLine(line);
			}

			try
			{
				File.AppendAllText(path, _csv_content.ToString());

				CustomMessageBox box = new CustomMessageBox(parent_form, CustomMessageBox.success, successMessage);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error! \n" + ex.Message);
			}
		}

		/// <summary>Highlights the row that is currently selected it the data gridview</summary>
		/// <param name="selectedRow">The selected row.</param>
		public void highlightRow(int selectedRow) 
		{
			dataGridView.Rows[selectedRow].DefaultCellStyle.BackColor = Color.GreenYellow;
			highlightedRows.Add(selectedRow);
		}
	}
}
