namespace Jekyll.Exceptions
{
	public class UnknownCommandException : JekyllException
	{
		public UnknownCommandException(string command)
			: base(string.Format("Unknown command '{0}'", command)) { }
	}
}
