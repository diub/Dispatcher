// 
// Run - © Copyright diub - Dipl.-Ing. Uwe Barth - 2019-03-03
// 
// Erlaubt das Anlegen von Thread-Pools für fast alle Funktionen, auch mit Parametern!
// Bei Hinzufügen eines neuen Parametersatzes wird automatisch ein Thread dafür freigegeben.
//
//

using System;
using System.Collections.Generic;
using System.Threading;

namespace diub.Threads {

	/// <summary>
	/// Basis-Klasse mit grundelegenden Elementen. 
	/// </summary>	
	public abstract class RunPoolBase<RT> : RunPoolBase {
		
		protected List<RT> return_values = new List<RT> ();

		public RT PopReturnValue() {
			RT value;

			lock(return_values) {
				value = return_values [0];
				return_values.RemoveAt (0);
			}
			return value;
		}

		public List<RT> Values {
			get {
				return return_values;
			}
		}

	}


	public class RunFuncPool<In0,RT> : RunPoolBase<RT> {
		public delegate RT FunctionDelegate ( In0 Inv0);
		private FunctionDelegate function ;

		private struct Parameters {
			public In0 inv0;
		}

		private List<Parameters> parameters = new List<Parameters>();

		public RunFuncPool (FunctionDelegate Function, int MaxConcurrentWorkers = 4, int PoolSize = 0) {
			List<Thread> threads;

			threads = new List<Thread> ();
			completed = new Semaphore (1, 1);
			function = Function;
			if(PoolSize == 0)
				PoolSize = MaxConcurrentWorkers * 2;
			pool_handler = new Semaphore (PoolSize, PoolSize);
			for (int i = 0; i < MaxConcurrentWorkers; i++) 
				threads.Add (new Thread (Loop));
			thread_handler = new ThreadPoolHandler (threads);
			thread_handler.StartThreads ();
		}

		protected void Loop () {
			Parameters par;

			do {
				thread_handler.Wait ();
				if (disposing)
					return;
				lock (parameters) {
					par = parameters [0];
					parameters.RemoveAt (0);
					pool_handler.Release ();
				}
				DoIt (par);
				lock (parameters) {
					todo--;
					thread_handler.Done ();
					if (todo == 0)
						completed.Release ();
				}
			} while (!disposing);
		}

		protected virtual void DoIt (Object Vars) {
			Parameters par = (Parameters) Vars;
			RT return_value;
		
			return_value = function ( par.inv0);
			lock (return_values)
				return_values.Add(return_value);
		}

		public void Add ( In0 Inv0) {
			Parameters add_parameters;

			add_parameters = new Parameters () { inv0=Inv0};
			pool_handler.WaitOne ();
			lock (parameters) {
				if (todo == 0)
					completed.WaitOne ();
				todo++;
				parameters.Add (add_parameters);
				thread_handler.Request ();
			}
		}


	}	// class

	public class RunFuncPool<In0,In1,RT> : RunPoolBase<RT> {
		public delegate RT FunctionDelegate ( In0 Inv0, In1 Inv1);
		private FunctionDelegate function ;

		private struct Parameters {
			public In0 inv0;
			public In1 inv1;
		}

		private List<Parameters> parameters = new List<Parameters>();

		public RunFuncPool (FunctionDelegate Function, int MaxConcurrentWorkers = 4, int PoolSize = 0) {
			List<Thread> threads;

			threads = new List<Thread> ();
			completed = new Semaphore (1, 1);
			function = Function;
			if(PoolSize == 0)
				PoolSize = MaxConcurrentWorkers * 2;
			pool_handler = new Semaphore (PoolSize, PoolSize);
			for (int i = 0; i < MaxConcurrentWorkers; i++) 
				threads.Add (new Thread (Loop));
			thread_handler = new ThreadPoolHandler (threads);
			thread_handler.StartThreads ();
		}

