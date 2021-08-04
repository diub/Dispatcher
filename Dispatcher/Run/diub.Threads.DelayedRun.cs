
// 
// Run - © Copyright diub - Dipl.-Ing. Uwe Barth - 2021-08-04
// Updated: 2021-08-04
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
	public class DelayedRun : Run{
		
		public bool Start () {
			try {
				thread.Start ();
				return true;
			} catch(Exception) { 
				return false;
			}
		}

	}	//	Run


	/// <summary>
	/// Synchronization Object for Func and getting the result.
	/// </summary>	
	public class DelayedRun<RT> : DelayedRun {
		protected RT return_value;

		public RT Result {
			get {
				Wait ();
				return return_value;
			}
		}
	}	//	Run

	// Action; syntactic special case, since no parameter
	public class DelayedRunAction : DelayedRun {		
		private Action action;

		public DelayedRunAction (Action Action) {
			action = Action;
			thread = new Thread (DoIt);
		}

		private void DoIt () {
			action ();
		}
	}   // Action

	// Function; syntactic special case, since no parameter
	public class DelayedRunFunc<RT> : DelayedRun<RT>  {		
		private Func<RT> function;

		public DelayedRunFunc (Func<RT> Function) {
			function = Function;
			thread = new Thread (DoIt);
		}

		private void DoIt () {
			return_value = function ();
		}
	}   // Function

	/// <summary>
	/// Synchronization Object for Func and getting the result.<para></para>
	/// for 2 Return Values.
	/// </summary>	
	public class DelayedRun2<RT0, RT1> : DelayedRun {
		protected (RT0, RT1) return_value;

		public (RT0, RT1) Result {
			get {
				Wait ();
				return return_value;
			}
		}
	}	//	Run

	/// <summary>
	/// Synchronization Object for Func and getting the result.<para></para>
	/// for 3 Return Values.
	/// </summary>	
	public class DelayedRun3<RT0, RT1, RT2> : DelayedRun {
		protected (RT0, RT1, RT2) return_value;

		public (RT0, RT1, RT2) Result {
			get {
				Wait ();
				return return_value;
			}
		}
	}	//	Run

	/// <summary>
	/// Synchronization Object for Func and getting the result.<para></para>
	/// for 4 Return Values.
	/// </summary>	
	public class DelayedRun4<RT0, RT1, RT2, RT3> : DelayedRun {
		protected (RT0, RT1, RT2, RT3) return_value;

		public (RT0, RT1, RT2, RT3) Result {
			get {
				Wait ();
				return return_value;
			}
		}
	}	//	Run

	/// <summary>
	/// Synchronization Object for Func and getting the result.<para></para>
	/// for 5 Return Values.
	/// </summary>	
	public class DelayedRun5<RT0, RT1, RT2, RT3, RT4> : DelayedRun {
		protected (RT0, RT1, RT2, RT3, RT4) return_value;

		public (RT0, RT1, RT2, RT3, RT4) Result {
			get {
				Wait ();
				return return_value;
			}
		}
	}	//	Run

	/// <summary>
	/// Synchronization Object for Func and getting the result.<para></para>
	/// for 6 Return Values.
	/// </summary>	
	public class DelayedRun6<RT0, RT1, RT2, RT3, RT4, RT5> : DelayedRun {
		protected (RT0, RT1, RT2, RT3, RT4, RT5) return_value;

		public (RT0, RT1, RT2, RT3, RT4, RT5) Result {
			get {
				Wait ();
				return return_value;
			}
		}
	}	//	Run

	/// <summary>
	/// Synchronization Object for Func and getting the result.<para></para>
	/// for 7 Return Values.
	/// </summary>	
	public class DelayedRun7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> : DelayedRun {
		protected (RT0, RT1, RT2, RT3, RT4, RT5, RT6) return_value;

		public (RT0, RT1, RT2, RT3, RT4, RT5, RT6) Result {
			get {
				Wait ();
				return return_value;
			}
		}
	}	//	Run

	/// <summary>
	/// Synchronization Object for Func and getting the result.<para></para>
	/// for 8 Return Values.
	/// </summary>	
	public class DelayedRun8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> : DelayedRun {
		protected (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7) return_value;

		public (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7) Result {
			get {
				Wait ();
				return return_value;
			}
		}
	}	//	Run

	/// <summary>
	/// Synchronization Object for Func and getting the result.<para></para>
	/// for 9 Return Values.
	/// </summary>	
	public class DelayedRun9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> : DelayedRun {
		protected (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8) return_value;

		public (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8) Result {
			get {
				Wait ();
				return return_value;
			}
		}
	}	//	Run

	/// <summary>
	/// Synchronization Object for Func and getting the result.<para></para>
	/// for 10 Return Values.
	/// </summary>	
	public class DelayedRun10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> : DelayedRun {
		protected (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9) return_value;

		public (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9) Result {
			get {
				Wait ();
				return return_value;
			}
		}
	}	//	Run

	/// <summary>
	/// Synchronization Object for Func and getting the result.<para></para>
	/// for 11 Return Values.
	/// </summary>	
	public class DelayedRun11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> : DelayedRun {
		protected (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10) return_value;

		public (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10) Result {
			get {
				Wait ();
				return return_value;
			}
		}
	}	//	Run

	/// <summary>
	/// Synchronization Object for Func and getting the result.<para></para>
	/// for 12 Return Values.
	/// </summary>	
	public class DelayedRun12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> : DelayedRun {
		protected (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11) return_value;

		public (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11) Result {
			get {
				Wait ();
				return return_value;
			}
		}
	}	//	Run

	/// <summary>
	/// Synchronization Object for Func and getting the result.<para></para>
	/// for 13 Return Values.
	/// </summary>	
	public class DelayedRun13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> : DelayedRun {
		protected (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12) return_value;

		public (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12) Result {
			get {
				Wait ();
				return return_value;
			}
		}
	}	//	Run

	/// <summary>
	/// Synchronization Object for Func and getting the result.<para></para>
	/// for 14 Return Values.
	/// </summary>	
	public class DelayedRun14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> : DelayedRun {
		protected (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13) return_value;

		public (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13) Result {
			get {
				Wait ();
				return return_value;
			}
		}
	}	//	Run

	/// <summary>
	/// Synchronization Object for Func and getting the result.<para></para>
	/// for 15 Return Values.
	/// </summary>	
	public class DelayedRun15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> : DelayedRun {
		protected (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14) return_value;

		public (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14) Result {
			get {
				Wait ();
				return return_value;
			}
		}
	}	//	Run

	/// <summary>
	/// Synchronization Object for Func and getting the result.<para></para>
	/// for 16 Return Values.
	/// </summary>	
	public class DelayedRun16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> : DelayedRun {
		protected (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15) return_value;

		public (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15) Result {
			get {
				Wait ();
				return return_value;
			}
		}
	}	//	Run


}	//	namespace	2021-08-04 - 13.10.48