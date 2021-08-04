
// 
// Run - © Copyright diub - Dipl.-Ing. Uwe Barth - 2021-03-31
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


	// Function with 1 parameter(s)
	public class DelayedRunFunc<In0,RT> : DelayedRun<RT> {
		private Func<In0,RT> function;
		In0 inv0;
	
		public DelayedRunFunc (Func<In0,RT> Function, In0 Inv0) {
			function = Function;
			inv0 = Inv0;
			thread = new Thread (DoIt);
		}
		
		private void DoIt () {
			return_value = function (inv0);
		}
	}	// Function 
	

	// Function with 1 parameter(s)<para></para>
	// and 2 return values.
	public class DelayedRunFunc2<In0, RT0, RT1> : DelayedRun2<RT0, RT1> {
		public delegate (RT0, RT1) RunDelegate (In0 Inv0);
		private RunDelegate function;
		private In0 inv0;
	
		public DelayedRunFunc2 (RunDelegate Action, In0 Inv0) {
			function = Action;
			inv0 = Inv0;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0);
		}
	}

	// Function with 1 parameter(s)<para></para>
	// and 3 return values.
	public class DelayedRunFunc3<In0, RT0, RT1, RT2> : DelayedRun3<RT0, RT1, RT2> {
		public delegate (RT0, RT1, RT2) RunDelegate (In0 Inv0);
		private RunDelegate function;
		private In0 inv0;
	
		public DelayedRunFunc3 (RunDelegate Action, In0 Inv0) {
			function = Action;
			inv0 = Inv0;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0);
		}
	}

	// Function with 1 parameter(s)<para></para>
	// and 4 return values.
	public class DelayedRunFunc4<In0, RT0, RT1, RT2, RT3> : DelayedRun4<RT0, RT1, RT2, RT3> {
		public delegate (RT0, RT1, RT2, RT3) RunDelegate (In0 Inv0);
		private RunDelegate function;
		private In0 inv0;
	
		public DelayedRunFunc4 (RunDelegate Action, In0 Inv0) {
			function = Action;
			inv0 = Inv0;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0);
		}
	}

	// Function with 1 parameter(s)<para></para>
	// and 5 return values.
	public class DelayedRunFunc5<In0, RT0, RT1, RT2, RT3, RT4> : DelayedRun5<RT0, RT1, RT2, RT3, RT4> {
		public delegate (RT0, RT1, RT2, RT3, RT4) RunDelegate (In0 Inv0);
		private RunDelegate function;
		private In0 inv0;
	
		public DelayedRunFunc5 (RunDelegate Action, In0 Inv0) {
			function = Action;
			inv0 = Inv0;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0);
		}
	}

	// Function with 1 parameter(s)<para></para>
	// and 6 return values.
	public class DelayedRunFunc6<In0, RT0, RT1, RT2, RT3, RT4, RT5> : DelayedRun6<RT0, RT1, RT2, RT3, RT4, RT5> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5) RunDelegate (In0 Inv0);
		private RunDelegate function;
		private In0 inv0;
	
		public DelayedRunFunc6 (RunDelegate Action, In0 Inv0) {
			function = Action;
			inv0 = Inv0;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0);
		}
	}

	// Function with 1 parameter(s)<para></para>
	// and 7 return values.
	public class DelayedRunFunc7<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6> : DelayedRun7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6) RunDelegate (In0 Inv0);
		private RunDelegate function;
		private In0 inv0;
	
		public DelayedRunFunc7 (RunDelegate Action, In0 Inv0) {
			function = Action;
			inv0 = Inv0;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0);
		}
	}

	// Function with 1 parameter(s)<para></para>
	// and 8 return values.
	public class DelayedRunFunc8<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> : DelayedRun8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7) RunDelegate (In0 Inv0);
		private RunDelegate function;
		private In0 inv0;
	
		public DelayedRunFunc8 (RunDelegate Action, In0 Inv0) {
			function = Action;
			inv0 = Inv0;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0);
		}
	}

	// Function with 1 parameter(s)<para></para>
	// and 9 return values.
	public class DelayedRunFunc9<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> : DelayedRun9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8) RunDelegate (In0 Inv0);
		private RunDelegate function;
		private In0 inv0;
	
		public DelayedRunFunc9 (RunDelegate Action, In0 Inv0) {
			function = Action;
			inv0 = Inv0;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0);
		}
	}

	// Function with 1 parameter(s)<para></para>
	// and 10 return values.
	public class DelayedRunFunc10<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> : DelayedRun10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9) RunDelegate (In0 Inv0);
		private RunDelegate function;
		private In0 inv0;
	
		public DelayedRunFunc10 (RunDelegate Action, In0 Inv0) {
			function = Action;
			inv0 = Inv0;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0);
		}
	}

	// Function with 1 parameter(s)<para></para>
	// and 11 return values.
	public class DelayedRunFunc11<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> : DelayedRun11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10) RunDelegate (In0 Inv0);
		private RunDelegate function;
		private In0 inv0;
	
		public DelayedRunFunc11 (RunDelegate Action, In0 Inv0) {
			function = Action;
			inv0 = Inv0;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0);
		}
	}

	// Function with 1 parameter(s)<para></para>
	// and 12 return values.
	public class DelayedRunFunc12<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> : DelayedRun12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11) RunDelegate (In0 Inv0);
		private RunDelegate function;
		private In0 inv0;
	
		public DelayedRunFunc12 (RunDelegate Action, In0 Inv0) {
			function = Action;
			inv0 = Inv0;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0);
		}
	}

	// Function with 1 parameter(s)<para></para>
	// and 13 return values.
	public class DelayedRunFunc13<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> : DelayedRun13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12) RunDelegate (In0 Inv0);
		private RunDelegate function;
		private In0 inv0;
	
		public DelayedRunFunc13 (RunDelegate Action, In0 Inv0) {
			function = Action;
			inv0 = Inv0;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0);
		}
	}

	// Function with 1 parameter(s)<para></para>
	// and 14 return values.
	public class DelayedRunFunc14<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> : DelayedRun14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13) RunDelegate (In0 Inv0);
		private RunDelegate function;
		private In0 inv0;
	
		public DelayedRunFunc14 (RunDelegate Action, In0 Inv0) {
			function = Action;
			inv0 = Inv0;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0);
		}
	}

	// Function with 1 parameter(s)<para></para>
	// and 15 return values.
	public class DelayedRunFunc15<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> : DelayedRun15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14) RunDelegate (In0 Inv0);
		private RunDelegate function;
		private In0 inv0;
	
		public DelayedRunFunc15 (RunDelegate Action, In0 Inv0) {
			function = Action;
			inv0 = Inv0;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0);
		}
	}

	// Function with 1 parameter(s)<para></para>
	// and 16 return values.
	public class DelayedRunFunc16<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> : DelayedRun16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15) RunDelegate (In0 Inv0);
		private RunDelegate function;
		private In0 inv0;
	
		public DelayedRunFunc16 (RunDelegate Action, In0 Inv0) {
			function = Action;
			inv0 = Inv0;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0);
		}
	}


	// Function with 2 parameter(s)
	public class DelayedRunFunc<In0,In1,RT> : DelayedRun<RT> {
		private Func<In0,In1,RT> function;
		In0 inv0;
		In1 inv1;
	
		public DelayedRunFunc (Func<In0,In1,RT> Function, In0 Inv0, In1 Inv1) {
			function = Function;
			inv0 = Inv0;
			inv1 = Inv1;
			thread = new Thread (DoIt);
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1);
		}
	}	// Function 
	

	// Function with 2 parameter(s)<para></para>
	// and 2 return values.
	public class DelayedRunFunc2<In0,In1, RT0, RT1> : DelayedRun2<RT0, RT1> {
		public delegate (RT0, RT1) RunDelegate (In0 Inv0, In1 Inv1);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
	
		public DelayedRunFunc2 (RunDelegate Action, In0 Inv0, In1 Inv1) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1);
		}
	}

	// Function with 2 parameter(s)<para></para>
	// and 3 return values.
	public class DelayedRunFunc3<In0,In1, RT0, RT1, RT2> : DelayedRun3<RT0, RT1, RT2> {
		public delegate (RT0, RT1, RT2) RunDelegate (In0 Inv0, In1 Inv1);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
	
		public DelayedRunFunc3 (RunDelegate Action, In0 Inv0, In1 Inv1) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1);
		}
	}

	// Function with 2 parameter(s)<para></para>
	// and 4 return values.
	public class DelayedRunFunc4<In0,In1, RT0, RT1, RT2, RT3> : DelayedRun4<RT0, RT1, RT2, RT3> {
		public delegate (RT0, RT1, RT2, RT3) RunDelegate (In0 Inv0, In1 Inv1);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
	
		public DelayedRunFunc4 (RunDelegate Action, In0 Inv0, In1 Inv1) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1);
		}
	}

	// Function with 2 parameter(s)<para></para>
	// and 5 return values.
	public class DelayedRunFunc5<In0,In1, RT0, RT1, RT2, RT3, RT4> : DelayedRun5<RT0, RT1, RT2, RT3, RT4> {
		public delegate (RT0, RT1, RT2, RT3, RT4) RunDelegate (In0 Inv0, In1 Inv1);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
	
		public DelayedRunFunc5 (RunDelegate Action, In0 Inv0, In1 Inv1) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1);
		}
	}

	// Function with 2 parameter(s)<para></para>
	// and 6 return values.
	public class DelayedRunFunc6<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5> : DelayedRun6<RT0, RT1, RT2, RT3, RT4, RT5> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5) RunDelegate (In0 Inv0, In1 Inv1);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
	
		public DelayedRunFunc6 (RunDelegate Action, In0 Inv0, In1 Inv1) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1);
		}
	}

	// Function with 2 parameter(s)<para></para>
	// and 7 return values.
	public class DelayedRunFunc7<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6> : DelayedRun7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6) RunDelegate (In0 Inv0, In1 Inv1);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
	
		public DelayedRunFunc7 (RunDelegate Action, In0 Inv0, In1 Inv1) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1);
		}
	}

	// Function with 2 parameter(s)<para></para>
	// and 8 return values.
	public class DelayedRunFunc8<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> : DelayedRun8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7) RunDelegate (In0 Inv0, In1 Inv1);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
	
		public DelayedRunFunc8 (RunDelegate Action, In0 Inv0, In1 Inv1) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1);
		}
	}

	// Function with 2 parameter(s)<para></para>
	// and 9 return values.
	public class DelayedRunFunc9<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> : DelayedRun9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8) RunDelegate (In0 Inv0, In1 Inv1);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
	
		public DelayedRunFunc9 (RunDelegate Action, In0 Inv0, In1 Inv1) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1);
		}
	}

	// Function with 2 parameter(s)<para></para>
	// and 10 return values.
	public class DelayedRunFunc10<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> : DelayedRun10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9) RunDelegate (In0 Inv0, In1 Inv1);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
	
		public DelayedRunFunc10 (RunDelegate Action, In0 Inv0, In1 Inv1) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1);
		}
	}

	// Function with 2 parameter(s)<para></para>
	// and 11 return values.
	public class DelayedRunFunc11<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> : DelayedRun11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10) RunDelegate (In0 Inv0, In1 Inv1);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
	
		public DelayedRunFunc11 (RunDelegate Action, In0 Inv0, In1 Inv1) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1);
		}
	}

	// Function with 2 parameter(s)<para></para>
	// and 12 return values.
	public class DelayedRunFunc12<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> : DelayedRun12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11) RunDelegate (In0 Inv0, In1 Inv1);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
	
		public DelayedRunFunc12 (RunDelegate Action, In0 Inv0, In1 Inv1) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1);
		}
	}

	// Function with 2 parameter(s)<para></para>
	// and 13 return values.
	public class DelayedRunFunc13<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> : DelayedRun13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12) RunDelegate (In0 Inv0, In1 Inv1);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
	
		public DelayedRunFunc13 (RunDelegate Action, In0 Inv0, In1 Inv1) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1);
		}
	}

	// Function with 2 parameter(s)<para></para>
	// and 14 return values.
	public class DelayedRunFunc14<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> : DelayedRun14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13) RunDelegate (In0 Inv0, In1 Inv1);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
	
		public DelayedRunFunc14 (RunDelegate Action, In0 Inv0, In1 Inv1) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1);
		}
	}

	// Function with 2 parameter(s)<para></para>
	// and 15 return values.
	public class DelayedRunFunc15<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> : DelayedRun15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14) RunDelegate (In0 Inv0, In1 Inv1);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
	
		public DelayedRunFunc15 (RunDelegate Action, In0 Inv0, In1 Inv1) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1);
		}
	}

	// Function with 2 parameter(s)<para></para>
	// and 16 return values.
	public class DelayedRunFunc16<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> : DelayedRun16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15) RunDelegate (In0 Inv0, In1 Inv1);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
	
		public DelayedRunFunc16 (RunDelegate Action, In0 Inv0, In1 Inv1) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1);
		}
	}


	// Function with 3 parameter(s)
	public class DelayedRunFunc<In0,In1,In2,RT> : DelayedRun<RT> {
		private Func<In0,In1,In2,RT> function;
		In0 inv0;
		In1 inv1;
		In2 inv2;
	
		public DelayedRunFunc (Func<In0,In1,In2,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			function = Function;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			thread = new Thread (DoIt);
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2);
		}
	}	// Function 
	

	// Function with 3 parameter(s)<para></para>
	// and 2 return values.
	public class DelayedRunFunc2<In0,In1,In2, RT0, RT1> : DelayedRun2<RT0, RT1> {
		public delegate (RT0, RT1) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
	
		public DelayedRunFunc2 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2);
		}
	}

	// Function with 3 parameter(s)<para></para>
	// and 3 return values.
	public class DelayedRunFunc3<In0,In1,In2, RT0, RT1, RT2> : DelayedRun3<RT0, RT1, RT2> {
		public delegate (RT0, RT1, RT2) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
	
		public DelayedRunFunc3 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2);
		}
	}

	// Function with 3 parameter(s)<para></para>
	// and 4 return values.
	public class DelayedRunFunc4<In0,In1,In2, RT0, RT1, RT2, RT3> : DelayedRun4<RT0, RT1, RT2, RT3> {
		public delegate (RT0, RT1, RT2, RT3) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
	
		public DelayedRunFunc4 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2);
		}
	}

	// Function with 3 parameter(s)<para></para>
	// and 5 return values.
	public class DelayedRunFunc5<In0,In1,In2, RT0, RT1, RT2, RT3, RT4> : DelayedRun5<RT0, RT1, RT2, RT3, RT4> {
		public delegate (RT0, RT1, RT2, RT3, RT4) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
	
		public DelayedRunFunc5 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2);
		}
	}

	// Function with 3 parameter(s)<para></para>
	// and 6 return values.
	public class DelayedRunFunc6<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5> : DelayedRun6<RT0, RT1, RT2, RT3, RT4, RT5> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
	
		public DelayedRunFunc6 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2);
		}
	}

	// Function with 3 parameter(s)<para></para>
	// and 7 return values.
	public class DelayedRunFunc7<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6> : DelayedRun7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
	
		public DelayedRunFunc7 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2);
		}
	}

	// Function with 3 parameter(s)<para></para>
	// and 8 return values.
	public class DelayedRunFunc8<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> : DelayedRun8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
	
		public DelayedRunFunc8 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2);
		}
	}

	// Function with 3 parameter(s)<para></para>
	// and 9 return values.
	public class DelayedRunFunc9<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> : DelayedRun9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
	
		public DelayedRunFunc9 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2);
		}
	}

	// Function with 3 parameter(s)<para></para>
	// and 10 return values.
	public class DelayedRunFunc10<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> : DelayedRun10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
	
		public DelayedRunFunc10 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2);
		}
	}

	// Function with 3 parameter(s)<para></para>
	// and 11 return values.
	public class DelayedRunFunc11<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> : DelayedRun11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
	
		public DelayedRunFunc11 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2);
		}
	}

	// Function with 3 parameter(s)<para></para>
	// and 12 return values.
	public class DelayedRunFunc12<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> : DelayedRun12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
	
		public DelayedRunFunc12 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2);
		}
	}

	// Function with 3 parameter(s)<para></para>
	// and 13 return values.
	public class DelayedRunFunc13<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> : DelayedRun13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
	
		public DelayedRunFunc13 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2);
		}
	}

	// Function with 3 parameter(s)<para></para>
	// and 14 return values.
	public class DelayedRunFunc14<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> : DelayedRun14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
	
		public DelayedRunFunc14 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2);
		}
	}

	// Function with 3 parameter(s)<para></para>
	// and 15 return values.
	public class DelayedRunFunc15<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> : DelayedRun15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
	
		public DelayedRunFunc15 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2);
		}
	}

	// Function with 3 parameter(s)<para></para>
	// and 16 return values.
	public class DelayedRunFunc16<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> : DelayedRun16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
	
		public DelayedRunFunc16 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2);
		}
	}


	// Function with 4 parameter(s)
	public class DelayedRunFunc<In0,In1,In2,In3,RT> : DelayedRun<RT> {
		private Func<In0,In1,In2,In3,RT> function;
		In0 inv0;
		In1 inv1;
		In2 inv2;
		In3 inv3;
	
		public DelayedRunFunc (Func<In0,In1,In2,In3,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			function = Function;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			thread = new Thread (DoIt);
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3);
		}
	}	// Function 
	

	// Function with 4 parameter(s)<para></para>
	// and 2 return values.
	public class DelayedRunFunc2<In0,In1,In2,In3, RT0, RT1> : DelayedRun2<RT0, RT1> {
		public delegate (RT0, RT1) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
	
		public DelayedRunFunc2 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3);
		}
	}

	// Function with 4 parameter(s)<para></para>
	// and 3 return values.
	public class DelayedRunFunc3<In0,In1,In2,In3, RT0, RT1, RT2> : DelayedRun3<RT0, RT1, RT2> {
		public delegate (RT0, RT1, RT2) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
	
		public DelayedRunFunc3 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3);
		}
	}

	// Function with 4 parameter(s)<para></para>
	// and 4 return values.
	public class DelayedRunFunc4<In0,In1,In2,In3, RT0, RT1, RT2, RT3> : DelayedRun4<RT0, RT1, RT2, RT3> {
		public delegate (RT0, RT1, RT2, RT3) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
	
		public DelayedRunFunc4 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3);
		}
	}

	// Function with 4 parameter(s)<para></para>
	// and 5 return values.
	public class DelayedRunFunc5<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4> : DelayedRun5<RT0, RT1, RT2, RT3, RT4> {
		public delegate (RT0, RT1, RT2, RT3, RT4) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
	
		public DelayedRunFunc5 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3);
		}
	}

	// Function with 4 parameter(s)<para></para>
	// and 6 return values.
	public class DelayedRunFunc6<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5> : DelayedRun6<RT0, RT1, RT2, RT3, RT4, RT5> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
	
		public DelayedRunFunc6 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3);
		}
	}

	// Function with 4 parameter(s)<para></para>
	// and 7 return values.
	public class DelayedRunFunc7<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6> : DelayedRun7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
	
		public DelayedRunFunc7 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3);
		}
	}

	// Function with 4 parameter(s)<para></para>
	// and 8 return values.
	public class DelayedRunFunc8<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> : DelayedRun8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
	
		public DelayedRunFunc8 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3);
		}
	}

	// Function with 4 parameter(s)<para></para>
	// and 9 return values.
	public class DelayedRunFunc9<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> : DelayedRun9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
	
		public DelayedRunFunc9 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3);
		}
	}

	// Function with 4 parameter(s)<para></para>
	// and 10 return values.
	public class DelayedRunFunc10<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> : DelayedRun10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
	
		public DelayedRunFunc10 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3);
		}
	}

	// Function with 4 parameter(s)<para></para>
	// and 11 return values.
	public class DelayedRunFunc11<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> : DelayedRun11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
	
		public DelayedRunFunc11 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3);
		}
	}

	// Function with 4 parameter(s)<para></para>
	// and 12 return values.
	public class DelayedRunFunc12<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> : DelayedRun12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
	
		public DelayedRunFunc12 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3);
		}
	}

	// Function with 4 parameter(s)<para></para>
	// and 13 return values.
	public class DelayedRunFunc13<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> : DelayedRun13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
	
		public DelayedRunFunc13 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3);
		}
	}

	// Function with 4 parameter(s)<para></para>
	// and 14 return values.
	public class DelayedRunFunc14<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> : DelayedRun14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
	
		public DelayedRunFunc14 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3);
		}
	}

	// Function with 4 parameter(s)<para></para>
	// and 15 return values.
	public class DelayedRunFunc15<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> : DelayedRun15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
	
		public DelayedRunFunc15 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3);
		}
	}

	// Function with 4 parameter(s)<para></para>
	// and 16 return values.
	public class DelayedRunFunc16<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> : DelayedRun16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
	
		public DelayedRunFunc16 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3);
		}
	}


	// Function with 5 parameter(s)
	public class DelayedRunFunc<In0,In1,In2,In3,In4,RT> : DelayedRun<RT> {
		private Func<In0,In1,In2,In3,In4,RT> function;
		In0 inv0;
		In1 inv1;
		In2 inv2;
		In3 inv3;
		In4 inv4;
	
		public DelayedRunFunc (Func<In0,In1,In2,In3,In4,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			function = Function;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			thread = new Thread (DoIt);
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4);
		}
	}	// Function 
	

	// Function with 5 parameter(s)<para></para>
	// and 2 return values.
	public class DelayedRunFunc2<In0,In1,In2,In3,In4, RT0, RT1> : DelayedRun2<RT0, RT1> {
		public delegate (RT0, RT1) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
	
		public DelayedRunFunc2 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4);
		}
	}

	// Function with 5 parameter(s)<para></para>
	// and 3 return values.
	public class DelayedRunFunc3<In0,In1,In2,In3,In4, RT0, RT1, RT2> : DelayedRun3<RT0, RT1, RT2> {
		public delegate (RT0, RT1, RT2) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
	
		public DelayedRunFunc3 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4);
		}
	}

	// Function with 5 parameter(s)<para></para>
	// and 4 return values.
	public class DelayedRunFunc4<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3> : DelayedRun4<RT0, RT1, RT2, RT3> {
		public delegate (RT0, RT1, RT2, RT3) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
	
		public DelayedRunFunc4 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4);
		}
	}

	// Function with 5 parameter(s)<para></para>
	// and 5 return values.
	public class DelayedRunFunc5<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4> : DelayedRun5<RT0, RT1, RT2, RT3, RT4> {
		public delegate (RT0, RT1, RT2, RT3, RT4) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
	
		public DelayedRunFunc5 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4);
		}
	}

	// Function with 5 parameter(s)<para></para>
	// and 6 return values.
	public class DelayedRunFunc6<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5> : DelayedRun6<RT0, RT1, RT2, RT3, RT4, RT5> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
	
		public DelayedRunFunc6 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4);
		}
	}

	// Function with 5 parameter(s)<para></para>
	// and 7 return values.
	public class DelayedRunFunc7<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6> : DelayedRun7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
	
		public DelayedRunFunc7 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4);
		}
	}

	// Function with 5 parameter(s)<para></para>
	// and 8 return values.
	public class DelayedRunFunc8<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> : DelayedRun8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
	
		public DelayedRunFunc8 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4);
		}
	}

	// Function with 5 parameter(s)<para></para>
	// and 9 return values.
	public class DelayedRunFunc9<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> : DelayedRun9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
	
		public DelayedRunFunc9 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4);
		}
	}

	// Function with 5 parameter(s)<para></para>
	// and 10 return values.
	public class DelayedRunFunc10<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> : DelayedRun10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
	
		public DelayedRunFunc10 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4);
		}
	}

	// Function with 5 parameter(s)<para></para>
	// and 11 return values.
	public class DelayedRunFunc11<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> : DelayedRun11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
	
		public DelayedRunFunc11 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4);
		}
	}

	// Function with 5 parameter(s)<para></para>
	// and 12 return values.
	public class DelayedRunFunc12<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> : DelayedRun12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
	
		public DelayedRunFunc12 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4);
		}
	}

	// Function with 5 parameter(s)<para></para>
	// and 13 return values.
	public class DelayedRunFunc13<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> : DelayedRun13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
	
		public DelayedRunFunc13 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4);
		}
	}

	// Function with 5 parameter(s)<para></para>
	// and 14 return values.
	public class DelayedRunFunc14<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> : DelayedRun14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
	
		public DelayedRunFunc14 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4);
		}
	}

	// Function with 5 parameter(s)<para></para>
	// and 15 return values.
	public class DelayedRunFunc15<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> : DelayedRun15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
	
		public DelayedRunFunc15 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4);
		}
	}

	// Function with 5 parameter(s)<para></para>
	// and 16 return values.
	public class DelayedRunFunc16<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> : DelayedRun16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
	
		public DelayedRunFunc16 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4);
		}
	}


	// Function with 6 parameter(s)
	public class DelayedRunFunc<In0,In1,In2,In3,In4,In5,RT> : DelayedRun<RT> {
		private Func<In0,In1,In2,In3,In4,In5,RT> function;
		In0 inv0;
		In1 inv1;
		In2 inv2;
		In3 inv3;
		In4 inv4;
		In5 inv5;
	
		public DelayedRunFunc (Func<In0,In1,In2,In3,In4,In5,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			function = Function;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			thread = new Thread (DoIt);
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5);
		}
	}	// Function 
	

	// Function with 6 parameter(s)<para></para>
	// and 2 return values.
	public class DelayedRunFunc2<In0,In1,In2,In3,In4,In5, RT0, RT1> : DelayedRun2<RT0, RT1> {
		public delegate (RT0, RT1) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
	
		public DelayedRunFunc2 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5);
		}
	}

	// Function with 6 parameter(s)<para></para>
	// and 3 return values.
	public class DelayedRunFunc3<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2> : DelayedRun3<RT0, RT1, RT2> {
		public delegate (RT0, RT1, RT2) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
	
		public DelayedRunFunc3 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5);
		}
	}

	// Function with 6 parameter(s)<para></para>
	// and 4 return values.
	public class DelayedRunFunc4<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3> : DelayedRun4<RT0, RT1, RT2, RT3> {
		public delegate (RT0, RT1, RT2, RT3) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
	
		public DelayedRunFunc4 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5);
		}
	}

	// Function with 6 parameter(s)<para></para>
	// and 5 return values.
	public class DelayedRunFunc5<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4> : DelayedRun5<RT0, RT1, RT2, RT3, RT4> {
		public delegate (RT0, RT1, RT2, RT3, RT4) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
	
		public DelayedRunFunc5 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5);
		}
	}

	// Function with 6 parameter(s)<para></para>
	// and 6 return values.
	public class DelayedRunFunc6<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5> : DelayedRun6<RT0, RT1, RT2, RT3, RT4, RT5> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
	
		public DelayedRunFunc6 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5);
		}
	}

	// Function with 6 parameter(s)<para></para>
	// and 7 return values.
	public class DelayedRunFunc7<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6> : DelayedRun7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
	
		public DelayedRunFunc7 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5);
		}
	}

	// Function with 6 parameter(s)<para></para>
	// and 8 return values.
	public class DelayedRunFunc8<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> : DelayedRun8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
	
		public DelayedRunFunc8 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5);
		}
	}

	// Function with 6 parameter(s)<para></para>
	// and 9 return values.
	public class DelayedRunFunc9<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> : DelayedRun9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
	
		public DelayedRunFunc9 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5);
		}
	}

	// Function with 6 parameter(s)<para></para>
	// and 10 return values.
	public class DelayedRunFunc10<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> : DelayedRun10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
	
		public DelayedRunFunc10 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5);
		}
	}

	// Function with 6 parameter(s)<para></para>
	// and 11 return values.
	public class DelayedRunFunc11<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> : DelayedRun11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
	
		public DelayedRunFunc11 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5);
		}
	}

	// Function with 6 parameter(s)<para></para>
	// and 12 return values.
	public class DelayedRunFunc12<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> : DelayedRun12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
	
		public DelayedRunFunc12 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5);
		}
	}

	// Function with 6 parameter(s)<para></para>
	// and 13 return values.
	public class DelayedRunFunc13<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> : DelayedRun13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
	
		public DelayedRunFunc13 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5);
		}
	}

	// Function with 6 parameter(s)<para></para>
	// and 14 return values.
	public class DelayedRunFunc14<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> : DelayedRun14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
	
		public DelayedRunFunc14 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5);
		}
	}

	// Function with 6 parameter(s)<para></para>
	// and 15 return values.
	public class DelayedRunFunc15<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> : DelayedRun15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
	
		public DelayedRunFunc15 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5);
		}
	}

	// Function with 6 parameter(s)<para></para>
	// and 16 return values.
	public class DelayedRunFunc16<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> : DelayedRun16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
	
		public DelayedRunFunc16 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5);
		}
	}


	// Function with 7 parameter(s)
	public class DelayedRunFunc<In0,In1,In2,In3,In4,In5,In6,RT> : DelayedRun<RT> {
		private Func<In0,In1,In2,In3,In4,In5,In6,RT> function;
		In0 inv0;
		In1 inv1;
		In2 inv2;
		In3 inv3;
		In4 inv4;
		In5 inv5;
		In6 inv6;
	
		public DelayedRunFunc (Func<In0,In1,In2,In3,In4,In5,In6,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			function = Function;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			thread = new Thread (DoIt);
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6);
		}
	}	// Function 
	

	// Function with 7 parameter(s)<para></para>
	// and 2 return values.
	public class DelayedRunFunc2<In0,In1,In2,In3,In4,In5,In6, RT0, RT1> : DelayedRun2<RT0, RT1> {
		public delegate (RT0, RT1) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
	
		public DelayedRunFunc2 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6);
		}
	}

	// Function with 7 parameter(s)<para></para>
	// and 3 return values.
	public class DelayedRunFunc3<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2> : DelayedRun3<RT0, RT1, RT2> {
		public delegate (RT0, RT1, RT2) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
	
		public DelayedRunFunc3 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6);
		}
	}

	// Function with 7 parameter(s)<para></para>
	// and 4 return values.
	public class DelayedRunFunc4<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3> : DelayedRun4<RT0, RT1, RT2, RT3> {
		public delegate (RT0, RT1, RT2, RT3) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
	
		public DelayedRunFunc4 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6);
		}
	}

	// Function with 7 parameter(s)<para></para>
	// and 5 return values.
	public class DelayedRunFunc5<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4> : DelayedRun5<RT0, RT1, RT2, RT3, RT4> {
		public delegate (RT0, RT1, RT2, RT3, RT4) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
	
		public DelayedRunFunc5 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6);
		}
	}

	// Function with 7 parameter(s)<para></para>
	// and 6 return values.
	public class DelayedRunFunc6<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5> : DelayedRun6<RT0, RT1, RT2, RT3, RT4, RT5> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
	
		public DelayedRunFunc6 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6);
		}
	}

	// Function with 7 parameter(s)<para></para>
	// and 7 return values.
	public class DelayedRunFunc7<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6> : DelayedRun7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
	
		public DelayedRunFunc7 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6);
		}
	}

	// Function with 7 parameter(s)<para></para>
	// and 8 return values.
	public class DelayedRunFunc8<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> : DelayedRun8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
	
		public DelayedRunFunc8 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6);
		}
	}

	// Function with 7 parameter(s)<para></para>
	// and 9 return values.
	public class DelayedRunFunc9<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> : DelayedRun9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
	
		public DelayedRunFunc9 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6);
		}
	}

	// Function with 7 parameter(s)<para></para>
	// and 10 return values.
	public class DelayedRunFunc10<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> : DelayedRun10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
	
		public DelayedRunFunc10 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6);
		}
	}

	// Function with 7 parameter(s)<para></para>
	// and 11 return values.
	public class DelayedRunFunc11<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> : DelayedRun11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
	
		public DelayedRunFunc11 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6);
		}
	}

	// Function with 7 parameter(s)<para></para>
	// and 12 return values.
	public class DelayedRunFunc12<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> : DelayedRun12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
	
		public DelayedRunFunc12 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6);
		}
	}

	// Function with 7 parameter(s)<para></para>
	// and 13 return values.
	public class DelayedRunFunc13<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> : DelayedRun13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
	
		public DelayedRunFunc13 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6);
		}
	}

	// Function with 7 parameter(s)<para></para>
	// and 14 return values.
	public class DelayedRunFunc14<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> : DelayedRun14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
	
		public DelayedRunFunc14 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6);
		}
	}

	// Function with 7 parameter(s)<para></para>
	// and 15 return values.
	public class DelayedRunFunc15<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> : DelayedRun15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
	
		public DelayedRunFunc15 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6);
		}
	}

	// Function with 7 parameter(s)<para></para>
	// and 16 return values.
	public class DelayedRunFunc16<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> : DelayedRun16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
	
		public DelayedRunFunc16 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6);
		}
	}


	// Function with 8 parameter(s)
	public class DelayedRunFunc<In0,In1,In2,In3,In4,In5,In6,In7,RT> : DelayedRun<RT> {
		private Func<In0,In1,In2,In3,In4,In5,In6,In7,RT> function;
		In0 inv0;
		In1 inv1;
		In2 inv2;
		In3 inv3;
		In4 inv4;
		In5 inv5;
		In6 inv6;
		In7 inv7;
	
		public DelayedRunFunc (Func<In0,In1,In2,In3,In4,In5,In6,In7,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			function = Function;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			thread = new Thread (DoIt);
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7);
		}
	}	// Function 
	

	// Function with 8 parameter(s)<para></para>
	// and 2 return values.
	public class DelayedRunFunc2<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1> : DelayedRun2<RT0, RT1> {
		public delegate (RT0, RT1) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
	
		public DelayedRunFunc2 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7);
		}
	}

	// Function with 8 parameter(s)<para></para>
	// and 3 return values.
	public class DelayedRunFunc3<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2> : DelayedRun3<RT0, RT1, RT2> {
		public delegate (RT0, RT1, RT2) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
	
		public DelayedRunFunc3 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7);
		}
	}

	// Function with 8 parameter(s)<para></para>
	// and 4 return values.
	public class DelayedRunFunc4<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3> : DelayedRun4<RT0, RT1, RT2, RT3> {
		public delegate (RT0, RT1, RT2, RT3) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
	
		public DelayedRunFunc4 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7);
		}
	}

	// Function with 8 parameter(s)<para></para>
	// and 5 return values.
	public class DelayedRunFunc5<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4> : DelayedRun5<RT0, RT1, RT2, RT3, RT4> {
		public delegate (RT0, RT1, RT2, RT3, RT4) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
	
		public DelayedRunFunc5 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7);
		}
	}

	// Function with 8 parameter(s)<para></para>
	// and 6 return values.
	public class DelayedRunFunc6<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5> : DelayedRun6<RT0, RT1, RT2, RT3, RT4, RT5> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
	
		public DelayedRunFunc6 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7);
		}
	}

	// Function with 8 parameter(s)<para></para>
	// and 7 return values.
	public class DelayedRunFunc7<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6> : DelayedRun7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
	
		public DelayedRunFunc7 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7);
		}
	}

	// Function with 8 parameter(s)<para></para>
	// and 8 return values.
	public class DelayedRunFunc8<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> : DelayedRun8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
	
		public DelayedRunFunc8 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7);
		}
	}

	// Function with 8 parameter(s)<para></para>
	// and 9 return values.
	public class DelayedRunFunc9<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> : DelayedRun9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
	
		public DelayedRunFunc9 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7);
		}
	}

	// Function with 8 parameter(s)<para></para>
	// and 10 return values.
	public class DelayedRunFunc10<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> : DelayedRun10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
	
		public DelayedRunFunc10 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7);
		}
	}

	// Function with 8 parameter(s)<para></para>
	// and 11 return values.
	public class DelayedRunFunc11<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> : DelayedRun11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
	
		public DelayedRunFunc11 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7);
		}
	}

	// Function with 8 parameter(s)<para></para>
	// and 12 return values.
	public class DelayedRunFunc12<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> : DelayedRun12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
	
		public DelayedRunFunc12 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7);
		}
	}

	// Function with 8 parameter(s)<para></para>
	// and 13 return values.
	public class DelayedRunFunc13<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> : DelayedRun13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
	
		public DelayedRunFunc13 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7);
		}
	}

	// Function with 8 parameter(s)<para></para>
	// and 14 return values.
	public class DelayedRunFunc14<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> : DelayedRun14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
	
		public DelayedRunFunc14 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7);
		}
	}

	// Function with 8 parameter(s)<para></para>
	// and 15 return values.
	public class DelayedRunFunc15<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> : DelayedRun15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
	
		public DelayedRunFunc15 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7);
		}
	}

	// Function with 8 parameter(s)<para></para>
	// and 16 return values.
	public class DelayedRunFunc16<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> : DelayedRun16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
	
		public DelayedRunFunc16 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7);
		}
	}


	// Function with 9 parameter(s)
	public class DelayedRunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,RT> : DelayedRun<RT> {
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
	
		public DelayedRunFunc (Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
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
			thread = new Thread (DoIt);
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8);
		}
	}	// Function 
	

	// Function with 9 parameter(s)<para></para>
	// and 2 return values.
	public class DelayedRunFunc2<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1> : DelayedRun2<RT0, RT1> {
		public delegate (RT0, RT1) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
	
		public DelayedRunFunc2 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8);
		}
	}

	// Function with 9 parameter(s)<para></para>
	// and 3 return values.
	public class DelayedRunFunc3<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2> : DelayedRun3<RT0, RT1, RT2> {
		public delegate (RT0, RT1, RT2) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
	
		public DelayedRunFunc3 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8);
		}
	}

	// Function with 9 parameter(s)<para></para>
	// and 4 return values.
	public class DelayedRunFunc4<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3> : DelayedRun4<RT0, RT1, RT2, RT3> {
		public delegate (RT0, RT1, RT2, RT3) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
	
		public DelayedRunFunc4 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8);
		}
	}

	// Function with 9 parameter(s)<para></para>
	// and 5 return values.
	public class DelayedRunFunc5<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4> : DelayedRun5<RT0, RT1, RT2, RT3, RT4> {
		public delegate (RT0, RT1, RT2, RT3, RT4) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
	
		public DelayedRunFunc5 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8);
		}
	}

	// Function with 9 parameter(s)<para></para>
	// and 6 return values.
	public class DelayedRunFunc6<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5> : DelayedRun6<RT0, RT1, RT2, RT3, RT4, RT5> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
	
		public DelayedRunFunc6 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8);
		}
	}

	// Function with 9 parameter(s)<para></para>
	// and 7 return values.
	public class DelayedRunFunc7<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6> : DelayedRun7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
	
		public DelayedRunFunc7 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8);
		}
	}

	// Function with 9 parameter(s)<para></para>
	// and 8 return values.
	public class DelayedRunFunc8<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> : DelayedRun8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
	
		public DelayedRunFunc8 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8);
		}
	}

	// Function with 9 parameter(s)<para></para>
	// and 9 return values.
	public class DelayedRunFunc9<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> : DelayedRun9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
	
		public DelayedRunFunc9 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8);
		}
	}

	// Function with 9 parameter(s)<para></para>
	// and 10 return values.
	public class DelayedRunFunc10<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> : DelayedRun10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
	
		public DelayedRunFunc10 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8);
		}
	}

	// Function with 9 parameter(s)<para></para>
	// and 11 return values.
	public class DelayedRunFunc11<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> : DelayedRun11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
	
		public DelayedRunFunc11 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8);
		}
	}

	// Function with 9 parameter(s)<para></para>
	// and 12 return values.
	public class DelayedRunFunc12<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> : DelayedRun12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
	
		public DelayedRunFunc12 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8);
		}
	}

	// Function with 9 parameter(s)<para></para>
	// and 13 return values.
	public class DelayedRunFunc13<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> : DelayedRun13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
	
		public DelayedRunFunc13 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8);
		}
	}

	// Function with 9 parameter(s)<para></para>
	// and 14 return values.
	public class DelayedRunFunc14<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> : DelayedRun14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
	
		public DelayedRunFunc14 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8);
		}
	}

	// Function with 9 parameter(s)<para></para>
	// and 15 return values.
	public class DelayedRunFunc15<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> : DelayedRun15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
	
		public DelayedRunFunc15 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8);
		}
	}

	// Function with 9 parameter(s)<para></para>
	// and 16 return values.
	public class DelayedRunFunc16<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> : DelayedRun16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
	
		public DelayedRunFunc16 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			function = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			inv6 = Inv6;
			inv7 = Inv7;
			inv8 = Inv8;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8);
		}
	}


	// Function with 10 parameter(s)
	public class DelayedRunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,RT> : DelayedRun<RT> {
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
	
		public DelayedRunFunc (Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
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
			thread = new Thread (DoIt);
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9);
		}
	}	// Function 
	

	// Function with 10 parameter(s)<para></para>
	// and 2 return values.
	public class DelayedRunFunc2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1> : DelayedRun2<RT0, RT1> {
		public delegate (RT0, RT1) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
	
		public DelayedRunFunc2 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9);
		}
	}

	// Function with 10 parameter(s)<para></para>
	// and 3 return values.
	public class DelayedRunFunc3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2> : DelayedRun3<RT0, RT1, RT2> {
		public delegate (RT0, RT1, RT2) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
	
		public DelayedRunFunc3 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9);
		}
	}

	// Function with 10 parameter(s)<para></para>
	// and 4 return values.
	public class DelayedRunFunc4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3> : DelayedRun4<RT0, RT1, RT2, RT3> {
		public delegate (RT0, RT1, RT2, RT3) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
	
		public DelayedRunFunc4 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9);
		}
	}

	// Function with 10 parameter(s)<para></para>
	// and 5 return values.
	public class DelayedRunFunc5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4> : DelayedRun5<RT0, RT1, RT2, RT3, RT4> {
		public delegate (RT0, RT1, RT2, RT3, RT4) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
	
		public DelayedRunFunc5 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9);
		}
	}

	// Function with 10 parameter(s)<para></para>
	// and 6 return values.
	public class DelayedRunFunc6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5> : DelayedRun6<RT0, RT1, RT2, RT3, RT4, RT5> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
	
		public DelayedRunFunc6 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9);
		}
	}

	// Function with 10 parameter(s)<para></para>
	// and 7 return values.
	public class DelayedRunFunc7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6> : DelayedRun7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
	
		public DelayedRunFunc7 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9);
		}
	}

	// Function with 10 parameter(s)<para></para>
	// and 8 return values.
	public class DelayedRunFunc8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> : DelayedRun8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
	
		public DelayedRunFunc8 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9);
		}
	}

	// Function with 10 parameter(s)<para></para>
	// and 9 return values.
	public class DelayedRunFunc9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> : DelayedRun9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
	
		public DelayedRunFunc9 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9);
		}
	}

	// Function with 10 parameter(s)<para></para>
	// and 10 return values.
	public class DelayedRunFunc10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> : DelayedRun10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
	
		public DelayedRunFunc10 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9);
		}
	}

	// Function with 10 parameter(s)<para></para>
	// and 11 return values.
	public class DelayedRunFunc11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> : DelayedRun11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
	
		public DelayedRunFunc11 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9);
		}
	}

	// Function with 10 parameter(s)<para></para>
	// and 12 return values.
	public class DelayedRunFunc12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> : DelayedRun12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
	
		public DelayedRunFunc12 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9);
		}
	}

	// Function with 10 parameter(s)<para></para>
	// and 13 return values.
	public class DelayedRunFunc13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> : DelayedRun13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
	
		public DelayedRunFunc13 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9);
		}
	}

	// Function with 10 parameter(s)<para></para>
	// and 14 return values.
	public class DelayedRunFunc14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> : DelayedRun14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
	
		public DelayedRunFunc14 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9);
		}
	}

	// Function with 10 parameter(s)<para></para>
	// and 15 return values.
	public class DelayedRunFunc15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> : DelayedRun15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
	
		public DelayedRunFunc15 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9);
		}
	}

	// Function with 10 parameter(s)<para></para>
	// and 16 return values.
	public class DelayedRunFunc16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> : DelayedRun16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
	
		public DelayedRunFunc16 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9);
		}
	}


	// Function with 11 parameter(s)
	public class DelayedRunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,RT> : DelayedRun<RT> {
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
	
		public DelayedRunFunc (Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
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
			thread = new Thread (DoIt);
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10);
		}
	}	// Function 
	

	// Function with 11 parameter(s)<para></para>
	// and 2 return values.
	public class DelayedRunFunc2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1> : DelayedRun2<RT0, RT1> {
		public delegate (RT0, RT1) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
	
		public DelayedRunFunc2 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10);
		}
	}

	// Function with 11 parameter(s)<para></para>
	// and 3 return values.
	public class DelayedRunFunc3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2> : DelayedRun3<RT0, RT1, RT2> {
		public delegate (RT0, RT1, RT2) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
	
		public DelayedRunFunc3 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10);
		}
	}

	// Function with 11 parameter(s)<para></para>
	// and 4 return values.
	public class DelayedRunFunc4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3> : DelayedRun4<RT0, RT1, RT2, RT3> {
		public delegate (RT0, RT1, RT2, RT3) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
	
		public DelayedRunFunc4 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10);
		}
	}

	// Function with 11 parameter(s)<para></para>
	// and 5 return values.
	public class DelayedRunFunc5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4> : DelayedRun5<RT0, RT1, RT2, RT3, RT4> {
		public delegate (RT0, RT1, RT2, RT3, RT4) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
	
		public DelayedRunFunc5 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10);
		}
	}

	// Function with 11 parameter(s)<para></para>
	// and 6 return values.
	public class DelayedRunFunc6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5> : DelayedRun6<RT0, RT1, RT2, RT3, RT4, RT5> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
	
		public DelayedRunFunc6 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10);
		}
	}

	// Function with 11 parameter(s)<para></para>
	// and 7 return values.
	public class DelayedRunFunc7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6> : DelayedRun7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
	
		public DelayedRunFunc7 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10);
		}
	}

	// Function with 11 parameter(s)<para></para>
	// and 8 return values.
	public class DelayedRunFunc8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> : DelayedRun8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
	
		public DelayedRunFunc8 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10);
		}
	}

	// Function with 11 parameter(s)<para></para>
	// and 9 return values.
	public class DelayedRunFunc9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> : DelayedRun9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
	
		public DelayedRunFunc9 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10);
		}
	}

	// Function with 11 parameter(s)<para></para>
	// and 10 return values.
	public class DelayedRunFunc10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> : DelayedRun10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
	
		public DelayedRunFunc10 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10);
		}
	}

	// Function with 11 parameter(s)<para></para>
	// and 11 return values.
	public class DelayedRunFunc11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> : DelayedRun11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
	
		public DelayedRunFunc11 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10);
		}
	}

	// Function with 11 parameter(s)<para></para>
	// and 12 return values.
	public class DelayedRunFunc12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> : DelayedRun12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
	
		public DelayedRunFunc12 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10);
		}
	}

	// Function with 11 parameter(s)<para></para>
	// and 13 return values.
	public class DelayedRunFunc13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> : DelayedRun13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
	
		public DelayedRunFunc13 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10);
		}
	}

	// Function with 11 parameter(s)<para></para>
	// and 14 return values.
	public class DelayedRunFunc14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> : DelayedRun14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
	
		public DelayedRunFunc14 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10);
		}
	}

	// Function with 11 parameter(s)<para></para>
	// and 15 return values.
	public class DelayedRunFunc15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> : DelayedRun15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
	
		public DelayedRunFunc15 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10);
		}
	}

	// Function with 11 parameter(s)<para></para>
	// and 16 return values.
	public class DelayedRunFunc16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> : DelayedRun16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
	
		public DelayedRunFunc16 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10);
		}
	}


	// Function with 12 parameter(s)
	public class DelayedRunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,RT> : DelayedRun<RT> {
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
	
		public DelayedRunFunc (Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
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
			thread = new Thread (DoIt);
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11);
		}
	}	// Function 
	

	// Function with 12 parameter(s)<para></para>
	// and 2 return values.
	public class DelayedRunFunc2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1> : DelayedRun2<RT0, RT1> {
		public delegate (RT0, RT1) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
	
		public DelayedRunFunc2 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11);
		}
	}

	// Function with 12 parameter(s)<para></para>
	// and 3 return values.
	public class DelayedRunFunc3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2> : DelayedRun3<RT0, RT1, RT2> {
		public delegate (RT0, RT1, RT2) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
	
		public DelayedRunFunc3 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11);
		}
	}

	// Function with 12 parameter(s)<para></para>
	// and 4 return values.
	public class DelayedRunFunc4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3> : DelayedRun4<RT0, RT1, RT2, RT3> {
		public delegate (RT0, RT1, RT2, RT3) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
	
		public DelayedRunFunc4 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11);
		}
	}

	// Function with 12 parameter(s)<para></para>
	// and 5 return values.
	public class DelayedRunFunc5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4> : DelayedRun5<RT0, RT1, RT2, RT3, RT4> {
		public delegate (RT0, RT1, RT2, RT3, RT4) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
	
		public DelayedRunFunc5 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11);
		}
	}

	// Function with 12 parameter(s)<para></para>
	// and 6 return values.
	public class DelayedRunFunc6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5> : DelayedRun6<RT0, RT1, RT2, RT3, RT4, RT5> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
	
		public DelayedRunFunc6 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11);
		}
	}

	// Function with 12 parameter(s)<para></para>
	// and 7 return values.
	public class DelayedRunFunc7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6> : DelayedRun7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
	
		public DelayedRunFunc7 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11);
		}
	}

	// Function with 12 parameter(s)<para></para>
	// and 8 return values.
	public class DelayedRunFunc8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> : DelayedRun8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
	
		public DelayedRunFunc8 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11);
		}
	}

	// Function with 12 parameter(s)<para></para>
	// and 9 return values.
	public class DelayedRunFunc9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> : DelayedRun9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
	
		public DelayedRunFunc9 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11);
		}
	}

	// Function with 12 parameter(s)<para></para>
	// and 10 return values.
	public class DelayedRunFunc10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> : DelayedRun10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
	
		public DelayedRunFunc10 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11);
		}
	}

	// Function with 12 parameter(s)<para></para>
	// and 11 return values.
	public class DelayedRunFunc11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> : DelayedRun11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
	
		public DelayedRunFunc11 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11);
		}
	}

	// Function with 12 parameter(s)<para></para>
	// and 12 return values.
	public class DelayedRunFunc12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> : DelayedRun12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
	
		public DelayedRunFunc12 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11);
		}
	}

	// Function with 12 parameter(s)<para></para>
	// and 13 return values.
	public class DelayedRunFunc13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> : DelayedRun13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
	
		public DelayedRunFunc13 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11);
		}
	}

	// Function with 12 parameter(s)<para></para>
	// and 14 return values.
	public class DelayedRunFunc14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> : DelayedRun14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
	
		public DelayedRunFunc14 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11);
		}
	}

	// Function with 12 parameter(s)<para></para>
	// and 15 return values.
	public class DelayedRunFunc15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> : DelayedRun15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
	
		public DelayedRunFunc15 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11);
		}
	}

	// Function with 12 parameter(s)<para></para>
	// and 16 return values.
	public class DelayedRunFunc16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> : DelayedRun16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
	
		public DelayedRunFunc16 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11);
		}
	}


	// Function with 13 parameter(s)
	public class DelayedRunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,RT> : DelayedRun<RT> {
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
	
		public DelayedRunFunc (Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
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
			thread = new Thread (DoIt);
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12);
		}
	}	// Function 
	

	// Function with 13 parameter(s)<para></para>
	// and 2 return values.
	public class DelayedRunFunc2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1> : DelayedRun2<RT0, RT1> {
		public delegate (RT0, RT1) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
	
		public DelayedRunFunc2 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12);
		}
	}

	// Function with 13 parameter(s)<para></para>
	// and 3 return values.
	public class DelayedRunFunc3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2> : DelayedRun3<RT0, RT1, RT2> {
		public delegate (RT0, RT1, RT2) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
	
		public DelayedRunFunc3 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12);
		}
	}

	// Function with 13 parameter(s)<para></para>
	// and 4 return values.
	public class DelayedRunFunc4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3> : DelayedRun4<RT0, RT1, RT2, RT3> {
		public delegate (RT0, RT1, RT2, RT3) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
	
		public DelayedRunFunc4 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12);
		}
	}

	// Function with 13 parameter(s)<para></para>
	// and 5 return values.
	public class DelayedRunFunc5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4> : DelayedRun5<RT0, RT1, RT2, RT3, RT4> {
		public delegate (RT0, RT1, RT2, RT3, RT4) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
	
		public DelayedRunFunc5 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12);
		}
	}

	// Function with 13 parameter(s)<para></para>
	// and 6 return values.
	public class DelayedRunFunc6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5> : DelayedRun6<RT0, RT1, RT2, RT3, RT4, RT5> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
	
		public DelayedRunFunc6 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12);
		}
	}

	// Function with 13 parameter(s)<para></para>
	// and 7 return values.
	public class DelayedRunFunc7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6> : DelayedRun7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
	
		public DelayedRunFunc7 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12);
		}
	}

	// Function with 13 parameter(s)<para></para>
	// and 8 return values.
	public class DelayedRunFunc8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> : DelayedRun8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
	
		public DelayedRunFunc8 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12);
		}
	}

	// Function with 13 parameter(s)<para></para>
	// and 9 return values.
	public class DelayedRunFunc9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> : DelayedRun9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
	
		public DelayedRunFunc9 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12);
		}
	}

	// Function with 13 parameter(s)<para></para>
	// and 10 return values.
	public class DelayedRunFunc10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> : DelayedRun10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
	
		public DelayedRunFunc10 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12);
		}
	}

	// Function with 13 parameter(s)<para></para>
	// and 11 return values.
	public class DelayedRunFunc11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> : DelayedRun11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
	
		public DelayedRunFunc11 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12);
		}
	}

	// Function with 13 parameter(s)<para></para>
	// and 12 return values.
	public class DelayedRunFunc12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> : DelayedRun12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
	
		public DelayedRunFunc12 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12);
		}
	}

	// Function with 13 parameter(s)<para></para>
	// and 13 return values.
	public class DelayedRunFunc13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> : DelayedRun13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
	
		public DelayedRunFunc13 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12);
		}
	}

	// Function with 13 parameter(s)<para></para>
	// and 14 return values.
	public class DelayedRunFunc14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> : DelayedRun14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
	
		public DelayedRunFunc14 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12);
		}
	}

	// Function with 13 parameter(s)<para></para>
	// and 15 return values.
	public class DelayedRunFunc15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> : DelayedRun15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
	
		public DelayedRunFunc15 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12);
		}
	}

	// Function with 13 parameter(s)<para></para>
	// and 16 return values.
	public class DelayedRunFunc16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> : DelayedRun16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
	
		public DelayedRunFunc16 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12);
		}
	}


	// Function with 14 parameter(s)
	public class DelayedRunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,RT> : DelayedRun<RT> {
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
	
		public DelayedRunFunc (Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
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
			thread = new Thread (DoIt);
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13);
		}
	}	// Function 
	

	// Function with 14 parameter(s)<para></para>
	// and 2 return values.
	public class DelayedRunFunc2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1> : DelayedRun2<RT0, RT1> {
		public delegate (RT0, RT1) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
	
		public DelayedRunFunc2 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13);
		}
	}

	// Function with 14 parameter(s)<para></para>
	// and 3 return values.
	public class DelayedRunFunc3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2> : DelayedRun3<RT0, RT1, RT2> {
		public delegate (RT0, RT1, RT2) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
	
		public DelayedRunFunc3 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13);
		}
	}

	// Function with 14 parameter(s)<para></para>
	// and 4 return values.
	public class DelayedRunFunc4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3> : DelayedRun4<RT0, RT1, RT2, RT3> {
		public delegate (RT0, RT1, RT2, RT3) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
	
		public DelayedRunFunc4 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13);
		}
	}

	// Function with 14 parameter(s)<para></para>
	// and 5 return values.
	public class DelayedRunFunc5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4> : DelayedRun5<RT0, RT1, RT2, RT3, RT4> {
		public delegate (RT0, RT1, RT2, RT3, RT4) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
	
		public DelayedRunFunc5 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13);
		}
	}

	// Function with 14 parameter(s)<para></para>
	// and 6 return values.
	public class DelayedRunFunc6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5> : DelayedRun6<RT0, RT1, RT2, RT3, RT4, RT5> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
	
		public DelayedRunFunc6 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13);
		}
	}

	// Function with 14 parameter(s)<para></para>
	// and 7 return values.
	public class DelayedRunFunc7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6> : DelayedRun7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
	
		public DelayedRunFunc7 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13);
		}
	}

	// Function with 14 parameter(s)<para></para>
	// and 8 return values.
	public class DelayedRunFunc8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> : DelayedRun8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
	
		public DelayedRunFunc8 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13);
		}
	}

	// Function with 14 parameter(s)<para></para>
	// and 9 return values.
	public class DelayedRunFunc9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> : DelayedRun9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
	
		public DelayedRunFunc9 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13);
		}
	}

	// Function with 14 parameter(s)<para></para>
	// and 10 return values.
	public class DelayedRunFunc10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> : DelayedRun10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
	
		public DelayedRunFunc10 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13);
		}
	}

	// Function with 14 parameter(s)<para></para>
	// and 11 return values.
	public class DelayedRunFunc11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> : DelayedRun11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
	
		public DelayedRunFunc11 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13);
		}
	}

	// Function with 14 parameter(s)<para></para>
	// and 12 return values.
	public class DelayedRunFunc12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> : DelayedRun12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
	
		public DelayedRunFunc12 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13);
		}
	}

	// Function with 14 parameter(s)<para></para>
	// and 13 return values.
	public class DelayedRunFunc13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> : DelayedRun13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
	
		public DelayedRunFunc13 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13);
		}
	}

	// Function with 14 parameter(s)<para></para>
	// and 14 return values.
	public class DelayedRunFunc14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> : DelayedRun14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
	
		public DelayedRunFunc14 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13);
		}
	}

	// Function with 14 parameter(s)<para></para>
	// and 15 return values.
	public class DelayedRunFunc15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> : DelayedRun15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
	
		public DelayedRunFunc15 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13);
		}
	}

	// Function with 14 parameter(s)<para></para>
	// and 16 return values.
	public class DelayedRunFunc16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> : DelayedRun16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
	
		public DelayedRunFunc16 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13);
		}
	}


	// Function with 15 parameter(s)
	public class DelayedRunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,RT> : DelayedRun<RT> {
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
	
		public DelayedRunFunc (Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
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
			thread = new Thread (DoIt);
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14);
		}
	}	// Function 
	

	// Function with 15 parameter(s)<para></para>
	// and 2 return values.
	public class DelayedRunFunc2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1> : DelayedRun2<RT0, RT1> {
		public delegate (RT0, RT1) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
	
		public DelayedRunFunc2 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14);
		}
	}

	// Function with 15 parameter(s)<para></para>
	// and 3 return values.
	public class DelayedRunFunc3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2> : DelayedRun3<RT0, RT1, RT2> {
		public delegate (RT0, RT1, RT2) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
	
		public DelayedRunFunc3 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14);
		}
	}

	// Function with 15 parameter(s)<para></para>
	// and 4 return values.
	public class DelayedRunFunc4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3> : DelayedRun4<RT0, RT1, RT2, RT3> {
		public delegate (RT0, RT1, RT2, RT3) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
	
		public DelayedRunFunc4 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14);
		}
	}

	// Function with 15 parameter(s)<para></para>
	// and 5 return values.
	public class DelayedRunFunc5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4> : DelayedRun5<RT0, RT1, RT2, RT3, RT4> {
		public delegate (RT0, RT1, RT2, RT3, RT4) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
	
		public DelayedRunFunc5 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14);
		}
	}

	// Function with 15 parameter(s)<para></para>
	// and 6 return values.
	public class DelayedRunFunc6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5> : DelayedRun6<RT0, RT1, RT2, RT3, RT4, RT5> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
	
		public DelayedRunFunc6 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14);
		}
	}

	// Function with 15 parameter(s)<para></para>
	// and 7 return values.
	public class DelayedRunFunc7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6> : DelayedRun7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
	
		public DelayedRunFunc7 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14);
		}
	}

	// Function with 15 parameter(s)<para></para>
	// and 8 return values.
	public class DelayedRunFunc8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> : DelayedRun8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
	
		public DelayedRunFunc8 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14);
		}
	}

	// Function with 15 parameter(s)<para></para>
	// and 9 return values.
	public class DelayedRunFunc9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> : DelayedRun9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
	
		public DelayedRunFunc9 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14);
		}
	}

	// Function with 15 parameter(s)<para></para>
	// and 10 return values.
	public class DelayedRunFunc10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> : DelayedRun10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
	
		public DelayedRunFunc10 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14);
		}
	}

	// Function with 15 parameter(s)<para></para>
	// and 11 return values.
	public class DelayedRunFunc11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> : DelayedRun11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
	
		public DelayedRunFunc11 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14);
		}
	}

	// Function with 15 parameter(s)<para></para>
	// and 12 return values.
	public class DelayedRunFunc12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> : DelayedRun12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
	
		public DelayedRunFunc12 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14);
		}
	}

	// Function with 15 parameter(s)<para></para>
	// and 13 return values.
	public class DelayedRunFunc13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> : DelayedRun13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
	
		public DelayedRunFunc13 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14);
		}
	}

	// Function with 15 parameter(s)<para></para>
	// and 14 return values.
	public class DelayedRunFunc14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> : DelayedRun14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
	
		public DelayedRunFunc14 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14);
		}
	}

	// Function with 15 parameter(s)<para></para>
	// and 15 return values.
	public class DelayedRunFunc15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> : DelayedRun15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
	
		public DelayedRunFunc15 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14);
		}
	}

	// Function with 15 parameter(s)<para></para>
	// and 16 return values.
	public class DelayedRunFunc16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> : DelayedRun16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
	
		public DelayedRunFunc16 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14);
		}
	}


	// Function with 16 parameter(s)
	public class DelayedRunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15,RT> : DelayedRun<RT> {
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
	
		public DelayedRunFunc (Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
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
			thread = new Thread (DoIt);
		}
		
		private void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14,inv15);
		}
	}	// Function 
	

	// Function with 16 parameter(s)<para></para>
	// and 2 return values.
	public class DelayedRunFunc2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1> : DelayedRun2<RT0, RT1> {
		public delegate (RT0, RT1) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
		private In15 inv15;
	
		public DelayedRunFunc2 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14,inv15);
		}
	}

	// Function with 16 parameter(s)<para></para>
	// and 3 return values.
	public class DelayedRunFunc3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2> : DelayedRun3<RT0, RT1, RT2> {
		public delegate (RT0, RT1, RT2) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
		private In15 inv15;
	
		public DelayedRunFunc3 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14,inv15);
		}
	}

	// Function with 16 parameter(s)<para></para>
	// and 4 return values.
	public class DelayedRunFunc4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3> : DelayedRun4<RT0, RT1, RT2, RT3> {
		public delegate (RT0, RT1, RT2, RT3) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
		private In15 inv15;
	
		public DelayedRunFunc4 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14,inv15);
		}
	}

	// Function with 16 parameter(s)<para></para>
	// and 5 return values.
	public class DelayedRunFunc5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4> : DelayedRun5<RT0, RT1, RT2, RT3, RT4> {
		public delegate (RT0, RT1, RT2, RT3, RT4) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
		private In15 inv15;
	
		public DelayedRunFunc5 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14,inv15);
		}
	}

	// Function with 16 parameter(s)<para></para>
	// and 6 return values.
	public class DelayedRunFunc6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5> : DelayedRun6<RT0, RT1, RT2, RT3, RT4, RT5> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
		private In15 inv15;
	
		public DelayedRunFunc6 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14,inv15);
		}
	}

	// Function with 16 parameter(s)<para></para>
	// and 7 return values.
	public class DelayedRunFunc7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6> : DelayedRun7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
		private In15 inv15;
	
		public DelayedRunFunc7 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14,inv15);
		}
	}

	// Function with 16 parameter(s)<para></para>
	// and 8 return values.
	public class DelayedRunFunc8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> : DelayedRun8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
		private In15 inv15;
	
		public DelayedRunFunc8 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14,inv15);
		}
	}

	// Function with 16 parameter(s)<para></para>
	// and 9 return values.
	public class DelayedRunFunc9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> : DelayedRun9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
		private In15 inv15;
	
		public DelayedRunFunc9 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14,inv15);
		}
	}

	// Function with 16 parameter(s)<para></para>
	// and 10 return values.
	public class DelayedRunFunc10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> : DelayedRun10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
		private In15 inv15;
	
		public DelayedRunFunc10 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14,inv15);
		}
	}

	// Function with 16 parameter(s)<para></para>
	// and 11 return values.
	public class DelayedRunFunc11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> : DelayedRun11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
		private In15 inv15;
	
		public DelayedRunFunc11 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14,inv15);
		}
	}

	// Function with 16 parameter(s)<para></para>
	// and 12 return values.
	public class DelayedRunFunc12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> : DelayedRun12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
		private In15 inv15;
	
		public DelayedRunFunc12 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14,inv15);
		}
	}

	// Function with 16 parameter(s)<para></para>
	// and 13 return values.
	public class DelayedRunFunc13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> : DelayedRun13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
		private In15 inv15;
	
		public DelayedRunFunc13 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14,inv15);
		}
	}

	// Function with 16 parameter(s)<para></para>
	// and 14 return values.
	public class DelayedRunFunc14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> : DelayedRun14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
		private In15 inv15;
	
		public DelayedRunFunc14 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14,inv15);
		}
	}

	// Function with 16 parameter(s)<para></para>
	// and 15 return values.
	public class DelayedRunFunc15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> : DelayedRun15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
		private In15 inv15;
	
		public DelayedRunFunc15 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14,inv15);
		}
	}

	// Function with 16 parameter(s)<para></para>
	// and 16 return values.
	public class DelayedRunFunc16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> : DelayedRun16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> {
		public delegate (RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15) RunDelegate (In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15);
		private RunDelegate function;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
		private In9 inv9;
		private In10 inv10;
		private In11 inv11;
		private In12 inv12;
		private In13 inv13;
		private In14 inv14;
		private In15 inv15;
	
		public DelayedRunFunc16 (RunDelegate Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			function = Action;
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			return_value = function (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14,inv15);
		}
	}


}	//	namespace	2019-03-01 - 16.30.38