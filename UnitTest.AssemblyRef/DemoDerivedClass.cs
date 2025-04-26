using MSTest.Bug;

namespace UnitTest.AssemblyRef
{
	internal class DemoDerivedClass : DemoClass
	{
		public override void AbstractMethod ()
		{
			throw new System.NotImplementedException ();
		}
	}
}
