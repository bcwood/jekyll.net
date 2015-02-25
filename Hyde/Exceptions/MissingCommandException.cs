namespace Hyde.Exceptions
{
	public class MissingCommandException : HydeException
	{
		public MissingCommandException()
			: base("No command specified") { }
	}
}
