// 
// Run - © Copyright diub - Dipl.-Ing. Uwe Barth - 2019-03-03
// 
// Allows you to start almost any function directly in its own thread and retrieve the result synchronized later.
//
using System;
using System.Threading;

namespace diub.Threads {

/// <summary>
/// Erlaubt es nahezu beliebige Funktionen direkt in einem eigenen Thread zu starten und das Ergebnis später
/// synchronisiert abzurufen.
/// </summary>

	/// <summary>
	/// Synchronization Object for Action.
	/// </summary>	
	public class Run {
		protected Thread thread;
		protected bool completed = false;

		public void Wait (){
			if (!completed) {
				if (thread == null)
					throw new Exception ("Thread is not created (null)!");
				if(	thread.ThreadState == ThreadState.Unstarted)
					throw new Exception ("Thread is not runned!");
				try {
					thread.Join ();
				} catch (Exception) {}
				completed = true;
			}
		}
	}	//	Run


	/// <summary>
	/// Synchronization Object for Func and getting the result.
	/// </summary>	
	public class Run<RT> : Run {
		protected RT return_value;

		public RT Result {
			get {
				Wait ();
				return return_value;
			}
		}
	}	//	Run

	// Action; syntactic special case, since no parameter
	public class RunAction : Run {		
		readonly private Action action;

		public RunAction (Action Action) {
			action = Action;
			(thread = new Thread (DoIt)).Start ();
		}

		private void DoIt () {
			action ();
		}
	}   // Action

	// Function; syntactic special case, since no parameter
	public class RunFunc<RT> : Run<RT>  {		
		readonly private Func<RT> function;

		public RunFunc (Func<RT> Function) {
			function = Function;
			(thread = new Thread (DoIt)).Start ();
		}

		private void DoIt () {
			return_value = function ();
		}
	}   // Function

	// Action with 1 parameter(s)
	public class RunAction<In0> : Run {
		readonly private Action<In0> action;
		readonly In0 inv0;
	
		public RunAction (Action<In0> Action , In0 Inv0) {
			action = Action;
			inv0 = Inv0;
			(thread = new Thread (DoIt)).Start();
		}
		
		public void DoIt () {
			action (inv0);
		}
	}	// Action

	// Function with 1 parameter(s)
	public class RunFunc<In0,RT> : Run<RT> {
		readonly private Func<In0,RT> function;
		readonly In0 inv0;
	
		public RunFunc (Func<In0,RT> Function, In0 Inv0) {
			function = Function;
			inv0 = Inv0;
			(thread = new Thread (DoIt)).Start();
		}
		
		private void DoIt () {
			return_value = function (inv0);
		}
	}	// Function 
	
	// Action with 2 parameter(s)
	public class RunAction<In0,In1> : Run {
		readonly private Action<In0,In1> action;
		readonly In0 inv0;
		readonly In1 inv1;
	
		public RunAction (Action<In0,In1> Action , In0 Inv0, In1 Inv1) {
			action = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			(thread = new Thread (DoIt)).Start();
		}
		
		public void DoIt () {
			action (inv0,inv1);
		}
	}	// Action

	// Function with 2 parameter(s)
	public class RunFunc<In0,In1,RT> : Run<RT> {
		readonly private Func<In0,In1,RT> function;
		readonly In0 inv0;
		readonly In1 inv1;
	
