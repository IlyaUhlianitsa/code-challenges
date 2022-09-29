using FluentAssertions;
using NUnit.Framework;

namespace LeetCode.Tests;

[TestFixture]
public class StringTasksTests
{
    [TestCase("egg", "add", true)]
    [TestCase("foo", "bar", false)]
    public void IsIsomorphic_Tests(string s, string t, bool result)
    {
        StringTasks.IsIsomorphic(s, t).Should().Be(result);
    }

    [TestCase("abc", "ahbgdc", true)]
    [TestCase("axc", "ahbgdc", false)]
    [TestCase("acb", "ahbgdc", false)]
    [TestCase("b", "c", false)]
    [TestCase("aaaaaa", "bbaaaa", false)]
    public void IsSubsequence_Tests(string s, string t, bool result)
    {
        StringTasks.IsSubsequence(s, t).Should().Be(result);
    }
}