namespace Hyde.Exceptions
{
	public class UnknownCommandException : HydeException
	{
		public UnknownCommandException(string command)
			: base(string.Format("Unknown command '{0}'", command)) { }
	}
}
