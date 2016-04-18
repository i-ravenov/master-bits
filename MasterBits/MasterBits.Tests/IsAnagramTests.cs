using System;
using NUnit;
using MasterBits;
using NUnit.Framework;

namespace MasterBits.Tests
{
    [TestFixture]
    public class IsAnagramTests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, StringExt.IsAnagram("aba","baa"));
            Assert.AreEqual(false, StringExt.IsAnagram("aba", "ba"));
        }
    }
}
