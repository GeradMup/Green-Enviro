using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Green_Enviro_App
{
	/// <summary>
	/// Class to handle all the user interactions with the fixed expenses.</summary>
	public partial class FixedExpensesViews : Form
	{
		FixedExpensesModel _fixedExpensesModel;
		Form parentForm;
		
		/// <summary>Initializes a new instance of the <see cref="FixedExpensesViews" /> class.</summary>
		/// <param name="pf">The parent form that's currently active before the FixedExpenses form is opened.</param>
		/// <param name="db">The database object.</param>
		/// <param name="fem">The FixedExpensesModel</param>
		public FixedExpensesViews(Form pf, FixedExpensesModel fem)
		{
			InitializeComponent();
			_fixedExpensesModel = fem;
			parentForm = pf;
			
			initializeFixedExpenses();
		}


	}
}
