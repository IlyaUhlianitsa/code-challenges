using FluentAssertions;
using NUnit.Framework;

namespace Interviews.Tests;

[TestFixture]
public class TuringTests
{
    [TestCaseSource(nameof(FindMaxUniqueValueTestCases))]
    public void WinningGame_Tests(int[][] cards, int uniqueMax)
    {
        Turing.FindMaxUniqueValue(cards).Should().Be(uniqueMax);
    }
    
    [TestCase("ab-cd", "dc-ba")]
    [TestCase("a-bC-dEf-ghIj", "j-Ih-gfE-dCba")]
    public void ReverseOnlyLetters_Tests(string str, string result)
    {
        Turing.ReverseOnlyLetters(str).Should().Be(result);
    }

    private static object[] FindMaxUniqueValueTestCases =
    {
        new object[]
        {
            new[] { new[] { 5, 7, 8, 9, 9 }, new[] { 1, 2, 2, 4, 4, 1 } },
            8
        },
        new object[]
        {
            new[] { new[] { 1, 1, 3, 3 }, new[] { 4, 4 } },
            -1
        }
    };
}
