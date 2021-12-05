using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Enviro_App
{
	/// <summary>
	/// Class EmployeesModel handles all the business logic relating to Employees.
	/// </summary>
	public class EmployeesModel
	{
		Database database;
		/// <summary>
		/// Initializes a new instance of the <see cref="EmployeesModel">EmployeesModel</see> class.
		/// </summary>
		/// <param name="db">The database.</param>
		public EmployeesModel(Database db) 
		{
			database = db;
		}

		/// <summary>Gets the employees and their information and returns a DataTable.</summary>
		/// <returns>DataTable.</returns>
		public DataTable getEmployees() 
		{
			return database.selectAll(Database.Tables.Employees);
		}
	}
}
 