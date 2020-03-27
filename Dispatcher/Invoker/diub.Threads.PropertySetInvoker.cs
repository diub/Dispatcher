using System;
using System.Collections.Generic;
//using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;


namespace diub.Threads {

	static public partial class Invoker {

		public delegate void ControlSetInvokerDelegate<T> (object Instance, MethodInfo MI, T Value);

		static public void ControlSetInvoker<T> (object Instance, MethodInfo MI, T Value) {
			MI.Invoke (Instance, new object [] { Value });
		}

		/// <summary>
		/// Für Toolbar-Items usw.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="Ctrl">Der ToolBar oder das Menu welches das eigentliche Zielobjekt enthält.</param>
		/// <param name="Instance">Das eigentliche Zielobjekt.</param>
		/// <param name="PropertyName">Der Name des Property.</param>
		/// <returns></returns>
		static public void SetInvoke<T> (Control Ctrl, object Instance, string PropertyName, T Value) {
			MethodInfo mi;
			ControlSetInvokerDelegate<T> control_invoker;

			mi = Instance.GetType ().GetMethod ("set_" + PropertyName);
			control_invoker = ControlSetInvoker<T>;
			Ctrl.Invoke (control_invoker, new object [] { Instance, mi, Value });
		}

		static public void SetInvoke (this Control Ctrl, String PropertyName, dynamic Obj) {
			SetInvoke<dynamic> (Ctrl, PropertyName, Obj);
		}

		static public void SetInvoke<T> (object Instance, String PropertyName, T Obj) {
			Instance.GetType ().GetMethod ("set_" + PropertyName).Invoke (Instance, new object [] { Obj });
		}

		static public void SetInvoke<T> (this Control Ctrl, String PropertyName, T Obj) {
			Delegate d;

			d = Delegate.CreateDelegate (typeof (Action<T>), Ctrl, "set_" + PropertyName);
			Ctrl.Invoke (d, new object [] { Obj });
		}

		static public Run RunSetInvoke<T> (this Control Ctrl, String PropertyName, T Obj) {
			return new RunAction<Control, String, T> (SetInvoke<T>, Ctrl, PropertyName, Obj);
		}


	}   // class

}   //	namespace	2020-03-25 - 17.57.47