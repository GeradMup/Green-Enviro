using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Green_Enviro_App
{
	/// <summary>
	///   Class for return actions after warnings have been issued out before certain actions like deleting items
	/// </summary>
	public abstract class WarningInterface
	{
		/// <summary>Function to be called after warning has been dislayed before deleting items</summary>
		/// <param name="actionConfirmed">Boolean to say what the user has chosen. 
		/// True if the user confirmed the action</param>
		public abstract void DeleteEntriesWarning(bool actionConfirmed);

		/// <summary>Function that will be called after the warning if the user was trying to add
		/// Purchase entries to the Purchases Police Register</summary>
		/// <param name="actionConfirmed">if set to <c>true</c> [action confirmed].</param>
		public abstract void PurchasePRWarning(bool actionConfirmed);
	}
}
