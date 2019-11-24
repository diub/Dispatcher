using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace diub.Threads {

	public class ThreadsTest {

		//
		//

		// Simple function for testing
		static String TestFunction (int i) {
			return i.ToString ();
		}

		// Runner works fine
		static public void RunnerFunctions () {
			List<Run<string>> runs;
			List<string> results;

			runs = new List<Run<string>> ();
			results = new List<string> ();
			for (int i = 0; i < 256; i++)
				runs.Add (Runner.Func<int, string> (TestFunction, i));
			foreach (Run<string> run in runs)
				results.Add (run.Result);
		}


		// Run works fine
		static public void RunFunctions () {
			List<Run<string>> runs;
			List<string> results;

			runs = new List<Run<string>> ();
			results = new List<string> ();
			for (int i = 0; i < 256; i++)
				runs.Add (Runner.Func<int, string> (TestFunction, i));
			foreach (Run<string> run in runs)
				results.Add (run.Result);
		}

		//
		//

		// Simple action for testing
		static public void TestAction (int i, Dictionary<int, string> results) {
			lock (results) {
				results.Add (i, i.ToString ());
			}
		}


		// Runner works fine
		static public void RunnerActions () {
			List<Run> runs;
			Dictionary<int, string> results;

			runs = new List<Run> ();
			results = new Dictionary<int, string> ();
			for (int i = 0; i < 256; i++)
				runs.Add (Runner.Action<int, Dictionary<int, string>> (TestAction, i, results));
			foreach (Run run in runs)
				run.Wait ();
		}

		// Run works fine
		static public void RunActions () {
			List<Run> runs;
			Dictionary<int, string> results;

			runs = new List<Run> ();
			results = new Dictionary<int, string> ();
			for (int i = 0; i < 256; i++)
				runs.Add (Runner.Action<int, Dictionary<int, string>> (TestAction, i, results));
			foreach (Run run in runs)
				run.Wait ();
		}

		// Linq Exception example
		static public void DemonstrateLinqException () {
			List<Thread> threads;
			Dictionary<int, string> results;
			Thread new_thread;

			threads = new List<Thread> ();
			results = new Dictionary<int, string> ();
			for (int i = 0; i < 256; i++) {
				(new_thread = new Thread (unused => TestAction (i, results))).Start ();
				threads.Add (new_thread);
			}
			foreach (Thread thread in threads)
				thread.Join ();
		}

	}   // class

}   //	namespace	2019-03-03 - 11.34.37
