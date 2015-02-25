using Hyde.Exceptions;
using NUnit.Framework;

namespace Hyde.Tests
{
	[TestFixture]
	public class OptionTests
	{
		[Test]
		public void ParseOptions_UnknownOption_ThrowsUnknownOptionException()
		{
			Assert.Throws<UnknownOptionException>(() => Option.ParseOptions("build -unknown".Split(' ')));
		}

		[Test]
		public void ParseOptions_MissingArgument_ThrowsMissingOptionArgumentException()
		{
			Assert.Throws<MissingOptionArgumentException>(() => Option.ParseOptions("build -source".Split(' ')));
		}

		[Test]
		public void ParseOptions_ValidOptions_ReturnsOptionsList()
		{
			var options = Option.ParseOptions("build -source c:\temp -destination c:\temp2".Split(' '));

			Assert.AreEqual(2, options.Count);
			Assert.AreEqual(OptionType.Source, options[0].Type);
			Assert.AreEqual("c:\temp", options[0].Value);
			Assert.AreEqual(OptionType.Destination, options[1].Type);
			Assert.AreEqual("c:\temp2", options[1].Value);
		}
	}
}
