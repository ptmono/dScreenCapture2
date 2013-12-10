using System;
using NUnit.Framework;
using System.Text.RegularExpressions;
using Libs;

namespace Libs.Tests
{
    [TestFixture]
    public class Preparing
    {
	[Test]
	public void basic()
	    {
		String aa = "ab";
		String bb = "ab";
		//Assert.AreEqual(3, 4);
		Assert.AreEqual(aa, bb);
	    }

	[Test]
	public void prepare_regexp()
	    {
		String filename_regexp = "([^\\s]+(\\.(?i)(jpg|png|gif|bmp))$)";
		String filename = "ccc.png";
		String filename2 = "ccc.jpg";
		String filename3 = "ccc.PNG";

		Match match = Regex.Match(filename, filename_regexp);
		Match match2 = Regex.Match(filename2, filename_regexp);
		Match match3 = Regex.Match(filename3, filename_regexp);

		Assert.IsTrue(match.Success);
		Assert.IsTrue(match2.Success);
		Assert.IsTrue(match3.Success);
		
	    }

    }
}
