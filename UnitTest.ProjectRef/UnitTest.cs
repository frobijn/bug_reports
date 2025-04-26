using System;

namespace UnitTest.ProjectRef
{
	[TestClass]
	public class UnitTest
	{
		[TestMethod]
		public void Test ()
		{
			var actual = new DemoDerivedClass ();
			Assert.ThrowsExactly<NotImplementedException> (() =>
			{
				actual.AbstractMethod ();
			});
		}
	}
}
