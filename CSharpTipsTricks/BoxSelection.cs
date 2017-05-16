using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havit.Demos.CSharpTipsTricks
{
	public class BoxSelection  // Alt + Select
	{
		// original
		private List<string> literals;
		private List<string> nodes;
		private List<string> stopWords;
		private List<string> dividers;

		// goal
		private readonly HashSet<string> _literals;
		private readonly HashSet<string> _nodes;
		private readonly HashSet<string> _stopWords;
		private readonly HashSet<string> _dividers;

		public BoxSelection()
		{
			_literals = new HashSet<string>();
			_nodes = new HashSet<string>();
			_stopWords = new HashSet<string>();
			_dividers = new HashSet<string>();
		}
	}
}
