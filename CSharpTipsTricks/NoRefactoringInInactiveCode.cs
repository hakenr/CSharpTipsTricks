using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havit.Demos.CSharpTipsTricks
{
    public static class NoRefactoringInInactiveCode
    {
        public static void DoSomething()
		{
			var demo = 10; // try to rename

#if DEBUG
			Console.WriteLine(demo);
#else
			Console.Error.WriteLine(demo);
#endif
		}

		// =================================================================================

		public static void DoSomething2()
		{
			var demo = 11;

			WriteDebug(demo);
			WriteRelease(demo);
		}

		[Conditional("DEBUG")]
		private static void WriteDebug(int demo)
		{
			Console.WriteLine(demo);
		}

		[Conditional("RELEASE")]  // does not exists if not added explicitly!
		private static void WriteRelease(int demo)
		{

			Console.Error.WriteLine(demo);
		}
	}
}