		protected void Loop () {
			Parameters par;

			do {
				thread_handler.Wait ();
				if (disposing)
					return;
				lock (parameters) {
					par = parameters [0];
					parameters.RemoveAt (0);
					pool_handler.Release ();
				}
				DoIt (par);
				lock (parameters) {
					todo--;
					thread_handler.Done ();
					if (todo == 0)
						completed.Release ();
				}
			} while (!disposing);
		}

		protected virtual void DoIt (Object Vars) {
			Parameters par = (Parameters) Vars;
			RT return_value;
		
			return_value = function ( par.inv0, par.inv1);
			lock (return_values)
				return_values.Add(return_value);
		}

		public void Add ( In0 Inv0, In1 Inv1) {
			Parameters add_parameters;

			add_parameters = new Parameters () { inv0=Inv0, inv1=Inv1};
			pool_handler.WaitOne ();
			lock (parameters) {
				if (todo == 0)
					completed.WaitOne ();
				todo++;
				parameters.Add (add_parameters);
				thread_handler.Request ();
			}
		}


	}	// class

	public class RunFuncPool<In0,In1,In2,RT> : RunPoolBase<RT> {
		public delegate RT FunctionDelegate ( In0 Inv0, In1 Inv1, In2 Inv2);
		private FunctionDelegate function ;

		private struct Parameters {
			public In0 inv0;
			public In1 inv1;
			public In2 inv2;
		}

		private List<Parameters> parameters = new List<Parameters>();

		public RunFuncPool (FunctionDelegate Function, int MaxConcurrentWorkers = 4, int PoolSize = 0) {
			List<Thread> threads;

			threads = new List<Thread> ();
			completed = new Semaphore (1, 1);
			function = Function;
			if(PoolSize == 0)
				PoolSize = MaxConcurrentWorkers * 2;
			pool_handler = new Semaphore (PoolSize, PoolSize);
			for (int i = 0; i < MaxConcurrentWorkers; i++) 
				threads.Add (new Thread (Loop));
			thread_handler = new ThreadPoolHandler (threads);
			thread_handler.StartThreads ();
		}

		protected void Loop () {
			Parameters par;

			do {
				thread_handler.Wait ();
				if (disposing)
					return;
				lock (parameters) {
					par = parameters [0];
					parameters.RemoveAt (0);
					pool_handler.Release ();
				}
				DoIt (par);
				lock (parameters) {
					todo--;
					thread_handler.Done ();
					if (todo == 0)
						completed.Release ();
				}
			} while (!disposing);
		}

		protected virtual void DoIt (Object Vars) {
			Parameters par = (Parameters) Vars;
			RT return_value;
		
			return_value = function ( par.inv0, par.inv1, par.inv2);
			lock (return_values)
				return_values.Add(return_value);
		}

		public void Add ( In0 Inv0, In1 Inv1, In2 Inv2) {
			Parameters add_parameters;

			add_parameters = new Parameters () { inv0=Inv0, inv1=Inv1, inv2=Inv2};
			pool_handler.WaitOne ();
			lock (parameters) {
				if (todo == 0)
					completed.WaitOne ();
				todo++;
				parameters.Add (add_parameters);
				thread_handler.Request ();
			}
		}


	}	// class

	public class RunFuncPool<In0,In1,In2,In3,RT> : RunPoolBase<RT> {
		public delegate RT FunctionDelegate ( In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3);
		private FunctionDelegate function ;

		private struct Parameters {
			public In0 inv0;
			public In1 inv1;
			public In2 inv2;
			public In3 inv3;
		}

		private List<Parameters> parameters = new List<Parameters>();

		public RunFuncPool (FunctionDelegate Function, int MaxConcurrentWorkers = 4, int PoolSize = 0) {
			List<Thread> threads;

			threads = new List<Thread> ();
			completed = new Semaphore (1, 1);
			function = Function;
			if(PoolSize == 0)
				PoolSize = MaxConcurrentWorkers * 2;
			pool_handler = new Semaphore (PoolSize, PoolSize);
			for (int i = 0; i < MaxConcurrentWorkers; i++) 
				threads.Add (new Thread (Loop));
			thread_handler = new ThreadPoolHandler (threads);
			thread_handler.StartThreads ();
		}

