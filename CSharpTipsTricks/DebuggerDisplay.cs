using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havit.Demos.CSharpTipsTricks
{
    public class DebuggerDisplay
    {
		public static void Foo()
		{
			var customer = new Customer()
			{
				Id = 10,
				Name = "HAVIT, s.r.o.",
				Address = "Budějovická 778/3a, Praha 4"
			};

			Debugger.Break();
		}
        
    }

	[DebuggerDisplay("{Name} [#{Id}]")]
	public class Customer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
	}

	// https://docs.microsoft.com/en-us/dotnet/api/system.diagnostics.debuggerdisplayattribute?view=netframework-4.7
}
