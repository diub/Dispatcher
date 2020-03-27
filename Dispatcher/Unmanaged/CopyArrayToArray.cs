
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Id = System.Int64;

namespace diub.Unmanaged {

	static public partial class Copy {
		
		/// <summary>
		/// Kopiert die Werte einzeln via *ptr++.
		/// </summary>
		/// <param name="Source"></param>
		/// <param name="Target"></param>
		/// <param name="Length"></param>
		unsafe static public void CopySBytes (SByte* Source, SByte* Target, int Length) {
			for (int i = 0; i < Length; i++) {
				*Target = *Source;		// 
				Source++;
				Target++;
			}
		}

		/// <summary>
		/// Kopiert die Werte auf Basis von "Int32 *ptr". Ein "Length alignment mismatch" wird ausgeglichen.
		/// </summary>
		/// <param name="Source">Quell-Array.</param>
		/// <param name="SourceStart">Startpunkt innerhalb des Quell-Array.</param>
		/// <param name="Target">Ziel-Array.</param>
		/// <param name="TargetStart">Startpunkt innerhalb des Ziel-Array.</param>
		/// <param name="Length">Anzahl der zu kopierenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public void CopySBytes (this SByte [] Source, Int32 SourceStart, SByte [] Target, Int32 TargetStart, Int32 Length) {
			CopyUnmanaged<SByte> (Source, SourceStart, Target, TargetStart, Length);
		}
	
		/// <summary>
		/// Kopiert die Werte einzeln via *ptr++.
		/// </summary>
		/// <param name="Source"></param>
		/// <param name="Target"></param>
		/// <param name="Length"></param>
		unsafe static public void CopyBytes (Byte* Source, Byte* Target, int Length) {
			for (int i = 0; i < Length; i++) {
				*Target = *Source;		// 
				Source++;
				Target++;
			}
		}

