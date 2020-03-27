using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diub.Unmanaged {

	/// <summary>
	/// Stellt Funktionen bereit zum Kopieren in und aus Byte-Arrays für "Unmanaged-Types", die "fixed*" verwenden.
	/// </summary>
	static public partial class Copy {

		/// <summary>
		/// Kopiert eine Abfolge vom Typ 'byte' via Pointer auf Basis von "UInt32"-Zugriffen. 
		/// Ein "Length-Alignment-Mismatch" wird ausgeglichen.
		/// </summary>
		/// <param name="Source"></param>
		/// <param name="Target"></param>
		/// <param name="Length"></param>
		/// <returns></returns>
		unsafe static public void CopyUnsafe (byte* Source, byte* Target, Int32 Length) {
			int i, rest;
			UInt32 * s, t;
			byte * bs, bt;

			s = (UInt32*) (Source);
			t = (UInt32*) (Target);
			// i += 4 : für 4 Byte je UInt32; dabei kann i tatsächlich gößer Length werden → Modulo
			for (i = 0; i < Length; i += 4) {
				*t = *s;	// Kopieren
				s++;		// Pointer Increment ala MS: plus Größe des 'Type', hier für 'Int32'; l+=4
				t++;
			}

			// Modulo: falls die Länge nicht glatt auf 32 Bit / 4 Byte aufgeht.
			rest = Length % 4;
			if (rest == 0)
				return;
			// Auf 'byte'-Zeiger zurückgehen.
			s--;
			bs = (byte*) s;
			t--;
			bt = (byte*) t;
			for (i = 0; i < rest; i++) {
				*bt = *bs;
				bs++;
				bt++;
			}
		}


		/// <summary>
		/// Kopiert eine Abfolge vom Typ "<typeparamref name="T"/>" via Pointer auf Basis von "UInt32"-Zugriffen. 
		/// 'Unmanaged Types' sind:sbyte, byte, short, ushort, int, uint, long, ulong, char, float, double, decimal, bool
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="Source">Linkes/Erstes Array für Vergleich.</param>
		/// <param name="SourceStart">Startpunkt innerhalb des linken Array.</param>
		/// <param name="Target">Rechtes/Zweites Array für Vergleich.</param>
		/// <param name="TargetStart">Startpunkt innerhalb des rechten Array.</param>
		/// <param name="Length">Anzahl der zu vergleichenden Elemente.</param>
		/// <returns></returns>
		unsafe static public void CopyUnmanaged<T> (this T [] Source, Int32 SourceStart, T [] Target, Int32 TargetStart, Int32 Length) where T : unmanaged {
			byte* l, r;
			int size;

			size = sizeof (T);
			fixed (void* left = Source) {
				l = ((byte*) left + SourceStart * size);
				fixed (void* right = Target) {
					r = ((byte*) right + TargetStart * size);
					CopyUnsafe (l, r, Length * size);  // Example: Int32 == 4 Byte
				}
			}
		}


	}   // class

}	//	namespace	2020-02-21 - 12.21.59