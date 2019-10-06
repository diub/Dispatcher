using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace diub.Threads {

	static public partial class Invoker {

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

		static public void SetInvoke (this Control Ctrl, String PropertyName, dynamic Obj) {
			SetInvoke<dynamic> (Ctrl, PropertyName, Obj);
		}

		static public void SetInvoke<T> (object Instance, String PropertyName, T Obj) {
			Instance.GetType ().GetMethod ("set_" + PropertyName).Invoke (Instance,new object [] { Obj });
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

}   //	namespace	2019-04-24 - 14.04.53