		public RunFunc (Func<In0,In1,RT> Function, In0 Inv0, In1 Inv1) {
			function = Function;
			inv0 = Inv0;
			inv1 = Inv1;
			(thread = new Thread (DoIt)).Start();
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1);
		}
	}	// Function 
	
	// Action with 3 parameter(s)
	public class RunAction<In0,In1,In2> : Run {
		readonly private Action<In0,In1,In2> action;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
	
		public RunAction (Action<In0,In1,In2> Action , In0 Inv0, In1 Inv1, In2 Inv2) {
			action = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			(thread = new Thread (DoIt)).Start();
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2);
		}
	}	// Action

	// Function with 3 parameter(s)
	public class RunFunc<In0,In1,In2,RT> : Run<RT> {
		readonly private Func<In0,In1,In2,RT> function;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
	
		public RunFunc (Func<In0,In1,In2,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			function = Function;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			(thread = new Thread (DoIt)).Start();
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2);
		}
	}	// Function 
	
	// Action with 4 parameter(s)
	public class RunAction<In0,In1,In2,In3> : Run {
		readonly private Action<In0,In1,In2,In3> action;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
	
		public RunAction (Action<In0,In1,In2,In3> Action , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			action = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			(thread = new Thread (DoIt)).Start();
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2,inv3);
		}
	}	// Action

	// Function with 4 parameter(s)
	public class RunFunc<In0,In1,In2,In3,RT> : Run<RT> {
		readonly private Func<In0,In1,In2,In3,RT> function;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
	
		public RunFunc (Func<In0,In1,In2,In3,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			function = Function;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			(thread = new Thread (DoIt)).Start();
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3);
		}
	}	// Function 
	
	// Action with 5 parameter(s)
	public class RunAction<In0,In1,In2,In3,In4> : Run {
		readonly private Action<In0,In1,In2,In3,In4> action;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
		readonly In4 inv4;
	
		public RunAction (Action<In0,In1,In2,In3,In4> Action , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			action = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			(thread = new Thread (DoIt)).Start();
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2,inv3,inv4);
		}
	}	// Action

	// Function with 5 parameter(s)
	public class RunFunc<In0,In1,In2,In3,In4,RT> : Run<RT> {
		readonly private Func<In0,In1,In2,In3,In4,RT> function;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
		readonly In4 inv4;
	
		public RunFunc (Func<In0,In1,In2,In3,In4,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			function = Function;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			(thread = new Thread (DoIt)).Start();
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4);
		}
	}	// Function 
	
	// Action with 6 parameter(s)
	public class RunAction<In0,In1,In2,In3,In4,In5> : Run {
		readonly private Action<In0,In1,In2,In3,In4,In5> action;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
		readonly In4 inv4;
		readonly In5 inv5;
	
		public RunAction (Action<In0,In1,In2,In3,In4,In5> Action , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			action = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			(thread = new Thread (DoIt)).Start();
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2,inv3,inv4,inv5);
		}
	}	// Action

	// Function with 6 parameter(s)
	public class RunFunc<In0,In1,In2,In3,In4,In5,RT> : Run<RT> {
		readonly private Func<In0,In1,In2,In3,In4,In5,RT> function;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
		readonly In4 inv4;
		readonly In5 inv5;
	
		public RunFunc (Func<In0,In1,In2,In3,In4,In5,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			function = Function;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			(thread = new Thread (DoIt)).Start();
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5);
		}
	}	// Function 
	
	// Action with 7 parameter(s)
	public class RunAction<In0,In1,In2,In3,In4,In5,In6> : Run {
		readonly private Action<In0,In1,In2,In3,In4,In5,In6> action;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
		readonly In4 inv4;
		readonly In5 inv5;
		readonly In6 inv6;
	
		public RunAction (Action<In0,In1,In2,In3,In4,In5,In6> Action , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			action = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			(thread = new Thread (DoIt)).Start();
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2,inv3,inv4,inv5,inv6);
		}
	}	// Action

	// Function with 7 parameter(s)
	public class RunFunc<In0,In1,In2,In3,In4,In5,In6,RT> : Run<RT> {
		readonly private Func<In0,In1,In2,In3,In4,In5,In6,RT> function;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
		readonly In4 inv4;
		readonly In5 inv5;
		readonly In6 inv6;
	
		public RunFunc (Func<In0,In1,In2,In3,In4,In5,In6,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			function = Function;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			(thread = new Thread (DoIt)).Start();
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6);
		}
	}	// Function 
	
	// Action with 8 parameter(s)
	public class RunAction<In0,In1,In2,In3,In4,In5,In6,In7> : Run {
		readonly private Action<In0,In1,In2,In3,In4,In5,In6,In7> action;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
		readonly In4 inv4;
		readonly In5 inv5;
		readonly In6 inv6;
		readonly In7 inv7;
	
		public RunAction (Action<In0,In1,In2,In3,In4,In5,In6,In7> Action , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			action = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			(thread = new Thread (DoIt)).Start();
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7);
		}
	}	// Action

	// Function with 8 parameter(s)
	public class RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,RT> : Run<RT> {
		readonly private Func<In0,In1,In2,In3,In4,In5,In6,In7,RT> function;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
		readonly In4 inv4;
		readonly In5 inv5;
		readonly In6 inv6;
		readonly In7 inv7;
	
		public RunFunc (Func<In0,In1,In2,In3,In4,In5,In6,In7,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			function = Function;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			(thread = new Thread (DoIt)).Start();
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7);
		}
	}	// Function 
	
	// Action with 9 parameter(s)
	public class RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8> : Run {
		readonly private Action<In0,In1,In2,In3,In4,In5,In6,In7,In8> action;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
		readonly In4 inv4;
		readonly In5 inv5;
		readonly In6 inv6;
		readonly In7 inv7;
		readonly In8 inv8;
	
		public RunAction (Action<In0,In1,In2,In3,In4,In5,In6,In7,In8> Action , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			action = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			(thread = new Thread (DoIt)).Start();
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8);
		}
	}	// Action

	// Function with 9 parameter(s)
	public class RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,RT> : Run<RT> {
		readonly private Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,RT> function;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
		readonly In4 inv4;
		readonly In5 inv5;
		readonly In6 inv6;
		readonly In7 inv7;
		readonly In8 inv8;
	
		public RunFunc (Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			function = Function;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			(thread = new Thread (DoIt)).Start();
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8);
		}
	}	// Function 
	
	// Action with 10 parameter(s)
	public class RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9> : Run {
		readonly private Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9> action;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
		readonly In4 inv4;
		readonly In5 inv5;
		readonly In6 inv6;
		readonly In7 inv7;
		readonly In8 inv8;
		readonly In9 inv9;
	
		public RunAction (Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9> Action , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			action = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			inv9 = Inv9;
			(thread = new Thread (DoIt)).Start();
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9);
		}
	}	// Action

	// Function with 10 parameter(s)
	public class RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,RT> : Run<RT> {
		readonly private Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,RT> function;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
		readonly In4 inv4;
		readonly In5 inv5;
		readonly In6 inv6;
		readonly In7 inv7;
		readonly In8 inv8;
		readonly In9 inv9;
	
		public RunFunc (Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			function = Function;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			inv9 = Inv9;
			(thread = new Thread (DoIt)).Start();
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9);
		}
	}	// Function 
	
	// Action with 11 parameter(s)
	public class RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10> : Run {
		readonly private Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10> action;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
		readonly In4 inv4;
		readonly In5 inv5;
		readonly In6 inv6;
		readonly In7 inv7;
		readonly In8 inv8;
		readonly In9 inv9;
		readonly In10 inv10;
	
		public RunAction (Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10> Action , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			action = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			inv9 = Inv9;
			inv10 = Inv10;
			(thread = new Thread (DoIt)).Start();
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10);
		}
	}	// Action

	// Function with 11 parameter(s)
	public class RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,RT> : Run<RT> {
		readonly private Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,RT> function;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
		readonly In4 inv4;
		readonly In5 inv5;
		readonly In6 inv6;
		readonly In7 inv7;
		readonly In8 inv8;
		readonly In9 inv9;
		readonly In10 inv10;
	
		public RunFunc (Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			function = Function;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			inv9 = Inv9;
			inv10 = Inv10;
			(thread = new Thread (DoIt)).Start();
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10);
		}
	}	// Function 
	
	// Action with 12 parameter(s)
	public class RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11> : Run {
		readonly private Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11> action;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
		readonly In4 inv4;
		readonly In5 inv5;
		readonly In6 inv6;
		readonly In7 inv7;
		readonly In8 inv8;
		readonly In9 inv9;
		readonly In10 inv10;
		readonly In11 inv11;
	
		public RunAction (Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11> Action , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			action = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			inv9 = Inv9;
			inv10 = Inv10;
			inv11 = Inv11;
			(thread = new Thread (DoIt)).Start();
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11);
		}
	}	// Action

	// Function with 12 parameter(s)
	public class RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,RT> : Run<RT> {
		readonly private Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,RT> function;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
		readonly In4 inv4;
		readonly In5 inv5;
		readonly In6 inv6;
		readonly In7 inv7;
		readonly In8 inv8;
		readonly In9 inv9;
		readonly In10 inv10;
		readonly In11 inv11;
	
		public RunFunc (Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			function = Function;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			inv9 = Inv9;
			inv10 = Inv10;
			inv11 = Inv11;
			(thread = new Thread (DoIt)).Start();
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11);
		}
	}	// Function 
	
	// Action with 13 parameter(s)
	public class RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12> : Run {
		readonly private Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12> action;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
		readonly In4 inv4;
		readonly In5 inv5;
		readonly In6 inv6;
		readonly In7 inv7;
		readonly In8 inv8;
		readonly In9 inv9;
		readonly In10 inv10;
		readonly In11 inv11;
		readonly In12 inv12;
	
		public RunAction (Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12> Action , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			action = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			inv9 = Inv9;
			inv10 = Inv10;
			inv11 = Inv11;
			inv12 = Inv12;
			(thread = new Thread (DoIt)).Start();
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12);
		}
	}	// Action

	// Function with 13 parameter(s)
	public class RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,RT> : Run<RT> {
		readonly private Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,RT> function;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
		readonly In4 inv4;
		readonly In5 inv5;
		readonly In6 inv6;
		readonly In7 inv7;
		readonly In8 inv8;
		readonly In9 inv9;
		readonly In10 inv10;
		readonly In11 inv11;
		readonly In12 inv12;
	
		public RunFunc (Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			function = Function;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			inv9 = Inv9;
			inv10 = Inv10;
			inv11 = Inv11;
			inv12 = Inv12;
			(thread = new Thread (DoIt)).Start();
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12);
		}
	}	// Function 
	
	// Action with 14 parameter(s)
	public class RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13> : Run {
		readonly private Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13> action;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
		readonly In4 inv4;
		readonly In5 inv5;
		readonly In6 inv6;
		readonly In7 inv7;
		readonly In8 inv8;
		readonly In9 inv9;
		readonly In10 inv10;
		readonly In11 inv11;
		readonly In12 inv12;
		readonly In13 inv13;
	
		public RunAction (Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13> Action , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			action = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			inv9 = Inv9;
			inv10 = Inv10;
			inv11 = Inv11;
			inv12 = Inv12;
			inv13 = Inv13;
			(thread = new Thread (DoIt)).Start();
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13);
		}
	}	// Action

	// Function with 14 parameter(s)
	public class RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,RT> : Run<RT> {
		readonly private Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,RT> function;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
		readonly In4 inv4;
		readonly In5 inv5;
		readonly In6 inv6;
		readonly In7 inv7;
		readonly In8 inv8;
		readonly In9 inv9;
		readonly In10 inv10;
		readonly In11 inv11;
		readonly In12 inv12;
		readonly In13 inv13;
	
		public RunFunc (Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			function = Function;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			inv9 = Inv9;
			inv10 = Inv10;
			inv11 = Inv11;
			inv12 = Inv12;
			inv13 = Inv13;
			(thread = new Thread (DoIt)).Start();
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13);
		}
	}	// Function 
	
	// Action with 15 parameter(s)
	public class RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14> : Run {
		readonly private Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14> action;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
		readonly In4 inv4;
		readonly In5 inv5;
		readonly In6 inv6;
		readonly In7 inv7;
		readonly In8 inv8;
		readonly In9 inv9;
		readonly In10 inv10;
		readonly In11 inv11;
		readonly In12 inv12;
		readonly In13 inv13;
		readonly In14 inv14;
	
		public RunAction (Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14> Action , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			action = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			inv9 = Inv9;
			inv10 = Inv10;
			inv11 = Inv11;
			inv12 = Inv12;
			inv13 = Inv13;
			inv14 = Inv14;
			(thread = new Thread (DoIt)).Start();
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14);
		}
	}	// Action

	// Function with 15 parameter(s)
	public class RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,RT> : Run<RT> {
		readonly private Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,RT> function;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
		readonly In4 inv4;
		readonly In5 inv5;
		readonly In6 inv6;
		readonly In7 inv7;
		readonly In8 inv8;
		readonly In9 inv9;
		readonly In10 inv10;
		readonly In11 inv11;
		readonly In12 inv12;
		readonly In13 inv13;
		readonly In14 inv14;
	
		public RunFunc (Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			function = Function;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			inv9 = Inv9;
			inv10 = Inv10;
			inv11 = Inv11;
			inv12 = Inv12;
			inv13 = Inv13;
			inv14 = Inv14;
			(thread = new Thread (DoIt)).Start();
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14);
		}
	}	// Function 
	
	// Action with 16 parameter(s)
	public class RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15> : Run {
		readonly private Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15> action;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
		readonly In4 inv4;
		readonly In5 inv5;
		readonly In6 inv6;
		readonly In7 inv7;
		readonly In8 inv8;
		readonly In9 inv9;
		readonly In10 inv10;
		readonly In11 inv11;
		readonly In12 inv12;
		readonly In13 inv13;
		readonly In14 inv14;
		readonly In15 inv15;
	
		public RunAction (Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15> Action , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			action = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			inv9 = Inv9;
			inv10 = Inv10;
			inv11 = Inv11;
			inv12 = Inv12;
			inv13 = Inv13;
			inv14 = Inv14;
			inv15 = Inv15;
			(thread = new Thread (DoIt)).Start();
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14,inv15);
		}
	}	// Action

	// Function with 16 parameter(s)
	public class RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15,RT> : Run<RT> {
		readonly private Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15,RT> function;
		readonly In0 inv0;
		readonly In1 inv1;
		readonly In2 inv2;
		readonly In3 inv3;
		readonly In4 inv4;
		readonly In5 inv5;
		readonly In6 inv6;
		readonly In7 inv7;
		readonly In8 inv8;
		readonly In9 inv9;
		readonly In10 inv10;
		readonly In11 inv11;
		readonly In12 inv12;
		readonly In13 inv13;
		readonly In14 inv14;
		readonly In15 inv15;
	
		public RunFunc (Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			function = Function;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			inv9 = Inv9;
			inv10 = Inv10;
			inv11 = Inv11;
			inv12 = Inv12;
			inv13 = Inv13;
			inv14 = Inv14;
			inv15 = Inv15;
			(thread = new Thread (DoIt)).Start();
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14,inv15);
		}
	}	// Function 
	

}	//	namespace	2019-03-01 - 16.30.38