using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace diub.Threads {

	static public partial class Invoker {

		/// <summary>
		/// Ruft eine Event-Funktion via Invoke auf.
		/// </summary>
		/// <param name="Ctrl"></param>
		/// <param name="EventHandler"></param>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		static public void EventInvoke (this Control Ctrl, EventHandler EventHandler, object sender, EventArgs e) {
			Ctrl.Invoke (new Action<object, EventArgs> (EventHandler), sender, e);
		}

		/// <summary>
		/// Ruft eine Event-Funktion in via Invoke in einem eigenen Thread auf. Liefert ein Run-Objekt zurück.
		/// </summary>
		/// <param name="Ctrl"></param>
		/// <param name="EventHandler"></param>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// <returns></returns>
		static public Run RunEventInvoke (this Control Ctrl, EventHandler EventHandler, object sender, EventArgs e) {
			return new RunAction<Control, EventHandler, object, EventArgs> (EventInvoke, Ctrl, EventHandler, sender, e);
		}


	}   // class

}	//	namespace	2019-04-24 - 14.05.59