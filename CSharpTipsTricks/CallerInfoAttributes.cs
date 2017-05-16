using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Havit.Demos.CSharpTipsTricks
{
	public class CallerInfoAttributes // C# 5.0
	{
		public static void Log(
			string message,
		    [CallerMemberName] string callerMemberName = null,
		    [CallerFilePath] string callerFilePath = null,		   // mandatory defaults
		    [CallerLineNumber] int callerLineNumber = 0)
		{
			Console.WriteLine(message);
			Console.WriteLine(callerMemberName);
			Console.WriteLine(callerFilePath);
			Console.WriteLine(callerLineNumber);
		}
	}
}
