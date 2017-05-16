using System;
using System.Data.SqlClient;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Havit.Demos.CSharpTipsTricksTests
{
	[TestClass]
	public class HardcodedDependenciesTestability
	{
		[TestMethod]
		public void HardcodedDependenciesTest_NoIndividualPriceNoDiscount_ShouldReturnBasicPrice()
		{
			Assert.Inconclusive("Hard to test! Waiting for full IoC/DI refactoring?");

			// 1. Extract dependencies to protected internal virtual methods (internal => visible to test project)
			// 2. Mock the dependency behavior by overriding those virtual methods in derived class
		}
	}

	public class HardcodedDependenciesService
	{
		public decimal GetPrice(int productId, int customerId)
		{
			decimal basicProductPrice = Convert.ToDecimal(File.ReadAllText($@"D:\BasicPrice_{productId}.txt"));

			decimal? individualCustomerPriceForProduct = null;
			using (SqlConnection conn = new SqlConnection("***CONN_STRING***"))
			{
				var cmd = conn.CreateCommand();
				// ...
				individualCustomerPriceForProduct = (decimal?)cmd.ExecuteScalar();
			}

			double productDiscount = new Random().NextDouble();

			return (individualCustomerPriceForProduct ?? basicProductPrice) * (decimal)productDiscount; // bug
		}
	}
}