		protected void Loop () {
			Parameters par;

			do {
				thread_handler.Wait ();
				if (disposing)
					return;
				lock (parameters) {
					par = parameters [0];
					parameters.RemoveAt (0);
					pool_handler.Release ();
				}
				DoIt (par);
				lock (parameters) {
					todo--;
					thread_handler.Done ();
					if (todo == 0)
						completed.Release ();
				}
			} while (!disposing);
		}

		protected virtual void DoIt (Object Vars) {
			Parameters par = (Parameters) Vars;
			RT return_value;
		
			return_value = function ( par.inv0, par.inv1, par.inv2, par.inv3);
			lock (return_values)
				return_values.Add(return_value);
		}

		public void Add ( In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3) {
			Parameters add_parameters;

			add_parameters = new Parameters () { inv0=Inv0, inv1=Inv1, inv2=Inv2, inv3=Inv3};
			pool_handler.WaitOne ();
			lock (parameters) {
				if (todo == 0)
					completed.WaitOne ();
				todo++;
				parameters.Add (add_parameters);
				thread_handler.Request ();
			}
		}


	}	// class

	public class RunFuncPool<In0,In1,In2,In3,In4,RT> : RunPoolBase<RT> {
		public delegate RT FunctionDelegate ( In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4);
		private FunctionDelegate function ;

		private struct Parameters {
			public In0 inv0;
			public In1 inv1;
			public In2 inv2;
			public In3 inv3;
			public In4 inv4;
		}

		private List<Parameters> parameters = new List<Parameters>();

		public RunFuncPool (FunctionDelegate Function, int MaxConcurrentWorkers = 4, int PoolSize = 0) {
			List<Thread> threads;

			threads = new List<Thread> ();
			completed = new Semaphore (1, 1);
			function = Function;
			if(PoolSize == 0)
				PoolSize = MaxConcurrentWorkers * 2;
			pool_handler = new Semaphore (PoolSize, PoolSize);
			for (int i = 0; i < MaxConcurrentWorkers; i++) 
				threads.Add (new Thread (Loop));
			thread_handler = new ThreadPoolHandler (threads);
			thread_handler.StartThreads ();
		}

		protected void Loop () {
			Parameters par;

			do {
				thread_handler.Wait ();
				if (disposing)
					return;
				lock (parameters) {
					par = parameters [0];
					parameters.RemoveAt (0);
					pool_handler.Release ();
				}
				DoIt (par);
				lock (parameters) {
					todo--;
					thread_handler.Done ();
					if (todo == 0)
						completed.Release ();
				}
			} while (!disposing);
		}

		protected virtual void DoIt (Object Vars) {
			Parameters par = (Parameters) Vars;
			RT return_value;
		
			return_value = function ( par.inv0, par.inv1, par.inv2, par.inv3, par.inv4);
			lock (return_values)
				return_values.Add(return_value);
		}

		public void Add ( In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4) {
			Parameters add_parameters;

			add_parameters = new Parameters () { inv0=Inv0, inv1=Inv1, inv2=Inv2, inv3=Inv3, inv4=Inv4};
			pool_handler.WaitOne ();
			lock (parameters) {
				if (todo == 0)
					completed.WaitOne ();
				todo++;
				parameters.Add (add_parameters);
				thread_handler.Request ();
			}
		}


	}	// class

	public class RunFuncPool<In0,In1,In2,In3,In4,In5,RT> : RunPoolBase<RT> {
		public delegate RT FunctionDelegate ( In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5);
		private FunctionDelegate function ;

		private struct Parameters {
			public In0 inv0;
			public In1 inv1;
			public In2 inv2;
			public In3 inv3;
			public In4 inv4;
			public In5 inv5;
		}

		private List<Parameters> parameters = new List<Parameters>();

