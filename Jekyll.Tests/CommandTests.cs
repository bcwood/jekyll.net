using Jekyll.Exceptions;
using NUnit.Framework;

namespace Jekyll.Tests
{
	[TestFixture]
    public class CommandTests
    {
		[Test]
		public void Parse_NoCommand_ThrowsMissingCommandException()
		{
			Assert.Throws<MissingCommandException>(() => Command.Parse(new string[0]));
		}

		[Test]
		public void Parse_UnknownCommand_ThrowsUnknownCommandException()
		{
			Assert.Throws<UnknownCommandException>(() => Command.Parse("unknown".Split(' ')));
		}

		[Test]
		public void Parse_ValidCommand_ReturnsCommandObject()
		{
			var command = Command.Parse("build".Split(' '));

			Assert.AreEqual(CommandType.Build, command.Type);
		}
    }
}
