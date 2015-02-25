namespace Jekyll.Exceptions
{
	public class MissingCommandException : JekyllException
	{
		public MissingCommandException()
			: base("No command specified") { }
	}
}
