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

		/// <summary>Adds new employee to the database.</summary>
		/// <param name="employeeInfo">The employee information.</param>
		/// <exception cref="System.Exception"></exception>
		public void addEmployee(EmployeeInfo employeeInfo)
		{
			string[] employeeInfoString = { employeeInfo.employeeName,
											employeeInfo.employeeSurname,
											employeeInfo.employeeId,
											employeeInfo.employeeGender,
											employeeInfo.employeeAddress,
											employeeInfo.employeeCell };

			try
			{
				database.insert(Database.Tables.Employees, employeeInfoString);
			}
			catch (Exception ex) 
			{
				throw new Exception(ex.Message);
			}
		}

		/// <summary>
		/// Internal class to describe all the properties of the Employee object.
		/// </summary>
		public class EmployeeInfo
		{
			/// <summary>Initializes a new instance of the <see cref="EmployeeInfo" /> class.</summary>
			public EmployeeInfo()
			{
				employeeName = "";
				employeeSurname = "";
				employeeId = "";
				employeeGender = "";
				employeeAddress = "";
				employeeCell = "";
			}

			/// <summary>Gets or sets the name of the employee.</summary>
			/// <value>The name of the employee.</value>
			public string employeeName { get; set; }
			/// <summary>Gets or sets the employee surname.</summary>
			/// <value>The employee surname.</value>
			public string employeeSurname { get; set; }
			/// <summary>Gets or sets the employee identifier.</summary>
			/// <value>The employee identifier.</value>
			public string employeeId { get; set; }
			/// <summary>Gets or sets the employee gender.</summary>
			/// <value>The employee gender.</value>
			public string employeeGender { get; set; }
			/// <summary>Gets or sets the employee address.</summary>
			/// <value>The employee address.</value>
			public string employeeAddress { get; set; }
			/// <summary>Gets or sets the employee cell number.</summary>
			/// <value>The employee cell number.</value>
			public string employeeCell { get; set; }

		}
	}
}
 