using System;
using NUnit.Framework;

namespace MasterBits.Tests
{
    [TestFixture]
    public static class NoBoringTests
    {
        private static void Testing(int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void Test1()
        {
            Console.WriteLine("Basic Tests NoBoringZeros");
            Testing(NoBoring.NoBoringZeros(1450), 145);
            Testing(NoBoring.NoBoringZeros(960000), 96);
            Testing(NoBoring.NoBoringZeros(1050), 105);
            Testing(NoBoring.NoBoringZeros(-1050), -105);
        }
    }
}