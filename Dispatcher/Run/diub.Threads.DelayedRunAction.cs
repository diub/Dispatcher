// 
// Run - © Copyright diub - Dipl.-Ing. Uwe Barth - 2019-03-03
// 
// Allows you to start almost any function directly in its own thread and retrieve the result synchronized later.
//
using diub.Threads;
using System;
using System.Threading;

namespace diub.Threads {

/// <summary>
/// Erlaubt es nahezu beliebige Funktionen direkt in einem eigenen Thread zu starten und das Ergebnis später
/// synchronisiert abzurufen.
/// </summary>


	// Action with 1 parameter(s)
	public class DelayedRunAction<In0> : DelayedRun {
		private Action<In0> action;
		private In0 inv0;
	
		public DelayedRunAction (Action<In0> Action, In0 Inv0) {
			action = Action;
			inv0 = Inv0;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			action (inv0);
		}
	}	// Action

	// Action with 2 parameter(s)
	public class DelayedRunAction<In0,In1> : DelayedRun {
		private Action<In0,In1> action;
		private In0 inv0;
		private In1 inv1;
	
		public DelayedRunAction (Action<In0,In1> Action, In0 Inv0, In1 Inv1) {
			action = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			action (inv0,inv1);
		}
	}	// Action

	// Action with 3 parameter(s)
	public class DelayedRunAction<In0,In1,In2> : DelayedRun {
		private Action<In0,In1,In2> action;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
	
		public DelayedRunAction (Action<In0,In1,In2> Action, In0 Inv0, In1 Inv1, In2 Inv2) {
			action = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2);
		}
	}	// Action

	// Action with 4 parameter(s)
	public class DelayedRunAction<In0,In1,In2,In3> : DelayedRun {
		private Action<In0,In1,In2,In3> action;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
	
		public DelayedRunAction (Action<In0,In1,In2,In3> Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			action = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2,inv3);
		}
	}	// Action

	// Action with 5 parameter(s)
	public class DelayedRunAction<In0,In1,In2,In3,In4> : DelayedRun {
		private Action<In0,In1,In2,In3,In4> action;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
	
		public DelayedRunAction (Action<In0,In1,In2,In3,In4> Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			action = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2,inv3,inv4);
		}
	}	// Action

	// Action with 6 parameter(s)
	public class DelayedRunAction<In0,In1,In2,In3,In4,In5> : DelayedRun {
		private Action<In0,In1,In2,In3,In4,In5> action;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
	
		public DelayedRunAction (Action<In0,In1,In2,In3,In4,In5> Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			action = Action;
			inv0 = Inv0;
			inv1 = Inv1;
			inv2 = Inv2;
			inv3 = Inv3;
			inv4 = Inv4;
			inv5 = Inv5;
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2,inv3,inv4,inv5);
		}
	}	// Action

	// Action with 7 parameter(s)
	public class DelayedRunAction<In0,In1,In2,In3,In4,In5,In6> : DelayedRun {
		private Action<In0,In1,In2,In3,In4,In5,In6> action;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
	
		public DelayedRunAction (Action<In0,In1,In2,In3,In4,In5,In6> Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			action = Action;
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
			action (inv0,inv1,inv2,inv3,inv4,inv5,inv6);
		}
	}	// Action

	// Action with 8 parameter(s)
	public class DelayedRunAction<In0,In1,In2,In3,In4,In5,In6,In7> : DelayedRun {
		private Action<In0,In1,In2,In3,In4,In5,In6,In7> action;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
	
		public DelayedRunAction (Action<In0,In1,In2,In3,In4,In5,In6,In7> Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			action = Action;
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
			action (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7);
		}
	}	// Action

	// Action with 9 parameter(s)
	public class DelayedRunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8> : DelayedRun {
		private Action<In0,In1,In2,In3,In4,In5,In6,In7,In8> action;
		private In0 inv0;
		private In1 inv1;
		private In2 inv2;
		private In3 inv3;
		private In4 inv4;
		private In5 inv5;
		private In6 inv6;
		private In7 inv7;
		private In8 inv8;
	
		public DelayedRunAction (Action<In0,In1,In2,In3,In4,In5,In6,In7,In8> Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8);
		}
	}	// Action

	// Action with 10 parameter(s)
	public class DelayedRunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9> : DelayedRun {
		private Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9> action;
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
	
		public DelayedRunAction (Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9> Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9);
		}
	}	// Action

	// Action with 11 parameter(s)
	public class DelayedRunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10> : DelayedRun {
		private Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10> action;
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
	
		public DelayedRunAction (Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10> Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10);
		}
	}	// Action

	// Action with 12 parameter(s)
	public class DelayedRunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11> : DelayedRun {
		private Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11> action;
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
	
		public DelayedRunAction (Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11> Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11);
		}
	}	// Action

	// Action with 13 parameter(s)
	public class DelayedRunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12> : DelayedRun {
		private Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12> action;
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
	
		public DelayedRunAction (Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12> Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12);
		}
	}	// Action

	// Action with 14 parameter(s)
	public class DelayedRunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13> : DelayedRun {
		private Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13> action;
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
	
		public DelayedRunAction (Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13> Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13);
		}
	}	// Action

	// Action with 15 parameter(s)
	public class DelayedRunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14> : DelayedRun {
		private Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14> action;
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
	
		public DelayedRunAction (Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14> Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14);
		}
	}	// Action

	// Action with 16 parameter(s)
	public class DelayedRunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15> : DelayedRun {
		private Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15> action;
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
	
		public DelayedRunAction (Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15> Action, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
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
			thread = new Thread (DoIt);
		}
		
		public void DoIt () {
			action (inv0,inv1,inv2,inv3,inv4,inv5,inv6,inv7,inv8,inv9,inv10,inv11,inv12,inv13,inv14,inv15);
		}
	}	// Action


}	//	namespace	2019-03-01 - 16.30.38