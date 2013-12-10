using System;
using NUnit.Framework;
using Libs;

namespace Libs.Tests
{
    [TestFixture]
    public class ImageContainerTest
    {
	[Test]
	public void basic()
	    {
		String aa = "ab";
		String bb = "ab";
		//Assert.AreEqual(3, 4);
		Assert.AreEqual(aa, bb);
	    }

    }
}
