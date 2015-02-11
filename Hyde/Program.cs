using System;

namespace Hyde
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var command = Command.Parse(args);

			if (command == null)
			{
				Console.WriteLine("No command specified.");
				Console.WriteLine("Usage: hyde <command> [options]");
				Console.WriteLine("Use 'hyde help' for a list of available commands.");
				return;
			}
			else if (command.Type == CommandType.Unknown)
			{
				Console.WriteLine("Unknown command: " + args[0]);
				Console.WriteLine("Use 'hyde help' for a list of available commands.");
				return;
			}

			command.Execute();
		}
	}
}