		public RunFuncPool (FunctionDelegate Function, int MaxConcurrentWorkers = 4, int PoolSize = 0) {
			List<Thread> threads;

			threads = new List<Thread> ();
			completed = new Semaphore (1, 1);
			function = Function;
			if(PoolSize == 0)
				PoolSize = MaxConcurrentWorkers * 2;
			pool_handler = new Semaphore (PoolSize, PoolSize);
			for (int i = 0; i < MaxConcurrentWorkers; i++) 
				threads.Add (new Thread (Loop));
			thread_handler = new ThreadPoolHandler (threads);
			thread_handler.StartThreads ();
		}

		protected void Loop () {
			Parameters par;

			do {
				thread_handler.Wait ();
				if (disposing)
					return;
				lock (parameters) {
					par = parameters [0];
					parameters.RemoveAt (0);
					pool_handler.Release ();
				}
				DoIt (par);
				lock (parameters) {
					todo--;
					thread_handler.Done ();
					if (todo == 0)
						completed.Release ();
				}
			} while (!disposing);
		}

		protected virtual void DoIt (Object Vars) {
			Parameters par = (Parameters) Vars;
			RT return_value;
		
			return_value = function ( par.inv0, par.inv1, par.inv2, par.inv3, par.inv4, par.inv5);
			lock (return_values)
				return_values.Add(return_value);
		}

		public void Add ( In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5) {
			Parameters add_parameters;

			add_parameters = new Parameters () { inv0=Inv0, inv1=Inv1, inv2=Inv2, inv3=Inv3, inv4=Inv4, inv5=Inv5};
			pool_handler.WaitOne ();
			lock (parameters) {
				if (todo == 0)
					completed.WaitOne ();
				todo++;
				parameters.Add (add_parameters);
				thread_handler.Request ();
			}
		}


	}	// class

	public class RunFuncPool<In0,In1,In2,In3,In4,In5,In6,RT> : RunPoolBase<RT> {
		public delegate RT FunctionDelegate ( In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6);
		private FunctionDelegate function ;

		private struct Parameters {
			public In0 inv0;
			public In1 inv1;
			public In2 inv2;
			public In3 inv3;
			public In4 inv4;
			public In5 inv5;
			public In6 inv6;
		}

		private List<Parameters> parameters = new List<Parameters>();

		public RunFuncPool (FunctionDelegate Function, int MaxConcurrentWorkers = 4, int PoolSize = 0) {
			List<Thread> threads;

			threads = new List<Thread> ();
			completed = new Semaphore (1, 1);
			function = Function;
			if(PoolSize == 0)
				PoolSize = MaxConcurrentWorkers * 2;
			pool_handler = new Semaphore (PoolSize, PoolSize);
			for (int i = 0; i < MaxConcurrentWorkers; i++) 
				threads.Add (new Thread (Loop));
			thread_handler = new ThreadPoolHandler (threads);
			thread_handler.StartThreads ();
		}

		protected void Loop () {
			Parameters par;

			do {
				thread_handler.Wait ();
				if (disposing)
					return;
				lock (parameters) {
					par = parameters [0];
					parameters.RemoveAt (0);
					pool_handler.Release ();
				}
				DoIt (par);
				lock (parameters) {
					todo--;
					thread_handler.Done ();
					if (todo == 0)
						completed.Release ();
				}
			} while (!disposing);
		}

		protected virtual void DoIt (Object Vars) {
			Parameters par = (Parameters) Vars;
			RT return_value;
		
			return_value = function ( par.inv0, par.inv1, par.inv2, par.inv3, par.inv4, par.inv5, par.inv6);
			lock (return_values)
				return_values.Add(return_value);
		}

		public void Add ( In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6) {
			Parameters add_parameters;

			add_parameters = new Parameters () { inv0=Inv0, inv1=Inv1, inv2=Inv2, inv3=Inv3, inv4=Inv4, inv5=Inv5, inv6=Inv6};
			pool_handler.WaitOne ();
			lock (parameters) {
				if (todo == 0)
					completed.WaitOne ();
				todo++;
				parameters.Add (add_parameters);
				thread_handler.Request ();
			}
		}


	}	// class

