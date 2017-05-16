using System;
using Havit.Demos.CSharpTipsTricks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Havit.Demos.CSharpTipsTricksTests
{
	[TestClass]
	public class InternalsTest
	{
		[TestMethod]
		public void InternalsTest_Add()
		{
			// arrange
			var sut = new InternalsToTest();

			// act
			var result = sut.Add(1, 2);

			// assert
			Assert.AreEqual(3, result);
		}
	}
}
