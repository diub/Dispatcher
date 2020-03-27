
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Id = System.Int64;

namespace diub.Unmanaged {

	static public partial class Copy {

	
		/// <summary>
		/// Liefert die Bytes ab der Stelle <paramref name="Offset"/> als Wert.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="Array"></param>
		/// <param name="Offset"></param>
		/// <returns></returns>
		unsafe static public dynamic CopyValue<T> (this byte [] Array, Int32 Offset) where T : unmanaged {
			fixed (byte* ptr = Array) {
				switch (Type.GetTypeCode (typeof (T))) {
	
					case TypeCode.SByte:
						SByte* vpSByte = (SByte*) (ptr + Offset);
						return *vpSByte;
	
					case TypeCode.Byte:
						Byte* vpByte = (Byte*) (ptr + Offset);
						return *vpByte;
	
					case TypeCode.Int16:
						Int16* vpInt16 = (Int16*) (ptr + Offset);
						return *vpInt16;
	
					case TypeCode.UInt16:
						UInt16* vpUInt16 = (UInt16*) (ptr + Offset);
						return *vpUInt16;
	
					case TypeCode.Int32:
						Int32* vpInt32 = (Int32*) (ptr + Offset);
						return *vpInt32;
	
					case TypeCode.UInt32:
						UInt32* vpUInt32 = (UInt32*) (ptr + Offset);
						return *vpUInt32;
	
					case TypeCode.Int64:
						Int64* vpInt64 = (Int64*) (ptr + Offset);
						return *vpInt64;
	
					case TypeCode.UInt64:
						UInt64* vpUInt64 = (UInt64*) (ptr + Offset);
						return *vpUInt64;
	
					case TypeCode.Char:
						Char* vpChar = (Char*) (ptr + Offset);
						return *vpChar;
	
					case TypeCode.Boolean:
						Boolean* vpBoolean = (Boolean*) (ptr + Offset);
						return *vpBoolean;
				}
			}
			throw new Exception ("Not implemented!");
		}


		/// <summary>
		/// Liefert die Bytes ab der Stelle <paramref name="Offset"/> als Wert.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="Array"></param>
		/// <param name="Offset">Position, ab der gelesen wird. Erhöht sich um die Anzhal der gelesenen Bytes!</param>
		/// <returns></returns>
		unsafe static public dynamic CopyValue<T> (this byte [] Array, ref Int32 Offset) where T : unmanaged {
			try {
				fixed (byte* ptr = Array) {
					switch (Type.GetTypeCode (typeof (T))) {
	
						case TypeCode.SByte:
							SByte* vpSByte = (SByte*) (ptr + Offset);
							return *vpSByte;
	
						case TypeCode.Byte:
							Byte* vpByte = (Byte*) (ptr + Offset);
							return *vpByte;
	
						case TypeCode.Int16:
							Int16* vpInt16 = (Int16*) (ptr + Offset);
							return *vpInt16;
	
						case TypeCode.UInt16:
							UInt16* vpUInt16 = (UInt16*) (ptr + Offset);
							return *vpUInt16;
	
						case TypeCode.Int32:
							Int32* vpInt32 = (Int32*) (ptr + Offset);
							return *vpInt32;
	
						case TypeCode.UInt32:
							UInt32* vpUInt32 = (UInt32*) (ptr + Offset);
							return *vpUInt32;
	
						case TypeCode.Int64:
							Int64* vpInt64 = (Int64*) (ptr + Offset);
							return *vpInt64;
	
						case TypeCode.UInt64:
							UInt64* vpUInt64 = (UInt64*) (ptr + Offset);
							return *vpUInt64;
	
						case TypeCode.Char:
							Char* vpChar = (Char*) (ptr + Offset);
							return *vpChar;
	
						case TypeCode.Boolean:
							Boolean* vpBoolean = (Boolean*) (ptr + Offset);
							return *vpBoolean;
					}
				}
			} finally {
				Offset += sizeof(T);
			}
			throw new Exception ("Not implemented!");
		}


	}	// class

}	//	namespace	2020-02-20 - 18.15.23