	public class RunFuncPool<In0,In1,In2,In3,In4,In5,In6,In7,RT> : RunPoolBase<RT> {
		public delegate RT FunctionDelegate ( In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7);
		private FunctionDelegate function ;

		private struct Parameters {
			public In0 inv0;
			public In1 inv1;
			public In2 inv2;
			public In3 inv3;
			public In4 inv4;
			public In5 inv5;
			public In6 inv6;
			public In7 inv7;
		}

		private List<Parameters> parameters = new List<Parameters>();

		public RunFuncPool (FunctionDelegate Function, int MaxConcurrentWorkers = 4, int PoolSize = 0) {
			List<Thread> threads;

			threads = new List<Thread> ();
			completed = new Semaphore (1, 1);
			function = Function;
			if(PoolSize == 0)
				PoolSize = MaxConcurrentWorkers * 2;
			pool_handler = new Semaphore (PoolSize, PoolSize);
			for (int i = 0; i < MaxConcurrentWorkers; i++) 
				threads.Add (new Thread (Loop));
			thread_handler = new ThreadPoolHandler (threads);
			thread_handler.StartThreads ();
		}

		protected void Loop () {
			Parameters par;

			do {
				thread_handler.Wait ();
				if (disposing)
					return;
				lock (parameters) {
					par = parameters [0];
					parameters.RemoveAt (0);
					pool_handler.Release ();
				}
				DoIt (par);
				lock (parameters) {
					todo--;
					thread_handler.Done ();
					if (todo == 0)
						completed.Release ();
				}
			} while (!disposing);
		}

		protected virtual void DoIt (Object Vars) {
			Parameters par = (Parameters) Vars;
			RT return_value;
		
			return_value = function ( par.inv0, par.inv1, par.inv2, par.inv3, par.inv4, par.inv5, par.inv6, par.inv7);
			lock (return_values)
				return_values.Add(return_value);
		}

		public void Add ( In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7) {
			Parameters add_parameters;

			add_parameters = new Parameters () { inv0=Inv0, inv1=Inv1, inv2=Inv2, inv3=Inv3, inv4=Inv4, inv5=Inv5, inv6=Inv6, inv7=Inv7};
			pool_handler.WaitOne ();
			lock (parameters) {
				if (todo == 0)
					completed.WaitOne ();
				todo++;
				parameters.Add (add_parameters);
				thread_handler.Request ();
			}
		}


	}	// class

	public class RunFuncPool<In0,In1,In2,In3,In4,In5,In6,In7,In8,RT> : RunPoolBase<RT> {
		public delegate RT FunctionDelegate ( In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8);
		private FunctionDelegate function ;

		private struct Parameters {
			public In0 inv0;
			public In1 inv1;
			public In2 inv2;
			public In3 inv3;
			public In4 inv4;
			public In5 inv5;
			public In6 inv6;
			public In7 inv7;
			public In8 inv8;
		}

		private List<Parameters> parameters = new List<Parameters>();

		public RunFuncPool (FunctionDelegate Function, int MaxConcurrentWorkers = 4, int PoolSize = 0) {
			List<Thread> threads;

			threads = new List<Thread> ();
			completed = new Semaphore (1, 1);
			function = Function;
			if(PoolSize == 0)
				PoolSize = MaxConcurrentWorkers * 2;
			pool_handler = new Semaphore (PoolSize, PoolSize);
			for (int i = 0; i < MaxConcurrentWorkers; i++) 
				threads.Add (new Thread (Loop));
			thread_handler = new ThreadPoolHandler (threads);
			thread_handler.StartThreads ();
		}

