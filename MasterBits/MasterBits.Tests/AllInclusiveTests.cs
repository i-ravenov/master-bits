using System;
using System.Collections.Generic;
using MySolution;
using NUnit.Framework;

[TestFixture]
public static class RotationsTests
{

    private static void Testing(Boolean actual, Boolean expected)
    {
        Assert.AreEqual(expected, actual);
    }
    [Test]
    public static void Test1()
    {
        Console.WriteLine("Basic Tests ContainAllRots");
        List<string> a = new List<string>() { "bsjq", "qbsj", "sjqb", "twZNsslC", "jqbs" };
        Testing(Rotations.ContainAllRots("bsjq", a), true);
        a = new List<string>() { };
        Testing(Rotations.ContainAllRots("", a), true);
        a = new List<string>() { "bsjq", "qbsj" };
        Testing(Rotations.ContainAllRots("", a), true);
        a = new List<string>() { "TzYxlgfnhf", "yqVAuoLjMLy", "BhRXjYA", "YABhRXj", "hRXjYAB", "jYABhRX", "XjYABhR", "ABhRXjY" };
        Testing(Rotations.ContainAllRots("XjYABhR", a), false);
    }
}