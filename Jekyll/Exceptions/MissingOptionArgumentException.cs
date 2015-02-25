namespace Jekyll.Exceptions
{
	public class MissingOptionArgumentException : JekyllException
	{
		public string Option { get; private set; }

		public MissingOptionArgumentException(string option)
			: base(string.Format("No argument supplied for option '{0}'", option))
		{
			this.Option = option;
		}
	}
}
