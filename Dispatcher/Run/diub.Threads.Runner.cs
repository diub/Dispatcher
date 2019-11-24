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

		// Action: syntactic special case, since no parameter
	
		// Static Action for easy and safe call
		static public Run Action(Action Action) {
			return (new RunAction(Action));
		}	

		// Function; syntactic special case, since no parameter

		// Static Function for easy and safe call
		static public Run<RT> Func<RT>(Func<RT> Function) {
			return (new RunFunc<RT>(Function));
		}
	
		// Action with 1 parameter(s)
		// Static Action for easy and safe call
		static public Run Action<In0>(Action<In0> Function, In0 Inv0) {
			return (new RunAction<In0>(Function,Inv0));
		}
	
		// Function with 1 parameter(s)
		// Static Function for easy and safe call
		static public Run<RT> Func<In0,RT>(Func<In0,RT> Function, In0 Inv0) {
			return (new RunFunc<In0,RT>(Function, Inv0));
		}
	
		// Action with 2 parameter(s)
		// Static Action for easy and safe call
		static public Run Action<In0,In1>(Action<In0,In1> Function, In0 Inv0, In1 Inv1) {
			return (new RunAction<In0,In1>(Function,Inv0,Inv1));
		}
	
		// Function with 2 parameter(s)
		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,RT>(Func<In0,In1,RT> Function, In0 Inv0, In1 Inv1) {
			return (new RunFunc<In0,In1,RT>(Function, Inv0,Inv1));
		}
	
		// Action with 3 parameter(s)
		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2>(Action<In0,In1,In2> Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			return (new RunAction<In0,In1,In2>(Function,Inv0,Inv1,Inv2));
		}
	
		// Function with 3 parameter(s)
		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,RT>(Func<In0,In1,In2,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			return (new RunFunc<In0,In1,In2,RT>(Function, Inv0,Inv1,Inv2));
		}
	
		// Action with 4 parameter(s)
		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3>(Action<In0,In1,In2,In3> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return (new RunAction<In0,In1,In2,In3>(Function,Inv0,Inv1,Inv2,Inv3));
		}
	
		// Function with 4 parameter(s)
		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,RT>(Func<In0,In1,In2,In3,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return (new RunFunc<In0,In1,In2,In3,RT>(Function, Inv0,Inv1,Inv2,Inv3));
		}
	
		// Action with 5 parameter(s)
		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3,In4>(Action<In0,In1,In2,In3,In4> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return (new RunAction<In0,In1,In2,In3,In4>(Function,Inv0,Inv1,Inv2,Inv3,Inv4));
		}
	
		// Function with 5 parameter(s)
		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,In4,RT>(Func<In0,In1,In2,In3,In4,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return (new RunFunc<In0,In1,In2,In3,In4,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4));
		}
	
		// Action with 6 parameter(s)
		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3,In4,In5>(Action<In0,In1,In2,In3,In4,In5> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return (new RunAction<In0,In1,In2,In3,In4,In5>(Function,Inv0,Inv1,Inv2,Inv3,Inv4,Inv5));
		}
	
		// Function with 6 parameter(s)
		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,RT>(Func<In0,In1,In2,In3,In4,In5,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return (new RunFunc<In0,In1,In2,In3,In4,In5,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5));
		}
	
		// Action with 7 parameter(s)
		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3,In4,In5,In6>(Action<In0,In1,In2,In3,In4,In5,In6> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6>(Function,Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6));
		}
	
		// Function with 7 parameter(s)
		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,RT>(Func<In0,In1,In2,In3,In4,In5,In6,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return (new RunFunc<In0,In1,In2,In3,In4,In5,In6,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6));
		}
	
		// Action with 8 parameter(s)
		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7>(Action<In0,In1,In2,In3,In4,In5,In6,In7> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7>(Function,Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7));
		}
	
		// Function with 8 parameter(s)
		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return (new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7));
		}
	
		// Action with 9 parameter(s)
		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7,In8>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8>(Function,Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8));
		}
	
		// Function with 9 parameter(s)
		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return (new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8));
		}
	
		// Action with 10 parameter(s)
		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9>(Function,Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9));
		}
	
		// Function with 10 parameter(s)
		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return (new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9));
		}
	
		// Action with 11 parameter(s)
		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10>(Function,Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10));
		}
	
		// Function with 11 parameter(s)
		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return (new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10));
		}
	
		// Action with 12 parameter(s)
		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11>(Function,Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11));
		}
	
		// Function with 12 parameter(s)
		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return (new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11));
		}
	
		// Action with 13 parameter(s)
		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12>(Function,Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12));
		}
	
		// Function with 13 parameter(s)
		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return (new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12));
		}
	
		// Action with 14 parameter(s)
		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13>(Function,Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13));
		}
	
		// Function with 14 parameter(s)
		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			return (new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13));
		}
	
		// Action with 15 parameter(s)
		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14>(Function,Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14));
		}
	
		// Function with 15 parameter(s)
		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			return (new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14));
		}
	
		// Action with 16 parameter(s)
		// Static Action for easy and safe call
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15>(Function,Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14,Inv15));
		}
	
		// Function with 16 parameter(s)
		// Static Function for easy and safe call
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			return (new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14,Inv15));
		}
	
	}
}	//	namespace	2019-03-01 - 16.30.38