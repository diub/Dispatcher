using System;
using System.Collections.Generic;
//using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Reflection.Emit;


namespace diub.Threads {

	// https://www.codeproject.com/articles/22615/dynamically-invoke-generic-methods

	static public partial class Invoker {

		private delegate RV GenericFunctionInvokerDelegate<RV> (object Instance, MethodInfo MI, object [] Params);

		static public RV GenericFunctionInvokedCall<RV> (object Instance, MethodInfo MI, object [] Params) {
			return (RV) MI.Invoke (Instance, Params);
		}

		/// <summary>
		/// Führt ein Invoke für ein Steuerelement/Formular auf eine generische(!) Funktion des Steuerelementes / des Formulars durch.
		/// </summary>
		/// <param name="Ctrl">Steuerelement oder Formular für welches der Invoke erfolgen soll.</param>
		/// <param name="ActionName">Name der aufzurufenden Funktion</param>
		/// <param name="Parameters">Die Parameter, mit der die Funktion aufgerufen werden soll.</param>
		/// <returns></returns>
		static public RV GenericFunctionInvoker<RV> (Control Ctrl, string ActionName, params object [] Parameters) {
			Type[] generic_types, param_types;
			MethodInfo mi;
			GenericFunctionInvokerDelegate<RV> generic_delegate;

			generic_types = new Type [] { };
			param_types = new Type [Parameters.Length];
			for (int i = 0; i < param_types.Length; i++)
				param_types [i] = Parameters [i].GetType ();
			mi = FindMethod (Ctrl.GetType (), ActionName, generic_types, param_types);
			generic_delegate = GenericFunctionInvokedCall<RV>;
			return (RV) Ctrl.Invoke (generic_delegate, new object [] { Ctrl, mi, Parameters });
		}

		/// <summary>
		/// Führt ein Invoke für ein Steuerelement/Formular auf die Funktion einer beliebigen Klasse aus. /// </summary>
		/// <param name="Ctrl">Steuerelement oder Formular für welches der Invoke erfolgen soll.</param>
		/// <param name="ClassType">typeof (Klassenname) für eine beliebige Klasse, in der die aufzurufende Funktion liegt.</param>
		/// <param name="ActionName">Name der aufzurufenden Funktion</param>
		/// <param name="Parameters">Die Parameter, mit der die Funktion aufgerufen werden soll.</param>
		/// <returns></returns>
		static public RV GenericFunctionInvoker<RV> (Control Ctrl, Type ClassType, string ActionName, params object [] Parameters) {
			Type[] generic_types, param_types;
			MethodInfo mi;
			GenericFunctionInvokerDelegate<RV> generic_delegate;

			generic_types = new Type [] { };
			param_types = new Type [Parameters.Length];
			for (int i = 0; i < param_types.Length; i++)
				param_types [i] = Parameters [i].GetType ();
			mi = FindMethod (ClassType, ActionName, generic_types, param_types);
			generic_delegate = GenericFunctionInvokedCall<RV>;
			return (RV) Ctrl.Invoke (generic_delegate, new object [] { Ctrl, mi, Parameters });
		}

	}   // class

}   //	namespace	2020-03-25 - 18.56.37