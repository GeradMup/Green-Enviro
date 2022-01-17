using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastMember;
using Green_Enviro_App.src.DataAccess;

namespace Green_Enviro_App
{
	/// <summary>
	/// Class EmployeesModel handles all the business logic relating to Employees.
	/// </summary>
	public class EmployeesModel
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EmployeesModel">EmployeesModel</see> class.
		/// </summary>
		public EmployeesModel() 
		{
		}

		/// <summary>Gets the employees and their information and returns a DataTable.</summary>
		/// <returns>DataTable.</returns>
		public DataTable getEmployees() 
		{
			List<Employee> employees;
			DataTable employeesTable = new DataTable();
			using (DataEntities context = new DataEntities())
			{
				employees = context.Employees.ToList();

				string key = "Id";
				string name = "Name";
				string surname = "Surname";
				string id = "Identification";
				string gender = "Gender";
				string address = "Address";
				string cell = "Cell";
				using (ObjectReader reader = ObjectReader.Create(employees, key, name, surname, id, gender, address, cell))
				{
					employeesTable.Load(reader);
				}
			}

			return employeesTable;
		}

		/// <summary>Adds new employee to the database.</summary>
		/// <param name="employeeInfo">The employee information.</param>
		/// <exception cref="System.Exception"></exception>
		public void addEmployee(EmployeeInfo employeeInfo)
		{
			try
			{
				using (DataEntities context = new DataEntities()) 
				{
					Employee newEmployee = new Employee()
					{
						Name = employeeInfo.employeeName,
						Surname = employeeInfo.employeeSurname,
						Identification = employeeInfo.employeeId,
						Gender = employeeInfo.employeeGender,
						Address = employeeInfo.employeeAddress,
						Cell = employeeInfo.employeeCell
					};
					context.Employees.Add(newEmployee);
					context.SaveChanges();
				}
			}
			catch (Exception ex) 
			{
				throw new Exception(ex.Message);
			}
		}

		/// <summary>Updates employee existing employee details.</summary>
		/// <param name="employeeInfo">The employee information.</param>
		/// <param name="employeeIdentifier">Unique identifier number for the employee.</param>
		public void updateEmployee(EmployeeInfo employeeInfo, string employeeIdentifier) 
		{
			try
			{
				using (DataEntities context = new DataEntities()) 
				{
					Employee employee = context.Employees.SingleOrDefault(_emp => _emp.Identification == employeeIdentifier);
					if (employee != null) 
					{
						employee.Name = employeeInfo.employeeName;
						employee.Surname = employeeInfo.employeeSurname;
						employee.Identification = employeeInfo.employeeId;
						employee.Gender = employeeInfo.employeeGender;
						employee.Address = employeeInfo.employeeAddress;
						employee.Cell = employeeInfo.employeeCell;
						context.SaveChanges();
					}
				}
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
 