		protected void Loop () {
			Parameters par;

			do {
				thread_handler.Wait ();
				if (disposing)
					return;
				lock (parameters) {
					par = parameters [0];
					parameters.RemoveAt (0);
					pool_handler.Release ();
				}
				DoIt (par);
				lock (parameters) {
					todo--;
					thread_handler.Done ();
					if (todo == 0)
						completed.Release ();
				}
			} while (!disposing);
		}

		protected virtual void DoIt (Object Vars) {
			Parameters par = (Parameters) Vars;
			RT return_value;
		
			return_value = function ( par.inv0, par.inv1, par.inv2, par.inv3, par.inv4, par.inv5, par.inv6, par.inv7, par.inv8);
			lock (return_values)
				return_values.Add(return_value);
		}

		public void Add ( In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8) {
			Parameters add_parameters;

			add_parameters = new Parameters () { inv0=Inv0, inv1=Inv1, inv2=Inv2, inv3=Inv3, inv4=Inv4, inv5=Inv5, inv6=Inv6, inv7=Inv7, inv8=Inv8};
			pool_handler.WaitOne ();
			lock (parameters) {
				if (todo == 0)
					completed.WaitOne ();
				todo++;
				parameters.Add (add_parameters);
				thread_handler.Request ();
			}
		}


	}	// class

	public class RunFuncPool<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,RT> : RunPoolBase<RT> {
		public delegate RT FunctionDelegate ( In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9);
		private FunctionDelegate function ;

		private struct Parameters {
			public In0 inv0;
			public In1 inv1;
			public In2 inv2;
			public In3 inv3;
			public In4 inv4;
			public In5 inv5;
			public In6 inv6;
			public In7 inv7;
			public In8 inv8;
			public In9 inv9;
		}

		private List<Parameters> parameters = new List<Parameters>();

		public RunFuncPool (FunctionDelegate Function, int MaxConcurrentWorkers = 4, int PoolSize = 0) {
			List<Thread> threads;

			threads = new List<Thread> ();
			completed = new Semaphore (1, 1);
			function = Function;
			if(PoolSize == 0)
				PoolSize = MaxConcurrentWorkers * 2;
			pool_handler = new Semaphore (PoolSize, PoolSize);
			for (int i = 0; i < MaxConcurrentWorkers; i++) 
				threads.Add (new Thread (Loop));
			thread_handler = new ThreadPoolHandler (threads);
			thread_handler.StartThreads ();
		}

		protected void Loop () {
			Parameters par;

			do {
				thread_handler.Wait ();
				if (disposing)
					return;
				lock (parameters) {
					par = parameters [0];
					parameters.RemoveAt (0);
					pool_handler.Release ();
				}
				DoIt (par);
				lock (parameters) {
					todo--;
					thread_handler.Done ();
					if (todo == 0)
						completed.Release ();
				}
			} while (!disposing);
		}

		protected virtual void DoIt (Object Vars) {
			Parameters par = (Parameters) Vars;
			RT return_value;
		
			return_value = function ( par.inv0, par.inv1, par.inv2, par.inv3, par.inv4, par.inv5, par.inv6, par.inv7, par.inv8, par.inv9);
			lock (return_values)
				return_values.Add(return_value);
		}

		public void Add ( In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9) {
			Parameters add_parameters;

			add_parameters = new Parameters () { inv0=Inv0, inv1=Inv1, inv2=Inv2, inv3=Inv3, inv4=Inv4, inv5=Inv5, inv6=Inv6, inv7=Inv7, inv8=Inv8, inv9=Inv9};
			pool_handler.WaitOne ();
			lock (parameters) {
				if (todo == 0)
					completed.WaitOne ();
				todo++;
				parameters.Add (add_parameters);
				thread_handler.Request ();
			}
		}


	}	// class

	public class RunFuncPool<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,RT> : RunPoolBase<RT> {
		public delegate RT FunctionDelegate ( In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10);
		private FunctionDelegate function ;

