namespace Jekyll.Exceptions
{
	public class UnknownOptionException : JekyllException
	{
		public UnknownOptionException(string option)
			: base(string.Format("Unknown option '{0}'", option)) { }
	}
}
