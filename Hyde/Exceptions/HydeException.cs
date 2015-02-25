using System;

namespace Hyde.Exceptions
{
	public abstract class HydeException : Exception
	{
		public HydeException(string message) : base(message) { }
	}
}
