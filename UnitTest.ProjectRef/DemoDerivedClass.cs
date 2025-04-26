using MSTest.Bug;

namespace UnitTest.ProjectRef
{
	internal class DemoDerivedClass : DemoClass
	{
		public override void AbstractMethod ()
		{
			throw new System.NotImplementedException ();
		}
	}
}
