using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App 
{
	class GenericControllers
	{
		/// <summary>
		/// Displays an error box with the given message.
		/// </summary>
		/// <param name="parentForm">The parent form.</param>
		/// <param name="message">The message.</param>
		public static void reportError(Form parentForm, string message) 
		{ new CustomMessageBox(parentForm, CustomMessageBox.error, message); }

		/// <summary>
		/// Displays a success box with the given message.
		/// </summary>
		/// <param name="parentForm">The parent form.</param>
		/// <param name="message">The message.</param>
		public static void reportSuccess(Form parentForm, string message)
		{ new CustomMessageBox(parentForm, CustomMessageBox.success, message); }
	}
}
