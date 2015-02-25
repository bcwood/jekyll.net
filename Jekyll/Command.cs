using System;
using System.Collections.Generic;
using System.Linq;
using Jekyll.Exceptions;

namespace Jekyll
{
	public enum CommandType
	{
		Build,
		Help
	}

	public class Command
	{
		public CommandType Type { get; set; }
		public List<Option> Options { get; set; }

		public static Command Parse(string[] args)
		{
			if (!args.Any())
			{
				throw new MissingCommandException();
			}

			var commandName = args[0];
			var command = new Command();

			switch (commandName.ToLower())
			{
				case "build":
					command.Type = CommandType.Build;
					break;

				case "help":
					command.Type = CommandType.Help;
					break;

				default:
					throw new UnknownCommandException(commandName);
			}

			command.Options = Option.ParseOptions(args);
			return command;
		}

		public void Execute()
		{
			throw new NotImplementedException();
		}
	}
}
