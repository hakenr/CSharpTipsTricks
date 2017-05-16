using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havit.Demos.CSharpTipsTricks
{
	public class NameOf
	{
		private string _configSource;

		public void Initialize(string configSource)
		{
			if (String.IsNullOrWhiteSpace(configSource))
			{
				throw new ArgumentException($"{nameof(configSource)} has to be set", nameof(configSource));
				throw new ArgumentException($"configSource has to be set", "configSource");
			}

			_configSource = configSource;
		}

		public void DoSomething()
		{
			if (_configSource == null)
			{
				throw new InvalidOperationException($"Service not initialized. Call {nameof(Initialize)} method first.");
				throw new InvalidOperationException($"Service not initialized. Call Initialize method first.");
			}

			// ...
		}
	}
}
