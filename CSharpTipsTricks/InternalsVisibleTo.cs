using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

// usualy placed in /Properties/AssemblyInfo.cs
[assembly: InternalsVisibleTo("Havit.Demos.CSharpTipsTricksTests")]
[assembly: InternalsVisibleTo("Havit.Demos.CSharpTipsTricksTests.Bllaaaah")]  // you can identify as many assemblies you want (does not have to exist)

namespace Havit.Demos.CSharpTipsTricks
{
    internal class InternalsToTest
	{
		internal int Add(int value1, int value2)
		{
			return value1 + value2;
		}      
    }
}

