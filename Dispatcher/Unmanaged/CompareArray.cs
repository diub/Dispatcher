// 
// ArrayCompare - © Copyright diub - Dipl.-Ing. Uwe Barth - 2019-11-02
// 
// Vergleiche für 'Unmanaged Type'-Arrays via Pointer auf UInt32; ein "Length-Missmatch" wird ausgeglichen.
//
// 'Unmanaged-Type' sind: sbyte, byte, short, ushort, int, uint, long, ulong, char, float, double, decimal, bool
//

using System;
using System.Threading;
using System.Reflection;

namespace diub.Unmanaged {

	static public partial class CompareArray {


		/// <summary>
		/// Vergleicht Arrays vom Typ 'sbyte'.
		/// </summary>
		/// <param name="Left">Linkes/Erstes Array für Vergleich.</param>
		/// <param name="LeftStart">Startpunkt innerhalb des linken Array.</param>
		/// <param name="Right">Rechtes/Zweites Array für Vergleich.</param>
		/// <param name="RightStart">Startpunkt innerhalb des rechten Array.</param>
		/// <param name="Length">Anzahl der zu vergleichenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public bool Compare (this sbyte [] Left, Int32 LeftStart, sbyte [] Right, Int32 RightStart, Int32 Length) {
			return CompareUnmanaged<sbyte> (Left, LeftStart, Right, RightStart, Length);
		}

