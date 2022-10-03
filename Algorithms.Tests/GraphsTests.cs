using FluentAssertions;
using NUnit.Framework;

namespace Algorithms.Tests;

[TestFixture]
public class GraphsTests
{
    [TestCaseSource(nameof(TestCases))]
    public void BFS_Tests(Dictionary<string, string[]> dict, string start, bool result)
    {
        Graphs.BFS(dict, start).Should().Be(result);
    }

    [TestCaseSource(nameof(TestCases))]
    public void DFS_Tests(Dictionary<string, string[]> dict, string start, bool result)
    {
        Graphs.DFS(dict, start).Should().Be(result);
    }

    [TestCaseSource(nameof(TestCases))]
    public void DFS_Recursive_Tests(Dictionary<string, string[]> dict, string start, bool result)
    {
        Graphs.DFS_Recursive(dict, start).Should().Be(result);
    }

    private static object[] TestCases =
    {
        new object[]
        {
            new Dictionary<string, string[]>
            {
                { "Petr", new[] { "Luke" } },
                { "Luke", new[] { "Petr" } }
            },
            "Petr", false
        },
        new object[]
        {
            new Dictionary<string, string[]>
            {
                { "Petr", new[] { "Luke" } },
                { "Luke", new[] { "John" } },
                { "John", new[] { "Adam" } }
            },
            "Petr", true
        },
        new object[]
        {
            new Dictionary<string, string[]>
            {
                { "Petr", new[] { "Luke", "John" } },
                { "Luke", new[] { "Ivan", "Rosalie", "Bill" } },
                { "John", new string[] { } },
                { "Ivan", new string[] { } },
                { "Rosalie", new[] { "John" } },
                { "Bill", new string[] { } }
            },
            "Petr", false
        },
        new object[]
        {
            new Dictionary<string, string[]>
            {
                { "Petr", new[] { "Luke", "John" } },
                { "Luke", new[] { "Ivan", "Rosalie", "Bill" } },
                { "John", new string[] { } },
                { "Ivan", new string[] { } },
                { "Rosalie", new[] { "Adam" } },
                { "Bill", new string[] { } }
            },
            "Petr", true
        },
        new object[] { new Dictionary<string, string[]> { { "Petr", new[] { "Adam" } } }, "Petr", true },
    };
}