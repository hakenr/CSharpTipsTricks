using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Havit.Demos.CSharpTipsTricks
{
	public static class AsyncLocal
	{
		private static AsyncLocal<string> _asyncLocalString = new AsyncLocal<string>();

		private static ThreadLocal<string> _threadLocalString = new ThreadLocal<string>();

		private static async Task AsyncMethodA()
		{
			// Start multiple async method calls, with different AsyncLocal values.
			// We also set ThreadLocal values, to demonstrate how the two mechanisms differ.
			_asyncLocalString.Value = "Value 1";
			_threadLocalString.Value = "Value 1";
			var t1 = AsyncMethodB("Value 1");

			_asyncLocalString.Value = "Value 2";
			_threadLocalString.Value = "Value 2";
			var t2 = AsyncMethodB("Value 2");

			// Await both calls
			await t1;
			await t2;
		}

		private static async Task AsyncMethodB(string expectedValue)
		{
			Console.WriteLine("Entering AsyncMethodB.");
			Console.WriteLine($"   Expected '{expectedValue}', AsyncLocal value is '{_asyncLocalString.Value}', ThreadLocal value is '{_threadLocalString.Value}', ThreadId {Thread.CurrentThread.ManagedThreadId}");
			await Task.Delay(100);
			Console.WriteLine("Exiting AsyncMethodB.");
			Console.WriteLine($"   Expected '{expectedValue}', AsyncLocal value is '{_asyncLocalString.Value}', ThreadLocal value is '{_threadLocalString.Value}', ThreadId {Thread.CurrentThread.ManagedThreadId}");
		}

		public static void Demo()
		{
			AsyncMethodA().Wait();
		}
	}
	// The example displays the following output:
	//   Entering AsyncMethodB.
	//      Expected 'Value 1', AsyncLocal value is 'Value 1', ThreadLocal value is 'Value 1'
	//   Entering AsyncMethodB.
	//      Expected 'Value 2', AsyncLocal value is 'Value 2', ThreadLocal value is 'Value 2'
	//   Exiting AsyncMethodB.
	//      Expected 'Value 2', got 'Value 2', ThreadLocal value is ''
	//   Exiting AsyncMethodB.
	//      Expected 'Value 1', got 'Value 1', ThreadLocal value is ''
}

// https://msdn.microsoft.com/en-us/library/dn906268(v=vs.110).aspx