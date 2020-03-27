// 
// Run - © Copyright diub - Dipl.-Ing. Uwe Barth - 2019-04-24
// 
// This part allows you to invoke almost any method/function directly in its own thread.
//

// ActionInvoke / FunctionInvoke: classic Invoke
// GenericActionInvoke / GenericFuncInvoke: Invoke a Generic Function → class.Func<T>(...) 
//
// RunActionInvoke / RunFunktionInvoke: asynchronous Invoke of a function from a newly created thread
// RunGenericActionInvoke / RunGenericFuncInvoke: asynchronous Invoke of a generic function from a newly created thread

using System;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;

namespace diub.Threads {

	/// <summary>
	/// This static class allows you to invoke almost any method/function directly in its own thread.
	/// Supports also invoking static functions. 
	/// </summary>
	static public partial class Invoker {

		// for static functions
		static public void ActionInvoke (Type ClassType, String ActionName) {
			ClassType.GetMethod (ActionName).Invoke (null, null);
		}

		static public void ActionInvoke (Object Instance, String ActionName) {
			Instance.GetType ().GetMethod (ActionName).Invoke (Instance, null);
		}

		static public void ActionInvoke (this Control Ctrl, String ActionName) {
			Ctrl.Invoke (Delegate.CreateDelegate (typeof (Action), Ctrl, ActionName));
		}

		static public Run RunActionInvoke (this Control Ctrl, String ActionName) {
			return new RunAction<Control, String> (ActionInvoke, Ctrl, ActionName);
		}

		// for static functions
		static public RT FuncInvoke<RT> (Type ClassType, String FunctionName) {
			return (RT) ClassType.GetMethod (FunctionName).Invoke (null, null);
		}

		static public RT FuncInvoke<RT> (Object Instance, String ActionName) {
			return (RT) Instance.GetType ().GetMethod (ActionName).Invoke (Instance, null);
		}

		static public RT FuncInvoke<RT> (this Control Ctrl, String FunctionName) {
			return (RT) Ctrl.Invoke (Delegate.CreateDelegate (typeof (Func<RT>), Ctrl, Ctrl.GetType ().GetMethod (FunctionName)));
		}

		static public Run<RT> RunFuncInvoke<RT> (this Control Ctrl, String FunctionName) {
			return (Run<RT>) new RunFunc<Control, String, RT> (FuncInvoke<RT>, Ctrl, FunctionName);
		}

		static public RT GenericFuncInvoke<RT> (this Control Ctrl, String FunctionName) {
			// The following is only theoretically possible, since no unique signature exists without parameter types.
			/*
				MethodInfo mi = Ctrl.GetType ().GetMethod (FunctionName).MakeGenericMethod  ( null);
				return (RT)	mi.Invoke (Ctrl, null);
			*/

			Delegate d;
			MethodInfo mi;

			mi = Ctrl.GetType ().GetMethod (FunctionName);
			mi = mi.MakeGenericMethod (typeof (RT));
			d = Delegate.CreateDelegate (typeof (Func<RT>), Ctrl, mi);
			return (RT) Ctrl.Invoke (d);
		}

		static public Run<RT> RunGenericFuncInvoke<RT> (this Control Ctrl, String FunctionName) {
			return (Run<RT>) new RunFunc<Control, String, RT> (GenericFuncInvoke<RT>, Ctrl, FunctionName);
		}

