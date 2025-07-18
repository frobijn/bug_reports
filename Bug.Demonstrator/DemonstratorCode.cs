namespace Bug.Demonstrator
{
	public class DemonstratorCode
	{
		private readonly int _Value;

		public string Method ()
		{
			if (_Value == 0)
			{
				var variableToBeRenamed = "The word variableToBeRenamed in a string";
				return variableToBeRenamed;
			}
			else
			{
				// Use Ctrl-R R to rename variableToBeRenamed
				// See how the "variableToBeRenamed: below changes AND IN BOTH STRINGS!
				var variableToBeRenamed = "The word variableToBeRenamed in another string";
				return variableToBeRenamed;
			}
		}
	}
}
