
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Reflection.Emit;


namespace diub.Threads {

	static public partial class Invoker {

		
		/// <summary>
		/// Führt ein Invoke für ein Steuerelement/Formular auf eine generische(!) Funktion des Steuerelementes / des Formulars durch.
		/// </summary>
		/// <param name="Ctrl">Steuerelement oder Formular für welches der Invoke erfolgen soll.</param>
		/// <param name="ActionName">Name der aufzurufenden Funktion</param>
		/// <param name="Parameters">Die Parameter, mit der die Funktion aufgerufen werden soll.</param>		
		static public void GenericActionInvoker<T0> (Control Ctrl, string ActionName, params object [] Parameters) {
			Type[] generic_types, param_types;
			MethodInfo mi;
			GenericActionInvokerDelegate generic_delegate;

			generic_types = new Type [] { typeof (T0) };
			param_types = new Type [Parameters.Length];
			for (int i = 0; i < param_types.Length; i++)
				param_types [i] = Parameters [i].GetType ();
			mi = FindMethod (Ctrl.GetType (), ActionName, generic_types, param_types);
			generic_delegate = GenericActionInvokedCall;
			Ctrl.Invoke (generic_delegate, new object [] { Ctrl, mi, Parameters });
		}

		/// <summary>
		/// Führt ein Invoke für ein Steuerelement/Formular auf die generische(!) Funktion einer beliebigen Klasse aus.
		/// </summary>
		/// <param name="Ctrl">Steuerelement oder Formular für welches der Invoke erfolgen soll.</param>
		/// <param name="ClassType">typeof (Klassenname) für eine beliebige Klasse, in der die aufzurufende Funktion liegt.</param>
		/// <param name="ActionName">Name der aufzurufenden Funktion</param>
		/// <param name="Parameters">Die Parameter, mit der die Funktion aufgerufen werden soll.</param>
		static public void GenericActionInvoker<T0> (Control Ctrl, Type ClassType, string ActionName, params object [] Parameters) {
			Type[] generic_types, param_types;
			MethodInfo mi;
			GenericActionInvokerDelegate generic_delegate;

			generic_types = new Type [] { typeof (T0) };
			param_types = new Type [Parameters.Length];
			for (int i = 0; i < param_types.Length; i++)
				param_types [i] = Parameters [i].GetType ();
			mi = FindMethod (ClassType, ActionName, generic_types, param_types);
			generic_delegate = GenericActionInvokedCall;
			Ctrl.Invoke (generic_delegate, new object [] { Ctrl, mi, Parameters });
		}

