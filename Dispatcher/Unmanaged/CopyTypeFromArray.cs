
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Id = System.Int64;

namespace diub.Unmanaged {

	static public partial class Copy {
			 
		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		unsafe static public SByte CopySByte (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				SByte* vpSByte = (SByte*) (ptr + Offset);
				return *vpSByte;
			}
		}

		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		unsafe static public SByte CopySByte (this byte [] Array, ref Int32 Offset) {
			try{
				fixed (byte* ptr = Array) {
					SByte* vpSByte = (SByte*) (ptr + Offset);
					return *vpSByte;
				}
			} finally {
				Offset += sizeof(SByte);
			}
		}

		/// <summary>
		/// Liefert den Wert (und neuen Offset) von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der gelesen wird.</param>
		unsafe static public (SByte, Int32) CopySByteOffset (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				SByte* vpSByte = (SByte*) (ptr + Offset);
				return (*vpSByte, Offset + sizeof(SByte));
			}
		}
		 
		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		unsafe static public Byte CopyByte (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				Byte* vpByte = (Byte*) (ptr + Offset);
				return *vpByte;
			}
		}

		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		unsafe static public Byte CopyByte (this byte [] Array, ref Int32 Offset) {
			try{
				fixed (byte* ptr = Array) {
					Byte* vpByte = (Byte*) (ptr + Offset);
					return *vpByte;
				}
			} finally {
				Offset += sizeof(Byte);
			}
		}

		/// <summary>
		/// Liefert den Wert (und neuen Offset) von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der gelesen wird.</param>
		unsafe static public (Byte, Int32) CopyByteOffset (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				Byte* vpByte = (Byte*) (ptr + Offset);
				return (*vpByte, Offset + sizeof(Byte));
			}
		}
		 
		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		unsafe static public Int16 CopyInt16 (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				Int16* vpInt16 = (Int16*) (ptr + Offset);
				return *vpInt16;
			}
		}

		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		unsafe static public Int16 CopyInt16 (this byte [] Array, ref Int32 Offset) {
			try{
				fixed (byte* ptr = Array) {
					Int16* vpInt16 = (Int16*) (ptr + Offset);
					return *vpInt16;
				}
			} finally {
				Offset += sizeof(Int16);
			}
		}

		/// <summary>
		/// Liefert den Wert (und neuen Offset) von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der gelesen wird.</param>
		unsafe static public (Int16, Int32) CopyInt16Offset (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				Int16* vpInt16 = (Int16*) (ptr + Offset);
				return (*vpInt16, Offset + sizeof(Int16));
			}
		}
		 
		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		unsafe static public UInt16 CopyUInt16 (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				UInt16* vpUInt16 = (UInt16*) (ptr + Offset);
				return *vpUInt16;
			}
		}

		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		unsafe static public UInt16 CopyUInt16 (this byte [] Array, ref Int32 Offset) {
			try{
				fixed (byte* ptr = Array) {
					UInt16* vpUInt16 = (UInt16*) (ptr + Offset);
					return *vpUInt16;
				}
			} finally {
				Offset += sizeof(UInt16);
			}
		}

		/// <summary>
		/// Liefert den Wert (und neuen Offset) von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der gelesen wird.</param>
		unsafe static public (UInt16, Int32) CopyUInt16Offset (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				UInt16* vpUInt16 = (UInt16*) (ptr + Offset);
				return (*vpUInt16, Offset + sizeof(UInt16));
			}
		}
		 
		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		unsafe static public Int32 CopyInt32 (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				Int32* vpInt32 = (Int32*) (ptr + Offset);
				return *vpInt32;
			}
		}

		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		unsafe static public Int32 CopyInt32 (this byte [] Array, ref Int32 Offset) {
			try{
				fixed (byte* ptr = Array) {
					Int32* vpInt32 = (Int32*) (ptr + Offset);
					return *vpInt32;
				}
			} finally {
				Offset += sizeof(Int32);
			}
		}

		/// <summary>
		/// Liefert den Wert (und neuen Offset) von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der gelesen wird.</param>
		unsafe static public (Int32, Int32) CopyInt32Offset (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				Int32* vpInt32 = (Int32*) (ptr + Offset);
				return (*vpInt32, Offset + sizeof(Int32));
			}
		}
		 
		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		unsafe static public UInt32 CopyUInt32 (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				UInt32* vpUInt32 = (UInt32*) (ptr + Offset);
				return *vpUInt32;
			}
		}

		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		unsafe static public UInt32 CopyUInt32 (this byte [] Array, ref Int32 Offset) {
			try{
				fixed (byte* ptr = Array) {
					UInt32* vpUInt32 = (UInt32*) (ptr + Offset);
					return *vpUInt32;
				}
			} finally {
				Offset += sizeof(UInt32);
			}
		}

		/// <summary>
		/// Liefert den Wert (und neuen Offset) von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der gelesen wird.</param>
		unsafe static public (UInt32, Int32) CopyUInt32Offset (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				UInt32* vpUInt32 = (UInt32*) (ptr + Offset);
				return (*vpUInt32, Offset + sizeof(UInt32));
			}
		}
		 
		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		unsafe static public Int64 CopyInt64 (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				Int64* vpInt64 = (Int64*) (ptr + Offset);
				return *vpInt64;
			}
		}

		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		unsafe static public Int64 CopyInt64 (this byte [] Array, ref Int32 Offset) {
			try{
				fixed (byte* ptr = Array) {
					Int64* vpInt64 = (Int64*) (ptr + Offset);
					return *vpInt64;
				}
			} finally {
				Offset += sizeof(Int64);
			}
		}

		/// <summary>
		/// Liefert den Wert (und neuen Offset) von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der gelesen wird.</param>
		unsafe static public (Int64, Int32) CopyInt64Offset (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				Int64* vpInt64 = (Int64*) (ptr + Offset);
				return (*vpInt64, Offset + sizeof(Int64));
			}
		}
		 
		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		unsafe static public UInt64 CopyUInt64 (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				UInt64* vpUInt64 = (UInt64*) (ptr + Offset);
				return *vpUInt64;
			}
		}

		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		unsafe static public UInt64 CopyUInt64 (this byte [] Array, ref Int32 Offset) {
			try{
				fixed (byte* ptr = Array) {
					UInt64* vpUInt64 = (UInt64*) (ptr + Offset);
					return *vpUInt64;
				}
			} finally {
				Offset += sizeof(UInt64);
			}
		}

		/// <summary>
		/// Liefert den Wert (und neuen Offset) von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der gelesen wird.</param>
		unsafe static public (UInt64, Int32) CopyUInt64Offset (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				UInt64* vpUInt64 = (UInt64*) (ptr + Offset);
				return (*vpUInt64, Offset + sizeof(UInt64));
			}
		}
		 
		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		unsafe static public Char CopyChar (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				Char* vpChar = (Char*) (ptr + Offset);
				return *vpChar;
			}
		}

		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		unsafe static public Char CopyChar (this byte [] Array, ref Int32 Offset) {
			try{
				fixed (byte* ptr = Array) {
					Char* vpChar = (Char*) (ptr + Offset);
					return *vpChar;
				}
			} finally {
				Offset += sizeof(Char);
			}
		}

		/// <summary>
		/// Liefert den Wert (und neuen Offset) von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der gelesen wird.</param>
		unsafe static public (Char, Int32) CopyCharOffset (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				Char* vpChar = (Char*) (ptr + Offset);
				return (*vpChar, Offset + sizeof(Char));
			}
		}
		 
		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		unsafe static public float CopyFloat (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				float* vpfloat = (float*) (ptr + Offset);
				return *vpfloat;
			}
		}

		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		unsafe static public float CopyFloat (this byte [] Array, ref Int32 Offset) {
			try{
				fixed (byte* ptr = Array) {
					float* vpfloat = (float*) (ptr + Offset);
					return *vpfloat;
				}
			} finally {
				Offset += sizeof(float);
			}
		}

		/// <summary>
		/// Liefert den Wert (und neuen Offset) von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der gelesen wird.</param>
		unsafe static public (float, Int32) CopyFloatOffset (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				float* vpfloat = (float*) (ptr + Offset);
				return (*vpfloat, Offset + sizeof(float));
			}
		}
		 
		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		unsafe static public double CopyDouble (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				double* vpdouble = (double*) (ptr + Offset);
				return *vpdouble;
			}
		}

		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		unsafe static public double CopyDouble (this byte [] Array, ref Int32 Offset) {
			try{
				fixed (byte* ptr = Array) {
					double* vpdouble = (double*) (ptr + Offset);
					return *vpdouble;
				}
			} finally {
				Offset += sizeof(double);
			}
		}

		/// <summary>
		/// Liefert den Wert (und neuen Offset) von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der gelesen wird.</param>
		unsafe static public (double, Int32) CopyDoubleOffset (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				double* vpdouble = (double*) (ptr + Offset);
				return (*vpdouble, Offset + sizeof(double));
			}
		}
		 
		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		unsafe static public decimal CopyDecimal (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				decimal* vpdecimal = (decimal*) (ptr + Offset);
				return *vpdecimal;
			}
		}

		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		unsafe static public decimal CopyDecimal (this byte [] Array, ref Int32 Offset) {
			try{
				fixed (byte* ptr = Array) {
					decimal* vpdecimal = (decimal*) (ptr + Offset);
					return *vpdecimal;
				}
			} finally {
				Offset += sizeof(decimal);
			}
		}

		/// <summary>
		/// Liefert den Wert (und neuen Offset) von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der gelesen wird.</param>
		unsafe static public (decimal, Int32) CopyDecimalOffset (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				decimal* vpdecimal = (decimal*) (ptr + Offset);
				return (*vpdecimal, Offset + sizeof(decimal));
			}
		}
		 
		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		unsafe static public bool CopyBool (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				bool* vpbool = (bool*) (ptr + Offset);
				return *vpbool;
			}
		}

		/// <summary>
		/// Liefert den Wert von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der geschrieben wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		unsafe static public bool CopyBool (this byte [] Array, ref Int32 Offset) {
			try{
				fixed (byte* ptr = Array) {
					bool* vpbool = (bool*) (ptr + Offset);
					return *vpbool;
				}
			} finally {
				Offset += sizeof(bool);
			}
		}

		/// <summary>
		/// Liefert den Wert (und neuen Offset) von der angegebenen Stelle im Byte-Array.
		/// </summary>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der gelesen wird.</param>
		unsafe static public (bool, Int32) CopyBoolOffset (this byte [] Array, Int32 Offset) {
			fixed (byte* ptr = Array) {
				bool* vpbool = (bool*) (ptr + Offset);
				return (*vpbool, Offset + sizeof(bool));
			}
		}

	}	// class

}	//	namespace	2020-02-20 - 18.15.23