		/// <summary>
		/// Kopiert die Werte auf Basis von "Int32 *ptr". Ein "Length alignment mismatch" wird ausgeglichen.
		/// </summary>
		/// <param name="Source">Quell-Array.</param>
		/// <param name="SourceStart">Startpunkt innerhalb des Quell-Array.</param>
		/// <param name="Target">Ziel-Array.</param>
		/// <param name="TargetStart">Startpunkt innerhalb des Ziel-Array.</param>
		/// <param name="Length">Anzahl der zu kopierenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public void CopyBytes (this Byte [] Source, Int32 SourceStart, Byte [] Target, Int32 TargetStart, Int32 Length) {
			CopyUnmanaged<Byte> (Source, SourceStart, Target, TargetStart, Length);
		}
	
		/// <summary>
		/// Kopiert die Werte einzeln via *ptr++.
		/// </summary>
		/// <param name="Source"></param>
		/// <param name="Target"></param>
		/// <param name="Length"></param>
		unsafe static public void CopyInt16s (Int16* Source, Int16* Target, int Length) {
			for (int i = 0; i < Length; i++) {
				*Target = *Source;		// 
				Source++;
				Target++;
			}
		}

		/// <summary>
		/// Kopiert die Werte auf Basis von "Int32 *ptr". Ein "Length alignment mismatch" wird ausgeglichen.
		/// </summary>
		/// <param name="Source">Quell-Array.</param>
		/// <param name="SourceStart">Startpunkt innerhalb des Quell-Array.</param>
		/// <param name="Target">Ziel-Array.</param>
		/// <param name="TargetStart">Startpunkt innerhalb des Ziel-Array.</param>
		/// <param name="Length">Anzahl der zu kopierenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public void CopyInt16s (this Int16 [] Source, Int32 SourceStart, Int16 [] Target, Int32 TargetStart, Int32 Length) {
			CopyUnmanaged<Int16> (Source, SourceStart, Target, TargetStart, Length);
		}
	
		/// <summary>
		/// Kopiert die Werte einzeln via *ptr++.
		/// </summary>
		/// <param name="Source"></param>
		/// <param name="Target"></param>
		/// <param name="Length"></param>
		unsafe static public void CopyUInt16s (UInt16* Source, UInt16* Target, int Length) {
			for (int i = 0; i < Length; i++) {
				*Target = *Source;		// 
				Source++;
				Target++;
			}
		}

		/// <summary>
		/// Kopiert die Werte auf Basis von "Int32 *ptr". Ein "Length alignment mismatch" wird ausgeglichen.
		/// </summary>
		/// <param name="Source">Quell-Array.</param>
		/// <param name="SourceStart">Startpunkt innerhalb des Quell-Array.</param>
		/// <param name="Target">Ziel-Array.</param>
		/// <param name="TargetStart">Startpunkt innerhalb des Ziel-Array.</param>
		/// <param name="Length">Anzahl der zu kopierenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public void CopyUInt16s (this UInt16 [] Source, Int32 SourceStart, UInt16 [] Target, Int32 TargetStart, Int32 Length) {
			CopyUnmanaged<UInt16> (Source, SourceStart, Target, TargetStart, Length);
		}
	
		/// <summary>
		/// Kopiert die Werte einzeln via *ptr++.
		/// </summary>
		/// <param name="Source"></param>
		/// <param name="Target"></param>
		/// <param name="Length"></param>
		unsafe static public void CopyInt32s (Int32* Source, Int32* Target, int Length) {
			for (int i = 0; i < Length; i++) {
				*Target = *Source;		// 
				Source++;
				Target++;
			}
		}

		/// <summary>
		/// Kopiert die Werte auf Basis von "Int32 *ptr". Ein "Length alignment mismatch" wird ausgeglichen.
		/// </summary>
		/// <param name="Source">Quell-Array.</param>
		/// <param name="SourceStart">Startpunkt innerhalb des Quell-Array.</param>
		/// <param name="Target">Ziel-Array.</param>
		/// <param name="TargetStart">Startpunkt innerhalb des Ziel-Array.</param>
		/// <param name="Length">Anzahl der zu kopierenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public void CopyInt32s (this Int32 [] Source, Int32 SourceStart, Int32 [] Target, Int32 TargetStart, Int32 Length) {
			CopyUnmanaged<Int32> (Source, SourceStart, Target, TargetStart, Length);
		}
	
		/// <summary>
		/// Kopiert die Werte einzeln via *ptr++.
		/// </summary>
		/// <param name="Source"></param>
		/// <param name="Target"></param>
		/// <param name="Length"></param>
		unsafe static public void CopyUInt32s (UInt32* Source, UInt32* Target, int Length) {
			for (int i = 0; i < Length; i++) {
				*Target = *Source;		// 
				Source++;
				Target++;
			}
		}

		/// <summary>
		/// Kopiert die Werte auf Basis von "Int32 *ptr". Ein "Length alignment mismatch" wird ausgeglichen.
		/// </summary>
		/// <param name="Source">Quell-Array.</param>
		/// <param name="SourceStart">Startpunkt innerhalb des Quell-Array.</param>
		/// <param name="Target">Ziel-Array.</param>
		/// <param name="TargetStart">Startpunkt innerhalb des Ziel-Array.</param>
		/// <param name="Length">Anzahl der zu kopierenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public void CopyUInt32s (this UInt32 [] Source, Int32 SourceStart, UInt32 [] Target, Int32 TargetStart, Int32 Length) {
			CopyUnmanaged<UInt32> (Source, SourceStart, Target, TargetStart, Length);
		}
	
		/// <summary>
		/// Kopiert die Werte einzeln via *ptr++.
		/// </summary>
		/// <param name="Source"></param>
		/// <param name="Target"></param>
		/// <param name="Length"></param>
		unsafe static public void CopyInt64s (Int64* Source, Int64* Target, int Length) {
			for (int i = 0; i < Length; i++) {
				*Target = *Source;		// 
				Source++;
				Target++;
			}
		}

		/// <summary>
		/// Kopiert die Werte auf Basis von "Int32 *ptr". Ein "Length alignment mismatch" wird ausgeglichen.
		/// </summary>
		/// <param name="Source">Quell-Array.</param>
		/// <param name="SourceStart">Startpunkt innerhalb des Quell-Array.</param>
		/// <param name="Target">Ziel-Array.</param>
		/// <param name="TargetStart">Startpunkt innerhalb des Ziel-Array.</param>
		/// <param name="Length">Anzahl der zu kopierenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public void CopyInt64s (this Int64 [] Source, Int32 SourceStart, Int64 [] Target, Int32 TargetStart, Int32 Length) {
			CopyUnmanaged<Int64> (Source, SourceStart, Target, TargetStart, Length);
		}
	
		/// <summary>
		/// Kopiert die Werte einzeln via *ptr++.
		/// </summary>
		/// <param name="Source"></param>
		/// <param name="Target"></param>
		/// <param name="Length"></param>
		unsafe static public void CopyUInt64s (UInt64* Source, UInt64* Target, int Length) {
			for (int i = 0; i < Length; i++) {
				*Target = *Source;		// 
				Source++;
				Target++;
			}
		}

		/// <summary>
		/// Kopiert die Werte auf Basis von "Int32 *ptr". Ein "Length alignment mismatch" wird ausgeglichen.
		/// </summary>
		/// <param name="Source">Quell-Array.</param>
		/// <param name="SourceStart">Startpunkt innerhalb des Quell-Array.</param>
		/// <param name="Target">Ziel-Array.</param>
		/// <param name="TargetStart">Startpunkt innerhalb des Ziel-Array.</param>
		/// <param name="Length">Anzahl der zu kopierenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public void CopyUInt64s (this UInt64 [] Source, Int32 SourceStart, UInt64 [] Target, Int32 TargetStart, Int32 Length) {
			CopyUnmanaged<UInt64> (Source, SourceStart, Target, TargetStart, Length);
		}
	
		/// <summary>
		/// Kopiert die Werte einzeln via *ptr++.
		/// </summary>
		/// <param name="Source"></param>
		/// <param name="Target"></param>
		/// <param name="Length"></param>
		unsafe static public void CopyChars (Char* Source, Char* Target, int Length) {
			for (int i = 0; i < Length; i++) {
				*Target = *Source;		// 
				Source++;
				Target++;
			}
		}

		/// <summary>
		/// Kopiert die Werte auf Basis von "Int32 *ptr". Ein "Length alignment mismatch" wird ausgeglichen.
		/// </summary>
		/// <param name="Source">Quell-Array.</param>
		/// <param name="SourceStart">Startpunkt innerhalb des Quell-Array.</param>
		/// <param name="Target">Ziel-Array.</param>
		/// <param name="TargetStart">Startpunkt innerhalb des Ziel-Array.</param>
		/// <param name="Length">Anzahl der zu kopierenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public void CopyChars (this Char [] Source, Int32 SourceStart, Char [] Target, Int32 TargetStart, Int32 Length) {
			CopyUnmanaged<Char> (Source, SourceStart, Target, TargetStart, Length);
		}
	
		/// <summary>
		/// Kopiert die Werte einzeln via *ptr++.
		/// </summary>
		/// <param name="Source"></param>
		/// <param name="Target"></param>
		/// <param name="Length"></param>
		unsafe static public void CopyFloats (float* Source, float* Target, int Length) {
			for (int i = 0; i < Length; i++) {
				*Target = *Source;		// 
				Source++;
				Target++;
			}
		}

		/// <summary>
		/// Kopiert die Werte auf Basis von "Int32 *ptr". Ein "Length alignment mismatch" wird ausgeglichen.
		/// </summary>
		/// <param name="Source">Quell-Array.</param>
		/// <param name="SourceStart">Startpunkt innerhalb des Quell-Array.</param>
		/// <param name="Target">Ziel-Array.</param>
		/// <param name="TargetStart">Startpunkt innerhalb des Ziel-Array.</param>
		/// <param name="Length">Anzahl der zu kopierenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public void CopyFloats (this float [] Source, Int32 SourceStart, float [] Target, Int32 TargetStart, Int32 Length) {
			CopyUnmanaged<float> (Source, SourceStart, Target, TargetStart, Length);
		}
	
		/// <summary>
		/// Kopiert die Werte einzeln via *ptr++.
		/// </summary>
		/// <param name="Source"></param>
		/// <param name="Target"></param>
		/// <param name="Length"></param>
		unsafe static public void CopyDoubles (double* Source, double* Target, int Length) {
			for (int i = 0; i < Length; i++) {
				*Target = *Source;		// 
				Source++;
				Target++;
			}
		}

		/// <summary>
		/// Kopiert die Werte auf Basis von "Int32 *ptr". Ein "Length alignment mismatch" wird ausgeglichen.
		/// </summary>
		/// <param name="Source">Quell-Array.</param>
		/// <param name="SourceStart">Startpunkt innerhalb des Quell-Array.</param>
		/// <param name="Target">Ziel-Array.</param>
		/// <param name="TargetStart">Startpunkt innerhalb des Ziel-Array.</param>
		/// <param name="Length">Anzahl der zu kopierenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public void CopyDoubles (this double [] Source, Int32 SourceStart, double [] Target, Int32 TargetStart, Int32 Length) {
			CopyUnmanaged<double> (Source, SourceStart, Target, TargetStart, Length);
		}
	
		/// <summary>
		/// Kopiert die Werte einzeln via *ptr++.
		/// </summary>
		/// <param name="Source"></param>
		/// <param name="Target"></param>
		/// <param name="Length"></param>
		unsafe static public void CopyDecimals (decimal* Source, decimal* Target, int Length) {
			for (int i = 0; i < Length; i++) {
				*Target = *Source;		// 
				Source++;
				Target++;
			}
		}

		/// <summary>
		/// Kopiert die Werte auf Basis von "Int32 *ptr". Ein "Length alignment mismatch" wird ausgeglichen.
		/// </summary>
		/// <param name="Source">Quell-Array.</param>
		/// <param name="SourceStart">Startpunkt innerhalb des Quell-Array.</param>
		/// <param name="Target">Ziel-Array.</param>
		/// <param name="TargetStart">Startpunkt innerhalb des Ziel-Array.</param>
		/// <param name="Length">Anzahl der zu kopierenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public void CopyDecimals (this decimal [] Source, Int32 SourceStart, decimal [] Target, Int32 TargetStart, Int32 Length) {
			CopyUnmanaged<decimal> (Source, SourceStart, Target, TargetStart, Length);
		}
	
		/// <summary>
		/// Kopiert die Werte einzeln via *ptr++.
		/// </summary>
		/// <param name="Source"></param>
		/// <param name="Target"></param>
		/// <param name="Length"></param>
		unsafe static public void CopyBools (bool* Source, bool* Target, int Length) {
			for (int i = 0; i < Length; i++) {
				*Target = *Source;		// 
				Source++;
				Target++;
			}
		}

		/// <summary>
		/// Kopiert die Werte auf Basis von "Int32 *ptr". Ein "Length alignment mismatch" wird ausgeglichen.
		/// </summary>
		/// <param name="Source">Quell-Array.</param>
		/// <param name="SourceStart">Startpunkt innerhalb des Quell-Array.</param>
		/// <param name="Target">Ziel-Array.</param>
		/// <param name="TargetStart">Startpunkt innerhalb des Ziel-Array.</param>
		/// <param name="Length">Anzahl der zu kopierenden Elemente.</param>
		/// <returns>True: falls vollständig gleich; sonst False.</returns>
		unsafe static public void CopyBools (this bool [] Source, Int32 SourceStart, bool [] Target, Int32 TargetStart, Int32 Length) {
			CopyUnmanaged<bool> (Source, SourceStart, Target, TargetStart, Length);
		}

	}	// class

}	//	namespace	2020-02-20 - 18.15.23