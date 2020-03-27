using System;
using System.Collections.Generic;
//using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;


namespace diub.Threads {

	static public partial class Invoker {

		public delegate T ControlGetInvokerDelegate<T> (object Instance, MethodInfo MI);

		static public T ControlGetInvoker<T> (object Instance, MethodInfo MI) {
			return (T) MI.Invoke (Instance, null);
		}

		/// <summary>
		/// Für Toolbar-Items usw.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="Ctrl">Der ToolBar oder das Menu welches das eigentliche Zielobjekt enthält.</param>
		/// <param name="Instance">Das eigentliche Zielobjekt.</param>
		/// <param name="PropertyName">Der Name des Property.</param>
		/// <returns></returns>
		static public T GetInvoke<T> (Control Ctrl, object Instance, string PropertyName) {
			MethodInfo mi;
			ControlGetInvokerDelegate<T> control_invoker;

			mi = Instance.GetType ().GetMethod ("get_" + PropertyName);
			control_invoker = ControlGetInvoker<T>;
			return (T) Ctrl.Invoke (control_invoker, new object [] { Instance, mi });
		}

		static public dynamic GetInvoke (this Control Ctrl, String PropertyName) {
			return GetInvoke<dynamic> (Ctrl, PropertyName);
		}

		static public T GetInvoke<T> (object Instance, String PropertyName) {
			return (T) Instance.GetType ().GetMethod ("get_" + PropertyName).Invoke (Instance, null);
		}

		static public T GetInvoke<T> (this Control Ctrl, String PropertyName) {
			Delegate d;

			d = Delegate.CreateDelegate (typeof (Func<T>), Ctrl, "get_" + PropertyName);
			return (T) Ctrl.Invoke (d);
		}

		static public Run<T> RunGetInvoke<T> (this Control Ctrl, String PropertyName) {
			return new RunFunc<Control, String, T> (GetInvoke<T>, Ctrl, PropertyName);
		}


	}   // class

}   //	namespace	2019-04-24 - 14.04.53