		private struct Parameters {
			public In0 inv0;
			public In1 inv1;
			public In2 inv2;
			public In3 inv3;
			public In4 inv4;
			public In5 inv5;
			public In6 inv6;
			public In7 inv7;
			public In8 inv8;
			public In9 inv9;
			public In10 inv10;
		}

		private List<Parameters> parameters = new List<Parameters>();

		public RunFuncPool (FunctionDelegate Function, int MaxConcurrentWorkers = 4, int PoolSize = 0) {
			List<Thread> threads;

			threads = new List<Thread> ();
			completed = new Semaphore (1, 1);
			function = Function;
			if(PoolSize == 0)
				PoolSize = MaxConcurrentWorkers * 2;
			pool_handler = new Semaphore (PoolSize, PoolSize);
			for (int i = 0; i < MaxConcurrentWorkers; i++) 
				threads.Add (new Thread (Loop));
			thread_handler = new ThreadPoolHandler (threads);
			thread_handler.StartThreads ();
		}

		protected void Loop () {
			Parameters par;

			do {
				thread_handler.Wait ();
				if (disposing)
					return;
				lock (parameters) {
					par = parameters [0];
					parameters.RemoveAt (0);
					pool_handler.Release ();
				}
				DoIt (par);
				lock (parameters) {
					todo--;
					thread_handler.Done ();
					if (todo == 0)
						completed.Release ();
				}
			} while (!disposing);
		}

		protected virtual void DoIt (Object Vars) {
			Parameters par = (Parameters) Vars;
			RT return_value;
		
			return_value = function ( par.inv0, par.inv1, par.inv2, par.inv3, par.inv4, par.inv5, par.inv6, par.inv7, par.inv8, par.inv9, par.inv10);
			lock (return_values)
				return_values.Add(return_value);
		}

		public void Add ( In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10) {
			Parameters add_parameters;

			add_parameters = new Parameters () { inv0=Inv0, inv1=Inv1, inv2=Inv2, inv3=Inv3, inv4=Inv4, inv5=Inv5, inv6=Inv6, inv7=Inv7, inv8=Inv8, inv9=Inv9, inv10=Inv10};
			pool_handler.WaitOne ();
			lock (parameters) {
				if (todo == 0)
					completed.WaitOne ();
				todo++;
				parameters.Add (add_parameters);
				thread_handler.Request ();
			}
		}


	}	// class

	public class RunFuncPool<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,RT> : RunPoolBase<RT> {
		public delegate RT FunctionDelegate ( In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11);
		private FunctionDelegate function ;

		private struct Parameters {
			public In0 inv0;
			public In1 inv1;
			public In2 inv2;
			public In3 inv3;
			public In4 inv4;
			public In5 inv5;
			public In6 inv6;
			public In7 inv7;
			public In8 inv8;
			public In9 inv9;
			public In10 inv10;
			public In11 inv11;
		}

		private List<Parameters> parameters = new List<Parameters>();

		public RunFuncPool (FunctionDelegate Function, int MaxConcurrentWorkers = 4, int PoolSize = 0) {
			List<Thread> threads;

			threads = new List<Thread> ();
			completed = new Semaphore (1, 1);
			function = Function;
			if(PoolSize == 0)
				PoolSize = MaxConcurrentWorkers * 2;
			pool_handler = new Semaphore (PoolSize, PoolSize);
			for (int i = 0; i < MaxConcurrentWorkers; i++) 
				threads.Add (new Thread (Loop));
			thread_handler = new ThreadPoolHandler (threads);
			thread_handler.StartThreads ();
		}

		protected void Loop () {
			Parameters par;

			do {
				thread_handler.Wait ();
				if (disposing)
					return;
				lock (parameters) {
					par = parameters [0];
					parameters.RemoveAt (0);
					pool_handler.Release ();
				}
				DoIt (par);
				lock (parameters) {
					todo--;
					thread_handler.Done ();
					if (todo == 0)
						completed.Release ();
				}
			} while (!disposing);
		}

