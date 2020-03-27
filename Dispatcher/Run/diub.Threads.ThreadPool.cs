using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Reflection;
//using System.ServiceProcess;

using System.Globalization;
using Microsoft.Win32;


namespace diub.Threads {

	/// <summary>
	/// Verwaltet die Freigabe der hinzugefügten Threads.
	/// Mit 'Request' können mehr Aufrufe angefordert werden, als gleichzeitig zur Verfügung stehen. 
	/// Diese werden dann weiter abgearbeitet.
	/// </summary>
	public class ThreadPoolHandler {

		/// <summary>
		/// Maximal gleichzeitig aktive Threads
		/// </summary>
		private int max_concurent_threads = 0;

		/// <summary>
		/// Gerade aktive Threads
		/// </summary>
		private int concurrent_threads = 0;

		/// <summary>
		/// Angeforderte Threads
		/// </summary>
		private int requested_threads = 0;

		private Semaphore thread_handler ;
		private List<Thread> threads;

		public ThreadPoolHandler (List<Thread> Threads) {
			threads = Threads;
			max_concurent_threads = threads.Count;
		}

		public void StartThreads () {
			if (thread_handler == null) {
				thread_handler = new Semaphore (0, max_concurent_threads);
				foreach (Thread item in threads)
					item.Start ();
			}
		}

		public void Request () {
			lock (thread_handler) {
				requested_threads++;
				if (concurrent_threads < max_concurent_threads) {
					concurrent_threads++;
					thread_handler.Release ();
				}
			}
		}

		/// <summary>
		/// Warten für Worker-Thread
		/// </summary>
		public void Wait () {
			thread_handler.WaitOne ();
		}

		/// <summary>
		/// Aufrufen wenn Worker-Thread Durchlauf beendet hat!
		/// </summary>
		public void Done () {
			lock (thread_handler) {
				requested_threads--;
				concurrent_threads--;
				if (requested_threads > concurrent_threads) {
					concurrent_threads++;
					thread_handler.Release ();
				}
			}
		}


		/// <summary>
		/// Zum Beenden der Threads wird jeder einmal freigegeben.
		/// </summary>
		public void ReleaseAll () {
			while (max_concurent_threads > 0) {
				thread_handler.Release ();
				max_concurent_threads--;
			}
		}

	}   // class

}   //	namespace	2019-03-31 - 16.39.42
