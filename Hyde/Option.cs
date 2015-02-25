using System.Collections.Generic;
using Hyde.Exceptions;

namespace Hyde
{
	public enum OptionType
	{
		Source,
		Destination
	}

	public class Option
	{
		public OptionType Type { get; set; }
		public string Value { get; set; }

		public static List<Option> ParseOptions(string[] args)
		{
			var options = new List<Option>();

			for (int i = 1; i < args.Length; i++)
			{
				var option = new Option();

				switch (args[i].ToLower())
				{
					case "-source":
						option.Type = OptionType.Source;
						option.Value = GetOptionArgument(args, i);
						i++;
						break;

					case "-destination":
						option.Type = OptionType.Destination;
						option.Value = GetOptionArgument(args, i);
						i++;
						break;

					default:
						throw new UnknownOptionException(args[i]);
				}

				options.Add(option);
			}

			return options;
		}

		private static string GetOptionArgument(string[] args, int index)
		{
			if (index + 1 < args.Length)
				return args[index + 1];
			else
				throw new MissingOptionArgumentException(args[index]);
		}
	}
}