		protected virtual void DoIt (Object Vars) {
			Parameters par = (Parameters) Vars;
			RT return_value;
		
			return_value = function ( par.inv0, par.inv1, par.inv2, par.inv3, par.inv4, par.inv5, par.inv6, par.inv7, par.inv8, par.inv9, par.inv10, par.inv11);
			lock (return_values)
				return_values.Add(return_value);
		}

		public void Add ( In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11) {
			Parameters add_parameters;

			add_parameters = new Parameters () { inv0=Inv0, inv1=Inv1, inv2=Inv2, inv3=Inv3, inv4=Inv4, inv5=Inv5, inv6=Inv6, inv7=Inv7, inv8=Inv8, inv9=Inv9, inv10=Inv10, inv11=Inv11};
			pool_handler.WaitOne ();
			lock (parameters) {
				if (todo == 0)
					completed.WaitOne ();
				todo++;
				parameters.Add (add_parameters);
				thread_handler.Request ();
			}
		}


	}	// class

	public class RunFuncPool<In0,In1,In2,In3,In4,In5,In6,In7,In8,In9,In10,In11,In12,RT> : RunPoolBase<RT> {
		public delegate RT FunctionDelegate ( In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12);
		private FunctionDelegate function ;

		private struct Parameters {
			public In0 inv0;
			public In1 inv1;
			public In2 inv2;
			public In3 inv3;
			public In4 inv4;
			public In5 inv5;
			public In6 inv6;
			public In7 inv7;
			public In8 inv8;
			public In9 inv9;
			public In10 inv10;
			public In11 inv11;
			public In12 inv12;
		}

		private List<Parameters> parameters = new List<Parameters>();

		public RunFuncPool (FunctionDelegate Function, int MaxConcurrentWorkers = 4, int PoolSize = 0) {
			List<Thread> threads;

			threads = new List<Thread> ();
			completed = new Semaphore (1, 1);
			function = Function;
			if(PoolSize == 0)
				PoolSize = MaxConcurrentWorkers * 2;
			pool_handler = new Semaphore (PoolSize, PoolSize);
			for (int i = 0; i < MaxConcurrentWorkers; i++) 
				threads.Add (new Thread (Loop));
			thread_handler = new ThreadPoolHandler (threads);
			thread_handler.StartThreads ();
		}

		protected void Loop () {
			Parameters par;

			do {
				thread_handler.Wait ();
				if (disposing)
					return;
				lock (parameters) {
					par = parameters [0];
					parameters.RemoveAt (0);
					pool_handler.Release ();
				}
				DoIt (par);
				lock (parameters) {
					todo--;
					thread_handler.Done ();
					if (todo == 0)
						completed.Release ();
				}
			} while (!disposing);
		}

		protected virtual void DoIt (Object Vars) {
			Parameters par = (Parameters) Vars;
			RT return_value;
		
			return_value = function ( par.inv0, par.inv1, par.inv2, par.inv3, par.inv4, par.inv5, par.inv6, par.inv7, par.inv8, par.inv9, par.inv10, par.inv11, par.inv12);
			lock (return_values)
				return_values.Add(return_value);
		}

		public void Add ( In0 Inv0, In1 Inv1, In2 Inv2, In3 Inv3, In4 Inv4, In5 Inv5, In6 Inv6, In7 Inv7, In8 Inv8, In9 Inv9, In10 Inv10, In11 Inv11, In12 Inv12) {
			Parameters add_parameters;

			add_parameters = new Parameters () { inv0=Inv0, inv1=Inv1, inv2=Inv2, inv3=Inv3, inv4=Inv4, inv5=Inv5, inv6=Inv6, inv7=Inv7, inv8=Inv8, inv9=Inv9, inv10=Inv10, inv11=Inv11, inv12=Inv12};
			pool_handler.WaitOne ();
			lock (parameters) {
				if (todo == 0)
					completed.WaitOne ();
				todo++;
				parameters.Add (add_parameters);
				thread_handler.Request ();
			}
		}


	}	// class
}	//	namespace	2019-05-02 - 12.17.20