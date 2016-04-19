using System;
using System.Numerics;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace MasterBits.Tests
{

    [TestFixture]
    public class MyTestGridPath
    {
        [Test]
        public void FirstTest()
        {
            Assert.AreEqual(BigInteger.Parse("2"), GridPath.NumberOfRoutes(1, 1));
        }

        [Test]
        public void Test()
        {
            Assert.AreEqual(BigInteger.Parse("6"), GridPath.NumberOfRoutes(2, 2));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(BigInteger.Parse("20"), GridPath.NumberOfRoutes(3, 3));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(BigInteger.Parse("70"), GridPath.NumberOfRoutes(4, 4));
        }


        [Test]
        public void SecondTest()
        {
            Assert.AreEqual(BigInteger.Parse("6"), GridPath.NumberOfRoutes(5, 1));
        }

        [Test]
        public void ThirdTest()
        {
            Assert.AreEqual(BigInteger.Parse("35"), GridPath.NumberOfRoutes(3, 4));
        }
    }

}
