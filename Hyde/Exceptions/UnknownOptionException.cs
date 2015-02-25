namespace Hyde.Exceptions
{
	public class UnknownOptionException : HydeException
	{
		public UnknownOptionException(string option)
			: base(string.Format("Unknown option '{0}'", option)) { }
	}
}
