using System;

namespace Jekyll.Exceptions
{
	public abstract class JekyllException : Exception
	{
		public JekyllException(string message) : base(message) { }
	}
}
