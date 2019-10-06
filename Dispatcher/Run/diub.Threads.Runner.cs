// 
// Runner - © Copyright diub - Dipl.-Ing. Uwe Barth - 2019-03-03
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
	public partial class Runner {

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
		private class RunAction : Run {		
			private Action action;

			public Run Start (Action Action) {
				action = Action;
				thread = new Thread (DoIt);
				thread.Start ();
				return this;
			}

			private void DoIt () {
				action ();
			}
		}   // Action

		// Static Action for easy and safe call
		static public Run Action(Action Action) {
			return (new RunAction()).Start(Action);
		}	

		// Function; syntactic special case, since no parameter
		private class RunFunc<RT> : Run<RT>  {		
			private Func<RT> function;

			public Run<RT> Start (Func<RT> Function) {
				function = Function;
				thread = new Thread (DoIt);
				thread.Start ();
				return this;
			}

			private void DoIt () {
				return_value = function ();
			}
		}   // Function

		// Static Function for easy and safe call
		static public Run<RT> Func<RT>(Func<RT> Function) {
			return (new RunFunc<RT>()).Start(Function);
		}
	
		// Action with 1 parameter(s)
		private class RunAction<In0> : Run {
			private Action<In0> function;
			In0 inv0;
	
			public Run Start (Action<In0> Function , In0 Inv0) {
				function = Function;
				inv0 = Inv0;
				(thread = new Thread (DoIt)).Start();
				return this;		
			}
		
			public void DoIt () {
				function (inv0);
			}
		}	// Action

		// Static Action for easy and safe call
		static public Run Action<In0>(Action<In0> Function, In0 Inv0) {
			return (new RunAction<In0>()).Start(Function,Inv0);
		}
	
		// Function with 1 parameter(s)
		private class RunFunc<In0,RT> : Run<RT> {
			private Func<In0,RT> function;
			In0 inv0;
	
			public Run<RT> Start (Func<In0,RT> Function, In0 Inv0) {
				function = Function;
				inv0 = Inv0;
				(thread = new Thread (DoIt)).Start();
				return this;		
			}
		
			private void DoIt () {
				return_value = function (inv0);
			}
		}	// Function 

		// Static Function for easy and safe call
		static public Run<RT> Func<In0,RT>(Func<In0,RT> Function, In0 Inv0) {
			return (new RunFunc<In0,RT>()).Start(Function, Inv0);
		}
	
		// Action with 2 parameter(s)
		private class RunAction<In0,In1> : Run {
			private Action<In0,In1> function;
			In0 inv0;
			In1 inv1;
	
			public Run Start (Action<In0,In1> Function , In0 Inv0, In1 Inv1) {
				function = Function;
				inv0 = Inv0;
				inv1 = Inv1;
				(thread = new Thread (DoIt)).Start();
				return this;		
			}
		
			public void DoIt () {
				function (inv0,inv1);
			}
		}	// Action

		// Static Action for easy and safe call
		static public Run Action<In0,In1>(Action<In0,In1> Function, In0 Inv0, In1 Inv1) {
			return (new RunAction<In0,In1>()).Start(Function,Inv0,Inv1);
		}
	
		// Function with 2 parameter(s)
		private class RunFunc<In0,In1,RT> : Run<RT> {
			private Func<In0,In1,RT> function;
			In0 inv0;
			In1 inv1;
	
			public Run<RT> Start (Func<In0,In1,RT> Function, In0 Inv0, In1 Inv1) {
				function = Function;
				inv0 = Inv0;
				inv1 = Inv1;
				(thread = new Thread (DoIt)).Start();
				return this;		
			}
		
			private void DoIt () {
				return_value = function (inv0,inv1);
			}
		}	// Function 

		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,RT>(Func<In0,In1,RT> Function, In0 Inv0, In1 Inv1) {
			return (new RunFunc<In0,In1,RT>()).Start(Function, Inv0,Inv1);
		}
	
		// Action with 3 parameter(s)
		private class RunAction<In0,In1,In2> : Run {
			private Action<In0,In1,In2> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
	
			public Run Start (Action<In0,In1,In2> Function , In0 Inv0, In1 Inv1, In2 Inv2) {
				function = Function;
				inv0 = Inv0;
				inv1 = Inv1;
				inv2 = Inv2;
				(thread = new Thread (DoIt)).Start();
				return this;		
			}
		
			public void DoIt () {
				function (inv0,inv1,inv2);
			}
		}	// Action

		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2>(Action<In0,In1,In2> Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			return (new RunAction<In0,In1,In2>()).Start(Function,Inv0,Inv1,Inv2);
		}
	
		// Function with 3 parameter(s)
		private class RunFunc<In0,In1,In2,RT> : Run<RT> {
			private Func<In0,In1,In2,RT> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
	
			public Run<RT> Start (Func<In0,In1,In2,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2) {
				function = Function;
				inv0 = Inv0;
				inv1 = Inv1;
				inv2 = Inv2;
				(thread = new Thread (DoIt)).Start();
				return this;		
			}
		
			private void DoIt () {
				return_value = function (inv0,inv1,inv2);
			}
		}	// Function 

		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,RT>(Func<In0,In1,In2,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			return (new RunFunc<In0,In1,In2,RT>()).Start(Function, Inv0,Inv1,Inv2);
		}
	
		// Action with 4 parameter(s)
		private class RunAction<In0,In1,In2,In3> : Run {
			private Action<In0,In1,In2,In3> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
	
			public Run Start (Action<In0,In1,In2,In3> Function , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
				function = Function;
				inv0 = Inv0;
				inv1 = Inv1;
				inv2 = Inv2;
				inv3 = Inv3;
				(thread = new Thread (DoIt)).Start();
				return this;		
			}
		
			public void DoIt () {
				function (inv0,inv1,inv2,inv3);
			}
		}	// Action

		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3>(Action<In0,In1,In2,In3> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return (new RunAction<In0,In1,In2,In3>()).Start(Function,Inv0,Inv1,Inv2,Inv3);
		}
	
		// Function with 4 parameter(s)
		private class RunFunc<In0,In1,In2,In3,RT> : Run<RT> {
			private Func<In0,In1,In2,In3,RT> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
	
			public Run<RT> Start (Func<In0,In1,In2,In3,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
				function = Function;
				inv0 = Inv0;
				inv1 = Inv1;
				inv2 = Inv2;
				inv3 = Inv3;
				(thread = new Thread (DoIt)).Start();
				return this;		
			}
		
			private void DoIt () {
				return_value = function (inv0,inv1,inv2,inv3);
			}
		}	// Function 

		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,RT>(Func<In0,In1,In2,In3,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return (new RunFunc<In0,In1,In2,In3,RT>()).Start(Function, Inv0,Inv1,Inv2,Inv3);
		}
	
		// Action with 5 parameter(s)
		private class RunAction<In0,In1,In2,In3,In4> : Run {
			private Action<In0,In1,In2,In3,In4> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
			In4 inv4;
	
			public Run Start (Action<In0,In1,In2,In3,In4> Function , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
				function = Function;
				inv0 = Inv0;
				inv1 = Inv1;
				inv2 = Inv2;
				inv3 = Inv3;
				inv4 = Inv4;
				(thread = new Thread (DoIt)).Start();
				return this;		
			}
		
			public void DoIt () {
				function (inv0,inv1,inv2,inv3,inv4);
			}
		}	// Action

		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3,In4>(Action<In0,In1,In2,In3,In4> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return (new RunAction<In0,In1,In2,In3,In4>()).Start(Function,Inv0,Inv1,Inv2,Inv3,Inv4);
		}
	
		// Function with 5 parameter(s)
		private class RunFunc<In0,In1,In2,In3,In4,RT> : Run<RT> {
			private Func<In0,In1,In2,In3,In4,RT> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
			In4 inv4;
	
			public Run<RT> Start (Func<In0,In1,In2,In3,In4,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
				function = Function;
				inv0 = Inv0;
				inv1 = Inv1;
				inv2 = Inv2;
				inv3 = Inv3;
				inv4 = Inv4;
				(thread = new Thread (DoIt)).Start();
				return this;		
			}
		
			private void DoIt () {
				return_value = function (inv0,inv1,inv2,inv3,inv4);
			}
		}	// Function 

		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,In4,RT>(Func<In0,In1,In2,In3,In4,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return (new RunFunc<In0,In1,In2,In3,In4,RT>()).Start(Function, Inv0,Inv1,Inv2,Inv3,Inv4);
		}
	
		// Action with 6 parameter(s)
		private class RunAction<In0,In1,In2,In3,In4,In5> : Run {
			private Action<In0,In1,In2,In3,In4,In5> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
			In4 inv4;
			In5 inv5;
	
			public Run Start (Action<In0,In1,In2,In3,In4,In5> Function , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
				function = Function;
				inv0 = Inv0;
				inv1 = Inv1;
				inv2 = Inv2;
				inv3 = Inv3;
				inv4 = Inv4;
				inv5 = Inv5;
				(thread = new Thread (DoIt)).Start();
				return this;		
			}
		
			public void DoIt () {
				function (inv0,inv1,inv2,inv3,inv4,inv5);
			}
		}	// Action

		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3,In4,In5>(Action<In0,In1,In2,In3,In4,In5> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return (new RunAction<In0,In1,In2,In3,In4,In5>()).Start(Function,Inv0,Inv1,Inv2,Inv3,Inv4,Inv5);
		}
	
		// Function with 6 parameter(s)
		private class RunFunc<In0,In1,In2,In3,In4,In5,RT> : Run<RT> {
			private Func<In0,In1,In2,In3,In4,In5,RT> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
			In4 inv4;
			In5 inv5;
	
			public Run<RT> Start (Func<In0,In1,In2,In3,In4,In5,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
				function = Function;
				inv0 = Inv0;
				inv1 = Inv1;
				inv2 = Inv2;
				inv3 = Inv3;
				inv4 = Inv4;
				inv5 = Inv5;
				(thread = new Thread (DoIt)).Start();
				return this;		
			}
		
			private void DoIt () {
				return_value = function (inv0,inv1,inv2,inv3,inv4,inv5);
			}
		}	// Function 

		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,RT>(Func<In0,In1,In2,In3,In4,In5,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return (new RunFunc<In0,In1,In2,In3,In4,In5,RT>()).Start(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5);
		}
	
		// Action with 7 parameter(s)
		private class RunAction<In0,In1,In2,In3,In4,In5,In6> : Run {
			private Action<In0,In1,In2,In3,In4,In5,In6> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
			In4 inv4;
			In5 inv5;
			In6 inv6;
	
			public Run Start (Action<In0,In1,In2,In3,In4,In5,In6> Function , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
				function = Function;
				inv0 = Inv0;
				inv1 = Inv1;
				inv2 = Inv2;
				inv3 = Inv3;
				inv4 = Inv4;
				inv5 = Inv5;
				inv6 = Inv6;
				(thread = new Thread (DoIt)).Start();
				return this;		
			}
		
			public void DoIt () {
				function (inv0,inv1,inv2,inv3,inv4,inv5,inv6);
			}
		}	// Action

		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3,In4,In5,In6>(Action<In0,In1,In2,In3,In4,In5,In6> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6>()).Start(Function,Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6);
		}
	
		// Function with 7 parameter(s)
		private class RunFunc<In0,In1,In2,In3,In4,In5,In6,RT> : Run<RT> {
			private Func<In0,In1,In2,In3,In4,In5,In6,RT> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
			In4 inv4;
			In5 inv5;
			In6 inv6;
	
			public Run<RT> Start (Func<In0,In1,In2,In3,In4,In5,In6,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
				function = Function;
				inv0 = Inv0;
				inv1 = Inv1;
				inv2 = Inv2;
				inv3 = Inv3;
				inv4 = Inv4;
				inv5 = Inv5;
				inv6 = Inv6;
				(thread = new Thread (DoIt)).Start();
				return this;		
			}
		
			private void DoIt () {
				return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6);
			}
		}	// Function 

		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,RT>(Func<In0,In1,In2,In3,In4,In5,In6,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return (new RunFunc<In0,In1,In2,In3,In4,In5,In6,RT>()).Start(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6);
		}
	
		// Action with 8 parameter(s)
		private class RunAction<In0,In1,In2,In3,In4,In5,In6,In7> : Run {
			private Action<In0,In1,In2,In3,In4,In5,In6,In7> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
			In4 inv4;
			In5 inv5;
			In6 inv6;
			In7 inv7;
	
			public Run Start (Action<In0,In1,In2,In3,In4,In5,In6,In7> Function , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
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
				return this;		
			}
		
			public void DoIt () {
				function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7);
			}
		}	// Action

		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7>(Action<In0,In1,In2,In3,In4,In5,In6,In7> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7>()).Start(Function,Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7);
		}
	
		// Function with 8 parameter(s)
		private class RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,RT> : Run<RT> {
			private Func<In0,In1,In2,In3,In4,In5,In6,In7,RT> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
			In4 inv4;
			In5 inv5;
			In6 inv6;
			In7 inv7;
	
			public Run<RT> Start (Func<In0,In1,In2,In3,In4,In5,In6,In7,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
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
				return this;		
			}
		
			private void DoIt () {
				return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7);
			}
		}	// Function 

		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return (new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,RT>()).Start(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7);
		}
	
		// Action with 9 parameter(s)
		private class RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8> : Run {
			private Action<In0,In1,In2,In3,In4,In5,In6,In7,In8> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
			In4 inv4;
			In5 inv5;
			In6 inv6;
			In7 inv7;
			In8 inv8;
	
			public Run Start (Action<In0,In1,In2,In3,In4,In5,In6,In7,In8> Function , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
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
				return this;		
			}
		
			public void DoIt () {
				function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8);
			}
		}	// Action

		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7,In8>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8>()).Start(Function,Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8);
		}
	
		// Function with 9 parameter(s)
		private class RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,RT> : Run<RT> {
			private Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,RT> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
			In4 inv4;
			In5 inv5;
			In6 inv6;
			In7 inv7;
			In8 inv8;
	
			public Run<RT> Start (Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
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
				return this;		
			}
		
			private void DoIt () {
				return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8);
			}
		}	// Function 

		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return (new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,RT>()).Start(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8);
		}
	
		// Action with 10 parameter(s)
		private class RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9> : Run {
			private Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
			In4 inv4;
			In5 inv5;
			In6 inv6;
			In7 inv7;
			In8 inv8;
			In9 inv9;
	
			public Run Start (Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9> Function , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
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
				return this;		
			}
		
			public void DoIt () {
				function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9);
			}
		}	// Action

		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9>()).Start(Function,Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9);
		}
	
		// Function with 10 parameter(s)
		private class RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,RT> : Run<RT> {
			private Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,RT> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
			In4 inv4;
			In5 inv5;
			In6 inv6;
			In7 inv7;
			In8 inv8;
			In9 inv9;
	
			public Run<RT> Start (Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
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
				return this;		
			}
		
			private void DoIt () {
				return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9);
			}
		}	// Function 

		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return (new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,RT>()).Start(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9);
		}
	
		// Action with 11 parameter(s)
		private class RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10> : Run {
			private Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
			In4 inv4;
			In5 inv5;
			In6 inv6;
			In7 inv7;
			In8 inv8;
			In9 inv9;
			In10 inv10;
	
			public Run Start (Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10> Function , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
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
				return this;		
			}
		
			public void DoIt () {
				function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10);
			}
		}	// Action

		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10>()).Start(Function,Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10);
		}
	
		// Function with 11 parameter(s)
		private class RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,RT> : Run<RT> {
			private Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,RT> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
			In4 inv4;
			In5 inv5;
			In6 inv6;
			In7 inv7;
			In8 inv8;
			In9 inv9;
			In10 inv10;
	
			public Run<RT> Start (Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
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
				return this;		
			}
		
			private void DoIt () {
				return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10);
			}
		}	// Function 

		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return (new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,RT>()).Start(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10);
		}
	
		// Action with 12 parameter(s)
		private class RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11> : Run {
			private Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
			In4 inv4;
			In5 inv5;
			In6 inv6;
			In7 inv7;
			In8 inv8;
			In9 inv9;
			In10 inv10;
			In11 inv11;
	
			public Run Start (Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11> Function , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
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
				return this;		
			}
		
			public void DoIt () {
				function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11);
			}
		}	// Action

		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11>()).Start(Function,Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11);
		}
	
		// Function with 12 parameter(s)
		private class RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,RT> : Run<RT> {
			private Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,RT> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
			In4 inv4;
			In5 inv5;
			In6 inv6;
			In7 inv7;
			In8 inv8;
			In9 inv9;
			In10 inv10;
			In11 inv11;
	
			public Run<RT> Start (Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
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
				return this;		
			}
		
			private void DoIt () {
				return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11);
			}
		}	// Function 

		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return (new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,RT>()).Start(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11);
		}
	
		// Action with 13 parameter(s)
		private class RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12> : Run {
			private Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
			In4 inv4;
			In5 inv5;
			In6 inv6;
			In7 inv7;
			In8 inv8;
			In9 inv9;
			In10 inv10;
			In11 inv11;
			In12 inv12;
	
			public Run Start (Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12> Function , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
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
				return this;		
			}
		
			public void DoIt () {
				function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12);
			}
		}	// Action

		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12>()).Start(Function,Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12);
		}
	
		// Function with 13 parameter(s)
		private class RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,RT> : Run<RT> {
			private Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,RT> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
			In4 inv4;
			In5 inv5;
			In6 inv6;
			In7 inv7;
			In8 inv8;
			In9 inv9;
			In10 inv10;
			In11 inv11;
			In12 inv12;
	
			public Run<RT> Start (Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
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
				return this;		
			}
		
			private void DoIt () {
				return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12);
			}
		}	// Function 

		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return (new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,RT>()).Start(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12);
		}
	
		// Action with 14 parameter(s)
		private class RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13> : Run {
			private Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
			In4 inv4;
			In5 inv5;
			In6 inv6;
			In7 inv7;
			In8 inv8;
			In9 inv9;
			In10 inv10;
			In11 inv11;
			In12 inv12;
			In13 inv13;
	
			public Run Start (Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13> Function , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
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
				return this;		
			}
		
			public void DoIt () {
				function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13);
			}
		}	// Action

		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13>()).Start(Function,Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13);
		}
	
		// Function with 14 parameter(s)
		private class RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,RT> : Run<RT> {
			private Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,RT> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
			In4 inv4;
			In5 inv5;
			In6 inv6;
			In7 inv7;
			In8 inv8;
			In9 inv9;
			In10 inv10;
			In11 inv11;
			In12 inv12;
			In13 inv13;
	
			public Run<RT> Start (Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
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
				return this;		
			}
		
			private void DoIt () {
				return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13);
			}
		}	// Function 

		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			return (new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,RT>()).Start(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13);
		}
	
		// Action with 15 parameter(s)
		private class RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14> : Run {
			private Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
			In4 inv4;
			In5 inv5;
			In6 inv6;
			In7 inv7;
			In8 inv8;
			In9 inv9;
			In10 inv10;
			In11 inv11;
			In12 inv12;
			In13 inv13;
			In14 inv14;
	
			public Run Start (Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14> Function , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
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
				return this;		
			}
		
			public void DoIt () {
				function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14);
			}
		}	// Action

		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14>()).Start(Function,Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14);
		}
	
		// Function with 15 parameter(s)
		private class RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,RT> : Run<RT> {
			private Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,RT> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
			In4 inv4;
			In5 inv5;
			In6 inv6;
			In7 inv7;
			In8 inv8;
			In9 inv9;
			In10 inv10;
			In11 inv11;
			In12 inv12;
			In13 inv13;
			In14 inv14;
	
			public Run<RT> Start (Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
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
				return this;		
			}
		
			private void DoIt () {
				return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14);
			}
		}	// Function 

		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			return (new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,RT>()).Start(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14);
		}
	
		// Action with 16 parameter(s)
		private class RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15> : Run {
			private Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
			In4 inv4;
			In5 inv5;
			In6 inv6;
			In7 inv7;
			In8 inv8;
			In9 inv9;
			In10 inv10;
			In11 inv11;
			In12 inv12;
			In13 inv13;
			In14 inv14;
			In15 inv15;
	
			public Run Start (Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15> Function , In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
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
				return this;		
			}
		
			public void DoIt () {
				function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14,inv15);
			}
		}	// Action

		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15>()).Start(Function,Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14,Inv15);
		}
	
		// Function with 16 parameter(s)
		private class RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15,RT> : Run<RT> {
			private Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15,RT> function;
			In0 inv0;
			In1 inv1;
			In2 inv2;
			In3 inv3;
			In4 inv4;
			In5 inv5;
			In6 inv6;
			In7 inv7;
			In8 inv8;
			In9 inv9;
			In10 inv10;
			In11 inv11;
			In12 inv12;
			In13 inv13;
			In14 inv14;
			In15 inv15;
	
			public Run<RT> Start (Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
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
				return this;		
			}
		
			private void DoIt () {
				return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14,inv15);
			}
		}	// Function 

		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			return (new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15,RT>()).Start(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14,Inv15);
		}
	
	}
}	//	namespace	2019-03-01 - 16.30.38