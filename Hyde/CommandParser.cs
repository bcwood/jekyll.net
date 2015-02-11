using System;
using System.Linq;

namespace Hyde
{
	public enum CommandType
	{
		Build,
		Help,
		Unknown
	}

	public class Command
	{
		public CommandType Type { get; set; }
		public string[] Args { get; set; }

		public static Command Parse(string[] args)
		{
			if (!args.Any())
			{
				return null;
			}

			var commandArg = args[0];
			var command = new Command();

			switch (commandArg)
			{
				case "build":
					command.Type = CommandType.Build;
					break;

				case "help":
					command.Type = CommandType.Help;
					break;

				default:
					command.Type = CommandType.Unknown;
					break;
			}

			// TODO: parse command options

			return command;
		}

		public void Execute()
		{
			throw new NotImplementedException();
		}
	}
}
