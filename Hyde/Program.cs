using System;
using Hyde.Exceptions;

namespace Hyde
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Command command;

			try
			{
				command = Command.Parse(args);
			}
			catch (HydeException ex)
			{
				Console.WriteLine(ex.Message);

				if (ex is MissingCommandException)
				{
					Console.WriteLine("Usage: hyde <command> [options]");
					Console.WriteLine("Use 'hyde help' for a list of available commands.");
				}
				else if (ex is UnknownCommandException)
				{
					Console.WriteLine("Use 'hyde help' for a list of available commands.");
				}
				else if (ex is UnknownOptionException || ex is MissingOptionArgumentException)
				{
					Console.WriteLine("Use 'hyde {0} help' for help with usage of that command.", args[0]);
				}
				else
				{
					throw;
				}

				return;
			}

			command.Execute();
		}
	}
}
