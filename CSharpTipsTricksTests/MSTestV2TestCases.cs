using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Havit.Demos.CSharpTipsTricksTests
{
	[TestClass]
	public class MSTestV2TestCases
	{
		[DataTestMethod]
		[DataRow(1, 2, "3")]
		[DataRow(10, 2, "12")]
		[DataRow(10, 20, "13")]
		public void MSTestV2TestCases_Add(int value1, int value2, string expected)
		{
			string Add(int op1, int op2) => (op1 + op2).ToString(); // C# 7.0 Local function

			Assert.AreEqual(expected, Add(value1, value2));
		}
	}
}