		//
		// 1 Parameter/s
		//

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public void ActionInvoke<In0> (Type ClassType, String ActionName, In0 Inv0) {
			ClassType.GetMethod (ActionName).Invoke (null, new object [] { Inv0 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public void ActionInvoke<In0> (object Instance, String ActionName, In0 Inv0) {
			Instance.GetType ().GetMethod (ActionName).Invoke (Instance, new object [] { Inv0 });
		}

		/// <summary>
		/// Invoke controls function
		/// </summary>		
		static public void ActionInvoke<In0> (this Control Ctrl, String ActionName, In0 Inv0) {
			Ctrl.Invoke (Delegate.CreateDelegate (typeof (Action<In0>), Ctrl, ActionName), Inv0);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run RunActionInvoke<In0> (this Control Ctrl, String ActionName, In0 Inv0) {
			return new RunAction<Control, String, In0> (ActionInvoke<In0>, Ctrl, ActionName, Inv0);
		}

		/// <summary>
		/// Invoke generic control function
		/// </summary>		
		static public void GenericActionInvoke<In0> (this Control Ctrl, String ActionName, In0 Inv0) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod (typeof(In0));
			mi.Invoke (Ctrl, new object [] { Inv0 });
		}

		/// <summary>
		/// Invoke generic control function asynchronously
		/// </summary>		
		static public Run RunGenericActionInvoke<In0> (this Control Ctrl, String ActionName, In0 Inv0) {
			return new RunAction<Control, String, In0> (GenericActionInvoke<In0>, Ctrl, ActionName, Inv0);
		}

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public RT FuncInvoke<In0, RT> (Type ClassType, String FunctionName, In0 Inv0) {
			return (RT) ClassType.GetMethod (FunctionName).Invoke (null, new object [] { Inv0 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public RT FuncInvoke<In0, RT> (object Instance, String FunctionName, In0 Inv0) {
			return (RT) Instance.GetType ().GetMethod (FunctionName).Invoke (Instance, new object [] { Inv0 });
		}

		/// <summary>
		/// Invoke Controls function
		/// </summary>		
		static public RT FuncInvoke<In0, RT> (this Control Ctrl, String FunctionName, In0 Inv0) {
			return (RT) Ctrl.Invoke (Delegate.CreateDelegate (typeof (Func<In0, RT>), Ctrl, Ctrl.GetType ().GetMethod (FunctionName)), Inv0);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run<RT> RunFuncInvoke<In0, RT> (this Control Ctrl, String FunctionName, In0 Inv0) {
			return (Run<RT>) new RunFunc<Control, String, In0, RT> (FuncInvoke<In0, RT>, Ctrl, FunctionName, Inv0);
		}

		/// <summary>
		/// Invoke generic controls function 
		/// </summary>		
		static public RT GenericFuncInvoke<In0, RT> (this Control Ctrl, String ActionName, In0 Inv0) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0));
			return (RT) mi.Invoke (Ctrl, new object [] { Inv0 });
		}

		/// <summary>
		/// Invoke genric controls function asynchronously
		/// </summary>		
		static public Run<RT> RunGenericFuncInvoke<In0, RT> (this Control Ctrl, String FunctionName, In0 Inv0) {
			return (Run<RT>) new RunFunc<Control, String, In0, RT> (GenericFuncInvoke<In0, RT>, Ctrl, FunctionName, Inv0);
		}

		//
		// 2 Parameter/s
		//

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public void ActionInvoke<In0, In1> (Type ClassType, String ActionName, In0 Inv0, In1 Inv1) {
			ClassType.GetMethod (ActionName).Invoke (null, new object [] { Inv0, Inv1 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public void ActionInvoke<In0, In1> (object Instance, String ActionName, In0 Inv0, In1 Inv1) {
			Instance.GetType ().GetMethod (ActionName).Invoke (Instance, new object [] { Inv0, Inv1 });
		}

		/// <summary>
		/// Invoke controls function
		/// </summary>		
		static public void ActionInvoke<In0, In1> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1) {
			Ctrl.Invoke (Delegate.CreateDelegate (typeof (Action<In0, In1>), Ctrl, ActionName), Inv0, Inv1);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run RunActionInvoke<In0, In1> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1) {
			return new RunAction<Control, String, In0, In1> (ActionInvoke<In0, In1>, Ctrl, ActionName, Inv0, Inv1);
		}

		/// <summary>
		/// Invoke generic control function
		/// </summary>		
		static public void GenericActionInvoke<In0, In1> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0), typeof(In1));
			mi.Invoke (Ctrl, new object [] { Inv0, Inv1 });
		}

		/// <summary>
		/// Invoke generic control function asynchronously
		/// </summary>		
		static public Run RunGenericActionInvoke<In0, In1> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1) {
			return new RunAction<Control, String, In0, In1> (GenericActionInvoke<In0, In1>, Ctrl, ActionName, Inv0, Inv1);
		}

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, RT> (Type ClassType, String FunctionName, In0 Inv0, In1 Inv1) {
			return (RT) ClassType.GetMethod (FunctionName).Invoke (null, new object [] { Inv0, Inv1 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, RT> (object Instance, String FunctionName, In0 Inv0, In1 Inv1) {
			return (RT) Instance.GetType ().GetMethod (FunctionName).Invoke (Instance, new object [] { Inv0, Inv1 });
		}

		/// <summary>
		/// Invoke Controls function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1) {
			return (RT) Ctrl.Invoke (Delegate.CreateDelegate (typeof (Func<In0, In1, RT>), Ctrl, Ctrl.GetType ().GetMethod (FunctionName)), Inv0, Inv1);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run<RT> RunFuncInvoke<In0, In1, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1) {
			return (Run<RT>) new RunFunc<Control, String, In0, In1, RT> (FuncInvoke<In0, In1, RT>, Ctrl, FunctionName, Inv0, Inv1);
		}

		/// <summary>
		/// Invoke generic controls function 
		/// </summary>		
		static public RT GenericFuncInvoke<In0, In1, RT> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0), typeof(In1));
			return (RT) mi.Invoke (Ctrl, new object [] { Inv0, Inv1 });
		}

		/// <summary>
		/// Invoke genric controls function asynchronously
		/// </summary>		
		static public Run<RT> RunGenericFuncInvoke<In0, In1, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1) {
			return (Run<RT>) new RunFunc<Control, String, In0, In1, RT> (GenericFuncInvoke<In0, In1, RT>, Ctrl, FunctionName, Inv0, Inv1);
		}

		//
		// 3 Parameter/s
		//

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2> (Type ClassType, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2) {
			ClassType.GetMethod (ActionName).Invoke (null, new object [] { Inv0, Inv1, Inv2 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2> (object Instance, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2) {
			Instance.GetType ().GetMethod (ActionName).Invoke (Instance, new object [] { Inv0, Inv1, Inv2 });
		}

		/// <summary>
		/// Invoke controls function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2) {
			Ctrl.Invoke (Delegate.CreateDelegate (typeof (Action<In0, In1, In2>), Ctrl, ActionName), Inv0, Inv1, Inv2);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run RunActionInvoke<In0, In1, In2> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2) {
			return new RunAction<Control, String, In0, In1, In2> (ActionInvoke<In0, In1, In2>, Ctrl, ActionName, Inv0, Inv1, Inv2);
		}

		/// <summary>
		/// Invoke generic control function
		/// </summary>		
		static public void GenericActionInvoke<In0, In1, In2> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0), typeof(In1), typeof(In2));
			mi.Invoke (Ctrl, new object [] { Inv0, Inv1, Inv2 });
		}

