using System;
using System.Collections.Generic;
//using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Reflection.Emit;


namespace diub.Threads {

	static public partial class Invoker {



		/// <summary>
		/// Sucht die Funktion passend zu Namen, Parametern und generischen Typen. <para></para>
		/// Hinweis: die ursprüngliche (stark eingeschränkte) Funktion stammt von https://www.codeproject.com/articles/22615/dynamically-invoke-generic-methods
		/// </summary>
		/// <param name="ClassType">Typ der Klasse, in der die Methode gesucht wird.</param>
		/// <param name="MethodName">Name der Methode, die gesucht wird.</param>
		/// <param name="GenericTypes">Typen der generischen Typ-Angaben oder leeres Array.</param>
		/// <param name="ParameterTypes">Typen der Parameter oder leeres Array.</param>
		/// <returns></returns>
		static private MethodInfo FindMethod (Type ClassType, string MethodName, Type [] GenericTypes, Type [] ParameterTypes) {
			int parameter_mismatches, least_mismatches, weighted_points;
			ParameterInfo [] parameter_infos;
			MethodInfo[] methods;
			MethodInfo method, generic_method;
			Type parameter_type;

			parameter_infos = null;
			least_mismatches = 1000;
			method = null;
			methods = ClassType.GetMethods (BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
			foreach (MethodInfo method_info in methods) {
				if (method_info.Name != MethodName)
					continue;
				if (method_info.IsGenericMethod) {
					generic_method = method_info.MakeGenericMethod (GenericTypes);
					parameter_infos = generic_method.GetParameters ();
				} else {
					generic_method = method_info;
					parameter_infos = method_info.GetParameters ();
				}
				if (parameter_infos.Length != ParameterTypes.Length)
					continue;
				parameter_mismatches = 0;
				for (int i = 0; i < parameter_infos.Length; i++) {
					parameter_type = ParameterTypes [i];
					weighted_points = parameter_infos.Length + 1 - i;
					while (parameter_type != null && parameter_infos [i].ParameterType != parameter_type) {
						parameter_mismatches += weighted_points;
						parameter_type = parameter_type.BaseType;
					}
					if (parameter_type == null)
						goto BREAK_NONGENERIC;
				}
				// Besten Treffer auswählen
				if (parameter_mismatches < least_mismatches) {
					method = generic_method;
					least_mismatches = parameter_mismatches;
				}
				BREAK_NONGENERIC:
				;
			}
			if (method == null)
				throw new InvalidOperationException ("Method not found!");
			return method;
		}

	}   // class

}   //	namespace	2020-03-27 - 09.52.56