using System;
using System.Threading;
using System.Reflection;

namespace diub.Unmanaged {

	/// <summary>
	/// Vergleiche für 'Unmanaged Type'-Arrays via Pointer auf UInt32; ein "Length-Missmatch" wird ausgeglichen.
	/// 'Unmanaged-Type' sind: sbyte, byte, short, ushort, int, uint, long, ulong, char, float, double, decimal, bool
	/// </summary>
	static public partial class CompareArray {

		/// <summary>
		/// Vergleicht zwei Abfolgen vom Typ 'byte' via Pointer auf Basis von "UInt32"-Zugriffen. 
		/// Ein "Length-Allignment-Mismatch" wird ausgeglichen.
		/// </summary>
		/// <param name="Left"></param>
		/// <param name="Right"></param>
		/// <param name="Length"></param>
		/// <returns></returns>
		unsafe static public bool CompareUnsafe (byte* Left, byte* Right, Int32 Length) {
			int i, rest;
			UInt32 * l, r;
			byte * bl, br;

			l = (UInt32*) (Left);
			r = (UInt32*) (Right);
			// i += 4 : für 4 Byte je UInt32; dabei kann i tatsächlich gößer Length werden → Modulo
			for (i = 0; i < Length; i += 4) {
				if (*l != *r)
					return false;
				l++;    // Pointer Increment ala MS: plus Größe des 'Type', hier für 'Int32'; l+=4
				r++;
			}

			// Modulo: falls die Länge nicht glatt auf 32 Bit / 4 Byte aufgeht.
			rest = Length % 4;
			if (rest == 0)
				return true;
			// Auf 'byte'-Zeiger zurückgehen.
			l--;
			bl = (byte*) l;
			r--;
			br = (byte*) r;
			for (i = 0; i < rest; i++) {
				if (*bl != *br)
					return false;
				bl++;
				br++;
			}
			return true;
		}


		/// <summary>
		/// Vergleicht Arrays von 'Unmanaged Types' alias 'ValueTypes'.<para></para>
		/// 'Unmanaged Types' sind:sbyte, byte, short, ushort, int, uint, long, ulong, char, float, double, decimal, bool
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="Left">Linkes/Erstes Array für Vergleich.</param>
		/// <param name="LeftStart">Startpunkt innerhalb des linken Array.</param>
		/// <param name="Right">Rechtes/Zweites Array für Vergleich.</param>
		/// <param name="RightStart">Startpunkt innerhalb des rechten Array.</param>
		/// <param name="Length">Anzahl der zu vergleichenden Elemente.</param>
		/// <returns></returns>
		unsafe static public bool CompareUnmanaged<T> (this T [] Left, Int32 LeftStart, T [] Right, Int32 RightStart, Int32 Length) where T : unmanaged {
			byte* l, r;
			int size;

			size = sizeof (T);
			fixed (void* left = Left) {
				l = ((byte*) left + LeftStart * size);
				fixed (void* right = Right) {
					r = ((byte*) right + RightStart * size);
					return CompareUnsafe (l, r, Length * size);  // Example: Int32 == 4 Byte
				}
			}
		}

	}   // class

}	//	namespace	2020-02-21 - 12.47.07