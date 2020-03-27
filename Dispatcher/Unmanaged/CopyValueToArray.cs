
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Id = System.Int64;

namespace diub.Unmanaged {

	static public partial class Copy {
			/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array und liefert den neuen Offset zurück.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		/// <param name="Value"></param>
		/// <returns>Liefert den neuen Offset.</returns>
		unsafe static public Int32 CopyValue (this byte [] Array, Int32 Offset, SByte Value) {
			fixed (byte* ptr = Array) {
				SByte* vp = (SByte*) (ptr + Offset);
				*vp = Value;
			}
			return Offset + sizeof(SByte);
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		/// <param name="Value"></param>		
		unsafe static public void CopyValue (this byte [] Array, ref Int32 Offset, SByte Value) {
			fixed (byte* ptr = Array) {
				SByte* vp = (SByte*) (ptr + Offset);
				*vp = Value;
				Offset += sizeof(SByte);
			}
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array und liefert den neuen Offset zurück.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		/// <param name="Value"></param>
		/// <returns>Liefert den neuen Offset.</returns>
		unsafe static public Int32 CopyValue (this byte [] Array, Int32 Offset, Byte Value) {
			fixed (byte* ptr = Array) {
				Byte* vp = (Byte*) (ptr + Offset);
				*vp = Value;
			}
			return Offset + sizeof(Byte);
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		/// <param name="Value"></param>		
		unsafe static public void CopyValue (this byte [] Array, ref Int32 Offset, Byte Value) {
			fixed (byte* ptr = Array) {
				Byte* vp = (Byte*) (ptr + Offset);
				*vp = Value;
				Offset += sizeof(Byte);
			}
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array und liefert den neuen Offset zurück.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		/// <param name="Value"></param>
		/// <returns>Liefert den neuen Offset.</returns>
		unsafe static public Int32 CopyValue (this byte [] Array, Int32 Offset, Int16 Value) {
			fixed (byte* ptr = Array) {
				Int16* vp = (Int16*) (ptr + Offset);
				*vp = Value;
			}
			return Offset + sizeof(Int16);
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		/// <param name="Value"></param>		
		unsafe static public void CopyValue (this byte [] Array, ref Int32 Offset, Int16 Value) {
			fixed (byte* ptr = Array) {
				Int16* vp = (Int16*) (ptr + Offset);
				*vp = Value;
				Offset += sizeof(Int16);
			}
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array und liefert den neuen Offset zurück.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		/// <param name="Value"></param>
		/// <returns>Liefert den neuen Offset.</returns>
		unsafe static public Int32 CopyValue (this byte [] Array, Int32 Offset, UInt16 Value) {
			fixed (byte* ptr = Array) {
				UInt16* vp = (UInt16*) (ptr + Offset);
				*vp = Value;
			}
			return Offset + sizeof(UInt16);
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		/// <param name="Value"></param>		
		unsafe static public void CopyValue (this byte [] Array, ref Int32 Offset, UInt16 Value) {
			fixed (byte* ptr = Array) {
				UInt16* vp = (UInt16*) (ptr + Offset);
				*vp = Value;
				Offset += sizeof(UInt16);
			}
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array und liefert den neuen Offset zurück.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		/// <param name="Value"></param>
		/// <returns>Liefert den neuen Offset.</returns>
		unsafe static public Int32 CopyValue (this byte [] Array, Int32 Offset, Int32 Value) {
			fixed (byte* ptr = Array) {
				Int32* vp = (Int32*) (ptr + Offset);
				*vp = Value;
			}
			return Offset + sizeof(Int32);
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		/// <param name="Value"></param>		
		unsafe static public void CopyValue (this byte [] Array, ref Int32 Offset, Int32 Value) {
			fixed (byte* ptr = Array) {
				Int32* vp = (Int32*) (ptr + Offset);
				*vp = Value;
				Offset += sizeof(Int32);
			}
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array und liefert den neuen Offset zurück.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		/// <param name="Value"></param>
		/// <returns>Liefert den neuen Offset.</returns>
		unsafe static public Int32 CopyValue (this byte [] Array, Int32 Offset, UInt32 Value) {
			fixed (byte* ptr = Array) {
				UInt32* vp = (UInt32*) (ptr + Offset);
				*vp = Value;
			}
			return Offset + sizeof(UInt32);
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		/// <param name="Value"></param>		
		unsafe static public void CopyValue (this byte [] Array, ref Int32 Offset, UInt32 Value) {
			fixed (byte* ptr = Array) {
				UInt32* vp = (UInt32*) (ptr + Offset);
				*vp = Value;
				Offset += sizeof(UInt32);
			}
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array und liefert den neuen Offset zurück.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		/// <param name="Value"></param>
		/// <returns>Liefert den neuen Offset.</returns>
		unsafe static public Int32 CopyValue (this byte [] Array, Int32 Offset, Int64 Value) {
			fixed (byte* ptr = Array) {
				Int64* vp = (Int64*) (ptr + Offset);
				*vp = Value;
			}
			return Offset + sizeof(Int64);
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		/// <param name="Value"></param>		
		unsafe static public void CopyValue (this byte [] Array, ref Int32 Offset, Int64 Value) {
			fixed (byte* ptr = Array) {
				Int64* vp = (Int64*) (ptr + Offset);
				*vp = Value;
				Offset += sizeof(Int64);
			}
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array und liefert den neuen Offset zurück.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		/// <param name="Value"></param>
		/// <returns>Liefert den neuen Offset.</returns>
		unsafe static public Int32 CopyValue (this byte [] Array, Int32 Offset, UInt64 Value) {
			fixed (byte* ptr = Array) {
				UInt64* vp = (UInt64*) (ptr + Offset);
				*vp = Value;
			}
			return Offset + sizeof(UInt64);
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		/// <param name="Value"></param>		
		unsafe static public void CopyValue (this byte [] Array, ref Int32 Offset, UInt64 Value) {
			fixed (byte* ptr = Array) {
				UInt64* vp = (UInt64*) (ptr + Offset);
				*vp = Value;
				Offset += sizeof(UInt64);
			}
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array und liefert den neuen Offset zurück.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		/// <param name="Value"></param>
		/// <returns>Liefert den neuen Offset.</returns>
		unsafe static public Int32 CopyValue (this byte [] Array, Int32 Offset, Char Value) {
			fixed (byte* ptr = Array) {
				Char* vp = (Char*) (ptr + Offset);
				*vp = Value;
			}
			return Offset + sizeof(Char);
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		/// <param name="Value"></param>		
		unsafe static public void CopyValue (this byte [] Array, ref Int32 Offset, Char Value) {
			fixed (byte* ptr = Array) {
				Char* vp = (Char*) (ptr + Offset);
				*vp = Value;
				Offset += sizeof(Char);
			}
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array und liefert den neuen Offset zurück.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		/// <param name="Value"></param>
		/// <returns>Liefert den neuen Offset.</returns>
		unsafe static public Int32 CopyValue (this byte [] Array, Int32 Offset, float Value) {
			fixed (byte* ptr = Array) {
				float* vp = (float*) (ptr + Offset);
				*vp = Value;
			}
			return Offset + sizeof(float);
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		/// <param name="Value"></param>		
		unsafe static public void CopyValue (this byte [] Array, ref Int32 Offset, float Value) {
			fixed (byte* ptr = Array) {
				float* vp = (float*) (ptr + Offset);
				*vp = Value;
				Offset += sizeof(float);
			}
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array und liefert den neuen Offset zurück.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		/// <param name="Value"></param>
		/// <returns>Liefert den neuen Offset.</returns>
		unsafe static public Int32 CopyValue (this byte [] Array, Int32 Offset, double Value) {
			fixed (byte* ptr = Array) {
				double* vp = (double*) (ptr + Offset);
				*vp = Value;
			}
			return Offset + sizeof(double);
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		/// <param name="Value"></param>		
		unsafe static public void CopyValue (this byte [] Array, ref Int32 Offset, double Value) {
			fixed (byte* ptr = Array) {
				double* vp = (double*) (ptr + Offset);
				*vp = Value;
				Offset += sizeof(double);
			}
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array und liefert den neuen Offset zurück.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		/// <param name="Value"></param>
		/// <returns>Liefert den neuen Offset.</returns>
		unsafe static public Int32 CopyValue (this byte [] Array, Int32 Offset, decimal Value) {
			fixed (byte* ptr = Array) {
				decimal* vp = (decimal*) (ptr + Offset);
				*vp = Value;
			}
			return Offset + sizeof(decimal);
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		/// <param name="Value"></param>		
		unsafe static public void CopyValue (this byte [] Array, ref Int32 Offset, decimal Value) {
			fixed (byte* ptr = Array) {
				decimal* vp = (decimal*) (ptr + Offset);
				*vp = Value;
				Offset += sizeof(decimal);
			}
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array und liefert den neuen Offset zurück.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		/// <param name="Value"></param>
		/// <returns>Liefert den neuen Offset.</returns>
		unsafe static public Int32 CopyValue (this byte [] Array, Int32 Offset, bool Value) {
			fixed (byte* ptr = Array) {
				bool* vp = (bool*) (ptr + Offset);
				*vp = Value;
			}
			return Offset + sizeof(bool);
		}

		/// <summary>
		/// Kopiert den Wert an die angegebene Stelle in das Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		/// <param name="Value"></param>		
		unsafe static public void CopyValue (this byte [] Array, ref Int32 Offset, bool Value) {
			fixed (byte* ptr = Array) {
				bool* vp = (bool*) (ptr + Offset);
				*vp = Value;
				Offset += sizeof(bool);
			}
		}


	}	// class

}	//	namespace	2020-02-20 - 18.15.23