using FluentAssertions;
using NUnit.Framework;

namespace Algorithms.Tests;

[TestFixture]
public class StringsTests
{
    [TestCase("egg", "add", true)]
    [TestCase("foo", "bar", false)]
    public void IsIsomorphic_Tests(string s, string t, bool result)
    {
        Strings.IsIsomorphic(s, t).Should().Be(result);
    }

    [TestCase("abc", "ahbgdc", true)]
    [TestCase("axc", "ahbgdc", false)]
    [TestCase("acb", "ahbgdc", false)]
    [TestCase("b", "c", false)]
    [TestCase("aaaaaa", "bbaaaa", false)]
    public void IsSubsequence_Tests(string s, string t, bool result)
    {
        Strings.IsSubsequence(s, t).Should().Be(result);
    }
}