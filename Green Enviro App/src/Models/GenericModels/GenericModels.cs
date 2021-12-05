using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Enviro_App
{
	/// <summary>This class defines all the generic objects and methods that will be used by other classes.</summary>
	public class GenericModels
	{
		internal class CompanyInfo
		{
			public CompanyInfo(string _name = "Unknown", string _contactPerson = "Unknown", string _email = "Unknown",
								string _contactNumber = "0000000000", string _physcalAddress = "Unknown")
			{
				this.companyName = _name;
				this.contactPerson = _contactPerson;
				this.emailAddress = _email;
				this.contactNumber = _contactNumber;
				this.physicalAddress = _physcalAddress;
			}

			public string companyName { set; get; }

			public string contactPerson { set; get; }

			public string emailAddress { get; set; }

			public string contactNumber { get; set; }

			public string physicalAddress { get; set; }

		}

		/// <summary>Converts the name of any enum field into a string.</summary>
		/// <typeparam name="EnumType">The name of the enum class.</typeparam>
		/// <param name="enumField">The enum field to be converted.</param>
		/// <returns>A string representation of the enum field name.</returns>
		public static string enumToString<EnumType>(EnumType enumField)
		{
			string enumName = enumField.ToString();
			return enumName;
		}

		/// <summary>Generic function that converts a string into an enum type.</summary>
		/// <typeparam name="EnumType">The type of enum to convert to.</typeparam>
		/// <param name="enumName">Name of the enum.</param>
		/// <returns>The a field of the given enum type after conversion.</returns>
		public static EnumType stringToEnum<EnumType>(string enumName)
		{
			EnumType enumField = (EnumType)Enum.Parse(typeof(EnumType), enumName, true);
			return enumField;
		}

		/// <summary>Function to generate a string containing all the fields of a given enum type.</summary>
		/// <typeparam name="EnumType">The enum type.</typeparam>
		/// <returns>A string representing all the fields of the enum seperated by commas.</returns>
		public static string enumFieldsToString<EnumType>()
		{
			string[] values = Enum.GetNames(typeof(EnumType));
			string stringValues = "";

			foreach (string value in values)
			{
				stringValues = stringValues + "," + value;
			}

			//remove the first comma
			stringValues = stringValues.Remove(0, 1);
			return stringValues;
		}

		/// <summary>Generates the path to save a file.</summary>
		/// <param name="basePath">The base path to the file. If a file with a given path already exists, a number is appended to the file name to make it unique.</param>
		/// <param name="month">The month which will be used in the path.</param>
		/// <param name="fileName">Name of the file.</param>
		/// <param name="fileExtension">The file extension.</param>
		/// <returns>A string that contains the full path to the file that will be created.</returns>
		public static string generateSavePath(string basePath, string month, string fileName, string fileExtension)
		{
			string date = Constants.DATE;
			string savePath = "";

			int maxFilesNumber = 200;
			string extraExtension = "";

			for (int fileNumber = 0; fileNumber < maxFilesNumber; fileNumber++)
			{
				extraExtension = fileNumber.ToString();

				savePath = basePath + @"\" + month + @"\" + fileName + @"_" + extraExtension + fileExtension;

				if (!File.Exists(savePath)) break;
			}

			return savePath;
		}
	}


	/// <summary>The exception thrown when a given path does not exist.</summary>
	public class PathDoesNotExist : Exception 
	{
		const string EXCEPTION_MESSAGE = "The specified path does not exist!";
		/// <summary>Initializes a new instance of the <see cref="PathDoesNotExist" /> class.</summary>
		public PathDoesNotExist() : base(EXCEPTION_MESSAGE){}
	}
}
