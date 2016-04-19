using System;
using System.Numerics;
using MasterBits;
using NUnit.Framework;

namespace MasterBits
{

    [TestFixture]
    public static class EasylineTests
    {
        private static void testing(BigInteger actual, BigInteger expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void Test()
        {
            Console.WriteLine("Fixed Tests");
            testing(Easyline.EasyLine(0), BigInteger.Parse("1"));
            testing(Easyline.EasyLine(1), BigInteger.Parse("2"));
            testing(Easyline.EasyLine(7), BigInteger.Parse("3432"));
            testing(Easyline.EasyLine(13), BigInteger.Parse("10400600"));
            testing(Easyline.EasyLine(17), BigInteger.Parse("2333606220"));
            testing(Easyline.EasyLine(19), BigInteger.Parse("35345263800"));
        }
    }
}