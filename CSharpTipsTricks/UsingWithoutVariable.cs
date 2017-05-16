using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Havit.Demos.CSharpTipsTricks
{
	public class UsingWithoutVariable
	{
		public object GetList()
		{
			using (var uow = this.UnitOfWorkProvider.Create())
			{
				return this.QueryFactory.Execute();
			}
		}

		public object GetList2()
		{
			using (this.UnitOfWorkProvider.Create())
			{
				return this.QueryFactory.Execute();
			}
		}

		// see also
		// Razor:	@using (Html.BeginForm(...)) { ... }
		// ORM:		using (new IdentityMapScope()) { ... }





		// fakes for illustration
		public dynamic QueryFactory { get; }
		public dynamic UnitOfWorkProvider { get; }

	}
}
