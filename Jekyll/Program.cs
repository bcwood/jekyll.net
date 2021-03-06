﻿using System;
using Jekyll.Exceptions;

namespace Jekyll
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
			catch (JekyllException ex)
			{
				Console.WriteLine(ex.Message);

				if (ex is MissingCommandException)
				{
					Console.WriteLine("Usage: Jekyll <command> [options]");
					Console.WriteLine("Use 'Jekyll help' for a list of available commands.");
				}
				else if (ex is UnknownCommandException)
				{
					Console.WriteLine("Use 'Jekyll help' for a list of available commands.");
				}
				else if (ex is UnknownOptionException || ex is MissingOptionArgumentException)
				{
					Console.WriteLine("Use 'Jekyll {0} help' for help with usage of that command.", args[0]);
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