		/// <summary>
		/// Führt ein Invoke für ein Steuerelement/Formular auf eine generische(!) Funktion des Steuerelementes / des Formulars durch.
		/// </summary>
		/// <param name="Ctrl">Steuerelement oder Formular für welches der Invoke erfolgen soll.</param>
		/// <param name="ActionName">Name der aufzurufenden Funktion</param>
		/// <param name="Parameters">Die Parameter, mit der die Funktion aufgerufen werden soll.</param>
		/// <returns></returns>	
		static public RV GenericFunctionInvoker<T0, RV> (Control Ctrl, string ActionName, params object [] Parameters) {
			Type[] generic_types, param_types;
			MethodInfo mi;
			GenericFunctionInvokerDelegate<RV> generic_delegate;

			generic_types = new Type [] { typeof (T0) };
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
		static public RV GenericFunctionInvoker<T0, RV> (Control Ctrl, Type ClassType, string ActionName, params object [] Parameters) {
			Type[] generic_types, param_types;
			MethodInfo mi;
			GenericFunctionInvokerDelegate<RV> generic_delegate;

			generic_types = new Type [] { typeof (T0) };
			param_types = new Type [Parameters.Length];
			for (int i = 0; i < param_types.Length; i++)
				param_types [i] = Parameters [i].GetType ();
			mi = FindMethod (ClassType, ActionName, generic_types, param_types);
			generic_delegate = GenericFunctionInvokedCall<RV>;
			return (RV) Ctrl.Invoke (generic_delegate, new object [] { Ctrl, mi, Parameters });
		}
		
		/// <summary>
		/// Führt ein Invoke für ein Steuerelement/Formular auf eine generische(!) Funktion des Steuerelementes / des Formulars durch.
		/// </summary>
		/// <param name="Ctrl">Steuerelement oder Formular für welches der Invoke erfolgen soll.</param>
		/// <param name="ActionName">Name der aufzurufenden Funktion</param>
		/// <param name="Parameters">Die Parameter, mit der die Funktion aufgerufen werden soll.</param>		
		static public void GenericActionInvoker<T0, T1> (Control Ctrl, string ActionName, params object [] Parameters) {
			Type[] generic_types, param_types;
			MethodInfo mi;
			GenericActionInvokerDelegate generic_delegate;

			generic_types = new Type [] { typeof (T0), typeof (T1) };
			param_types = new Type [Parameters.Length];
			for (int i = 0; i < param_types.Length; i++)
				param_types [i] = Parameters [i].GetType ();
			mi = FindMethod (Ctrl.GetType (), ActionName, generic_types, param_types);
			generic_delegate = GenericActionInvokedCall;
			Ctrl.Invoke (generic_delegate, new object [] { Ctrl, mi, Parameters });
		}

		/// <summary>
		/// Führt ein Invoke für ein Steuerelement/Formular auf die generische(!) Funktion einer beliebigen Klasse aus.
		/// </summary>
		/// <param name="Ctrl">Steuerelement oder Formular für welches der Invoke erfolgen soll.</param>
		/// <param name="ClassType">typeof (Klassenname) für eine beliebige Klasse, in der die aufzurufende Funktion liegt.</param>
		/// <param name="ActionName">Name der aufzurufenden Funktion</param>
		/// <param name="Parameters">Die Parameter, mit der die Funktion aufgerufen werden soll.</param>
		static public void GenericActionInvoker<T0, T1> (Control Ctrl, Type ClassType, string ActionName, params object [] Parameters) {
			Type[] generic_types, param_types;
			MethodInfo mi;
			GenericActionInvokerDelegate generic_delegate;

			generic_types = new Type [] { typeof (T0), typeof (T1) };
			param_types = new Type [Parameters.Length];
			for (int i = 0; i < param_types.Length; i++)
				param_types [i] = Parameters [i].GetType ();
			mi = FindMethod (ClassType, ActionName, generic_types, param_types);
			generic_delegate = GenericActionInvokedCall;
			Ctrl.Invoke (generic_delegate, new object [] { Ctrl, mi, Parameters });
		}

		/// <summary>
		/// Führt ein Invoke für ein Steuerelement/Formular auf eine generische(!) Funktion des Steuerelementes / des Formulars durch.
		/// </summary>
		/// <param name="Ctrl">Steuerelement oder Formular für welches der Invoke erfolgen soll.</param>
		/// <param name="ActionName">Name der aufzurufenden Funktion</param>
		/// <param name="Parameters">Die Parameter, mit der die Funktion aufgerufen werden soll.</param>
		/// <returns></returns>	
		static public RV GenericFunctionInvoker<T0, T1, RV> (Control Ctrl, string ActionName, params object [] Parameters) {
			Type[] generic_types, param_types;
			MethodInfo mi;
			GenericFunctionInvokerDelegate<RV> generic_delegate;

			generic_types = new Type [] { typeof (T0), typeof (T1) };
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
		static public RV GenericFunctionInvoker<T0, T1, RV> (Control Ctrl, Type ClassType, string ActionName, params object [] Parameters) {
			Type[] generic_types, param_types;
			MethodInfo mi;
			GenericFunctionInvokerDelegate<RV> generic_delegate;

			generic_types = new Type [] { typeof (T0), typeof (T1) };
			param_types = new Type [Parameters.Length];
			for (int i = 0; i < param_types.Length; i++)
				param_types [i] = Parameters [i].GetType ();
			mi = FindMethod (ClassType, ActionName, generic_types, param_types);
			generic_delegate = GenericFunctionInvokedCall<RV>;
			return (RV) Ctrl.Invoke (generic_delegate, new object [] { Ctrl, mi, Parameters });
		}
		
		/// <summary>
		/// Führt ein Invoke für ein Steuerelement/Formular auf eine generische(!) Funktion des Steuerelementes / des Formulars durch.
		/// </summary>
		/// <param name="Ctrl">Steuerelement oder Formular für welches der Invoke erfolgen soll.</param>
		/// <param name="ActionName">Name der aufzurufenden Funktion</param>
		/// <param name="Parameters">Die Parameter, mit der die Funktion aufgerufen werden soll.</param>		
		static public void GenericActionInvoker<T0, T1, T2> (Control Ctrl, string ActionName, params object [] Parameters) {
			Type[] generic_types, param_types;
			MethodInfo mi;
			GenericActionInvokerDelegate generic_delegate;

			generic_types = new Type [] { typeof (T0), typeof (T1), typeof (T2) };
			param_types = new Type [Parameters.Length];
			for (int i = 0; i < param_types.Length; i++)
				param_types [i] = Parameters [i].GetType ();
			mi = FindMethod (Ctrl.GetType (), ActionName, generic_types, param_types);
			generic_delegate = GenericActionInvokedCall;
			Ctrl.Invoke (generic_delegate, new object [] { Ctrl, mi, Parameters });
		}

		/// <summary>
		/// Führt ein Invoke für ein Steuerelement/Formular auf die generische(!) Funktion einer beliebigen Klasse aus.
		/// </summary>
		/// <param name="Ctrl">Steuerelement oder Formular für welches der Invoke erfolgen soll.</param>
		/// <param name="ClassType">typeof (Klassenname) für eine beliebige Klasse, in der die aufzurufende Funktion liegt.</param>
		/// <param name="ActionName">Name der aufzurufenden Funktion</param>
		/// <param name="Parameters">Die Parameter, mit der die Funktion aufgerufen werden soll.</param>
		static public void GenericActionInvoker<T0, T1, T2> (Control Ctrl, Type ClassType, string ActionName, params object [] Parameters) {
			Type[] generic_types, param_types;
			MethodInfo mi;
			GenericActionInvokerDelegate generic_delegate;

			generic_types = new Type [] { typeof (T0), typeof (T1), typeof (T2) };
			param_types = new Type [Parameters.Length];
			for (int i = 0; i < param_types.Length; i++)
				param_types [i] = Parameters [i].GetType ();
			mi = FindMethod (ClassType, ActionName, generic_types, param_types);
			generic_delegate = GenericActionInvokedCall;
			Ctrl.Invoke (generic_delegate, new object [] { Ctrl, mi, Parameters });
		}

		/// <summary>
		/// Führt ein Invoke für ein Steuerelement/Formular auf eine generische(!) Funktion des Steuerelementes / des Formulars durch.
		/// </summary>
		/// <param name="Ctrl">Steuerelement oder Formular für welches der Invoke erfolgen soll.</param>
		/// <param name="ActionName">Name der aufzurufenden Funktion</param>
		/// <param name="Parameters">Die Parameter, mit der die Funktion aufgerufen werden soll.</param>
		/// <returns></returns>	
		static public RV GenericFunctionInvoker<T0, T1, T2, RV> (Control Ctrl, string ActionName, params object [] Parameters) {
			Type[] generic_types, param_types;
			MethodInfo mi;
			GenericFunctionInvokerDelegate<RV> generic_delegate;

			generic_types = new Type [] { typeof (T0), typeof (T1), typeof (T2) };
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
		static public RV GenericFunctionInvoker<T0, T1, T2, RV> (Control Ctrl, Type ClassType, string ActionName, params object [] Parameters) {
			Type[] generic_types, param_types;
			MethodInfo mi;
			GenericFunctionInvokerDelegate<RV> generic_delegate;

			generic_types = new Type [] { typeof (T0), typeof (T1), typeof (T2) };
			param_types = new Type [Parameters.Length];
			for (int i = 0; i < param_types.Length; i++)
				param_types [i] = Parameters [i].GetType ();
			mi = FindMethod (ClassType, ActionName, generic_types, param_types);
			generic_delegate = GenericFunctionInvokedCall<RV>;
			return (RV) Ctrl.Invoke (generic_delegate, new object [] { Ctrl, mi, Parameters });
		}
	}   // class

}	//	namespace	2020-03-27 - 09.52.56