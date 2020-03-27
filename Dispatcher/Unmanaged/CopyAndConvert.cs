using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diub.Unmanaged {

	static public partial class Copy {


		/// <summary>
		/// Kopiert den Inhalt von <paramref name="Source"/> an die mit <paramref name="Target"/> angegeben Stelle.
		/// </summary>
		/// <param name="Source"></param>
		/// <param name="Target"></param>
		unsafe static public void CopyChars (string Source, char* Target) {
			fixed (char* ptr = Source.ToArray ()) {
				CopyChars (ptr, (char*) Target, Source.Length);
			}
		}

		/// <summary>
		/// Kopiert "<paramref name="Length"/>" Zeichen 
		/// ab der mit <paramref name="Source"/> angegebene Stelle 
		/// in einen neuen String.
		/// </summary>
		/// <param name="Source"></param>
		/// <param name="Length"></param>
		/// <returns></returns>
		unsafe static public string CopyChars (char* Source, int Length) {
			string str;

			str = new string (Source, 0, Length);
			return str;
		}

		/// <summary>
		/// Kopiert die Bytes einzeln via *ptr++.
		/// </summary>
		/// <param name="Source"></param>
		/// <param name="Target"></param>
		unsafe static public void CopyBytes (byte [] Source, byte* Target) {
			fixed (byte* source = Source) {
				CopyBytes (source, Target, Source.Length);
			}
		}


	}   // class

}   //	namespace	2019-04-14 - 16.51.18