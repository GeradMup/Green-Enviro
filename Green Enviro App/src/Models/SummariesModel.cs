using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Enviro_App
{
	class SummariesModel
	{
		FileHandles fileHandles;

		public SummariesModel(FileHandles fh) 
		{
			fileHandles = fh;
		}

		/// <summary>
		/// Gets all all the months for which summaries can be calculated.
		/// Summaries will base its months on the number of months for which purchases are available.
		/// </summary>
		/// <returns>A list of strings representing the months.</returns>
		public List<string> getMonths()
		{
			return fileHandles.getLogNames(FileHandles.LogType.Purchases);
		}
	}
}