		/// <summary>
		/// Vergleicht Arrays vom Typ 'byte'.
		/// </summary>
		/// <param name="Left">Linkes/Erstes Array für Vergleich.</param>
		/// <param name="LeftStart">Startpunkt innerhalb des linken Array.</param>
		/// <param name="Right">Rechtes/Zweites Array für Vergleich.</param>
		/// <param name="RightStart">Startpunkt innerhalb des rechten Array.</param>
		/// <param name="Length">Anzahl der zu vergleichenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public bool Compare (this byte [] Left, Int32 LeftStart, byte [] Right, Int32 RightStart, Int32 Length) {
			return CompareUnmanaged<byte> (Left, LeftStart, Right, RightStart, Length);
		}

		/// <summary>
		/// Vergleicht Arrays vom Typ 'short'.
		/// </summary>
		/// <param name="Left">Linkes/Erstes Array für Vergleich.</param>
		/// <param name="LeftStart">Startpunkt innerhalb des linken Array.</param>
		/// <param name="Right">Rechtes/Zweites Array für Vergleich.</param>
		/// <param name="RightStart">Startpunkt innerhalb des rechten Array.</param>
		/// <param name="Length">Anzahl der zu vergleichenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public bool Compare (this short [] Left, Int32 LeftStart, short [] Right, Int32 RightStart, Int32 Length) {
			return CompareUnmanaged<short> (Left, LeftStart, Right, RightStart, Length);
		}

		/// <summary>
		/// Vergleicht Arrays vom Typ 'ushort'.
		/// </summary>
		/// <param name="Left">Linkes/Erstes Array für Vergleich.</param>
		/// <param name="LeftStart">Startpunkt innerhalb des linken Array.</param>
		/// <param name="Right">Rechtes/Zweites Array für Vergleich.</param>
		/// <param name="RightStart">Startpunkt innerhalb des rechten Array.</param>
		/// <param name="Length">Anzahl der zu vergleichenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public bool Compare (this ushort [] Left, Int32 LeftStart, ushort [] Right, Int32 RightStart, Int32 Length) {
			return CompareUnmanaged<ushort> (Left, LeftStart, Right, RightStart, Length);
		}

		/// <summary>
		/// Vergleicht Arrays vom Typ 'int'.
		/// </summary>
		/// <param name="Left">Linkes/Erstes Array für Vergleich.</param>
		/// <param name="LeftStart">Startpunkt innerhalb des linken Array.</param>
		/// <param name="Right">Rechtes/Zweites Array für Vergleich.</param>
		/// <param name="RightStart">Startpunkt innerhalb des rechten Array.</param>
		/// <param name="Length">Anzahl der zu vergleichenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public bool Compare (this int [] Left, Int32 LeftStart, int [] Right, Int32 RightStart, Int32 Length) {
			return CompareUnmanaged<int> (Left, LeftStart, Right, RightStart, Length);
		}

		/// <summary>
		/// Vergleicht Arrays vom Typ 'uint'.
		/// </summary>
		/// <param name="Left">Linkes/Erstes Array für Vergleich.</param>
		/// <param name="LeftStart">Startpunkt innerhalb des linken Array.</param>
		/// <param name="Right">Rechtes/Zweites Array für Vergleich.</param>
		/// <param name="RightStart">Startpunkt innerhalb des rechten Array.</param>
		/// <param name="Length">Anzahl der zu vergleichenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public bool Compare (this uint [] Left, Int32 LeftStart, uint [] Right, Int32 RightStart, Int32 Length) {
			return CompareUnmanaged<uint> (Left, LeftStart, Right, RightStart, Length);
		}

		/// <summary>
		/// Vergleicht Arrays vom Typ 'long'.
		/// </summary>
		/// <param name="Left">Linkes/Erstes Array für Vergleich.</param>
		/// <param name="LeftStart">Startpunkt innerhalb des linken Array.</param>
		/// <param name="Right">Rechtes/Zweites Array für Vergleich.</param>
		/// <param name="RightStart">Startpunkt innerhalb des rechten Array.</param>
		/// <param name="Length">Anzahl der zu vergleichenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public bool Compare (this long [] Left, Int32 LeftStart, long [] Right, Int32 RightStart, Int32 Length) {
			return CompareUnmanaged<long> (Left, LeftStart, Right, RightStart, Length);
		}

		/// <summary>
		/// Vergleicht Arrays vom Typ 'ulong'.
		/// </summary>
		/// <param name="Left">Linkes/Erstes Array für Vergleich.</param>
		/// <param name="LeftStart">Startpunkt innerhalb des linken Array.</param>
		/// <param name="Right">Rechtes/Zweites Array für Vergleich.</param>
		/// <param name="RightStart">Startpunkt innerhalb des rechten Array.</param>
		/// <param name="Length">Anzahl der zu vergleichenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public bool Compare (this ulong [] Left, Int32 LeftStart, ulong [] Right, Int32 RightStart, Int32 Length) {
			return CompareUnmanaged<ulong> (Left, LeftStart, Right, RightStart, Length);
		}

		/// <summary>
		/// Vergleicht Arrays vom Typ 'char'.
		/// </summary>
		/// <param name="Left">Linkes/Erstes Array für Vergleich.</param>
		/// <param name="LeftStart">Startpunkt innerhalb des linken Array.</param>
		/// <param name="Right">Rechtes/Zweites Array für Vergleich.</param>
		/// <param name="RightStart">Startpunkt innerhalb des rechten Array.</param>
		/// <param name="Length">Anzahl der zu vergleichenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public bool Compare (this char [] Left, Int32 LeftStart, char [] Right, Int32 RightStart, Int32 Length) {
			return CompareUnmanaged<char> (Left, LeftStart, Right, RightStart, Length);
		}

		/// <summary>
		/// Vergleicht Arrays vom Typ 'float'.
		/// </summary>
		/// <param name="Left">Linkes/Erstes Array für Vergleich.</param>
		/// <param name="LeftStart">Startpunkt innerhalb des linken Array.</param>
		/// <param name="Right">Rechtes/Zweites Array für Vergleich.</param>
		/// <param name="RightStart">Startpunkt innerhalb des rechten Array.</param>
		/// <param name="Length">Anzahl der zu vergleichenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public bool Compare (this float [] Left, Int32 LeftStart, float [] Right, Int32 RightStart, Int32 Length) {
			return CompareUnmanaged<float> (Left, LeftStart, Right, RightStart, Length);
		}

		/// <summary>
		/// Vergleicht Arrays vom Typ 'double'.
		/// </summary>
		/// <param name="Left">Linkes/Erstes Array für Vergleich.</param>
		/// <param name="LeftStart">Startpunkt innerhalb des linken Array.</param>
		/// <param name="Right">Rechtes/Zweites Array für Vergleich.</param>
		/// <param name="RightStart">Startpunkt innerhalb des rechten Array.</param>
		/// <param name="Length">Anzahl der zu vergleichenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public bool Compare (this double [] Left, Int32 LeftStart, double [] Right, Int32 RightStart, Int32 Length) {
			return CompareUnmanaged<double> (Left, LeftStart, Right, RightStart, Length);
		}

		/// <summary>
		/// Vergleicht Arrays vom Typ 'decimal'.
		/// </summary>
		/// <param name="Left">Linkes/Erstes Array für Vergleich.</param>
		/// <param name="LeftStart">Startpunkt innerhalb des linken Array.</param>
		/// <param name="Right">Rechtes/Zweites Array für Vergleich.</param>
		/// <param name="RightStart">Startpunkt innerhalb des rechten Array.</param>
		/// <param name="Length">Anzahl der zu vergleichenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public bool Compare (this decimal [] Left, Int32 LeftStart, decimal [] Right, Int32 RightStart, Int32 Length) {
			return CompareUnmanaged<decimal> (Left, LeftStart, Right, RightStart, Length);
		}

		/// <summary>
		/// Vergleicht Arrays vom Typ 'bool'.
		/// </summary>
		/// <param name="Left">Linkes/Erstes Array für Vergleich.</param>
		/// <param name="LeftStart">Startpunkt innerhalb des linken Array.</param>
		/// <param name="Right">Rechtes/Zweites Array für Vergleich.</param>
		/// <param name="RightStart">Startpunkt innerhalb des rechten Array.</param>
		/// <param name="Length">Anzahl der zu vergleichenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public bool Compare (this bool [] Left, Int32 LeftStart, bool [] Right, Int32 RightStart, Int32 Length) {
			return CompareUnmanaged<bool> (Left, LeftStart, Right, RightStart, Length);
		}

	}	// class

}	//	namespace	2019-11-02 - 14.48.53