// 
// Runner - © Copyright diub - Dipl.-Ing. Uwe Barth - 2019-03-03
// Updated: 2021-03-31
// 
// Allows you to start almost any function directly in its own thread and retrieve the result synchronized later.
//
using System;
using System.Threading;

using diub.Threads;

namespace diub.Threads {
		
	/// <summary>
	/// Erlaubt es nahezu beliebige Funktionen direkt in einem eigenen Thread zu starten und das Ergebnis später
	/// synchronisiert abzurufen.
	/// </summary>
	public partial class Runner {

		/// <summary>
		/// Action: syntactic special case, since no parameter.<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public Run Action(Action Action) {
			return (new RunAction(Action));
		}	

		/// <summary>
		/// Action: syntactic special case, since no parameter.<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public DelayedRun DelayedAction(Action Action) {
			return (new DelayedRunAction(Action));
		}	

		/// <summary>
		/// Function; syntactic special case, since no parameter.<para></para>
		// Static Function for easy and safe call
		/// </summary>
		static public Run<RT> Func<RT>(Func<RT> Function) {
			return (new RunFunc<RT>(Function));
		}
	
		/// <summary>
		/// Function; syntactic special case, since no parameter.<para></para>
		// Static Function for easy and safe call
		/// </summary>
		static public DelayedRun<RT> DelayedFunc<RT>(Func<RT> Function) {
			return (new DelayedRunFunc<RT>(Function));
		}

		/// <summary>
		/// Action with 1 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public Run Action<In0>(Action<In0> Function, In0 Inv0) {
			return (new RunAction<In0>(Function, Inv0));
		}
	
		/// <summary>
		/// Action with 1 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public DelayedRun DelayedAction<In0>(Action<In0> Function, In0 Inv0) {
			return (new DelayedRunAction<In0>(Function, Inv0));
		}
	
		/// <summary>
		/// Function with 1 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run<RT> Func<In0,RT>(Func<In0,RT> Function, In0 Inv0) {
			return new RunFunc<In0,RT>(Function, Inv0);
		}

		/// <summary>
		/// Function with 1 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public DelayedRun<RT> DelayedFunc<In0,RT>(Func<In0,RT> Function, In0 Inv0) {
			return new DelayedRunFunc<In0,RT>(Function, Inv0);
		}

		/// <summary>
		/// Function with 1 parameter(s)
		/// and 2 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run2<RT0, RT1> Func2<In0, RT0, RT1> (RunFunc2<In0, RT0, RT1>.RunDelegate Function, In0 Inv0) {
			return new RunFunc2<In0, RT0, RT1> (Function, Inv0);
		}

		/// <summary>
		/// Function with 1 parameter(s)
		/// and 3 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run3<RT0, RT1, RT2> Func3<In0, RT0, RT1, RT2> (RunFunc3<In0, RT0, RT1, RT2>.RunDelegate Function, In0 Inv0) {
			return new RunFunc3<In0, RT0, RT1, RT2> (Function, Inv0);
		}

		/// <summary>
		/// Function with 1 parameter(s)
		/// and 4 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run4<RT0, RT1, RT2, RT3> Func4<In0, RT0, RT1, RT2, RT3> (RunFunc4<In0, RT0, RT1, RT2, RT3>.RunDelegate Function, In0 Inv0) {
			return new RunFunc4<In0, RT0, RT1, RT2, RT3> (Function, Inv0);
		}

		/// <summary>
		/// Function with 1 parameter(s)
		/// and 5 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run5<RT0, RT1, RT2, RT3, RT4> Func5<In0, RT0, RT1, RT2, RT3, RT4> (RunFunc5<In0, RT0, RT1, RT2, RT3, RT4>.RunDelegate Function, In0 Inv0) {
			return new RunFunc5<In0, RT0, RT1, RT2, RT3, RT4> (Function, Inv0);
		}

		/// <summary>
		/// Function with 1 parameter(s)
		/// and 6 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run6<RT0, RT1, RT2, RT3, RT4, RT5> Func6<In0, RT0, RT1, RT2, RT3, RT4, RT5> (RunFunc6<In0, RT0, RT1, RT2, RT3, RT4, RT5>.RunDelegate Function, In0 Inv0) {
			return new RunFunc6<In0, RT0, RT1, RT2, RT3, RT4, RT5> (Function, Inv0);
		}

		/// <summary>
		/// Function with 1 parameter(s)
		/// and 7 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> Func7<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (RunFunc7<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6>.RunDelegate Function, In0 Inv0) {
			return new RunFunc7<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (Function, Inv0);
		}

		/// <summary>
		/// Function with 1 parameter(s)
		/// and 8 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> Func8<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (RunFunc8<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7>.RunDelegate Function, In0 Inv0) {
			return new RunFunc8<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (Function, Inv0);
		}

		/// <summary>
		/// Function with 1 parameter(s)
		/// and 9 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> Func9<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (RunFunc9<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8>.RunDelegate Function, In0 Inv0) {
			return new RunFunc9<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (Function, Inv0);
		}

		/// <summary>
		/// Function with 1 parameter(s)
		/// and 10 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> Func10<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (RunFunc10<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9>.RunDelegate Function, In0 Inv0) {
			return new RunFunc10<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (Function, Inv0);
		}

		/// <summary>
		/// Function with 1 parameter(s)
		/// and 11 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> Func11<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (RunFunc11<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10>.RunDelegate Function, In0 Inv0) {
			return new RunFunc11<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (Function, Inv0);
		}

		/// <summary>
		/// Function with 1 parameter(s)
		/// and 12 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> Func12<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (RunFunc12<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11>.RunDelegate Function, In0 Inv0) {
			return new RunFunc12<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (Function, Inv0);
		}

		/// <summary>
		/// Function with 1 parameter(s)
		/// and 13 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> Func13<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (RunFunc13<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12>.RunDelegate Function, In0 Inv0) {
			return new RunFunc13<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (Function, Inv0);
		}

		/// <summary>
		/// Function with 1 parameter(s)
		/// and 14 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> Func14<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (RunFunc14<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13>.RunDelegate Function, In0 Inv0) {
			return new RunFunc14<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (Function, Inv0);
		}

		/// <summary>
		/// Function with 1 parameter(s)
		/// and 15 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> Func15<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (RunFunc15<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14>.RunDelegate Function, In0 Inv0) {
			return new RunFunc15<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (Function, Inv0);
		}

		/// <summary>
		/// Function with 1 parameter(s)
		/// and 16 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> Func16<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (RunFunc16<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15>.RunDelegate Function, In0 Inv0) {
			return new RunFunc16<In0, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (Function, Inv0);
		}
	
		/// <summary>
		/// Action with 2 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public Run Action<In0,In1>(Action<In0,In1> Function, In0 Inv0, In1 Inv1) {
			return (new RunAction<In0,In1>(Function, Inv0,Inv1));
		}
	
		/// <summary>
		/// Action with 2 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public DelayedRun DelayedAction<In0,In1>(Action<In0,In1> Function, In0 Inv0, In1 Inv1) {
			return (new DelayedRunAction<In0,In1>(Function, Inv0,Inv1));
		}
	
		/// <summary>
		/// Function with 2 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run<RT> Func<In0,In1,RT>(Func<In0,In1,RT> Function, In0 Inv0, In1 Inv1) {
			return new RunFunc<In0,In1,RT>(Function, Inv0,Inv1);
		}

		/// <summary>
		/// Function with 2 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public DelayedRun<RT> DelayedFunc<In0,In1,RT>(Func<In0,In1,RT> Function, In0 Inv0, In1 Inv1) {
			return new DelayedRunFunc<In0,In1,RT>(Function, Inv0,Inv1);
		}

		/// <summary>
		/// Function with 2 parameter(s)
		/// and 2 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run2<RT0, RT1> Func2<In0,In1, RT0, RT1> (RunFunc2<In0,In1, RT0, RT1>.RunDelegate Function, In0 Inv0, In1 Inv1) {
			return new RunFunc2<In0,In1, RT0, RT1> (Function, Inv0,Inv1);
		}

		/// <summary>
		/// Function with 2 parameter(s)
		/// and 3 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run3<RT0, RT1, RT2> Func3<In0,In1, RT0, RT1, RT2> (RunFunc3<In0,In1, RT0, RT1, RT2>.RunDelegate Function, In0 Inv0, In1 Inv1) {
			return new RunFunc3<In0,In1, RT0, RT1, RT2> (Function, Inv0,Inv1);
		}

		/// <summary>
		/// Function with 2 parameter(s)
		/// and 4 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run4<RT0, RT1, RT2, RT3> Func4<In0,In1, RT0, RT1, RT2, RT3> (RunFunc4<In0,In1, RT0, RT1, RT2, RT3>.RunDelegate Function, In0 Inv0, In1 Inv1) {
			return new RunFunc4<In0,In1, RT0, RT1, RT2, RT3> (Function, Inv0,Inv1);
		}

		/// <summary>
		/// Function with 2 parameter(s)
		/// and 5 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run5<RT0, RT1, RT2, RT3, RT4> Func5<In0,In1, RT0, RT1, RT2, RT3, RT4> (RunFunc5<In0,In1, RT0, RT1, RT2, RT3, RT4>.RunDelegate Function, In0 Inv0, In1 Inv1) {
			return new RunFunc5<In0,In1, RT0, RT1, RT2, RT3, RT4> (Function, Inv0,Inv1);
		}

		/// <summary>
		/// Function with 2 parameter(s)
		/// and 6 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run6<RT0, RT1, RT2, RT3, RT4, RT5> Func6<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5> (RunFunc6<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5>.RunDelegate Function, In0 Inv0, In1 Inv1) {
			return new RunFunc6<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5> (Function, Inv0,Inv1);
		}

		/// <summary>
		/// Function with 2 parameter(s)
		/// and 7 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> Func7<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (RunFunc7<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6>.RunDelegate Function, In0 Inv0, In1 Inv1) {
			return new RunFunc7<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (Function, Inv0,Inv1);
		}

		/// <summary>
		/// Function with 2 parameter(s)
		/// and 8 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> Func8<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (RunFunc8<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7>.RunDelegate Function, In0 Inv0, In1 Inv1) {
			return new RunFunc8<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (Function, Inv0,Inv1);
		}

		/// <summary>
		/// Function with 2 parameter(s)
		/// and 9 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> Func9<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (RunFunc9<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8>.RunDelegate Function, In0 Inv0, In1 Inv1) {
			return new RunFunc9<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (Function, Inv0,Inv1);
		}

		/// <summary>
		/// Function with 2 parameter(s)
		/// and 10 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> Func10<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (RunFunc10<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9>.RunDelegate Function, In0 Inv0, In1 Inv1) {
			return new RunFunc10<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (Function, Inv0,Inv1);
		}

		/// <summary>
		/// Function with 2 parameter(s)
		/// and 11 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> Func11<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (RunFunc11<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10>.RunDelegate Function, In0 Inv0, In1 Inv1) {
			return new RunFunc11<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (Function, Inv0,Inv1);
		}

		/// <summary>
		/// Function with 2 parameter(s)
		/// and 12 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> Func12<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (RunFunc12<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11>.RunDelegate Function, In0 Inv0, In1 Inv1) {
			return new RunFunc12<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (Function, Inv0,Inv1);
		}

		/// <summary>
		/// Function with 2 parameter(s)
		/// and 13 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> Func13<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (RunFunc13<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12>.RunDelegate Function, In0 Inv0, In1 Inv1) {
			return new RunFunc13<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (Function, Inv0,Inv1);
		}

		/// <summary>
		/// Function with 2 parameter(s)
		/// and 14 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> Func14<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (RunFunc14<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13>.RunDelegate Function, In0 Inv0, In1 Inv1) {
			return new RunFunc14<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (Function, Inv0,Inv1);
		}

		/// <summary>
		/// Function with 2 parameter(s)
		/// and 15 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> Func15<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (RunFunc15<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14>.RunDelegate Function, In0 Inv0, In1 Inv1) {
			return new RunFunc15<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (Function, Inv0,Inv1);
		}

		/// <summary>
		/// Function with 2 parameter(s)
		/// and 16 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> Func16<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (RunFunc16<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15>.RunDelegate Function, In0 Inv0, In1 Inv1) {
			return new RunFunc16<In0,In1, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (Function, Inv0,Inv1);
		}
	
		/// <summary>
		/// Action with 3 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public Run Action<In0,In1,In2>(Action<In0,In1,In2> Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			return (new RunAction<In0,In1,In2>(Function, Inv0,Inv1,Inv2));
		}
	
		/// <summary>
		/// Action with 3 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public DelayedRun DelayedAction<In0,In1,In2>(Action<In0,In1,In2> Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			return (new DelayedRunAction<In0,In1,In2>(Function, Inv0,Inv1,Inv2));
		}
	
		/// <summary>
		/// Function with 3 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run<RT> Func<In0,In1,In2,RT>(Func<In0,In1,In2,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			return new RunFunc<In0,In1,In2,RT>(Function, Inv0,Inv1,Inv2);
		}

		/// <summary>
		/// Function with 3 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public DelayedRun<RT> DelayedFunc<In0,In1,In2,RT>(Func<In0,In1,In2,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			return new DelayedRunFunc<In0,In1,In2,RT>(Function, Inv0,Inv1,Inv2);
		}

		/// <summary>
		/// Function with 3 parameter(s)
		/// and 2 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run2<RT0, RT1> Func2<In0,In1,In2, RT0, RT1> (RunFunc2<In0,In1,In2, RT0, RT1>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			return new RunFunc2<In0,In1,In2, RT0, RT1> (Function, Inv0,Inv1,Inv2);
		}

		/// <summary>
		/// Function with 3 parameter(s)
		/// and 3 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run3<RT0, RT1, RT2> Func3<In0,In1,In2, RT0, RT1, RT2> (RunFunc3<In0,In1,In2, RT0, RT1, RT2>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			return new RunFunc3<In0,In1,In2, RT0, RT1, RT2> (Function, Inv0,Inv1,Inv2);
		}

		/// <summary>
		/// Function with 3 parameter(s)
		/// and 4 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run4<RT0, RT1, RT2, RT3> Func4<In0,In1,In2, RT0, RT1, RT2, RT3> (RunFunc4<In0,In1,In2, RT0, RT1, RT2, RT3>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			return new RunFunc4<In0,In1,In2, RT0, RT1, RT2, RT3> (Function, Inv0,Inv1,Inv2);
		}

		/// <summary>
		/// Function with 3 parameter(s)
		/// and 5 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run5<RT0, RT1, RT2, RT3, RT4> Func5<In0,In1,In2, RT0, RT1, RT2, RT3, RT4> (RunFunc5<In0,In1,In2, RT0, RT1, RT2, RT3, RT4>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			return new RunFunc5<In0,In1,In2, RT0, RT1, RT2, RT3, RT4> (Function, Inv0,Inv1,Inv2);
		}

		/// <summary>
		/// Function with 3 parameter(s)
		/// and 6 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run6<RT0, RT1, RT2, RT3, RT4, RT5> Func6<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5> (RunFunc6<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			return new RunFunc6<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5> (Function, Inv0,Inv1,Inv2);
		}

		/// <summary>
		/// Function with 3 parameter(s)
		/// and 7 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> Func7<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (RunFunc7<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			return new RunFunc7<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (Function, Inv0,Inv1,Inv2);
		}

		/// <summary>
		/// Function with 3 parameter(s)
		/// and 8 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> Func8<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (RunFunc8<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			return new RunFunc8<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (Function, Inv0,Inv1,Inv2);
		}

		/// <summary>
		/// Function with 3 parameter(s)
		/// and 9 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> Func9<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (RunFunc9<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			return new RunFunc9<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (Function, Inv0,Inv1,Inv2);
		}

		/// <summary>
		/// Function with 3 parameter(s)
		/// and 10 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> Func10<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (RunFunc10<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			return new RunFunc10<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (Function, Inv0,Inv1,Inv2);
		}

		/// <summary>
		/// Function with 3 parameter(s)
		/// and 11 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> Func11<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (RunFunc11<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			return new RunFunc11<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (Function, Inv0,Inv1,Inv2);
		}

		/// <summary>
		/// Function with 3 parameter(s)
		/// and 12 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> Func12<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (RunFunc12<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			return new RunFunc12<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (Function, Inv0,Inv1,Inv2);
		}

		/// <summary>
		/// Function with 3 parameter(s)
		/// and 13 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> Func13<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (RunFunc13<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			return new RunFunc13<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (Function, Inv0,Inv1,Inv2);
		}

		/// <summary>
		/// Function with 3 parameter(s)
		/// and 14 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> Func14<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (RunFunc14<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			return new RunFunc14<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (Function, Inv0,Inv1,Inv2);
		}

		/// <summary>
		/// Function with 3 parameter(s)
		/// and 15 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> Func15<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (RunFunc15<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			return new RunFunc15<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (Function, Inv0,Inv1,Inv2);
		}

		/// <summary>
		/// Function with 3 parameter(s)
		/// and 16 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> Func16<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (RunFunc16<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2) {
			return new RunFunc16<In0,In1,In2, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (Function, Inv0,Inv1,Inv2);
		}
	
		/// <summary>
		/// Action with 4 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public Run Action<In0,In1,In2,In3>(Action<In0,In1,In2,In3> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return (new RunAction<In0,In1,In2,In3>(Function, Inv0,Inv1,Inv2,Inv3));
		}
	
		/// <summary>
		/// Action with 4 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public DelayedRun DelayedAction<In0,In1,In2,In3>(Action<In0,In1,In2,In3> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return (new DelayedRunAction<In0,In1,In2,In3>(Function, Inv0,Inv1,Inv2,Inv3));
		}
	
		/// <summary>
		/// Function with 4 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run<RT> Func<In0,In1,In2,In3,RT>(Func<In0,In1,In2,In3,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return new RunFunc<In0,In1,In2,In3,RT>(Function, Inv0,Inv1,Inv2,Inv3);
		}

		/// <summary>
		/// Function with 4 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public DelayedRun<RT> DelayedFunc<In0,In1,In2,In3,RT>(Func<In0,In1,In2,In3,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return new DelayedRunFunc<In0,In1,In2,In3,RT>(Function, Inv0,Inv1,Inv2,Inv3);
		}

		/// <summary>
		/// Function with 4 parameter(s)
		/// and 2 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run2<RT0, RT1> Func2<In0,In1,In2,In3, RT0, RT1> (RunFunc2<In0,In1,In2,In3, RT0, RT1>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return new RunFunc2<In0,In1,In2,In3, RT0, RT1> (Function, Inv0,Inv1,Inv2,Inv3);
		}

		/// <summary>
		/// Function with 4 parameter(s)
		/// and 3 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run3<RT0, RT1, RT2> Func3<In0,In1,In2,In3, RT0, RT1, RT2> (RunFunc3<In0,In1,In2,In3, RT0, RT1, RT2>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return new RunFunc3<In0,In1,In2,In3, RT0, RT1, RT2> (Function, Inv0,Inv1,Inv2,Inv3);
		}

		/// <summary>
		/// Function with 4 parameter(s)
		/// and 4 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run4<RT0, RT1, RT2, RT3> Func4<In0,In1,In2,In3, RT0, RT1, RT2, RT3> (RunFunc4<In0,In1,In2,In3, RT0, RT1, RT2, RT3>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return new RunFunc4<In0,In1,In2,In3, RT0, RT1, RT2, RT3> (Function, Inv0,Inv1,Inv2,Inv3);
		}

		/// <summary>
		/// Function with 4 parameter(s)
		/// and 5 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run5<RT0, RT1, RT2, RT3, RT4> Func5<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4> (RunFunc5<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return new RunFunc5<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4> (Function, Inv0,Inv1,Inv2,Inv3);
		}

		/// <summary>
		/// Function with 4 parameter(s)
		/// and 6 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run6<RT0, RT1, RT2, RT3, RT4, RT5> Func6<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5> (RunFunc6<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return new RunFunc6<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5> (Function, Inv0,Inv1,Inv2,Inv3);
		}

		/// <summary>
		/// Function with 4 parameter(s)
		/// and 7 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> Func7<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (RunFunc7<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return new RunFunc7<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (Function, Inv0,Inv1,Inv2,Inv3);
		}

		/// <summary>
		/// Function with 4 parameter(s)
		/// and 8 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> Func8<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (RunFunc8<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return new RunFunc8<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (Function, Inv0,Inv1,Inv2,Inv3);
		}

		/// <summary>
		/// Function with 4 parameter(s)
		/// and 9 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> Func9<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (RunFunc9<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return new RunFunc9<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (Function, Inv0,Inv1,Inv2,Inv3);
		}

		/// <summary>
		/// Function with 4 parameter(s)
		/// and 10 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> Func10<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (RunFunc10<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return new RunFunc10<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (Function, Inv0,Inv1,Inv2,Inv3);
		}

		/// <summary>
		/// Function with 4 parameter(s)
		/// and 11 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> Func11<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (RunFunc11<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return new RunFunc11<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (Function, Inv0,Inv1,Inv2,Inv3);
		}

		/// <summary>
		/// Function with 4 parameter(s)
		/// and 12 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> Func12<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (RunFunc12<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return new RunFunc12<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (Function, Inv0,Inv1,Inv2,Inv3);
		}

		/// <summary>
		/// Function with 4 parameter(s)
		/// and 13 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> Func13<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (RunFunc13<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return new RunFunc13<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (Function, Inv0,Inv1,Inv2,Inv3);
		}

		/// <summary>
		/// Function with 4 parameter(s)
		/// and 14 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> Func14<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (RunFunc14<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return new RunFunc14<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (Function, Inv0,Inv1,Inv2,Inv3);
		}

		/// <summary>
		/// Function with 4 parameter(s)
		/// and 15 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> Func15<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (RunFunc15<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return new RunFunc15<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (Function, Inv0,Inv1,Inv2,Inv3);
		}

		/// <summary>
		/// Function with 4 parameter(s)
		/// and 16 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> Func16<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (RunFunc16<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			return new RunFunc16<In0,In1,In2,In3, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (Function, Inv0,Inv1,Inv2,Inv3);
		}
	
		/// <summary>
		/// Action with 5 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public Run Action<In0,In1,In2,In3,In4>(Action<In0,In1,In2,In3,In4> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return (new RunAction<In0,In1,In2,In3,In4>(Function, Inv0,Inv1,Inv2,Inv3,Inv4));
		}
	
		/// <summary>
		/// Action with 5 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public DelayedRun DelayedAction<In0,In1,In2,In3,In4>(Action<In0,In1,In2,In3,In4> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return (new DelayedRunAction<In0,In1,In2,In3,In4>(Function, Inv0,Inv1,Inv2,Inv3,Inv4));
		}
	
		/// <summary>
		/// Function with 5 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run<RT> Func<In0,In1,In2,In3,In4,RT>(Func<In0,In1,In2,In3,In4,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return new RunFunc<In0,In1,In2,In3,In4,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4);
		}

		/// <summary>
		/// Function with 5 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public DelayedRun<RT> DelayedFunc<In0,In1,In2,In3,In4,RT>(Func<In0,In1,In2,In3,In4,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return new DelayedRunFunc<In0,In1,In2,In3,In4,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4);
		}

		/// <summary>
		/// Function with 5 parameter(s)
		/// and 2 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run2<RT0, RT1> Func2<In0,In1,In2,In3,In4, RT0, RT1> (RunFunc2<In0,In1,In2,In3,In4, RT0, RT1>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return new RunFunc2<In0,In1,In2,In3,In4, RT0, RT1> (Function, Inv0,Inv1,Inv2,Inv3,Inv4);
		}

		/// <summary>
		/// Function with 5 parameter(s)
		/// and 3 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run3<RT0, RT1, RT2> Func3<In0,In1,In2,In3,In4, RT0, RT1, RT2> (RunFunc3<In0,In1,In2,In3,In4, RT0, RT1, RT2>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return new RunFunc3<In0,In1,In2,In3,In4, RT0, RT1, RT2> (Function, Inv0,Inv1,Inv2,Inv3,Inv4);
		}

		/// <summary>
		/// Function with 5 parameter(s)
		/// and 4 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run4<RT0, RT1, RT2, RT3> Func4<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3> (RunFunc4<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return new RunFunc4<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3> (Function, Inv0,Inv1,Inv2,Inv3,Inv4);
		}

		/// <summary>
		/// Function with 5 parameter(s)
		/// and 5 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run5<RT0, RT1, RT2, RT3, RT4> Func5<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4> (RunFunc5<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return new RunFunc5<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4> (Function, Inv0,Inv1,Inv2,Inv3,Inv4);
		}

		/// <summary>
		/// Function with 5 parameter(s)
		/// and 6 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run6<RT0, RT1, RT2, RT3, RT4, RT5> Func6<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5> (RunFunc6<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return new RunFunc6<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5> (Function, Inv0,Inv1,Inv2,Inv3,Inv4);
		}

		/// <summary>
		/// Function with 5 parameter(s)
		/// and 7 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> Func7<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (RunFunc7<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return new RunFunc7<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (Function, Inv0,Inv1,Inv2,Inv3,Inv4);
		}

		/// <summary>
		/// Function with 5 parameter(s)
		/// and 8 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> Func8<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (RunFunc8<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return new RunFunc8<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (Function, Inv0,Inv1,Inv2,Inv3,Inv4);
		}

		/// <summary>
		/// Function with 5 parameter(s)
		/// and 9 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> Func9<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (RunFunc9<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return new RunFunc9<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (Function, Inv0,Inv1,Inv2,Inv3,Inv4);
		}

		/// <summary>
		/// Function with 5 parameter(s)
		/// and 10 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> Func10<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (RunFunc10<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return new RunFunc10<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (Function, Inv0,Inv1,Inv2,Inv3,Inv4);
		}

		/// <summary>
		/// Function with 5 parameter(s)
		/// and 11 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> Func11<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (RunFunc11<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return new RunFunc11<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (Function, Inv0,Inv1,Inv2,Inv3,Inv4);
		}

		/// <summary>
		/// Function with 5 parameter(s)
		/// and 12 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> Func12<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (RunFunc12<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return new RunFunc12<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (Function, Inv0,Inv1,Inv2,Inv3,Inv4);
		}

		/// <summary>
		/// Function with 5 parameter(s)
		/// and 13 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> Func13<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (RunFunc13<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return new RunFunc13<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (Function, Inv0,Inv1,Inv2,Inv3,Inv4);
		}

		/// <summary>
		/// Function with 5 parameter(s)
		/// and 14 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> Func14<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (RunFunc14<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return new RunFunc14<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (Function, Inv0,Inv1,Inv2,Inv3,Inv4);
		}

		/// <summary>
		/// Function with 5 parameter(s)
		/// and 15 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> Func15<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (RunFunc15<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return new RunFunc15<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (Function, Inv0,Inv1,Inv2,Inv3,Inv4);
		}

		/// <summary>
		/// Function with 5 parameter(s)
		/// and 16 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> Func16<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (RunFunc16<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			return new RunFunc16<In0,In1,In2,In3,In4, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (Function, Inv0,Inv1,Inv2,Inv3,Inv4);
		}
	
		/// <summary>
		/// Action with 6 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public Run Action<In0,In1,In2,In3,In4,In5>(Action<In0,In1,In2,In3,In4,In5> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return (new RunAction<In0,In1,In2,In3,In4,In5>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5));
		}
	
		/// <summary>
		/// Action with 6 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public DelayedRun DelayedAction<In0,In1,In2,In3,In4,In5>(Action<In0,In1,In2,In3,In4,In5> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return (new DelayedRunAction<In0,In1,In2,In3,In4,In5>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5));
		}
	
		/// <summary>
		/// Function with 6 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,RT>(Func<In0,In1,In2,In3,In4,In5,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return new RunFunc<In0,In1,In2,In3,In4,In5,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5);
		}

		/// <summary>
		/// Function with 6 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public DelayedRun<RT> DelayedFunc<In0,In1,In2,In3,In4,In5,RT>(Func<In0,In1,In2,In3,In4,In5,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return new DelayedRunFunc<In0,In1,In2,In3,In4,In5,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5);
		}

		/// <summary>
		/// Function with 6 parameter(s)
		/// and 2 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run2<RT0, RT1> Func2<In0,In1,In2,In3,In4,In5, RT0, RT1> (RunFunc2<In0,In1,In2,In3,In4,In5, RT0, RT1>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return new RunFunc2<In0,In1,In2,In3,In4,In5, RT0, RT1> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5);
		}

		/// <summary>
		/// Function with 6 parameter(s)
		/// and 3 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run3<RT0, RT1, RT2> Func3<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2> (RunFunc3<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return new RunFunc3<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5);
		}

		/// <summary>
		/// Function with 6 parameter(s)
		/// and 4 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run4<RT0, RT1, RT2, RT3> Func4<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3> (RunFunc4<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return new RunFunc4<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5);
		}

		/// <summary>
		/// Function with 6 parameter(s)
		/// and 5 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run5<RT0, RT1, RT2, RT3, RT4> Func5<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4> (RunFunc5<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return new RunFunc5<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5);
		}

		/// <summary>
		/// Function with 6 parameter(s)
		/// and 6 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run6<RT0, RT1, RT2, RT3, RT4, RT5> Func6<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5> (RunFunc6<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return new RunFunc6<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5);
		}

		/// <summary>
		/// Function with 6 parameter(s)
		/// and 7 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> Func7<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (RunFunc7<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return new RunFunc7<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5);
		}

		/// <summary>
		/// Function with 6 parameter(s)
		/// and 8 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> Func8<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (RunFunc8<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return new RunFunc8<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5);
		}

		/// <summary>
		/// Function with 6 parameter(s)
		/// and 9 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> Func9<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (RunFunc9<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return new RunFunc9<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5);
		}

		/// <summary>
		/// Function with 6 parameter(s)
		/// and 10 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> Func10<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (RunFunc10<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return new RunFunc10<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5);
		}

		/// <summary>
		/// Function with 6 parameter(s)
		/// and 11 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> Func11<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (RunFunc11<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return new RunFunc11<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5);
		}

		/// <summary>
		/// Function with 6 parameter(s)
		/// and 12 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> Func12<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (RunFunc12<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return new RunFunc12<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5);
		}

		/// <summary>
		/// Function with 6 parameter(s)
		/// and 13 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> Func13<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (RunFunc13<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return new RunFunc13<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5);
		}

		/// <summary>
		/// Function with 6 parameter(s)
		/// and 14 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> Func14<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (RunFunc14<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return new RunFunc14<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5);
		}

		/// <summary>
		/// Function with 6 parameter(s)
		/// and 15 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> Func15<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (RunFunc15<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return new RunFunc15<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5);
		}

		/// <summary>
		/// Function with 6 parameter(s)
		/// and 16 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> Func16<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (RunFunc16<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			return new RunFunc16<In0,In1,In2,In3,In4,In5, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5);
		}
	
		/// <summary>
		/// Action with 7 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public Run Action<In0,In1,In2,In3,In4,In5,In6>(Action<In0,In1,In2,In3,In4,In5,In6> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6));
		}
	
		/// <summary>
		/// Action with 7 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public DelayedRun DelayedAction<In0,In1,In2,In3,In4,In5,In6>(Action<In0,In1,In2,In3,In4,In5,In6> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return (new DelayedRunAction<In0,In1,In2,In3,In4,In5,In6>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6));
		}
	
		/// <summary>
		/// Function with 7 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,RT>(Func<In0,In1,In2,In3,In4,In5,In6,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return new RunFunc<In0,In1,In2,In3,In4,In5,In6,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6);
		}

		/// <summary>
		/// Function with 7 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public DelayedRun<RT> DelayedFunc<In0,In1,In2,In3,In4,In5,In6,RT>(Func<In0,In1,In2,In3,In4,In5,In6,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return new DelayedRunFunc<In0,In1,In2,In3,In4,In5,In6,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6);
		}

		/// <summary>
		/// Function with 7 parameter(s)
		/// and 2 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run2<RT0, RT1> Func2<In0,In1,In2,In3,In4,In5,In6, RT0, RT1> (RunFunc2<In0,In1,In2,In3,In4,In5,In6, RT0, RT1>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return new RunFunc2<In0,In1,In2,In3,In4,In5,In6, RT0, RT1> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6);
		}

		/// <summary>
		/// Function with 7 parameter(s)
		/// and 3 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run3<RT0, RT1, RT2> Func3<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2> (RunFunc3<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return new RunFunc3<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6);
		}

		/// <summary>
		/// Function with 7 parameter(s)
		/// and 4 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run4<RT0, RT1, RT2, RT3> Func4<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3> (RunFunc4<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return new RunFunc4<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6);
		}

		/// <summary>
		/// Function with 7 parameter(s)
		/// and 5 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run5<RT0, RT1, RT2, RT3, RT4> Func5<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4> (RunFunc5<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return new RunFunc5<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6);
		}

		/// <summary>
		/// Function with 7 parameter(s)
		/// and 6 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run6<RT0, RT1, RT2, RT3, RT4, RT5> Func6<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5> (RunFunc6<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return new RunFunc6<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6);
		}

		/// <summary>
		/// Function with 7 parameter(s)
		/// and 7 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> Func7<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (RunFunc7<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return new RunFunc7<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6);
		}

		/// <summary>
		/// Function with 7 parameter(s)
		/// and 8 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> Func8<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (RunFunc8<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return new RunFunc8<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6);
		}

		/// <summary>
		/// Function with 7 parameter(s)
		/// and 9 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> Func9<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (RunFunc9<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return new RunFunc9<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6);
		}

		/// <summary>
		/// Function with 7 parameter(s)
		/// and 10 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> Func10<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (RunFunc10<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return new RunFunc10<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6);
		}

		/// <summary>
		/// Function with 7 parameter(s)
		/// and 11 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> Func11<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (RunFunc11<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return new RunFunc11<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6);
		}

		/// <summary>
		/// Function with 7 parameter(s)
		/// and 12 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> Func12<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (RunFunc12<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return new RunFunc12<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6);
		}

		/// <summary>
		/// Function with 7 parameter(s)
		/// and 13 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> Func13<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (RunFunc13<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return new RunFunc13<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6);
		}

		/// <summary>
		/// Function with 7 parameter(s)
		/// and 14 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> Func14<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (RunFunc14<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return new RunFunc14<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6);
		}

		/// <summary>
		/// Function with 7 parameter(s)
		/// and 15 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> Func15<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (RunFunc15<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return new RunFunc15<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6);
		}

		/// <summary>
		/// Function with 7 parameter(s)
		/// and 16 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> Func16<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (RunFunc16<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			return new RunFunc16<In0,In1,In2,In3,In4,In5,In6, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6);
		}
	
		/// <summary>
		/// Action with 8 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7>(Action<In0,In1,In2,In3,In4,In5,In6,In7> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7));
		}
	
		/// <summary>
		/// Action with 8 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public DelayedRun DelayedAction<In0,In1,In2,In3,In4,In5,In6,In7>(Action<In0,In1,In2,In3,In4,In5,In6,In7> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return (new DelayedRunAction<In0,In1,In2,In3,In4,In5,In6,In7>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7));
		}
	
		/// <summary>
		/// Function with 8 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7);
		}

		/// <summary>
		/// Function with 8 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public DelayedRun<RT> DelayedFunc<In0,In1,In2,In3,In4,In5,In6,In7,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return new DelayedRunFunc<In0,In1,In2,In3,In4,In5,In6,In7,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7);
		}

		/// <summary>
		/// Function with 8 parameter(s)
		/// and 2 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run2<RT0, RT1> Func2<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1> (RunFunc2<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return new RunFunc2<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7);
		}

		/// <summary>
		/// Function with 8 parameter(s)
		/// and 3 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run3<RT0, RT1, RT2> Func3<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2> (RunFunc3<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return new RunFunc3<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7);
		}

		/// <summary>
		/// Function with 8 parameter(s)
		/// and 4 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run4<RT0, RT1, RT2, RT3> Func4<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3> (RunFunc4<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return new RunFunc4<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7);
		}

		/// <summary>
		/// Function with 8 parameter(s)
		/// and 5 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run5<RT0, RT1, RT2, RT3, RT4> Func5<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4> (RunFunc5<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return new RunFunc5<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7);
		}

		/// <summary>
		/// Function with 8 parameter(s)
		/// and 6 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run6<RT0, RT1, RT2, RT3, RT4, RT5> Func6<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5> (RunFunc6<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return new RunFunc6<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7);
		}

		/// <summary>
		/// Function with 8 parameter(s)
		/// and 7 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> Func7<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (RunFunc7<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return new RunFunc7<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7);
		}

		/// <summary>
		/// Function with 8 parameter(s)
		/// and 8 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> Func8<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (RunFunc8<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return new RunFunc8<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7);
		}

		/// <summary>
		/// Function with 8 parameter(s)
		/// and 9 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> Func9<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (RunFunc9<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return new RunFunc9<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7);
		}

		/// <summary>
		/// Function with 8 parameter(s)
		/// and 10 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> Func10<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (RunFunc10<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return new RunFunc10<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7);
		}

		/// <summary>
		/// Function with 8 parameter(s)
		/// and 11 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> Func11<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (RunFunc11<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return new RunFunc11<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7);
		}

		/// <summary>
		/// Function with 8 parameter(s)
		/// and 12 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> Func12<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (RunFunc12<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return new RunFunc12<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7);
		}

		/// <summary>
		/// Function with 8 parameter(s)
		/// and 13 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> Func13<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (RunFunc13<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return new RunFunc13<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7);
		}

		/// <summary>
		/// Function with 8 parameter(s)
		/// and 14 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> Func14<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (RunFunc14<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return new RunFunc14<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7);
		}

		/// <summary>
		/// Function with 8 parameter(s)
		/// and 15 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> Func15<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (RunFunc15<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return new RunFunc15<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7);
		}

		/// <summary>
		/// Function with 8 parameter(s)
		/// and 16 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> Func16<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (RunFunc16<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			return new RunFunc16<In0,In1,In2,In3,In4,In5,In6,In7, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7);
		}
	
		/// <summary>
		/// Action with 9 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7,In8>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8));
		}
	
		/// <summary>
		/// Action with 9 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public DelayedRun DelayedAction<In0,In1,In2,In3,In4,In5,In6,In7,In8>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return (new DelayedRunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8));
		}
	
		/// <summary>
		/// Function with 9 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8);
		}

		/// <summary>
		/// Function with 9 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public DelayedRun<RT> DelayedFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return new DelayedRunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8);
		}

		/// <summary>
		/// Function with 9 parameter(s)
		/// and 2 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run2<RT0, RT1> Func2<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1> (RunFunc2<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return new RunFunc2<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8);
		}

		/// <summary>
		/// Function with 9 parameter(s)
		/// and 3 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run3<RT0, RT1, RT2> Func3<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2> (RunFunc3<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return new RunFunc3<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8);
		}

		/// <summary>
		/// Function with 9 parameter(s)
		/// and 4 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run4<RT0, RT1, RT2, RT3> Func4<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3> (RunFunc4<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return new RunFunc4<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8);
		}

		/// <summary>
		/// Function with 9 parameter(s)
		/// and 5 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run5<RT0, RT1, RT2, RT3, RT4> Func5<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4> (RunFunc5<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return new RunFunc5<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8);
		}

		/// <summary>
		/// Function with 9 parameter(s)
		/// and 6 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run6<RT0, RT1, RT2, RT3, RT4, RT5> Func6<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5> (RunFunc6<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return new RunFunc6<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8);
		}

		/// <summary>
		/// Function with 9 parameter(s)
		/// and 7 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> Func7<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (RunFunc7<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return new RunFunc7<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8);
		}

		/// <summary>
		/// Function with 9 parameter(s)
		/// and 8 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> Func8<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (RunFunc8<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return new RunFunc8<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8);
		}

		/// <summary>
		/// Function with 9 parameter(s)
		/// and 9 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> Func9<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (RunFunc9<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return new RunFunc9<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8);
		}

		/// <summary>
		/// Function with 9 parameter(s)
		/// and 10 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> Func10<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (RunFunc10<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return new RunFunc10<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8);
		}

		/// <summary>
		/// Function with 9 parameter(s)
		/// and 11 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> Func11<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (RunFunc11<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return new RunFunc11<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8);
		}

		/// <summary>
		/// Function with 9 parameter(s)
		/// and 12 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> Func12<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (RunFunc12<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return new RunFunc12<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8);
		}

		/// <summary>
		/// Function with 9 parameter(s)
		/// and 13 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> Func13<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (RunFunc13<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return new RunFunc13<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8);
		}

		/// <summary>
		/// Function with 9 parameter(s)
		/// and 14 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> Func14<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (RunFunc14<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return new RunFunc14<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8);
		}

		/// <summary>
		/// Function with 9 parameter(s)
		/// and 15 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> Func15<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (RunFunc15<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return new RunFunc15<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8);
		}

		/// <summary>
		/// Function with 9 parameter(s)
		/// and 16 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> Func16<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (RunFunc16<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			return new RunFunc16<In0,In1,In2,In3,In4,In5,In6,In7,In8, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8);
		}
	
		/// <summary>
		/// Action with 10 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9));
		}
	
		/// <summary>
		/// Action with 10 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public DelayedRun DelayedAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return (new DelayedRunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9));
		}
	
		/// <summary>
		/// Function with 10 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9);
		}

		/// <summary>
		/// Function with 10 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public DelayedRun<RT> DelayedFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return new DelayedRunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9);
		}

		/// <summary>
		/// Function with 10 parameter(s)
		/// and 2 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run2<RT0, RT1> Func2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1> (RunFunc2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return new RunFunc2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9);
		}

		/// <summary>
		/// Function with 10 parameter(s)
		/// and 3 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run3<RT0, RT1, RT2> Func3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2> (RunFunc3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return new RunFunc3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9);
		}

		/// <summary>
		/// Function with 10 parameter(s)
		/// and 4 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run4<RT0, RT1, RT2, RT3> Func4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3> (RunFunc4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return new RunFunc4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9);
		}

		/// <summary>
		/// Function with 10 parameter(s)
		/// and 5 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run5<RT0, RT1, RT2, RT3, RT4> Func5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4> (RunFunc5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return new RunFunc5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9);
		}

		/// <summary>
		/// Function with 10 parameter(s)
		/// and 6 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run6<RT0, RT1, RT2, RT3, RT4, RT5> Func6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5> (RunFunc6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return new RunFunc6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9);
		}

		/// <summary>
		/// Function with 10 parameter(s)
		/// and 7 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> Func7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (RunFunc7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return new RunFunc7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9);
		}

		/// <summary>
		/// Function with 10 parameter(s)
		/// and 8 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> Func8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (RunFunc8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return new RunFunc8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9);
		}

		/// <summary>
		/// Function with 10 parameter(s)
		/// and 9 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> Func9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (RunFunc9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return new RunFunc9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9);
		}

		/// <summary>
		/// Function with 10 parameter(s)
		/// and 10 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> Func10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (RunFunc10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return new RunFunc10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9);
		}

		/// <summary>
		/// Function with 10 parameter(s)
		/// and 11 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> Func11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (RunFunc11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return new RunFunc11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9);
		}

		/// <summary>
		/// Function with 10 parameter(s)
		/// and 12 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> Func12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (RunFunc12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return new RunFunc12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9);
		}

		/// <summary>
		/// Function with 10 parameter(s)
		/// and 13 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> Func13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (RunFunc13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return new RunFunc13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9);
		}

		/// <summary>
		/// Function with 10 parameter(s)
		/// and 14 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> Func14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (RunFunc14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return new RunFunc14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9);
		}

		/// <summary>
		/// Function with 10 parameter(s)
		/// and 15 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> Func15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (RunFunc15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return new RunFunc15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9);
		}

		/// <summary>
		/// Function with 10 parameter(s)
		/// and 16 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> Func16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (RunFunc16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			return new RunFunc16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9);
		}
	
		/// <summary>
		/// Action with 11 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10));
		}
	
		/// <summary>
		/// Action with 11 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public DelayedRun DelayedAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return (new DelayedRunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10));
		}
	
		/// <summary>
		/// Function with 11 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10);
		}

		/// <summary>
		/// Function with 11 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public DelayedRun<RT> DelayedFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return new DelayedRunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10);
		}

		/// <summary>
		/// Function with 11 parameter(s)
		/// and 2 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run2<RT0, RT1> Func2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1> (RunFunc2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return new RunFunc2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10);
		}

		/// <summary>
		/// Function with 11 parameter(s)
		/// and 3 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run3<RT0, RT1, RT2> Func3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2> (RunFunc3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return new RunFunc3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10);
		}

		/// <summary>
		/// Function with 11 parameter(s)
		/// and 4 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run4<RT0, RT1, RT2, RT3> Func4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3> (RunFunc4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return new RunFunc4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10);
		}

		/// <summary>
		/// Function with 11 parameter(s)
		/// and 5 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run5<RT0, RT1, RT2, RT3, RT4> Func5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4> (RunFunc5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return new RunFunc5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10);
		}

		/// <summary>
		/// Function with 11 parameter(s)
		/// and 6 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run6<RT0, RT1, RT2, RT3, RT4, RT5> Func6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5> (RunFunc6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return new RunFunc6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10);
		}

		/// <summary>
		/// Function with 11 parameter(s)
		/// and 7 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> Func7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (RunFunc7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return new RunFunc7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10);
		}

		/// <summary>
		/// Function with 11 parameter(s)
		/// and 8 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> Func8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (RunFunc8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return new RunFunc8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10);
		}

		/// <summary>
		/// Function with 11 parameter(s)
		/// and 9 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> Func9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (RunFunc9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return new RunFunc9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10);
		}

		/// <summary>
		/// Function with 11 parameter(s)
		/// and 10 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> Func10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (RunFunc10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return new RunFunc10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10);
		}

		/// <summary>
		/// Function with 11 parameter(s)
		/// and 11 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> Func11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (RunFunc11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return new RunFunc11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10);
		}

		/// <summary>
		/// Function with 11 parameter(s)
		/// and 12 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> Func12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (RunFunc12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return new RunFunc12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10);
		}

		/// <summary>
		/// Function with 11 parameter(s)
		/// and 13 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> Func13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (RunFunc13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return new RunFunc13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10);
		}

		/// <summary>
		/// Function with 11 parameter(s)
		/// and 14 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> Func14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (RunFunc14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return new RunFunc14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10);
		}

		/// <summary>
		/// Function with 11 parameter(s)
		/// and 15 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> Func15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (RunFunc15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return new RunFunc15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10);
		}

		/// <summary>
		/// Function with 11 parameter(s)
		/// and 16 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> Func16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (RunFunc16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			return new RunFunc16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10);
		}
	
		/// <summary>
		/// Action with 12 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11));
		}
	
		/// <summary>
		/// Action with 12 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public DelayedRun DelayedAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return (new DelayedRunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11));
		}
	
		/// <summary>
		/// Function with 12 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11);
		}

		/// <summary>
		/// Function with 12 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public DelayedRun<RT> DelayedFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return new DelayedRunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11);
		}

		/// <summary>
		/// Function with 12 parameter(s)
		/// and 2 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run2<RT0, RT1> Func2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1> (RunFunc2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return new RunFunc2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11);
		}

		/// <summary>
		/// Function with 12 parameter(s)
		/// and 3 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run3<RT0, RT1, RT2> Func3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2> (RunFunc3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return new RunFunc3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11);
		}

		/// <summary>
		/// Function with 12 parameter(s)
		/// and 4 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run4<RT0, RT1, RT2, RT3> Func4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3> (RunFunc4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return new RunFunc4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11);
		}

		/// <summary>
		/// Function with 12 parameter(s)
		/// and 5 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run5<RT0, RT1, RT2, RT3, RT4> Func5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4> (RunFunc5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return new RunFunc5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11);
		}

		/// <summary>
		/// Function with 12 parameter(s)
		/// and 6 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run6<RT0, RT1, RT2, RT3, RT4, RT5> Func6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5> (RunFunc6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return new RunFunc6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11);
		}

		/// <summary>
		/// Function with 12 parameter(s)
		/// and 7 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> Func7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (RunFunc7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return new RunFunc7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11);
		}

		/// <summary>
		/// Function with 12 parameter(s)
		/// and 8 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> Func8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (RunFunc8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return new RunFunc8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11);
		}

		/// <summary>
		/// Function with 12 parameter(s)
		/// and 9 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> Func9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (RunFunc9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return new RunFunc9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11);
		}

		/// <summary>
		/// Function with 12 parameter(s)
		/// and 10 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> Func10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (RunFunc10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return new RunFunc10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11);
		}

		/// <summary>
		/// Function with 12 parameter(s)
		/// and 11 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> Func11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (RunFunc11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return new RunFunc11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11);
		}

		/// <summary>
		/// Function with 12 parameter(s)
		/// and 12 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> Func12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (RunFunc12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return new RunFunc12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11);
		}

		/// <summary>
		/// Function with 12 parameter(s)
		/// and 13 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> Func13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (RunFunc13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return new RunFunc13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11);
		}

		/// <summary>
		/// Function with 12 parameter(s)
		/// and 14 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> Func14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (RunFunc14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return new RunFunc14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11);
		}

		/// <summary>
		/// Function with 12 parameter(s)
		/// and 15 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> Func15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (RunFunc15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return new RunFunc15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11);
		}

		/// <summary>
		/// Function with 12 parameter(s)
		/// and 16 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> Func16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (RunFunc16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			return new RunFunc16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11);
		}
	
		/// <summary>
		/// Action with 13 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12));
		}
	
		/// <summary>
		/// Action with 13 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public DelayedRun DelayedAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return (new DelayedRunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12));
		}
	
		/// <summary>
		/// Function with 13 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12);
		}

		/// <summary>
		/// Function with 13 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public DelayedRun<RT> DelayedFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return new DelayedRunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12);
		}

		/// <summary>
		/// Function with 13 parameter(s)
		/// and 2 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run2<RT0, RT1> Func2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1> (RunFunc2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return new RunFunc2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12);
		}

		/// <summary>
		/// Function with 13 parameter(s)
		/// and 3 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run3<RT0, RT1, RT2> Func3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2> (RunFunc3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return new RunFunc3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12);
		}

		/// <summary>
		/// Function with 13 parameter(s)
		/// and 4 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run4<RT0, RT1, RT2, RT3> Func4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3> (RunFunc4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return new RunFunc4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12);
		}

		/// <summary>
		/// Function with 13 parameter(s)
		/// and 5 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run5<RT0, RT1, RT2, RT3, RT4> Func5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4> (RunFunc5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return new RunFunc5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12);
		}

		/// <summary>
		/// Function with 13 parameter(s)
		/// and 6 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run6<RT0, RT1, RT2, RT3, RT4, RT5> Func6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5> (RunFunc6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return new RunFunc6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12);
		}

		/// <summary>
		/// Function with 13 parameter(s)
		/// and 7 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> Func7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (RunFunc7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return new RunFunc7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12);
		}

		/// <summary>
		/// Function with 13 parameter(s)
		/// and 8 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> Func8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (RunFunc8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return new RunFunc8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12);
		}

		/// <summary>
		/// Function with 13 parameter(s)
		/// and 9 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> Func9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (RunFunc9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return new RunFunc9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12);
		}

		/// <summary>
		/// Function with 13 parameter(s)
		/// and 10 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> Func10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (RunFunc10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return new RunFunc10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12);
		}

		/// <summary>
		/// Function with 13 parameter(s)
		/// and 11 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> Func11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (RunFunc11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return new RunFunc11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12);
		}

		/// <summary>
		/// Function with 13 parameter(s)
		/// and 12 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> Func12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (RunFunc12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return new RunFunc12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12);
		}

		/// <summary>
		/// Function with 13 parameter(s)
		/// and 13 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> Func13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (RunFunc13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return new RunFunc13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12);
		}

		/// <summary>
		/// Function with 13 parameter(s)
		/// and 14 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> Func14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (RunFunc14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return new RunFunc14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12);
		}

		/// <summary>
		/// Function with 13 parameter(s)
		/// and 15 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> Func15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (RunFunc15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return new RunFunc15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12);
		}

		/// <summary>
		/// Function with 13 parameter(s)
		/// and 16 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> Func16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (RunFunc16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			return new RunFunc16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12);
		}
	
		/// <summary>
		/// Action with 14 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13));
		}
	
		/// <summary>
		/// Action with 14 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public DelayedRun DelayedAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			return (new DelayedRunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13));
		}
	
		/// <summary>
		/// Function with 14 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			return new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13);
		}

		/// <summary>
		/// Function with 14 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public DelayedRun<RT> DelayedFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			return new DelayedRunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13);
		}

		/// <summary>
		/// Function with 14 parameter(s)
		/// and 2 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run2<RT0, RT1> Func2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1> (RunFunc2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			return new RunFunc2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13);
		}

		/// <summary>
		/// Function with 14 parameter(s)
		/// and 3 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run3<RT0, RT1, RT2> Func3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2> (RunFunc3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			return new RunFunc3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13);
		}

		/// <summary>
		/// Function with 14 parameter(s)
		/// and 4 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run4<RT0, RT1, RT2, RT3> Func4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3> (RunFunc4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			return new RunFunc4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13);
		}

		/// <summary>
		/// Function with 14 parameter(s)
		/// and 5 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run5<RT0, RT1, RT2, RT3, RT4> Func5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4> (RunFunc5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			return new RunFunc5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13);
		}

		/// <summary>
		/// Function with 14 parameter(s)
		/// and 6 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run6<RT0, RT1, RT2, RT3, RT4, RT5> Func6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5> (RunFunc6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			return new RunFunc6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13);
		}

		/// <summary>
		/// Function with 14 parameter(s)
		/// and 7 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> Func7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (RunFunc7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			return new RunFunc7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13);
		}

		/// <summary>
		/// Function with 14 parameter(s)
		/// and 8 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> Func8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (RunFunc8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			return new RunFunc8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13);
		}

		/// <summary>
		/// Function with 14 parameter(s)
		/// and 9 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> Func9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (RunFunc9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			return new RunFunc9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13);
		}

		/// <summary>
		/// Function with 14 parameter(s)
		/// and 10 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> Func10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (RunFunc10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			return new RunFunc10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13);
		}

		/// <summary>
		/// Function with 14 parameter(s)
		/// and 11 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> Func11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (RunFunc11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			return new RunFunc11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13);
		}

		/// <summary>
		/// Function with 14 parameter(s)
		/// and 12 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> Func12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (RunFunc12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			return new RunFunc12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13);
		}

		/// <summary>
		/// Function with 14 parameter(s)
		/// and 13 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> Func13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (RunFunc13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			return new RunFunc13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13);
		}

		/// <summary>
		/// Function with 14 parameter(s)
		/// and 14 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> Func14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (RunFunc14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			return new RunFunc14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13);
		}

		/// <summary>
		/// Function with 14 parameter(s)
		/// and 15 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> Func15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (RunFunc15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			return new RunFunc15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13);
		}

		/// <summary>
		/// Function with 14 parameter(s)
		/// and 16 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> Func16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (RunFunc16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13) {
			return new RunFunc16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13);
		}
	
		/// <summary>
		/// Action with 15 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14));
		}
	
		/// <summary>
		/// Action with 15 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public DelayedRun DelayedAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			return (new DelayedRunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14));
		}
	
		/// <summary>
		/// Function with 15 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			return new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14);
		}

		/// <summary>
		/// Function with 15 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public DelayedRun<RT> DelayedFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			return new DelayedRunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14);
		}

		/// <summary>
		/// Function with 15 parameter(s)
		/// and 2 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run2<RT0, RT1> Func2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1> (RunFunc2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			return new RunFunc2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14);
		}

		/// <summary>
		/// Function with 15 parameter(s)
		/// and 3 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run3<RT0, RT1, RT2> Func3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2> (RunFunc3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			return new RunFunc3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14);
		}

		/// <summary>
		/// Function with 15 parameter(s)
		/// and 4 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run4<RT0, RT1, RT2, RT3> Func4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3> (RunFunc4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			return new RunFunc4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14);
		}

		/// <summary>
		/// Function with 15 parameter(s)
		/// and 5 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run5<RT0, RT1, RT2, RT3, RT4> Func5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4> (RunFunc5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			return new RunFunc5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14);
		}

		/// <summary>
		/// Function with 15 parameter(s)
		/// and 6 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run6<RT0, RT1, RT2, RT3, RT4, RT5> Func6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5> (RunFunc6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			return new RunFunc6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14);
		}

		/// <summary>
		/// Function with 15 parameter(s)
		/// and 7 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> Func7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (RunFunc7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			return new RunFunc7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14);
		}

		/// <summary>
		/// Function with 15 parameter(s)
		/// and 8 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> Func8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (RunFunc8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			return new RunFunc8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14);
		}

		/// <summary>
		/// Function with 15 parameter(s)
		/// and 9 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> Func9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (RunFunc9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			return new RunFunc9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14);
		}

		/// <summary>
		/// Function with 15 parameter(s)
		/// and 10 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> Func10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (RunFunc10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			return new RunFunc10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14);
		}

		/// <summary>
		/// Function with 15 parameter(s)
		/// and 11 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> Func11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (RunFunc11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			return new RunFunc11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14);
		}

		/// <summary>
		/// Function with 15 parameter(s)
		/// and 12 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> Func12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (RunFunc12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			return new RunFunc12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14);
		}

		/// <summary>
		/// Function with 15 parameter(s)
		/// and 13 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> Func13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (RunFunc13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			return new RunFunc13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14);
		}

		/// <summary>
		/// Function with 15 parameter(s)
		/// and 14 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> Func14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (RunFunc14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			return new RunFunc14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14);
		}

		/// <summary>
		/// Function with 15 parameter(s)
		/// and 15 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> Func15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (RunFunc15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			return new RunFunc15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14);
		}

		/// <summary>
		/// Function with 15 parameter(s)
		/// and 16 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> Func16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (RunFunc16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14) {
			return new RunFunc16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14);
		}
	
		/// <summary>
		/// Action with 16 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public Run Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			return (new RunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14,Inv15));
		}
	
		/// <summary>
		/// Action with 16 parameter(s).<para></para>
		/// Static Action for easy and safe call
		/// </summary>
		static public DelayedRun DelayedAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15>(Action<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			return (new DelayedRunAction<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14,Inv15));
		}
	
		/// <summary>
		/// Function with 16 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run<RT> Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			return new RunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14,Inv15);
		}

		/// <summary>
		/// Function with 16 parameter(s).<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public DelayedRun<RT> DelayedFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15,RT>(Func<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15,RT> Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			return new DelayedRunFunc<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15,RT>(Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14,Inv15);
		}

		/// <summary>
		/// Function with 16 parameter(s)
		/// and 2 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run2<RT0, RT1> Func2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1> (RunFunc2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			return new RunFunc2<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14,Inv15);
		}

		/// <summary>
		/// Function with 16 parameter(s)
		/// and 3 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run3<RT0, RT1, RT2> Func3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2> (RunFunc3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			return new RunFunc3<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14,Inv15);
		}

		/// <summary>
		/// Function with 16 parameter(s)
		/// and 4 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run4<RT0, RT1, RT2, RT3> Func4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3> (RunFunc4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			return new RunFunc4<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14,Inv15);
		}

		/// <summary>
		/// Function with 16 parameter(s)
		/// and 5 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run5<RT0, RT1, RT2, RT3, RT4> Func5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4> (RunFunc5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			return new RunFunc5<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14,Inv15);
		}

		/// <summary>
		/// Function with 16 parameter(s)
		/// and 6 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run6<RT0, RT1, RT2, RT3, RT4, RT5> Func6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5> (RunFunc6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			return new RunFunc6<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14,Inv15);
		}

		/// <summary>
		/// Function with 16 parameter(s)
		/// and 7 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run7<RT0, RT1, RT2, RT3, RT4, RT5, RT6> Func7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (RunFunc7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			return new RunFunc7<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14,Inv15);
		}

		/// <summary>
		/// Function with 16 parameter(s)
		/// and 8 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run8<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> Func8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (RunFunc8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			return new RunFunc8<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14,Inv15);
		}

		/// <summary>
		/// Function with 16 parameter(s)
		/// and 9 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run9<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> Func9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (RunFunc9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			return new RunFunc9<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14,Inv15);
		}

		/// <summary>
		/// Function with 16 parameter(s)
		/// and 10 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run10<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> Func10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (RunFunc10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			return new RunFunc10<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14,Inv15);
		}

		/// <summary>
		/// Function with 16 parameter(s)
		/// and 11 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run11<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> Func11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (RunFunc11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			return new RunFunc11<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14,Inv15);
		}

		/// <summary>
		/// Function with 16 parameter(s)
		/// and 12 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run12<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> Func12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (RunFunc12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			return new RunFunc12<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14,Inv15);
		}

		/// <summary>
		/// Function with 16 parameter(s)
		/// and 13 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run13<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> Func13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (RunFunc13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			return new RunFunc13<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14,Inv15);
		}

		/// <summary>
		/// Function with 16 parameter(s)
		/// and 14 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run14<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> Func14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (RunFunc14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			return new RunFunc14<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14,Inv15);
		}

		/// <summary>
		/// Function with 16 parameter(s)
		/// and 15 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run15<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> Func15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (RunFunc15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			return new RunFunc15<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14,Inv15);
		}

		/// <summary>
		/// Function with 16 parameter(s)
		/// and 16 return values.<para></para>
		/// Static Function for easy and safe call
		/// </summary>
		static public Run16<RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> Func16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (RunFunc16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15>.RunDelegate Function, In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12, In13 Inv13, In14 Inv14, In15 Inv15) {
			return new RunFunc16<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,In13,In14,In15, RT0, RT1, RT2, RT3, RT4, RT5, RT6, RT7, RT8, RT9, RT10, RT11, RT12, RT13, RT14, RT15> (Function, Inv0,Inv1,Inv2,Inv3,Inv4,Inv5,Inv6,Inv7,Inv8,Inv9,Inv10,Inv11,Inv12,Inv13,Inv14,Inv15);
		}
	
}
}	//	namespace	2019-03-01 - 16.30.38