		/// <summary>
		/// Invoke generic control function asynchronously
		/// </summary>		
		static public Run RunGenericActionInvoke<In0, In1, In2> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2) {
			return new RunAction<Control, String, In0, In1, In2> (GenericActionInvoke<In0, In1, In2>, Ctrl, ActionName, Inv0, Inv1, Inv2);
		}

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, RT> (Type ClassType, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2) {
			return (RT) ClassType.GetMethod (FunctionName).Invoke (null, new object [] { Inv0, Inv1, Inv2 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, RT> (object Instance, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2) {
			return (RT) Instance.GetType ().GetMethod (FunctionName).Invoke (Instance, new object [] { Inv0, Inv1, Inv2 });
		}

		/// <summary>
		/// Invoke Controls function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2) {
			return (RT) Ctrl.Invoke (Delegate.CreateDelegate (typeof (Func<In0, In1, In2, RT>), Ctrl, Ctrl.GetType ().GetMethod (FunctionName)), Inv0, Inv1, Inv2);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run<RT> RunFuncInvoke<In0, In1, In2, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2) {
			return (Run<RT>) new RunFunc<Control, String, In0, In1, In2, RT> (FuncInvoke<In0, In1, In2, RT>, Ctrl, FunctionName, Inv0, Inv1, Inv2);
		}

		/// <summary>
		/// Invoke generic controls function 
		/// </summary>		
		static public RT GenericFuncInvoke<In0, In1, In2, RT> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0), typeof(In1), typeof(In2));
			return (RT) mi.Invoke (Ctrl, new object [] { Inv0, Inv1, Inv2 });
		}

		/// <summary>
		/// Invoke genric controls function asynchronously
		/// </summary>		
		static public Run<RT> RunGenericFuncInvoke<In0, In1, In2, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2) {
			return (Run<RT>) new RunFunc<Control, String, In0, In1, In2, RT> (GenericFuncInvoke<In0, In1, In2, RT>, Ctrl, FunctionName, Inv0, Inv1, Inv2);
		}

		//
		// 4 Parameter/s
		//

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3> (Type ClassType, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			ClassType.GetMethod (ActionName).Invoke (null, new object [] { Inv0, Inv1, Inv2, Inv3 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3> (object Instance, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			Instance.GetType ().GetMethod (ActionName).Invoke (Instance, new object [] { Inv0, Inv1, Inv2, Inv3 });
		}

		/// <summary>
		/// Invoke controls function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			Ctrl.Invoke (Delegate.CreateDelegate (typeof (Action<In0, In1, In2, In3>), Ctrl, ActionName), Inv0, Inv1, Inv2, Inv3);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run RunActionInvoke<In0, In1, In2, In3> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return new RunAction<Control, String, In0, In1, In2, In3> (ActionInvoke<In0, In1, In2, In3>, Ctrl, ActionName, Inv0, Inv1, Inv2, Inv3);
		}

		/// <summary>
		/// Invoke generic control function
		/// </summary>		
		static public void GenericActionInvoke<In0, In1, In2, In3> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0), typeof(In1), typeof(In2), typeof(In3));
			mi.Invoke (Ctrl, new object [] { Inv0, Inv1, Inv2, Inv3 });
		}

		/// <summary>
		/// Invoke generic control function asynchronously
		/// </summary>		
		static public Run RunGenericActionInvoke<In0, In1, In2, In3> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return new RunAction<Control, String, In0, In1, In2, In3> (GenericActionInvoke<In0, In1, In2, In3>, Ctrl, ActionName, Inv0, Inv1, Inv2, Inv3);
		}

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, RT> (Type ClassType, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return (RT) ClassType.GetMethod (FunctionName).Invoke (null, new object [] { Inv0, Inv1, Inv2, Inv3 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, RT> (object Instance, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return (RT) Instance.GetType ().GetMethod (FunctionName).Invoke (Instance, new object [] { Inv0, Inv1, Inv2, Inv3 });
		}

		/// <summary>
		/// Invoke Controls function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return (RT) Ctrl.Invoke (Delegate.CreateDelegate (typeof (Func<In0, In1, In2, In3, RT>), Ctrl, Ctrl.GetType ().GetMethod (FunctionName)), Inv0, Inv1, Inv2, Inv3);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run<RT> RunFuncInvoke<In0, In1, In2, In3, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return (Run<RT>) new RunFunc<Control, String, In0, In1, In2, In3, RT> (FuncInvoke<In0, In1, In2, In3, RT>, Ctrl, FunctionName, Inv0, Inv1, Inv2, Inv3);
		}

		/// <summary>
		/// Invoke generic controls function 
		/// </summary>		
		static public RT GenericFuncInvoke<In0, In1, In2, In3, RT> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0), typeof(In1), typeof(In2), typeof(In3));
			return (RT) mi.Invoke (Ctrl, new object [] { Inv0, Inv1, Inv2, Inv3 });
		}

		/// <summary>
		/// Invoke genric controls function asynchronously
		/// </summary>		
		static public Run<RT> RunGenericFuncInvoke<In0, In1, In2, In3, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return (Run<RT>) new RunFunc<Control, String, In0, In1, In2, In3, RT> (GenericFuncInvoke<In0, In1, In2, In3, RT>, Ctrl, FunctionName, Inv0, Inv1, Inv2, Inv3);
		}

		//
		// 5 Parameter/s
		//

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4> (Type ClassType, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			ClassType.GetMethod (ActionName).Invoke (null, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4> (object Instance, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			Instance.GetType ().GetMethod (ActionName).Invoke (Instance, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4 });
		}

		/// <summary>
		/// Invoke controls function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			Ctrl.Invoke (Delegate.CreateDelegate (typeof (Action<In0, In1, In2, In3, In4>), Ctrl, ActionName), Inv0, Inv1, Inv2, Inv3, Inv4);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run RunActionInvoke<In0, In1, In2, In3, In4> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return new RunAction<Control, String, In0, In1, In2, In3, In4> (ActionInvoke<In0, In1, In2, In3, In4>, Ctrl, ActionName, Inv0, Inv1, Inv2, Inv3, Inv4);
		}

		/// <summary>
		/// Invoke generic control function
		/// </summary>		
		static public void GenericActionInvoke<In0, In1, In2, In3, In4> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0), typeof(In1), typeof(In2), typeof(In3), typeof(In4));
			mi.Invoke (Ctrl, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4 });
		}

		/// <summary>
		/// Invoke generic control function asynchronously
		/// </summary>		
		static public Run RunGenericActionInvoke<In0, In1, In2, In3, In4> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return new RunAction<Control, String, In0, In1, In2, In3, In4> (GenericActionInvoke<In0, In1, In2, In3, In4>, Ctrl, ActionName, Inv0, Inv1, Inv2, Inv3, Inv4);
		}

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, RT> (Type ClassType, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return (RT) ClassType.GetMethod (FunctionName).Invoke (null, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, RT> (object Instance, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return (RT) Instance.GetType ().GetMethod (FunctionName).Invoke (Instance, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4 });
		}

		/// <summary>
		/// Invoke Controls function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return (RT) Ctrl.Invoke (Delegate.CreateDelegate (typeof (Func<In0, In1, In2, In3, In4, RT>), Ctrl, Ctrl.GetType ().GetMethod (FunctionName)), Inv0, Inv1, Inv2, Inv3, Inv4);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run<RT> RunFuncInvoke<In0, In1, In2, In3, In4, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return (Run<RT>) new RunFunc<Control, String, In0, In1, In2, In3, In4, RT> (FuncInvoke<In0, In1, In2, In3, In4, RT>, Ctrl, FunctionName, Inv0, Inv1, Inv2, Inv3, Inv4);
		}

		/// <summary>
		/// Invoke generic controls function 
		/// </summary>		
		static public RT GenericFuncInvoke<In0, In1, In2, In3, In4, RT> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0), typeof(In1), typeof(In2), typeof(In3), typeof(In4));
			return (RT) mi.Invoke (Ctrl, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4 });
		}

		/// <summary>
		/// Invoke genric controls function asynchronously
		/// </summary>		
		static public Run<RT> RunGenericFuncInvoke<In0, In1, In2, In3, In4, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return (Run<RT>) new RunFunc<Control, String, In0, In1, In2, In3, In4, RT> (GenericFuncInvoke<In0, In1, In2, In3, In4, RT>, Ctrl, FunctionName, Inv0, Inv1, Inv2, Inv3, Inv4);
		}

		//
		// 6 Parameter/s
		//

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4, In5> (Type ClassType, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			ClassType.GetMethod (ActionName).Invoke (null, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4, In5> (object Instance, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			Instance.GetType ().GetMethod (ActionName).Invoke (Instance, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5 });
		}

		/// <summary>
		/// Invoke controls function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4, In5> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			Ctrl.Invoke (Delegate.CreateDelegate (typeof (Action<In0, In1, In2, In3, In4, In5>), Ctrl, ActionName), Inv0, Inv1, Inv2, Inv3, Inv4, Inv5);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run RunActionInvoke<In0, In1, In2, In3, In4, In5> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return new RunAction<Control, String, In0, In1, In2, In3, In4, In5> (ActionInvoke<In0, In1, In2, In3, In4, In5>, Ctrl, ActionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5);
		}

		/// <summary>
		/// Invoke generic control function
		/// </summary>		
		static public void GenericActionInvoke<In0, In1, In2, In3, In4, In5> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0), typeof(In1), typeof(In2), typeof(In3), typeof(In4), typeof(In5));
			mi.Invoke (Ctrl, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5 });
		}

		/// <summary>
		/// Invoke generic control function asynchronously
		/// </summary>		
		static public Run RunGenericActionInvoke<In0, In1, In2, In3, In4, In5> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return new RunAction<Control, String, In0, In1, In2, In3, In4, In5> (GenericActionInvoke<In0, In1, In2, In3, In4, In5>, Ctrl, ActionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5);
		}

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, In5, RT> (Type ClassType, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return (RT) ClassType.GetMethod (FunctionName).Invoke (null, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, In5, RT> (object Instance, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return (RT) Instance.GetType ().GetMethod (FunctionName).Invoke (Instance, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5 });
		}

		/// <summary>
		/// Invoke Controls function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, In5, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return (RT) Ctrl.Invoke (Delegate.CreateDelegate (typeof (Func<In0, In1, In2, In3, In4, In5, RT>), Ctrl, Ctrl.GetType ().GetMethod (FunctionName)), Inv0, Inv1, Inv2, Inv3, Inv4, Inv5);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run<RT> RunFuncInvoke<In0, In1, In2, In3, In4, In5, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return (Run<RT>) new RunFunc<Control, String, In0, In1, In2, In3, In4, In5, RT> (FuncInvoke<In0, In1, In2, In3, In4, In5, RT>, Ctrl, FunctionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5);
		}

		/// <summary>
		/// Invoke generic controls function 
		/// </summary>		
		static public RT GenericFuncInvoke<In0, In1, In2, In3, In4, In5, RT> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0), typeof(In1), typeof(In2), typeof(In3), typeof(In4), typeof(In5));
			return (RT) mi.Invoke (Ctrl, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5 });
		}

		/// <summary>
		/// Invoke genric controls function asynchronously
		/// </summary>		
		static public Run<RT> RunGenericFuncInvoke<In0, In1, In2, In3, In4, In5, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return (Run<RT>) new RunFunc<Control, String, In0, In1, In2, In3, In4, In5, RT> (GenericFuncInvoke<In0, In1, In2, In3, In4, In5, RT>, Ctrl, FunctionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5);
		}

		//
		// 7 Parameter/s
		//

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4, In5, In6> (Type ClassType, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			ClassType.GetMethod (ActionName).Invoke (null, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4, In5, In6> (object Instance, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			Instance.GetType ().GetMethod (ActionName).Invoke (Instance, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6 });
		}

		/// <summary>
		/// Invoke controls function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4, In5, In6> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			Ctrl.Invoke (Delegate.CreateDelegate (typeof (Action<In0, In1, In2, In3, In4, In5, In6>), Ctrl, ActionName), Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run RunActionInvoke<In0, In1, In2, In3, In4, In5, In6> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return new RunAction<Control, String, In0, In1, In2, In3, In4, In5, In6> (ActionInvoke<In0, In1, In2, In3, In4, In5, In6>, Ctrl, ActionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6);
		}

		/// <summary>
		/// Invoke generic control function
		/// </summary>		
		static public void GenericActionInvoke<In0, In1, In2, In3, In4, In5, In6> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0), typeof(In1), typeof(In2), typeof(In3), typeof(In4), typeof(In5), typeof(In6));
			mi.Invoke (Ctrl, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6 });
		}

		/// <summary>
		/// Invoke generic control function asynchronously
		/// </summary>		
		static public Run RunGenericActionInvoke<In0, In1, In2, In3, In4, In5, In6> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return new RunAction<Control, String, In0, In1, In2, In3, In4, In5, In6> (GenericActionInvoke<In0, In1, In2, In3, In4, In5, In6>, Ctrl, ActionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6);
		}

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, In5, In6, RT> (Type ClassType, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return (RT) ClassType.GetMethod (FunctionName).Invoke (null, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, In5, In6, RT> (object Instance, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return (RT) Instance.GetType ().GetMethod (FunctionName).Invoke (Instance, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6 });
		}

		/// <summary>
		/// Invoke Controls function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, In5, In6, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return (RT) Ctrl.Invoke (Delegate.CreateDelegate (typeof (Func<In0, In1, In2, In3, In4, In5, In6, RT>), Ctrl, Ctrl.GetType ().GetMethod (FunctionName)), Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run<RT> RunFuncInvoke<In0, In1, In2, In3, In4, In5, In6, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return (Run<RT>) new RunFunc<Control, String, In0, In1, In2, In3, In4, In5, In6, RT> (FuncInvoke<In0, In1, In2, In3, In4, In5, In6, RT>, Ctrl, FunctionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6);
		}

		/// <summary>
		/// Invoke generic controls function 
		/// </summary>		
		static public RT GenericFuncInvoke<In0, In1, In2, In3, In4, In5, In6, RT> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0), typeof(In1), typeof(In2), typeof(In3), typeof(In4), typeof(In5), typeof(In6));
			return (RT) mi.Invoke (Ctrl, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6 });
		}

		/// <summary>
		/// Invoke genric controls function asynchronously
		/// </summary>		
		static public Run<RT> RunGenericFuncInvoke<In0, In1, In2, In3, In4, In5, In6, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return (Run<RT>) new RunFunc<Control, String, In0, In1, In2, In3, In4, In5, In6, RT> (GenericFuncInvoke<In0, In1, In2, In3, In4, In5, In6, RT>, Ctrl, FunctionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6);
		}

		//
		// 8 Parameter/s
		//

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7> (Type ClassType, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			ClassType.GetMethod (ActionName).Invoke (null, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7> (object Instance, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			Instance.GetType ().GetMethod (ActionName).Invoke (Instance, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7 });
		}

		/// <summary>
		/// Invoke controls function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			Ctrl.Invoke (Delegate.CreateDelegate (typeof (Action<In0, In1, In2, In3, In4, In5, In6, In7>), Ctrl, ActionName), Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run RunActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return new RunAction<Control, String, In0, In1, In2, In3, In4, In5, In6, In7> (ActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7>, Ctrl, ActionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7);
		}

		/// <summary>
		/// Invoke generic control function
		/// </summary>		
		static public void GenericActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0), typeof(In1), typeof(In2), typeof(In3), typeof(In4), typeof(In5), typeof(In6), typeof(In7));
			mi.Invoke (Ctrl, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7 });
		}

		/// <summary>
		/// Invoke generic control function asynchronously
		/// </summary>		
		static public Run RunGenericActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return new RunAction<Control, String, In0, In1, In2, In3, In4, In5, In6, In7> (GenericActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7>, Ctrl, ActionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7);
		}

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, RT> (Type ClassType, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return (RT) ClassType.GetMethod (FunctionName).Invoke (null, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, RT> (object Instance, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return (RT) Instance.GetType ().GetMethod (FunctionName).Invoke (Instance, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7 });
		}

		/// <summary>
		/// Invoke Controls function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return (RT) Ctrl.Invoke (Delegate.CreateDelegate (typeof (Func<In0, In1, In2, In3, In4, In5, In6, In7, RT>), Ctrl, Ctrl.GetType ().GetMethod (FunctionName)), Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run<RT> RunFuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return (Run<RT>) new RunFunc<Control, String, In0, In1, In2, In3, In4, In5, In6, In7, RT> (FuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, RT>, Ctrl, FunctionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7);
		}

		/// <summary>
		/// Invoke generic controls function 
		/// </summary>		
		static public RT GenericFuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, RT> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0), typeof(In1), typeof(In2), typeof(In3), typeof(In4), typeof(In5), typeof(In6), typeof(In7));
			return (RT) mi.Invoke (Ctrl, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7 });
		}

		/// <summary>
		/// Invoke genric controls function asynchronously
		/// </summary>		
		static public Run<RT> RunGenericFuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return (Run<RT>) new RunFunc<Control, String, In0, In1, In2, In3, In4, In5, In6, In7, RT> (GenericFuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, RT>, Ctrl, FunctionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7);
		}

		//
		// 9 Parameter/s
		//

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8> (Type ClassType, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			ClassType.GetMethod (ActionName).Invoke (null, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8> (object Instance, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			Instance.GetType ().GetMethod (ActionName).Invoke (Instance, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8 });
		}

		/// <summary>
		/// Invoke controls function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			Ctrl.Invoke (Delegate.CreateDelegate (typeof (Action<In0, In1, In2, In3, In4, In5, In6, In7, In8>), Ctrl, ActionName), Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run RunActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return new RunAction<Control, String, In0, In1, In2, In3, In4, In5, In6, In7, In8> (ActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8>, Ctrl, ActionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8);
		}

		/// <summary>
		/// Invoke generic control function
		/// </summary>		
		static public void GenericActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0), typeof(In1), typeof(In2), typeof(In3), typeof(In4), typeof(In5), typeof(In6), typeof(In7), typeof(In8));
			mi.Invoke (Ctrl, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8 });
		}

		/// <summary>
		/// Invoke generic control function asynchronously
		/// </summary>		
		static public Run RunGenericActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return new RunAction<Control, String, In0, In1, In2, In3, In4, In5, In6, In7, In8> (GenericActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8>, Ctrl, ActionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8);
		}

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, RT> (Type ClassType, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return (RT) ClassType.GetMethod (FunctionName).Invoke (null, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, RT> (object Instance, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return (RT) Instance.GetType ().GetMethod (FunctionName).Invoke (Instance, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8 });
		}

		/// <summary>
		/// Invoke Controls function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return (RT) Ctrl.Invoke (Delegate.CreateDelegate (typeof (Func<In0, In1, In2, In3, In4, In5, In6, In7, In8, RT>), Ctrl, Ctrl.GetType ().GetMethod (FunctionName)), Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run<RT> RunFuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return (Run<RT>) new RunFunc<Control, String, In0, In1, In2, In3, In4, In5, In6, In7, In8, RT> (FuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, RT>, Ctrl, FunctionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8);
		}

		/// <summary>
		/// Invoke generic controls function 
		/// </summary>		
		static public RT GenericFuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, RT> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0), typeof(In1), typeof(In2), typeof(In3), typeof(In4), typeof(In5), typeof(In6), typeof(In7), typeof(In8));
			return (RT) mi.Invoke (Ctrl, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8 });
		}

		/// <summary>
		/// Invoke genric controls function asynchronously
		/// </summary>		
		static public Run<RT> RunGenericFuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return (Run<RT>) new RunFunc<Control, String, In0, In1, In2, In3, In4, In5, In6, In7, In8, RT> (GenericFuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, RT>, Ctrl, FunctionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8);
		}

		//
		// 10 Parameter/s
		//

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9> (Type ClassType, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			ClassType.GetMethod (ActionName).Invoke (null, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9> (object Instance, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			Instance.GetType ().GetMethod (ActionName).Invoke (Instance, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9 });
		}

		/// <summary>
		/// Invoke controls function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			Ctrl.Invoke (Delegate.CreateDelegate (typeof (Action<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9>), Ctrl, ActionName), Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run RunActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return new RunAction<Control, String, In0, In1, In2, In3, In4, In5, In6, In7, In8, In9> (ActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9>, Ctrl, ActionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9);
		}

		/// <summary>
		/// Invoke generic control function
		/// </summary>		
		static public void GenericActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0), typeof(In1), typeof(In2), typeof(In3), typeof(In4), typeof(In5), typeof(In6), typeof(In7), typeof(In8), typeof(In9));
			mi.Invoke (Ctrl, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9 });
		}

		/// <summary>
		/// Invoke generic control function asynchronously
		/// </summary>		
		static public Run RunGenericActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return new RunAction<Control, String, In0, In1, In2, In3, In4, In5, In6, In7, In8, In9> (GenericActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9>, Ctrl, ActionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9);
		}

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, RT> (Type ClassType, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return (RT) ClassType.GetMethod (FunctionName).Invoke (null, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, RT> (object Instance, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return (RT) Instance.GetType ().GetMethod (FunctionName).Invoke (Instance, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9 });
		}

		/// <summary>
		/// Invoke Controls function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return (RT) Ctrl.Invoke (Delegate.CreateDelegate (typeof (Func<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, RT>), Ctrl, Ctrl.GetType ().GetMethod (FunctionName)), Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run<RT> RunFuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return (Run<RT>) new RunFunc<Control, String, In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, RT> (FuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, RT>, Ctrl, FunctionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9);
		}

		/// <summary>
		/// Invoke generic controls function 
		/// </summary>		
		static public RT GenericFuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, RT> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0), typeof(In1), typeof(In2), typeof(In3), typeof(In4), typeof(In5), typeof(In6), typeof(In7), typeof(In8), typeof(In9));
			return (RT) mi.Invoke (Ctrl, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9 });
		}

		/// <summary>
		/// Invoke genric controls function asynchronously
		/// </summary>		
		static public Run<RT> RunGenericFuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return (Run<RT>) new RunFunc<Control, String, In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, RT> (GenericFuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, RT>, Ctrl, FunctionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9);
		}

		//
		// 11 Parameter/s
		//

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10> (Type ClassType, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			ClassType.GetMethod (ActionName).Invoke (null, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10> (object Instance, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			Instance.GetType ().GetMethod (ActionName).Invoke (Instance, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10 });
		}

		/// <summary>
		/// Invoke controls function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			Ctrl.Invoke (Delegate.CreateDelegate (typeof (Action<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10>), Ctrl, ActionName), Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run RunActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return new RunAction<Control, String, In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10> (ActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10>, Ctrl, ActionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10);
		}

		/// <summary>
		/// Invoke generic control function
		/// </summary>		
		static public void GenericActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0), typeof(In1), typeof(In2), typeof(In3), typeof(In4), typeof(In5), typeof(In6), typeof(In7), typeof(In8), typeof(In9), typeof(In10));
			mi.Invoke (Ctrl, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10 });
		}

		/// <summary>
		/// Invoke generic control function asynchronously
		/// </summary>		
		static public Run RunGenericActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return new RunAction<Control, String, In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10> (GenericActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10>, Ctrl, ActionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10);
		}

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, RT> (Type ClassType, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return (RT) ClassType.GetMethod (FunctionName).Invoke (null, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, RT> (object Instance, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return (RT) Instance.GetType ().GetMethod (FunctionName).Invoke (Instance, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10 });
		}

		/// <summary>
		/// Invoke Controls function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return (RT) Ctrl.Invoke (Delegate.CreateDelegate (typeof (Func<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, RT>), Ctrl, Ctrl.GetType ().GetMethod (FunctionName)), Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run<RT> RunFuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return (Run<RT>) new RunFunc<Control, String, In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, RT> (FuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, RT>, Ctrl, FunctionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10);
		}

		/// <summary>
		/// Invoke generic controls function 
		/// </summary>		
		static public RT GenericFuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, RT> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0), typeof(In1), typeof(In2), typeof(In3), typeof(In4), typeof(In5), typeof(In6), typeof(In7), typeof(In8), typeof(In9), typeof(In10));
			return (RT) mi.Invoke (Ctrl, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10 });
		}

		/// <summary>
		/// Invoke genric controls function asynchronously
		/// </summary>		
		static public Run<RT> RunGenericFuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return (Run<RT>) new RunFunc<Control, String, In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, RT> (GenericFuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, RT>, Ctrl, FunctionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10);
		}

		//
		// 12 Parameter/s
		//

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11> (Type ClassType, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			ClassType.GetMethod (ActionName).Invoke (null, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10, Inv11 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11> (object Instance, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			Instance.GetType ().GetMethod (ActionName).Invoke (Instance, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10, Inv11 });
		}

		/// <summary>
		/// Invoke controls function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			Ctrl.Invoke (Delegate.CreateDelegate (typeof (Action<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11>), Ctrl, ActionName), Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10, Inv11);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run RunActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return new RunAction<Control, String, In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11> (ActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11>, Ctrl, ActionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10, Inv11);
		}

		/// <summary>
		/// Invoke generic control function
		/// </summary>		
		static public void GenericActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0), typeof(In1), typeof(In2), typeof(In3), typeof(In4), typeof(In5), typeof(In6), typeof(In7), typeof(In8), typeof(In9), typeof(In10), typeof(In11));
			mi.Invoke (Ctrl, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10, Inv11 });
		}

		/// <summary>
		/// Invoke generic control function asynchronously
		/// </summary>		
		static public Run RunGenericActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return new RunAction<Control, String, In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11> (GenericActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11>, Ctrl, ActionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10, Inv11);
		}

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, RT> (Type ClassType, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return (RT) ClassType.GetMethod (FunctionName).Invoke (null, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10, Inv11 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, RT> (object Instance, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return (RT) Instance.GetType ().GetMethod (FunctionName).Invoke (Instance, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10, Inv11 });
		}

		/// <summary>
		/// Invoke Controls function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return (RT) Ctrl.Invoke (Delegate.CreateDelegate (typeof (Func<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, RT>), Ctrl, Ctrl.GetType ().GetMethod (FunctionName)), Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10, Inv11);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run<RT> RunFuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return (Run<RT>) new RunFunc<Control, String, In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, RT> (FuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, RT>, Ctrl, FunctionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10, Inv11);
		}

		/// <summary>
		/// Invoke generic controls function 
		/// </summary>		
		static public RT GenericFuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, RT> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0), typeof(In1), typeof(In2), typeof(In3), typeof(In4), typeof(In5), typeof(In6), typeof(In7), typeof(In8), typeof(In9), typeof(In10), typeof(In11));
			return (RT) mi.Invoke (Ctrl, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10, Inv11 });
		}

		/// <summary>
		/// Invoke genric controls function asynchronously
		/// </summary>		
		static public Run<RT> RunGenericFuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return (Run<RT>) new RunFunc<Control, String, In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, RT> (GenericFuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, RT>, Ctrl, FunctionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10, Inv11);
		}

		//
		// 13 Parameter/s
		//

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, In12> (Type ClassType, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			ClassType.GetMethod (ActionName).Invoke (null, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10, Inv11, Inv12 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, In12> (object Instance, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			Instance.GetType ().GetMethod (ActionName).Invoke (Instance, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10, Inv11, Inv12 });
		}

		/// <summary>
		/// Invoke controls function
		/// </summary>		
		static public void ActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, In12> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			Ctrl.Invoke (Delegate.CreateDelegate (typeof (Action<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, In12>), Ctrl, ActionName), Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10, Inv11, Inv12);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run RunActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, In12> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return new RunAction<Control, String, In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, In12> (ActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, In12>, Ctrl, ActionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10, Inv11, Inv12);
		}

		/// <summary>
		/// Invoke generic control function
		/// </summary>		
		static public void GenericActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, In12> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0), typeof(In1), typeof(In2), typeof(In3), typeof(In4), typeof(In5), typeof(In6), typeof(In7), typeof(In8), typeof(In9), typeof(In10), typeof(In11), typeof(In12));
			mi.Invoke (Ctrl, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10, Inv11, Inv12 });
		}

		/// <summary>
		/// Invoke generic control function asynchronously
		/// </summary>		
		static public Run RunGenericActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, In12> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return new RunAction<Control, String, In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, In12> (GenericActionInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, In12>, Ctrl, ActionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10, Inv11, Inv12);
		}

		/// <summary>
		/// Invoke static function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, In12, RT> (Type ClassType, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return (RT) ClassType.GetMethod (FunctionName).Invoke (null, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10, Inv11, Inv12 });
		}

		/// <summary>
		/// Invoke instance function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, In12, RT> (object Instance, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return (RT) Instance.GetType ().GetMethod (FunctionName).Invoke (Instance, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10, Inv11, Inv12 });
		}

		/// <summary>
		/// Invoke Controls function
		/// </summary>		
		static public RT FuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, In12, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return (RT) Ctrl.Invoke (Delegate.CreateDelegate (typeof (Func<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, In12, RT>), Ctrl, Ctrl.GetType ().GetMethod (FunctionName)), Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10, Inv11, Inv12);
		}

		/// <summary>
		/// Invoke controls function asynchronously
		/// </summary>		
		static public Run<RT> RunFuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, In12, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return (Run<RT>) new RunFunc<Control, String, In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, In12, RT> (FuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, In12, RT>, Ctrl, FunctionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10, Inv11, Inv12);
		}

		/// <summary>
		/// Invoke generic controls function 
		/// </summary>		
		static public RT GenericFuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, In12, RT> (this Control Ctrl, String ActionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			MethodInfo mi = Ctrl.GetType ().GetMethod (ActionName).MakeGenericMethod  ( typeof(In0), typeof(In1), typeof(In2), typeof(In3), typeof(In4), typeof(In5), typeof(In6), typeof(In7), typeof(In8), typeof(In9), typeof(In10), typeof(In11), typeof(In12));
			return (RT) mi.Invoke (Ctrl, new object [] { Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10, Inv11, Inv12 });
		}

		/// <summary>
		/// Invoke genric controls function asynchronously
		/// </summary>		
		static public Run<RT> RunGenericFuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, In12, RT> (this Control Ctrl, String FunctionName, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return (Run<RT>) new RunFunc<Control, String, In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, In12, RT> (GenericFuncInvoke<In0, In1, In2, In3, In4, In5, In6, In7, In8, In9, In10, In11, In12, RT>, Ctrl, FunctionName, Inv0, Inv1, Inv2, Inv3, Inv4, Inv5, Inv6, Inv7, Inv8, Inv9, Inv10, Inv11, Inv12);
		}


	}   // class

}   //	namespace	2019-04-24 - 13.36.14
